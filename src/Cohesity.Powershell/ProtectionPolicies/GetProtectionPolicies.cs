using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;

namespace Cohesity.ProtectionPolicies
{
    /// <summary>
    /// <para type="synopsis">
    /// List Protection Policies filtered by some parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Protection Policies currently on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "CohesityPolicy")]
    [OutputType(typeof(ProtectionPolicy))]
    public class GetProtectionPolicies : PSCmdlet
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
        /// Filter by Environment type.
        /// Only Policies protecting the specified environment type are returned. 
        /// NOTE: "kPuppeteer" refers to Cohesity’s Remote Adapter.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Protection Policy ids.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public string[] IDs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Protection Policy names.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public string[] Names { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (Environments != null && Environments.Any())
                qb.Add("environments", string.Join(",", Environments));

            if (IDs != null && IDs.Any())
                qb.Add("ids", string.Join(",", IDs));

            if (Names != null && Names.Any())
                qb.Add("names", string.Join(",", Names));

            var preparedUrl = $"/public/protectionPolicies{qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionPolicy>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}
