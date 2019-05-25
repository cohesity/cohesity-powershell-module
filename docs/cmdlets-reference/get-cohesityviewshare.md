# Get-CohesityViewShare

## SYNOPSIS
Gets a list of shares associated with a view.

## SYNTAX

```
Get-CohesityViewShare -ViewName <string> [<CommonParameters>]
```

## DESCRIPTION
Gets a list of shares associated with a view.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityViewShare -ViewName Test-view
```

Displays the shares associated with a view with the name "Test-view".

## PARAMETERS

### -ViewName
Name of the View

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.View
## NOTES

## RELATED LINKS
