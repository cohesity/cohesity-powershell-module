using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;

namespace Cohesity.ViewBoxes
{
    [Cmdlet("Get", "CohesityViewBoxStats")]
    [OutputType(typeof(ViewBox))]
    public class GetViewBoxStats : PSCmdlet
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

        [Parameter(Position = 1, Mandatory = false)]
        public int[] IDs { get; set; }



        private bool fetchStats = false;

        [Parameter(Position = 2, Mandatory = false)]
        public SwitchParameter FetchStats
        {
            get { return fetchStats; }
            set { fetchStats = value; }
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (IDs != null && IDs.Any())
                qb.Add("ids", IDs);

            if (FetchStats)
                qb.Add("fetchStats", FetchStats.ToString());

            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/viewBoxes{qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ViewBox>>(preparedUrl);
            WriteObject(result, true);
        }
    }
}
