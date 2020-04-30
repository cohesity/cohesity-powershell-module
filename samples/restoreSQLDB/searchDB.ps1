[CmdletBinding()]
param(
    [Parameter(Mandatory = $True)][string]$vip,
    [Parameter(Mandatory = $True)][string]$username,
    [Parameter()][string]$domain = 'local',
    [Parameter(Mandatory = $True)][string]$jobName,
    [Parameter()][switch]$appendSourceIP = $true
)

Begin {
    Import-Module -Name $env:cohesity"\cohesity-api.psm1"
    apiauth -vip $vip -username $username -domain $domain
    # look for the target job
    $sqlJob = api get "/public/protectionJobs?names=$jobName&environments=kSQL"
    if($null -eq $sqlJob) {
        write-host "Job details not found for $jobName"
        return
    }
    $dbList = [System.Collections.ArrayList]::new()
    foreach($item in $sqlJob.sourceSpecialParameters) {
        $dbList.AddRange($item.sqlSpecialParameters.applicationEntityIds)
    }
    $dbList = $dbList -join ','
    # search the db list details
    $dbDetails = api get "/public/protectionSources/objects?objectIds=$dbList"
    if($null -eq $dbDetails) {
        write-host "DB details could not be fetched for $dbList"
        return
    }
    if($appendSourceIP) {
        # will identify the source server IP
        $uniquParentIds = $dbDetails | select-object -Property ParentId -Unique
        $mapSQLHostIdToIP = @{}
        foreach($item in $uniquParentIds) {
            $sqlHostId = $item.parentId
            $sqlHostDetails = api get "/public/protectionSources/registrationInfo?environments=kSQL&ids=$sqlHostId"
            $mapSQLHostIdToIP[$sqlHostId] = ($sqlHostDetails.rootNodes | where-object{$_.rootNode.id -eq $sqlHostId}).rootNode.Name
        }
        # ammending the result with the source server ip
        foreach($item in $dbDetails) {
            $item | add-member -membertype noteproperty -name customHostIP -value $mapSQLHostIdToIP[$item.parentId]
        }
    }
    return $dbDetails
}

Process {
}

End{
}