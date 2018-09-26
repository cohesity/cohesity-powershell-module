# Register-CohesityProtectionSourcePhysical

## SYNOPSIS
Registers a new Physical protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourcePhysical -HostType <HostTypeEnum> -PhysicalType <PhysicalTypeEnum>
 -Server <string> [<CommonParameters>]
```

## DESCRIPTION
Registers a new Physical protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourcePhysical -Server server.example.com -HostType KLinux -PhysicalType KHost
```

Registers a physical linux server with hostname "server.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address of the Physical server.

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

### -HostType
Type of host.
Must be set to KLinux or KWindows.

Possible values: KLinux, KWindows, KAix, KSolaris, KOther

```yaml
Type: HostTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KLinux, KWindows, KAix, KSolaris, KOther

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhysicalType
Type of physical host.
Must be set to KHost or KWindowsCluster.

Possible values: KHost, KWindowsCluster

```yaml
Type: PhysicalTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KHost, KWindowsCluster

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

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS
