function Register-CohesityProtectionSourceHyperV {
    <#
        .SYNOPSIS
        Registers a new HyperV protection source with the Cohesity Cluster. The HyperV type can be a SCVMM server or HyperV Host.
        .DESCRIPTION
        Registers a new HyperV protection source with the Cohesity Cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Register-CohesityProtectionSourceHyperV -Server scvmm.example.com -Credential (Get-Credential) -HyperVType KSCVMMServer
		Registers a new SCVMM server with hostname "scvmm.example.com" with the Cohesity Cluster.
		.EXAMPLE
		Register-CohesityProtectionSourceHyperV -Server hyperV-host.example.com -HyperVType KHyperVHost
		Registers a new HyperV host "scvmm.example.com" with the Cohesity Cluster.
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Position = 0, Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
	# Hostname or IP Address for the SCVMM server.
    [String]$Server,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet('KSCVMMServer', 'KHyperVHost')]
	# Specifies HyperV type.
    $HyperVType,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
	# User credentials for the SCVMM server.
    [System.Management.Automation.PSCredential]$Credentials
  )

  Begin {
    if (-not (Test-Path -Path "$HOME/.cohesity")) {
      throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
  }

  Process {

    $token = 'Bearer ' + $session.AccessToken.AccessToken
    $headers = @{"Authorization" = $token }
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/protectionSources/register'

    if ($HyperVType -eq 'KSCVMMServer') {
      $reqParameters = @{
        environment = "kHyperV"
        username    = $Credentials.UserName
        password    = $Credentials.GetNetworkCredential().Password
        endpoint    = $Server
        hyperVType  = "kSCVMMServer"
      }
    }
    else {
      $reqParameters = @{
        environment = "kHyperV"
        endpoint    = $Server
        hyperVType  = "kStandaloneHost"
      }
    }

    $columnWidth = 20
    $request = $reqParameters | ConvertTo-Json
    Invoke-RestApi -Method Post -Headers $headers -Uri $uri -Body $request |
    Format-Table @{ Label = 'ID'; Expression = { $_.id }; },
    @{ Label = 'Name'; Expression = { $_.name }; Width = $columnWidth; },
    @{ Label = 'Environment'; Expression = { $_.environment }; Width = $columnWidth },
    @{ Label = 'Type'; Expression = { $_.hypervProtectionSource.type }; Width = $columnWidth }
  } # End of process
} # End of function
