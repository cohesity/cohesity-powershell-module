# Register-CohesityProtectionSourceO365

## SYNOPSIS
Registers a new O365 protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceO365 [-Credential] <PSCredential> [-AppId] <String> [-AppSecretKey] <String>
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new O365 protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceO365 -AppId "app1" -AppSecretKey "key" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "root", (ConvertTo-SecureString -AsPlainText "secret" -Force))
```

## PARAMETERS

### -Credential
User credentials for the O365.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppId
Specifies the app id.

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

### -AppSecretKey
Specifies the app secret key.

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

