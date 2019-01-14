# Mount-CohesityVolume

## SYNOPSIS
Mounts the specified volumes instantly to a target host from a previous backup.

## SYNTAX

```
Mount-CohesityVolume -JobId <long> -SourceId <long> -TaskName <string> [-BringDisksOnline] [-JobRunId <long>]
 [-NewParentId <long>] [-StartTime <long>] [-TargetHostCredential <PSCredential>] [-TargetHostId <long>]
 [-VolumeNames <string[]>] [<CommonParameters>]
```

## DESCRIPTION
Mounts the specified volumes instantly to a target host from a previous backup.

## EXAMPLES

### EXAMPLE 1
```
Mount-CohesityVolume -TaskName "Test-Mount" -SourceId 12 -JobId 8 -BringDisksOnline -TargetHostId 23 -TargetHostCredential (Get-Credential)
```

Mounts the volumes corresponding to the given source id to the given target host id using the latest run of job id 8.

## PARAMETERS

### -TaskName
Specifies the name of the instant volume mount task.

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

### -SourceId
Specifies the source id that was backed up.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id to be used for this instant volume mount.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
Specifies the job run id to be used for this instant volume mount.
If not specified the latest run is used.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Specifies the time when the Job Run starts capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if job run id is specified.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BringDisksOnline
Specifies if the volumes will be brought online on the mount target after attaching the disks.
This field is only applicable for VMs.
The Cohesity Cluster always attempts to mount Physical servers.
If the mount target is a VM, then VMware Tools must be installed on the guest operating system and login credentials to the mount target must be specified.
NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewParentId
Specifies a new registered parent Protection Source.
If not specified, the original parent source will be used.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostId
Specifies the source id of the target host where the volumes will be mounted.
NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostCredential
User credentials for accessing the target host for mounting the volumes.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VolumeNames
Specifies the names of volumes to mount.
If none are specified, all volumes are mounted on the target.
Note: Windows volumes should be specified in unix format.
'/C' instead of 'C:'

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
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

## NOTES

## RELATED LINKS
