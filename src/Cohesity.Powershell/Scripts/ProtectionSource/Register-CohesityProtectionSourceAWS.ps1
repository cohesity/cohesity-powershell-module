function Register-CohesityProtectionSourceAWS {
  <#
        .SYNOPSIS
        Registers a new AWS protection source with the Cohesity Cluster.
        .DESCRIPTION
        Registers a new AWS protection source with the Cohesity Cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Register-CohesityProtectionSourceAWS -AccessKey "access-key" -SecretAccessKey "secret-key" -ARN "aws-arn"
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the access key.
    [String]$AccessKey,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the secret access key.
    [String]$SecretAccessKey,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the ARN.
    [String]$ARN
  )

  Begin {
    $session = CohesityUserProfile
  }

  Process {

    $token = 'Bearer ' + $session.AccessToken.AccessToken
    $headers = @{"Authorization" = $token }
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/protectionSources/register'

    $awsRegistrationParameters = @{
								  awsCredentials = @{
									accessKey = $AccessKey
									authMethod = "kUseIAMUser"
									awsType = "kIAMUser"
									iamRoleArn = $ARN
									secretAccessKey = $SecretAccessKey
								  }
								  environment = "kAWS"
								}

    $request = $awsRegistrationParameters | ConvertTo-Json
    $result = Invoke-RestApi -Method Post -Headers $headers -Uri $uri -Body $request
    $result
  }
}