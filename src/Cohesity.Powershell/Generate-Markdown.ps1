# Copyright 2018 Cohesity Inc.
#
# Generate-Markdown.ps1: generates markdown documentation from a module help xml file (MAML)
param (   
    [string]$ModuleHelpXmlPath = $(throw "-ModuleHelpXmlPath is required. Please provide the path to the PowerShell Module help xml file"),
    [string]$MarkdownPath      = $(throw "-MarkdownPath is required. Please provide the path to the directory where the markdown files should be generated.")
)

if (!(Get-Module "PlatyPS")) {
    Install-Module -Name PlatyPS -Force -Scope CurrentUser
}

Import-Module "PlatyPS"
New-MarkdownHelp -MamlFile $ModuleHelpXmlPath -OutputFolder $MarkdownPath -Force -NoMetadata

# Rename the file names to lower case.
dir $MarkdownPath -r | % { if ($_.Name -cne $_.Name.ToLower()) { ren $_.FullName $_.Name.ToLower() } }
