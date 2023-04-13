function Get-CohesityAgentStatus {
    <#
        .SYNOPSIS
        Get all agent status in a table view.
        .DESCRIPTION
        Get all agent status in a table view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityAgentStatus
        Get all agent status.
    #>

    Begin {
    }

    Process {

        $baseUrl = "/irisservices/api/v1/public/"

        $url = $baseUrl + "reports/agents"
        $agents = Invoke-RestApi -Method Get -Uri $url

        # Incase of any registration error, add those unhealthy source error
        # messages to the output.
        $url = $baseUrl + "protectionSources/registrationInfo?environments=kPhysical"
        $errors = @{}
            $protectionSources = Invoke-RestApi -Method Get -Uri $url
            foreach ($source in $protectionSources.rootNodes){
                $errors.add(
                    $source.rootNode.name, $source.registrationInfo.refreshErrorMessage)
            }

        foreach ($agent in $agents){
            if ($agent.healthStatus -eq "kUnHealthy"){
                $agent | Add-Member -name errorStatus -Value $errors[$agent.hostIp] -MemberType NoteProperty
            }
        }

        if ($agents -eq $Nil -or $agents.Count -eq 0) {
            Write-Output "No agent details found in the cluster."
            return
        }
        # $agents | Format-Table
        $agents
    }

    End {
    }
}