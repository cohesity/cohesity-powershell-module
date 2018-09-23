# Add multiple VMs to a Protection Job
You can use the powershell script below to add multiple VMs to an existing protection job.

This script uses the cmdlets `Get-CohesityProtectionJob`, `Get-CohesityVM` and `Set-CohesityProtectionJob` to achieve this task.

### Example
```powershell
Add-VmsToProtectionJob.ps1 -JobId 5 -VMNames linux-vm,win2k16-vm -Mode Append
```

```powershell
param(
    # The Protection Job Id
    [Parameter(Mandatory=$true, Position=0)]
    [long]
    $JobId,

    # Mode: Append or Replace
    [Parameter(Mandatory=$true, Position=1)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet("Append", "Replace")]
    [string]
    $Mode,

    # VMs to be added to the Protection Job
    [Parameter(Mandatory=$true, Position=2)]
    [ValidateNotNullOrEmpty()]
    [string[]]
    $VMNames
)

$protectionJob = Get-CohesityProtectionJob -Id $JobId
if ($null -eq $protectionJob) {
        "Protection Job was not found."
        return
}

$protectionSources = Get-CohesityVM -Names $VMNames
if ($null -eq $protectionSources -or $protectionSources.Count -eq 0) {
    "No matching virtual machines found."
    return
}

$protectionSourceIds = $protectionSources | ForEach-Object{ $_.Id }

if($Mode -eq "Append") {
    $protectionJob.SourceIds = $protectionJob.SourceIds + $protectionSourceIds    
} elseif ($Mode -eq "Replace") {
    $protectionJob.SourceIds = $protectionSourceIds    
}        

Set-CohesityProtectionJob -Id $JobId -ProtectionJob $protectionJob
```
