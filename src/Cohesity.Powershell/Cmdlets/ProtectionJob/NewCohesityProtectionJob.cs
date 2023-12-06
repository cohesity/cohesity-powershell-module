// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Creates a new protection job.
    /// </para>
    /// <para type="description">
    /// Returns the created protection job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   New-CohesityProtectionJob -Name 'Test-Job-View' -Description 'Protects a View' -PolicyId 4816026365909361:1530076822448:1 -Environment kView -ViewName cohesity_int_19417 -StorageDomainId 3144
    ///   </code>
    ///   <para>
    ///   Creates a protection job for protecting a Cohesity View.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.New, "CohesityProtectionJob", DefaultParameterSetName = "CreateByName")]
    [OutputType(typeof(Model.ProtectionJob))]
    public class NewCohesityProtectionJob : PSCmdlet
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
        /// Specifies the name of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the description of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection policy associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateById")]
        [ValidateNotNullOrEmpty()]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the protection policy associated with the protection job.
        /// </para>
        /// </summary>

        [Parameter(Mandatory = true, ParameterSetName = "CreateByName")]
        [ValidateNotNullOrEmpty()]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the parent protection source (such as a vCenter server) protected by this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection source objects (such as a virtual machines) protected by this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipeline = true)]
        public long[] SourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of Source ids from a Protection Source that should not be protected by this Protection Job.
        /// Both leaf and non-leaf Objects may be specified in this list.
        /// An Object in this list must have its ancestor in the SourceIds list.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] ExcludeSourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of VM tag ids to protect VMs with the corresponding tags.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] VmTagIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of VM tag ids to exclude VMs with the corresponding tags.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] ExcludeVmTagIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the timezone for this protection job. Must be a string in Olson time zone format such as "America/Los_Angeles".
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the start date time for this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public System.DateTime ScheduleStartTime { get; set; } = System.DateTime.Now;

        /// <summary>
        /// <para type="description">
        /// Specifies the storage domain (view box) id where this job writes data.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateById")]
        public long StorageDomainId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the storage domain associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateByName")]
        [ValidateNotNullOrEmpty()]
        public string StorageDomainName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the View associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string ViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
        /// A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? FullSLATimeInMinutes { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of minutes that a Job Run of a CBT-based backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
        /// A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? IncrementalSLATimeInMinutes { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the environment that this job is protecting. Default is kView.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.ProtectionJob.EnvironmentEnum? Environment { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies additional settings that can apply to a subset of the
        /// Sources listed in the Protection Job.For example, you can specify a list
        /// of files and folders to protect instead of protecting the entire Physical
        /// Server.If this field's setting conflicts with environmentParameters,
        /// then this setting will be used. Specific volume selections must be passed
        /// in here to take effect.
        /// </para>
        /// </summary>
        [Parameter()]
        public SourceSpecialParameter[] SourceSpecialParameters { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered.
        /// This also specifies inclusion and exclusion rules that determine the directories to index (backup files).
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter EnableIndexing { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PauseFutureRuns { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the QoS policy type to use for this Protection Job.
        /// 'kBackupHDD' indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting.
        /// 'kBackupSSD' indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
        /// 'kTestAndDevHigh' indicated the test and dev workload.
        /// 'kBackupAll' indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.
        /// Default is kBackupHDD.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.ProtectionJob.QosTypeEnum? QosType { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority.
        /// 'kLow' indicates lowest execution priority for a Protection job.
        /// 'kMedium' indicates medium execution priority for a Protection job.
        /// 'kHigh' indicates highest execution priority for a Protection job.
        /// Default is kMedium.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.ProtectionJob.PriorityEnum? Priority { get; set; }

        /// <summary>
        /// <para type="description">
        /// Array of Job Events. During Job Runs, the following Job Events are generated:
        /// 1) Job succeeds 2) Job fails 3) Job violates the SLA
        /// These Job Events can cause Alerts to be generated.
        /// 'kSuccess' means the Protection Job succeeded.
        /// 'kFailure' means the Protection Job failed.
        /// 'kSlaViolation' means the Protection Job took longer than the time period specified in the SLA.
        /// Default is kFailure.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.ProtectionJob.AlertingPolicyEnum[] AlertOn { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] EmailAddress { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            if (string.IsNullOrWhiteSpace(Timezone))
                Timezone = TimeZoneInfoExtensions.GetOlsonTimeZone();

            if (!string.IsNullOrWhiteSpace(PolicyName))
            {
                var policy = RestApiCommon.GetPolicyByName(Session.ApiClient, PolicyName);
                PolicyId = policy.Id;
            }

            if (!string.IsNullOrWhiteSpace(StorageDomainName))
            {
                var domain = RestApiCommon.GetStorageDomainByName(Session.ApiClient, StorageDomainName);
                StorageDomainId = (long) domain.Id;
            }

            var newProtectionJob = new Model.ProtectionJob(name: Name, policyId: PolicyId, viewBoxId: StorageDomainId)
            {
                Timezone = Timezone,
                StartTime = new TimeOfDay(ScheduleStartTime.Hour, ScheduleStartTime.Minute)
            };

            if (ParentSourceId.HasValue)
                newProtectionJob.ParentSourceId = ParentSourceId;

            if (SourceIds != null && SourceIds.Any())
                newProtectionJob.SourceIds = SourceIds.ToList();

            if (ExcludeSourceIds != null && ExcludeSourceIds.Any())
                newProtectionJob.ExcludeSourceIds = ExcludeSourceIds.ToList();

            if (VmTagIds != null && VmTagIds.Any())
            {
                var vmTagIdsList = VmTagIds.ToList();
                newProtectionJob.VmTagIds = new List<List<long>>();
                foreach (var vmTagIds in vmTagIdsList)
                {
                    newProtectionJob.VmTagIds.Add(new List<long> { vmTagIds });
                }
            }  

            if (ExcludeVmTagIds != null && ExcludeVmTagIds.Any())
            {
                var excludeVmTagIdsList = ExcludeVmTagIds.ToList();
                newProtectionJob.ExcludeVmTagIds = new List<List<long>>();
                foreach (var excludeVmTagIds in excludeVmTagIdsList)
                {
                    newProtectionJob.ExcludeVmTagIds.Add(new List<long> { excludeVmTagIds });
                }
            }

            if (!string.IsNullOrWhiteSpace(ViewName))
                newProtectionJob.ViewName = ViewName;

            newProtectionJob.Environment = Environment != null ? Environment : Model.ProtectionJob.EnvironmentEnum.KView;

            if (FullSLATimeInMinutes != null)
                newProtectionJob.FullProtectionSlaTimeMins = FullSLATimeInMinutes;

            if (IncrementalSLATimeInMinutes != null)
                newProtectionJob.IncrementalProtectionSlaTimeMins = IncrementalSLATimeInMinutes;

            if (SourceSpecialParameters != null && SourceSpecialParameters.Any())
            {
                newProtectionJob.SourceSpecialParameters = SourceSpecialParameters.ToList();
            }

            if (EnableIndexing.IsPresent)
            {
                newProtectionJob.IndexingPolicy = new IndexingPolicy();
                newProtectionJob.IndexingPolicy.DisableIndexing = false;
                newProtectionJob.IndexingPolicy.AllowPrefixes = new List<string>() { "/" };
            }

            if (PauseFutureRuns.IsPresent)
            {
                newProtectionJob.IsPaused = true;
            }

            if (EndTimeUsecs != null)
                newProtectionJob.EndTimeUsecs = EndTimeUsecs;

            if (QosType != null)
                newProtectionJob.QosType = QosType;

            if (Priority != null)
                newProtectionJob.Priority = Priority;

            if (AlertOn != null && AlertOn.Any())
                newProtectionJob.AlertingPolicy = AlertOn.ToList();

            if (EmailAddress != null && EmailAddress.Any())
            {
                var EmailAddressList = EmailAddress.ToList();
                newProtectionJob.AlertingConfig = new Model.AlertingConfig();
                newProtectionJob.AlertingConfig.EmailDeliveryTargets = new List<Model.EmailDeliveryTarget>();

                foreach (var EmailAdd in EmailAddressList)
                {
                    var EmailDeliveryTarget = new Model.EmailDeliveryTarget
                    {
                        EmailAddress = EmailAdd,
                        RecipientType = Model.EmailDeliveryTarget.RecipientTypeEnum.KTo
                    };
                    newProtectionJob.AlertingConfig.EmailDeliveryTargets.Add(EmailDeliveryTarget);
                }
            }

            var preparedUrl = $"/public/protectionJobs";
            var result = Session.ApiClient.Post<Model.ProtectionJob>(preparedUrl, newProtectionJob);
            WriteObject(result);
        }
    }
}
