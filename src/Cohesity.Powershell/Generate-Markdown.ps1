param (   
    [string]$ModuleHelpXmlPath = $(throw "-ModuleHelpXmlPath is required. Please provide the path to the PowerShell Module help xml file"),
    [string]$MarkdownPath      = $(throw "-MarkdownPath is required. Please provide the path to the directory where the markdown files should be generated.")
)

if (!(Get-Module "PlatyPS")) {
    Install-Module -Name PlatyPS -Force -Scope CurrentUser
}

Import-Module "PlatyPS"
New-MarkdownHelp -MamlFile $ModuleHelpXmlPath -OutputFolder $MarkdownPath -Force
