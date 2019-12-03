$currentPath=pwd
#Update the Cohesity Powershell module by reinstalling the module
UnInstall-Module -Name Cohesity.PowerShell.Core -AllVersions  -Verbose
Install-Module -Name Cohesity.PowerShell.Core

#Navigate to SDK-Generation folder
$targetTestPath = "..\..\sdk-generation\powershell-tests"
cd $targetTestPath

#Invoke the pester and navigate back to powershell module
Invoke-Pester -Script .\Access.Management.Tests.ps1 , .\Monitoring.Tests.ps1 , .\Remote.Cluster.Tests.ps1, .\Update.Protection.Job.Run.Tests.ps1
cd $currentPath