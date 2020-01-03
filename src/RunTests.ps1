$currentPath=pwd
#Update the Cohesity Powershell module by reinstalling the module
UnInstall-Module -Name Cohesity.PowerShell -AllVersions  -Verbose
Install-Module -Name Cohesity.PowerShell -Repository LocalPSRepo -Verbose

#Navigate to SDK-Generation folder
$targetTestPath = "..\..\sdk-generation\powershell-tests"
cd $targetTestPath

#Invoke the pester and navigate back to powershell module
Invoke-Pester -Tag UnitTest
cd $currentPath