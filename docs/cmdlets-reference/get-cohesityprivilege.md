# Get-CohesityPrivilege

## SYNOPSIS
Gets all privileges defined on the Cohesity Cluster.

## SYNTAX

```
Get-CohesityPrivilege [-Name <string[]>] [<CommonParameters>]
```

## DESCRIPTION
In addition, information about each privilege is returned such as the associated category, description, name.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityPrivilege -Name PRINCIPAL_VIEW
```

Gets details of privilege with name PRINCIPAL_VIEW.

## PARAMETERS

### -Name
Specifies the name of the Privilege.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.PrivilegeInfo
## NOTES

## RELATED LINKS
