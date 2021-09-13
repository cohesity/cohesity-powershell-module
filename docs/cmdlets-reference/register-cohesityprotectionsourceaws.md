# Register-CohesityProtectionSourceAWS

## SYNOPSIS
Registers a new AWS protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceAWS [-AccessKey] <String> [-SecretAccessKey] <String> [-ARN] <String>
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new AWS protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceAWS -AccessKey "access-key" -SecretAccessKey "secret-key" -ARN "aws-arn"
```

## PARAMETERS

### -AccessKey
Specifies the access key.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
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

Required: True
Position: 2
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

Required: True
Position: 3
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

