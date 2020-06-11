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
    [Parameter(Mandatory = $true, ParameterSetName = "ForTargetEnabled")]
    [ValidateNotNullOrEmpty()]
    [string]$ldfFolder,
    [Parameter(Mandatory = $true, ParameterSetName = "ForTargetEnabled")]
    [ValidateNotNullOrEmpty()]
    [switch]$gridViewEnabled,
    [Parameter()]
    [ValidateNotNullOrEmpty()]
    [string]$sourceInstance,
    [Parameter()]
    [ValidateNotNullOrEmpty()]
    [string[]]$sourceDBs,
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
            if($sourceInstance -and $sourceDBs) {
                [bool]$invalidDB = $false
                # Standalone processing individual database
                $searchedDBs  =.\searchDB.ps1 -vip $vip -username $username -jobName $jobName
                foreach ($item in $sourceDBs) {
                    $foundDB = $null
                    $foundDB = $searchedDBs | Where-Object{$_.sqlProtectionSource.name -eq $sourceInstance -and $_.sqlProtectionSource.databaseName -eq $item}
                    if($null -eq $foundDB) {
                        $invalidDB = $true
                        Write-host "Database not found $sourceInstance/$item" -ForegroundColor Red
                    }
                    if($null -eq $selectedDBs) {
                        $selectedDBs = @()
                    }
                    $selectedDBs += $foundDB
                }
                if($true -eq $invalidDB) {
                    write-host "Cannot proceed with invaild database(s)" -ForegroundColor Red
                    exit 0
                }
            } elseif ($sourceInstance) {
                # Standalone parallel processing all databases inside a single instance
                $searchedDBs  =.\searchDB.ps1 -vip $vip -username $username -jobName $jobName
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
                $selectedDBs = .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName
                if($gridViewEnabled) {
                    $selectedDBs = $selectedDBs | Out-GridView -PassThru
                }
                if($null -eq $selectedDBs) {
                    write-host "No database selected" -ForegroundColor Red
                    exit 0
                }
                $selectedDBs | .\parallel-process-mssql-objects.ps1 `
                 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true -targetServer $targetServer -targetInstance $targetInstance -mdfFolder $mdfFolder -ldfFolder $ldfFolder
            } else {
                write-host "Please provide target server info" -ForegroundColor Red
            }
            break
        }
    }
}
End {
}

