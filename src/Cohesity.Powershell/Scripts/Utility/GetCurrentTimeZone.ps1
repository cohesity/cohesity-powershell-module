function GetCurrentTimeZone {
    [OutputType('System.Object')]
    [cmdletbinding()]
    param(
    )
    [string]$timeZone = "America/Los_Angeles"
    try {
        $standardTZ = (Get-TimeZone).Id
        $current_dir = $PSScriptRoot
        $tz_file = [IO.Path]::Combine($current_dir, "timezone_mapping.json")
        # find out if its a Windows OS
        [bool]$itsWindows = [System.Environment]::OSVersion.VersionString -like "*Windows*"
        if ($itsWindows) {
            # need to convert the time zone for windows (for consistency)
            # Ref : https://devblogs.microsoft.com/dotnet/cross-platform-time-zones-with-net-core/
            # $standardTZ = [TimeZoneConverter.TZConvert]::WindowsToIana($standardTZ)
            $tz = get-content $tz_file | ConvertFrom-Json
            $time_zone = $tz.$standardTZ
            if ($time_zone -ne $null){
                $standardTZ = $tz.$standardTZ
            }
            else{
                $standardTZ = $timeZone
            }
        }
        $timeZone = $standardTZ
    }
    catch {
        $errorMsg = "Exception : Constructing time zone, " + $_.Exception.Message
        CSLog -Message $errorMsg -Severity 3
    }
    return $timeZone
}