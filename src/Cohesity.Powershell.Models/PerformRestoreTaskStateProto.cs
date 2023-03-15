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
    /// PerformRestoreTaskStateProto
    /// </summary>
    [DataContract]
    public partial class PerformRestoreTaskStateProto :  IEquatable<PerformRestoreTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformRestoreTaskStateProto" /> class.
        /// </summary>
        /// <param name="actionExecutorTargetType">Denotes the target for action executor(Bridge / BridgeProxy) on which task on slave should execute actions..</param>
        /// <param name="backupRunLockVec">Information about the backup runs to lock during this restore..</param>
        /// <param name="_base">_base.</param>
        /// <param name="canTeardown">This is set if the clone operation has created any objects on the primary environment and teardown operation is possible. UI will disable the teardown button only if this is not set or set to false. NOTE: This won&#39;t be reset if the teardown operation subsequently completes as teardown state is managed separately..</param>
        /// <param name="cdpRestoreProgressMonitorTaskPath">The path of the progress monitor for the task that is responsible for creating the CDP hydrated view..</param>
        /// <param name="cdpRestoreTask">cdpRestoreTask.</param>
        /// <param name="cdpRestoreTaskId">The id of the task that will create the CDP hydrated view..</param>
        /// <param name="cdpRestoreViewName">The temporary view where the hydrated disks of the CDP restores are kept..</param>
        /// <param name="childCloneTaskId">The id of the child clone task triggered by refresh op..</param>
        /// <param name="childDestroyTaskId">The following fields are used by clone refresh op. These will be present only in case of refresh task op.  The id of the child destroy clone task triggered by refresh op..</param>
        /// <param name="cloneAppViewInfo">cloneAppViewInfo.</param>
        /// <param name="cloudDeployInfo">cloudDeployInfo.</param>
        /// <param name="continueRestoreOnError">Whether to continue with the restore operation if restore of any object fails..</param>
        /// <param name="createView">True iff the target view needs to be created..</param>
        /// <param name="datastoreEntityVec">Please refer to comments for the field CreateRestoreTaskArg.datastore_entity_vec for more details..</param>
        /// <param name="deployVmsToCloudTaskState">deployVmsToCloudTaskState.</param>
        /// <param name="folderEntity">folderEntity.</param>
        /// <param name="fullViewName">The full view name (internal or external). This is composed of an optional Cohesity specific prefix and the user provided view name..</param>
        /// <param name="includeVmConfig">This is set to true if the vm-config.xml need to be copied in the target view/folder..</param>
        /// <param name="isMultiStageRestore">Whether this task is a multi-stage restore task..</param>
        /// <param name="mountVolumesTaskState">mountVolumesTaskState.</param>
        /// <param name="multiRestoreTaskId">The id of the task that is created to restore multiple apps. For e.g., user requested to restore multiple databases or multiple AD objects. When the user requests to restore &#39;n&#39; objects, we will create &#39;n+1&#39; restore tasks with &#39;n&#39; child tasks and one multi restore task. The relationship is maintained by stamping the id of the multi restore task on all the child tasks using this parameter..</param>
        /// <param name="multiStageRestoreTaskState">multiStageRestoreTaskState.</param>
        /// <param name="nosqlConnectParams">nosqlConnectParams.</param>
        /// <param name="nosqlRecoverJobParams">nosqlRecoverJobParams.</param>
        /// <param name="objectNameDEPRECATED">An optional name to give to the restored object..</param>
        /// <param name="objects">Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job from the latest snapshot, this will have individual objects and the exact snapshot they are being restored from. If specified, this can only have leaf-level entities..</param>
        /// <param name="objectsProgressMonitorTaskPaths">Vector containing the relative task path of progress monitors of the objects in the above field &#39;objects&#39; to be restored. There is one to one correspondence between elements in &#39;objects&#39; and &#39;objects_progress_monitor_task_paths&#39;.  Please note that this field will be set only after progress monitor is created for this restore task..</param>
        /// <param name="parentRestoreJobId">If this a child restore task, this field will contain the id of the parent restore job that spawned this task.  List of env and action type for which this field is applicable are: Acropolis: kRecoverVMs..</param>
        /// <param name="parentRestoreTaskId">The id of the parent restore task if this is a restore sub-task.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware: Used for multi-stage restore that supports a hot-standby.  This will also be used by refresh op to mark the new clone as internal sub-task..</param>
        /// <param name="pathPrefixDEPRECATED">pathPrefixDEPRECATED.</param>
        /// <param name="physicalFlrParallelRestore">If enabled, magneto physical file restore will be enabled via job framework.</param>
        /// <param name="physicalFlrUseNewLockingMethod">If enabled, magneto physical file restore will be enabled via job framework.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="preserveTags">This field is currently used by HyperV and VMWare..</param>
        /// <param name="progressMonitorTaskPath">Root path of a Pulse task tracking the progress of the restore task..</param>
        /// <param name="recoverDisksTaskState">recoverDisksTaskState.</param>
        /// <param name="recoverVolumesTaskState">recoverVolumesTaskState.</param>
        /// <param name="relatedRestoreTaskId">The task id of a related restore task. For example, a SQL restore operation may involve restoring a VM first and then restoring SQL databases after that. So the corresponding VM restore and SQL database restore tasks will be related, and they will each have their &#39;related_restore_task_id&#39; set to the id of the other task..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="renameRestoredVappParam">renameRestoredVappParam.</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="restoreAcropolisVmsParams">restoreAcropolisVmsParams.</param>
        /// <param name="restoreAppTaskState">restoreAppTaskState.</param>
        /// <param name="restoreFilesTaskState">restoreFilesTaskState.</param>
        /// <param name="restoreGroupsParams">restoreGroupsParams.</param>
        /// <param name="restoreHypervVmParams">restoreHypervVmParams.</param>
        /// <param name="restoreInfo">restoreInfo.</param>
        /// <param name="restoreKubernetesNamespacesParams">restoreKubernetesNamespacesParams.</param>
        /// <param name="restoreKvmVmsParams">restoreKvmVmsParams.</param>
        /// <param name="restoreOneDriveParams">restoreOneDriveParams.</param>
        /// <param name="restoreOutlookParams">restoreOutlookParams.</param>
        /// <param name="restoreParentSource">restoreParentSource.</param>
        /// <param name="restorePublicFoldersParams">restorePublicFoldersParams.</param>
        /// <param name="restoreSiteParams">restoreSiteParams.</param>
        /// <param name="restoreStandbyTaskState">restoreStandbyTaskState.</param>
        /// <param name="restoreSubTaskVec">Inside Magneto, these are represented as regular restore tasks with their own PerformRestoreTaskStateProto. Each restore sub-task will have its parent_restore_task_id field set.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware : User for standby restore to store CDPLogApplyRestoreOp id. kOracle : Used for Instant restore for clone..</param>
        /// <param name="restoreTaskPurged">Whether the restore task is purged. During WAL recovery, purged restore tasks are ignored..</param>
        /// <param name="restoreTeamsParams">restoreTeamsParams.</param>
        /// <param name="restoreViewDatastoreEntity">restoreViewDatastoreEntity.</param>
        /// <param name="restoreVmwareVmParams">restoreVmwareVmParams.</param>
        /// <param name="restoredDataStorageDomainId">The storage domain id to which the data is restored.  E.g.: For folder download tasks, this denotes the storage domain (view box) id in which the zip file created by yoda is stored - in case of CAD jobs this could be the auxiliary view box corresponding to the CAD view box, and for regular jobs, this is most likely same as the view box used by that job..</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="restoredToDifferentSource">Whether restore is being performed to a different parent source..</param>
        /// <param name="retrieveArchiveProgressMonitorTaskPath">The path of the progress monitor for the task that is responsible for retrieving the objects from the archive..</param>
        /// <param name="retrieveArchiveStubViewName">The stub view created by Icebox corresponding to the archive. The stub view is used to selectively retrieve files and folders..</param>
        /// <param name="retrieveArchiveTaskUidVec">The uid of the tasks that will retrieve the objects from the archive. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. Hence we may need multiple uids to start retrieval task..</param>
        /// <param name="retrieveArchiveTaskVec">Proto that contains all the information about the retrieve archive task. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. As we may start the multiple retrieval tasks, we need vector of RetrieveArchiveTaskStateProto for storing information of retrieved archive tasks..</param>
        /// <param name="retrieveArchiveViewName">The temporary view where the entities that have been retrieved from an archive have been placed in by Icebox..</param>
        /// <param name="selectedDatastoreIdx">In case of restore job with multi-vm multi-datastore this field denotes the specific datastore index in datastore_entity_vec to be selected for the task. Not going for specific datastore allocation in datastore_entity_vec so that we have required information in case of extensibility for task level retries with different datastore.</param>
        /// <param name="sfdcRecoverJobParams">sfdcRecoverJobParams.</param>
        /// <param name="skipCloningRetrieveArchiveView">Whether Magneto should use the &#39;retrieve_archive_stub_view&#39; above for restore without cloning it. We are currently setting it for Direct archive restores using stub views..</param>
        /// <param name="skipImageDeploy">This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks..</param>
        /// <param name="skipRigelForRestore">Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only..</param>
        /// <param name="stubViewRelativeDirName">Relative directory inside the stub view that corresponds with the archive..</param>
        /// <param name="udaRecoverJobParams">udaRecoverJobParams.</param>
        /// <param name="vaultRestoreParams">vaultRestoreParams.</param>
        /// <param name="vcdConfig">vcdConfig.</param>
        /// <param name="vcdStorageProfileDatastoreMorefVec">This field is applicable for VCD type recovery. It defines the compatible datastores for recovery to alternate location. This field is inferred using the storage profile in restore_vmware_vm_params below..</param>
        /// <param name="viewBoxId">The view box id to which &#39;view_name&#39; belongs to. In case the restore task corresponds to a backup job, this view box corresponds to the view box of the backup job..</param>
        /// <param name="viewNameDEPRECATED">The view name as provided by the user for this restore operation..</param>
        /// <param name="viewParams">viewParams.</param>
        /// <param name="vmRestoreReuseCdpView">Whether VM restore should reuse the cdp restore view while VM recovery..</param>
        /// <param name="volumeInfoVec">Information regarding volumes that are required for the restore task. This is populated for restore files and mount virtual disk ops..</param>
        public PerformRestoreTaskStateProto(int? actionExecutorTargetType = default(int?), List<BackupRunId> backupRunLockVec = default(List<BackupRunId>), RestoreTaskStateBaseProto _base = default(RestoreTaskStateBaseProto), bool? canTeardown = default(bool?), string cdpRestoreProgressMonitorTaskPath = default(string), PerformRestoreTaskStateProto cdpRestoreTask = default(PerformRestoreTaskStateProto), long? cdpRestoreTaskId = default(long?), string cdpRestoreViewName = default(string), long? childCloneTaskId = default(long?), long? childDestroyTaskId = default(long?), CloneAppViewInfoProto cloneAppViewInfo = default(CloneAppViewInfoProto), CloudDeployInfoProto cloudDeployInfo = default(CloudDeployInfoProto), bool? continueRestoreOnError = default(bool?), bool? createView = default(bool?), List<EntityProto> datastoreEntityVec = default(List<EntityProto>), DeployVMsToCloudTaskStateProto deployVmsToCloudTaskState = default(DeployVMsToCloudTaskStateProto), EntityProto folderEntity = default(EntityProto), string fullViewName = default(string), bool? includeVmConfig = default(bool?), bool? isMultiStageRestore = default(bool?), MountVolumesTaskStateProto mountVolumesTaskState = default(MountVolumesTaskStateProto), long? multiRestoreTaskId = default(long?), MultiStageRestoreTaskStateProto multiStageRestoreTaskState = default(MultiStageRestoreTaskStateProto), NoSqlConnectParams nosqlConnectParams = default(NoSqlConnectParams), NoSqlRecoverJobParams nosqlRecoverJobParams = default(NoSqlRecoverJobParams), string objectNameDEPRECATED = default(string), List<RestoreObject> objects = default(List<RestoreObject>), List<string> objectsProgressMonitorTaskPaths = default(List<string>), long? parentRestoreJobId = default(long?), long? parentRestoreTaskId = default(long?), string pathPrefixDEPRECATED = default(string), bool? physicalFlrParallelRestore = default(bool?), bool? physicalFlrUseNewLockingMethod = default(bool?), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), bool? preserveTags = default(bool?), string progressMonitorTaskPath = default(string), RecoverDisksTaskStateProto recoverDisksTaskState = default(RecoverDisksTaskStateProto), RecoverVolumesTaskStateProto recoverVolumesTaskState = default(RecoverVolumesTaskStateProto), long? relatedRestoreTaskId = default(long?), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), RenameObjectParamProto renameRestoredVappParam = default(RenameObjectParamProto), EntityProto resourcePoolEntity = default(EntityProto), RestoreAcropolisVMsParams restoreAcropolisVmsParams = default(RestoreAcropolisVMsParams), RestoreAppTaskStateProto restoreAppTaskState = default(RestoreAppTaskStateProto), RestoreFilesTaskStateProto restoreFilesTaskState = default(RestoreFilesTaskStateProto), RestoreO365GroupsParams restoreGroupsParams = default(RestoreO365GroupsParams), RestoreHyperVVMParams restoreHypervVmParams = default(RestoreHyperVVMParams), RestoreInfoProto restoreInfo = default(RestoreInfoProto), RestoreKubernetesNamespacesParams restoreKubernetesNamespacesParams = default(RestoreKubernetesNamespacesParams), RestoreKVMVMsParams restoreKvmVmsParams = default(RestoreKVMVMsParams), RestoreOneDriveParams restoreOneDriveParams = default(RestoreOneDriveParams), RestoreOutlookParams restoreOutlookParams = default(RestoreOutlookParams), EntityProto restoreParentSource = default(EntityProto), RestoreO365PublicFoldersParams restorePublicFoldersParams = default(RestoreO365PublicFoldersParams), RestoreSiteParams restoreSiteParams = default(RestoreSiteParams), RestoreStandbyTaskStateProto restoreStandbyTaskState = default(RestoreStandbyTaskStateProto), List<long> restoreSubTaskVec = default(List<long>), bool? restoreTaskPurged = default(bool?), RestoreO365TeamsParams restoreTeamsParams = default(RestoreO365TeamsParams), EntityProto restoreViewDatastoreEntity = default(EntityProto), RestoreVMwareVMParams restoreVmwareVmParams = default(RestoreVMwareVMParams), long? restoredDataStorageDomainId = default(long?), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), bool? restoredToDifferentSource = default(bool?), string retrieveArchiveProgressMonitorTaskPath = default(string), string retrieveArchiveStubViewName = default(string), List<UniversalIdProto> retrieveArchiveTaskUidVec = default(List<UniversalIdProto>), List<RetrieveArchiveTaskStateProto> retrieveArchiveTaskVec = default(List<RetrieveArchiveTaskStateProto>), string retrieveArchiveViewName = default(string), long? selectedDatastoreIdx = default(long?), SfdcRecoverJobParams sfdcRecoverJobParams = default(SfdcRecoverJobParams), bool? skipCloningRetrieveArchiveView = default(bool?), bool? skipImageDeploy = default(bool?), bool? skipRigelForRestore = default(bool?), string stubViewRelativeDirName = default(string), UdaRecoverJobParams udaRecoverJobParams = default(UdaRecoverJobParams), VaultParamsRestoreParams vaultRestoreParams = default(VaultParamsRestoreParams), RestoredObjectVCDConfigProto vcdConfig = default(RestoredObjectVCDConfigProto), List<string> vcdStorageProfileDatastoreMorefVec = default(List<string>), long? viewBoxId = default(long?), string viewNameDEPRECATED = default(string), ViewParams viewParams = default(ViewParams), bool? vmRestoreReuseCdpView = default(bool?), List<VolumeInfo> volumeInfoVec = default(List<VolumeInfo>))
        {
            this.ActionExecutorTargetType = actionExecutorTargetType;
            this.BackupRunLockVec = backupRunLockVec;
            this.CanTeardown = canTeardown;
            this.CdpRestoreProgressMonitorTaskPath = cdpRestoreProgressMonitorTaskPath;
            this.CdpRestoreTaskId = cdpRestoreTaskId;
            this.CdpRestoreViewName = cdpRestoreViewName;
            this.ChildCloneTaskId = childCloneTaskId;
            this.ChildDestroyTaskId = childDestroyTaskId;
            this.ContinueRestoreOnError = continueRestoreOnError;
            this.CreateView = createView;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.FullViewName = fullViewName;
            this.IncludeVmConfig = includeVmConfig;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.MultiRestoreTaskId = multiRestoreTaskId;
            this.ObjectNameDEPRECATED = objectNameDEPRECATED;
            this.Objects = objects;
            this.ObjectsProgressMonitorTaskPaths = objectsProgressMonitorTaskPaths;
            this.ParentRestoreJobId = parentRestoreJobId;
            this.ParentRestoreTaskId = parentRestoreTaskId;
            this.PathPrefixDEPRECATED = pathPrefixDEPRECATED;
            this.PhysicalFlrParallelRestore = physicalFlrParallelRestore;
            this.PhysicalFlrUseNewLockingMethod = physicalFlrUseNewLockingMethod;
            this.PreserveTags = preserveTags;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RelatedRestoreTaskId = relatedRestoreTaskId;
            this.RestoreSubTaskVec = restoreSubTaskVec;
            this.RestoreTaskPurged = restoreTaskPurged;
            this.RestoredDataStorageDomainId = restoredDataStorageDomainId;
            this.RestoredToDifferentSource = restoredToDifferentSource;
            this.RetrieveArchiveProgressMonitorTaskPath = retrieveArchiveProgressMonitorTaskPath;
            this.RetrieveArchiveStubViewName = retrieveArchiveStubViewName;
            this.RetrieveArchiveTaskUidVec = retrieveArchiveTaskUidVec;
            this.RetrieveArchiveTaskVec = retrieveArchiveTaskVec;
            this.RetrieveArchiveViewName = retrieveArchiveViewName;
            this.SelectedDatastoreIdx = selectedDatastoreIdx;
            this.SkipCloningRetrieveArchiveView = skipCloningRetrieveArchiveView;
            this.SkipImageDeploy = skipImageDeploy;
            this.SkipRigelForRestore = skipRigelForRestore;
            this.StubViewRelativeDirName = stubViewRelativeDirName;
            this.VcdStorageProfileDatastoreMorefVec = vcdStorageProfileDatastoreMorefVec;
            this.ViewBoxId = viewBoxId;
            this.ViewNameDEPRECATED = viewNameDEPRECATED;
            this.VmRestoreReuseCdpView = vmRestoreReuseCdpView;
            this.VolumeInfoVec = volumeInfoVec;
            this.ActionExecutorTargetType = actionExecutorTargetType;
            this.BackupRunLockVec = backupRunLockVec;
            this.Base = _base;
            this.CanTeardown = canTeardown;
            this.CdpRestoreProgressMonitorTaskPath = cdpRestoreProgressMonitorTaskPath;
            this.CdpRestoreTask = cdpRestoreTask;
            this.CdpRestoreTaskId = cdpRestoreTaskId;
            this.CdpRestoreViewName = cdpRestoreViewName;
            this.ChildCloneTaskId = childCloneTaskId;
            this.ChildDestroyTaskId = childDestroyTaskId;
            this.CloneAppViewInfo = cloneAppViewInfo;
            this.CloudDeployInfo = cloudDeployInfo;
            this.ContinueRestoreOnError = continueRestoreOnError;
            this.CreateView = createView;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.DeployVmsToCloudTaskState = deployVmsToCloudTaskState;
            this.FolderEntity = folderEntity;
            this.FullViewName = fullViewName;
            this.IncludeVmConfig = includeVmConfig;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.MountVolumesTaskState = mountVolumesTaskState;
            this.MultiRestoreTaskId = multiRestoreTaskId;
            this.MultiStageRestoreTaskState = multiStageRestoreTaskState;
            this.NosqlConnectParams = nosqlConnectParams;
            this.NosqlRecoverJobParams = nosqlRecoverJobParams;
            this.ObjectNameDEPRECATED = objectNameDEPRECATED;
            this.Objects = objects;
            this.ObjectsProgressMonitorTaskPaths = objectsProgressMonitorTaskPaths;
            this.ParentRestoreJobId = parentRestoreJobId;
            this.ParentRestoreTaskId = parentRestoreTaskId;
            this.PathPrefixDEPRECATED = pathPrefixDEPRECATED;
            this.PhysicalFlrParallelRestore = physicalFlrParallelRestore;
            this.PhysicalFlrUseNewLockingMethod = physicalFlrUseNewLockingMethod;
            this.PowerStateConfig = powerStateConfig;
            this.PreserveTags = preserveTags;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RecoverDisksTaskState = recoverDisksTaskState;
            this.RecoverVolumesTaskState = recoverVolumesTaskState;
            this.RelatedRestoreTaskId = relatedRestoreTaskId;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.RenameRestoredVappParam = renameRestoredVappParam;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.RestoreAcropolisVmsParams = restoreAcropolisVmsParams;
            this.RestoreAppTaskState = restoreAppTaskState;
            this.RestoreFilesTaskState = restoreFilesTaskState;
            this.RestoreGroupsParams = restoreGroupsParams;
            this.RestoreHypervVmParams = restoreHypervVmParams;
            this.RestoreInfo = restoreInfo;
            this.RestoreKubernetesNamespacesParams = restoreKubernetesNamespacesParams;
            this.RestoreKvmVmsParams = restoreKvmVmsParams;
            this.RestoreOneDriveParams = restoreOneDriveParams;
            this.RestoreOutlookParams = restoreOutlookParams;
            this.RestoreParentSource = restoreParentSource;
            this.RestorePublicFoldersParams = restorePublicFoldersParams;
            this.RestoreSiteParams = restoreSiteParams;
            this.RestoreStandbyTaskState = restoreStandbyTaskState;
            this.RestoreSubTaskVec = restoreSubTaskVec;
            this.RestoreTaskPurged = restoreTaskPurged;
            this.RestoreTeamsParams = restoreTeamsParams;
            this.RestoreViewDatastoreEntity = restoreViewDatastoreEntity;
            this.RestoreVmwareVmParams = restoreVmwareVmParams;
            this.RestoredDataStorageDomainId = restoredDataStorageDomainId;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.RestoredToDifferentSource = restoredToDifferentSource;
            this.RetrieveArchiveProgressMonitorTaskPath = retrieveArchiveProgressMonitorTaskPath;
            this.RetrieveArchiveStubViewName = retrieveArchiveStubViewName;
            this.RetrieveArchiveTaskUidVec = retrieveArchiveTaskUidVec;
            this.RetrieveArchiveTaskVec = retrieveArchiveTaskVec;
            this.RetrieveArchiveViewName = retrieveArchiveViewName;
            this.SelectedDatastoreIdx = selectedDatastoreIdx;
            this.SfdcRecoverJobParams = sfdcRecoverJobParams;
            this.SkipCloningRetrieveArchiveView = skipCloningRetrieveArchiveView;
            this.SkipImageDeploy = skipImageDeploy;
            this.SkipRigelForRestore = skipRigelForRestore;
            this.StubViewRelativeDirName = stubViewRelativeDirName;
            this.UdaRecoverJobParams = udaRecoverJobParams;
            this.VaultRestoreParams = vaultRestoreParams;
            this.VcdConfig = vcdConfig;
            this.VcdStorageProfileDatastoreMorefVec = vcdStorageProfileDatastoreMorefVec;
            this.ViewBoxId = viewBoxId;
            this.ViewNameDEPRECATED = viewNameDEPRECATED;
            this.ViewParams = viewParams;
            this.VmRestoreReuseCdpView = vmRestoreReuseCdpView;
            this.VolumeInfoVec = volumeInfoVec;
        }
        
        /// <summary>
        /// Denotes the target for action executor(Bridge / BridgeProxy) on which task on slave should execute actions.
        /// </summary>
        /// <value>Denotes the target for action executor(Bridge / BridgeProxy) on which task on slave should execute actions.</value>
        [DataMember(Name="actionExecutorTargetType", EmitDefaultValue=true)]
        public int? ActionExecutorTargetType { get; set; }

        /// <summary>
        /// Information about the backup runs to lock during this restore.
        /// </summary>
        /// <value>Information about the backup runs to lock during this restore.</value>
        [DataMember(Name="backupRunLockVec", EmitDefaultValue=true)]
        public List<BackupRunId> BackupRunLockVec { get; set; }

        /// <summary>
        /// Gets or Sets Base
        /// </summary>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public RestoreTaskStateBaseProto Base { get; set; }

        /// <summary>
        /// This is set if the clone operation has created any objects on the primary environment and teardown operation is possible. UI will disable the teardown button only if this is not set or set to false. NOTE: This won&#39;t be reset if the teardown operation subsequently completes as teardown state is managed separately.
        /// </summary>
        /// <value>This is set if the clone operation has created any objects on the primary environment and teardown operation is possible. UI will disable the teardown button only if this is not set or set to false. NOTE: This won&#39;t be reset if the teardown operation subsequently completes as teardown state is managed separately.</value>
        [DataMember(Name="canTeardown", EmitDefaultValue=true)]
        public bool? CanTeardown { get; set; }

        /// <summary>
        /// The path of the progress monitor for the task that is responsible for creating the CDP hydrated view.
        /// </summary>
        /// <value>The path of the progress monitor for the task that is responsible for creating the CDP hydrated view.</value>
        [DataMember(Name="cdpRestoreProgressMonitorTaskPath", EmitDefaultValue=true)]
        public string CdpRestoreProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets CdpRestoreTask
        /// </summary>
        [DataMember(Name="cdpRestoreTask", EmitDefaultValue=false)]
        public PerformRestoreTaskStateProto CdpRestoreTask { get; set; }

        /// <summary>
        /// The id of the task that will create the CDP hydrated view.
        /// </summary>
        /// <value>The id of the task that will create the CDP hydrated view.</value>
        [DataMember(Name="cdpRestoreTaskId", EmitDefaultValue=true)]
        public long? CdpRestoreTaskId { get; set; }

        /// <summary>
        /// The temporary view where the hydrated disks of the CDP restores are kept.
        /// </summary>
        /// <value>The temporary view where the hydrated disks of the CDP restores are kept.</value>
        [DataMember(Name="cdpRestoreViewName", EmitDefaultValue=true)]
        public string CdpRestoreViewName { get; set; }

        /// <summary>
        /// The id of the child clone task triggered by refresh op.
        /// </summary>
        /// <value>The id of the child clone task triggered by refresh op.</value>
        [DataMember(Name="childCloneTaskId", EmitDefaultValue=true)]
        public long? ChildCloneTaskId { get; set; }

        /// <summary>
        /// The following fields are used by clone refresh op. These will be present only in case of refresh task op.  The id of the child destroy clone task triggered by refresh op.
        /// </summary>
        /// <value>The following fields are used by clone refresh op. These will be present only in case of refresh task op.  The id of the child destroy clone task triggered by refresh op.</value>
        [DataMember(Name="childDestroyTaskId", EmitDefaultValue=true)]
        public long? ChildDestroyTaskId { get; set; }

        /// <summary>
        /// Gets or Sets CloneAppViewInfo
        /// </summary>
        [DataMember(Name="cloneAppViewInfo", EmitDefaultValue=false)]
        public CloneAppViewInfoProto CloneAppViewInfo { get; set; }

        /// <summary>
        /// Gets or Sets CloudDeployInfo
        /// </summary>
        [DataMember(Name="cloudDeployInfo", EmitDefaultValue=false)]
        public CloudDeployInfoProto CloudDeployInfo { get; set; }

        /// <summary>
        /// Whether to continue with the restore operation if restore of any object fails.
        /// </summary>
        /// <value>Whether to continue with the restore operation if restore of any object fails.</value>
        [DataMember(Name="continueRestoreOnError", EmitDefaultValue=true)]
        public bool? ContinueRestoreOnError { get; set; }

        /// <summary>
        /// True iff the target view needs to be created.
        /// </summary>
        /// <value>True iff the target view needs to be created.</value>
        [DataMember(Name="createView", EmitDefaultValue=true)]
        public bool? CreateView { get; set; }

        /// <summary>
        /// Please refer to comments for the field CreateRestoreTaskArg.datastore_entity_vec for more details.
        /// </summary>
        /// <value>Please refer to comments for the field CreateRestoreTaskArg.datastore_entity_vec for more details.</value>
        [DataMember(Name="datastoreEntityVec", EmitDefaultValue=true)]
        public List<EntityProto> DatastoreEntityVec { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToCloudTaskState
        /// </summary>
        [DataMember(Name="deployVmsToCloudTaskState", EmitDefaultValue=false)]
        public DeployVMsToCloudTaskStateProto DeployVmsToCloudTaskState { get; set; }

        /// <summary>
        /// Gets or Sets FolderEntity
        /// </summary>
        [DataMember(Name="folderEntity", EmitDefaultValue=false)]
        public EntityProto FolderEntity { get; set; }

        /// <summary>
        /// The full view name (internal or external). This is composed of an optional Cohesity specific prefix and the user provided view name.
        /// </summary>
        /// <value>The full view name (internal or external). This is composed of an optional Cohesity specific prefix and the user provided view name.</value>
        [DataMember(Name="fullViewName", EmitDefaultValue=true)]
        public string FullViewName { get; set; }

        /// <summary>
        /// This is set to true if the vm-config.xml need to be copied in the target view/folder.
        /// </summary>
        /// <value>This is set to true if the vm-config.xml need to be copied in the target view/folder.</value>
        [DataMember(Name="includeVmConfig", EmitDefaultValue=true)]
        public bool? IncludeVmConfig { get; set; }

        /// <summary>
        /// Whether this task is a multi-stage restore task.
        /// </summary>
        /// <value>Whether this task is a multi-stage restore task.</value>
        [DataMember(Name="isMultiStageRestore", EmitDefaultValue=true)]
        public bool? IsMultiStageRestore { get; set; }

        /// <summary>
        /// Gets or Sets MountVolumesTaskState
        /// </summary>
        [DataMember(Name="mountVolumesTaskState", EmitDefaultValue=false)]
        public MountVolumesTaskStateProto MountVolumesTaskState { get; set; }

        /// <summary>
        /// The id of the task that is created to restore multiple apps. For e.g., user requested to restore multiple databases or multiple AD objects. When the user requests to restore &#39;n&#39; objects, we will create &#39;n+1&#39; restore tasks with &#39;n&#39; child tasks and one multi restore task. The relationship is maintained by stamping the id of the multi restore task on all the child tasks using this parameter.
        /// </summary>
        /// <value>The id of the task that is created to restore multiple apps. For e.g., user requested to restore multiple databases or multiple AD objects. When the user requests to restore &#39;n&#39; objects, we will create &#39;n+1&#39; restore tasks with &#39;n&#39; child tasks and one multi restore task. The relationship is maintained by stamping the id of the multi restore task on all the child tasks using this parameter.</value>
        [DataMember(Name="multiRestoreTaskId", EmitDefaultValue=true)]
        public long? MultiRestoreTaskId { get; set; }

        /// <summary>
        /// Gets or Sets MultiStageRestoreTaskState
        /// </summary>
        [DataMember(Name="multiStageRestoreTaskState", EmitDefaultValue=false)]
        public MultiStageRestoreTaskStateProto MultiStageRestoreTaskState { get; set; }

        /// <summary>
        /// Gets or Sets NosqlConnectParams
        /// </summary>
        [DataMember(Name="nosqlConnectParams", EmitDefaultValue=false)]
        public NoSqlConnectParams NosqlConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets NosqlRecoverJobParams
        /// </summary>
        [DataMember(Name="nosqlRecoverJobParams", EmitDefaultValue=false)]
        public NoSqlRecoverJobParams NosqlRecoverJobParams { get; set; }

        /// <summary>
        /// An optional name to give to the restored object.
        /// </summary>
        /// <value>An optional name to give to the restored object.</value>
        [DataMember(Name="objectName_DEPRECATED", EmitDefaultValue=true)]
        public string ObjectNameDEPRECATED { get; set; }

        /// <summary>
        /// Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job from the latest snapshot, this will have individual objects and the exact snapshot they are being restored from. If specified, this can only have leaf-level entities.
        /// </summary>
        /// <value>Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job from the latest snapshot, this will have individual objects and the exact snapshot they are being restored from. If specified, this can only have leaf-level entities.</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObject> Objects { get; set; }

        /// <summary>
        /// Vector containing the relative task path of progress monitors of the objects in the above field &#39;objects&#39; to be restored. There is one to one correspondence between elements in &#39;objects&#39; and &#39;objects_progress_monitor_task_paths&#39;.  Please note that this field will be set only after progress monitor is created for this restore task.
        /// </summary>
        /// <value>Vector containing the relative task path of progress monitors of the objects in the above field &#39;objects&#39; to be restored. There is one to one correspondence between elements in &#39;objects&#39; and &#39;objects_progress_monitor_task_paths&#39;.  Please note that this field will be set only after progress monitor is created for this restore task.</value>
        [DataMember(Name="objectsProgressMonitorTaskPaths", EmitDefaultValue=true)]
        public List<string> ObjectsProgressMonitorTaskPaths { get; set; }

        /// <summary>
        /// If this a child restore task, this field will contain the id of the parent restore job that spawned this task.  List of env and action type for which this field is applicable are: Acropolis: kRecoverVMs.
        /// </summary>
        /// <value>If this a child restore task, this field will contain the id of the parent restore job that spawned this task.  List of env and action type for which this field is applicable are: Acropolis: kRecoverVMs.</value>
        [DataMember(Name="parentRestoreJobId", EmitDefaultValue=true)]
        public long? ParentRestoreJobId { get; set; }

        /// <summary>
        /// The id of the parent restore task if this is a restore sub-task.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware: Used for multi-stage restore that supports a hot-standby.  This will also be used by refresh op to mark the new clone as internal sub-task.
        /// </summary>
        /// <value>The id of the parent restore task if this is a restore sub-task.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware: Used for multi-stage restore that supports a hot-standby.  This will also be used by refresh op to mark the new clone as internal sub-task.</value>
        [DataMember(Name="parentRestoreTaskId", EmitDefaultValue=true)]
        public long? ParentRestoreTaskId { get; set; }

        /// <summary>
        /// Gets or Sets PathPrefixDEPRECATED
        /// </summary>
        [DataMember(Name="pathPrefix_DEPRECATED", EmitDefaultValue=true)]
        public string PathPrefixDEPRECATED { get; set; }

        /// <summary>
        /// If enabled, magneto physical file restore will be enabled via job framework
        /// </summary>
        /// <value>If enabled, magneto physical file restore will be enabled via job framework</value>
        [DataMember(Name="physicalFlrParallelRestore", EmitDefaultValue=true)]
        public bool? PhysicalFlrParallelRestore { get; set; }

        /// <summary>
        /// If enabled, magneto physical file restore will be enabled via job framework
        /// </summary>
        /// <value>If enabled, magneto physical file restore will be enabled via job framework</value>
        [DataMember(Name="physicalFlrUseNewLockingMethod", EmitDefaultValue=true)]
        public bool? PhysicalFlrUseNewLockingMethod { get; set; }

        /// <summary>
        /// Gets or Sets PowerStateConfig
        /// </summary>
        [DataMember(Name="powerStateConfig", EmitDefaultValue=false)]
        public PowerStateConfigProto PowerStateConfig { get; set; }

        /// <summary>
        /// This field is currently used by HyperV and VMWare.
        /// </summary>
        /// <value>This field is currently used by HyperV and VMWare.</value>
        [DataMember(Name="preserveTags", EmitDefaultValue=true)]
        public bool? PreserveTags { get; set; }

        /// <summary>
        /// Root path of a Pulse task tracking the progress of the restore task.
        /// </summary>
        /// <value>Root path of a Pulse task tracking the progress of the restore task.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets RecoverDisksTaskState
        /// </summary>
        [DataMember(Name="recoverDisksTaskState", EmitDefaultValue=false)]
        public RecoverDisksTaskStateProto RecoverDisksTaskState { get; set; }

        /// <summary>
        /// Gets or Sets RecoverVolumesTaskState
        /// </summary>
        [DataMember(Name="recoverVolumesTaskState", EmitDefaultValue=false)]
        public RecoverVolumesTaskStateProto RecoverVolumesTaskState { get; set; }

        /// <summary>
        /// The task id of a related restore task. For example, a SQL restore operation may involve restoring a VM first and then restoring SQL databases after that. So the corresponding VM restore and SQL database restore tasks will be related, and they will each have their &#39;related_restore_task_id&#39; set to the id of the other task.
        /// </summary>
        /// <value>The task id of a related restore task. For example, a SQL restore operation may involve restoring a VM first and then restoring SQL databases after that. So the corresponding VM restore and SQL database restore tasks will be related, and they will each have their &#39;related_restore_task_id&#39; set to the id of the other task.</value>
        [DataMember(Name="relatedRestoreTaskId", EmitDefaultValue=true)]
        public long? RelatedRestoreTaskId { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredObjectParam
        /// </summary>
        [DataMember(Name="renameRestoredObjectParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredObjectParam { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredVappParam
        /// </summary>
        [DataMember(Name="renameRestoredVappParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredVappParam { get; set; }

        /// <summary>
        /// Gets or Sets ResourcePoolEntity
        /// </summary>
        [DataMember(Name="resourcePoolEntity", EmitDefaultValue=false)]
        public EntityProto ResourcePoolEntity { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAcropolisVmsParams
        /// </summary>
        [DataMember(Name="restoreAcropolisVmsParams", EmitDefaultValue=false)]
        public RestoreAcropolisVMsParams RestoreAcropolisVmsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAppTaskState
        /// </summary>
        [DataMember(Name="restoreAppTaskState", EmitDefaultValue=false)]
        public RestoreAppTaskStateProto RestoreAppTaskState { get; set; }

        /// <summary>
        /// Gets or Sets RestoreFilesTaskState
        /// </summary>
        [DataMember(Name="restoreFilesTaskState", EmitDefaultValue=false)]
        public RestoreFilesTaskStateProto RestoreFilesTaskState { get; set; }

        /// <summary>
        /// Gets or Sets RestoreGroupsParams
        /// </summary>
        [DataMember(Name="restoreGroupsParams", EmitDefaultValue=false)]
        public RestoreO365GroupsParams RestoreGroupsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreHypervVmParams
        /// </summary>
        [DataMember(Name="restoreHypervVmParams", EmitDefaultValue=false)]
        public RestoreHyperVVMParams RestoreHypervVmParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreInfo
        /// </summary>
        [DataMember(Name="restoreInfo", EmitDefaultValue=false)]
        public RestoreInfoProto RestoreInfo { get; set; }

        /// <summary>
        /// Gets or Sets RestoreKubernetesNamespacesParams
        /// </summary>
        [DataMember(Name="restoreKubernetesNamespacesParams", EmitDefaultValue=false)]
        public RestoreKubernetesNamespacesParams RestoreKubernetesNamespacesParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreKvmVmsParams
        /// </summary>
        [DataMember(Name="restoreKvmVmsParams", EmitDefaultValue=false)]
        public RestoreKVMVMsParams RestoreKvmVmsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreOneDriveParams
        /// </summary>
        [DataMember(Name="restoreOneDriveParams", EmitDefaultValue=false)]
        public RestoreOneDriveParams RestoreOneDriveParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreOutlookParams
        /// </summary>
        [DataMember(Name="restoreOutlookParams", EmitDefaultValue=false)]
        public RestoreOutlookParams RestoreOutlookParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParentSource
        /// </summary>
        [DataMember(Name="restoreParentSource", EmitDefaultValue=false)]
        public EntityProto RestoreParentSource { get; set; }

        /// <summary>
        /// Gets or Sets RestorePublicFoldersParams
        /// </summary>
        [DataMember(Name="restorePublicFoldersParams", EmitDefaultValue=false)]
        public RestoreO365PublicFoldersParams RestorePublicFoldersParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreSiteParams
        /// </summary>
        [DataMember(Name="restoreSiteParams", EmitDefaultValue=false)]
        public RestoreSiteParams RestoreSiteParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreStandbyTaskState
        /// </summary>
        [DataMember(Name="restoreStandbyTaskState", EmitDefaultValue=false)]
        public RestoreStandbyTaskStateProto RestoreStandbyTaskState { get; set; }

        /// <summary>
        /// Inside Magneto, these are represented as regular restore tasks with their own PerformRestoreTaskStateProto. Each restore sub-task will have its parent_restore_task_id field set.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware : User for standby restore to store CDPLogApplyRestoreOp id. kOracle : Used for Instant restore for clone.
        /// </summary>
        /// <value>Inside Magneto, these are represented as regular restore tasks with their own PerformRestoreTaskStateProto. Each restore sub-task will have its parent_restore_task_id field set.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standby. kVMware : User for standby restore to store CDPLogApplyRestoreOp id. kOracle : Used for Instant restore for clone.</value>
        [DataMember(Name="restoreSubTaskVec", EmitDefaultValue=true)]
        public List<long> RestoreSubTaskVec { get; set; }

        /// <summary>
        /// Whether the restore task is purged. During WAL recovery, purged restore tasks are ignored.
        /// </summary>
        /// <value>Whether the restore task is purged. During WAL recovery, purged restore tasks are ignored.</value>
        [DataMember(Name="restoreTaskPurged", EmitDefaultValue=true)]
        public bool? RestoreTaskPurged { get; set; }

        /// <summary>
        /// Gets or Sets RestoreTeamsParams
        /// </summary>
        [DataMember(Name="restoreTeamsParams", EmitDefaultValue=false)]
        public RestoreO365TeamsParams RestoreTeamsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreViewDatastoreEntity
        /// </summary>
        [DataMember(Name="restoreViewDatastoreEntity", EmitDefaultValue=false)]
        public EntityProto RestoreViewDatastoreEntity { get; set; }

        /// <summary>
        /// Gets or Sets RestoreVmwareVmParams
        /// </summary>
        [DataMember(Name="restoreVmwareVmParams", EmitDefaultValue=false)]
        public RestoreVMwareVMParams RestoreVmwareVmParams { get; set; }

        /// <summary>
        /// The storage domain id to which the data is restored.  E.g.: For folder download tasks, this denotes the storage domain (view box) id in which the zip file created by yoda is stored - in case of CAD jobs this could be the auxiliary view box corresponding to the CAD view box, and for regular jobs, this is most likely same as the view box used by that job.
        /// </summary>
        /// <value>The storage domain id to which the data is restored.  E.g.: For folder download tasks, this denotes the storage domain (view box) id in which the zip file created by yoda is stored - in case of CAD jobs this could be the auxiliary view box corresponding to the CAD view box, and for regular jobs, this is most likely same as the view box used by that job.</value>
        [DataMember(Name="restoredDataStorageDomainId", EmitDefaultValue=true)]
        public long? RestoredDataStorageDomainId { get; set; }

        /// <summary>
        /// Gets or Sets RestoredObjectsNetworkConfig
        /// </summary>
        [DataMember(Name="restoredObjectsNetworkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto RestoredObjectsNetworkConfig { get; set; }

        /// <summary>
        /// Whether restore is being performed to a different parent source.
        /// </summary>
        /// <value>Whether restore is being performed to a different parent source.</value>
        [DataMember(Name="restoredToDifferentSource", EmitDefaultValue=true)]
        public bool? RestoredToDifferentSource { get; set; }

        /// <summary>
        /// The path of the progress monitor for the task that is responsible for retrieving the objects from the archive.
        /// </summary>
        /// <value>The path of the progress monitor for the task that is responsible for retrieving the objects from the archive.</value>
        [DataMember(Name="retrieveArchiveProgressMonitorTaskPath", EmitDefaultValue=true)]
        public string RetrieveArchiveProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// The stub view created by Icebox corresponding to the archive. The stub view is used to selectively retrieve files and folders.
        /// </summary>
        /// <value>The stub view created by Icebox corresponding to the archive. The stub view is used to selectively retrieve files and folders.</value>
        [DataMember(Name="retrieveArchiveStubViewName", EmitDefaultValue=true)]
        public string RetrieveArchiveStubViewName { get; set; }

        /// <summary>
        /// The uid of the tasks that will retrieve the objects from the archive. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. Hence we may need multiple uids to start retrieval task.
        /// </summary>
        /// <value>The uid of the tasks that will retrieve the objects from the archive. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. Hence we may need multiple uids to start retrieval task.</value>
        [DataMember(Name="retrieveArchiveTaskUidVec", EmitDefaultValue=true)]
        public List<UniversalIdProto> RetrieveArchiveTaskUidVec { get; set; }

        /// <summary>
        /// Proto that contains all the information about the retrieve archive task. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. As we may start the multiple retrieval tasks, we need vector of RetrieveArchiveTaskStateProto for storing information of retrieved archive tasks.
        /// </summary>
        /// <value>Proto that contains all the information about the retrieve archive task. Typically we only retrieve one snapshot for an enity but for point in time restores for SQL/Oracle database, we may need to retrieve multiple snapshots typically one full, and few logs. As we may start the multiple retrieval tasks, we need vector of RetrieveArchiveTaskStateProto for storing information of retrieved archive tasks.</value>
        [DataMember(Name="retrieveArchiveTaskVec", EmitDefaultValue=true)]
        public List<RetrieveArchiveTaskStateProto> RetrieveArchiveTaskVec { get; set; }

        /// <summary>
        /// The temporary view where the entities that have been retrieved from an archive have been placed in by Icebox.
        /// </summary>
        /// <value>The temporary view where the entities that have been retrieved from an archive have been placed in by Icebox.</value>
        [DataMember(Name="retrieveArchiveViewName", EmitDefaultValue=true)]
        public string RetrieveArchiveViewName { get; set; }

        /// <summary>
        /// In case of restore job with multi-vm multi-datastore this field denotes the specific datastore index in datastore_entity_vec to be selected for the task. Not going for specific datastore allocation in datastore_entity_vec so that we have required information in case of extensibility for task level retries with different datastore
        /// </summary>
        /// <value>In case of restore job with multi-vm multi-datastore this field denotes the specific datastore index in datastore_entity_vec to be selected for the task. Not going for specific datastore allocation in datastore_entity_vec so that we have required information in case of extensibility for task level retries with different datastore</value>
        [DataMember(Name="selectedDatastoreIdx", EmitDefaultValue=true)]
        public long? SelectedDatastoreIdx { get; set; }

        /// <summary>
        /// Gets or Sets SfdcRecoverJobParams
        /// </summary>
        [DataMember(Name="sfdcRecoverJobParams", EmitDefaultValue=false)]
        public SfdcRecoverJobParams SfdcRecoverJobParams { get; set; }

        /// <summary>
        /// Whether Magneto should use the &#39;retrieve_archive_stub_view&#39; above for restore without cloning it. We are currently setting it for Direct archive restores using stub views.
        /// </summary>
        /// <value>Whether Magneto should use the &#39;retrieve_archive_stub_view&#39; above for restore without cloning it. We are currently setting it for Direct archive restores using stub views.</value>
        [DataMember(Name="skipCloningRetrieveArchiveView", EmitDefaultValue=true)]
        public bool? SkipCloningRetrieveArchiveView { get; set; }

        /// <summary>
        /// This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks.
        /// </summary>
        /// <value>This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks.</value>
        [DataMember(Name="skipImageDeploy", EmitDefaultValue=true)]
        public bool? SkipImageDeploy { get; set; }

        /// <summary>
        /// Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.
        /// </summary>
        /// <value>Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.</value>
        [DataMember(Name="skipRigelForRestore", EmitDefaultValue=true)]
        public bool? SkipRigelForRestore { get; set; }

        /// <summary>
        /// Relative directory inside the stub view that corresponds with the archive.
        /// </summary>
        /// <value>Relative directory inside the stub view that corresponds with the archive.</value>
        [DataMember(Name="stubViewRelativeDirName", EmitDefaultValue=true)]
        public string StubViewRelativeDirName { get; set; }

        /// <summary>
        /// Gets or Sets UdaRecoverJobParams
        /// </summary>
        [DataMember(Name="udaRecoverJobParams", EmitDefaultValue=false)]
        public UdaRecoverJobParams UdaRecoverJobParams { get; set; }

        /// <summary>
        /// Gets or Sets VaultRestoreParams
        /// </summary>
        [DataMember(Name="vaultRestoreParams", EmitDefaultValue=false)]
        public VaultParamsRestoreParams VaultRestoreParams { get; set; }

        /// <summary>
        /// Gets or Sets VcdConfig
        /// </summary>
        [DataMember(Name="vcdConfig", EmitDefaultValue=false)]
        public RestoredObjectVCDConfigProto VcdConfig { get; set; }

        /// <summary>
        /// This field is applicable for VCD type recovery. It defines the compatible datastores for recovery to alternate location. This field is inferred using the storage profile in restore_vmware_vm_params below.
        /// </summary>
        /// <value>This field is applicable for VCD type recovery. It defines the compatible datastores for recovery to alternate location. This field is inferred using the storage profile in restore_vmware_vm_params below.</value>
        [DataMember(Name="vcdStorageProfileDatastoreMorefVec", EmitDefaultValue=true)]
        public List<string> VcdStorageProfileDatastoreMorefVec { get; set; }

        /// <summary>
        /// The view box id to which &#39;view_name&#39; belongs to. In case the restore task corresponds to a backup job, this view box corresponds to the view box of the backup job.
        /// </summary>
        /// <value>The view box id to which &#39;view_name&#39; belongs to. In case the restore task corresponds to a backup job, this view box corresponds to the view box of the backup job.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// The view name as provided by the user for this restore operation.
        /// </summary>
        /// <value>The view name as provided by the user for this restore operation.</value>
        [DataMember(Name="viewName_DEPRECATED", EmitDefaultValue=true)]
        public string ViewNameDEPRECATED { get; set; }

        /// <summary>
        /// Gets or Sets ViewParams
        /// </summary>
        [DataMember(Name="viewParams", EmitDefaultValue=false)]
        public ViewParams ViewParams { get; set; }

        /// <summary>
        /// Whether VM restore should reuse the cdp restore view while VM recovery.
        /// </summary>
        /// <value>Whether VM restore should reuse the cdp restore view while VM recovery.</value>
        [DataMember(Name="vmRestoreReuseCdpView", EmitDefaultValue=true)]
        public bool? VmRestoreReuseCdpView { get; set; }

        /// <summary>
        /// Information regarding volumes that are required for the restore task. This is populated for restore files and mount virtual disk ops.
        /// </summary>
        /// <value>Information regarding volumes that are required for the restore task. This is populated for restore files and mount virtual disk ops.</value>
        [DataMember(Name="volumeInfoVec", EmitDefaultValue=true)]
        public List<VolumeInfo> VolumeInfoVec { get; set; }

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
            return this.Equals(input as PerformRestoreTaskStateProto);
        }

        /// <summary>
        /// Returns true if PerformRestoreTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformRestoreTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformRestoreTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionExecutorTargetType == input.ActionExecutorTargetType ||
                    (this.ActionExecutorTargetType != null &&
                    this.ActionExecutorTargetType.Equals(input.ActionExecutorTargetType))
                ) && 
                (
                    this.BackupRunLockVec == input.BackupRunLockVec ||
                    this.BackupRunLockVec != null &&
                    input.BackupRunLockVec != null &&
                    this.BackupRunLockVec.SequenceEqual(input.BackupRunLockVec)
                ) && 
                (
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.CanTeardown == input.CanTeardown ||
                    (this.CanTeardown != null &&
                    this.CanTeardown.Equals(input.CanTeardown))
                ) && 
                (
                    this.CdpRestoreProgressMonitorTaskPath == input.CdpRestoreProgressMonitorTaskPath ||
                    (this.CdpRestoreProgressMonitorTaskPath != null &&
                    this.CdpRestoreProgressMonitorTaskPath.Equals(input.CdpRestoreProgressMonitorTaskPath))
                ) && 
                (
                    this.CdpRestoreTask == input.CdpRestoreTask ||
                    (this.CdpRestoreTask != null &&
                    this.CdpRestoreTask.Equals(input.CdpRestoreTask))
                ) && 
                (
                    this.CdpRestoreTaskId == input.CdpRestoreTaskId ||
                    (this.CdpRestoreTaskId != null &&
                    this.CdpRestoreTaskId.Equals(input.CdpRestoreTaskId))
                ) && 
                (
                    this.CdpRestoreViewName == input.CdpRestoreViewName ||
                    (this.CdpRestoreViewName != null &&
                    this.CdpRestoreViewName.Equals(input.CdpRestoreViewName))
                ) && 
                (
                    this.ChildCloneTaskId == input.ChildCloneTaskId ||
                    (this.ChildCloneTaskId != null &&
                    this.ChildCloneTaskId.Equals(input.ChildCloneTaskId))
                ) && 
                (
                    this.ChildDestroyTaskId == input.ChildDestroyTaskId ||
                    (this.ChildDestroyTaskId != null &&
                    this.ChildDestroyTaskId.Equals(input.ChildDestroyTaskId))
                ) && 
                (
                    this.CloneAppViewInfo == input.CloneAppViewInfo ||
                    (this.CloneAppViewInfo != null &&
                    this.CloneAppViewInfo.Equals(input.CloneAppViewInfo))
                ) && 
                (
                    this.CloudDeployInfo == input.CloudDeployInfo ||
                    (this.CloudDeployInfo != null &&
                    this.CloudDeployInfo.Equals(input.CloudDeployInfo))
                ) && 
                (
                    this.ContinueRestoreOnError == input.ContinueRestoreOnError ||
                    (this.ContinueRestoreOnError != null &&
                    this.ContinueRestoreOnError.Equals(input.ContinueRestoreOnError))
                ) && 
                (
                    this.CreateView == input.CreateView ||
                    (this.CreateView != null &&
                    this.CreateView.Equals(input.CreateView))
                ) && 
                (
                    this.DatastoreEntityVec == input.DatastoreEntityVec ||
                    this.DatastoreEntityVec != null &&
                    input.DatastoreEntityVec != null &&
                    this.DatastoreEntityVec.SequenceEqual(input.DatastoreEntityVec)
                ) && 
                (
                    this.DeployVmsToCloudTaskState == input.DeployVmsToCloudTaskState ||
                    (this.DeployVmsToCloudTaskState != null &&
                    this.DeployVmsToCloudTaskState.Equals(input.DeployVmsToCloudTaskState))
                ) && 
                (
                    this.FolderEntity == input.FolderEntity ||
                    (this.FolderEntity != null &&
                    this.FolderEntity.Equals(input.FolderEntity))
                ) && 
                (
                    this.FullViewName == input.FullViewName ||
                    (this.FullViewName != null &&
                    this.FullViewName.Equals(input.FullViewName))
                ) && 
                (
                    this.IncludeVmConfig == input.IncludeVmConfig ||
                    (this.IncludeVmConfig != null &&
                    this.IncludeVmConfig.Equals(input.IncludeVmConfig))
                ) && 
                (
                    this.IsMultiStageRestore == input.IsMultiStageRestore ||
                    (this.IsMultiStageRestore != null &&
                    this.IsMultiStageRestore.Equals(input.IsMultiStageRestore))
                ) && 
                (
                    this.MountVolumesTaskState == input.MountVolumesTaskState ||
                    (this.MountVolumesTaskState != null &&
                    this.MountVolumesTaskState.Equals(input.MountVolumesTaskState))
                ) && 
                (
                    this.MultiRestoreTaskId == input.MultiRestoreTaskId ||
                    (this.MultiRestoreTaskId != null &&
                    this.MultiRestoreTaskId.Equals(input.MultiRestoreTaskId))
                ) && 
                (
                    this.MultiStageRestoreTaskState == input.MultiStageRestoreTaskState ||
                    (this.MultiStageRestoreTaskState != null &&
                    this.MultiStageRestoreTaskState.Equals(input.MultiStageRestoreTaskState))
                ) && 
                (
                    this.NosqlConnectParams == input.NosqlConnectParams ||
                    (this.NosqlConnectParams != null &&
                    this.NosqlConnectParams.Equals(input.NosqlConnectParams))
                ) && 
                (
                    this.NosqlRecoverJobParams == input.NosqlRecoverJobParams ||
                    (this.NosqlRecoverJobParams != null &&
                    this.NosqlRecoverJobParams.Equals(input.NosqlRecoverJobParams))
                ) && 
                (
                    this.ObjectNameDEPRECATED == input.ObjectNameDEPRECATED ||
                    (this.ObjectNameDEPRECATED != null &&
                    this.ObjectNameDEPRECATED.Equals(input.ObjectNameDEPRECATED))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.ObjectsProgressMonitorTaskPaths == input.ObjectsProgressMonitorTaskPaths ||
                    this.ObjectsProgressMonitorTaskPaths != null &&
                    input.ObjectsProgressMonitorTaskPaths != null &&
                    this.ObjectsProgressMonitorTaskPaths.SequenceEqual(input.ObjectsProgressMonitorTaskPaths)
                ) && 
                (
                    this.ParentRestoreJobId == input.ParentRestoreJobId ||
                    (this.ParentRestoreJobId != null &&
                    this.ParentRestoreJobId.Equals(input.ParentRestoreJobId))
                ) && 
                (
                    this.ParentRestoreTaskId == input.ParentRestoreTaskId ||
                    (this.ParentRestoreTaskId != null &&
                    this.ParentRestoreTaskId.Equals(input.ParentRestoreTaskId))
                ) && 
                (
                    this.PathPrefixDEPRECATED == input.PathPrefixDEPRECATED ||
                    (this.PathPrefixDEPRECATED != null &&
                    this.PathPrefixDEPRECATED.Equals(input.PathPrefixDEPRECATED))
                ) && 
                (
                    this.PhysicalFlrParallelRestore == input.PhysicalFlrParallelRestore ||
                    (this.PhysicalFlrParallelRestore != null &&
                    this.PhysicalFlrParallelRestore.Equals(input.PhysicalFlrParallelRestore))
                ) && 
                (
                    this.PhysicalFlrUseNewLockingMethod == input.PhysicalFlrUseNewLockingMethod ||
                    (this.PhysicalFlrUseNewLockingMethod != null &&
                    this.PhysicalFlrUseNewLockingMethod.Equals(input.PhysicalFlrUseNewLockingMethod))
                ) && 
                (
                    this.PowerStateConfig == input.PowerStateConfig ||
                    (this.PowerStateConfig != null &&
                    this.PowerStateConfig.Equals(input.PowerStateConfig))
                ) && 
                (
                    this.PreserveTags == input.PreserveTags ||
                    (this.PreserveTags != null &&
                    this.PreserveTags.Equals(input.PreserveTags))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.RecoverDisksTaskState == input.RecoverDisksTaskState ||
                    (this.RecoverDisksTaskState != null &&
                    this.RecoverDisksTaskState.Equals(input.RecoverDisksTaskState))
                ) && 
                (
                    this.RecoverVolumesTaskState == input.RecoverVolumesTaskState ||
                    (this.RecoverVolumesTaskState != null &&
                    this.RecoverVolumesTaskState.Equals(input.RecoverVolumesTaskState))
                ) && 
                (
                    this.RelatedRestoreTaskId == input.RelatedRestoreTaskId ||
                    (this.RelatedRestoreTaskId != null &&
                    this.RelatedRestoreTaskId.Equals(input.RelatedRestoreTaskId))
                ) && 
                (
                    this.RenameRestoredObjectParam == input.RenameRestoredObjectParam ||
                    (this.RenameRestoredObjectParam != null &&
                    this.RenameRestoredObjectParam.Equals(input.RenameRestoredObjectParam))
                ) && 
                (
                    this.RenameRestoredVappParam == input.RenameRestoredVappParam ||
                    (this.RenameRestoredVappParam != null &&
                    this.RenameRestoredVappParam.Equals(input.RenameRestoredVappParam))
                ) && 
                (
                    this.ResourcePoolEntity == input.ResourcePoolEntity ||
                    (this.ResourcePoolEntity != null &&
                    this.ResourcePoolEntity.Equals(input.ResourcePoolEntity))
                ) && 
                (
                    this.RestoreAcropolisVmsParams == input.RestoreAcropolisVmsParams ||
                    (this.RestoreAcropolisVmsParams != null &&
                    this.RestoreAcropolisVmsParams.Equals(input.RestoreAcropolisVmsParams))
                ) && 
                (
                    this.RestoreAppTaskState == input.RestoreAppTaskState ||
                    (this.RestoreAppTaskState != null &&
                    this.RestoreAppTaskState.Equals(input.RestoreAppTaskState))
                ) && 
                (
                    this.RestoreFilesTaskState == input.RestoreFilesTaskState ||
                    (this.RestoreFilesTaskState != null &&
                    this.RestoreFilesTaskState.Equals(input.RestoreFilesTaskState))
                ) && 
                (
                    this.RestoreGroupsParams == input.RestoreGroupsParams ||
                    (this.RestoreGroupsParams != null &&
                    this.RestoreGroupsParams.Equals(input.RestoreGroupsParams))
                ) && 
                (
                    this.RestoreHypervVmParams == input.RestoreHypervVmParams ||
                    (this.RestoreHypervVmParams != null &&
                    this.RestoreHypervVmParams.Equals(input.RestoreHypervVmParams))
                ) && 
                (
                    this.RestoreInfo == input.RestoreInfo ||
                    (this.RestoreInfo != null &&
                    this.RestoreInfo.Equals(input.RestoreInfo))
                ) && 
                (
                    this.RestoreKubernetesNamespacesParams == input.RestoreKubernetesNamespacesParams ||
                    (this.RestoreKubernetesNamespacesParams != null &&
                    this.RestoreKubernetesNamespacesParams.Equals(input.RestoreKubernetesNamespacesParams))
                ) && 
                (
                    this.RestoreKvmVmsParams == input.RestoreKvmVmsParams ||
                    (this.RestoreKvmVmsParams != null &&
                    this.RestoreKvmVmsParams.Equals(input.RestoreKvmVmsParams))
                ) && 
                (
                    this.RestoreOneDriveParams == input.RestoreOneDriveParams ||
                    (this.RestoreOneDriveParams != null &&
                    this.RestoreOneDriveParams.Equals(input.RestoreOneDriveParams))
                ) && 
                (
                    this.RestoreOutlookParams == input.RestoreOutlookParams ||
                    (this.RestoreOutlookParams != null &&
                    this.RestoreOutlookParams.Equals(input.RestoreOutlookParams))
                ) && 
                (
                    this.RestoreParentSource == input.RestoreParentSource ||
                    (this.RestoreParentSource != null &&
                    this.RestoreParentSource.Equals(input.RestoreParentSource))
                ) && 
                (
                    this.RestorePublicFoldersParams == input.RestorePublicFoldersParams ||
                    (this.RestorePublicFoldersParams != null &&
                    this.RestorePublicFoldersParams.Equals(input.RestorePublicFoldersParams))
                ) && 
                (
                    this.RestoreSiteParams == input.RestoreSiteParams ||
                    (this.RestoreSiteParams != null &&
                    this.RestoreSiteParams.Equals(input.RestoreSiteParams))
                ) && 
                (
                    this.RestoreStandbyTaskState == input.RestoreStandbyTaskState ||
                    (this.RestoreStandbyTaskState != null &&
                    this.RestoreStandbyTaskState.Equals(input.RestoreStandbyTaskState))
                ) && 
                (
                    this.RestoreSubTaskVec == input.RestoreSubTaskVec ||
                    this.RestoreSubTaskVec != null &&
                    input.RestoreSubTaskVec != null &&
                    this.RestoreSubTaskVec.SequenceEqual(input.RestoreSubTaskVec)
                ) && 
                (
                    this.RestoreTaskPurged == input.RestoreTaskPurged ||
                    (this.RestoreTaskPurged != null &&
                    this.RestoreTaskPurged.Equals(input.RestoreTaskPurged))
                ) && 
                (
                    this.RestoreTeamsParams == input.RestoreTeamsParams ||
                    (this.RestoreTeamsParams != null &&
                    this.RestoreTeamsParams.Equals(input.RestoreTeamsParams))
                ) && 
                (
                    this.RestoreViewDatastoreEntity == input.RestoreViewDatastoreEntity ||
                    (this.RestoreViewDatastoreEntity != null &&
                    this.RestoreViewDatastoreEntity.Equals(input.RestoreViewDatastoreEntity))
                ) && 
                (
                    this.RestoreVmwareVmParams == input.RestoreVmwareVmParams ||
                    (this.RestoreVmwareVmParams != null &&
                    this.RestoreVmwareVmParams.Equals(input.RestoreVmwareVmParams))
                ) && 
                (
                    this.RestoredDataStorageDomainId == input.RestoredDataStorageDomainId ||
                    (this.RestoredDataStorageDomainId != null &&
                    this.RestoredDataStorageDomainId.Equals(input.RestoredDataStorageDomainId))
                ) && 
                (
                    this.RestoredObjectsNetworkConfig == input.RestoredObjectsNetworkConfig ||
                    (this.RestoredObjectsNetworkConfig != null &&
                    this.RestoredObjectsNetworkConfig.Equals(input.RestoredObjectsNetworkConfig))
                ) && 
                (
                    this.RestoredToDifferentSource == input.RestoredToDifferentSource ||
                    (this.RestoredToDifferentSource != null &&
                    this.RestoredToDifferentSource.Equals(input.RestoredToDifferentSource))
                ) && 
                (
                    this.RetrieveArchiveProgressMonitorTaskPath == input.RetrieveArchiveProgressMonitorTaskPath ||
                    (this.RetrieveArchiveProgressMonitorTaskPath != null &&
                    this.RetrieveArchiveProgressMonitorTaskPath.Equals(input.RetrieveArchiveProgressMonitorTaskPath))
                ) && 
                (
                    this.RetrieveArchiveStubViewName == input.RetrieveArchiveStubViewName ||
                    (this.RetrieveArchiveStubViewName != null &&
                    this.RetrieveArchiveStubViewName.Equals(input.RetrieveArchiveStubViewName))
                ) && 
                (
                    this.RetrieveArchiveTaskUidVec == input.RetrieveArchiveTaskUidVec ||
                    this.RetrieveArchiveTaskUidVec != null &&
                    input.RetrieveArchiveTaskUidVec != null &&
                    this.RetrieveArchiveTaskUidVec.SequenceEqual(input.RetrieveArchiveTaskUidVec)
                ) && 
                (
                    this.RetrieveArchiveTaskVec == input.RetrieveArchiveTaskVec ||
                    this.RetrieveArchiveTaskVec != null &&
                    input.RetrieveArchiveTaskVec != null &&
                    this.RetrieveArchiveTaskVec.SequenceEqual(input.RetrieveArchiveTaskVec)
                ) && 
                (
                    this.RetrieveArchiveViewName == input.RetrieveArchiveViewName ||
                    (this.RetrieveArchiveViewName != null &&
                    this.RetrieveArchiveViewName.Equals(input.RetrieveArchiveViewName))
                ) && 
                (
                    this.SelectedDatastoreIdx == input.SelectedDatastoreIdx ||
                    (this.SelectedDatastoreIdx != null &&
                    this.SelectedDatastoreIdx.Equals(input.SelectedDatastoreIdx))
                ) && 
                (
                    this.SfdcRecoverJobParams == input.SfdcRecoverJobParams ||
                    (this.SfdcRecoverJobParams != null &&
                    this.SfdcRecoverJobParams.Equals(input.SfdcRecoverJobParams))
                ) && 
                (
                    this.SkipCloningRetrieveArchiveView == input.SkipCloningRetrieveArchiveView ||
                    (this.SkipCloningRetrieveArchiveView != null &&
                    this.SkipCloningRetrieveArchiveView.Equals(input.SkipCloningRetrieveArchiveView))
                ) && 
                (
                    this.SkipImageDeploy == input.SkipImageDeploy ||
                    (this.SkipImageDeploy != null &&
                    this.SkipImageDeploy.Equals(input.SkipImageDeploy))
                ) && 
                (
                    this.SkipRigelForRestore == input.SkipRigelForRestore ||
                    (this.SkipRigelForRestore != null &&
                    this.SkipRigelForRestore.Equals(input.SkipRigelForRestore))
                ) && 
                (
                    this.StubViewRelativeDirName == input.StubViewRelativeDirName ||
                    (this.StubViewRelativeDirName != null &&
                    this.StubViewRelativeDirName.Equals(input.StubViewRelativeDirName))
                ) && 
                (
                    this.UdaRecoverJobParams == input.UdaRecoverJobParams ||
                    (this.UdaRecoverJobParams != null &&
                    this.UdaRecoverJobParams.Equals(input.UdaRecoverJobParams))
                ) && 
                (
                    this.VaultRestoreParams == input.VaultRestoreParams ||
                    (this.VaultRestoreParams != null &&
                    this.VaultRestoreParams.Equals(input.VaultRestoreParams))
                ) && 
                (
                    this.VcdConfig == input.VcdConfig ||
                    (this.VcdConfig != null &&
                    this.VcdConfig.Equals(input.VcdConfig))
                ) && 
                (
                    this.VcdStorageProfileDatastoreMorefVec == input.VcdStorageProfileDatastoreMorefVec ||
                    this.VcdStorageProfileDatastoreMorefVec != null &&
                    input.VcdStorageProfileDatastoreMorefVec != null &&
                    this.VcdStorageProfileDatastoreMorefVec.SequenceEqual(input.VcdStorageProfileDatastoreMorefVec)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewNameDEPRECATED == input.ViewNameDEPRECATED ||
                    (this.ViewNameDEPRECATED != null &&
                    this.ViewNameDEPRECATED.Equals(input.ViewNameDEPRECATED))
                ) && 
                (
                    this.ViewParams == input.ViewParams ||
                    (this.ViewParams != null &&
                    this.ViewParams.Equals(input.ViewParams))
                ) && 
                (
                    this.VmRestoreReuseCdpView == input.VmRestoreReuseCdpView ||
                    (this.VmRestoreReuseCdpView != null &&
                    this.VmRestoreReuseCdpView.Equals(input.VmRestoreReuseCdpView))
                ) && 
                (
                    this.VolumeInfoVec == input.VolumeInfoVec ||
                    this.VolumeInfoVec != null &&
                    input.VolumeInfoVec != null &&
                    this.VolumeInfoVec.SequenceEqual(input.VolumeInfoVec)
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
                if (this.ActionExecutorTargetType != null)
                    hashCode = hashCode * 59 + this.ActionExecutorTargetType.GetHashCode();
                if (this.BackupRunLockVec != null)
                    hashCode = hashCode * 59 + this.BackupRunLockVec.GetHashCode();
                if (this.Base != null)
                    hashCode = hashCode * 59 + this.Base.GetHashCode();
                if (this.CanTeardown != null)
                    hashCode = hashCode * 59 + this.CanTeardown.GetHashCode();
                if (this.CdpRestoreProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.CdpRestoreProgressMonitorTaskPath.GetHashCode();
                if (this.CdpRestoreTask != null)
                    hashCode = hashCode * 59 + this.CdpRestoreTask.GetHashCode();
                if (this.CdpRestoreTaskId != null)
                    hashCode = hashCode * 59 + this.CdpRestoreTaskId.GetHashCode();
                if (this.CdpRestoreViewName != null)
                    hashCode = hashCode * 59 + this.CdpRestoreViewName.GetHashCode();
                if (this.ChildCloneTaskId != null)
                    hashCode = hashCode * 59 + this.ChildCloneTaskId.GetHashCode();
                if (this.ChildDestroyTaskId != null)
                    hashCode = hashCode * 59 + this.ChildDestroyTaskId.GetHashCode();
                if (this.CloneAppViewInfo != null)
                    hashCode = hashCode * 59 + this.CloneAppViewInfo.GetHashCode();
                if (this.CloudDeployInfo != null)
                    hashCode = hashCode * 59 + this.CloudDeployInfo.GetHashCode();
                if (this.ContinueRestoreOnError != null)
                    hashCode = hashCode * 59 + this.ContinueRestoreOnError.GetHashCode();
                if (this.CreateView != null)
                    hashCode = hashCode * 59 + this.CreateView.GetHashCode();
                if (this.DatastoreEntityVec != null)
                    hashCode = hashCode * 59 + this.DatastoreEntityVec.GetHashCode();
                if (this.DeployVmsToCloudTaskState != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloudTaskState.GetHashCode();
                if (this.FolderEntity != null)
                    hashCode = hashCode * 59 + this.FolderEntity.GetHashCode();
                if (this.FullViewName != null)
                    hashCode = hashCode * 59 + this.FullViewName.GetHashCode();
                if (this.IncludeVmConfig != null)
                    hashCode = hashCode * 59 + this.IncludeVmConfig.GetHashCode();
                if (this.IsMultiStageRestore != null)
                    hashCode = hashCode * 59 + this.IsMultiStageRestore.GetHashCode();
                if (this.MountVolumesTaskState != null)
                    hashCode = hashCode * 59 + this.MountVolumesTaskState.GetHashCode();
                if (this.MultiRestoreTaskId != null)
                    hashCode = hashCode * 59 + this.MultiRestoreTaskId.GetHashCode();
                if (this.MultiStageRestoreTaskState != null)
                    hashCode = hashCode * 59 + this.MultiStageRestoreTaskState.GetHashCode();
                if (this.NosqlConnectParams != null)
                    hashCode = hashCode * 59 + this.NosqlConnectParams.GetHashCode();
                if (this.NosqlRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.NosqlRecoverJobParams.GetHashCode();
                if (this.ObjectNameDEPRECATED != null)
                    hashCode = hashCode * 59 + this.ObjectNameDEPRECATED.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.ObjectsProgressMonitorTaskPaths != null)
                    hashCode = hashCode * 59 + this.ObjectsProgressMonitorTaskPaths.GetHashCode();
                if (this.ParentRestoreJobId != null)
                    hashCode = hashCode * 59 + this.ParentRestoreJobId.GetHashCode();
                if (this.ParentRestoreTaskId != null)
                    hashCode = hashCode * 59 + this.ParentRestoreTaskId.GetHashCode();
                if (this.PathPrefixDEPRECATED != null)
                    hashCode = hashCode * 59 + this.PathPrefixDEPRECATED.GetHashCode();
                if (this.PhysicalFlrParallelRestore != null)
                    hashCode = hashCode * 59 + this.PhysicalFlrParallelRestore.GetHashCode();
                if (this.PhysicalFlrUseNewLockingMethod != null)
                    hashCode = hashCode * 59 + this.PhysicalFlrUseNewLockingMethod.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.PreserveTags != null)
                    hashCode = hashCode * 59 + this.PreserveTags.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RecoverDisksTaskState != null)
                    hashCode = hashCode * 59 + this.RecoverDisksTaskState.GetHashCode();
                if (this.RecoverVolumesTaskState != null)
                    hashCode = hashCode * 59 + this.RecoverVolumesTaskState.GetHashCode();
                if (this.RelatedRestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RelatedRestoreTaskId.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.RenameRestoredVappParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredVappParam.GetHashCode();
                if (this.ResourcePoolEntity != null)
                    hashCode = hashCode * 59 + this.ResourcePoolEntity.GetHashCode();
                if (this.RestoreAcropolisVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreAcropolisVmsParams.GetHashCode();
                if (this.RestoreAppTaskState != null)
                    hashCode = hashCode * 59 + this.RestoreAppTaskState.GetHashCode();
                if (this.RestoreFilesTaskState != null)
                    hashCode = hashCode * 59 + this.RestoreFilesTaskState.GetHashCode();
                if (this.RestoreGroupsParams != null)
                    hashCode = hashCode * 59 + this.RestoreGroupsParams.GetHashCode();
                if (this.RestoreHypervVmParams != null)
                    hashCode = hashCode * 59 + this.RestoreHypervVmParams.GetHashCode();
                if (this.RestoreInfo != null)
                    hashCode = hashCode * 59 + this.RestoreInfo.GetHashCode();
                if (this.RestoreKubernetesNamespacesParams != null)
                    hashCode = hashCode * 59 + this.RestoreKubernetesNamespacesParams.GetHashCode();
                if (this.RestoreKvmVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreKvmVmsParams.GetHashCode();
                if (this.RestoreOneDriveParams != null)
                    hashCode = hashCode * 59 + this.RestoreOneDriveParams.GetHashCode();
                if (this.RestoreOutlookParams != null)
                    hashCode = hashCode * 59 + this.RestoreOutlookParams.GetHashCode();
                if (this.RestoreParentSource != null)
                    hashCode = hashCode * 59 + this.RestoreParentSource.GetHashCode();
                if (this.RestorePublicFoldersParams != null)
                    hashCode = hashCode * 59 + this.RestorePublicFoldersParams.GetHashCode();
                if (this.RestoreSiteParams != null)
                    hashCode = hashCode * 59 + this.RestoreSiteParams.GetHashCode();
                if (this.RestoreStandbyTaskState != null)
                    hashCode = hashCode * 59 + this.RestoreStandbyTaskState.GetHashCode();
                if (this.RestoreSubTaskVec != null)
                    hashCode = hashCode * 59 + this.RestoreSubTaskVec.GetHashCode();
                if (this.RestoreTaskPurged != null)
                    hashCode = hashCode * 59 + this.RestoreTaskPurged.GetHashCode();
                if (this.RestoreTeamsParams != null)
                    hashCode = hashCode * 59 + this.RestoreTeamsParams.GetHashCode();
                if (this.RestoreViewDatastoreEntity != null)
                    hashCode = hashCode * 59 + this.RestoreViewDatastoreEntity.GetHashCode();
                if (this.RestoreVmwareVmParams != null)
                    hashCode = hashCode * 59 + this.RestoreVmwareVmParams.GetHashCode();
                if (this.RestoredDataStorageDomainId != null)
                    hashCode = hashCode * 59 + this.RestoredDataStorageDomainId.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.RestoredToDifferentSource != null)
                    hashCode = hashCode * 59 + this.RestoredToDifferentSource.GetHashCode();
                if (this.RetrieveArchiveProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveProgressMonitorTaskPath.GetHashCode();
                if (this.RetrieveArchiveStubViewName != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveStubViewName.GetHashCode();
                if (this.RetrieveArchiveTaskUidVec != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveTaskUidVec.GetHashCode();
                if (this.RetrieveArchiveTaskVec != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveTaskVec.GetHashCode();
                if (this.RetrieveArchiveViewName != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveViewName.GetHashCode();
                if (this.SelectedDatastoreIdx != null)
                    hashCode = hashCode * 59 + this.SelectedDatastoreIdx.GetHashCode();
                if (this.SfdcRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.SfdcRecoverJobParams.GetHashCode();
                if (this.SkipCloningRetrieveArchiveView != null)
                    hashCode = hashCode * 59 + this.SkipCloningRetrieveArchiveView.GetHashCode();
                if (this.SkipImageDeploy != null)
                    hashCode = hashCode * 59 + this.SkipImageDeploy.GetHashCode();
                if (this.SkipRigelForRestore != null)
                    hashCode = hashCode * 59 + this.SkipRigelForRestore.GetHashCode();
                if (this.StubViewRelativeDirName != null)
                    hashCode = hashCode * 59 + this.StubViewRelativeDirName.GetHashCode();
                if (this.UdaRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.UdaRecoverJobParams.GetHashCode();
                if (this.VaultRestoreParams != null)
                    hashCode = hashCode * 59 + this.VaultRestoreParams.GetHashCode();
                if (this.VcdConfig != null)
                    hashCode = hashCode * 59 + this.VcdConfig.GetHashCode();
                if (this.VcdStorageProfileDatastoreMorefVec != null)
                    hashCode = hashCode * 59 + this.VcdStorageProfileDatastoreMorefVec.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewNameDEPRECATED != null)
                    hashCode = hashCode * 59 + this.ViewNameDEPRECATED.GetHashCode();
                if (this.ViewParams != null)
                    hashCode = hashCode * 59 + this.ViewParams.GetHashCode();
                if (this.VmRestoreReuseCdpView != null)
                    hashCode = hashCode * 59 + this.VmRestoreReuseCdpView.GetHashCode();
                if (this.VolumeInfoVec != null)
                    hashCode = hashCode * 59 + this.VolumeInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

