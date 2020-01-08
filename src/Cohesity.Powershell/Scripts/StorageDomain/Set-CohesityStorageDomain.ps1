function Set-CohesityStorageDomain {
    <#
        .SYNOPSIS
        Request to update storage domain (view box) configuration with specified parameters.
        .DESCRIPTION
        The Set-CohesityStorageDomain function is used to update storage domain (view box) using REST API with given parameters and returns the updated storage domain (view box).
        If name of the storage domain (view box) that to be updated is not specified, then update all the storage domain (view box) with the given parameters.
        .EXAMPLE
        Set-CohesityStorageDomain -Name <DomainName> -NewDomainName <NewDomainName>
        Update the specified storage domain (view box) with the user provided name.
        .EXAMPLE
        Set-CohesityStorageDomain -Name <DomainName> -PhysicalQuota 20
        Update the physical quota for the specified storage domain (view box).
        .NOTES
        Mention PhysicalQuota value in GiB unit.
        .EXAMPLE
        Set-CohesityStorageDomain -Name <DomainName> -Deduplication true -InlineDeduplication false -Compression true -InlineCompression true
        Update storage domain (view box) with user specified deduplication, Compression disabled. Based on enable/disable state of compression parameter, compression policy will be decided.
        .EXAMPLE
        Get-CohesityStorageDomain | Set-CohesityStorageDomain -Name <DomainName> -PhysicalQuota 20
        Get the list of storage domain through pipeline and fetch the specified storage domain domain. Update the physical quota for the specified storage domain (view box).
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [string]$Name = $null,
        # New domain name to be update
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')]
        [string]$NewDomainName = $null,
        # If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster,
        # thus reducing the amount of storage space needed to store data.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$Deduplication = $true,
        # Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.
        # If on, deduplication occurs as the Cluster saves blocks to the Partition. If off, deduplication occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$InlineDeduplication,
        # Determines whether the compression policy should be ‘kCompressionNone’ (disabled case) or ‘kCompressionLow’ (enabled case)
        # ‘kCompressionNone’ indicates that data is not compressed. ‘kCompressionLow’ indicates that data is compressed.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$Compression,
        # Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled.
        # If on, compression occurs as the Cluster saves blocks to the Partition. If off, compression occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$InlineCompression,
        # Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in GiB.
        # If no value is specified,there is no limit.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')]
        [Int]$PhysicalQuota = $null,
        # List of storage domain (view box), returned from 'Get-CohesityStorageDomain' commandlet
        [Parameter(ValueFromPipeline = $true, DontShow = $true)]
		[object[]]$StorageDomain = $null
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
        $payload = $null
        if (!$Name -and $NewDomainName) {
            Write-Warning 'Cannot update entire storage domain with same domain name. Please specify any single storage domain to update with new domain name.'
            return
        }

        if ($NewDomainName) {
            # Check if the storage domain with specified name already exist
            $isDomainExist = Get-CohesityStorageDomain -Name $NewDomainName -WarningAction SilentlyContinue

            if ($isDomainExist) {
                Write-Warning "Storage Domain with name '$NewDomainName' already exists."
                return
            }
        }

        if ($null -ne $StorageDomain) {
            $domainObj = $StorageDomain
            if ($Name) {
                $domainObj = $StorageDomain | Where-Object {$_.name -eq $Name}
            }
        }

        # Construct URL & header
        $StorageDomainUrl = $server + '/irisservices/api/v1/public/viewBoxes'
        $headers = @{'Authorization' = 'Bearer ' + $token }

        if ($null -eq $StorageDomain) {
            $getUrl = $StorageDomainUrl
            if ($Name) {
                $getUrl = $getUrl + '?names=' + $Name
            }
            $domainObj = Invoke-RestApi -Method 'Get' -Uri $getUrl -Headers $headers
        }

        # Update the specified Storage domain
        if ($null -ne $domainObj) {
            $domainObj | ForEach-Object {
                $payload = $_
                # Update the payload with specified parameter values
                if ('UpdateField' -eq $PsCmdlet.ParameterSetName) {
                    $PsBoundParameters.keys | ForEach-Object {
                        switch ($_) {
                            'NewDomainName' {
                                $payload.name = $NewDomainName
                            }
                            'Deduplication' {
                                $payload.storagePolicy.deduplicationEnabled = [System.Convert]::ToBoolean($Deduplication)
                                if ($Deduplication -eq $false) { $payload.storagePolicy.inlineDeduplicate = [System.Convert]::ToBoolean($Deduplication) }
                            }
                            'InlineDeduplication' {
                                $payload.storagePolicy.inlineDeduplicate = [System.Convert]::ToBoolean($InlineDeduplicate)
                                if ($Deduplication -eq $false) { $payload.storagePolicy.inlineDeduplicate = [System.Convert]::ToBoolean($Deduplication) }
                            }
                            'Compression' {
                                $payload.storagePolicy.compressionPolicy = $(if ($Compression -eq $true) {'kCompressionLow'} else {'kCompressionNone'})
                                if ($Compression -eq $false) { $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($Compression) }
                            }
                            'InlineCompression' {
                                $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($InlineCompression)
                                if ($Compression -eq $false) { $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($Compression) }
                            }
                            'PhysicalQuota' {
                                $GibToBytes = (1024 * 1024 * 1024)
                                [Int64]$PhysicalQuota_bytes = ($PhysicalQuota * $GibToBytes)
                                if ($null -ne $payload.physicalQuota.hardLimitBytes) {
                                    $payload.physicalQuota.hardLimitBytes = $PhysicalQuota_bytes
                                } else {
                                    $payload.physicalQuota | Add-Member -MemberType NoteProperty -Name hardLimitBytes -Value $PhysicalQuota_bytes
                                }
                            }
                        }
                    }
                }

                $StorageDomainId = $payload.id
                $payloadJson = $payload | ConvertTo-Json

                $updateUrl = $StorageDomainUrl + "/" + $StorageDomainId
                $StorageDomainObj = Invoke-RestApi -Method 'Put' -Uri $updateUrl -Headers $headers -Body $payloadJson

                if ($StorageDomainObj) {
                    Write-Host "Updated '$Name' Storage Domain Successfully." -ForegroundColor Green
                    $StorageDomainObj
                }
            }
        }
    } # End of process
} # End of function