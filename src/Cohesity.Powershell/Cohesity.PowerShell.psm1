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