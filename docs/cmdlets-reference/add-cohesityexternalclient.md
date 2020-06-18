
# Add-CohesityExternalClient

## SYNOPSIS
Add an external client IP.

## SYNTAX

```
Add-CohesityExternalClient -IP4 <string> -NetmaskIP4 <string> [<CommonParameters>]
```

## DESCRIPTION
The Add-CohesityExternalClient function is used to add external client (global whitelist) IP.

## EXAMPLES

### EXAMPLE 1
```
Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0"
```

Add an external client as the global whitelist IP(s)


### EXAMPLE 2
```
Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0" -NFSRootSquash:$false -NFSAccess "kReadWrite" -NFSAllSquash:$false -SMBAccess "kReadWrite"
```

Add an external client as the global whitelist IP(s) with optional parameters

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

