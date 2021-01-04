[CmdletBinding()]
Param(
	[Parameter(Mandatory = $true)]
	[string]$TenantName
)
Begin {
	if (-not (Test-Path -Path "$HOME/.cohesity")) {
		throw "Failed to authenticate. Please connect (using admin credentials) to the Cohesity Cluster using 'Connect-CohesityCluster'"
	}
	$session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

	$server = $session.ClusterUri

	$token = $session.Accesstoken.Accesstoken
}

Process {
	write-host "Impersonating the admin user to get the tenant resource access to '$TenantName'"
	$org = Get-CohesityOrganization -Name $TenantName

	$url = $server + '/irisservices/api/v1/public/views'
	$headers = @{
			'Authorization' = 'Bearer ' + $token
			# appending the tenant id in the header to get tenant specific objects
			'X-IMPERSONATE-TENANT-ID' = $org.tenantId
		}

	If ($PSVersionTable.PSVersion.Major -ge 6) {
		$result = Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck -Method Get -Uri $url -Headers $headers
	}
	else {
		# ignore self-signed server certificates
		New-Object System.Net.WebClient | Out-Null;
		[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
		Add-Type @"
    using System;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    public class ServerCertificateValidationCallback
    {
        public static void Ignore()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate
                (
                    Object obj,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors errors
                )
                {
                    return true;
                };
        }
    }
"@
		[ServerCertificateValidationCallback]::Ignore();
		$result = Invoke-WebRequest -UseBasicParsing -Method Get -Uri $url -Headers $headers
	}
	($result.Content | ConvertFrom-Json)
}
End {
}
