<#
.SYNOPSIS
    Demonstrates how to write a command that works with paths that allow
    wildards and must exist.
.DESCRIPTION
    This command also demonstrates how you need to supply a LiteralPath
    parameter when your Path parameter accepts wildcards.  This is in order
    to handle paths like foo[1].txt.  If you pass this path to the Path
    parameter, it will fail to find this file because "[1]" is interpreted
    as a wildcard spec e.g it resolves to foo1.txt.  The LiteralPath parameter
    is used in this case as it does not interpret wildcard chars.
.EXAMPLE
    C:\PS> Import-FileWildcard -LiteralPath ..\..\Tests\foo[1].txt -WhatIf
    This example shows how to use the LiteralPath parameter with a path
    that happens to use the wildcard chars "[" and "]".
#>
function AddVMtoProtectionJob {
    [CmdletBinding(SupportsShouldProcess=$false)]
    param(
        # The ID of a Protection Job.
        [Parameter(Mandatory=$true,
            Position=0,
            HelpMessage="Protection Job ID is required.")]
        [long]
        $JobID,

        # Specifies a path to one or more locations. Wildcards are permitted.
        [Parameter(Mandatory=$true,
                   Position=1,
                   HelpMessage="Path to one or more locations.")]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("Append", "Replace")]
        [string]
        $Modification,

        # Specifies a path to one or more locations. Unlike the Path parameter, the value of the LiteralPath parameter is
        # used exactly as it is typed. No characters are interpreted as wildcards. If the path includes escape characters,
        # enclose it in single quotation marks. Single quotation marks tell Windows PowerShell not to interpret any
        # characters as escape sequences.
        [Parameter(Mandatory=$true,
                   Position=2,
                   ValueFromPipelineByPropertyName=$true,
                   HelpMessage="Literal path to one or more locations.")]
        [ValidateNotNullOrEmpty()]
        [string[]]
        $VMNames
    )

    begin {
    }

    process {
        $protectionJob = Get-CohesityProtectionJob -ID $JobID
        if ($null -eq $protectionJob) {
             "Protection Job was not found."
             return
        }

        $protectionSources = Get-CohesityVM -Names $VMNames
        if ($null -eq $protectionSources -or $protectionSources.Count -eq 0) {
            "No Protection Sources found."
            return
        }
		
        $protectionSourceIds = $protectionSources | ForEach-Object{ $_.Id }
        
        if($Modification -eq "Append") {
            $protectionJob.SourceIds = $protectionJob.SourceIds + $protectionSourceIds    
        } elseif ($Modification -eq "Replace") {
            $protectionJob.SourceIds = $protectionSourceIds    
        }        

        Set-CohesityProtectionJob -ID $JobID -ProtectionJob $protectionJob
    }

    end {
    }
}

function get-Nodes ($Sources, $Names) {
    $results = @()
    
    foreach ($Source in $Sources) {
        if ($Names -contains $Source.Name) {
            $results += $Source
        }            
    }

    return $results
}