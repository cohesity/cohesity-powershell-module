[CmdletBinding()]
param(
    [Parameter(Mandatory = $True)][string]$vip,
    [Parameter(Mandatory = $True)][string]$username,
    [Parameter()][string]$domain = 'local',
    [Parameter(Mandatory = $True)][string]$jobName,
    [Parameter()][switch]$appendSourceIP = $true
)

Begin {
    # initialize the current working path
    $env:cohesity=$pwd
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

    $nonDBItems = $dbDetails | Where-Object {$_.sqlProtectionSource.type -eq "kInstance"}
    if ($null -ne $nonDBItems) {
        # we may encounter kInstance (when source is auto protected)
        $databaseIds = @()
        foreach ($item in $dbDetails) {
            if ($item.sqlProtectionSource.type -eq "kDatabase") {
                $databaseIds += $item
            }
            else {
                if ($item.sqlProtectionSource.type -eq "kInstance") {
                    $instanceId = $item.id
                    $instanceTree = api get "/public/protectionSources?id=$instanceId&environments=kSQL"
                    $databaseIds += ($instanceTree.nodes | Select-Object -ExpandProperty ProtectionSource) | Select-Object -Property id
                }
            }
        }
        # now we have the db ids
        $dbList = $databaseIds.id -join ','
        # search the db list details
        $dbDetails = api get "/public/protectionSources/objects?objectIds=$dbList"
        if ($null -eq $dbDetails) {
            write-host "DB details not found for $dbList"
            return
        }
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