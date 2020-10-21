function FlattenProtectionSourceNode {
	[OutputType('System.Object[]')]
    [cmdletbinding()]
    param(
        [Parameter(Mandatory = $true)]
        $Nodes,
        [Parameter(Mandatory = $true)]
        [ValidateSet(1, 2, 3)]
        [int]$Type
    )
    $result = @()
    if (-not $Nodes) {
        return $result
    }
    if ($Type -eq 1) {
        foreach ($node in $Nodes) {
            $childrenNodes = $node.nodes;
            if (-not $childrenNodes) {
                if ($node.ApplicationNodes) {
                    $childrenNodes = $node.ApplicationNodes;
                }
            }
            $result += @($node)
            if ($childrenNodes) {
                $result += (FlattenProtectionSourceNode -Nodes $childrenNodes -Type $Type)
            }
        }
    }
    if ($Type -eq 2) {
        foreach ($node in $Nodes)
        {
            $childrenNodes = $node.nodes;
            $result += $node
            if($childrenNodes) {
                $result += (FlattenProtectionSourceNode -Nodes $childrenNodes -Type $Type)
            }
        }
    }
    return $result
}