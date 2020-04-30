[CmdletBinding()]
param(
    [Parameter(Mandatory = $True)][string]$vip,
    [Parameter(Mandatory = $True)][string]$username,
    [Parameter()][string]$domain = 'local',
    [Parameter(Mandatory = $True)][string]$jobName,
    [Parameter()][string]$targetServer
)

.\searchDB.ps1 -vip $vip -username $username -jobName  $jobName | Out-GridView -PassThru | .\parallel-process-mssql-objects.ps1 -vip $vip -username $username  -overWrite:$true -wait:$true -progress:$true