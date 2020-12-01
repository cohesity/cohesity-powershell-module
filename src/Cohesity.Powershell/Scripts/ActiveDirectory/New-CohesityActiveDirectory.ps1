function New-CohesityActiveDirectory {
    <#
        .SYNOPSIS
        Add active directory to the cohesity cluster.
        .DESCRIPTION
        After a Cohesity Cluster has been joined to an Active Directory domain,
		the users and groups in the domain can be authenticated on the Cohesity Cluster
		using their Active Directory credentials.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test"
		.EXAMPLE
		New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force))
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the fully qualified domain name (FQDN) of an Active Directory.
        $DomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNull()]
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
		# Specifies the Active Directory credential.
        $Credential,
        [Parameter(Mandatory = $true)]
		# Array of Machine Accounts. Specifies an array of computer names used to identify the Cohesity Cluster on the domain.
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
        if ($PSCmdlet.ShouldProcess($DomainName)) {

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
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}