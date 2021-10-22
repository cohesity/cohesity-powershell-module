function New-CohesityNASProtectionJob {
    <#
        .SYNOPSIS
        Create a new protection job for generic NAS source.
        .DESCRIPTION
        The New-CohesityNASProtectionJob function is used to create a generic NAS protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityNASProtectionJob -Name job-nas -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "10.14.31.60:/view1"
        Creating job for a NFS mount NAS source.
        .EXAMPLE
        New-CohesityNASProtectionJob -Name job-smb1 -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "\\10.14.31.156\view3" -TimeZone "Asia/Kolkata"
        Creating job for a SMB mount NAS source. For 'TimeZone' use (Get-TimeZone).Id to get the local time zone.
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the name of the protection job.
        [string]$Name,
        [Parameter(Mandatory = $true)]
        # Specifies the policy name of the protection job.
        [string]$PolicyName,
        [Parameter(Mandatory = $true)]
        # Specifies the viewbox or the storage domain name associated with the protection job.
        [string]$StorageDomainName,
        [Parameter(Mandatory = $true)]
        # Specifies the source name for the protection job.
        [string]$SourceName,
        [Parameter(Mandatory = $false)]
        # Specifies the time zone.
        [string]$TimeZone
    )
    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($Name)) {
            if(-not $TimeZone) {
                $TimeZone = GetCurrentTimeZone
            }
            $protectionPolicyObject = Get-CohesityProtectionPolicy -Names $PolicyName | Where-Object { $_.name -eq $PolicyName }
            if (-not $protectionPolicyObject) {
                Write-Output "Incorrect protection policy name '$PolicyName'"
                return
            }

            $storageDomainObject = Get-CohesityStorageDomain | Where-Object { $_.name -eq $StorageDomainName }
            if (-not $storageDomainObject) {
                Write-Output "Incorrect storage domain name '$StorageDomainName'"
                return
            }

            $protectionSourceObject = Get-CohesityProtectionSourceObject | Where-Object { $_.name -eq $SourceName }
            if (-not $protectionSourceObject) {
                Write-Output "There are no source found with the name '$SourceName'"
                return
            }
            $protectionSourceParentId = (Get-CohesityProtectionSourceObject -Environments KGenericNas | Where-Object {$_.nasProtectionSource.type -eq "kGroup"}).id
            if(-not $protectionSourceParentId) {
                Write-Output "Parent id not found for '$SourceName'"
                return
            }

            if ("System.Array" -eq $protectionSourceObject.GetType().BaseType.ToString()) {
                # In case the name of the object is same across different registered sources
                Write-Output "There are multiple objects found for the search item, selecting the first item as source"
                $protectionSourceObject = $protectionSourceObject[0]
            }
            $payload = @{
                name           = $Name
                policyId       = $protectionPolicyObject.Id
                viewBoxId      = $storageDomainObject.Id
                timezone       = $TimeZone
                environment    = "kGenericNas"
                environmentParameters = @{
                    nasParameters = @{
                        nasProtocol = "kNfs3"
                        continueOnError = $true
                    }
                }
                indexingPolicy = @{
                    disableIndexing = $false
                    allowPrefixes = @("/")
                }
                sourceIds      = @($protectionSourceObject.Id)
                parentSourceId = $protectionSourceParentId
                startTime      = @{hour = (Get-Date).Hour; minute = (Get-Date).Minute }
            }

            $cohesityUrl = '/irisservices/api/v1/public/protectionJobs'
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Body $payloadJson
            if ($resp) {
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($resp | Add-Member -TypeName 'System.Object#ProtectionJob' -PassThru)
            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", GenericNASProtectionJob : Failed to create."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            return
        }
    }

    End {
    }
}