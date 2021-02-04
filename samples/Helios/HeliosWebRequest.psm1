
function HeliosWebRequest {
    [CmdletBinding()]
    Param(
        $Uri,
        $Method,
        $APIKey
    )
    Begin {}
    Process {
        $headers = @{'apiKey' = $APIKey }

        If ($PSVersionTable.PSVersion.Major -ge 6) {
            $result = Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck -Method $Method -Uri $Uri -Headers $headers
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
            $result = Invoke-WebRequest -UseBasicParsing -Method $Method -Uri $Uri -Headers $headers
        }

        ($result.Content | ConvertFrom-Json)
    
    }
    End {}

}

Export-ModuleMember  -Function *