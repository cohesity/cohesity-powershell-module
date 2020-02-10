# Cohesity VMware backup restore test validation example

This is an example powershell for simple random recovery test for each VMware Protection Job.

Script will automatically select random virtual machines from each job for recovery. By default number is 2 per job, but this can altered to any other value. Script will clone VMs for recovery testing, and after succesful cloning it will validate VM status with VMware Tools running status.

# Prerequisites

* [PowerShell](https://aka.ms/getps6)
* [Cohesity PowerShell Module](https://cohesity.github.io/cohesity-powershell-module/#/)
* [VMware PowerCLI](https://www.powershellgallery.com/packages/VMware.PowerCLI/)

# How to start using this?


## Credential files

This script uses encrypted credentials for authentication. You can create credentials with simple two commands:

```PowerShell
Get-Credential | Export-Clixml vmware_credentials.xml
Get-Credential | Export-Clixml cohesity_credentials.xml
```

Note: Secure XML files can only be decrypted by the user account that created them.

## Usage
./vmware-recovery-tests.ps1 -cohesityCluster 192.168.1.198 -vmwareEnvironment 192.168.1.200 -cohesityCred 'cohesity_credentials.xml' -vmwareCred 'vmware_credentials.xml' -resourcePool 'Resources' -perjob '10']


# Notes
Jussi Jaurola - <jussi@cohesity.com>
```
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```
