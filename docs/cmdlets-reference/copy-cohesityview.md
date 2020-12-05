# Copy-CohesityView

## SYNOPSIS
Clones the specified Cohesity View.

## SYNTAX

### Default (Default)
```
Copy-CohesityView [-TaskName <String>] -SourceViewName <String> -TargetViewName <String>
 [-TargetViewDescription <String>] -JobId <Int64> [-QoSPolicy <String>] [<CommonParameters>]
```

### JobRunSpecific
```
Copy-CohesityView [-TaskName <String>] -SourceViewName <String> -TargetViewName <String>
 [-TargetViewDescription <String>] -JobId <Int64> [-QoSPolicy <String>] -JobRunId <Int64> -StartTime <Int64>
 [<CommonParameters>]
```

## DESCRIPTION
Clones the specified Cohesity View.

## EXAMPLES

### EXAMPLE 1
```
Copy-CohesityView -TaskName "Task-clone-a-view" -SourceViewName "source-view" -TargetViewName "target-view" -TargetViewDescription "Create a view clone" -QosPolicy "Backup Target Low" -JobId 12345
```

Clones the Cohesity View called "test-view" with the given source id using the latest run of job id 49402.

### EXAMPLE 2
```
Copy-CohesityView -TaskName "Task-clone-a-view" -SourceViewName "source-view" -TargetViewName "target-view" -TargetViewDescription "Create a view clone" -JobId 17955 -JobRunId 17956 -StartTime 1582878606980416
```

Clones a view from a job with job run id and start time.

## PARAMETERS

### -TaskName
Task name for the operation.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceViewName
Specifies the name of the source View that will be cloned.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewName
Specifies the name of the target View.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewDescription
Specifies an optional text description about the View.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Job Id for the protected source view.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -QoSPolicy
Specifies the name of the QoS Policy used for the View.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: Backup Target Low
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
Job run id for the protected source view.

```yaml
Type: Int64
Parameter Sets: JobRunSpecific
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Start time for the protected source view.

```yaml
Type: Int64
Parameter Sets: JobRunSpecific
Aliases:

Required: True
Position: Named
Default value: 0
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

