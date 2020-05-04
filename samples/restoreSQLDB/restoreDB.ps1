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
    [string]$sourceServer,
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
            if($sourceServer -and $sourceInstance -and $sourceDB) {
                # Standalone processing individual database
                .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true `
                -sourceServer $sourceServer -sourceInstance  $sourceInstance -sourceDB $sourceDB 
            } elseif ($sourceServer -and $sourceInstance) {
                # Standalone parallel processing all databases inside a single instance
                .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true `
                -sourceServer $sourceServer -sourceInstance  $sourceInstance
            } else {
                # Piped selection of db and parallel processing of selected dbs
                .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru | `
                .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true
            }
        }
        "RESTORE-REMOTE" {
            if ($targetServer) {
                # Piped selection of db and parallel processing of selected dbs on target server/instance/folder
                .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru | `
                .\parallel-process-mssql-objects.ps1 `
                 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true -targetServer $targetServer -targetInstance $targetInstance -mdfFolder $mdfFolder
            } else {
                write-host "Please provide target server info"
            }
        }
    }
}
End {
}

