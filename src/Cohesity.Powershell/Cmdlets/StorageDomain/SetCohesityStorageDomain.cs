using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.StorageDomain
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates a Domain.
    /// </para>
    /// <para type="description">
    /// Returns the updated Domain.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityStorageDomain -Domain $domain
    ///   </code>
    ///   <para>
    ///   Updates a Domain.
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
        /// The updated Protection Policy object.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull()]
        public Models.ViewBox Domain { get; set; } = null;

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
            var preparedUrl = $"/public/viewBoxes/{Domain.Id.ToString()}";
            var result = Session.NetworkClient.Put<Models.ViewBox>(preparedUrl, Domain);
            WriteObject(result);
        }

        #endregion
    }
}
