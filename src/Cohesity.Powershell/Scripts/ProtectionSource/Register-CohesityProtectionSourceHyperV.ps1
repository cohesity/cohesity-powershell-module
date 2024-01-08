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
    [System.Management.Automation.PSCredential]$Credentials,
    # Set to true, if result need to returned in object format
    [Parameter(Position = 1, HelpMessage = "Return Output as Object", Mandatory = $false)]
    [Switch]$ReturnObject
  )

  Begin {
  }

  Process {

    $uri = '/irisservices/api/v1/public/protectionSources/register'

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
    $result = Invoke-RestApi -Method Post -Uri $uri -Body $request

    if ($ReturnObject -eq $true) {
      return $result
    }
    else {
      $result  | Format-Table @{ Label = 'ID'; Expression = { $_.id }; },
      @{ Label = 'Name'; Expression = { $_.name }; Width = $columnWidth; },
      @{ Label = 'Environment'; Expression = { $_.environment }; Width = $columnWidth },
      @{ Label = 'Type'; Expression = { $_.hypervProtectionSource.type }; Width = $columnWidth }
    }
  } # End of process
} # End of function