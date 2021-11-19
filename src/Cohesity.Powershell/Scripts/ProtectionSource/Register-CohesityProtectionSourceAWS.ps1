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
        .EXAMPLE
        Register-CohesityProtectionSourceAWS -AuthMethod kUseIAMRole -IamRoleName "role-name" -AccountId "12321432" -FleetSubnetType kSourceVM -FleetTags $tags
        Register AWS protection source with IAmRole authentication method, construct the tags as follows,
        $tags = @()
        $tags += @{key="bjt1";value="bjv1"}
        $tags += @{key="bjt2";value="bjv2"}
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    # Specifies the access key.
    [String]$AccessKey,
    [Parameter(Mandatory = $false)]
    # Specifies amazon resource name.
    [String]$AmazonResourceName,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    # Specifies the secret access key.
    [String]$SecretAccessKey,
    [Parameter(Mandatory = $false)]
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
    [object[]]$FleetTags,
    [Parameter(Mandatory = $false)]
    # AWS account id.
    [string]$AccountId,
    [Parameter(Mandatory = $false)]
    # IamRole registration name.
    [string]$IamRoleName
  )

  Begin {
  }

  Process {

    if ($AuthMethod -eq "kUseIAMUser") {
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

    } else {
        # the auth method would be kUseIAMRole
        $uri = '/irisservices/api/v1/backupsources'

        $ENTITY_TYPE = 16
        $AWS_ENTITY_TYPE = 0
        $ENTITY_INFO_TYPE = 16
        $AWS_AUTH_METHOD = 1
        $SUBSCRIPTION_TYPE = 3
        $iamRoleARN = [string]::Format("arn:aws:iam::{0}:role/{1}",$AccountId,$IamRoleName)
        $awsRegistrationParameters = @{
            entity = @{
                type = $ENTITY_TYPE
                awsEntity = @{
                    type =  $AWS_ENTITY_TYPE
                    ownerId = $AccountId
                    commonInfo = @{
                        id = $AccountId
                    }
                }
            }
            entityInfo = @{
                type = $ENTITY_INFO_TYPE
                credentials = @{
                    cloudCredentials = @{
                        awsCredentials = @{
                            authMethod = $AWS_AUTH_METHOD
                            subscriptionType = $SUBSCRIPTION_TYPE
                            iamRoleArn = $iamRoleARN
                        }
                    }
                }
            }
        }
        if ($FleetSubnetType) {
            $awsFleetParams = @{
                fleetSubnetType = $FleetSubnetType
                fleetTagVec       = $FleetTags
            }
            $awsRegistrationParameters | Add-Member -NotePropertyName awsFleetParams -NotePropertyValue $awsFleetParams
        }
    }

    $request = $awsRegistrationParameters | ConvertTo-Json -Depth 100
    $result = Invoke-RestApi -Method Post -Uri $uri -Body $request
    $result
  }
}