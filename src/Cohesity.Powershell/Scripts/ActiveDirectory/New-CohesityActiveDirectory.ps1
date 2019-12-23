#### USAGE ####
#	********************** Using Function *********************
#   New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test"
#   New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force))
###############
function New-CohesityActiveDirectory {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $DomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNull()]
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $Credential,
        [Parameter(Mandatory = $true)]
        [string[]]$MachineAccounts
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
        $UserName = $Credential.UserName
        $PlainPassword = $Credential.GetNetworkCredential().Password

        $url = $server + '/irisservices/api/v1/public/activeDirectory'

        $headers = @{'Authorization' = 'Bearer ' + $token}
        $payload = @{
            domainName                 = $DomainName
            machineAccounts            = @($MachineAccounts)
            preferredDomainControllers = @(@{domainName = $DomainName})
            trustedDomainsEnabled      = $false
            userIdMapping              = @{ }
            userName                   = $UserName
            password                   = $PlainPassword
        }
        $payloadJson = $payload | ConvertTo-Json
        $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Failed to create, active directory configuration"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}