# Params
# ---------------------------------------
$Name = 'Test Job 123bbb'
$Description = 'It protects'
$Policy_Name = 'asdfg'
$ParentProtectionSourceName = 'Physical Servers'
$ViewBoxName = 'NDDC'

$ProtectionSourceConfigurations = @(
    [PSCustomObject]@{
        Name='10.2.41.166'
        FilePaths=@(
            [PSCustomObject]@{
                BackupFilePath='/'
                ExcludedFilePaths=@()
                SkipNestedVolumes=$true
            }
        )
    }
)

# Execution
# ---------------------------------------
$Environment = 'kPhysicalFiles'
$protectionPolicies = cohesity-listpolicies -Environments $Environment -Names @($Policy_Name)
$protectionPolicy = $protectionPolicies[0]
$policyId = $protectionPolicy.Id

# Get protection sources for environment
$parentProtectionSources = cohesity-listprotectionsources -Environments 'kPhysical'
$parentProtectionSources = $parentProtectionSources | Where-Object {$_.ProtectionSource.Name -Like $ParentProtectionSourceName}
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
$protectionSourceNames = $ProtectionSourceConfigurations | ForEach-Object { $_.Name }
$protectionSources = Get-Nodes $parentProtectionSource.Nodes $protectionSourceNames

$sourceIds = @()
$sourceSpecialParameters = @()
foreach ($protectionSource in $protectionSources) {
    $sourceId = $protectionSource.ProtectionSource.Id
    $sourceName = $protectionSource.ProtectionSource.Name
    $protectionSourceConfig = $ProtectionSourceConfigurations | Where-Object { $_.Name -eq $sourceName } | Select-Object -First 1
    
    $filePaths = New-Object -TypeName System.Collections.Generic.List[Cohesity.Models.FilePathParameters]
    foreach($configFilePath in $protectionSourceConfig.FilePaths) {
        $filePath = New-Object -TypeName Cohesity.Models.FilePathParameters -ArgumentList @($configFilePath.BackupFilePath, $null, $configFilePath.SkipNestedVolumes)
        $filePaths.Add($filePath)
    }

    $physicalSpecialParameters = New-Object -TypeName Cohesity.Models.PhysicalSpecialParameters -ArgumentList @($null, $null, $filePaths, $null, $null)
    $sourceSpecialParameter = New-Object -TypeName Cohesity.Models.SourceSpecialParameter -ArgumentList @($physicalSpecialParameters, $null, $sourceId, $null, $null, $null, $null)
    $sourceSpecialParameters += $sourceSpecialParameter
    $sourceIds += $sourceId
}

# Get ViewBoxID ; TODO: make call to api to get the viewboxid
$viewBoxes = Cohesity-ListViewBox -Names @( $ViewBoxName )
$viewBox = $viewBoxes[0]
$viewBoxId = $viewBox.Id

Cohesity-CreateDataProtectionJobs -Name $Name -Description $Description -PolicyID $policyId -ParentSourceID $parentSourceId -SourceIDs $sourceIds -SourceSpecialParameters $sourceSpecialParameters -ViewBoxID $viewBoxId -Environment $Environment
