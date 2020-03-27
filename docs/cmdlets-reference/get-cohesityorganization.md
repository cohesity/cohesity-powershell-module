# Get-CohesityOrganization

## SYNOPSIS
Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters
To get a specific organization provide the organization name
## SYNTAX

```
Get-CohesityOrganization -Name <string> [<CommonParameters>] 
```

## DESCRIPTION
Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityOrganization
```

Lists all Cohesity organisation.

### EXAMPLE 2
```
Get-CohesityOrganization -Name testorg
```

Lists the Cohesity organisation after filtering with the given name.

## PARAMETERS

### -Name
Specifies the name of the organisation

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
