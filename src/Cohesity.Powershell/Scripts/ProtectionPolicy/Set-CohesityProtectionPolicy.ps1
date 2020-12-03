function Set-CohesityProtectionPolicy {
    <#
        .SYNOPSIS
        Updates a Protection Policy.
        .DESCRIPTION
        Returns the updated Protection Policy.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityProtectionPolicy -ProtectionPolicy $policy
        Updates a Protection Policy with the specified parameters.
        .EXAMPLE
        $result = Get-CohesityProtectionPolicy -Name Test-Policy
        Set-CohesityProtectionPolicy -Names $result
        .EXAMPLE
        $result = Get-CohesityProtectionPolicy -Name Test-Policy
        $result.name = "Test-Policy-updated"
        $result | Set-CohesityProtectionPolicy
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated Protection Policy object.
        [object]$ProtectionPolicy
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $protectionPolicyName = $ProtectionPolicy.name
        if ($PSCmdlet.ShouldProcess($protectionPolicyName)) {
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $url = '/irisservices/api/v1/public/protectionPolicies/' + $ProtectionPolicy.id
            $cohesityUrl = $cohesityServer + $url
            $payloadJson = ($ProtectionPolicy | ConvertTo-Json -Depth 100)
            $resp = Invoke-RestApi -Method Put -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
            if($resp) {
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($resp | Add-Member -TypeName 'System.Object#ProtectionPolicy' -PassThru)
            }
            else {
                $errorMsg = "Protection Policy : $protectionPolicyName, Failed to update"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
