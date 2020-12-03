function Get-CohesityProtectionSourceObject {
    <#
        .SYNOPSIS
        Gets a list of the registered Protection Sources and their sub objects.
        .DESCRIPTION
        If no parameters are specified, all the Protection Sources and their sub objects are returned.
        Specifying additional parameters can filter the results that are returned.
        If you only want to get a specific object you can specify the -Id parameter.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionSourceObject -Environments KPhysical
        Returns all the registered protection sources and their sub objects that match the environment type 'kPhysical'.
        .EXAMPLE
        Get-CohesityProtectionSourceObject -Id 1234
        Returns only the object that matches the specified id.
        .EXAMPLE
        $sql = Get-CohesityProtectionSourceObject -Environments KSQL
        $sql | Where-Object{$_.SqlProtectionSource.Type -eq "KDatabase"}
        Get all the SQL objects and filter the array with KDatabase and KInstance to get the databases and the server instances respectively.
        .EXAMPLE
        Get-CohesityProtectionSourceObject -Environments kVMware -ExcludeTypes kResourcePool
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Set this parameter to also return kDatastore type of objects.
        # By default, datastores are not returned.
        [switch]$IncludeDatastores,
        [Parameter(Mandatory = $false)]
        # Set this parameter to also return kNetwork type of objects.
        # By default, network objects are not returned.
        [switch]$IncludeNetworks,
        [Parameter(Mandatory = $false)]
        # Set this parameter to also return kVMFolder type of objects.
        # By default, VM folder objects are not returned.
        [switch]$IncludeVMFolders,
        [Parameter(Mandatory = $false)]
        # Return only Protection Sources that match the passed in environment type.
        # For example, set this parameter to 'kVMware' to only return the Sources (and their sub objects) found in the VMware environment.
        [Cohesity.Model.ProtectionSource+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false, ValueFromPipeline = $true)]
        # Returns only the object specified by the id.
        [long]$Id,
        [Parameter(Mandatory = $false)]
        # Filter out the Object types (and their sub objects) that match the passed in types.
        # For example, set this parameter to "kResourcePool" to exclude Resource Pool Objects from being returned.
        # Available values : kVCenter, kFolder, kDatacenter, kComputeResource, kClusterComputeResource, kResourcePool, kDatastore, kHostSystem, kVirtualMachine, kVirtualApp, kStandaloneHost, kStoragePod, kNetwork, kDistributedVirtualPortgroup, kTagCategory, kTag
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
