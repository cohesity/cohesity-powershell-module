function Get-CohesityProtectionSource {
    <#
        .SYNOPSIS
        Get protection source.
        .DESCRIPTION
        The Get-CohesityProtectionSource function is used to get protection source.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Available values for parameter 'Environments': kVMware, kSQL, kView, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure, kKubernetes, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase

        Get-CohesityProtectionSource -Environments kPhysical
        .EXAMPLE
        Get-CohesityProtectionSource -Id 1234
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [string[]]$Environments,
        [Parameter(Mandatory = $false)]
        [long]$Id
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
            $resp = @($resp)
            $resp
        }
        else {
            $url = '/irisservices/api/v1/public/protectionSources/rootNodes'
            $filter = ""
            if ($Environments) {
                if ($filter -ne "") {
                    $filter += "?"
                }
                $filter += "environments=" + ($Environments -join ",")
            }
            $results = @()
            $cohesityUrl = $cohesityServer + $url
            $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
            $groups = $resp | where-object{-not $_.RegistrationInfo}
            foreach ($group in $groups) {
                $url = '/irisservices/api/v1/public/protectionSources?id=' + $group.ProtectionSource.Id.ToString()
                $cohesityUrl = $cohesityServer + $url
                $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
                $children = FlattenProtectionSourceNode -Nodes $resp -Type 2
                foreach ($child in $children) {
                    if ($child.RegistrationInfo) {
                        $results += $child
                    }
                }
            }
            $results
        }
    }

    End {
    }
}
