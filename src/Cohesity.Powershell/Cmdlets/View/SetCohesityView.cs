// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates a Cohesity View.
    /// </para>
    /// <para type="description">
    /// Returns the updated Cohesity View.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityView -View $view
    ///   </code>
    ///   <para>
    ///   Updates a Cohesity View.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   $view = Get-CohesityView -ViewNames “Cohesity_View”
    ///   $SubnetWhitelists = New-Object 'System.Collections.Generic.List[Cohesity.Model.Subnet]'
    ///   $subnet =  New-Object -TypeName Cohesity.Model.Subnet("") -Property @{NetmaskIp4="255.255.255.0" Description="whitelist linux";Ip="10.2.146.241";NfsAccess=3; SmbAccess=2;NfsRootSquash=$False}
    ///   $SubnetWhitelists.Add($subnet)
    ///   $view.SubnetWhitelist= $SubnetWhitelists
    ///   Set-CohesityView -View $view
    ///   </code>
    ///   <para>
    ///   Override global whitelist.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityView")]
    [OutputType(typeof(Model.View))]
    public class SetCohesityView: PSCmdlet
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
        /// The updated View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull()]
        public Model.View View { get; set; } = null;

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
            var preparedUrl = $"/public/views/{View.Name}";
            var result = Session.ApiClient.Put<Model.View>(preparedUrl, View);
            WriteObject(result);
        }

        #endregion
    }
}
