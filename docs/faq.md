# Frequently Asked Questions

### Q: How do I avoid specifying credentials in my PowerShell scripts?
You can export the credentials securely to a file and then import the credentials from that file in your scripts.
#### Exporting the credentials to a file
```powershell
$credential = Get-Credential
$credential | Export-CliXml -Path 'cred.xml'
```
#### Importing the credentials from a file
```powershell
$credential = Import-CliXml -Path 'cred.xml'
```
You can then pass the `$credential` to other cmdlets as below:
```powershell
Connect-CohesityCluster -Server $clusterVIP -Credential $credential
```
> **Note:** `Export-CliXml` is currently broken on non-windows platforms due to this [powershell issue](https://github.com/PowerShell/PowerShell/issues/2059).
