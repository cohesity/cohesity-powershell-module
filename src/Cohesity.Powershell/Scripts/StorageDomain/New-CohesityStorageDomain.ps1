function New-CohesityStorageDomain {
    <#
        .SYNOPSIS
        Request to create storage domain (view box) configuration with specified parameters.
        .DESCRIPTION
        The New-CohesityStorageDomain function is used to create storage domain (view box) using REST API with given parameters. If no parameters are specified, storage domain (view box) will be cretaed with default settings.
        .EXAMPLE
        New-CohesityStorageDomain -Name storage1
        Create storage domain (view box) with default settings.
        .EXAMPLE
        New-CohesityStorageDomain -Name storage1 -PhysicalQuota 10
        Create storage domain (view box) with specific physical quota.
        .NOTES
        Mention PhysicalQuota value in GiB unit.
        .EXAMPLE
        New-CohesityStorageDomain -Name storage1 -Deduplication true -InlineDeduplication true -Compression true -InlineCompression true -Encryption true
        Create storage domain (view box) with deduplication, Compression disabled and Encryption enabled. Based on enable/disable state of compression and encryption parameter, compression and encryption policy will be decided respectively.
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        # Determines whether the compression policy should be 'kCompressionNone' (disabled case) or 'kCompressionLow' (enabled case)
        # 'kCompressionNone' indicates that data is not compressed. 'kCompressionLow' indicates that data is compressed.
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [String]$Compression = $true,
        # If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster,
        # thus reducing the amount of storage space needed to store data.
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [String]$Deduplication = $true,
        # Specifies the encryption setting for the Storage Domain (View Box).
        # 'kEncryptionNone' (disabled case) indicates the data is not encrypted. 'kEncryptionStrong' (enabled case) indicates the data is encrypted.
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [String]$Encryption = $false,
        # Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled.
        # If on, compression occurs as the Cluster saves blocks to the Partition. If off, compression occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [String]$InlineCompression = $true,
        # Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.
        # If on, deduplication occurs as the Cluster saves blocks to the Partition. If off, deduplication occurs after the Cluster writes data to the Partition.
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [String]$InlineDeduplication = $true,
        [Parameter(Mandatory = $True)]
        # Storage domain name.
        [String]$Name,
        # Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in GiB.
        # If no value is specified,there is no limit.
        [Parameter(Mandatory = $false)]
        [Int]$PhysicalQuota = $null
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($Name)) {
            # Check if the storage domain with specified name already exist
            $domainUrl = '/irisservices/api/v1/public/viewBoxes'

            $url = $domainUrl + '?names=' + $Name + '&allUnderHierarchy=true'
            $isDomainExist = Invoke-RestApi -Method 'Get' -Uri $url

            if ($isDomainExist) {
                Write-Warning "Storage Domain with name '$Name' already exists."
                return
            }
            elseif ($Global:CohesityAPIError.StatusCode -eq 'Unauthorized') {
                return
            }

            # Get the cluster partion ID
            $clusterUrl = '/irisservices/api/v1/public/clusterPartitions'
            $clusterPartition = Invoke-RestApi -Method 'Get' -Uri $clusterUrl

            if ($clusterPartition) {
                $ClusterPartitionId = $clusterPartition[0].id
            }

            # If parameter is specified by user
            if ($Deduplication -eq $false) {
                $InlineDeduplication = $false
            }
            if ($Compression -eq $false) {
                $InlineCompression = $false
            }

            # Convert Physical quota value to bytes, if physical quota is specified by user
            $PhysicalQuotaObj = @{}
            $GibToBytes = (1024 * 1024 * 1024)

            if ($PhysicalQuota) {
                [Int64]$PhysicalQuota_bytes = ($PhysicalQuota * $GibToBytes)
                $PhysicalQuotaObj = @{hardLimitBytes = $PhysicalQuota_bytes }
            }

            $payload = @{
                name                   = $Name
                clusterPartitionId     = $ClusterPartitionId
                storagePolicy          = @{
                    deduplicationEnabled = [System.Convert]::ToBoolean($Deduplication)
                    inlineDeduplicate    = [System.Convert]::ToBoolean($InlineDeduplication)
                    inlineCompress       = [System.Convert]::ToBoolean($InlineCompression)
                    compressionPolicy    = $(if ($Compression -eq $true) { 'kCompressionLow' } else { 'kCompressionNone' })
                    encryptionPolicy     = $(if ($Encryption -eq $true) { 'kEncryptionStrong' } else { 'kEncryptionNone' })
                }
                physicalQuota          = $PhysicalQuotaObj
                defaultViewQuotaPolicy = @{}
            }
            $payloadJson = $payload | ConvertTo-Json

            # Construct URL & header
            $StorageDomain = Invoke-RestApi -Method 'Post' -Uri $domainUrl -Body $payloadJson

            if ($StorageDomain) {
                Get-CohesityStorageDomain -Names $Name
                $successMsg = "Created '$Name' Storage Domain Successfully `n $StorageDomain"
                CSLog -Message $successMsg
            }
            else {
                $errorMsg = "Failed to create storage domain '$Name'."
                Write-Error $errorMsg
                CSLog -Message $errorMsg
            }
        }
    } # End of process
} # End of function