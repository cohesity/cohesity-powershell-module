[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [string]$TenantName
)
Begin {
    Set-CohesityCmdletConfig -OrganizationName $TenantName
}

Process {
    # operate on tenant ($TenantName) based queries
    $views = Get-CohesityView
    Write-Output $views
}
End {
}
