// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers a new SMB file share as protection source with the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Registers a new SMB file share as protection source with the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourceSMB -MountPath "\\smb-server.example.com\share -Credential (Get-Credential)"
    /// </code>
    /// <para>
    /// Registers a new SMB file share with mount path "\\smb-server.example.com\share" with the Cohesity Cluster.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityProtectionSourceSMB")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class RegisterCohesityProtectionSourceSMB : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// NFS Mount path.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string MountPath { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// User credentials for accessing the SMB file share.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public PSCredential Credential { get; set; } = null;
        #endregion

        #region Processing

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var networkCredential = Credential.GetNetworkCredential();
            var domain = networkCredential.Domain;
            var requestData = JsonConvert.SerializeObject(new {
                entity = new {
                    type = 11,
                    genericNasEntity = new {
                        protocol = 2,
                        type = 1,
                        path = MountPath
                    }
                },
                entityInfo = new {
                    endpoint = MountPath,
                    type = 11,
                    credentials = new {
                        username = Credential.UserName,
                        password = networkCredential.Password,
                        nasMountCredentials = new {
                            protocol = 2,
                            username = Credential.UserName,
                            password = networkCredential.Password,
                            domainName = domain
                        }
                    }
                }
            });

            // POST /backupsources
            var registerUrl = $"/backupsources";
            var result = Session.ApiClient.Post(registerUrl, requestData);

            JObject protectionSourceObject = JObject.Parse(result);
            string protectionSourceId = (string)protectionSourceObject["id"];

            // GET /protectionSources/{id}
            var getProtectionSourcesUrl = $"/public/protectionSources/objects/{protectionSourceId}";
            var response = Session.ApiClient.Get<Models.ProtectionSource>(getProtectionSourcesUrl);

            WriteObject(response);
        }

        #endregion
    }
}