function New-CohesityView {
    <#
        .SYNOPSIS
        Creates a new Cohesity View.
        .DESCRIPTION
        Creates a new Cohesity View.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityView -Name 'Test-View' -AccessProtocol KS3Only -StorageDomainName 'Test-Storage-Domain'
        Creates a new Cohesity View only accessible via S3 protocol using Storage Domain with name 'Test-Storage-Domain'.
        .EXAMPLE
        Copy-CohesityView -TaskName "Task-clone-a-view" -SourceViewName "source-view" -TargetViewName "target-view" -TargetViewDescription "Create a view clone" -JobId 17955 -JobRunId 17956 -StartTime 1582878606980416
        Clones a view from a job with job run id and start time.
    #>
    [CmdletBinding(DefaultParameterSetName = "Default")]
    param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$Name,
        [Parameter(Mandatory = $false)]
        # Specifies the description for this View.
        [string]$Description,
        [Parameter(Mandatory = $false)]
        [ValidateSet("BackupTarget", "FileServices", "ObjectServices")]
        # Specifies the category of the View.
        # If not specified, default is FileServices.
        [string]$Category = "FileServices",
        [ValidateSet("All", "NFS", "NFS4", "SMB", "S3", "Swift")]
        # Specifies the supported protocols for this View.
        # If not specified, default is kAll (which means all protocols are supported) for FileShare category and kNFSOnly for BackupTarget
        [string[]]$AccessProtocols = "All",
        [Parameter(Mandatory = $false)]
        [ValidateSet("Backup Target High", "Backup Target Low", "TestAndDev High", "TestAndDev Low", "Backup Target SSD", "Backup Target Commvault", "Journaled Sequential Dump", "Backup Target Auto")]
        # Specifies the Quality of Service (QoS) Policy for this View.
        # If not specified, the default is 'Backup Target Low'
        [string]$QosPolicy = "Backup Target Low",
        [Parameter(Mandatory = $true)]
        # Specifies the Storage Domain name for this View.
        [string]$StorageDomainName,
        [Parameter(Mandatory = $false)]
        # Specifies an optional quota limit on the usage allowed for this view. This limit is specified in bytes. If no value is specified, there is no limit.
        [long]$LogicalQuotaInBytes,
        [Parameter(Mandatory = $false)]
        # Specifies if an alert should be triggered when the usage of this view exceeds this quota limit.
        # This limit is optional and is specified in bytes. If no value is specified, there is no limit.
        [long]$AlertQuotaInBytes,
        [Parameter(Mandatory = $false)]
        # Specifies whether to support case insensitive file/folder names.
        # This is not enabled by default.
        [switch]$CaseInsensitiveNames,
        [Parameter(Mandatory = $false)]
        # Specifies whether the shares from this View are browsable.
        # This is not enabled by default.
        [switch]$BrowsableShares,
        [Parameter(Mandatory = $false)]
        # Specifies whether SMB Access Based Enumeration is enabled.
        # This is not enabled by default.
        [switch]$SmbAccessBasedEnumeration,
        [Parameter(Mandatory = $false)]
        # Specifies whether inline deduplication and compression settings inherited from the Storage Domain should be disabled for this View.
        [switch]$DisableInlineDedupAndCompression
    )

    Begin {
    }

    Process {

        $storageDomainObj = Get-CohesityStorageDomain -Names $StorageDomainName
        if (-not $storageDomainObj) {
            Write-Output "Could not proceed, storage domain '$StorageDomainName' not found."
            return
        }
        $storageDomainId = $storageDomainObj.Id;

        $payload = @{
            name                        = $Name
            storageDomainId             = $storageDomainId
            category                    = $Category
            description                 = $Description
            protocolAccess              = @()
            qos                         = @{
                principalName = $QosPolicy
            }
            caseInsensitiveNamesEnabled = $CaseInsensitiveNamesEnabled.IsPresent
            enableSmbViewDiscovery      = $EnableSmbViewDiscovery.IsPresent
            storagePolicyOverride       = @{
                disableInlineDedupAndCompression = $DisableInlineDedupAndCompression.IsPresent
            }
        }

        if (("BackupTarget" -eq $Category) -and ($AccessProtocols.Length -ne 1)) {
            return "Select only one protocol for 'Backup Target' view category"
        }
        elseif (("BackupTarget" -eq $Category) -and ("All" -eq $AccessProtocols)) {
            $payload.protocolAccess += @{
                "type" = "NFS";
                "mode" = "ReadWrite"
            }
        }
        else {
            foreach ($AccessProtocol in $AccessProtocols) {
                if ($AccessProtocol -eq "All") {
                    $protocols = @("NFS", "NFS4", "SMB", "S3")

                    foreach ($protocol in $protocols) {
                        $payload.protocolAccess += @{
                            "type" = $protocol;
                            "mode" = If ("S3" -eq $protocol) { "ReadOnly" } Else { "ReadWrite" }
                        }
                    }
                }
                else {
                    $payload.protocolAccess += @{
                        "type" = $AccessProtocol;
                        "mode" = If ("S3" -eq $protocol) { "ReadOnly" } Else { "ReadWrite" }
                    }
                }
            }
        }


        if ($LogicalQuotaInBytes -or $AlertQuotaInBytes) {
            $payload.LogicalQuota = @{};

            if ($LogicalQuotaInBytes) {
                $payload.LogicalQuota.HardLimitBytes = $LogicalQuotaInBytes;
            }

            if ($AlertQuotaInBytes) {
                $payload.LogicalQuota.AlertLimitBytes = $AlertQuotaInBytes;
            }
        }

        $payloadJson = $payload | ConvertTo-Json -Depth 100

        $viewURL = '/v2/file-services/views'
        $viewResp = Invoke-RestApi -Method Post -Uri $viewURL -Body $payloadJson
        if ($viewResp) {
            $viewResp
        }
        else {
            $errorMsg = "View : Failed to create"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}