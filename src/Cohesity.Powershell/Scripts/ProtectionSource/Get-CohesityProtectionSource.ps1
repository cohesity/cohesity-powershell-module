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
        Get-CohesityProtectionSource -Environments KPhysical
        .EXAMPLE
        Get-CohesityProtectionSource -Id 1234
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [Cohesity.Model.ProtectionSource+EnvironmentEnum[]]$Environments,
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
            if ($Environments) {
                $envList = @()
                foreach ($item in $Environments) {
                    # converting KVMware to kVMware
                    $envText = $item.ToString()
                    $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
                }
                $url += "?environments=" + ($envList -join ",")
            }
            $result = @()
            $cohesityUrl = $cohesityServer + $url
            $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
            if ($resp) {
                $result = @($resp)
                $groups = @($result | where-object { $null -eq $_.registrationInfo })
                foreach ($group in $groups) {
                    $url = '/irisservices/api/v1/public/protectionSources?id=' + $group.protectionSource.id.ToString()
                    $cohesityUrl = $cohesityServer + $url
                    $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
                    if($resp) {
                        $children = FlattenProtectionSourceNode -Nodes $resp -Type 2
                        foreach ($child in $children) {
                            if ($child.registrationInfo) {
                                $result += $child
                            }
                        }
                    }
                }
            }
            $result = @($result | where-object {
                $_.protectionSource.environment -ne "kAgent" `
                -and $_.protectionSource.environment -ne "kView" `
                -and $_.protectionSource.environment -ne "kPuppeteer" `
                -and $null -ne $_.registrationInfo
            })
            # we have to sort the rows based on protectionSource.id and remove any duplicate entries
            $result = @($result | Sort-Object -property @{expression={$_.protectionSource.id }} -Unique)
            $result
        }
    }

    End {
    }
}
