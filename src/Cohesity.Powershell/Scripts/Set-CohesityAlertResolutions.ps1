function UpdateAlertResolution($alertIds, $resolvedAlertId) {
    $url = $server + '/irisservices/api/v1/public/alertResolutions/'+$resolvedAlertId

    $headers = @{'Authorization'='Bearer '+$token}
    $payload = @{
        alertIdList=@($alertIds)
    }
    $payloadJson = $payload  | ConvertTo-Json
    $resp = Invoke-RestMethod -Method 'Put' -Uri $url -Headers $headers -Body $payloadJson -SkipCertificateCheck
    $resolutionId = $resp.resolutionDetails.resolutionId
    Write-Host "Successfully updated the resolution for the alert with id ="$resolutionId

}
function CreateAlertResolution($alertIds, $resolutionSummary, $resolutionDetails) {
    $url = $server + '/irisservices/api/v1/public/alertResolutions'

    $headers = @{'Authorization'='Bearer '+$token}
    $payload = @{
        alertIdList=@($alertIds)
        resolutionDetails=@{
            resolutionDetails=$resolutionDetails
            resolutionSummary=$resolutionSummary
        }
    }
    $payloadJson = $payload  | ConvertTo-Json
    # Write-Host $payloadJson
    $resp = Invoke-RestMethod -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson -SkipCertificateCheck
    $resolutionId = $resp.resolutionDetails.resolutionId
    Write-Host "Successfully created a resolution for the alert with id ="$resolutionId

}
function Set-CohesityAlertResolutions {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [String]$resolvedAlertId = "",
        [Parameter(Mandatory = $true,ValueFromPipelineByPropertyName=$True)]
        [alias("Id")][string[]]$alertIds,
        [Parameter(Mandatory = $false)]
        [string]$resolutionSummary = "",
        [Parameter(Mandatory = $false)]
        [string]$resolutionDetails = ""
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
        if("" -eq $resolvedAlertId) {
            if("" -eq $resolutionSummary) {
                $resolutionSummary = "Resolved alerts through powershell cmdlets" #this is a mandatory field in the payload
            }
            CreateAlertResolution $alertIds $resolutionSummary $resolutionDetails
        } else {
            UpdateAlertResolution $alertIds $resolvedAlertId
        }

    }
    End {
    }
}