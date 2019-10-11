class AlertInfo {
    [String]$id
    [ulong]$latestTimestampUsecs
    [String]$severity
    [String]$alertState
    [String]$alertCategory
    [String]$alertCause

    AlertInfo() {}
    AlertInfo(
        [String]$id,
        [ulong]$latestTimestampUsecs,
        [String]$severity,
        [String]$alertState,
        [String]$alertCategory,
        [String]$alertCause
    ) {
        $this.id = $id
        $this.latestTimestampUsecs = $latestTimestampUsecs
        $this.severity = $severity
        $this.alertState = $alertState
        $this.alertCategory = $alertCategory
        $this.alertCause = $alertCause
    }

    [string]GetLatestTimestamp() {
        if($this.latestTimestampUsecs -eq 0) {
            return "0"
        }
        $timestampInSec = $this.latestTimestampUsecs/1000000 #the time is in micro seconds
        $ret = ([DateTimeOffset]::FromUnixTimeSeconds($timestampInSec)).DateTime.ToLocalTime()
        return $ret.ToString()
    }
}
function Get-CohesityAlerts {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [int][ValidateRange("Positive")]$MaxAlerts,
        [Parameter(Mandatory = $false)]
        [String]$server,
        [Parameter(Mandatory = $false)]
        [String]$token
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        $url = $server + '/irisservices/api/v1/public/alerts?maxAlerts='+$MaxAlerts

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck

        $alertList = New-Object System.Collections.ArrayList
        foreach($item in $resp) {
            [AlertInfo]$alert = [AlertInfo]::new($item.id,$item.latestTimestampUsecs,$item.severity,$item.alertState,$item.alertCategory,$item.alertDocument.alertCause)
            $alertList += $alert
        }

        $columnWidth = 20
        $alertList | Sort-Object  -Property alertState  -Descending |
        Format-Table @{ Label=”ID”; Expression={$_.id};},  
        @{ Label=”ALERT STATE”; Expression={$_.alertState}; Width=$columnWidth; },
        @{ Label=”ALERT CATEGORY”; Expression={$_.alertCategory}; Width=$columnWidth },
        @{ Label=”SEVERITY”; Expression={$_.severity}; Width=$columnWidth },
        @{ Label=”LATEST TIMESTAMP”; Expression={$_.GetLatestTimestamp()};Width=$columnWidth },
        @{ Label=”ALERT CAUSE”; Expression={$_.alertCause}; Width=$columnWidth }
    }
    End {
    }
}

Get-CohesityAlerts