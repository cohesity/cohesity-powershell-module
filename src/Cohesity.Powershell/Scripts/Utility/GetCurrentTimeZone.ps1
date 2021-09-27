function GetCurrentTimeZone {
    [OutputType('System.Object')]
    [cmdletbinding()]
    param(
    )
    [string]$timeZone = "America/Los_Angeles"
    try {
        # find out if its a Windows OS
        [bool]$itsWindows = [System.Environment]::OSVersion.VersionString -like "*Windows*"
        if ($itsWindows) {
            # need to convert the time zone for windows (for consistency)
            # Ref : https://devblogs.microsoft.com/dotnet/cross-platform-time-zones-with-net-core/
            $standardTZ = [TimeZoneConverter.TZConvert]::WindowsToIana((Get-TimeZone).Id)
        }
        else {
            $standardTZ = (Get-TimeZone).Id
        }
        $timeZone = $standardTZ
    }
    catch {
        $errorMsg = "Exception : Constructing time zone, " + $_.Exception.Message
        CSLog -Message $errorMsg -Severity 3
    }
    return $timeZone
}