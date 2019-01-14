// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes a Share associated with a Cohesity View .
    /// </para>
    /// <para type="description">
    /// Returns success if the Share is deleted.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityViewShare -ShareName "Test-Share"
    ///   </code>
    ///   <para>
    ///   Removes a share with the name "Test-Share".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CohesityViewShare",
        SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveCohesityViewShare : PSCmdlet
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
        public string ShareName { get; set; }

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
            if (ShouldProcess($"Share Name: {ShareName.Trim()}"))
            {
                // DELETE /public/viewAliases/{name}
                var preparedUrl = $"/public/viewAliases/{ShareName}";
                Session.ApiClient.Delete(preparedUrl, string.Empty);
                WriteObject($"Share with name {ShareName.Trim()} was deleted successfully.");
            }

            else
            {
                WriteObject($"Share with name {ShareName.Trim()} was not deleted.");
            }
        }

        #endregion
    }
}
