<#
    setProtectionExclusion.ps1 - Excludes a VM sandpit from the autoprotect feature on a Cohesity cluster

    Example usage: 
            setProtectionExclusion.ps1 -cluster 10.2.145.70 -userName cohesityadmin -userPass thepassw0rd -nodeToExclude rmavmrsoe7999
            setProtectionExclusion.ps1 -cluster 10.2.102.115 -userName admin -userPass admin -nodeToExclude "centos-server01-MKLu","copy-centos-server01","gary-flr-win2k12" -forceRefresh:$true -coolingTimeInSeconds 180
    Assumptions:
            - The node to exclude exists at the Cohesity cluster (in any protection job) with the same exact name you are passing as a parameter (fqdn, usually)
#>



[CmdletBinding()] 
param (
    [ValidateNotNullOrEmpty()][Parameter(Mandatory = $True)][string]$cluster,                                        # Cohesity cluster to connect to (DNS name or IP)
    [ValidateNotNullOrEmpty()][Parameter(Mandatory = $True)][string]$userName,                                       # Cohesity username
    [ValidateNotNullOrEmpty()][Parameter(Mandatory = $True)][string]$userPass,                                       # Cohesity password
    #[ValidateNotNullOrEmpty()][Parameter(Mandatory = $True)][System.Management.Automation.PSCredential]$credential, # Cohesity Credentials (commented out)
    [ValidateNotNullOrEmpty()][Parameter(Mandatory = $True)][string[]]$nodeToExclude,                                  # list of fqdn of the machine to be excluded from autoprotection
    [Parameter(Mandatory = $False)][bool]$forceRefresh = $True,                                                       # Allows to disable Cohesity objects refresh (default=true)
    [Parameter(Mandatory = $True)][int]$coolingTimeInSeconds                                                   # Wait for the inventory to update after executing "Update-CohesityProtectionSource"
) 

#-- Convert user/pass to credential
    $userSecure = ConvertTo-SecureString $userPass -AsPlainText -Force
    $credential = New-Object System.Management.Automation.PSCredential ($userName, $userSecure)

#-- Show some debug info & show parameters
    Write-Output "--- VARIABLES -----------------------------------------"
    Write-Output "- Cluster: $cluster"
    Write-Output "- adminName: $userName"
    Write-Output "- adminPass: $userSecure" #wont really show the pass
    Write-Output "- Credentials: $credential"
    Write-Output "- Nodes to exclude: $nodeToExclude"
    Write-Output "- Refresh: $forceRefresh"

#-- RFC1123 https://tools.ietf.org/html/rfc1123 only allows a-z0-9 and the hyphen (-) on hostnames, up to 64 characters
    #if ($nodeToExclude.length -gt 64 -or $nodeToExclude -match '[^a-zA-Z0-9\-]')
    #{
    #    Write-Output "ERROR - Unallowed machine name."
    #    Exit 99
    #}

#-- Connect to the Cohesity Cluster
    Write-Output "--- CONNECTION ---------------------------------------"
    $cohesityConn = Connect-CohesityCluster -Server $cluster -Credential $credential
    if ($null -eq $cohesityConn)
    {
        Write-Output "ERROR - Can't access Cohesity Cluster. Please check cluster availability."
        Exit 99
    }
    <# else #> Write-Output "- $cohesityConn"

#-- Refresh Cohesity's list of VMs
    Write-Output "--- COHESITY REFRESH ---------------------------------"
    if ($forceRefresh)
    {
        $refreshOutput = Get-CohesityProtectionSource -Environments KVMware | Update-CohesityProtectionSource
        Write-Output "- $refreshOutput"
        # Allow the cohesity inventory to complete the refresh process triggered by "Update-CohesityProtectionSource"
        # You can modify the time as per your requirement
        Write-Output "Request you to wait for '$coolingTimeInSeconds' seconds for the inventory to update"
        Start-Sleep -Seconds $coolingTimeInSeconds
    }
    else { Write-Output "- forceRefresh specified as FALSE. Cohesity refresh skipped." }

#-- Checking that our cluster knows our VM (checking that it exists somewhere in the cluster)
    Write-Output "--- VM ID -----------------------------------------"
    $counter=0
    $vmExclusionIds = @()
    foreach($item in $nodeToExclude) {
        $vmObject = Get-CohesityVMwareVM | Where-Object { $_.Name -ieq $item } | Select-Object -first 1
        if($vmObject.Id) 
        {
            $nodeToExcludeId = $vmObject.Id
            $vmName = $vmObject.Name
            Write-Output "'$vmName'- VM Id to exclude is: $nodeToExcludeId"
            $vmExclusionIds += $nodeToExcludeId
            $counter++
        }
        else 
        {
            Write-Output "ERROR - Couldnt find '$item' the specified node as a protected VM object on the Cohesity cluster."
            Disconnect-CohesityCluster #we make sure we free up the connection
            Exit 99
        }
    }

#-- Get list of Cohesity protection jobs, show it!
    Write-Output "--- JOB LIST -----------------------------------------"
    $cohesityJobs = Get-CohesityProtectionJob -Environments kVMware
    if ($null -eq $cohesityJobs) 
    {
        Write-Output "ERROR - Cohesity protection job list is empty."
        Disconnect-CohesityCluster #we make sure we free up the connection
        Exit 99
    }
    <# else #> Write-Output $cohesityJobs

#-- Loop around the jobs and exclude our VM from all of them
    Write-Output "--- EXCLUSION ----------------------------------------"
    $counterFail=0
    $counterOK=0
    $numberOfJobs=0
    foreach ($currentJob in $cohesityJobs) 
    {
        $currentJobName = $currentJob.name
        $numberOfJobs++
        $newExclusionList = $currentJob.ExcludeSourceIds + $vmExclusionIds
        $newExclusionList = $newExclusionList | select -Unique
        $currentJob.ExcludeSourceIds = $newExclusionList
        try
        {
            ( $currentJob | Set-CohesityProtectionJob ) 2>&1>$null
            Write-Output "OK   - $($currentJobName.PadRight(25,'.')) - $nodeToExclude excluded from job."
            $counterOK++
        }
        catch
        {
            #Write-Output "$_.Name generated an error"
            Write-Output "WARN - $($currentJobName.PadRight(25,'.')) - $nodeToExclude not found in job."
            $counterFail++
        }
    }
    Write-Output "$nodeToExclude excluded from $counterOK jobs (total jobs=$numberOfJobs) - Couldn't find the object in $counterFail jobs."
    Write-Output "------------------------------------------------------"

    Disconnect-CohesityCluster #we make sure we free up the connection


