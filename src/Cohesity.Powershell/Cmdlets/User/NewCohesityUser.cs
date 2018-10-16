// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Creates a new Cohesity User.
    /// </para>
    /// <para type="description">
    /// Returns the created Cohesity User.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   New-CohesityUser -Name test-user -Password password -Roles COHESITY_ADMIN
    ///   </code>
    ///   <para>
    ///   Creates a new Cohesity User in default LOCAL domain called "test-user" with COHESITY_ADMIN role.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.New, "CohesityUser")]
    [OutputType(typeof(Models.User))]
    public class NewCohesityUser: PSCmdlet
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
        /// Specifies the name of the User to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the password for the User to be created.
        /// This is mandatory in case of a LOCAL user.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Password { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies one or more roles for the User to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string[] Roles { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the fully qualified domain name of an Active Directory or LOCAL for the default domain.
        /// A user is uniquely identified by combination of the username and the domain.
        /// If not specified, the default domain is used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Domain { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the email address for the User to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string EmailAddress { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the description for the User to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether the created user has restricted access.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter Restricted { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the effective time for this User.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public DateTime EffectiveTime { get; set; } = DateTime.Now;

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

            var request = new Models.UserParameters(username: Name, password: Password)
            {
                Roles = new List<string>(Roles),
                Restricted = Restricted.IsPresent
            };

            if(EffectiveTime != null)
            {
                DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                long milliseconds = (EffectiveTime.ToUniversalTime() - UnixEpoch).Ticks / TimeSpan.TicksPerMillisecond;
                request.EffectiveTimeMsecs = milliseconds;
            }

            if (!string.IsNullOrWhiteSpace(Domain))
                request.Domain = Domain;

            if (!string.IsNullOrWhiteSpace(EmailAddress))
                request.EmailAddress = EmailAddress;

            if (!string.IsNullOrWhiteSpace(Description))
                request.Description = Description;
            
            var preparedUrl = $"/public/users";
            var result = Session.ApiClient.Post<Models.User>(preparedUrl, request);
            WriteObject(result);
        }

        #endregion
    }
}
