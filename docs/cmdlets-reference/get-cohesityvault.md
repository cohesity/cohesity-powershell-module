# Get-CohesityVault

## SYNOPSIS
Get cohesity vault (external targets).

## SYNTAX

```
Get-CohesityVault [[-VaultName] <Object>] [<CommonParameters>]
```

## DESCRIPTION
List the Vaults (External Targets) registered on the Cohesity Cluster filtered by the specified parameters.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityVault -VaultName "nas-archival"
```

Lists the vault filtered by the vault name.

### EXAMPLE 2
```
Get-CohesityVault
```

## PARAMETERS

### -VaultName
Specifies the vault name to filter.

```yaml
Type: Object
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

