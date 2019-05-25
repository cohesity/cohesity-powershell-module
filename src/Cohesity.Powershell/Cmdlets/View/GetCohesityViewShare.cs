// Copyright 2018 Cohesity Inc.
using System.Linq;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of shares associated with a view.
    /// </para>
    /// <para type="description">
    /// Gets a list of shares associated with a view.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityViewShare -ViewName Test-view
    ///   </code>
    ///   <para>
    ///   Displays the shares associated with a view with the name "Test-view".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityViewShare")]
    [OutputType(typeof(Models.View))]
    public class GetCohesityViewShare : PSCmdlet
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

        /// <summary>
        /// <para type="description">
        /// Name of the View
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string ViewName { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            qb.Add("viewNames", ViewName);

            var preparedUrl = $"/public/views{qb.Build()}";
            var result = Session.ApiClient.Get<GetViewsResult>(preparedUrl);
            var view = result.Views.Where(x => x.Name.Equals(ViewName)).FirstOrDefault();
            WriteObject(view.Aliases, true);
        }
    }
}
