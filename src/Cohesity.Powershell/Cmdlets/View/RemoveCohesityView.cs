using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes a Cohesity View.
    /// </para>
    /// <para type="description">
    /// Returns success if the view is deleted.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityView -Name "Test-View"
    ///   </code>
    ///   <para>
    ///   Removes a view with the name "Test-View".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CohesityView")]
    public class RemoveCohesityView : PSCmdlet
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
        /// Specifies the name of the View to be deleted.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

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
            // DELETE /public/views/{name}
            var preparedUrl = $"/public/views/{Name}";
            Session.NetworkClient.Delete(preparedUrl, string.Empty);
            WriteObject("View was deleted successfully.");
        }

        #endregion
    }
}
