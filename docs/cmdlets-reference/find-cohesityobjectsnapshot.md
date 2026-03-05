# Find-CohesityObjectSnapshot

## SYNOPSIS
List the snapshots for a given object.

## SYNTAX

```
Find-CohesityObjectSnapshot [-ObjectId] <String> [[-ProtectionGroupIds] <String[]>] [<CommonParameters>]
```

## DESCRIPTION
List the snapshots for a given object.

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityObjectSnapshot -ObjectId 12
```

Returns list of snapshot information of specified object with id 12.

### EXAMPLE 2
```
Find-CohesityObjectSnapshot -ObjectId 12 -ProtectionGroupIds 1111:2222:12
```

Returns list of snapshot information of specified object with id 12, which is protected through specified protection job.

## PARAMETERS

### -ObjectId
Specifies the id of the Object.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionGroupIds
List of protection group id.
If specified, this returns only the snapshots of the specified object ID, which belong to the provided protection group IDs.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)

