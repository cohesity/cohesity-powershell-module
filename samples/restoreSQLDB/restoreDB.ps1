[CmdletBinding(DefaultParameterSetName = "Default")]
param(
    [Parameter(Mandatory = $True)][string]$vip,
    [Parameter(Mandatory = $True)][string]$username,
    [Parameter()][string]$domain = 'local',
    [Parameter(Mandatory = $True)][string]$jobName,
    [Parameter(Mandatory = $true, ParameterSetName = "ForTargetEnabled")]
    [ValidateNotNullOrEmpty()]
    [string]$targetServer,
    [Parameter(Mandatory = $true, ParameterSetName = "ForTargetEnabled")]
    [ValidateNotNullOrEmpty()]
    [string]$targetInstance,
    [Parameter(Mandatory = $true, ParameterSetName = "ForTargetEnabled")]
    [ValidateNotNullOrEmpty()]
    [string]$mdfFolder,
    [Parameter()]
    [ValidateNotNullOrEmpty()]
    [string]$sourceInstance,
    [Parameter()]
    [ValidateNotNullOrEmpty()]
    [string]$sourceDB,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet("RESTORE-LOCAL", "RESTORE-REMOTE")]
    [string]$restoreType
)
Begin {
    write-host "Restore type selected : " $restoreType
}
Process {
    switch ($restoreType) {
        "RESTORE-LOCAL" {
            $selectedDBs = $null
            if($sourceInstance -and $sourceDB) {
                # Standalone processing individual database
                $searchedDBs  =.\searchDB.ps1 -vip $vip -username admin -jobName $jobName
                $selectedDBs = $searchedDBs | Where-Object{$_.sqlProtectionSource.name -eq $sourceInstance -and $_.sqlProtectionSource.databaseName -eq $sourceDB}
                if($null -eq $selectedDBs) {
                    write-host "Database not found $sourceInstance/$sourceDB" -ForegroundColor Red
                    exit 0
                }
            } elseif ($sourceInstance) {
                # Standalone parallel processing all databases inside a single instance
                $searchedDBs  =.\searchDB.ps1 -vip $vip -username admin -jobName $jobName
                $selectedDBs = $searchedDBs | Where-Object{$_.sqlProtectionSource.name -eq $sourceInstance}
                if($null -eq $selectedDBs) {
                    write-host "Instance not found $sourceInstance" -ForegroundColor Red
                    exit 0
                }
            } else {
                # Piped selection of db and parallel processing of selected dbs
                $selectedDBs = .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru
                if($null -eq $selectedDBs) {
                    write-host "Databases not selected" -ForegroundColor Red
                    exit 0
                }
            }
            $selectedDBs | .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true
            break
        }
        "RESTORE-REMOTE" {
            $selectedDBs = $null
            if ($targetServer) {
                # Piped selection of db and parallel processing of selected dbs on target server/instance/folder
                $selectedDBs = .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru
                if($null -eq $selectedDBs) {
                    write-host "No database selected" -ForegroundColor Red
                    exit 0
                }
                $selectedDBs | .\parallel-process-mssql-objects.ps1 `
                 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true -targetServer $targetServer -targetInstance $targetInstance -mdfFolder $mdfFolder
            } else {
                write-host "Please provide target server info" -ForegroundColor Red
            }
            break
        }
    }
}
End {
}

