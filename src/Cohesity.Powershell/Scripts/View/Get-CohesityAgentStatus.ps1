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

        $url = "/irisservices/api/v1/public/reports/agents"
        $agents = Invoke-RestApi -Method Get -Uri $url

        if ($agents -eq $Nil -or $agents.Count -eq 0) {
            Write-Output "No agent details found in the cluster."
            return
        }
        $agents | Format-Table
    }

    End {
    }
}