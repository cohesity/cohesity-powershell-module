# Get-CohesityRole

## SYNOPSIS
Gets the roles defined on the Cohesity Cluster.

## SYNTAX

```
Get-CohesityRole [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Gets the roles defined on the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityRole -Name COHESITY_ADMIN
```

Gets the role with the name COHESITY_ADMIN.

### EXAMPLE 2
```
Get-CohesityRole
```

Gets all the roles on the Cohesity Cluster.

## PARAMETERS

### -Name
Specifies the name of the Role.

```yaml
Type: String
Parameter Sets: (All)
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

### Cohesity.Model.Role
## NOTES

## RELATED LINKS
