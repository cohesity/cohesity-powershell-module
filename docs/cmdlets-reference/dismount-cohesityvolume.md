# Dismount-CohesityVolume

## SYNOPSIS
Removes or tears down Cohesity instant mount volumes.

## SYNTAX

```
Dismount-CohesityVolume -TaskId <long> [<CommonParameters>]
```

## DESCRIPTION
Removes or tears down the Cohesity instant mount volumes created by the specified task id.

## EXAMPLES

### EXAMPLE 1
```
Dismount-CohesityVolume -TaskId 1234
```

Tears down the Cohesity instant mount volumes created by task id 1234.

## PARAMETERS

### -TaskId
Specifies the task id that created the instant mount volumes to be removed.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies the task id that created the instant mount volumes to be removed.

## OUTPUTS

## NOTES

## RELATED LINKS
