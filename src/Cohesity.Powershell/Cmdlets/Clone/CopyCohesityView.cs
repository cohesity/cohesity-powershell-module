// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Clone
{
    /// <summary>
    /// <para type="synopsis">
    /// Clones the specified Cohesity View.
    /// </para>
    /// <para type="description">
    /// Clones the specified Cohesity View.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Copy-CohesityView -TaskName "clone-view-task" -SourceViewName "test-view" -TargetViewName "clone-of-test-view" -QosPolicy "Backup Target Low" -JobId 49402
    ///   </code>
    ///   <para>
    ///   Clones the Cohesity View called "test-view" with the given source id using the latest run of job id 49402.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Copy, "CohesityView")]
    public class CopyCohesityView : PSCmdlet
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
        /// Specifies the name of the clone task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TaskName { get; set; }


        /// <summary>
        /// <para type="description">
        /// Specifies the name of the View to clone.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the cloned View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the QoS Policy used for the cloned View such as 'TestAndDev High’, 'Backup Target SSD’, ‘Backup Target High’ ‘TestAndDev Low’ and 'Backup Target Low’.
        /// If not specified, the default is 'Backup Target Low’.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string QoSPolicy { get; set; } = "Backup Target Low";

        /// <summary>
        /// <para type="description">
        /// Specifies the description of the cloned View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TargetViewDescription { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id that backed up this View and will be used for cloning.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job run id that captured the snapshot for this View. If not specified the latest run is used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the time when the Job Run starts capturing a snapshot.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// This must be specified if job run id is specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTime { get; set; }

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
            var view = RestApiCommon.GetViewByName(Session.ApiClient, SourceViewName);

            var cloneRequest = new Models.CloneTaskRequest(name: TaskName)
            {
                Type = Models.CloneTaskRequest.TypeEnum.KCloneView,
                ContinueOnError = true,
            };

            var cloneViewParams = new Models.CloneView_
            {
                SourceViewName = SourceViewName,
                CloneViewName = TargetViewName,
                Description = TargetViewDescription,
                Qos = new Models.QoS
                {
                    PrincipalName = QoSPolicy
                }
            };

            cloneRequest.CloneViewParameters = cloneViewParams;

            var cloneObject = new Models.RestoreObject
            {
                JobId = JobId,
                ProtectionSourceId = view.ViewProtection.MagnetoEntityId
            };

            if (JobRunId.HasValue)
                cloneObject.JobRunId = JobRunId;

            if (StartTime.HasValue)
                cloneObject.StartedTimeUsecs = StartTime;

            var objects = new List<Models.RestoreObject>();
            objects.Add(cloneObject);

            cloneRequest.Objects = objects;

            // POST /public/restore/clone
            var preparedUrl = $"/public/restore/clone";
            var result = Session.ApiClient.Post<Models.RestoreTask>(preparedUrl, cloneRequest);
            WriteObject(result);
        }

        #endregion
    }

}
