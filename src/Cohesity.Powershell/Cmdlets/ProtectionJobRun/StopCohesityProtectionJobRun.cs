using System;
using System.Collections.Generic;
using System.Text;
using Cohesity.Models;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRuns
{
    /// <summary>
    /// <para type="synopsis">
    /// Cancel a Protection Job run.
    /// </para>
    /// <para type="description">
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Stop-CohesityProtectionJobRun -ID 78773 -JobRunID 85510
    ///   </code>
    ///   <para>
    ///   Stops a running protection job with ID 78773 and JobRunID 85510. 
    ///   </para>
    /// </example>
    [Cmdlet("Stop", "CohesityProtectionJobRun")]
    public class StopCohesityProtectionJobRun : PSCmdlet
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
        /// Specifies a unique id of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long ID { get; set; } = 0;

        /// <summary>
        /// <para type="description">
        /// CopyTaskUid is the Uid of a copy task. 
        /// If a particular copy task is to be cancelled, this field should be set to the id of that particular copy task. 
        /// For example, if replication task is to be canceled, CopyTaskUid of the replication task has to be specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public UniversalId CopyTaskUID { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Run Id of a Protection Job Run that needs to be cancelled.
        /// If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? JobRunID { get; set; }

        /// <summary>
        /// Begin Processing
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Record
        /// </summary>
        protected override void ProcessRecord()
        {
            CancelProtectionJobRunParam body = null;

            if (CopyTaskUID != null || JobRunID != null)
            {
                body = new CancelProtectionJobRunParam(CopyTaskUID, JobRunID);
            }

            var url = $"/public/protectionRuns/cancel/{ID.ToString()}";
            var result = Session.NetworkClient.Post(url, body);
            WriteObject("Protection Job Run cancelled.");
        }
    }
}

