// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// BackupJobProto
    /// </summary>
    [DataContract]
    public partial class BackupJobProto :  IEquatable<BackupJobProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProto" /> class.
        /// </summary>
        /// <param name="abortInExclusionWindow">NOTE: Atmost one of abort_in_exclusion_window and pause_in_blackout_window will be set to true. This field determines whether a backup run should be aborted when it hits an exclusion window (assuming that it was started earlier when it was not in an exclusion window)..</param>
        /// <param name="alertingPolicy">alertingPolicy.</param>
        /// <param name="allArchivalSnapshotsExpired">If job deletion status is kDeleteJobAndBackups and this field is set to true, then it  implies that expiration requests for all archival snapshots of this job (if any) have been acknowledged by Icebox. NOTE: This field may remain false for some period of time even if is_deleted field is set to true for the job..</param>
        /// <param name="allInternalReplicationViewsDeleted">Indicates that all the internal replication views have been deleted..</param>
        /// <param name="allowParallelRuns">Denotes whether for this host based backup jobs we allow parallel runs or not. This is only supported by VMware adapter..</param>
        /// <param name="backupQosPrincipal">The backup QoS principal to use for the backup job..</param>
        /// <param name="backupSourceParams">This contains additional backup params that are applicable to sources that are captured as part of the backup job. NOTE: The sources could point to higher level entities (such as a \&quot;Cluster\&quot; in VMware environment), but the source params captured here will not be for the matching higher level entity, but instead be for leaf-level entities (such as VMs)..</param>
        /// <param name="cloudPostBackupScript">cloudPostBackupScript.</param>
        /// <param name="cloudPostSnapshotScript">cloudPostSnapshotScript.</param>
        /// <param name="cloudPreBackupScript">cloudPreBackupScript.</param>
        /// <param name="configVec">Common Backup Configuration Parameters.</param>
        /// <param name="continueOnQuiesceFailure">Whether to continue backing up on quiesce failure..</param>
        /// <param name="createRemoteView">If set to false, a remote view will not be created. If set to true and: 1) Remote view name is not provided by the user, a remote view is created with the same name as source view name. 2) Remote view name is provided by the user, a remote view is created with the given name. NOTE: From 6.6 onwards, remote view is always created for view backups if policy has replication. Hence, this bool is only used for Remote Adapter jobs (kPuppeteer)..</param>
        /// <param name="dataTransferInfo">dataTransferInfo.</param>
        /// <param name="dedupDisabledSourceIdVec">List of source ids for which source side dedup is disabled from the backup job..</param>
        /// <param name="deletionStatus">Determines if the job (and associated backups) should be deleted. Once a job has been deleted, its status cannot be changed..</param>
        /// <param name="description">Job description (as entered by the user)..</param>
        /// <param name="drToCloudParams">drToCloudParams.</param>
        /// <param name="ehParentSource">ehParentSource.</param>
        /// <param name="endTimeUsecs">The time (in usecs) after which no backup for the job should be scheduled..</param>
        /// <param name="envBackupParams">envBackupParams.</param>
        /// <param name="excludeSources">The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;..</param>
        /// <param name="excludeSourcesDEPRECATED">The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;..</param>
        /// <param name="exclusionRanges">Do not run backups in these time-ranges..</param>
        /// <param name="fullBackupJobPolicy">fullBackupJobPolicy.</param>
        /// <param name="fullBackupSlaTimeMins">Same as &#39;sla_time_mins&#39; above, but applies to full backups. NOTE: This value is considered only for full backups that are excepted i.e either scheduled or the first full backup and not for full backups that happen as a result of incremental backup failure..</param>
        /// <param name="globalIncludeExclude">globalIncludeExclude.</param>
        /// <param name="ignorableErrorsInErrorDb">Specifies the list of errors, that should not be persisted in error_db.</param>
        /// <param name="indexingPolicy">indexingPolicy.</param>
        /// <param name="isActive">Whether the backup job is active or not. Details about what an active job is can be found here: https://goo.gl/1mLvS3..</param>
        /// <param name="isCdpSyncReplicationEnabled">If set to true and backup job policy has CDP parameters as well as snapshot replication target policy is specified then data is synchronously replicated to the replication target through Atom service..</param>
        /// <param name="isCloudArchiveDirect">Denotes whether the backup job is CloudArchiveDirect (excluding NAS direct archive in native format). NAS direct archive jobs in native format can be identified by checking for the &#39;is_direct_archive_enabled&#39; field..</param>
        /// <param name="isContinuousSnapshottingEnabled">Indicates if Magneto should continue taking source snapshots even if there is a pending run..</param>
        /// <param name="isDeleted">Tracks whether the backup job has actually been deleted. NOTE: If job deletion status is kDeleteJobAndBackups and this field is true, then it only implies that all local snapshots have been deleted. Status of whether all archival snapshots have been expired can be inferred through &#39;all_archival_snapshots_expired&#39; field..</param>
        /// <param name="isDirectArchiveEnabled">This field is set to true if this is a direct archive backup job..</param>
        /// <param name="isDirectArchiveNativeFormatEnabled">This field is set to true if native format should be used for archiving. Applicable for only direct archive jobs..</param>
        /// <param name="isInternal">Whether the backup job is an internal job. These jobs are hidden from the user, and are created internally..</param>
        /// <param name="isPaused">Whether the backup job is paused. New backup runs are not scheduled for the paused backup job. Active run of a backup job (if any) is not impacted..</param>
        /// <param name="isRpoJob">Whether the backup job is an RPO policy job. These jobs are hidden from the user, and are created internally to have a backup schedule for the given source..</param>
        /// <param name="isSourcePausedMap">A map from entity id of the source to whether the source backup is paused..</param>
        /// <param name="jobCreationTimeUsecs">Time when this job was first created..</param>
        /// <param name="jobId">A unique id for locally created jobs. This should only be used to identify jobs created on the local cluster. When Iris communicates with Magneto, Iris can continue to use this job_id field, which will always be assumed to refer to locally created jobs.  For remotely created jobs, the &#39;job_uid&#39; field should be used. The only time Iris should ever need to refer to a remote job is when restoring an object from a remote snapshot. In all such cases, Iris should use the job_uid field..</param>
        /// <param name="jobPolicy">jobPolicy.</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="lastModificationTimeUsecs">Time when this job description was last updated..</param>
        /// <param name="lastPauseModificationTimeUsecs">Time when the job was last paused or unpaused..</param>
        /// <param name="lastPauseReason">Last reason for pausing the backup job. Capturing the reason will help in resuming only the jobs that were paused because of a reason once the reason for pausing is not applicable..</param>
        /// <param name="lastStartTimeModificationTimeUsecs">Time when this job description was last updated..</param>
        /// <param name="lastUpdatedUsername">The user who modified the job most recently..</param>
        /// <param name="leverageNutanixSnapshots">This is set to true by the user if nutanix snapshot is requested This is applicable in case if the vcenter in question is registered as a management server on a prism endpoint. This flag will be ignored at the backend if it is not feasible to leverage nutanix snapshot..</param>
        /// <param name="leverageSanTransport">This is set to true by the user in order to backup the objects via a dedicated storage area network (SAN), as opposed to transport via LAN or management network. NOTE: Not all adapters support this method. Currently only VMware..</param>
        /// <param name="leverageStorageSnapshots">Whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method. NOTE: This will be set for Pure snapshots..</param>
        /// <param name="leverageStorageSnapshotsForHyperflex">This is set to true by the user if hyperflex snapshots are requested NOTE: If this is set to true, then leverage_storage_snapshots above should be false..</param>
        /// <param name="logBackupJobPolicy">logBackupJobPolicy.</param>
        /// <param name="logBackupSlaTimeMins">Same as &#39;sla_time_mins&#39; above, but applies to log backups..</param>
        /// <param name="maxAllowedSourceSnapshots">Determines the maximum number of source snapshots allowed for a given entity in the job. This is only applicable if &#39;is_continuous_snapshotting_enabled&#39; is set to true..</param>
        /// <param name="name">The name of this backup job. This must be unique across all jobs..</param>
        /// <param name="numSnapshotsToKeepOnPrimary">Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment. NOTE: This is only applicable for certain environments like kPure..</param>
        /// <param name="objectBackupSpecUid">objectBackupSpecUid.</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="pauseInBlackoutWindow">This field determines whether a backup run should be paused when it hits a blackout window (assuming that it was started earlier when it was not in an blackout window). The backup run will get resumed when the blackout period ends..</param>
        /// <param name="performBrickBasedDedup">Whether or not to perform source side dedup..</param>
        /// <param name="performSourceSideDedup">Whether or not to perform source side dedup..</param>
        /// <param name="policyAppliedTimeMsecs">Epoch time in milliseconds when the policy was last applied to this job. This field will be used to determine whether a policy has changed after it was applied to a particular job..</param>
        /// <param name="policyId">Id of the policy being applied to the backup job. It is expected to be of the form \&quot;cluster_id:cluster_instance_id:local_identifier\&quot;..</param>
        /// <param name="policyName">The name of the policy referred to by policy_uid. This field can be stale and should not be relied upon for the latest name..</param>
        /// <param name="postBackupScript">postBackupScript.</param>
        /// <param name="postSnapshotScript">postSnapshotScript.</param>
        /// <param name="preScript">preScript.</param>
        /// <param name="primaryJobUid">primaryJobUid.</param>
        /// <param name="priority">The priority for the job. This is used at admission time - all admitted jobs are treated equally. This is also used to determine the Madrox replication priority..</param>
        /// <param name="quiesce">Whether to take app-consistent snapshots by quiescing apps and the filesystem before taking a backup..</param>
        /// <param name="remoteJobUids">The globally unique ids of all remote jobs that are linked to this job (because of incoming replications). This field will only be populated for locally created jobs. This field is populated only for the local(stub) job during incoming replications. In the most common case of one cluster replicating to another, this field will only have one entry (which is the id of the job on Tx side) and matches the primary_job_uid. This will have multiple entries in the following situation: A-&gt;B, A-&gt;C replication. The backup is failed over to B, and B now starts replicating to C. In this case, the stub job at C will have two entries. One is the job id from cluster A, and another is the local(stub) job uid from B. Also note that since the job originated from A, primary_job_uid for all the replicated instances of this job across multiple clusters will remain the same (which is equal to the job id from the original cluster A)..</param>
        /// <param name="remoteViewName">A human readable name of the remote view. A remote view is created with name overwriting the latest snapshot. NOTE: From 6.6 onwards, we support protecting multiple views within a protection group, &#39;remote_view_params&#39; is the new field which captures this information for view backups, &#39;remote_view_name&#39; here is now only used for Remote Adapter jobs (kPuppeteer)..</param>
        /// <param name="remoteViewParams">remoteViewParams.</param>
        /// <param name="requiredFeatureVec">The features that are strictly required to be supported by the cluster of the backup job. This is currently used in the following cases: 1. Tx cluster looks at the Rx cluster&#39;s supported features and replicates the backup job only if all the features captured here are supported. 2. When performing remote restore of a backup job from an archival, this job will be retrieved only if the cluster supports all the features listed here..</param>
        /// <param name="skipRigelForBackup">Whether to skip Rigel for backup or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only..</param>
        /// <param name="skipTenantValidations">If set to true, skips tenant related validations. Default is false..</param>
        /// <param name="slaTimeMins">If specified, this variable determines the amount of time (after backup has started) in which backup is expected to finish for this job. An SLA violation is counted against this job if the amount of time taken exceeds this amount..</param>
        /// <param name="sourceFilters">sourceFilters.</param>
        /// <param name="sources">The list of sources that should be backed up. A source in this list could be a descendant of another source in the list (this will be used when specifying override backup schedules)..</param>
        /// <param name="standbyResourceVec">User provided resource(s) for creating a standby VM for each entity present in this backup job. For example in case of VMware, the user will provide the vCenter, datastore and resource pool on which the standby VM should be created. TODO(hmehra) Can the user edit this after the job is created or the resources have been specified?.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="storageArraySnapshot">Whether this backup job has a policy for storage array snapshot based backups..</param>
        /// <param name="stubbingPolicy">stubbingPolicy.</param>
        /// <param name="tagVec">Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;..</param>
        /// <param name="taskTimeoutVec">This is a vector of timeouts, for different backup types(kFull, kRegular). A cancellation will automatically gets triggered if the backup tasks inside a run has been running for more than this timeout duration..</param>
        /// <param name="timezone">Timezone of the backup job. All time fields (i.e., TimeOfDay) in this backup job are stored wrt to this timezone.  The time zones have unique names of the form \&quot;Area/Location\&quot;, e.g. \&quot;America/New_York\&quot;. We are using \&quot;America/Los_Angeles\&quot; as a default value so as to be backward compatible with pre-2.7 code..</param>
        /// <param name="truncateLogs">Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment..</param>
        /// <param name="type">The type of environment this backup job corresponds to..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="viewBoxId">The view box to which data will be written..</param>
        public BackupJobProto(bool? abortInExclusionWindow = default(bool?), AlertingPolicyProto alertingPolicy = default(AlertingPolicyProto), bool? allArchivalSnapshotsExpired = default(bool?), bool? allInternalReplicationViewsDeleted = default(bool?), bool? allowParallelRuns = default(bool?), int? backupQosPrincipal = default(int?), List<BackupSourceParams> backupSourceParams = default(List<BackupSourceParams>), CloudBackupJobPreOrPostScript cloudPostBackupScript = default(CloudBackupJobPreOrPostScript), CloudBackupJobPreOrPostScript cloudPostSnapshotScript = default(CloudBackupJobPreOrPostScript), CloudBackupJobPreOrPostScript cloudPreBackupScript = default(CloudBackupJobPreOrPostScript), List<ConfigurationParams> configVec = default(List<ConfigurationParams>), bool? continueOnQuiesceFailure = default(bool?), bool? createRemoteView = default(bool?), DataTransferInfo dataTransferInfo = default(DataTransferInfo), List<long> dedupDisabledSourceIdVec = default(List<long>), int? deletionStatus = default(int?), string description = default(string), BackupJobProtoDRToCloudParams drToCloudParams = default(BackupJobProtoDRToCloudParams), EntityProto ehParentSource = default(EntityProto), long? endTimeUsecs = default(long?), EnvBackupParams envBackupParams = default(EnvBackupParams), List<BackupJobProtoExcludeSource> excludeSources = default(List<BackupJobProtoExcludeSource>), List<EntityProto> excludeSourcesDEPRECATED = default(List<EntityProto>), List<BackupJobProtoExclusionTimeRange> exclusionRanges = default(List<BackupJobProtoExclusionTimeRange>), JobPolicyProto fullBackupJobPolicy = default(JobPolicyProto), long? fullBackupSlaTimeMins = default(long?), PhysicalFileBackupParamsGlobalIncludeExclude globalIncludeExclude = default(PhysicalFileBackupParamsGlobalIncludeExclude), List<ErrorProto> ignorableErrorsInErrorDb = default(List<ErrorProto>), IndexingPolicyProto indexingPolicy = default(IndexingPolicyProto), bool? isActive = default(bool?), bool? isCdpSyncReplicationEnabled = default(bool?), bool? isCloudArchiveDirect = default(bool?), bool? isContinuousSnapshottingEnabled = default(bool?), bool? isDeleted = default(bool?), bool? isDirectArchiveEnabled = default(bool?), bool? isDirectArchiveNativeFormatEnabled = default(bool?), bool? isInternal = default(bool?), bool? isPaused = default(bool?), bool? isRpoJob = default(bool?), List<BackupJobProtoIsSourcePausedMapEntry> isSourcePausedMap = default(List<BackupJobProtoIsSourcePausedMapEntry>), long? jobCreationTimeUsecs = default(long?), long? jobId = default(long?), JobPolicyProto jobPolicy = default(JobPolicyProto), UniversalIdProto jobUid = default(UniversalIdProto), long? lastModificationTimeUsecs = default(long?), long? lastPauseModificationTimeUsecs = default(long?), int? lastPauseReason = default(int?), long? lastStartTimeModificationTimeUsecs = default(long?), string lastUpdatedUsername = default(string), bool? leverageNutanixSnapshots = default(bool?), bool? leverageSanTransport = default(bool?), bool? leverageStorageSnapshots = default(bool?), bool? leverageStorageSnapshotsForHyperflex = default(bool?), JobPolicyProto logBackupJobPolicy = default(JobPolicyProto), long? logBackupSlaTimeMins = default(long?), int? maxAllowedSourceSnapshots = default(int?), string name = default(string), long? numSnapshotsToKeepOnPrimary = default(long?), UniversalIdProto objectBackupSpecUid = default(UniversalIdProto), EntityProto parentSource = default(EntityProto), bool? pauseInBlackoutWindow = default(bool?), bool? performBrickBasedDedup = default(bool?), bool? performSourceSideDedup = default(bool?), long? policyAppliedTimeMsecs = default(long?), string policyId = default(string), string policyName = default(string), BackupJobPreOrPostScript postBackupScript = default(BackupJobPreOrPostScript), BackupJobPreOrPostScript postSnapshotScript = default(BackupJobPreOrPostScript), BackupJobPreOrPostScript preScript = default(BackupJobPreOrPostScript), UniversalIdProto primaryJobUid = default(UniversalIdProto), int? priority = default(int?), bool? quiesce = default(bool?), List<UniversalIdProto> remoteJobUids = default(List<UniversalIdProto>), string remoteViewName = default(string), BackupJobProtoRemoteViewParams remoteViewParams = default(BackupJobProtoRemoteViewParams), List<string> requiredFeatureVec = default(List<string>), bool? skipRigelForBackup = default(bool?), bool? skipTenantValidations = default(bool?), long? slaTimeMins = default(long?), SourceFilters sourceFilters = default(SourceFilters), List<BackupJobProtoBackupSource> sources = default(List<BackupJobProtoBackupSource>), List<StandbyResource> standbyResourceVec = default(List<StandbyResource>), Time startTime = default(Time), bool? storageArraySnapshot = default(bool?), StubbingPolicyProto stubbingPolicy = default(StubbingPolicyProto), List<string> tagVec = default(List<string>), List<CancellationTimeout> taskTimeoutVec = default(List<CancellationTimeout>), string timezone = default(string), bool? truncateLogs = default(bool?), int? type = default(int?), UserInformation userInfo = default(UserInformation), long? viewBoxId = default(long?))
        {
            this.AbortInExclusionWindow = abortInExclusionWindow;
            this.AllArchivalSnapshotsExpired = allArchivalSnapshotsExpired;
            this.AllInternalReplicationViewsDeleted = allInternalReplicationViewsDeleted;
            this.AllowParallelRuns = allowParallelRuns;
            this.BackupQosPrincipal = backupQosPrincipal;
            this.BackupSourceParams = backupSourceParams;
            this.ConfigVec = configVec;
            this.ContinueOnQuiesceFailure = continueOnQuiesceFailure;
            this.CreateRemoteView = createRemoteView;
            this.DedupDisabledSourceIdVec = dedupDisabledSourceIdVec;
            this.DeletionStatus = deletionStatus;
            this.Description = description;
            this.EndTimeUsecs = endTimeUsecs;
            this.ExcludeSources = excludeSources;
            this.ExcludeSourcesDEPRECATED = excludeSourcesDEPRECATED;
            this.ExclusionRanges = exclusionRanges;
            this.FullBackupSlaTimeMins = fullBackupSlaTimeMins;
            this.IgnorableErrorsInErrorDb = ignorableErrorsInErrorDb;
            this.IsActive = isActive;
            this.IsCdpSyncReplicationEnabled = isCdpSyncReplicationEnabled;
            this.IsCloudArchiveDirect = isCloudArchiveDirect;
            this.IsContinuousSnapshottingEnabled = isContinuousSnapshottingEnabled;
            this.IsDeleted = isDeleted;
            this.IsDirectArchiveEnabled = isDirectArchiveEnabled;
            this.IsDirectArchiveNativeFormatEnabled = isDirectArchiveNativeFormatEnabled;
            this.IsInternal = isInternal;
            this.IsPaused = isPaused;
            this.IsRpoJob = isRpoJob;
            this.IsSourcePausedMap = isSourcePausedMap;
            this.JobCreationTimeUsecs = jobCreationTimeUsecs;
            this.JobId = jobId;
            this.LastModificationTimeUsecs = lastModificationTimeUsecs;
            this.LastPauseModificationTimeUsecs = lastPauseModificationTimeUsecs;
            this.LastPauseReason = lastPauseReason;
            this.LastStartTimeModificationTimeUsecs = lastStartTimeModificationTimeUsecs;
            this.LastUpdatedUsername = lastUpdatedUsername;
            this.LeverageNutanixSnapshots = leverageNutanixSnapshots;
            this.LeverageSanTransport = leverageSanTransport;
            this.LeverageStorageSnapshots = leverageStorageSnapshots;
            this.LeverageStorageSnapshotsForHyperflex = leverageStorageSnapshotsForHyperflex;
            this.LogBackupSlaTimeMins = logBackupSlaTimeMins;
            this.MaxAllowedSourceSnapshots = maxAllowedSourceSnapshots;
            this.Name = name;
            this.NumSnapshotsToKeepOnPrimary = numSnapshotsToKeepOnPrimary;
            this.PauseInBlackoutWindow = pauseInBlackoutWindow;
            this.PerformBrickBasedDedup = performBrickBasedDedup;
            this.PerformSourceSideDedup = performSourceSideDedup;
            this.PolicyAppliedTimeMsecs = policyAppliedTimeMsecs;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
            this.Priority = priority;
            this.Quiesce = quiesce;
            this.RemoteJobUids = remoteJobUids;
            this.RemoteViewName = remoteViewName;
            this.RequiredFeatureVec = requiredFeatureVec;
            this.SkipRigelForBackup = skipRigelForBackup;
            this.SkipTenantValidations = skipTenantValidations;
            this.SlaTimeMins = slaTimeMins;
            this.Sources = sources;
            this.StandbyResourceVec = standbyResourceVec;
            this.StorageArraySnapshot = storageArraySnapshot;
            this.TagVec = tagVec;
            this.TaskTimeoutVec = taskTimeoutVec;
            this.Timezone = timezone;
            this.TruncateLogs = truncateLogs;
            this.Type = type;
            this.ViewBoxId = viewBoxId;
            this.AbortInExclusionWindow = abortInExclusionWindow;
            this.AlertingPolicy = alertingPolicy;
            this.AllArchivalSnapshotsExpired = allArchivalSnapshotsExpired;
            this.AllInternalReplicationViewsDeleted = allInternalReplicationViewsDeleted;
            this.AllowParallelRuns = allowParallelRuns;
            this.BackupQosPrincipal = backupQosPrincipal;
            this.BackupSourceParams = backupSourceParams;
            this.CloudPostBackupScript = cloudPostBackupScript;
            this.CloudPostSnapshotScript = cloudPostSnapshotScript;
            this.CloudPreBackupScript = cloudPreBackupScript;
            this.ConfigVec = configVec;
            this.ContinueOnQuiesceFailure = continueOnQuiesceFailure;
            this.CreateRemoteView = createRemoteView;
            this.DataTransferInfo = dataTransferInfo;
            this.DedupDisabledSourceIdVec = dedupDisabledSourceIdVec;
            this.DeletionStatus = deletionStatus;
            this.Description = description;
            this.DrToCloudParams = drToCloudParams;
            this.EhParentSource = ehParentSource;
            this.EndTimeUsecs = endTimeUsecs;
            this.EnvBackupParams = envBackupParams;
            this.ExcludeSources = excludeSources;
            this.ExcludeSourcesDEPRECATED = excludeSourcesDEPRECATED;
            this.ExclusionRanges = exclusionRanges;
            this.FullBackupJobPolicy = fullBackupJobPolicy;
            this.FullBackupSlaTimeMins = fullBackupSlaTimeMins;
            this.GlobalIncludeExclude = globalIncludeExclude;
            this.IgnorableErrorsInErrorDb = ignorableErrorsInErrorDb;
            this.IndexingPolicy = indexingPolicy;
            this.IsActive = isActive;
            this.IsCdpSyncReplicationEnabled = isCdpSyncReplicationEnabled;
            this.IsCloudArchiveDirect = isCloudArchiveDirect;
            this.IsContinuousSnapshottingEnabled = isContinuousSnapshottingEnabled;
            this.IsDeleted = isDeleted;
            this.IsDirectArchiveEnabled = isDirectArchiveEnabled;
            this.IsDirectArchiveNativeFormatEnabled = isDirectArchiveNativeFormatEnabled;
            this.IsInternal = isInternal;
            this.IsPaused = isPaused;
            this.IsRpoJob = isRpoJob;
            this.IsSourcePausedMap = isSourcePausedMap;
            this.JobCreationTimeUsecs = jobCreationTimeUsecs;
            this.JobId = jobId;
            this.JobPolicy = jobPolicy;
            this.JobUid = jobUid;
            this.LastModificationTimeUsecs = lastModificationTimeUsecs;
            this.LastPauseModificationTimeUsecs = lastPauseModificationTimeUsecs;
            this.LastPauseReason = lastPauseReason;
            this.LastStartTimeModificationTimeUsecs = lastStartTimeModificationTimeUsecs;
            this.LastUpdatedUsername = lastUpdatedUsername;
            this.LeverageNutanixSnapshots = leverageNutanixSnapshots;
            this.LeverageSanTransport = leverageSanTransport;
            this.LeverageStorageSnapshots = leverageStorageSnapshots;
            this.LeverageStorageSnapshotsForHyperflex = leverageStorageSnapshotsForHyperflex;
            this.LogBackupJobPolicy = logBackupJobPolicy;
            this.LogBackupSlaTimeMins = logBackupSlaTimeMins;
            this.MaxAllowedSourceSnapshots = maxAllowedSourceSnapshots;
            this.Name = name;
            this.NumSnapshotsToKeepOnPrimary = numSnapshotsToKeepOnPrimary;
            this.ObjectBackupSpecUid = objectBackupSpecUid;
            this.ParentSource = parentSource;
            this.PauseInBlackoutWindow = pauseInBlackoutWindow;
            this.PerformBrickBasedDedup = performBrickBasedDedup;
            this.PerformSourceSideDedup = performSourceSideDedup;
            this.PolicyAppliedTimeMsecs = policyAppliedTimeMsecs;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
            this.PostBackupScript = postBackupScript;
            this.PostSnapshotScript = postSnapshotScript;
            this.PreScript = preScript;
            this.PrimaryJobUid = primaryJobUid;
            this.Priority = priority;
            this.Quiesce = quiesce;
            this.RemoteJobUids = remoteJobUids;
            this.RemoteViewName = remoteViewName;
            this.RemoteViewParams = remoteViewParams;
            this.RequiredFeatureVec = requiredFeatureVec;
            this.SkipRigelForBackup = skipRigelForBackup;
            this.SkipTenantValidations = skipTenantValidations;
            this.SlaTimeMins = slaTimeMins;
            this.SourceFilters = sourceFilters;
            this.Sources = sources;
            this.StandbyResourceVec = standbyResourceVec;
            this.StartTime = startTime;
            this.StorageArraySnapshot = storageArraySnapshot;
            this.StubbingPolicy = stubbingPolicy;
            this.TagVec = tagVec;
            this.TaskTimeoutVec = taskTimeoutVec;
            this.Timezone = timezone;
            this.TruncateLogs = truncateLogs;
            this.Type = type;
            this.UserInfo = userInfo;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// NOTE: Atmost one of abort_in_exclusion_window and pause_in_blackout_window will be set to true. This field determines whether a backup run should be aborted when it hits an exclusion window (assuming that it was started earlier when it was not in an exclusion window).
        /// </summary>
        /// <value>NOTE: Atmost one of abort_in_exclusion_window and pause_in_blackout_window will be set to true. This field determines whether a backup run should be aborted when it hits an exclusion window (assuming that it was started earlier when it was not in an exclusion window).</value>
        [DataMember(Name="abortInExclusionWindow", EmitDefaultValue=true)]
        public bool? AbortInExclusionWindow { get; set; }

        /// <summary>
        /// Gets or Sets AlertingPolicy
        /// </summary>
        [DataMember(Name="alertingPolicy", EmitDefaultValue=false)]
        public AlertingPolicyProto AlertingPolicy { get; set; }

        /// <summary>
        /// If job deletion status is kDeleteJobAndBackups and this field is set to true, then it  implies that expiration requests for all archival snapshots of this job (if any) have been acknowledged by Icebox. NOTE: This field may remain false for some period of time even if is_deleted field is set to true for the job.
        /// </summary>
        /// <value>If job deletion status is kDeleteJobAndBackups and this field is set to true, then it  implies that expiration requests for all archival snapshots of this job (if any) have been acknowledged by Icebox. NOTE: This field may remain false for some period of time even if is_deleted field is set to true for the job.</value>
        [DataMember(Name="allArchivalSnapshotsExpired", EmitDefaultValue=true)]
        public bool? AllArchivalSnapshotsExpired { get; set; }

        /// <summary>
        /// Indicates that all the internal replication views have been deleted.
        /// </summary>
        /// <value>Indicates that all the internal replication views have been deleted.</value>
        [DataMember(Name="allInternalReplicationViewsDeleted", EmitDefaultValue=true)]
        public bool? AllInternalReplicationViewsDeleted { get; set; }

        /// <summary>
        /// Denotes whether for this host based backup jobs we allow parallel runs or not. This is only supported by VMware adapter.
        /// </summary>
        /// <value>Denotes whether for this host based backup jobs we allow parallel runs or not. This is only supported by VMware adapter.</value>
        [DataMember(Name="allowParallelRuns", EmitDefaultValue=true)]
        public bool? AllowParallelRuns { get; set; }

        /// <summary>
        /// The backup QoS principal to use for the backup job.
        /// </summary>
        /// <value>The backup QoS principal to use for the backup job.</value>
        [DataMember(Name="backupQosPrincipal", EmitDefaultValue=true)]
        public int? BackupQosPrincipal { get; set; }

        /// <summary>
        /// This contains additional backup params that are applicable to sources that are captured as part of the backup job. NOTE: The sources could point to higher level entities (such as a \&quot;Cluster\&quot; in VMware environment), but the source params captured here will not be for the matching higher level entity, but instead be for leaf-level entities (such as VMs).
        /// </summary>
        /// <value>This contains additional backup params that are applicable to sources that are captured as part of the backup job. NOTE: The sources could point to higher level entities (such as a \&quot;Cluster\&quot; in VMware environment), but the source params captured here will not be for the matching higher level entity, but instead be for leaf-level entities (such as VMs).</value>
        [DataMember(Name="backupSourceParams", EmitDefaultValue=true)]
        public List<BackupSourceParams> BackupSourceParams { get; set; }

        /// <summary>
        /// Gets or Sets CloudPostBackupScript
        /// </summary>
        [DataMember(Name="cloudPostBackupScript", EmitDefaultValue=false)]
        public CloudBackupJobPreOrPostScript CloudPostBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets CloudPostSnapshotScript
        /// </summary>
        [DataMember(Name="cloudPostSnapshotScript", EmitDefaultValue=false)]
        public CloudBackupJobPreOrPostScript CloudPostSnapshotScript { get; set; }

        /// <summary>
        /// Gets or Sets CloudPreBackupScript
        /// </summary>
        [DataMember(Name="cloudPreBackupScript", EmitDefaultValue=false)]
        public CloudBackupJobPreOrPostScript CloudPreBackupScript { get; set; }

        /// <summary>
        /// Common Backup Configuration Parameters
        /// </summary>
        /// <value>Common Backup Configuration Parameters</value>
        [DataMember(Name="configVec", EmitDefaultValue=true)]
        public List<ConfigurationParams> ConfigVec { get; set; }

        /// <summary>
        /// Whether to continue backing up on quiesce failure.
        /// </summary>
        /// <value>Whether to continue backing up on quiesce failure.</value>
        [DataMember(Name="continueOnQuiesceFailure", EmitDefaultValue=true)]
        public bool? ContinueOnQuiesceFailure { get; set; }

        /// <summary>
        /// If set to false, a remote view will not be created. If set to true and: 1) Remote view name is not provided by the user, a remote view is created with the same name as source view name. 2) Remote view name is provided by the user, a remote view is created with the given name. NOTE: From 6.6 onwards, remote view is always created for view backups if policy has replication. Hence, this bool is only used for Remote Adapter jobs (kPuppeteer).
        /// </summary>
        /// <value>If set to false, a remote view will not be created. If set to true and: 1) Remote view name is not provided by the user, a remote view is created with the same name as source view name. 2) Remote view name is provided by the user, a remote view is created with the given name. NOTE: From 6.6 onwards, remote view is always created for view backups if policy has replication. Hence, this bool is only used for Remote Adapter jobs (kPuppeteer).</value>
        [DataMember(Name="createRemoteView", EmitDefaultValue=true)]
        public bool? CreateRemoteView { get; set; }

        /// <summary>
        /// Gets or Sets DataTransferInfo
        /// </summary>
        [DataMember(Name="dataTransferInfo", EmitDefaultValue=false)]
        public DataTransferInfo DataTransferInfo { get; set; }

        /// <summary>
        /// List of source ids for which source side dedup is disabled from the backup job.
        /// </summary>
        /// <value>List of source ids for which source side dedup is disabled from the backup job.</value>
        [DataMember(Name="dedupDisabledSourceIdVec", EmitDefaultValue=true)]
        public List<long> DedupDisabledSourceIdVec { get; set; }

        /// <summary>
        /// Determines if the job (and associated backups) should be deleted. Once a job has been deleted, its status cannot be changed.
        /// </summary>
        /// <value>Determines if the job (and associated backups) should be deleted. Once a job has been deleted, its status cannot be changed.</value>
        [DataMember(Name="deletionStatus", EmitDefaultValue=true)]
        public int? DeletionStatus { get; set; }

        /// <summary>
        /// Job description (as entered by the user).
        /// </summary>
        /// <value>Job description (as entered by the user).</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DrToCloudParams
        /// </summary>
        [DataMember(Name="drToCloudParams", EmitDefaultValue=false)]
        public BackupJobProtoDRToCloudParams DrToCloudParams { get; set; }

        /// <summary>
        /// Gets or Sets EhParentSource
        /// </summary>
        [DataMember(Name="ehParentSource", EmitDefaultValue=false)]
        public EntityProto EhParentSource { get; set; }

        /// <summary>
        /// The time (in usecs) after which no backup for the job should be scheduled.
        /// </summary>
        /// <value>The time (in usecs) after which no backup for the job should be scheduled.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets EnvBackupParams
        /// </summary>
        [DataMember(Name="envBackupParams", EmitDefaultValue=false)]
        public EnvBackupParams EnvBackupParams { get; set; }

        /// <summary>
        /// The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;.
        /// </summary>
        /// <value>The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;.</value>
        [DataMember(Name="excludeSources", EmitDefaultValue=true)]
        public List<BackupJobProtoExcludeSource> ExcludeSources { get; set; }

        /// <summary>
        /// The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;.
        /// </summary>
        /// <value>The list of sources to exclude from backups. These can have non-leaf-level entities, but it&#39;s up to the creator to ensure that a child of these sources hasn&#39;t been explicitly added to &#39;sources&#39;.</value>
        [DataMember(Name="excludeSources_DEPRECATED", EmitDefaultValue=true)]
        public List<EntityProto> ExcludeSourcesDEPRECATED { get; set; }

        /// <summary>
        /// Do not run backups in these time-ranges.
        /// </summary>
        /// <value>Do not run backups in these time-ranges.</value>
        [DataMember(Name="exclusionRanges", EmitDefaultValue=true)]
        public List<BackupJobProtoExclusionTimeRange> ExclusionRanges { get; set; }

        /// <summary>
        /// Gets or Sets FullBackupJobPolicy
        /// </summary>
        [DataMember(Name="fullBackupJobPolicy", EmitDefaultValue=false)]
        public JobPolicyProto FullBackupJobPolicy { get; set; }

        /// <summary>
        /// Same as &#39;sla_time_mins&#39; above, but applies to full backups. NOTE: This value is considered only for full backups that are excepted i.e either scheduled or the first full backup and not for full backups that happen as a result of incremental backup failure.
        /// </summary>
        /// <value>Same as &#39;sla_time_mins&#39; above, but applies to full backups. NOTE: This value is considered only for full backups that are excepted i.e either scheduled or the first full backup and not for full backups that happen as a result of incremental backup failure.</value>
        [DataMember(Name="fullBackupSlaTimeMins", EmitDefaultValue=true)]
        public long? FullBackupSlaTimeMins { get; set; }

        /// <summary>
        /// Gets or Sets GlobalIncludeExclude
        /// </summary>
        [DataMember(Name="globalIncludeExclude", EmitDefaultValue=false)]
        public PhysicalFileBackupParamsGlobalIncludeExclude GlobalIncludeExclude { get; set; }

        /// <summary>
        /// Specifies the list of errors, that should not be persisted in error_db
        /// </summary>
        /// <value>Specifies the list of errors, that should not be persisted in error_db</value>
        [DataMember(Name="ignorableErrorsInErrorDb", EmitDefaultValue=true)]
        public List<ErrorProto> IgnorableErrorsInErrorDb { get; set; }

        /// <summary>
        /// Gets or Sets IndexingPolicy
        /// </summary>
        [DataMember(Name="indexingPolicy", EmitDefaultValue=false)]
        public IndexingPolicyProto IndexingPolicy { get; set; }

        /// <summary>
        /// Whether the backup job is active or not. Details about what an active job is can be found here: https://goo.gl/1mLvS3.
        /// </summary>
        /// <value>Whether the backup job is active or not. Details about what an active job is can be found here: https://goo.gl/1mLvS3.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// If set to true and backup job policy has CDP parameters as well as snapshot replication target policy is specified then data is synchronously replicated to the replication target through Atom service.
        /// </summary>
        /// <value>If set to true and backup job policy has CDP parameters as well as snapshot replication target policy is specified then data is synchronously replicated to the replication target through Atom service.</value>
        [DataMember(Name="isCdpSyncReplicationEnabled", EmitDefaultValue=true)]
        public bool? IsCdpSyncReplicationEnabled { get; set; }

        /// <summary>
        /// Denotes whether the backup job is CloudArchiveDirect (excluding NAS direct archive in native format). NAS direct archive jobs in native format can be identified by checking for the &#39;is_direct_archive_enabled&#39; field.
        /// </summary>
        /// <value>Denotes whether the backup job is CloudArchiveDirect (excluding NAS direct archive in native format). NAS direct archive jobs in native format can be identified by checking for the &#39;is_direct_archive_enabled&#39; field.</value>
        [DataMember(Name="isCloudArchiveDirect", EmitDefaultValue=true)]
        public bool? IsCloudArchiveDirect { get; set; }

        /// <summary>
        /// Indicates if Magneto should continue taking source snapshots even if there is a pending run.
        /// </summary>
        /// <value>Indicates if Magneto should continue taking source snapshots even if there is a pending run.</value>
        [DataMember(Name="isContinuousSnapshottingEnabled", EmitDefaultValue=true)]
        public bool? IsContinuousSnapshottingEnabled { get; set; }

        /// <summary>
        /// Tracks whether the backup job has actually been deleted. NOTE: If job deletion status is kDeleteJobAndBackups and this field is true, then it only implies that all local snapshots have been deleted. Status of whether all archival snapshots have been expired can be inferred through &#39;all_archival_snapshots_expired&#39; field.
        /// </summary>
        /// <value>Tracks whether the backup job has actually been deleted. NOTE: If job deletion status is kDeleteJobAndBackups and this field is true, then it only implies that all local snapshots have been deleted. Status of whether all archival snapshots have been expired can be inferred through &#39;all_archival_snapshots_expired&#39; field.</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// This field is set to true if this is a direct archive backup job.
        /// </summary>
        /// <value>This field is set to true if this is a direct archive backup job.</value>
        [DataMember(Name="isDirectArchiveEnabled", EmitDefaultValue=true)]
        public bool? IsDirectArchiveEnabled { get; set; }

        /// <summary>
        /// This field is set to true if native format should be used for archiving. Applicable for only direct archive jobs.
        /// </summary>
        /// <value>This field is set to true if native format should be used for archiving. Applicable for only direct archive jobs.</value>
        [DataMember(Name="isDirectArchiveNativeFormatEnabled", EmitDefaultValue=true)]
        public bool? IsDirectArchiveNativeFormatEnabled { get; set; }

        /// <summary>
        /// Whether the backup job is an internal job. These jobs are hidden from the user, and are created internally.
        /// </summary>
        /// <value>Whether the backup job is an internal job. These jobs are hidden from the user, and are created internally.</value>
        [DataMember(Name="isInternal", EmitDefaultValue=true)]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// Whether the backup job is paused. New backup runs are not scheduled for the paused backup job. Active run of a backup job (if any) is not impacted.
        /// </summary>
        /// <value>Whether the backup job is paused. New backup runs are not scheduled for the paused backup job. Active run of a backup job (if any) is not impacted.</value>
        [DataMember(Name="isPaused", EmitDefaultValue=true)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Whether the backup job is an RPO policy job. These jobs are hidden from the user, and are created internally to have a backup schedule for the given source.
        /// </summary>
        /// <value>Whether the backup job is an RPO policy job. These jobs are hidden from the user, and are created internally to have a backup schedule for the given source.</value>
        [DataMember(Name="isRpoJob", EmitDefaultValue=true)]
        public bool? IsRpoJob { get; set; }

        /// <summary>
        /// A map from entity id of the source to whether the source backup is paused.
        /// </summary>
        /// <value>A map from entity id of the source to whether the source backup is paused.</value>
        [DataMember(Name="isSourcePausedMap", EmitDefaultValue=true)]
        public List<BackupJobProtoIsSourcePausedMapEntry> IsSourcePausedMap { get; set; }

        /// <summary>
        /// Time when this job was first created.
        /// </summary>
        /// <value>Time when this job was first created.</value>
        [DataMember(Name="jobCreationTimeUsecs", EmitDefaultValue=true)]
        public long? JobCreationTimeUsecs { get; set; }

        /// <summary>
        /// A unique id for locally created jobs. This should only be used to identify jobs created on the local cluster. When Iris communicates with Magneto, Iris can continue to use this job_id field, which will always be assumed to refer to locally created jobs.  For remotely created jobs, the &#39;job_uid&#39; field should be used. The only time Iris should ever need to refer to a remote job is when restoring an object from a remote snapshot. In all such cases, Iris should use the job_uid field.
        /// </summary>
        /// <value>A unique id for locally created jobs. This should only be used to identify jobs created on the local cluster. When Iris communicates with Magneto, Iris can continue to use this job_id field, which will always be assumed to refer to locally created jobs.  For remotely created jobs, the &#39;job_uid&#39; field should be used. The only time Iris should ever need to refer to a remote job is when restoring an object from a remote snapshot. In all such cases, Iris should use the job_uid field.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobPolicy
        /// </summary>
        [DataMember(Name="jobPolicy", EmitDefaultValue=false)]
        public JobPolicyProto JobPolicy { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Time when this job description was last updated.
        /// </summary>
        /// <value>Time when this job description was last updated.</value>
        [DataMember(Name="lastModificationTimeUsecs", EmitDefaultValue=true)]
        public long? LastModificationTimeUsecs { get; set; }

        /// <summary>
        /// Time when the job was last paused or unpaused.
        /// </summary>
        /// <value>Time when the job was last paused or unpaused.</value>
        [DataMember(Name="lastPauseModificationTimeUsecs", EmitDefaultValue=true)]
        public long? LastPauseModificationTimeUsecs { get; set; }

        /// <summary>
        /// Last reason for pausing the backup job. Capturing the reason will help in resuming only the jobs that were paused because of a reason once the reason for pausing is not applicable.
        /// </summary>
        /// <value>Last reason for pausing the backup job. Capturing the reason will help in resuming only the jobs that were paused because of a reason once the reason for pausing is not applicable.</value>
        [DataMember(Name="lastPauseReason", EmitDefaultValue=true)]
        public int? LastPauseReason { get; set; }

        /// <summary>
        /// Time when this job description was last updated.
        /// </summary>
        /// <value>Time when this job description was last updated.</value>
        [DataMember(Name="lastStartTimeModificationTimeUsecs", EmitDefaultValue=true)]
        public long? LastStartTimeModificationTimeUsecs { get; set; }

        /// <summary>
        /// The user who modified the job most recently.
        /// </summary>
        /// <value>The user who modified the job most recently.</value>
        [DataMember(Name="lastUpdatedUsername", EmitDefaultValue=true)]
        public string LastUpdatedUsername { get; set; }

        /// <summary>
        /// This is set to true by the user if nutanix snapshot is requested This is applicable in case if the vcenter in question is registered as a management server on a prism endpoint. This flag will be ignored at the backend if it is not feasible to leverage nutanix snapshot.
        /// </summary>
        /// <value>This is set to true by the user if nutanix snapshot is requested This is applicable in case if the vcenter in question is registered as a management server on a prism endpoint. This flag will be ignored at the backend if it is not feasible to leverage nutanix snapshot.</value>
        [DataMember(Name="leverageNutanixSnapshots", EmitDefaultValue=true)]
        public bool? LeverageNutanixSnapshots { get; set; }

        /// <summary>
        /// This is set to true by the user in order to backup the objects via a dedicated storage area network (SAN), as opposed to transport via LAN or management network. NOTE: Not all adapters support this method. Currently only VMware.
        /// </summary>
        /// <value>This is set to true by the user in order to backup the objects via a dedicated storage area network (SAN), as opposed to transport via LAN or management network. NOTE: Not all adapters support this method. Currently only VMware.</value>
        [DataMember(Name="leverageSanTransport", EmitDefaultValue=true)]
        public bool? LeverageSanTransport { get; set; }

        /// <summary>
        /// Whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method. NOTE: This will be set for Pure snapshots.
        /// </summary>
        /// <value>Whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method. NOTE: This will be set for Pure snapshots.</value>
        [DataMember(Name="leverageStorageSnapshots", EmitDefaultValue=true)]
        public bool? LeverageStorageSnapshots { get; set; }

        /// <summary>
        /// This is set to true by the user if hyperflex snapshots are requested NOTE: If this is set to true, then leverage_storage_snapshots above should be false.
        /// </summary>
        /// <value>This is set to true by the user if hyperflex snapshots are requested NOTE: If this is set to true, then leverage_storage_snapshots above should be false.</value>
        [DataMember(Name="leverageStorageSnapshotsForHyperflex", EmitDefaultValue=true)]
        public bool? LeverageStorageSnapshotsForHyperflex { get; set; }

        /// <summary>
        /// Gets or Sets LogBackupJobPolicy
        /// </summary>
        [DataMember(Name="logBackupJobPolicy", EmitDefaultValue=false)]
        public JobPolicyProto LogBackupJobPolicy { get; set; }

        /// <summary>
        /// Same as &#39;sla_time_mins&#39; above, but applies to log backups.
        /// </summary>
        /// <value>Same as &#39;sla_time_mins&#39; above, but applies to log backups.</value>
        [DataMember(Name="logBackupSlaTimeMins", EmitDefaultValue=true)]
        public long? LogBackupSlaTimeMins { get; set; }

        /// <summary>
        /// Determines the maximum number of source snapshots allowed for a given entity in the job. This is only applicable if &#39;is_continuous_snapshotting_enabled&#39; is set to true.
        /// </summary>
        /// <value>Determines the maximum number of source snapshots allowed for a given entity in the job. This is only applicable if &#39;is_continuous_snapshotting_enabled&#39; is set to true.</value>
        [DataMember(Name="maxAllowedSourceSnapshots", EmitDefaultValue=true)]
        public int? MaxAllowedSourceSnapshots { get; set; }

        /// <summary>
        /// The name of this backup job. This must be unique across all jobs.
        /// </summary>
        /// <value>The name of this backup job. This must be unique across all jobs.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment. NOTE: This is only applicable for certain environments like kPure.
        /// </summary>
        /// <value>Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment. NOTE: This is only applicable for certain environments like kPure.</value>
        [DataMember(Name="numSnapshotsToKeepOnPrimary", EmitDefaultValue=true)]
        public long? NumSnapshotsToKeepOnPrimary { get; set; }

        /// <summary>
        /// Gets or Sets ObjectBackupSpecUid
        /// </summary>
        [DataMember(Name="objectBackupSpecUid", EmitDefaultValue=false)]
        public UniversalIdProto ObjectBackupSpecUid { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public EntityProto ParentSource { get; set; }

        /// <summary>
        /// This field determines whether a backup run should be paused when it hits a blackout window (assuming that it was started earlier when it was not in an blackout window). The backup run will get resumed when the blackout period ends.
        /// </summary>
        /// <value>This field determines whether a backup run should be paused when it hits a blackout window (assuming that it was started earlier when it was not in an blackout window). The backup run will get resumed when the blackout period ends.</value>
        [DataMember(Name="pauseInBlackoutWindow", EmitDefaultValue=true)]
        public bool? PauseInBlackoutWindow { get; set; }

        /// <summary>
        /// Whether or not to perform source side dedup.
        /// </summary>
        /// <value>Whether or not to perform source side dedup.</value>
        [DataMember(Name="performBrickBasedDedup", EmitDefaultValue=true)]
        public bool? PerformBrickBasedDedup { get; set; }

        /// <summary>
        /// Whether or not to perform source side dedup.
        /// </summary>
        /// <value>Whether or not to perform source side dedup.</value>
        [DataMember(Name="performSourceSideDedup", EmitDefaultValue=true)]
        public bool? PerformSourceSideDedup { get; set; }

        /// <summary>
        /// Epoch time in milliseconds when the policy was last applied to this job. This field will be used to determine whether a policy has changed after it was applied to a particular job.
        /// </summary>
        /// <value>Epoch time in milliseconds when the policy was last applied to this job. This field will be used to determine whether a policy has changed after it was applied to a particular job.</value>
        [DataMember(Name="policyAppliedTimeMsecs", EmitDefaultValue=true)]
        public long? PolicyAppliedTimeMsecs { get; set; }

        /// <summary>
        /// Id of the policy being applied to the backup job. It is expected to be of the form \&quot;cluster_id:cluster_instance_id:local_identifier\&quot;.
        /// </summary>
        /// <value>Id of the policy being applied to the backup job. It is expected to be of the form \&quot;cluster_id:cluster_instance_id:local_identifier\&quot;.</value>
        [DataMember(Name="policyId", EmitDefaultValue=true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The name of the policy referred to by policy_uid. This field can be stale and should not be relied upon for the latest name.
        /// </summary>
        /// <value>The name of the policy referred to by policy_uid. This field can be stale and should not be relied upon for the latest name.</value>
        [DataMember(Name="policyName", EmitDefaultValue=true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PostBackupScript
        /// </summary>
        [DataMember(Name="postBackupScript", EmitDefaultValue=false)]
        public BackupJobPreOrPostScript PostBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets PostSnapshotScript
        /// </summary>
        [DataMember(Name="postSnapshotScript", EmitDefaultValue=false)]
        public BackupJobPreOrPostScript PostSnapshotScript { get; set; }

        /// <summary>
        /// Gets or Sets PreScript
        /// </summary>
        [DataMember(Name="preScript", EmitDefaultValue=false)]
        public BackupJobPreOrPostScript PreScript { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryJobUid
        /// </summary>
        [DataMember(Name="primaryJobUid", EmitDefaultValue=false)]
        public UniversalIdProto PrimaryJobUid { get; set; }

        /// <summary>
        /// The priority for the job. This is used at admission time - all admitted jobs are treated equally. This is also used to determine the Madrox replication priority.
        /// </summary>
        /// <value>The priority for the job. This is used at admission time - all admitted jobs are treated equally. This is also used to determine the Madrox replication priority.</value>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public int? Priority { get; set; }

        /// <summary>
        /// Whether to take app-consistent snapshots by quiescing apps and the filesystem before taking a backup.
        /// </summary>
        /// <value>Whether to take app-consistent snapshots by quiescing apps and the filesystem before taking a backup.</value>
        [DataMember(Name="quiesce", EmitDefaultValue=true)]
        public bool? Quiesce { get; set; }

        /// <summary>
        /// The globally unique ids of all remote jobs that are linked to this job (because of incoming replications). This field will only be populated for locally created jobs. This field is populated only for the local(stub) job during incoming replications. In the most common case of one cluster replicating to another, this field will only have one entry (which is the id of the job on Tx side) and matches the primary_job_uid. This will have multiple entries in the following situation: A-&gt;B, A-&gt;C replication. The backup is failed over to B, and B now starts replicating to C. In this case, the stub job at C will have two entries. One is the job id from cluster A, and another is the local(stub) job uid from B. Also note that since the job originated from A, primary_job_uid for all the replicated instances of this job across multiple clusters will remain the same (which is equal to the job id from the original cluster A).
        /// </summary>
        /// <value>The globally unique ids of all remote jobs that are linked to this job (because of incoming replications). This field will only be populated for locally created jobs. This field is populated only for the local(stub) job during incoming replications. In the most common case of one cluster replicating to another, this field will only have one entry (which is the id of the job on Tx side) and matches the primary_job_uid. This will have multiple entries in the following situation: A-&gt;B, A-&gt;C replication. The backup is failed over to B, and B now starts replicating to C. In this case, the stub job at C will have two entries. One is the job id from cluster A, and another is the local(stub) job uid from B. Also note that since the job originated from A, primary_job_uid for all the replicated instances of this job across multiple clusters will remain the same (which is equal to the job id from the original cluster A).</value>
        [DataMember(Name="remoteJobUids", EmitDefaultValue=true)]
        public List<UniversalIdProto> RemoteJobUids { get; set; }

        /// <summary>
        /// A human readable name of the remote view. A remote view is created with name overwriting the latest snapshot. NOTE: From 6.6 onwards, we support protecting multiple views within a protection group, &#39;remote_view_params&#39; is the new field which captures this information for view backups, &#39;remote_view_name&#39; here is now only used for Remote Adapter jobs (kPuppeteer).
        /// </summary>
        /// <value>A human readable name of the remote view. A remote view is created with name overwriting the latest snapshot. NOTE: From 6.6 onwards, we support protecting multiple views within a protection group, &#39;remote_view_params&#39; is the new field which captures this information for view backups, &#39;remote_view_name&#39; here is now only used for Remote Adapter jobs (kPuppeteer).</value>
        [DataMember(Name="remoteViewName", EmitDefaultValue=true)]
        public string RemoteViewName { get; set; }

        /// <summary>
        /// Gets or Sets RemoteViewParams
        /// </summary>
        [DataMember(Name="remoteViewParams", EmitDefaultValue=false)]
        public BackupJobProtoRemoteViewParams RemoteViewParams { get; set; }

        /// <summary>
        /// The features that are strictly required to be supported by the cluster of the backup job. This is currently used in the following cases: 1. Tx cluster looks at the Rx cluster&#39;s supported features and replicates the backup job only if all the features captured here are supported. 2. When performing remote restore of a backup job from an archival, this job will be retrieved only if the cluster supports all the features listed here.
        /// </summary>
        /// <value>The features that are strictly required to be supported by the cluster of the backup job. This is currently used in the following cases: 1. Tx cluster looks at the Rx cluster&#39;s supported features and replicates the backup job only if all the features captured here are supported. 2. When performing remote restore of a backup job from an archival, this job will be retrieved only if the cluster supports all the features listed here.</value>
        [DataMember(Name="requiredFeatureVec", EmitDefaultValue=true)]
        public List<string> RequiredFeatureVec { get; set; }

        /// <summary>
        /// Whether to skip Rigel for backup or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.
        /// </summary>
        /// <value>Whether to skip Rigel for backup or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.</value>
        [DataMember(Name="skipRigelForBackup", EmitDefaultValue=true)]
        public bool? SkipRigelForBackup { get; set; }

        /// <summary>
        /// If set to true, skips tenant related validations. Default is false.
        /// </summary>
        /// <value>If set to true, skips tenant related validations. Default is false.</value>
        [DataMember(Name="skipTenantValidations", EmitDefaultValue=true)]
        public bool? SkipTenantValidations { get; set; }

        /// <summary>
        /// If specified, this variable determines the amount of time (after backup has started) in which backup is expected to finish for this job. An SLA violation is counted against this job if the amount of time taken exceeds this amount.
        /// </summary>
        /// <value>If specified, this variable determines the amount of time (after backup has started) in which backup is expected to finish for this job. An SLA violation is counted against this job if the amount of time taken exceeds this amount.</value>
        [DataMember(Name="slaTimeMins", EmitDefaultValue=true)]
        public long? SlaTimeMins { get; set; }

        /// <summary>
        /// Gets or Sets SourceFilters
        /// </summary>
        [DataMember(Name="sourceFilters", EmitDefaultValue=false)]
        public SourceFilters SourceFilters { get; set; }

        /// <summary>
        /// The list of sources that should be backed up. A source in this list could be a descendant of another source in the list (this will be used when specifying override backup schedules).
        /// </summary>
        /// <value>The list of sources that should be backed up. A source in this list could be a descendant of another source in the list (this will be used when specifying override backup schedules).</value>
        [DataMember(Name="sources", EmitDefaultValue=true)]
        public List<BackupJobProtoBackupSource> Sources { get; set; }

        /// <summary>
        /// User provided resource(s) for creating a standby VM for each entity present in this backup job. For example in case of VMware, the user will provide the vCenter, datastore and resource pool on which the standby VM should be created. TODO(hmehra) Can the user edit this after the job is created or the resources have been specified?
        /// </summary>
        /// <value>User provided resource(s) for creating a standby VM for each entity present in this backup job. For example in case of VMware, the user will provide the vCenter, datastore and resource pool on which the standby VM should be created. TODO(hmehra) Can the user edit this after the job is created or the resources have been specified?</value>
        [DataMember(Name="standbyResourceVec", EmitDefaultValue=true)]
        public List<StandbyResource> StandbyResourceVec { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public Time StartTime { get; set; }

        /// <summary>
        /// Whether this backup job has a policy for storage array snapshot based backups.
        /// </summary>
        /// <value>Whether this backup job has a policy for storage array snapshot based backups.</value>
        [DataMember(Name="storageArraySnapshot", EmitDefaultValue=true)]
        public bool? StorageArraySnapshot { get; set; }

        /// <summary>
        /// Gets or Sets StubbingPolicy
        /// </summary>
        [DataMember(Name="stubbingPolicy", EmitDefaultValue=false)]
        public StubbingPolicyProto StubbingPolicy { get; set; }

        /// <summary>
        /// Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;.
        /// </summary>
        /// <value>Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;.</value>
        [DataMember(Name="tagVec", EmitDefaultValue=true)]
        public List<string> TagVec { get; set; }

        /// <summary>
        /// This is a vector of timeouts, for different backup types(kFull, kRegular). A cancellation will automatically gets triggered if the backup tasks inside a run has been running for more than this timeout duration.
        /// </summary>
        /// <value>This is a vector of timeouts, for different backup types(kFull, kRegular). A cancellation will automatically gets triggered if the backup tasks inside a run has been running for more than this timeout duration.</value>
        [DataMember(Name="taskTimeoutVec", EmitDefaultValue=true)]
        public List<CancellationTimeout> TaskTimeoutVec { get; set; }

        /// <summary>
        /// Timezone of the backup job. All time fields (i.e., TimeOfDay) in this backup job are stored wrt to this timezone.  The time zones have unique names of the form \&quot;Area/Location\&quot;, e.g. \&quot;America/New_York\&quot;. We are using \&quot;America/Los_Angeles\&quot; as a default value so as to be backward compatible with pre-2.7 code.
        /// </summary>
        /// <value>Timezone of the backup job. All time fields (i.e., TimeOfDay) in this backup job are stored wrt to this timezone.  The time zones have unique names of the form \&quot;Area/Location\&quot;, e.g. \&quot;America/New_York\&quot;. We are using \&quot;America/Los_Angeles\&quot; as a default value so as to be backward compatible with pre-2.7 code.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment.
        /// </summary>
        /// <value>Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment.</value>
        [DataMember(Name="truncateLogs", EmitDefaultValue=true)]
        public bool? TruncateLogs { get; set; }

        /// <summary>
        /// The type of environment this backup job corresponds to.
        /// </summary>
        /// <value>The type of environment this backup job corresponds to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserInformation UserInfo { get; set; }

        /// <summary>
        /// The view box to which data will be written.
        /// </summary>
        /// <value>The view box to which data will be written.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupJobProto);
        }

        /// <summary>
        /// Returns true if BackupJobProto instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbortInExclusionWindow == input.AbortInExclusionWindow ||
                    (this.AbortInExclusionWindow != null &&
                    this.AbortInExclusionWindow.Equals(input.AbortInExclusionWindow))
                ) && 
                (
                    this.AlertingPolicy == input.AlertingPolicy ||
                    (this.AlertingPolicy != null &&
                    this.AlertingPolicy.Equals(input.AlertingPolicy))
                ) && 
                (
                    this.AllArchivalSnapshotsExpired == input.AllArchivalSnapshotsExpired ||
                    (this.AllArchivalSnapshotsExpired != null &&
                    this.AllArchivalSnapshotsExpired.Equals(input.AllArchivalSnapshotsExpired))
                ) && 
                (
                    this.AllInternalReplicationViewsDeleted == input.AllInternalReplicationViewsDeleted ||
                    (this.AllInternalReplicationViewsDeleted != null &&
                    this.AllInternalReplicationViewsDeleted.Equals(input.AllInternalReplicationViewsDeleted))
                ) && 
                (
                    this.AllowParallelRuns == input.AllowParallelRuns ||
                    (this.AllowParallelRuns != null &&
                    this.AllowParallelRuns.Equals(input.AllowParallelRuns))
                ) && 
                (
                    this.BackupQosPrincipal == input.BackupQosPrincipal ||
                    (this.BackupQosPrincipal != null &&
                    this.BackupQosPrincipal.Equals(input.BackupQosPrincipal))
                ) && 
                (
                    this.BackupSourceParams == input.BackupSourceParams ||
                    this.BackupSourceParams != null &&
                    input.BackupSourceParams != null &&
                    this.BackupSourceParams.SequenceEqual(input.BackupSourceParams)
                ) && 
                (
                    this.CloudPostBackupScript == input.CloudPostBackupScript ||
                    (this.CloudPostBackupScript != null &&
                    this.CloudPostBackupScript.Equals(input.CloudPostBackupScript))
                ) && 
                (
                    this.CloudPostSnapshotScript == input.CloudPostSnapshotScript ||
                    (this.CloudPostSnapshotScript != null &&
                    this.CloudPostSnapshotScript.Equals(input.CloudPostSnapshotScript))
                ) && 
                (
                    this.CloudPreBackupScript == input.CloudPreBackupScript ||
                    (this.CloudPreBackupScript != null &&
                    this.CloudPreBackupScript.Equals(input.CloudPreBackupScript))
                ) && 
                (
                    this.ConfigVec == input.ConfigVec ||
                    this.ConfigVec != null &&
                    input.ConfigVec != null &&
                    this.ConfigVec.SequenceEqual(input.ConfigVec)
                ) && 
                (
                    this.ContinueOnQuiesceFailure == input.ContinueOnQuiesceFailure ||
                    (this.ContinueOnQuiesceFailure != null &&
                    this.ContinueOnQuiesceFailure.Equals(input.ContinueOnQuiesceFailure))
                ) && 
                (
                    this.CreateRemoteView == input.CreateRemoteView ||
                    (this.CreateRemoteView != null &&
                    this.CreateRemoteView.Equals(input.CreateRemoteView))
                ) && 
                (
                    this.DataTransferInfo == input.DataTransferInfo ||
                    (this.DataTransferInfo != null &&
                    this.DataTransferInfo.Equals(input.DataTransferInfo))
                ) && 
                (
                    this.DedupDisabledSourceIdVec == input.DedupDisabledSourceIdVec ||
                    this.DedupDisabledSourceIdVec != null &&
                    input.DedupDisabledSourceIdVec != null &&
                    this.DedupDisabledSourceIdVec.SequenceEqual(input.DedupDisabledSourceIdVec)
                ) && 
                (
                    this.DeletionStatus == input.DeletionStatus ||
                    (this.DeletionStatus != null &&
                    this.DeletionStatus.Equals(input.DeletionStatus))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DrToCloudParams == input.DrToCloudParams ||
                    (this.DrToCloudParams != null &&
                    this.DrToCloudParams.Equals(input.DrToCloudParams))
                ) && 
                (
                    this.EhParentSource == input.EhParentSource ||
                    (this.EhParentSource != null &&
                    this.EhParentSource.Equals(input.EhParentSource))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.EnvBackupParams == input.EnvBackupParams ||
                    (this.EnvBackupParams != null &&
                    this.EnvBackupParams.Equals(input.EnvBackupParams))
                ) && 
                (
                    this.ExcludeSources == input.ExcludeSources ||
                    this.ExcludeSources != null &&
                    input.ExcludeSources != null &&
                    this.ExcludeSources.SequenceEqual(input.ExcludeSources)
                ) && 
                (
                    this.ExcludeSourcesDEPRECATED == input.ExcludeSourcesDEPRECATED ||
                    this.ExcludeSourcesDEPRECATED != null &&
                    input.ExcludeSourcesDEPRECATED != null &&
                    this.ExcludeSourcesDEPRECATED.SequenceEqual(input.ExcludeSourcesDEPRECATED)
                ) && 
                (
                    this.ExclusionRanges == input.ExclusionRanges ||
                    this.ExclusionRanges != null &&
                    input.ExclusionRanges != null &&
                    this.ExclusionRanges.SequenceEqual(input.ExclusionRanges)
                ) && 
                (
                    this.FullBackupJobPolicy == input.FullBackupJobPolicy ||
                    (this.FullBackupJobPolicy != null &&
                    this.FullBackupJobPolicy.Equals(input.FullBackupJobPolicy))
                ) && 
                (
                    this.FullBackupSlaTimeMins == input.FullBackupSlaTimeMins ||
                    (this.FullBackupSlaTimeMins != null &&
                    this.FullBackupSlaTimeMins.Equals(input.FullBackupSlaTimeMins))
                ) && 
                (
                    this.GlobalIncludeExclude == input.GlobalIncludeExclude ||
                    (this.GlobalIncludeExclude != null &&
                    this.GlobalIncludeExclude.Equals(input.GlobalIncludeExclude))
                ) && 
                (
                    this.IgnorableErrorsInErrorDb == input.IgnorableErrorsInErrorDb ||
                    this.IgnorableErrorsInErrorDb != null &&
                    input.IgnorableErrorsInErrorDb != null &&
                    this.IgnorableErrorsInErrorDb.SequenceEqual(input.IgnorableErrorsInErrorDb)
                ) && 
                (
                    this.IndexingPolicy == input.IndexingPolicy ||
                    (this.IndexingPolicy != null &&
                    this.IndexingPolicy.Equals(input.IndexingPolicy))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsCdpSyncReplicationEnabled == input.IsCdpSyncReplicationEnabled ||
                    (this.IsCdpSyncReplicationEnabled != null &&
                    this.IsCdpSyncReplicationEnabled.Equals(input.IsCdpSyncReplicationEnabled))
                ) && 
                (
                    this.IsCloudArchiveDirect == input.IsCloudArchiveDirect ||
                    (this.IsCloudArchiveDirect != null &&
                    this.IsCloudArchiveDirect.Equals(input.IsCloudArchiveDirect))
                ) && 
                (
                    this.IsContinuousSnapshottingEnabled == input.IsContinuousSnapshottingEnabled ||
                    (this.IsContinuousSnapshottingEnabled != null &&
                    this.IsContinuousSnapshottingEnabled.Equals(input.IsContinuousSnapshottingEnabled))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.IsDirectArchiveEnabled == input.IsDirectArchiveEnabled ||
                    (this.IsDirectArchiveEnabled != null &&
                    this.IsDirectArchiveEnabled.Equals(input.IsDirectArchiveEnabled))
                ) && 
                (
                    this.IsDirectArchiveNativeFormatEnabled == input.IsDirectArchiveNativeFormatEnabled ||
                    (this.IsDirectArchiveNativeFormatEnabled != null &&
                    this.IsDirectArchiveNativeFormatEnabled.Equals(input.IsDirectArchiveNativeFormatEnabled))
                ) && 
                (
                    this.IsInternal == input.IsInternal ||
                    (this.IsInternal != null &&
                    this.IsInternal.Equals(input.IsInternal))
                ) && 
                (
                    this.IsPaused == input.IsPaused ||
                    (this.IsPaused != null &&
                    this.IsPaused.Equals(input.IsPaused))
                ) && 
                (
                    this.IsRpoJob == input.IsRpoJob ||
                    (this.IsRpoJob != null &&
                    this.IsRpoJob.Equals(input.IsRpoJob))
                ) && 
                (
                    this.IsSourcePausedMap == input.IsSourcePausedMap ||
                    this.IsSourcePausedMap != null &&
                    input.IsSourcePausedMap != null &&
                    this.IsSourcePausedMap.SequenceEqual(input.IsSourcePausedMap)
                ) && 
                (
                    this.JobCreationTimeUsecs == input.JobCreationTimeUsecs ||
                    (this.JobCreationTimeUsecs != null &&
                    this.JobCreationTimeUsecs.Equals(input.JobCreationTimeUsecs))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobPolicy == input.JobPolicy ||
                    (this.JobPolicy != null &&
                    this.JobPolicy.Equals(input.JobPolicy))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.LastModificationTimeUsecs == input.LastModificationTimeUsecs ||
                    (this.LastModificationTimeUsecs != null &&
                    this.LastModificationTimeUsecs.Equals(input.LastModificationTimeUsecs))
                ) && 
                (
                    this.LastPauseModificationTimeUsecs == input.LastPauseModificationTimeUsecs ||
                    (this.LastPauseModificationTimeUsecs != null &&
                    this.LastPauseModificationTimeUsecs.Equals(input.LastPauseModificationTimeUsecs))
                ) && 
                (
                    this.LastPauseReason == input.LastPauseReason ||
                    (this.LastPauseReason != null &&
                    this.LastPauseReason.Equals(input.LastPauseReason))
                ) && 
                (
                    this.LastStartTimeModificationTimeUsecs == input.LastStartTimeModificationTimeUsecs ||
                    (this.LastStartTimeModificationTimeUsecs != null &&
                    this.LastStartTimeModificationTimeUsecs.Equals(input.LastStartTimeModificationTimeUsecs))
                ) && 
                (
                    this.LastUpdatedUsername == input.LastUpdatedUsername ||
                    (this.LastUpdatedUsername != null &&
                    this.LastUpdatedUsername.Equals(input.LastUpdatedUsername))
                ) && 
                (
                    this.LeverageNutanixSnapshots == input.LeverageNutanixSnapshots ||
                    (this.LeverageNutanixSnapshots != null &&
                    this.LeverageNutanixSnapshots.Equals(input.LeverageNutanixSnapshots))
                ) && 
                (
                    this.LeverageSanTransport == input.LeverageSanTransport ||
                    (this.LeverageSanTransport != null &&
                    this.LeverageSanTransport.Equals(input.LeverageSanTransport))
                ) && 
                (
                    this.LeverageStorageSnapshots == input.LeverageStorageSnapshots ||
                    (this.LeverageStorageSnapshots != null &&
                    this.LeverageStorageSnapshots.Equals(input.LeverageStorageSnapshots))
                ) && 
                (
                    this.LeverageStorageSnapshotsForHyperflex == input.LeverageStorageSnapshotsForHyperflex ||
                    (this.LeverageStorageSnapshotsForHyperflex != null &&
                    this.LeverageStorageSnapshotsForHyperflex.Equals(input.LeverageStorageSnapshotsForHyperflex))
                ) && 
                (
                    this.LogBackupJobPolicy == input.LogBackupJobPolicy ||
                    (this.LogBackupJobPolicy != null &&
                    this.LogBackupJobPolicy.Equals(input.LogBackupJobPolicy))
                ) && 
                (
                    this.LogBackupSlaTimeMins == input.LogBackupSlaTimeMins ||
                    (this.LogBackupSlaTimeMins != null &&
                    this.LogBackupSlaTimeMins.Equals(input.LogBackupSlaTimeMins))
                ) && 
                (
                    this.MaxAllowedSourceSnapshots == input.MaxAllowedSourceSnapshots ||
                    (this.MaxAllowedSourceSnapshots != null &&
                    this.MaxAllowedSourceSnapshots.Equals(input.MaxAllowedSourceSnapshots))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumSnapshotsToKeepOnPrimary == input.NumSnapshotsToKeepOnPrimary ||
                    (this.NumSnapshotsToKeepOnPrimary != null &&
                    this.NumSnapshotsToKeepOnPrimary.Equals(input.NumSnapshotsToKeepOnPrimary))
                ) && 
                (
                    this.ObjectBackupSpecUid == input.ObjectBackupSpecUid ||
                    (this.ObjectBackupSpecUid != null &&
                    this.ObjectBackupSpecUid.Equals(input.ObjectBackupSpecUid))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.PauseInBlackoutWindow == input.PauseInBlackoutWindow ||
                    (this.PauseInBlackoutWindow != null &&
                    this.PauseInBlackoutWindow.Equals(input.PauseInBlackoutWindow))
                ) && 
                (
                    this.PerformBrickBasedDedup == input.PerformBrickBasedDedup ||
                    (this.PerformBrickBasedDedup != null &&
                    this.PerformBrickBasedDedup.Equals(input.PerformBrickBasedDedup))
                ) && 
                (
                    this.PerformSourceSideDedup == input.PerformSourceSideDedup ||
                    (this.PerformSourceSideDedup != null &&
                    this.PerformSourceSideDedup.Equals(input.PerformSourceSideDedup))
                ) && 
                (
                    this.PolicyAppliedTimeMsecs == input.PolicyAppliedTimeMsecs ||
                    (this.PolicyAppliedTimeMsecs != null &&
                    this.PolicyAppliedTimeMsecs.Equals(input.PolicyAppliedTimeMsecs))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PostBackupScript == input.PostBackupScript ||
                    (this.PostBackupScript != null &&
                    this.PostBackupScript.Equals(input.PostBackupScript))
                ) && 
                (
                    this.PostSnapshotScript == input.PostSnapshotScript ||
                    (this.PostSnapshotScript != null &&
                    this.PostSnapshotScript.Equals(input.PostSnapshotScript))
                ) && 
                (
                    this.PreScript == input.PreScript ||
                    (this.PreScript != null &&
                    this.PreScript.Equals(input.PreScript))
                ) && 
                (
                    this.PrimaryJobUid == input.PrimaryJobUid ||
                    (this.PrimaryJobUid != null &&
                    this.PrimaryJobUid.Equals(input.PrimaryJobUid))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Quiesce == input.Quiesce ||
                    (this.Quiesce != null &&
                    this.Quiesce.Equals(input.Quiesce))
                ) && 
                (
                    this.RemoteJobUids == input.RemoteJobUids ||
                    this.RemoteJobUids != null &&
                    input.RemoteJobUids != null &&
                    this.RemoteJobUids.SequenceEqual(input.RemoteJobUids)
                ) && 
                (
                    this.RemoteViewName == input.RemoteViewName ||
                    (this.RemoteViewName != null &&
                    this.RemoteViewName.Equals(input.RemoteViewName))
                ) && 
                (
                    this.RemoteViewParams == input.RemoteViewParams ||
                    (this.RemoteViewParams != null &&
                    this.RemoteViewParams.Equals(input.RemoteViewParams))
                ) && 
                (
                    this.RequiredFeatureVec == input.RequiredFeatureVec ||
                    this.RequiredFeatureVec != null &&
                    input.RequiredFeatureVec != null &&
                    this.RequiredFeatureVec.SequenceEqual(input.RequiredFeatureVec)
                ) && 
                (
                    this.SkipRigelForBackup == input.SkipRigelForBackup ||
                    (this.SkipRigelForBackup != null &&
                    this.SkipRigelForBackup.Equals(input.SkipRigelForBackup))
                ) && 
                (
                    this.SkipTenantValidations == input.SkipTenantValidations ||
                    (this.SkipTenantValidations != null &&
                    this.SkipTenantValidations.Equals(input.SkipTenantValidations))
                ) && 
                (
                    this.SlaTimeMins == input.SlaTimeMins ||
                    (this.SlaTimeMins != null &&
                    this.SlaTimeMins.Equals(input.SlaTimeMins))
                ) && 
                (
                    this.SourceFilters == input.SourceFilters ||
                    (this.SourceFilters != null &&
                    this.SourceFilters.Equals(input.SourceFilters))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.StandbyResourceVec == input.StandbyResourceVec ||
                    this.StandbyResourceVec != null &&
                    input.StandbyResourceVec != null &&
                    this.StandbyResourceVec.SequenceEqual(input.StandbyResourceVec)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StorageArraySnapshot == input.StorageArraySnapshot ||
                    (this.StorageArraySnapshot != null &&
                    this.StorageArraySnapshot.Equals(input.StorageArraySnapshot))
                ) && 
                (
                    this.StubbingPolicy == input.StubbingPolicy ||
                    (this.StubbingPolicy != null &&
                    this.StubbingPolicy.Equals(input.StubbingPolicy))
                ) && 
                (
                    this.TagVec == input.TagVec ||
                    this.TagVec != null &&
                    input.TagVec != null &&
                    this.TagVec.SequenceEqual(input.TagVec)
                ) && 
                (
                    this.TaskTimeoutVec == input.TaskTimeoutVec ||
                    this.TaskTimeoutVec != null &&
                    input.TaskTimeoutVec != null &&
                    this.TaskTimeoutVec.SequenceEqual(input.TaskTimeoutVec)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TruncateLogs == input.TruncateLogs ||
                    (this.TruncateLogs != null &&
                    this.TruncateLogs.Equals(input.TruncateLogs))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AbortInExclusionWindow != null)
                    hashCode = hashCode * 59 + this.AbortInExclusionWindow.GetHashCode();
                if (this.AlertingPolicy != null)
                    hashCode = hashCode * 59 + this.AlertingPolicy.GetHashCode();
                if (this.AllArchivalSnapshotsExpired != null)
                    hashCode = hashCode * 59 + this.AllArchivalSnapshotsExpired.GetHashCode();
                if (this.AllInternalReplicationViewsDeleted != null)
                    hashCode = hashCode * 59 + this.AllInternalReplicationViewsDeleted.GetHashCode();
                if (this.AllowParallelRuns != null)
                    hashCode = hashCode * 59 + this.AllowParallelRuns.GetHashCode();
                if (this.BackupQosPrincipal != null)
                    hashCode = hashCode * 59 + this.BackupQosPrincipal.GetHashCode();
                if (this.BackupSourceParams != null)
                    hashCode = hashCode * 59 + this.BackupSourceParams.GetHashCode();
                if (this.CloudPostBackupScript != null)
                    hashCode = hashCode * 59 + this.CloudPostBackupScript.GetHashCode();
                if (this.CloudPostSnapshotScript != null)
                    hashCode = hashCode * 59 + this.CloudPostSnapshotScript.GetHashCode();
                if (this.CloudPreBackupScript != null)
                    hashCode = hashCode * 59 + this.CloudPreBackupScript.GetHashCode();
                if (this.ConfigVec != null)
                    hashCode = hashCode * 59 + this.ConfigVec.GetHashCode();
                if (this.ContinueOnQuiesceFailure != null)
                    hashCode = hashCode * 59 + this.ContinueOnQuiesceFailure.GetHashCode();
                if (this.CreateRemoteView != null)
                    hashCode = hashCode * 59 + this.CreateRemoteView.GetHashCode();
                if (this.DataTransferInfo != null)
                    hashCode = hashCode * 59 + this.DataTransferInfo.GetHashCode();
                if (this.DedupDisabledSourceIdVec != null)
                    hashCode = hashCode * 59 + this.DedupDisabledSourceIdVec.GetHashCode();
                if (this.DeletionStatus != null)
                    hashCode = hashCode * 59 + this.DeletionStatus.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DrToCloudParams != null)
                    hashCode = hashCode * 59 + this.DrToCloudParams.GetHashCode();
                if (this.EhParentSource != null)
                    hashCode = hashCode * 59 + this.EhParentSource.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.EnvBackupParams != null)
                    hashCode = hashCode * 59 + this.EnvBackupParams.GetHashCode();
                if (this.ExcludeSources != null)
                    hashCode = hashCode * 59 + this.ExcludeSources.GetHashCode();
                if (this.ExcludeSourcesDEPRECATED != null)
                    hashCode = hashCode * 59 + this.ExcludeSourcesDEPRECATED.GetHashCode();
                if (this.ExclusionRanges != null)
                    hashCode = hashCode * 59 + this.ExclusionRanges.GetHashCode();
                if (this.FullBackupJobPolicy != null)
                    hashCode = hashCode * 59 + this.FullBackupJobPolicy.GetHashCode();
                if (this.FullBackupSlaTimeMins != null)
                    hashCode = hashCode * 59 + this.FullBackupSlaTimeMins.GetHashCode();
                if (this.GlobalIncludeExclude != null)
                    hashCode = hashCode * 59 + this.GlobalIncludeExclude.GetHashCode();
                if (this.IgnorableErrorsInErrorDb != null)
                    hashCode = hashCode * 59 + this.IgnorableErrorsInErrorDb.GetHashCode();
                if (this.IndexingPolicy != null)
                    hashCode = hashCode * 59 + this.IndexingPolicy.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsCdpSyncReplicationEnabled != null)
                    hashCode = hashCode * 59 + this.IsCdpSyncReplicationEnabled.GetHashCode();
                if (this.IsCloudArchiveDirect != null)
                    hashCode = hashCode * 59 + this.IsCloudArchiveDirect.GetHashCode();
                if (this.IsContinuousSnapshottingEnabled != null)
                    hashCode = hashCode * 59 + this.IsContinuousSnapshottingEnabled.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.IsDirectArchiveEnabled != null)
                    hashCode = hashCode * 59 + this.IsDirectArchiveEnabled.GetHashCode();
                if (this.IsDirectArchiveNativeFormatEnabled != null)
                    hashCode = hashCode * 59 + this.IsDirectArchiveNativeFormatEnabled.GetHashCode();
                if (this.IsInternal != null)
                    hashCode = hashCode * 59 + this.IsInternal.GetHashCode();
                if (this.IsPaused != null)
                    hashCode = hashCode * 59 + this.IsPaused.GetHashCode();
                if (this.IsRpoJob != null)
                    hashCode = hashCode * 59 + this.IsRpoJob.GetHashCode();
                if (this.IsSourcePausedMap != null)
                    hashCode = hashCode * 59 + this.IsSourcePausedMap.GetHashCode();
                if (this.JobCreationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.JobCreationTimeUsecs.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobPolicy != null)
                    hashCode = hashCode * 59 + this.JobPolicy.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.LastModificationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastModificationTimeUsecs.GetHashCode();
                if (this.LastPauseModificationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastPauseModificationTimeUsecs.GetHashCode();
                if (this.LastPauseReason != null)
                    hashCode = hashCode * 59 + this.LastPauseReason.GetHashCode();
                if (this.LastStartTimeModificationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastStartTimeModificationTimeUsecs.GetHashCode();
                if (this.LastUpdatedUsername != null)
                    hashCode = hashCode * 59 + this.LastUpdatedUsername.GetHashCode();
                if (this.LeverageNutanixSnapshots != null)
                    hashCode = hashCode * 59 + this.LeverageNutanixSnapshots.GetHashCode();
                if (this.LeverageSanTransport != null)
                    hashCode = hashCode * 59 + this.LeverageSanTransport.GetHashCode();
                if (this.LeverageStorageSnapshots != null)
                    hashCode = hashCode * 59 + this.LeverageStorageSnapshots.GetHashCode();
                if (this.LeverageStorageSnapshotsForHyperflex != null)
                    hashCode = hashCode * 59 + this.LeverageStorageSnapshotsForHyperflex.GetHashCode();
                if (this.LogBackupJobPolicy != null)
                    hashCode = hashCode * 59 + this.LogBackupJobPolicy.GetHashCode();
                if (this.LogBackupSlaTimeMins != null)
                    hashCode = hashCode * 59 + this.LogBackupSlaTimeMins.GetHashCode();
                if (this.MaxAllowedSourceSnapshots != null)
                    hashCode = hashCode * 59 + this.MaxAllowedSourceSnapshots.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumSnapshotsToKeepOnPrimary != null)
                    hashCode = hashCode * 59 + this.NumSnapshotsToKeepOnPrimary.GetHashCode();
                if (this.ObjectBackupSpecUid != null)
                    hashCode = hashCode * 59 + this.ObjectBackupSpecUid.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.PauseInBlackoutWindow != null)
                    hashCode = hashCode * 59 + this.PauseInBlackoutWindow.GetHashCode();
                if (this.PerformBrickBasedDedup != null)
                    hashCode = hashCode * 59 + this.PerformBrickBasedDedup.GetHashCode();
                if (this.PerformSourceSideDedup != null)
                    hashCode = hashCode * 59 + this.PerformSourceSideDedup.GetHashCode();
                if (this.PolicyAppliedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.PolicyAppliedTimeMsecs.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PostBackupScript != null)
                    hashCode = hashCode * 59 + this.PostBackupScript.GetHashCode();
                if (this.PostSnapshotScript != null)
                    hashCode = hashCode * 59 + this.PostSnapshotScript.GetHashCode();
                if (this.PreScript != null)
                    hashCode = hashCode * 59 + this.PreScript.GetHashCode();
                if (this.PrimaryJobUid != null)
                    hashCode = hashCode * 59 + this.PrimaryJobUid.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Quiesce != null)
                    hashCode = hashCode * 59 + this.Quiesce.GetHashCode();
                if (this.RemoteJobUids != null)
                    hashCode = hashCode * 59 + this.RemoteJobUids.GetHashCode();
                if (this.RemoteViewName != null)
                    hashCode = hashCode * 59 + this.RemoteViewName.GetHashCode();
                if (this.RemoteViewParams != null)
                    hashCode = hashCode * 59 + this.RemoteViewParams.GetHashCode();
                if (this.RequiredFeatureVec != null)
                    hashCode = hashCode * 59 + this.RequiredFeatureVec.GetHashCode();
                if (this.SkipRigelForBackup != null)
                    hashCode = hashCode * 59 + this.SkipRigelForBackup.GetHashCode();
                if (this.SkipTenantValidations != null)
                    hashCode = hashCode * 59 + this.SkipTenantValidations.GetHashCode();
                if (this.SlaTimeMins != null)
                    hashCode = hashCode * 59 + this.SlaTimeMins.GetHashCode();
                if (this.SourceFilters != null)
                    hashCode = hashCode * 59 + this.SourceFilters.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.StandbyResourceVec != null)
                    hashCode = hashCode * 59 + this.StandbyResourceVec.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StorageArraySnapshot != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshot.GetHashCode();
                if (this.StubbingPolicy != null)
                    hashCode = hashCode * 59 + this.StubbingPolicy.GetHashCode();
                if (this.TagVec != null)
                    hashCode = hashCode * 59 + this.TagVec.GetHashCode();
                if (this.TaskTimeoutVec != null)
                    hashCode = hashCode * 59 + this.TaskTimeoutVec.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TruncateLogs != null)
                    hashCode = hashCode * 59 + this.TruncateLogs.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}

