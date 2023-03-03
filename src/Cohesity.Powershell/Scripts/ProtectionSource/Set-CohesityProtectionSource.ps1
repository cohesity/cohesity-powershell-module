function Set-CohesityProtectionSource {
    <#
        .SYNOPSIS
        Updates the registered protection source.
        .DESCRIPTION
        If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityProtectionSource -ProtectionSourceObject $theObject
        Returns updated registered protection sources.
        .EXAMPLE
        $protecionSource = Get-CohesityProtectionSource -Id 121
        $protecionSource.Name = "UpdatedName"
        $protecionSource.Name = "UpdatedName"
        $protecionSource | Set-CohesityProtectionSource
        Returns updated registered protection sources when the object is piped.
        .EXAMPLE
        Update the credentials of a VMware Protection Source.
        $protecionSource = Get-CohesityProtectionSource -Id 1
        $protecionSource |Add-Member -Name username  -Value "Administrator" -Type NoteProperty
        $protecionSource |Add-Member -Name password  -Value "cohesity" -Type NoteProperty
        $protecionSource | Set-CohesityProtectionSource
    #>
    [CmdletBinding(SupportsShouldProcess = $true, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullOrEmpty()]
        # The protection source object, can be found from Get-CohesityProtectionSource.
        $ProtectionSourceObject
    )

    Begin {
    }

    Process {
        if(-not $ProtectionSourceObject) {
            Write-Output "Protection source object not found"
            return
        }
        if ($PSCmdlet.ShouldProcess($ProtectionSourceObject.Id)) {
            $cohesityClusterURL = '/irisservices/api/v1/public/protectionSources/' + $ProtectionSourceObject.Id
            $payloadJson = $ProtectionSourceObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Patch -Uri $cohesityClusterURL -Body $payloadJson
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
