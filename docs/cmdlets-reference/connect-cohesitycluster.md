# Connect-CohesityCluster

## SYNOPSIS
Connects to a Cohesity Cluster and acquires an authentication token.

## SYNTAX

### UsingCreds (Default)
```
Connect-CohesityCluster -Server <String> [-Port <Int64>] -Credential <PSCredential> [<CommonParameters>]
```

### UsingAPIKey
```
Connect-CohesityCluster -Server <String> [-Port <Int64>] [-APIKey <String>] [<CommonParameters>]
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

### EXAMPLE 2
```
Connect-CohesityCluster -Server 192.168.1.100 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "mydomain.com\admin", (ConvertTo-SecureString -AsPlainText "p@ssword" -Force))
```

Connects to a Cohesity Cluster at the address "192.168.1.100" using the active directory user, by appending domain name(mydomain.com) to the user.

### EXAMPLE 3
```
Connect-CohesityCluster -Server 192.168.1.100 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "LOCAL\user1@tenant1", (ConvertTo-SecureString -AsPlainText "p@ssword" -Force))
```

Connects to a Cohesity Cluster at the address "192.168.1.100" for a user "user1" in the tenant "tenant1".

### EXAMPLE 4
```
Connect-CohesityCluster -Server 192.168.1.100 -APIKey "00000000-0000-0000-0000-000000000000"
```

Connects to a Cohesity Cluster at the address "192.168.1.100" using the API Key (supported 6.5.1d onwards).

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

### -Port
The port to use to connect to Cohesity Cluster.

```yaml
Type: Int64
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
To login as a tenant use the user name as LOCAL\user1@tenant1

```yaml
Type: PSCredential
Parameter Sets: UsingCreds
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -APIKey
Cohesity API key

```yaml
Type: String
Parameter Sets: UsingAPIKey
Aliases:

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

## RELATED LINKS
