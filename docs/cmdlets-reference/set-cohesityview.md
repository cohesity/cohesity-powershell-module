# Set-CohesityView

## SYNOPSIS
Updates a Cohesity View.

## SYNTAX

```
Set-CohesityView -View <View> [<CommonParameters>]
```

## DESCRIPTION
Returns the updated Cohesity View.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityView -View $view
```

### EXAMPLE 2
Override global whitelist
```
$view = Get-CohesityView -ViewNames “Cohesity_View”
$SubnetWhitelists = New-Object 'System.Collections.Generic.List[Cohesity.Model.Subnet]'
$subnet =  New-Object -TypeName Cohesity.Model.Subnet("") -Property @{NetmaskIp4="255.255.255.0" Description="whitelist linux";Ip="10.2.146.241";NfsAccess=3; SmbAccess=2;NfsRootSquash=$False}
$SubnetWhitelists.Add($subnet)
$view.SubnetWhitelist= $SubnetWhitelists
Set-CohesityView -View $view
```

Updates a Cohesity View.

## PARAMETERS

### -View
The updated View.

```yaml
Type: View
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Model.View
The updated View.

## OUTPUTS

### Cohesity.Model.View
## NOTES

## RELATED LINKS
