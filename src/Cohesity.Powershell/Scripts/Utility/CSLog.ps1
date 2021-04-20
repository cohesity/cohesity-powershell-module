function CSLog {
    param (
        [Parameter(Mandatory)]
        [string]$Message,
        [Parameter()]
        [ValidateSet(1, 2, 3)]
        [int]$Severity = 1 ## Default to a low severity. Otherwise, override
    )
    if ($null -eq $Global:CohesityCmdletConfig) {
        return
    }
    if ($Severity -gt $Global:CohesityCmdletConfig.LogSeverity) {
        return
    }

    $line = [pscustomobject]@{
        'DateTime' = (Get-Date)
        'Message'  = $Message
        'Severity' = $Severity
    }
    $logFilePath = $Global:CohesityCmdletConfig.LogFilePath
    $logFileName = $Global:CohesityCmdletConfig.LogFileName
    $cohesityFolder = $Global:CohesityCmdletConfig.ConfigFolder
    # check if the folder exists
    if ($false -eq [System.IO.Directory]::Exists("$HOME/" + $cohesityFolder)) {
        New-Item -Path "$HOME/" -Name $cohesityFolder -ItemType "directory"
    }
    if ($null -eq $CSLogFilePath) {
        $CSLogFilePath = "$HOME/" + $cohesityFolder + "/" + $logFileName
    }
    if ($logFilePath) {
        $CSLogFilePath = $logFilePath + "/" + $logFileName
    }
    if ([System.IO.File]::Exists($CSLogFilePath)) {
        # roll over if the log file size is greater than 1MB
        if ( ((Get-Item $CSLogFilePath).length) / 1MB -gt 1) {
            $random = Get-Date -Format "MM-dd-yyyy-HH-mm-ss"
            $rollOverLogFileName = $logFileName + $random
            Rename-Item -Path $CSLogFilePath -NewName $rollOverLogFileName
        }
    }
    $line | Export-Csv -Path $CSLogFilePath -Append -NoTypeInformation
}