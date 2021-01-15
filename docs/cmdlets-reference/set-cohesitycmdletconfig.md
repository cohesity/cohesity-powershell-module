# Set-CohesityCmdletConfig

## SYNOPSIS
Set the local configuration for cohesity powershell cmdlets.

## SYNTAX

### LogSeverity (Default)
```
Set-CohesityCmdletConfig [-LogSeverity <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### LogRequestedPayload
```
Set-CohesityCmdletConfig [-LogRequestedPayload <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### LogResponseData
```
Set-CohesityCmdletConfig [-LogResponseData <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### LogHeaderDetail
```
Set-CohesityCmdletConfig [-LogHeaderDetail <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### RefreshToken
```
Set-CohesityCmdletConfig [-RefreshToken <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Set the local configuration for cohesity powershell cmdlets.
If the logging flags are set, a log is generated in the following path $HOME/cohesity/cmdlet.log.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityCmdletConfig -LogSeverity 2
```

Enables the log severity to 2.

### EXAMPLE 2
```
Set-CohesityCmdletConfig -LogRequestedPayload $true
```

Enables the log for request payload.

### EXAMPLE 3
```
Set-CohesityCmdletConfig -LogResponseData $true
```

Enables the log for response data.

### EXAMPLE 4
```
Set-CohesityCmdletConfig -LogHeaderDetail $true
```

Enables the logs for headers.

### EXAMPLE 5
```
Set-CohesityCmdletConfig -RefreshToken $true
```

Enables the flag RefreshToken, the cmdlet framework would implicitly attempt to refresh the expired token.
The user does not need to explicitly connect to the cluster post token expiry.

## PARAMETERS

### -LogSeverity
Set the log level.

```yaml
Type: Object
Parameter Sets: LogSeverity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogRequestedPayload
not recommended, the request payload may contain passwords or key information.

```yaml
Type: Object
Parameter Sets: LogRequestedPayload
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogResponseData
Log the response data.

```yaml
Type: Object
Parameter Sets: LogResponseData
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogHeaderDetail
Log the header details.

```yaml
Type: Object
Parameter Sets: LogHeaderDetail
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -RefreshToken
If set and the token has expired, the framework would attempt refreshing the token.

```yaml
Type: Object
Parameter Sets: RefreshToken
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
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

