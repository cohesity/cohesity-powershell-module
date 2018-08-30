using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// List Views filtered by some parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Views on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// <para type="description">
    /// NOTE: If maxCount is set and the number of Views returned exceeds the maxCount, there are more Views to return.
    /// To get the next set of Views, send another request and specify the id of the
    /// last View returned in viewList from the previous response.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityView -viewNames Testview
    ///   </code>
    ///   <para>
    ///   Displays the view with name Testview.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityView")]
    [OutputType(typeof(List<Models.View>))]
    public class GetCohesityView : PSCmdlet
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
        /// Specifies if inactive Views on this Remote Cluster (which have Snapshots copied by replication) should also be returned.
        /// Inactive Views are not counted towards the maxCount.
        /// By default, this field is set to false. 
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = false)]
        public bool IncludeInactive { get; set; } = false;

        /// <summary>
        /// <para type="description">
        /// If true, view aliases are also matched with the names in viewNames.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public bool MatchAliasNames { get; set; } = false;

        /// <summary>
        /// <para type="description">
        /// Filter by a list of View names.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public string[] ViewNames { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Storage Domains (View Boxes) specified by id.
        /// </para>
        /// </summary>
        [Parameter(Position = 4, Mandatory = false)]
        public int[] ViewBoxIDs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of View Box names.
        /// </para>
        /// </summary>
        [Parameter(Position = 5, Mandatory = false)]
        public string[] ViewBoxNames { get; set; }

        /// <summary>
        /// <para type="description">
        /// If true, the names in viewNames are matched by prefix rather than exactly matched.
        /// </para>
        /// </summary>
        [Parameter(Position = 6, Mandatory = false)]
        public bool? MatchPartialNames { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a limit on the number of Views returned.
        /// </para>
        /// </summary>
        [Parameter(Position = 7, Mandatory = false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// <para type="description">
        /// If the number of Views to return exceeds the maxCount specified in the original request, specify the id of the last View from the viewList in the previous response to get the next set of Views.
        /// </para>
        /// </summary>
        [Parameter(Position = 8, Mandatory = false)]
        public int? MaxViewID { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by Protection Job ids. Return Views that are being protected by listed Jobs, which are specified by ids.
        /// </para>
        /// </summary>
        [Parameter(Position = 9, Mandatory = false)]
        public int[] JobIDs { get; set; }

        /// <summary>
        /// <para type="description"> 
        /// If set to true, the list is sorted descending by logical usage.
        /// </para>
        /// </summary>
        [Parameter(Position = 10, Mandatory = false)]
        public bool? SortByLogicalUsage { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            qb.Add("includeInactive", IncludeInactive);

            if (MatchAliasNames)
                qb.Add("matchAliasNames", MatchAliasNames);

            if (ViewNames != null && ViewNames.Any())
                qb.Add("viewNames", ViewNames);

            if (ViewBoxIDs != null && ViewBoxIDs.Any())
                qb.Add("viewBoxIds", ViewBoxIDs);

            if (ViewBoxNames != null && ViewBoxNames.Any())
                qb.Add("viewBoxNames", ViewBoxNames);

            if (MatchPartialNames.HasValue && MatchPartialNames.Value)
                qb.Add("matchPartialNames", MatchPartialNames.Value);

            if (MaxCount.HasValue)
                qb.Add("maxCount", MaxCount.Value);

            if (MaxViewID.HasValue)
                qb.Add("maxViewId", MaxViewID.Value);

            if (JobIDs != null && JobIDs.Any())
                qb.Add("jobIds", JobIDs);

            if (SortByLogicalUsage.HasValue && SortByLogicalUsage.Value)
                qb.Add("SortByLogicalUsage", SortByLogicalUsage.Value);

            var preparedUrl = $"/public/views{qb.Build()}";
            var result = Session.NetworkClient.Get<GetViewsResult>(preparedUrl);
            WriteObject(result.Views);
        }
    }
}
