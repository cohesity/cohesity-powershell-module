## Template generator
The cohesity powershell cmdlete template generator Generate-CohesityPSCmdletTemplate.ps1 is available.
It facilitates generating template code by applying specifications identified by cohesity team.
For example,
1. Generate-CohesityPSCmdletTemplate.ps1 -ActionType Get -Feature ProtectionJob
2. Generate-CohesityPSCmdletTemplate.ps1 -ActionType Get -Feature ProtectionJob -FilePath /home/Cohesity/

The first example would generate a script file with the name Get-CohesityProtectionJob.ps1 in the current folder wheras the second example would generate the file Get-CohesityProtectionJob.ps1 in "/home/Cohesity/" folder.
