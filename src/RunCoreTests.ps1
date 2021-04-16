$ProgressPreference = "SilentlyContinue"
$currentPath=pwd
#Update the Cohesity Powershell module by reinstalling the module
UnInstall-Module -Name Cohesity.PowerShell.Core -AllVersions  -Verbose
Install-Module -Name Cohesity.PowerShell.Core -Repository LocalPSRepo -Verbose


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

	$reportFileName = $currentPath.ToString() + "\Win-PS-Core-" + $newTag + "-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString() + ".xml"
	#Invoke the pester
	Invoke-Pester -Tag $tags -OutputFormat  NUnitXml -OutputFile $reportFileName
}

cd $currentPath
