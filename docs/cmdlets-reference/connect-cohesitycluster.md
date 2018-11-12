# Connect-CohesityCluster

## SYNOPSIS
Connects to a Cohesity Cluster and acquires an authentication token.

## SYNTAX

```
Connect-CohesityCluster -Credential <PSCredential> -Server <string> [-Port <long>] [<CommonParameters>]
```

## DESCRIPTION
You must run this cmdlet with valid Cohesity credentials before any other Cohesity cmdlets.
The subsequent Cohesity cmdlets will use this connection.
The connection is valid for 24 hours.

## EXAMPLES

### EXAMPLE 1
```
Connect-CohesityCluster -Server 192.168.1.100 -Credential (Get-Credential)
```

Connects to a Cohesity Cluster at the address "192.168.1.100" using the provided credentials.

## PARAMETERS

### -Server
The FQDN or IP address of any node in the Cohesity Cluster or Cluster VIP.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Port
The port to use to connect to Cohesity Cluster.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 443
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials for the Cohesity Cluster.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
