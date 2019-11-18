$localRepoPath="C:\workspace\MyServer\MyServer\Packages\"
$powerShellPackage=$localRepoPath+"Cohesity.Powershell"
$powerShellCorePackage=$localRepoPath+"Cohesity.Powershell.Core"
Remove-Item -Recurse -Force $powerShellPackage
Remove-Item -Recurse -Force $powerShellCorePackage

Publish-Module -Path '.\Cohesity.Powershell\bin\Release\Cohesity.Powershell\' -Repository LocalPSRepo -NuGetApiKey 'AnyStringWillDo110' -Verbose
Publish-Module -Path '.\Cohesity.Powershell\bin\Release\Cohesity.Powershell.Core\' -Repository LocalPSRepo -NuGetApiKey 'AnyStringWillDo110Core' -Verbose