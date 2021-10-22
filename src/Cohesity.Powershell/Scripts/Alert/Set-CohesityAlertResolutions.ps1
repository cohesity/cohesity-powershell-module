function Set-CohesityAlertResolutions {
    <#
        .SYNOPSIS
        Creates or updates an alert resolution.
        .DESCRIPTION
        Creates or updates an alert resolution by executing the commandlet individually or using piped commandlet.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityAlertResolutions -AlertIds 2286917:1574404721769725,2285865:1574389202182867
        .EXAMPLE
        Set-CohesityAlertResolutions -ResolutionId 2684117 -AlertIds 2286917:1574404721769725,2285865:1574389202182867
        .EXAMPLE
        Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions
        .EXAMPLE
        Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions -ResolutionId 2684117
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # The resolution id is used to update the alert resolutions.
        $ResolutionId = $null,
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $True)]
        # Specifies an array of protection job run ids.
        [alias("Id")][string[]]$AlertIds,
        [Parameter(Mandatory = $false)]
        # Resolution summary.
        $ResolutionSummary = $null,
        [Parameter(Mandatory = $false)]
        # Describe the resolution.
        $ResolutionDetails = $null
    )
    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($AlertIds)) {
            if ($null -eq $ResolutionId) {
                if ($null -eq $ResolutionSummary) {
                    $ResolutionSummary = "Resolved alerts through powershell cmdlets" #this is a mandatory field in the payload
                }
                $url = '/irisservices/api/v1/public/alertResolutions'

                $payload = @{
                    alertIdList       = @($AlertIds)
                    resolutionDetails = @{
                        resolutionDetails = $ResolutionDetails
                        resolutionSummary = $ResolutionSummary
                    }
                }
                $payloadJson = $payload  | ConvertTo-Json
                $resp = Invoke-RestApi -Method 'Post' -Uri $url -Body $payloadJson
                Write-Output "Successfully created, the resolution id ="$resp.resolutionDetails.resolutionId

            }
            else {
                $url = '/irisservices/api/v1/public/alertResolutions/' + $ResolutionId

                $payload = @{
                    alertIdList = @($AlertIds)
                }
                $payloadJson = $payload  | ConvertTo-Json
                $resp = Invoke-RestApi -Method 'Put' -Uri $url -Body $payloadJson
                Write-Output "Successfully updated, the resolution id ="$resp.resolutionDetails.resolutionId
            }
        }
    }
    End {
    }
}