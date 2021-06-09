# This script uses AWS powershell SDK to accomplish the bucket read write operations

[CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [string]$ClusterVIP,
        [Parameter(Mandatory = $true)]
        [string]$UserName,
        [Parameter(Mandatory = $true)]
        [string]$Password
    )

    [string]$viewName = "s3test2"
    [string]$accessKeyId = $null
    [string]$secretKey = $null
    # for example https://1.2.3.4:3000
    [string]$endpointURL = "https://" + $ClusterVIP + ":3000"

    [string]$fileName = "testfile1.txt"
    [string]$fileKey = "/" + $fileName


    # Connect to the cluster
    Connect-CohesityCluster -Server $ClusterVIP -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $UserName, (ConvertTo-SecureString -AsPlainText $Password -Force))

    # Get the Access key and the secret key from the current user
    $userDetail = Get-CohesityUser -Names $UserName
    $accessKeyId = $userDetail.S3AccessKeyId
    $secretKey = $userDetail.S3SecretKey

    # Create a S3 bucket with the help of cohesity view
    New-CohesityView -Name $viewName -AccessProtocol KS3Only -StorageDomainName DefaultStorageDomain

    # Create a sample file (you can avoid this step if you have an existing file)
    New-Item -Path . -Name $fileName -ItemType "file" -Value "This is a text string." -Force

    # Make sure that you are able to access the bucket, created from the view
    Get-S3Bucket -AccessKey  $accessKeyId -SecretKey $secretKey -EndpointUrl $endpointURL -BucketName $viewName

    # Start uploading the file into the bucket
    Write-S3Object -AccessKey  $accessKeyId -SecretKey $secretKey -EndpointUrl $endpointURL -BucketName $viewName -File $fileName -Key $fileKey -Verbose

    # Check if the file is uploaded
    Get-S3Object -AccessKey  $accessKeyId -SecretKey $secretKey -EndpointUrl $endpointURL -BucketName $viewName  -Key $fileKey -Verbose

    # Remove the file from the bucket
    Remove-S3Object -AccessKey  $accessKeyId -SecretKey $secretKey -EndpointUrl $endpointURL -BucketName $viewName  -Key $fileKey -Confirm:$false -Verbose

    # Delete the S3 bucket
    Remove-CohesityView -Name $viewName -Confirm:$false