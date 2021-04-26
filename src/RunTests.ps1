$ProgressPreference = "SilentlyContinue"
$currentPath=pwd
#Update the Cohesity Powershell module by reinstalling the module
UnInstall-Module -Name Cohesity.PowerShell -AllVersions  -Verbose
Install-Module -Name Cohesity.PowerShell -Repository LocalPSRepo -Verbose

#Generate the powershell sdk documentation
.\Generate-CohesityDoc.ps1


# create a fresh unit test report directory
$utReportDirectory = $currentPath.ToString() + "\UTReport\"
if ([System.IO.Directory]::Exists($utReportDirectory)) {
	Remove-Item -Path $utReportDirectory -Force -Confirm:$false -Recurse
}
# create a folder for accumulating unit test report
New-Item -Path $utReportDirectory -ItemType "directory" -Force | Out-Null


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

	$reportFileName = $utReportDirectory + "\Win-PS-" + $newTag + "-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString() + ".xml"
	#Invoke the pester
	Invoke-Pester -Tag $tags -OutputFormat  NUnitXml -OutputFile $reportFileName
}

# navigate back to powershell module
cd $currentPath

# run the report unit to convert the unit test report to a readable format
.\ReportUnit.exe $utReportDirectory $utReportDirectory