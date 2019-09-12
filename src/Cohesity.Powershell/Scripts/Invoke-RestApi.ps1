function Invoke-RestApi
{
    [CmdletBinding()]
    param(
        $Uri,
        $Headers,
        $Method,
        $Body
    )
    
    if ($PSVersionTable.PSVersion.Major -ge 6) {
        try{
            $result =  Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck @PSBoundParameters
            } catch {
                Write-Host "Error in Cmdlet"
                $result = @{ErrorCode = $_.Exception.Response.StatusCode.value__
                             ErrorMessage =$_.Exception.Response.ReasonPhrase}
                return $result
    } else {
        Allow-SelfSignedCertificates
        $result = Invoke-WebRequest -UseBasicParsing @PSBoundParameters
    
    return ($result.Content | ConvertFrom-Json)
}
