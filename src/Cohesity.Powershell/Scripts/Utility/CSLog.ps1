function CSLog
{
    param (
        [Parameter(Mandatory)]
        [string]$Message,
        
        [Parameter()]
        [ValidateSet('1','2','3')]
        [int]$Severity = 1 ## Default to a low severity. Otherwise, override
    )
    
    $line = [pscustomobject]@{
        'DateTime' = (Get-Date)
        'Message' = $Message
        'Severity' = $Severity
    }
    $logFileName = "cohesityPS.log"
    if($null -eq $CSLogFilePath) {
        $CSLogFilePath = "$HOME/" + $logFileName
    }
    if([System.IO.File]::Exists($CSLogFilePath)) {
        # roll over if the log file size is greater than 1MB
        if ( ((Get-Item $CSLogFilePath).length)/1MB -gt 1) {
            $random = Get-Date -Format "MM-dd-yyyy-HH-mm-ss"
            $rollOverLogFileName = $logFileName + $random
            Rename-Item -Path $CSLogFilePath -NewName $rollOverLogFileName
        }
    }

    $line | Export-Csv -Path $CSLogFilePath -Append -NoTypeInformation
}