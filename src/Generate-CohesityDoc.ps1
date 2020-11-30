[CmdletBinding()]
Param(
	[Parameter(Mandatory = $false)]
	[ValidateNotNullOrEmpty()]
	[string]$OutputFolder = "./output"
)

Begin {
	if (!(Get-Module "PlatyPS")) {
	    Install-Module -Name PlatyPS -Force -Scope CurrentUser
	}
	Import-Module "PlatyPS"

	$moduleName = "Cohesity.PowerShell"
	$resp = Get-InstalledModule
	$installedPackage = $resp | Where-Object { $_.Name -contains "Cohesity.PowerShell" }
	if (-not $installedPackage) {
		$moduleName = "Cohesity.PowerShell.Core"
		$installedPackage = $resp | Where-Object { $_.Name -contains "Cohesity.PowerShell.Core" }
	}
	if (-not $installedPackage) {
		write-output "No Cohesity module found"
		return
	}
	New-MarkdownHelp -Module $moduleName -OutputFolder $OutputFolder  -Force -NoMetadata
	$mdFiles = @( Get-ChildItem -Recurse -Path $OutputFolder\*.md -ErrorAction SilentlyContinue )
	foreach($mdFile in $mdFiles) {
		ren $mdFile.FullName $mdFile.FullName.ToLower()
	}
}

