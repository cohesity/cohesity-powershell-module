// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Adds a new share to a Cohesity View.
    /// </para>
    /// <para type="description">
    /// Adds a new share to a Cohesity View.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Add-CohesityViewShare -ViewName 'Test-View' -ShareName 'Test-Share' -ViewPath '/'
    ///   </code>
    ///   <para>
    ///   Adds a new share called 'Test-Share' using a Cohesity View named 'Test-View' mapped to the directory path '/' inside the View.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Add, "CohesityViewShare")]
    [OutputType(typeof(Model.ViewAlias))]
    public class AddCohesityViewShare: PSCmdlet
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
        /// Specifies the name of the View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string ViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the Share to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string ShareName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a directory path inside the View to be mounted using this Share.
        /// If not specified, '/' will be used as the default path.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string ViewPath { get; set; } = "/";

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
            var request = new Model.ViewAlias(aliasName: ShareName, viewName: ViewName, viewPath: ViewPath) { };

            var preparedUrl = $"/public/viewAliases";
            var result = Session.ApiClient.Post<Model.ViewAlias>(preparedUrl, request);
            WriteObject(result);
        }

        #endregion
    }
}
