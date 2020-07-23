function Set-CohesityAlertResolutions {
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        $ResolutionId = $null,
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $True)]
        [alias("Id")][string[]]$AlertIds,
        [Parameter(Mandatory = $false)]
        $ResolutionSummary = $null,
        [Parameter(Mandatory = $false)]
        $ResolutionDetails = $null
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
        if ($PSCmdlet.ShouldProcess($AlertIds)) {
            if ($null -eq $ResolutionId) {
                if ($null -eq $ResolutionSummary) {
                    $ResolutionSummary = "Resolved alerts through powershell cmdlets" #this is a mandatory field in the payload
                }
                $url = $server + '/irisservices/api/v1/public/alertResolutions'

                $headers = @{'Authorization' = 'Bearer ' + $token }
                $payload = @{
                    alertIdList       = @($AlertIds)
                    resolutionDetails = @{
                        resolutionDetails = $ResolutionDetails
                        resolutionSummary = $ResolutionSummary
                    }
                }
                $payloadJson = $payload  | ConvertTo-Json
                $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
                Write-Output "Successfully created, the resolution id ="$resp.resolutionDetails.resolutionId

            }
            else {
                $url = $server + '/irisservices/api/v1/public/alertResolutions/' + $ResolutionId

                $headers = @{'Authorization' = 'Bearer ' + $token }
                $payload = @{
                    alertIdList = @($AlertIds)
                }
                $payloadJson = $payload  | ConvertTo-Json
                $resp = Invoke-RestApi -Method 'Put' -Uri $url -Headers $headers -Body $payloadJson
                Write-Output "Successfully updated, the resolution id ="$resp.resolutionDetails.resolutionId
            }
        }
    }
    End {
    }
}