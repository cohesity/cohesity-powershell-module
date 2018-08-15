#cohesity-connect 10.2.47.155

# Params
# ---------------------------------------
$Name = 'Test Job 123aaa'
$Description = 'It protects'
$Policy_Name = 'asdfg'
$ParentProtectionSource_Name = 'sv4-st1-vcenter-01'
$ProtectionSourceNames = @('DC1', 'HCL-DC')
$ViewBoxName = 'systemtest'

# Execution
# ---------------------------------------
$Environment = 'kVMWare'
$protectionPolicies = cohesity-listpolicies -Environments $Environment -Names @($Policy_Name)
$protectionPolicy = $protectionPolicies[0]
$policyId = $protectionPolicy.Id

# Get protection sources for environment
$parentProtectionSources = cohesity-listprotectionsources -Environments $Environment
$parentProtectionSources = $parentProtectionSources | Where-Object {$_.ProtectionSource.Name -Like $ParentProtectionSource_Name}
$parentProtectionSource = $parentProtectionSources[0]
$parentSourceId = $parentProtectionSource.ProtectionSource.Id

function Get-Nodes ($Sources, $Names) {
    $results = @()

    foreach ($Source in $Sources) {
        if ($Names -contains $Source.ProtectionSource.Name) {
            $results += $Source
        }            
        
        if ($Source.Nodes -ne $null) {
            $childResults = Get-Nodes $Source.Nodes $Names 
            $results = $results + $childResults
        }
    }

    return $results
}

# Get sources
$protectionSources = Get-Nodes $parentProtectionSource.Nodes $ProtectionSourceNames
$sourceIds = $protectionSources | ForEach-Object {$_.ProtectionSource.Id}

# Get ViewBoxID ; TODO: make call to api to get the viewboxid
$viewBoxes = Cohesity-ListViewBox -Names @( $ViewBoxName )
$viewBox = $viewBoxes[0]
$viewBoxId = $viewBox.Id

Cohesity-CreateDataProtectionJobs -Name $Name -Description $Description -PolicyID $policyId -ParentSourceID $parentSourceId -SourceIDs $sourceIds -ViewBoxID $viewBoxId -Environment $Environment
