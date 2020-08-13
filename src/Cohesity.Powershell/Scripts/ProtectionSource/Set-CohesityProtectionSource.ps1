function Set-CohesityProtectionSource {
    <#
        .SYNOPSIS
        Update a protection source.
        .DESCRIPTION
        The Set-CohesityProtectionSource function is used to update the protection source.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        $protecionSource = Get-CohesityProtectionSource -Id 121
        $protecionSource.Name = "UpdatedName"
        $protecionSource | Set-CohesityProtectionSource
    #>
    [CmdletBinding(SupportsShouldProcess = $true, ConfirmImpact = "High")]
    Param(
        [Parameter(ValueFromPipeline = $true, DontShow = $true)]
        [ValidateNotNullOrEmpty()]
        $ProtectionSourceObject
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($ProtectionSourceObject.Id)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/protectionSources/' + $ProtectionSourceObject.Id
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payloadJson = $ProtectionSourceObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Patch -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Update protection source : Failed to update"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
