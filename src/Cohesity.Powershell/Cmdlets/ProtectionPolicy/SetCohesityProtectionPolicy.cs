// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.ProtectionPolicy
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates a Protection Policy.
    /// </para>
    /// <para type="description">
    /// Returns the updated Protection Policy.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityProtectionPolicy -ProtectionPolicy $policy
    ///   </code>
    ///   <para>
    ///   Updates a Protection Policy with the specified parameters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityProtectionPolicy")]
    [OutputType(typeof(Models.ProtectionPolicy))]
    public class SetCohesityProtectionPolicy : PSCmdlet
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
        /// The updated Protection Policy object.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull()]
        public Models.ProtectionPolicy ProtectionPolicy { get; set; } = null;

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
            var preparedUrl = $"/public/protectionPolicies/{ProtectionPolicy.Id.ToString()}";
            var result = Session.ApiClient.Put<Models.ProtectionPolicy>(preparedUrl, ProtectionPolicy);
            WriteObject(result);
        }

        #endregion

    }
}
