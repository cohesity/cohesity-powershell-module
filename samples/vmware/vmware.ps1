
$ErrorActionPreference = "Stop"
$VMCOUNT = 4 # Number of VMs that will be cloned from SourceVMName
### Get cohesity module directory
$PowerShellModuleVersion = Get-InstalledModule -Name Cohesity* | ForEach-Object{ $_.Version }
$cohesityPath = $env:PSModulePath.split(':')[0] + '/Cohesity.PowerShell.Core/' + $PowerShellModuleVersion +'/Scripts/Utility/'
### Import all script under utility folder
Get-ChildItem ($cohesityPath + "*.ps1")| ForEach-Object {. (Join-Path $cohesityPath $_.Name)} | Out-Null

### Read the var.json file for all the params
$filepath = Resolve-Path "vars.json"
$parameters = Get-Content $filepath.Path | ConvertFrom-Json

Write-Host "*************Let's connect to a vCenter*************" -ForegroundColor Green

### Check if vCenter Parameters are present in vars.json. If not, collect it from the user
if (([string]::IsNullOrEmpty($parameters.vCenterServer)))
{
    $vCenterServer = Read-Host " vCenterServer variable not found in vars.json. Enter it here: "  
}else {
    $vCenterServer = $parameters.vCenterServer    
}

if (([string]::IsNullOrEmpty($parameters.vCenterUserName)))
{
    $vCenterUserName = Read-Host " vCenterUserName variable not found in vars.json. Enter it here: "  
}else{
    $vCenterUserName = $parameters.vCenterUserName
}

### Collect credentials of vCenter and save it in a Secure String
$credentials= Get-Credential -UserName $vCenterUserName  -Message "Enter your vCenter password"

### Connect to vCenter to create VMs in future
$vc = Connect-VIServer -Server $vCenterServer -Credential $credentials

Write-Host "*************Connected to the vCenter**************************`n" -ForegroundColor Green

Write-Host "*************Let's clone some VMs from an existing VM*************`n" -ForegroundColor Green

### Check if VM details are present in vars.json. If not, collect it from the user
if (([string]::IsNullOrEmpty($parameters.VMPrefix)))
{
    $VMPrefix = Read-Host " VMPrefix variable not found in vars.json. It will used for VM name. Enter it here: "  
}else{
    $VMPrefix = $parameters.VMPrefix
}

if (([string]::IsNullOrEmpty($parameters.SourceVMName)))
{
    $SourceVMName = Read-Host " SourceVMName variable not found in vars.json. This VM will be cloned. Enter it here: "  
}else{
    $SourceVMName = $parameters.SourceVMName
}
 $SourceVM = Get-VM -Name $SourceVMName -Server $vc

if (([string]::IsNullOrEmpty($parameters.vCenterFolderName)))
{
    $vCenterFolderName = Read-Host " vCenterFolderName variable not found in vars.json. This is where the VMs will be created. Enter it here: "  
}else{
    $vCenterFolderName = $parameters.vCenterFolderName
}

### Array to store all VM names
$ProtectionVM = @()

### Create half the VMs
$i = 1    
$i..($VMCOUNT/2) | foreach {
    $VMName = $VMPrefix + "0" + $i # Create unique VM name
    $ProtectionVM += $VMName # Add VM to array
    Write-Host "*************Creating VM $($VMName). It might take some time*************`n" -ForegroundColor Green
    New-VM -Name $VMName -Location $vCenterFolderName -VM $SourceVM -VMHost $SourceVM.VMHost -Server $vc # Create VM
    $VMName ="" # Set this to empty so that all names are not appended
    $i+=1
}

Write-Host "*************Let's connect to a Cohesity Cluster*************`n" -ForegroundColor Green

### Check if Cohesity Cluster details are present in vars.json. If not, collect it from the user
if (([string]::IsNullOrEmpty($parameters.CohesityCluster)))
{
    $CohesityCluster = Read-Host " CohesityCluster variable not found in vars.json. Enter it here: "  
}else{
    $CohesityCluster = $parameters.CohesityCluster
}

### Check if API token is already present
if(-not (Test-Path -Path "$HOME/.cohesity"))
{
    throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
}
$session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

$server = $session.ClusterUri # API URL

$token = $session.Accesstoken.Accesstoken # API TOKEN

### Connect to Cohesity Cluster.
Connect-CohesityCluster -Server $CohesityCluster -Credential (Get-Credential -Message "Enter your Cohesity Cluster details")  

$uri = $server + '/irisservices/api/v1/public/protectionSources/rootNodes' # GET all sources
$headers = @{'Authorization'='Bearer '+$token}

