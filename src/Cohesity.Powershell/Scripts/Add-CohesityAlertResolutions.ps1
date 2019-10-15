function Add-CohesityAlertResolutions {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [String[]]$alertIds,
        [Parameter(Mandatory = $true)]
        [String]$resolutionSummary,
        [Parameter(Mandatory = $true)]
        [String]$resolutionDetails,
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
        $url = $server + '/irisservices/api/v1/public/alertResolutions'

        $headers = @{'Authorization'='Bearer '+$token}
        $payload = @{
            alertIdList=$alertIds
            resolutionDetails=@{
                resolutionDetails=$resolutionDetails
                resolutionSummary=$resolutionSummary
            }
        }
        $payloadJson = $payload  | ConvertTo-Json
        $resp = Invoke-RestMethod -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson -SkipCertificateCheck
        $resolutionId = $resp.resolutionDetails.resolutionId
        Write-Host "Successfully created a resolution for the alert with id ="$resolutionId

    }
    End {
    }
}

Add-CohesityAlertResolutions