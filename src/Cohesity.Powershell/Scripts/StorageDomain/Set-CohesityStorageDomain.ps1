function Set-CohesityStorageDomain {
    <#
        .SYNOPSIS
        Request to update storage domain (view box) configuration with specified parameters.
        .DESCRIPTION
        The Set-CohesityStorageDomain function is used to update storage domain (view box) using REST API with given parameters and returns the updated storage domain (view box).
        If name of the storage domain (view box) that to be updated is not specified, then update all the storage domain (view box) with the given parameters.
        .EXAMPLE
        Set-CohesityStorageDomain -Name storage1 -NewDomainName storage2 -PhysicalQuota 10
        Update the specified storage domain (view box) with the user provided parameter values.
        .NOTES
        Mention PhysicalQuota value in GiB unit.
        .EXAMPLE
        Set-CohesityStorageDomain -Name storage1 -Deduplication true -InlineDeduplication true -Compression true -InlineCompression true
        Update storage domain (view box) with user specified deduplication, Compression disabled. Based on enable/disable state of compression parameter, compression policy will be decided.
        .EXAMPLE
        Get-CohesityStorageDomain -Names storage1 | Set-CohesityStorageDomain -PhysicalQuota 10
        Get the list of storage domain filtered out by storage domain name through pipeline. Update the physical quota for the fetched storage domain (view box).
        .EXAMPLE
        Get-CohesityStorageDomain | Set-CohesityStorageDomain -PhysicalQuota 10
        Update all the available storage domain (view box) with the specified parameter values.
        .EXAMPLE
        Set-CohesityStorageDomain -StorageDomain $storageObject
        Update the specified storage domain (view box) object.
    #>
    [CmdletBinding(DefaultParameterSetName = 'UpdateField', SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        # Determines whether the compression policy should be 'kCompressionNone' (disabled case) or 'kCompressionLow' (enabled case)
        # 'kCompressionNone' indicates that data is not compressed. 'kCompressionLow' indicates that data is compressed.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$Compression,
        # If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster,
        # thus reducing the amount of storage space needed to store data.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$Deduplication,
        # Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.
        # If on, deduplication occurs as the Cluster saves blocks to the Partition. If off, deduplication occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$InlineDeduplication,
        # Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled.
        # If on, compression occurs as the Cluster saves blocks to the Partition. If off, compression occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')][ValidateSet("true", "false")]
        [String]$InlineCompression,
        [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true)]
        [string]$Name = $null,
        # New domain name to be update
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')]
        [string]$NewDomainName = $null,
        # Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in GiB.
        # If no value is specified,there is no limit.
        [Parameter(Mandatory = $false, ParameterSetName = 'UpdateField')]
        [Int]$PhysicalQuota = $null,
        # List of storage domain (view box), returned from 'Get-CohesityStorageDomain' commandlet
        [Parameter(ValueFromPipeline = $true)]
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
        if ($PSCmdlet.ShouldProcess($Name)) {
            $payload = $null
            $domainUrl = $server + '/irisservices/api/v1/public/viewBoxes'
            $headers = @{'Authorization' = 'Bearer ' + $token }

            # Check if the storage domain with specified name already exist
            if ($NewDomainName) {
                $url = $domainUrl + '?names=' + $NewDomainName + '&allUnderHierarchy=true'
                $isDomainExist = Invoke-RestApi -Method 'Get' -Uri $url -Headers $headers

                if ($isDomainExist) {
                    throw "Storage Domain with name '$NewDomainName' already exists."
                }
                elseif ($Global:CohesityAPIError.StatusCode -eq 'Unauthorized') {
                    return
                }
            }

            if ($null -ne $StorageDomain) {
                $domainObj = $StorageDomain
                if ($Name) {
                    $domainObj = $StorageDomain | Where-Object { $_.name -eq $Name }
                }
                else {
                    $Name = $StorageDomain.name
                }
            }

            if (!$Name) {
                Write-Warning "Please provide atleast one Storage Domain (View Box) name to update."
                return
            }

            # Construct URL & header
            $StorageDomainUrl = $server + '/irisservices/api/v1/public/viewBoxes'

            if ($null -eq $StorageDomain) {
                $getUrl = $StorageDomainUrl + '?names=' + $Name + '&allUnderHierarchy=true'
                $domainObj = Invoke-RestApi -Method 'Get' -Uri $getUrl -Headers $headers

                if ($null -eq $domainObj) {
                    if ($Global:CohesityAPIError) {
                        if ($Global:CohesityAPIError.StatusCode -eq 'NotFound') {
                            $errorMsg = "Storage domain (View Box) '$Name' doesn't exists."
                            Write-Warning $errorMsg
                        }
                        else {
                            $errorMsg = "Failed to fetch Storage Domain (View Box) information with an error : " + $Global:CohesityAPIError
                        }
                    }
                    else {
                        $errorMsg = "Storage domain (View Box) '$Name' doesn't exist."
                        Write-Warning $errorMsg
                    }
                    CSLog -Message $errorMsg
                }
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
                                    $payload.storagePolicy.compressionPolicy = $(if ($Compression -eq $true) { 'kCompressionLow' } else { 'kCompressionNone' })
                                    if ($Compression -eq $false) { $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($Compression) }
                                }
                                'InlineCompression' {
                                    $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($InlineCompression)
                                    if ($Compression -eq $false) { $payload.storagePolicy.inlineCompress = [System.Convert]::ToBoolean($Compression) }
                                }
                                'PhysicalQuota' {
                                    $GibToBytes = (1024 * 1024 * 1024)
                                    [Int64]$PhysicalQuota_bytes = ($PhysicalQuota * $GibToBytes)
                                    if ($null -eq $payload.physicalQuota) {
                                        $payload | Add-Member -MemberType NoteProperty -Name physicalQuota -Value @{}
                                    }
                                    if ($null -ne $payload.physicalQuota.hardLimitBytes) {
                                        $payload.physicalQuota.hardLimitBytes = $PhysicalQuota_bytes
                                    }
                                    else {
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
                        $StorageDomainObj
                    }
                }
            }
        }
        #To satsify ScriptAnalyzer (linting) piping the parameters to null
        $Compression | Out-Null
        $Deduplication | Out-Null
        $InlineDeduplication | Out-Null
        $InlineCompression | Out-Null
        $PhysicalQuota | Out-Null


    } # End of process
} # End of function