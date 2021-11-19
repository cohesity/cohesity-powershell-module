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
        .EXAMPLE
        Register-CohesityProtectionSourceAWS -AccessKey access-key -SecretAccessKey "secret-key" -ARN "aws-arn" -FleetSubnetType kSourceVM -FleetTags $tags
        Construct the tags as follows,
        $tags = @()
        $tags += @{key="bjt1";value="bjv1"}
        $tags += @{key="bjt2";value="bjv2"}
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the access key.
    [String]$AccessKey,
    [Parameter(Mandatory = $false)]
    # Specifies amazon resource name.
    [String]$AmazonResourceName,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the secret access key.
    [String]$SecretAccessKey,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the ARN.
    [String]$ARN,
    [Parameter(Mandatory = $false)]
    [ValidateSet("kUseIAMUser", "kUseIAMRole")]
    [ValidateNotNullOrEmpty()]
    # Specifies the authentication method.
    [String]$AuthMethod = "kUseIAMUser",
    [Parameter(Mandatory = $false)]
    [ValidateSet("kIAMUser", "kRegion", "kAvailabilityZone", "kEC2Instance", "kVPC", "kSubnet", "kNetworkSecurityGroup", "kInstanceType", "kKeyPair", "kTag", "kRDSOptionGroup", "kRDSParameterGroup", "kRDSInstance", "kRDSSubnet", "kRDSTag", "kAuroraCluster")]
    [ValidateNotNullOrEmpty()]
    # Specifies the AWS type.
    [String]$AWSType = "kIAMUser",
    [Parameter(Mandatory = $false)]
    [ValidateSet("kAWSCommercial", "kAWSGovCloud")]
    [ValidateNotNullOrEmpty()]
    # Specifies the subscription type.
    [String]$SubscriptionType = "kAWSCommercial",
    [Parameter(Mandatory = $false)]
    [ValidateSet("kCluster", "kSourceVM", "kCustom")]
    # Fleet settings, fleet subnet type.
    [String]$FleetSubnetType,
    [Parameter(Mandatory = $false)]
    # Fleet settings, fleet tags.
    [object[]]$FleetTags
  )

  Begin {
  }

  Process {

    $uri = '/irisservices/api/v1/public/protectionSources/register'

    $awsRegistrationParameters = @{
      awsCredentials = @{
        accessKey          = $AccessKey
        amazonResourceName = $AmazonResourceName
        authMethod         = $AuthMethod
        awsType            = $AWSType
        iamRoleArn         = $ARN
        secretAccessKey    = $SecretAccessKey
        subscriptionType   = $SubscriptionType
      }
      environment    = "kAWS"
    }
    if ($FleetSubnetType) {
      $awsFleetParams = @{
        fleetSubnetType = $FleetSubnetType
        fleetTags       = $FleetTags
      }
      $awsRegistrationParameters | Add-Member -NotePropertyName awsFleetParams -NotePropertyValue $awsFleetParams
    }

    $request = $awsRegistrationParameters | ConvertTo-Json -Depth 100
    $result = Invoke-RestApi -Method Post -Uri $uri -Body $request
    $result
  }
}