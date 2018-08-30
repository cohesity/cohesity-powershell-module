param (   
    [string]$ModuleHelpXmlPath = $(throw "-ModuleHelpXmlPath is required. Please provide the path to the PowerShell Module help xml file"),
    [string]$MarkdownPath      = $(throw "-MarkdownPath is required. Please provide the path to the directory where the markdown files should be generated.")
)

if (!(Get-Module "PlatyPS")) {
    Install-Module -Name PlatyPS -Force -Scope CurrentUser
}

Import-Module "PlatyPS"
New-MarkdownHelp -MamlFile $ModuleHelpXmlPath -OutputFolder $MarkdownPath -Force

# Rename the file names to lower case. GitBook auto-renames it this way.
dir $MarkdownPath -r | % { if ($_.Name -cne $_.Name.ToLower()) { ren $_.FullName $_.Name.ToLower() } }
