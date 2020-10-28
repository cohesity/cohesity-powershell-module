function Get-CohesityProtectionSourceObject {
    <#
        .SYNOPSIS
        Get protection source object.
        .DESCRIPTION
        The Get-CohesityProtectionSourceObject function is used to get protection source object.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Available values for parameter 'ExcludeTypes': kVCenter, kFolder, kDatacenter, kComputeResource, kClusterComputeResource, kResourcePool, kDatastore, kHostSystem, kVirtualMachine, kVirtualApp, kStandaloneHost, kStoragePod, kNetwork, kDistributedVirtualPortgroup, kTagCategory, kTag

        Get-CohesityProtectionSourceObject -Environments kVMware -ExcludeTypes kResourcePool
        .EXAMPLE
        Get-CohesityProtectionSourceObject -Id 1234
    #>
	[OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [switch]$IncludeDatastores,
        [Parameter(Mandatory = $false)]
        [switch]$IncludeNetworks,
        [Parameter(Mandatory = $false)]
        [switch]$IncludeVMFolders,
        [Parameter(Mandatory = $false)]
        [Cohesity.Model.ProtectionSource+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false, ValueFromPipeline = $true)]
        [long]$Id,
        [Parameter(Mandatory = $false)]
        [string[]]$ExcludeTypes
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        if ($Id) {
            $cohesityUrl = $cohesityServer + '/irisservices/api/v1/public/protectionSources/objects/' + $Id.ToString()
            $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionSource' -PassThru)
        }
        else {
            $url = '/irisservices/api/v1/public/protectionSources'
            $filter = ""
            if ($IncludeDatastores.IsPresent) {
                $filter += "includeDatastores=true"
            }
            if ($IncludeNetworks.IsPresent) {
                if ($filter -ne "") {
                    $filter += "&"
                }
                $filter += "includeNetworks=true"
            }
            if ($IncludeVMFolders.IsPresent) {
                if ($filter -ne "") {
                    $filter += "&"
                }
                $filter += "includeVMFolders=true"
            }
            if ($Environments) {
                if ($filter -ne "") {
                    $filter += "&"
                }
                $envList = @()
                foreach ($item in $Environments) {
                    # converting KVMware to kVMware
                    $envText = $item.ToString()
                    $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
                }
                $filter += "environments=" + ($envList -join ",")
            }
            if ($ExcludeTypes) {
                if ($filter -ne "") {
                    $filter += "&"
                }
                $filter += "excludeTypes=" + ($ExcludeTypes -join ",")
            }
            if ($filter -ne "") {
                $url += ("?" + $filter)
            }

            $cohesityUrl = $cohesityServer + $url
            $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
            if ($resp) {
                $resp = FlattenProtectionSourceNode -Nodes $resp -Type 1
                $resp = $resp.protectionSource
                # though we get the filtered response from API but required to filter out for KSQL and KPhysical
                if($Environments) {
                    $resp = @($resp | Where-Object {$Environments -contains $_.environment})
                }
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($resp | Add-Member -TypeName 'System.Object#ProtectionSource' -PassThru)
            }
        }
    }

    End {
    }
}
