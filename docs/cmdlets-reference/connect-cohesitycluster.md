---
external help file: Cohesity.Powershell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Connect-CohesityCluster

## SYNOPSIS

Connects to a Cohesity cluster and acquires an authentication token.

## SYNTAX

```text
Connect-CohesityCluster -Server <String> -Credential <PSCredential> [<CommonParameters>]
```

## DESCRIPTION

You must run this cmdlet with valid Cohesity credentials before any other Cohesity cmdlets. The subsequent Cohesity cmdlets will use this connection. The connection is valid for 24 hours.

## EXAMPLES

### EXAMPLE 1

```text
Connect-CohesityCluster -Server 192.168.1.100 -Credential (Get-Credential)
```

Connects to a Cohesity Cluster at the address "192.168.1.100" using the provided credentials.

## PARAMETERS

### -Server

The FQDN or IP address of any node in the Cohesity Cluster or Cluster VIP.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
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

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