### Invoke API request to Get all sources present in Cohesity Cluster
$rootnodes = Invoke-RestApi -Method 'Get' -Uri $uri -Headers $headers

### Find the source ID for this VCenter in Cohesity Cluster
foreach($node in $rootnodes){
    if($node.protectionSource.name -eq $vCenterServer){
        $vCenterSourceID = $node.protectionSource.id
        break
    }
}

### Check if this vCenter is already added as Protection Source. If not, add it
Write-Host "*************Let's check if [$($vCenterServer)] is registered as a source *************`n" -ForegroundColor Green
Get-CohesityProtectionSource | grep $vCenterServer
if($LASTEXITCODE -eq 1){
    Write-Host "*************Looks like it is not registered. Registering using provided credentials*************`n" -ForegroundColor Yellow
    $vcenter = Register-CohesityProtectionSourceVMware -Credential $credentials -Server $vCenterServer -Type KVCenter
}else{
    Write-Host "*************The provided vCenter is already registered *************`n" -ForegroundColor Green
}

### Make a refresh API call
$uri = $server + '/irisservices/api/v1/public/protectionSources/refresh/'+ $vCenterSourceID # Generate Refresh API endpoint
Invoke-RestApi -Method 'Post' -Uri $uri -Headers $headers #Refresh the source to get updated VM list

### Collect the newly created VMs SourceID to use in New Protection Job creation
$CohesityVMwareObjects = Get-CohesityVMwareVM -Names $ProtectionVM # Collect objects by names first
$CohesityVMwareObjectsIds = $CohesityVMwareObjects | ForEach-Object{ $_.Id } # Collect the object Ids now which will be Source ID

Write-Host "*************Let's add the created VMs to a Protection Job*************`n" -ForegroundColor Green

#$vms = Get-CohesityVMwareVM -ParentSourceId $vcenter.Id| Where-Object {$_.Name -match $VMPrefix}

### Check if Protection Job details are present in vars.json. If not, collect it from the user
if (([string]::IsNullOrEmpty($parameters.ProtectionJobName)))
{
    $ProtectionJobName = Read-Host " ProtectionJobName variable not found in vars.json. Enter it here: "  
}else{
    $ProtectionJobName = $parameters.ProtectionJobName
}

if (([string]::IsNullOrEmpty($parameters.ProtectionPolicyName)))
{
    $ProtectionPolicyName = Read-Host " ProtectionPolicyName variable not found in vars.json. Enter it here: "  
}else{
   $ProtectionPolicyName = $parameters.ProtectionPolicyName
}

if (([string]::IsNullOrEmpty($parameters.StorageDomainName)))
{
    $StorageDomainName = Read-Host " StorageDomainName variable not found in vars.json. Enter it here: "  
}else{
   $StorageDomainName = $parameters.StorageDomainName
}

## Create a Job using CohesityVMwareObjectsIds as SourceIDs
$OriginalJob = New-CohesityProtectionJob -Name $ProtectionJobName `
                                         -Description $ProtectionPolicyName `
                                         -PolicyName $ProtectionPolicyName `
                                         -StorageDomainName $StorageDomainName `
                                         -ParentSourceId $CohesityVMwareObjects[0].ParentId `
                                         -Environment kVMware `
                                         -SourceIds $CohesityVMwareObjectsIds

### Now we will create remaining VMs and Add it to the protection job

### Create remaining VMs
$i..$VMCOUNT | foreach {
    $VMName = $VMPrefix + "0" + $i # Create unique VM name
    $ProtectionVM += $VMName # Add VM to array
    Write-Host "*************Creating VM $($VMName). It might take some time*************`n" -ForegroundColor Green
    New-VM -Name $VMName -Location $vCenterFolderName -VM $SourceVM -VMHost $SourceVM.VMHost -Server $vc # Create VM
    $VMName ="" # Set this to empty so that all names are not appended
    $i+=1
}

### Make a refresh API call
Invoke-RestApi -Method 'Post' -Uri $uri -Headers $headers #Refresh the source to get updated VM list

### Update the protection object list with the newly created VMs
$CohesityVMwareObjects = Get-CohesityVMwareVM -Names $ProtectionVM

### Get the Ids for the updated protection object list
$CohesityVMwareObjectsIds = $CohesityVMwareObjects | ForEach-Object{ $_.Id }

### Update the original protection job object and used the Updated cmdlet
$UpdatedJob = $OriginalJob # Create a copy
$UpdatedJob.SourceIds = $CohesityVMwareObjectsIds # Update the SourceIds with the new VMs
$UpdatedJob | Set-CohesityProtectionJob # This will update the job
