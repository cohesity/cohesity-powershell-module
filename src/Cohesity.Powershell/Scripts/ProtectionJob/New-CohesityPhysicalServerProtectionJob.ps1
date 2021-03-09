function New-CohesityPhysicalServerProtectionJob {
    <#
        .SYNOPSIS
        Create a new protection job for Physical Server source.
        .DESCRIPTION
        The New-CohesityPhysicalServerProtectionJob function is used to create a protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityPhysicalServerProtectionJob -Name ps-block-based -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "10.2.151.120" -SourceType kPhysical
        .EXAMPLE
        New-CohesityPhysicalServerProtectionJob -Name ps-files-based -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "10.2.151.120" -SourceType kPhysicalFiles -TimeZone "Asia/Calcutta"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the name of the protection job.
        $Name,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the policy name of the protection job.
        $PolicyName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the viewbox or the storage domain name associated with the protection job.
        $StorageDomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the source name for the protection job.
        $SourceName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("kPhysical", "kPhysicalFiles")]
        # Specifies the source type of the source name.
        $SourceType,
        [Parameter(Mandatory = $false)]
        # Specifies the time zone.
        $TimeZone
    )

    Begin {
        $session = CohesityUserProfile
        $server = $session.ClusterUri
        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($SourceName)) {
            if(-not $TimeZone) {
                $TimeZone = (Get-TimeZone).Id
            }
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

            $protectionSourceObject = Get-CohesityProtectionSourceObject -Environments KPhysical, KPhysicalFiles | Where-Object { $_.name -eq $SourceName }
            if ($null -eq $protectionSourceObject) {
                Write-Output "There are no source found with the name '$SourceName'"
                return
            }
            if ("System.Array" -eq $protectionSourceObject.GetType().BaseType.ToString()) {
                # In case the name of the object is same across different registered sources
                Write-Output "There are multiple objects found for the search item, selecting the first item as source"
                $protectionSourceObject = $protectionSourceObject[0]
            }
            $parentId = $null
            $parentObject = Get-CohesityProtectionSourceObject -Environments KPhysical, KPhysicalFiles | Where-Object { $_.PhysicalProtectionSource.Type -eq "kGroup" }
            $parentId = $parentObject.Id

            $url = $server + '/irisservices/api/v1/public/protectionJobs'

            $headers = @{'Authorization' = 'Bearer ' + $token }
            $payload = @{
                name           = $Name
                policyId       = $protectionPolicyObject.Id
                _policyName    = $protectionPolicyObject.Name
                viewBoxId      = $storageDomainObject.Id
                _viewBoxName   = $storageDomainObject.Name
                timezone       = $TimeZone
                environment    = $SourceType
                sourceIds      = @($protectionSourceObject.Id)
                parentSourceId = $parentId
                startTime      = @{hour = (Get-Date).Hour; minute = (Get-Date).Minute }
            }
            if($SourceType -eq "kPhysicalFiles") {
                $bkupFilePath = "/"
                if($protectionSourceObject.PhysicalProtectionSource.HostType -eq "kWindows") {
                    $bkupFilePath = "C:\"
                }
                $filePath = @{
                    backupFilePath = $bkupFilePath
                    skipNestedVolumes = $true
                }
                $sourceSpecial = @{
                    sourceId = $protectionSourceObject.Id
                    physicalSpecialParameters = @{
                        filePaths = @($filePath)
                    }
                }
                $payload | Add-Member -MemberType NoteProperty -Name sourceSpecialParameters -Value @($sourceSpecial)
            }

            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                Write-Output "Protection job : Failed to create job for Physical Server"
                Write-Output $Global:CohesityAPIError
            }
        }
    }
    End {
    }
}