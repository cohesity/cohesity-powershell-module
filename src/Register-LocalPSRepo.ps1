# Register a NuGet-based server
$registerPSRepositorySplat = @{
    Name = 'LocalPSRepo'
    SourceLocation = 'C:\Workspace\LocalRepo\LocalPSRepo\Packages\'
    ScriptSourceLocation = 'C:\Workspace\LocalRepo\LocalPSRepo\Packages\'
    InstallationPolicy = 'Trusted'
}
Register-PSRepository @registerPSRepositorySplat