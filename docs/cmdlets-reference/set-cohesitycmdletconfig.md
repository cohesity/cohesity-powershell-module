# Set-CohesityCmdletConfig

## SYNOPSIS
Sets cohesity cmdlet configurations.

## SYNTAX

```
Set-CohesityCmdletConfig [-LogSeverity <Object>] [<CommonParameters>]

Set-CohesityCmdletConfig [-LogRequestedPayload <Object>] [<CommonParameters>]

Set-CohesityCmdletConfig [-LogResponseData <Object>] [<CommonParameters>]

Set-CohesityCmdletConfig [-LogHeaderDetail <Object>] [<CommonParameters>]

Set-CohesityCmdletConfig [-RefreshToken <Object>] [<CommonParameters>]
```

## DESCRIPTION
Sets the configuration parameters.

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
Enables the flag RefreshToken, the cmdlet framework would implicitly attempt to refresh the expired token. The user does not need to explicitly connect to the cluster post token expiry.


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## RELATED LINKS
