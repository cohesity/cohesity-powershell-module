$scripts  = @( Get-ChildItem -Recurse -Path $PSScriptRoot\Scripts\*.ps1 -ErrorAction SilentlyContinue )

#Dot source the files
Foreach($script in @($scripts))
{
    Try
    {
        . $script.fullname
        Export-ModuleMember -Function $script.BaseName
    }
    Catch
    {
        Write-Error -Message "Failed to import function $($script.fullname): $_"
    }
}
# Post module installation initialize the cmdlet configuration
$config = Get-CohesityCmdletConfig
if($null -eq $config) {
    $resp = Set-CohesityCmdletConfig -LogSeverity 3
} else {
    $resp = Update-CohesityCmdletConfig -CurrentVersion $config.Version
}
