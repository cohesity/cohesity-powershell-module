$ProgressPreference = "SilentlyContinue"
$currentPath=pwd
#Update the Cohesity Powershell module by reinstalling the module
UnInstall-Module -Name Cohesity.PowerShell -AllVersions  -Verbose
Install-Module -Name Cohesity.PowerShell -Repository LocalPSRepo -Verbose

#Generate the powershell sdk documentation
.\Generate-CohesityDoc.ps1

#Navigate to SDK-Generation folder
$targetTestPath = "..\..\sdk-generation\powershell-tests"
cd $targetTestPath

# read the config files prepared for each cohesity cluster versions
$configFiles = Get-Item -Path "./config/*"
foreach($config in $configFiles) {
	$configName = ($config.BaseName -Split "config").Replace(" ","")
	$cohesityClusterVersion = $configName[1]
	$unitTest = "UnitTest"
	$tags = @($unitTest)
	[string]$newTag = ($unitTest+$cohesityClusterVersion)
	$tags += $newTag

    Copy-Item -Path $config.fullname -Destination ".\config.ini"  -Force

	#Invoke the pester
	Invoke-Pester -Tag $tags
}

# navigate back to powershell module
cd $currentPath