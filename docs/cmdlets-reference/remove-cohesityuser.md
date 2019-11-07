# Remove-CohesityUser

## SYNOPSIS
Creates a new Cohesity User.

## SYNTAX

```
New-CohesityUser -Name <string> -Domain <string>
```

## DESCRIPTION
Removes the Cohesity User

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityUser -Name test-user
```
### EXAMPLE 2
```
Remove-CohesityUser -Name test-user -Domain LOCAL
```

### EXAMPLE 3
```
Remove-CohesityUser -Name ad_user -Domain ad.engg.company.com
```
Deletes the Cohesity User 

## PARAMETERS

### -Name
Specifies the name of the User to be created.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Domain
Defaults to LOCAL Domain if not specified.

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


```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
