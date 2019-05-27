// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Unregisters the specified protection source from the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Unregisters the specified protection source from the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Unregister-CohesityProtectionSource -Id 12
    ///   </code>
    ///   <para>
    ///   Unregisters the given protection source.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Unregister, "CohesityProtectionSource")]
    public class UnregisterCohesityProtectionSource : PSCmdlet
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

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies a unique id of the protection source.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "ById")]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a protection source object.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "ByObject")]
        public Model.ProtectionSourceNode ProtectionSource { get; set; }

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            if(ProtectionSource != null)
            {
                Id = (long)ProtectionSource.ProtectionSource.Id;
            }
            // DELETE /backupSources/{id}
            var preparedUrl = $"/backupsources/{Id.ToString()}";
            Session.ApiClient.Delete(preparedUrl, string.Empty);
            WriteObject("Protection source was unregistered successfully.");
        }

        #endregion
    }
}