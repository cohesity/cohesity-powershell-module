
NAME
    Set-CohesityViewDirectoryQuota
    
SYNOPSIS
    Request to update directory quota for a view filtered by specified parameters.
    
    
SYNTAX
    Set-CohesityViewDirectoryQuota [-ViewName] <String> [-DirPath] <String> [[-AlertLimitInGB] <Int64>] [[-HardLimitInGB] <Int64>] [-WhatIf] [-Confirm] [<CommonParameters>]
    
    
DESCRIPTION
    The Set-CohesityViewDirectoryQuota function is used to set directory quota for a view.
    

PARAMETERS
    -ViewName <String>
        
        Required?                    true
        Position?                    1
        Default value                
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    -DirPath <String>
        
        Required?                    true
        Position?                    2
        Default value                
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    -AlertLimitInGB <Int64>
        
        Required?                    false
        Position?                    3
        Default value                0
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    -HardLimitInGB <Int64>
        
        Required?                    false
        Position?                    4
        Default value                0
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    -WhatIf [<SwitchParameter>]
        
        Required?                    false
        Position?                    named
        Default value                
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    -Confirm [<SwitchParameter>]
        
        Required?                    false
        Position?                    named
        Default value                
        Accept pipeline input?       false
        Accept wildcard characters?  false
        
    <CommonParameters>
        This cmdlet supports the common parameters: Verbose, Debug,
        ErrorAction, ErrorVariable, WarningAction, WarningVariable,
        OutBuffer, PipelineVariable, and OutVariable. For more information, see
        about_CommonParameters (https://go.microsoft.com/fwlink/?LinkID=113216). 
    
INPUTS
    
OUTPUTS
    
    -------------------------- EXAMPLE 1 --------------------------
    
    PS > Set-CohesityViewDirectoryQuota -ViewName view1
    
    
    
    
    
    
    
RELATED LINKS


