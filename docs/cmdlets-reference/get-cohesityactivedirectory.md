# Get-CohesityActiveDirectory

## SYNOPSIS
Get active directory list.

## SYNTAX

```
Get-CohesityActiveDirectory [[-DomainNames] <String[]>] [<CommonParameters>]
```

## DESCRIPTION
After a Cohesity Cluster has been joined to an Active Directory domain, the users and groups in
the domain can be authenticated on the Cohesity Cluster using their Active Directory credentials.
NOTE: The userName and password fields are not populated by this operation.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityActiveDirectory -DomainNames "cohesity.com","abc.com"
```

## PARAMETERS

### -DomainNames
Specifies the domains to fetch active directory entries.

```yaml
Type: String[]
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

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)

