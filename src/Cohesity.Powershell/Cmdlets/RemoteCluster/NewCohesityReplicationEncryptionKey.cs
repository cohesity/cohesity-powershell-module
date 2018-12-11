// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.RemoteCluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Generates a new encryption key that can be used for encrypting replication data between this Cluster and a remote Cluster.
    /// </para>
    /// <para type="description">
    /// Generates a new encryption key that can be used for encrypting replication data between this Cluster and a remote Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityReplicationEncryptionKey
    ///   </code>
    ///   <para>
    ///   Gets a new encryption key that can be used for encrypting replication data between this Cluster and a remote Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.New, "CohesityReplicationEncryptionKey")]
    [OutputType(typeof(string))]
    public class NewCohesityReplicationEncryptionKey : PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var url = $"/public/replicationEncryptionKey";
            var results = Session.ApiClient.Get<Models.ReplicationEncryptionKeyReponse>(url);
            WriteObject(results.EncryptionKey);
        }
    }
}