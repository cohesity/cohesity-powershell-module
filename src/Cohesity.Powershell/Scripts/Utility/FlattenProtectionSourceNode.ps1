function FlattenProtectionSourceNode {
    [cmdletbinding()]
    param(
        [Parameter(Mandatory = $true)]
        $Nodes,
        [Parameter(Mandatory = $true)]
        [Cohesity.Model.ProtectionSource+EnvironmentEnum[]]$Environments
    )
    $result = @()
    if (-not $Nodes) {
        return $result
    }
    foreach ($node in $Nodes) {
        $childrenNodes = $node.nodes;
        if (-not $childrenNodes) {
            if ($node.ApplicationNodes) {
                $childrenNodes = $node.ApplicationNodes;
            }
        }
        if ($Environments -contains $node.ProtectionSource.Environment) {
            $result += @($node)
        }
        if ($childrenNodes) {
            $result += (FlattenProtectionSourceNode -Nodes $childrenNodes -Environments $Environments)
        }

        return $result
    }
}