# Get-CohesityUserGroup

## SYNOPSIS
List the user groups that match the filter criteria specified using parameters

## SYNTAX

```
Get-CohesityUserGroup [[-Name] <String>] [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityUserGroup function is used to fetch list of all user groups.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityUserGroup
```

List all user groups

### EXAMPLE 2
```
Get-CohesityUserGroup -Name user_group1
```

## PARAMETERS

### -Name
Optionally specify a group name to filter by.
All groups containing name will be returned.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Array
## NOTES

## RELATED LINKS
