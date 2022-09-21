function Get-CohesityProtectionSource {
    <#
        .SYNOPSIS
        Gets a list of the registered protection sources filtered by the specified parameters.
        .DESCRIPTION
        If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionSource -Environments KVMware
        Returns registered protection sources that match the environment type 'kVMware'.
        .EXAMPLE
        Get-CohesityProtectionSource -Id 1234
        Returns registered protection source that matches the id 1234.
        .EXAMPLE
        Get-CohesityProtectionSource -Name 'abc'
        Returns registered protection sources that matches the name 'abc'.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Return only protection sources that match the passed in environment type.
        # For example, set this parameter to 'kVMware' to only return the VMware sources.
        [Cohesity.Model.ProtectionSource+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false)]
        # Return only the protection source that matches the Id.
        [long]$Id,
        [Parameter(Mandatory = $false)]
        # Return only the protection source that matches the sepecified object name.
        [String]$Name
    )

    Begin {
    }

    Process {
        if ($Id) {
            $PSObjectUrl = '/irisservices/api/v1/public/protectionSources/objects/' + $Id.ToString()
            $resp = Invoke-RestApi -Method Get -Uri $PSObjectUrl

            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionSource' -PassThru)
        } elseif ($Name) {
            $PSObjectUrl = '/irisservices/api/v1/public/protectionSources/registrationInfo'

            if ($Environments) {
                $envList = @()
                foreach ($item in $Environments) {
                    # converting KVMware to kVMware
                    $envText = $item.ToString()
                    $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
                }
                $PSObjectUrl += "?environments=" + ($envList -join ",")
            }

            $PSObjectResp = Invoke-RestApi -Method Get -Uri $PSObjectUrl

            if ($PSObjectResp -and $PSObjectResp.rootNodes -and $PSObjectResp.rootNodes.Length -ne 0) {
                $PSObjectResp = $PSObjectResp.rootNodes

                $PSObject = @($PSObjectResp | where-object { $Name -eq $_.rootNode.name })

                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($PSObject | Add-Member -TypeName 'System.Object#RootNode' -PassThru)
            }
        } else {
            $rootNodeUrl = '/irisservices/api/v1/public/protectionSources/rootNodes'
            if ($Environments) {
                $envList = @()
                foreach ($item in $Environments) {
                    # converting KVMware to kVMware
                    $envText = $item.ToString()
                    $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
                }
                $rootNodeUrl += "?environments=" + ($envList -join ",")
            }

            $result = @()
            $resp = Invoke-RestApi -Method Get -Uri $rootNodeUrl

            if ($resp) {
                $result = @($resp)
                $groups = @($result | where-object { $null -eq $_.registrationInfo })
                if($groups) {
                    foreach ($group in $groups) {
                        $PSurl = '/irisservices/api/v1/public/protectionSources?id=' + $group.protectionSource.id.ToString()
                        $resp = Invoke-RestApi -Method Get -Uri $PSurl

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
            }

            # Skip kView, kAgent, kPuppeteer environment types and group nodes themselves
            $result = @($result | where-object {
                $_.protectionSource.environment -ne "kAgent" `
                -and $_.protectionSource.environment -ne "kView" `
                -and $_.protectionSource.environment -ne "kPuppeteer" `
                -and $null -ne $_.registrationInfo
            })

            # Make sure each source id is only listed once as it might repeat under different environments
            # we have to sort the rows based on protectionSource.id and remove any duplicate entries
            $result = @($result | Sort-Object -property @{expression={$_.protectionSource.id }} -Unique)
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($result | Add-Member -TypeName 'System.Object#ProtectionSourceNode' -PassThru)
        }
    }

    End {
    }
}
