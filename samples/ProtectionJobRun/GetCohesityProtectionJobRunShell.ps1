[CmdletBinding()]
Param(
	[Parameter(Mandatory = $false)]
	[switch]$OnlyReturnShellInfo
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
	$url = $server + '/irisservices/api/v1/public/protectionRuns'
	if ($OnlyReturnShellInfo.IsPresent -eq $true) {
		$url += "?onlyReturnShellInfo=true"
	}


	$headers = @{'Authorization' = 'Bearer ' + $token }

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
