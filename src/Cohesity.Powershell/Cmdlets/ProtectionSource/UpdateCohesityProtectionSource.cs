// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Refreshes the object hierarchy of the specified protection source on the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Forces an immediate refresh of the specified protection source on the Cohesity Cluster.
    /// Returns success if the forced refresh has been started.
    /// Note that the amount of time to complete a refresh depends on the size of the object hierarchy.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Update-CohesityProtectionSource -Id 12
    ///   </code>
    ///   <para>
    ///   Immediately refreshes the given protection source.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Update, "CohesityProtectionSource")]
    public class UpdateCohesityProtectionSource : PSCmdlet
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
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

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
            // POST /public/protectionSources/refresh/{id}
            var preparedUrl = $"/public/protectionSources/refresh/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, string.Empty);
            WriteObject("Protection source was refreshed successfully.");
        }

        #endregion
    }
}