# Resume-CohesityProtectionJob

## SYNOPSIS
Resumes the future runs of the specified protection job.

## SYNTAX

### ById
```
Resume-CohesityProtectionJob -Id <Int64> [<CommonParameters>]
```

### ByName
```
Resume-CohesityProtectionJob -Name <String> [<CommonParameters>]
```

## DESCRIPTION
This operation restores the protection job to a running state and new runs are started as defined by the schedule in the policy associated with the job.
Returns success if the state is changed.

## EXAMPLES

### EXAMPLE 1
```
Resume-CohesityProtectionJob -Id 1234
```

Resumes a protection job with the Id of 1234.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

```yaml
Type: Int64
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specifies the name of the protection job.

```yaml
Type: String
Parameter Sets: ByName
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

### System.Int64
Specifies the unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS
