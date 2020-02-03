## Template generator
The cohesity powershell cmdlet template generator Generate-CohesityPSCmdletTemplate.ps1 is available.
It facilitates generating template code by applying specifications identified by cohesity team.
For example,
Generate-CohesityPSCmdletTemplate.ps1 -ActionType GET -Feature ProtectionJob

The above example would generate a script file with the name Get-CohesityProtectionJob.ps1 in the current folder.
