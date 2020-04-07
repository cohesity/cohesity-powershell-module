[CmdletBinding()]
param (
    [Parameter(Mandatory = $True)][string]$cluster, # the cluster to connect to (DNS name or IP)
    [Parameter(Mandatory = $True)][System.Management.Automation.PSCredential]$credential, # credentials
    [Parameter(Mandatory = $True)][string]$exclusionFile = 'exclusion.txt' # file name containing list of VMs to exclude
)

# Connect to the Cohesity Cluster
Connect-CohesityCluster -Server $cluster -Credential $credential

# Read the vm names to exclude from the file
$vms = Get-Content -Path $exclusionFile

$vmExcludeIdList = @()
foreach ($vm in $vms) {
    if(![string]::IsNullOrEmpty($vm.Trim())) {
        $vmObject = Get-CohesityVMwareVM | Where-Object { $_.Name -imatch $vm }
        if($vmObject.Id) {
            $vmExcludeIdList += $vmObject.Id
        }
    }
}

# Get all VMware jobs and apply the exclude list
$jobs = Get-CohesityProtectionJob -Environments kVMware
foreach ($job in $jobs) {
    $job.ExcludeSourceIds = $vmExcludeIdList
    $job | Set-CohesityProtectionJob
}
