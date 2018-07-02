# cohesity-connect 10.2.45.177

# Parameters
# ------------------------------
$Name = 'Test Job 666'
$Description = 'It protects'
$Policy_Name = 'Backup-ST-VC'
$ViewName = 'Cohesity_exc'

# Execution
# ------------------------------
$Environment = 'kView'
$protectionPolicies = cohesity-listpolicies -Environments $Environment -Names @($Policy_Name)
$protectionPolicy = $protectionPolicies[0]
$policyId = $protectionPolicy.Id

# Get View
$views = cohesity-ListViews -ViewNames @($ViewName)
$view = $views.Views[0]
$viewBoxId = $view.ViewBoxId

Cohesity-CreateDataProtectionJobs -Name $Name -Description $Description -PolicyID $policyId -Environment $Environment -ViewName $ViewName -ViewBoxID $viewBoxId
