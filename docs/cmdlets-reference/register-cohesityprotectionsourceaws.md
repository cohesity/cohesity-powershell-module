# Register-CohesityProtectionSourceAWS

## SYNOPSIS
Registers a new AWS protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceAWS [[-AccessKey] <String>] [[-AmazonResourceName] <String>]
 [[-SecretAccessKey] <String>] [[-ARN] <String>] [[-AuthMethod] <String>] [[-AWSType] <String>]
 [[-SubscriptionType] <String>] [[-FleetSubnetType] <String>] [[-FleetTags] <Object[]>] [[-AccountId] <String>]
 [[-IamRoleName] <String>] [<CommonParameters>]
```

## DESCRIPTION
Registers a new AWS protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceAWS -AccessKey "access-key" -SecretAccessKey "secret-key" -ARN "aws-arn"
```

### EXAMPLE 2
```
Register-CohesityProtectionSourceAWS -AccessKey access-key -SecretAccessKey "secret-key" -ARN "aws-arn" -FleetSubnetType kSourceVM -FleetTags $tags
```

Construct the tags as follows,
$tags = @()
$tags += @{key="bjt1";value="bjv1"}
$tags += @{key="bjt2";value="bjv2"}

### EXAMPLE 3
```
Register-CohesityProtectionSourceAWS -AuthMethod kUseIAMRole -IamRoleName "role-name" -AccountId "12321432" -FleetSubnetType kSourceVM -FleetTags $tags
```

Register AWS protection source with IAmRole authentication method, construct the tags as follows,
$tags = @()
$tags += @{key="bjt1";value="bjv1"}
$tags += @{key="bjt2";value="bjv2"}

## PARAMETERS

### -AccessKey
Specifies the access key.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AmazonResourceName
Specifies amazon resource name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecretAccessKey
Specifies the secret access key.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ARN
Specifies the ARN.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthMethod
Specifies the authentication method.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: KUseIAMUser
Accept pipeline input: False
Accept wildcard characters: False
```

### -AWSType
Specifies the AWS type.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: KIAMUser
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionType
Specifies the subscription type.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: KAWSCommercial
Accept pipeline input: False
Accept wildcard characters: False
```

### -FleetSubnetType
Fleet settings, fleet subnet type.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FleetTags
Fleet settings, fleet tags.

```yaml
Type: Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountId
AWS account id.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IamRoleName
IamRole registration name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)

