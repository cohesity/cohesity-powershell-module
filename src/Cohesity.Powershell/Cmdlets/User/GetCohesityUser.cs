// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;
using System.Linq;

namespace Cohesity.Powershell.Cmdlets.User
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets the users defined on the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Gets the users defined on the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityUser -Names admin,test-user
    ///   </code>
    ///   <para>
    ///   Gets the details of the users with the names "admin" and "test-user".
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityUser -Domain example.com
    ///   </code>
    ///   <para>
    ///   Gets the details of all the users with the domain name as "example.com".
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityUser
    ///   </code>
    ///   <para>
    ///   Gets the details of all the users on the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityUser")]
    [OutputType(typeof(Models.User))]
    public class GetCohesityUser : PSCmdlet
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
        /// Specifies a list of user names to filter the results.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string[] Names { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of email addresses to filter the results.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string[] EmailAddresses { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the domain name to filter the results.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Domain { get; set; }

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

            if (Names != null && Names.Any())
                qb.Add("usernames", string.Join(",", Names));

            if (EmailAddresses != null && EmailAddresses.Any())
                qb.Add("emailAddresses", string.Join(",", EmailAddresses));

            if (!string.IsNullOrWhiteSpace(Domain))
                qb.Add("domain", Domain);

            var preparedUrl = $"/public/users{qb.Build()}";
            WriteDebug(preparedUrl);
            var result = Session.ApiClient.Get<IEnumerable<Models.User>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}