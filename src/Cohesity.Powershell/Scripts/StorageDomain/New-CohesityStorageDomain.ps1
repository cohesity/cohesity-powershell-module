# Request to create a Storage Domain (View Box) configuration.
#### USAGE ####
#New-CohesityStorageDomain -Name sample
#New-CohesityStorageDomain -Name sampleS -Deduplication -InlineDeduplication -InlineCompress -Encryption -ClusterPartitionName DefaultPartition
###############

function New-CohesityStorageDomain {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory=$True)]
        [string]$Name = $null,
        [Parameter(Mandatory=$False)]
        [string]$ClusterPartitionName = $null,
        #If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster,
        # thus reducing the amount of storage space needed to store data.
        [Parameter(Mandatory=$False)]
        [switch]$Deduplication,
        #Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.
        [Parameter(Mandatory=$False)]
        [switch]$InlineDeduplication,
        #Specifies if compression should occur inline (as the data is being written).
        # ‘kCompressionNone’ indicates that data is not compressed. ‘kCompressionLow’ indicates that data is compressed.
        [Parameter(Mandatory=$False)]
        [switch]$InlineCompress,
        #Specifies the encryption setting for the Storage Domain (View Box). 
        # ‘kEncryptionNone’ indicates the data is not encrypted. ‘kEncryptionStrong’ indicates the data is encrypted.
        [Parameter(Mandatory=$False)]
        [switch]$Encryption
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
        # Get the cluster partion ID
        $clusterUrl = $server + '/irisservices/api/v1/public/clusterPartitions'
        $headers = @{'Authorization' = 'Bearer ' + $token }
        $clusterPartition = Invoke-RestApi -Method 'Get' -Uri $clusterUrl -Headers $headers

        if ($clusterPartition) {
            $ClusterPartitionId = $clusterPartition[0].id
            if ($ClusterPartitionName) {
                $clusterPartition = $clusterPartition | Where-Object {$_.name -eq $ClusterPartitionName}
                $ClusterPartitionId = $(if ($clusterPartition) {$clusterPartition.id} else {$ClusterPartitionId})
            }
        }

        $payload = @{
            name                    =       $Name
            clusterPartitionId      =       $ClusterPartitionId
            storagePolicy           =       @{
                                                deduplicationEnabled    =   $Deduplication.IsPresent
                                                inlineDeduplicate       =   $InlineDeduplication.IsPresent
                                                inlineCompress          =   $InlineCompress.IsPresent
                                                compressionPolicy       =   $(if ($InlineCompress.IsPresent) {'kCompressionLow'} else {'kCompressionNone'})
                                                encryptionPolicy        =   $(if ($Encryption.IsPresent) {'kEncryptionStrong'} else {'kEncryptionNone'})
                                            }
            erasureCodingInfo       =       @(@{erasureCodingEnabled    =   $false})
            physicalQuota           =       @{}
            defaultViewQuotaPolicy  =       @{}
        }
        $payloadJson = $payload | ConvertTo-Json
        
        # Construct URL & header
        $domainUrl = $server + '/irisservices/api/v1/public/viewBoxes'
        $headers = @{'Authorization' = 'Bearer ' + $token }
        $StorageDomain = Invoke-RestApi -Method 'Post' -Uri $domainUrl -Headers $headers -Body $payloadJson

        if ($StorageDomain) {
            Write-Host "Created '$Name' Storage Domain Successfully" -ForegroundColor Green
            Get-CohesityStorageDomain -Names $Name
            $successMsg = "Created '$Name' Storage Domain Successfully `n $StorageDomain"
            CSLog -Message $successMsg
        } else {
            $errorMsg = "Failed to create storage domain '$Name'"
            Write-Error $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}