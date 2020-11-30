[CmdletBinding()]
Param(
	[Parameter(Mandatory = $false)]
	[ValidateNotNullOrEmpty()]
	[string]$OutputFolder = "./output"
)

Begin {

	New-MarkdownHelp -Module Cohesity.Powershell.Core -OutputFolder $OutputFolder -Force
	$mdFiles = @( Get-ChildItem -Recurse -Path $OutputFolder\*.md -ErrorAction SilentlyContinue )
	foreach($mdFile in $mdFiles) {
		mv $mdFile.FullName $mdFile.FullName.ToLower()
	}
}

