[CmdletBinding()]
Param(
	[Parameter(Mandatory = $false)]
	[ValidateNotNullOrEmpty()]
	[string]$OutputFolder = "..\docs\cmdlets-reference\",
	[Parameter(Mandatory = $false)]
	[ValidateNotNullOrEmpty()]
	[string]$ModuleName = "Cohesity.PowerShell"
)

Begin {
	$resp = Get-InstalledModule
	$installedPackage = $resp | Where-Object { $_.Name -contains "Cohesity.PowerShell" }
	if (-not $installedPackage) {
		$ModuleName = "Cohesity.PowerShell.Core"
		$installedPackage = $resp | Where-Object { $_.Name -contains "Cohesity.PowerShell.Core" }
	}
	if (-not $installedPackage) {
		write-output "No Cohesity module found"
		return
	}

	New-MarkdownHelp -Module $ModuleName -OutputFolder $OutputFolder  -Force -NoMetadata
}

Process {
	dir $OutputFolder -r | % { if ($_.Name -cne $_.Name.ToLower()) { ren $_.FullName $_.Name.ToLower() } }
}