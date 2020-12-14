function ConstructResponseWithStatus {
    [OutputType('System.Object')]
    [cmdletbinding()]
    param(
        [Parameter(Mandatory = $true)]
        $APIResponse
    )
    $result = @{
        # The HTTP response code
        StatusCode   = 0
        # The error message from the cohesity cluster
        ErrorMessage = "SUCCESS"
        # The json object for a successful API request call
        ResponseJsonObject = "{}"
        # Additional information for caller to know about the powershell framework error/exception
        FrameworkError = $null
    }
    # As per recommendation from powershell team, https://github.com/PowerShell/PowerShell/issues/9009
    if ($APIResponse.Exception) {
        $result.StatusCode = $APIResponse.Exception.Response.StatusCode.value__
        $result.ErrorMessage = $APIResponse.ErrorDetails.Message
        $result.FrameworkError = $APIResponse
    }
    else {
        $result.StatusCode = $APIResponse.StatusCode
        $result.ResponseJsonObject = ($APIResponse.Content | ConvertFrom-Json)
    }
    $result
}