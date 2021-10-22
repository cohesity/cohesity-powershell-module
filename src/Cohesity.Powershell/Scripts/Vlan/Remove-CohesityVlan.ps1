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
        .EXAMPLE
        Get-CohesityVlan -VlanId 11 | Remove-CohesityVlan
    #>
    [CmdletBinding(DefaultParameterSetName = "PipedVlanInfo", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'VlanId')]
        [ValidateNotNullOrEmpty()]
        # Specifies the Id of the Vlan.
        [int]$VlanId,
        [Parameter(Mandatory = $false, ValueFromPipeline = $True, DontShow = $True)]
        # Piped vlan info.
        $VlanInfo = $null
    )

    Begin {
    }

    Process {
        $vlanObject = $null
        if ($VlanInfo) {
            # Object sailing through the pipe
            $VlanId = $VlanInfo.id
            $vlanObject = $VlanInfo
        }
        else {
            $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId }
            if ($null -eq $vlanObject) {
                Write-Output "VLAN id  '$VlanId' does not exists"
                return
            }
        }
        if ($PSCmdlet.ShouldProcess($VlanId)) {
            $cohesityClusterURL = '/irisservices/api/v1/public/vlans/' + $vlanObject.id

            $payload = @{
                ifaceGroupName = $vlanObject.ifaceGroupName
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Delete -Uri $cohesityClusterURL -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "VLAN : Failed to delete"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}