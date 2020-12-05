function New-CohesityHypervProtectionJob {
    <#
        .SYNOPSIS
        Create a new protection job for HyperV source.
        .DESCRIPTION
        The New-CohesityHypervProtectionJob function is used to create a protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityHypervProtectionJob -Name test-hyperv -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName test-vm1
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the name of the protection job.
        $Name,
        [Parameter(Mandatory = $true)]
        # Specifies the policy name of the protection job.
        $PolicyName,
        [Parameter(Mandatory = $true)]
        # Specifies the viewbox or the storage domain name associated with the protection job.
        $StorageDomainName,
        [Parameter(Mandatory = $true)]
        # Specifies the source name for the protection job.
        $SourceName
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
        if ($PSCmdlet.ShouldProcess($Name)) {
            $timeZone = Get-TimeZone
            # fix for support to v6.3 and v6.5
            $protectionPolicyObject = Get-CohesityProtectionPolicy -Names $PolicyName | Where-Object { $_.name -eq $PolicyName }
            if ($null -eq $protectionPolicyObject) {
                Write-Output "Incorrect protection policy name '$PolicyName'"
                return
            }

            $storageDomainObject = Get-CohesityStorageDomain | Where-Object { $_.name -eq $StorageDomainName }
            if ($null -eq $storageDomainObject) {
                Write-Output "Incorrect storage domain name '$StorageDomainName'"
                return
            }

            $protectionSourceObject = Get-CohesityProtectionSourceObject | Where-Object { $_.name -eq $SourceName }
            if ($null -eq $protectionSourceObject) {
                Write-Output "There are no source found with the name '$SourceName'"
                return
            }
            if ("System.Array" -eq $protectionSourceObject.GetType().BaseType.ToString()) {
                # In case the name of the object is same across different registered sources
                Write-Output "There are multiple objects found for the search item, selecting the first item as source"
                $protectionSourceObject = $protectionSourceObject[0]
            }

            $url = $server + '/irisservices/api/v1/public/protectionJobs'

            $headers = @{'Authorization' = 'Bearer ' + $token }
            $payload = @{
                name           = $Name
                policyId       = $protectionPolicyObject.Id
                _policyName    = $protectionPolicyObject.Name
                viewBoxId      = $storageDomainObject.Id
                _viewBoxName   = $storageDomainObject.Name
                timezone       = $timeZone.Id
                environment    = "kHyperVVSS"
                sourceIds      = @($protectionSourceObject.Id)
                parentSourceId = $protectionSourceObject.ParentId
                startTime      = @{hour = (Get-Date).Hour; minute = (Get-Date).Minute }
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
            if ($resp) {
                Start-CohesityProtectionJob -Id $resp.Id | Out-Null
                $resp
            }
            else {
                Write-Output "Protection job : Failed to create job for HyperV"
                Write-Output $Global:CohesityAPIError
            }
        }
    }
    End {
    }
}