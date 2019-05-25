# Get-CohesityUser

## SYNOPSIS
Gets the users defined on the Cohesity Cluster.

## SYNTAX

```
Get-CohesityUser [-Domain <string>] [-EmailAddresses <string[]>] [-Names <string[]>] [<CommonParameters>]
```

## DESCRIPTION
Gets the users defined on the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityUser -Names admin,test-user
```

Gets the details of the users with the names "admin" and "test-user".

### EXAMPLE 2
```
Get-CohesityUser -Domain example.com
```

Gets the details of all the users with the domain name as "example.com".

### EXAMPLE 3
```
Get-CohesityUser
```

Gets the details of all the users on the Cohesity Cluster.

## PARAMETERS

### -Names
Specifies a list of user names to filter the results.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddresses
Specifies a list of email addresses to filter the results.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Domain
Specifies the domain name to filter the results.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
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

### Cohesity.Model.User
## NOTES

## RELATED LINKS
