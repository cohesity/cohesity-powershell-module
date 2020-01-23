function Remove-CohesityVlan {
    <#
        .SYNOPSIS
        Removes a vlan.
        .DESCRIPTION
        The Remove-CohesityVlan function is used to delete vlan.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityVlan  -VlanId 18
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$VlanId
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
        if ($PSCmdlet.ShouldProcess($VlanId)) {
            $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId }
            if ($null -eq $vlanObject) {
                Write-Host "VLAN id  '$VlanId' does not exists"
                return
            }
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/vlans/' + $vlanObject.id
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
    
            $payload = @{
                ifaceGroupName = $vlanObject.ifaceGroupName
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Delete -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "VLAN : Failed to delete"
                Write-Host $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}