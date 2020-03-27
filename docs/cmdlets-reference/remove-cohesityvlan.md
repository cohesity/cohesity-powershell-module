# Remove-CohesityVlan

## SYNOPSIS
Removes a vlan.

## SYNTAX

```
Remove-CohesityVlan  -VlanId <int> [<CommonParameters>]
```

```
Get-CohesityVlan -VlanId <int> | Remove-CohesityVlan [<CommonParameters>]
```

## DESCRIPTION
The Remove-CohesityVlan function is used to delete vlan.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityVlan  -VlanId 18
```
Removes vlan of the specific Id.

### EXAMPLE 2
```
Get-CohesityVlan -VlanId 11 | Remove-CohesityVlan
```
Removes vlan of the specific Id.

## PARAMETERS

### -VlanId
Specifies the Id of the Vlan.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: True
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
