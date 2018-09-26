// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.StorageDomain
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates a Storage Domain.
    /// </para>
    /// <para type="description">
    /// Returns the updated Storage Domain.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityStorageDomain -StorageDomain $domain
    ///   </code>
    ///   <para>
    ///   Updates a Storage Domain.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityStorageDomain")]
    [OutputType(typeof(Models.ViewBox))]
    public class SetCohesityStorageDomain: PSCmdlet
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
        /// The updated StorageDomain.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull()]
        public Models.ViewBox StorageDomain { get; set; } = null;

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
            var preparedUrl = $"/public/viewBoxes/{StorageDomain.Id.ToString()}";
            var result = Session.ApiClient.Put<Models.ViewBox>(preparedUrl, StorageDomain);
            WriteObject(result);
        }

        #endregion
    }
}
