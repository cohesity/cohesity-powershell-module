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
    [string]$mdfFolder
)

if ($targetServer) {
    .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru | `
    .\parallel-process-mssql-objects.ps1 `
     -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true -targetServer $targetServer -targetInstance $targetInstance -mdfFolder $mdfFolder
}
else {
    .\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru | `
    .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true
}
