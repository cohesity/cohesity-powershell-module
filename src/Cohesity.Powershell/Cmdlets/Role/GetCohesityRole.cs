// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Role
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets the roles defined on the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Gets the roles defined on the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityRole -Name COHESITY_ADMIN
    ///   </code>
    ///   <para>
    ///   Gets the role with the name COHESITY_ADMIN.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityRole
    ///   </code>
    ///   <para>
    ///   Gets all the roles on the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityRole")]
    [OutputType(typeof(Models.Role))]
    public class GetCohesityRole : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the Role.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string Name { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Records
        /// </summary>
        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (!string.IsNullOrWhiteSpace(Name))
                qb.Add("name", Name);

            var preparedUrl = $"/public/roles{qb.Build()}";
            WriteDebug(preparedUrl);
            var result = Session.ApiClient.Get<IEnumerable<Models.Role>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}