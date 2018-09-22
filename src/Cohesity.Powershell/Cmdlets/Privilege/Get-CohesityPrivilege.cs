// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;
using System.Linq;

namespace Cohesity.Powershell.Cmdlets.Privilege
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets all privileges defined on the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// In addition, information about each privilege is returned such as the associated category, description, name.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityPrivilege -Name PRINCIPAL_VIEW
    ///   </code>
    ///   <para>
    ///   Gets details of privilege with name PRINCIPAL_VIEW.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityPrivilege")]
    [OutputType(typeof(Models.PrivilegeInfo))]
    public class GetCohesityPrivilege : PSCmdlet
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
        /// Specifies the name of the Privilege.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Name { get; set; }

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

            if (Name != null && Name.Any())
                qb.Add("name", string.Join(",", Name));

            var preparedUrl = $"/public/privileges{qb.Build()}";
            WriteDebug(preparedUrl);
            var result = Session.ApiClient.Get<IEnumerable<Models.PrivilegeInfo>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}