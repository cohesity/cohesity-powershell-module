// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionPolicy
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of protection policies filtered by specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all protection policies on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionPolicy -Names Test-Policy
    ///   </code>
    ///   <para>
    ///   Displays the protection policy with name "Test-Policy".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionPolicy")]
    [OutputType(typeof(Models.ProtectionPolicy))]
    public class GetCohesityProtectionPolicy : PSCmdlet
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
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of protection policy ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of protection policy names.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
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

            if (Ids != null && Ids.Any())
                qb.Add("ids", string.Join(",", Ids));

            if (Names != null && Names.Any())
                qb.Add("names", string.Join(",", Names));

            var preparedUrl = $"/public/protectionPolicies{qb.Build()}";
            var result = Session.ApiClient.Get<IEnumerable<Models.ProtectionPolicy>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}
