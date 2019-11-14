function Invoke-RestApi
{
    [CmdletBinding()]
    param(
        $Uri,
        $Headers,
        $Method,
        $Body
    )
    If ($PSVersionTable.PSVersion.Major -ge 6) {
            $result =  Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck @PSBoundParameters
    } else {
        Allow-SelfSignedCertificates
        $result = Invoke-WebRequest -UseBasicParsing @PSBoundParameters
    }
    return ($result.Content | ConvertFrom-Json)
}

