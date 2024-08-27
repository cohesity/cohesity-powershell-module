$localRepoPath="C:\Workspace\LocalRepo\LocalPSRepo\Packages\"
$powerShellPackage=$localRepoPath+"Cohesity.PowerShell"
$powerShellCorePackage=$localRepoPath+"Cohesity.PowerShell.Core"
Remove-Item -Recurse -Force $powerShellPackage
Remove-Item -Recurse -Force $powerShellCorePackage

Publish-Module -Path '.\Cohesity.Powershell\bin\Release\Cohesity.PowerShell\' -Repository LocalPSRepo -NuGetApiKey 'AnyStringWillDo110' -Verbose
Publish-Module -Path '.\Cohesity.Powershell\bin\Release\Cohesity.PowerShell.Core\' -Repository LocalPSRepo -NuGetApiKey 'AnyStringWillDo110Core' -Verbose