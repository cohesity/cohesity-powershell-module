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
    /// Specifies information about a Restore Task.
    /// </summary>
    [DataContract]
    public partial class RestoreTask :  IEquatable<RestoreTask>
    {
        /// <summary>
        /// Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. &#39;kInternalViewCreated&#39; indicates that internal view for the task has been created. &#39;kZipFileRequested&#39; indicates that request has been sent to create zip files for the files to be downloaded. This state is only going to be present for kDownloadFiles Task. &#39;kCancelled&#39; indicates that task or jb has been cancelled.
        /// </summary>
        /// <value>Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. &#39;kInternalViewCreated&#39; indicates that internal view for the task has been created. &#39;kZipFileRequested&#39; indicates that request has been sent to create zip files for the files to be downloaded. This state is only going to be present for kDownloadFiles Task. &#39;kCancelled&#39; indicates that task or jb has been cancelled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum KReadyToSchedule for value: kReadyToSchedule
            /// </summary>
            [EnumMember(Value = "kReadyToSchedule")]
            KReadyToSchedule = 1,

            /// <summary>
            /// Enum KProgressMonitorCreated for value: kProgressMonitorCreated
            /// </summary>
            [EnumMember(Value = "kProgressMonitorCreated")]
            KProgressMonitorCreated = 2,

            /// <summary>
            /// Enum KRetrievedFromArchive for value: kRetrievedFromArchive
            /// </summary>
            [EnumMember(Value = "kRetrievedFromArchive")]
            KRetrievedFromArchive = 3,

            /// <summary>
            /// Enum KAdmitted for value: kAdmitted
            /// </summary>
            [EnumMember(Value = "kAdmitted")]
            KAdmitted = 4,

            /// <summary>
            /// Enum KInProgress for value: kInProgress
            /// </summary>
            [EnumMember(Value = "kInProgress")]
            KInProgress = 5,

            /// <summary>
            /// Enum KFinishingProgressMonitor for value: kFinishingProgressMonitor
            /// </summary>
            [EnumMember(Value = "kFinishingProgressMonitor")]
            KFinishingProgressMonitor = 6,

            /// <summary>
            /// Enum KFinished for value: kFinished
            /// </summary>
            [EnumMember(Value = "kFinished")]
            KFinished = 7,

            /// <summary>
            /// Enum KInternalViewCreated for value: kInternalViewCreated
            /// </summary>
            [EnumMember(Value = "kInternalViewCreated")]
            KInternalViewCreated = 8,

            /// <summary>
            /// Enum KZipFileRequested for value: kZipFileRequested
            /// </summary>
            [EnumMember(Value = "kZipFileRequested")]
            KZipFileRequested = 9,

            /// <summary>
            /// Enum KCancelled for value: kCancelled
            /// </summary>
            [EnumMember(Value = "kCancelled")]
            KCancelled = 10

        }

        /// <summary>
        /// Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. &#39;kInternalViewCreated&#39; indicates that internal view for the task has been created. &#39;kZipFileRequested&#39; indicates that request has been sent to create zip files for the files to be downloaded. This state is only going to be present for kDownloadFiles Task. &#39;kCancelled&#39; indicates that task or jb has been cancelled.
        /// </summary>
        /// <value>Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. &#39;kInternalViewCreated&#39; indicates that internal view for the task has been created. &#39;kZipFileRequested&#39; indicates that request has been sent to create zip files for the files to be downloaded. This state is only going to be present for kDownloadFiles Task. &#39;kCancelled&#39; indicates that task or jb has been cancelled.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. &#39;kRecoverApp&#39; specifies a Restore Task that recovers app. &#39;kCloneApp&#39; specifies a Restore Task that clone app. &#39;kRecoverSanVolume&#39; specifies a Restore Task that recovers SAN volumes. &#39;kConvertAndDeployVMs&#39; specifies a Restore Task that converts and deploy VMs to a target environment. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. &#39;kSystem&#39; specifies a Restore Task that recovers a system. &#39;kRecoverVolumes&#39; specifies a Restore Task that recovers volumes via the physical agent. &#39;kDeployVolumes&#39; specifies a Restore Task that deployes volumes to a target environment. &#39;kDownloadFiles&#39; specifies a Restore Task that downloads the requested files and folders in zip format. &#39;kRecoverEmails&#39; specifies a Restore Task that recovers the mailbox/email items. &#39;kRecoverDisks&#39; specifies a Restore Task that recovers the virtual disks.
        /// </summary>
        /// <value>Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. &#39;kRecoverApp&#39; specifies a Restore Task that recovers app. &#39;kCloneApp&#39; specifies a Restore Task that clone app. &#39;kRecoverSanVolume&#39; specifies a Restore Task that recovers SAN volumes. &#39;kConvertAndDeployVMs&#39; specifies a Restore Task that converts and deploy VMs to a target environment. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. &#39;kSystem&#39; specifies a Restore Task that recovers a system. &#39;kRecoverVolumes&#39; specifies a Restore Task that recovers volumes via the physical agent. &#39;kDeployVolumes&#39; specifies a Restore Task that deployes volumes to a target environment. &#39;kDownloadFiles&#39; specifies a Restore Task that downloads the requested files and folders in zip format. &#39;kRecoverEmails&#39; specifies a Restore Task that recovers the mailbox/email items. &#39;kRecoverDisks&#39; specifies a Restore Task that recovers the virtual disks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRecoverVMs for value: kRecoverVMs
            /// </summary>
            [EnumMember(Value = "kRecoverVMs")]
            KRecoverVMs = 1,

            /// <summary>
            /// Enum KCloneVMs for value: kCloneVMs
            /// </summary>
            [EnumMember(Value = "kCloneVMs")]
            KCloneVMs = 2,

            /// <summary>
            /// Enum KCloneView for value: kCloneView
            /// </summary>
            [EnumMember(Value = "kCloneView")]
            KCloneView = 3,

            /// <summary>
            /// Enum KMountVolumes for value: kMountVolumes
            /// </summary>
            [EnumMember(Value = "kMountVolumes")]
            KMountVolumes = 4,

            /// <summary>
            /// Enum KRestoreFiles for value: kRestoreFiles
            /// </summary>
            [EnumMember(Value = "kRestoreFiles")]
            KRestoreFiles = 5,

            /// <summary>
            /// Enum KRecoverApp for value: kRecoverApp
            /// </summary>
            [EnumMember(Value = "kRecoverApp")]
            KRecoverApp = 6,

            /// <summary>
            /// Enum KCloneApp for value: kCloneApp
            /// </summary>
            [EnumMember(Value = "kCloneApp")]
            KCloneApp = 7,

            /// <summary>
            /// Enum KRecoverSanVolume for value: kRecoverSanVolume
            /// </summary>
            [EnumMember(Value = "kRecoverSanVolume")]
            KRecoverSanVolume = 8,

            /// <summary>
            /// Enum KConvertAndDeployVMs for value: kConvertAndDeployVMs
            /// </summary>
            [EnumMember(Value = "kConvertAndDeployVMs")]
            KConvertAndDeployVMs = 9,

            /// <summary>
            /// Enum KMountFileVolume for value: kMountFileVolume
            /// </summary>
            [EnumMember(Value = "kMountFileVolume")]
            KMountFileVolume = 10,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 11,

            /// <summary>
            /// Enum KRecoverVolumes for value: kRecoverVolumes
            /// </summary>
            [EnumMember(Value = "kRecoverVolumes")]
            KRecoverVolumes = 12,

            /// <summary>
            /// Enum KDeployVMs for value: kDeployVMs
            /// </summary>
            [EnumMember(Value = "kDeployVMs")]
            KDeployVMs = 13,

            /// <summary>
            /// Enum KDownloadFiles for value: kDownloadFiles
            /// </summary>
            [EnumMember(Value = "kDownloadFiles")]
            KDownloadFiles = 14,

            /// <summary>
            /// Enum KRecoverEmails for value: kRecoverEmails
            /// </summary>
            [EnumMember(Value = "kRecoverEmails")]
            KRecoverEmails = 15,

            /// <summary>
            /// Enum KRecoverDisks for value: kRecoverDisks
            /// </summary>
            [EnumMember(Value = "kRecoverDisks")]
            KRecoverDisks = 16

        }

        /// <summary>
        /// Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. &#39;kRecoverApp&#39; specifies a Restore Task that recovers app. &#39;kCloneApp&#39; specifies a Restore Task that clone app. &#39;kRecoverSanVolume&#39; specifies a Restore Task that recovers SAN volumes. &#39;kConvertAndDeployVMs&#39; specifies a Restore Task that converts and deploy VMs to a target environment. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. &#39;kSystem&#39; specifies a Restore Task that recovers a system. &#39;kRecoverVolumes&#39; specifies a Restore Task that recovers volumes via the physical agent. &#39;kDeployVolumes&#39; specifies a Restore Task that deployes volumes to a target environment. &#39;kDownloadFiles&#39; specifies a Restore Task that downloads the requested files and folders in zip format. &#39;kRecoverEmails&#39; specifies a Restore Task that recovers the mailbox/email items. &#39;kRecoverDisks&#39; specifies a Restore Task that recovers the virtual disks.
        /// </summary>
        /// <value>Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. &#39;kRecoverApp&#39; specifies a Restore Task that recovers app. &#39;kCloneApp&#39; specifies a Restore Task that clone app. &#39;kRecoverSanVolume&#39; specifies a Restore Task that recovers SAN volumes. &#39;kConvertAndDeployVMs&#39; specifies a Restore Task that converts and deploy VMs to a target environment. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. &#39;kSystem&#39; specifies a Restore Task that recovers a system. &#39;kRecoverVolumes&#39; specifies a Restore Task that recovers volumes via the physical agent. &#39;kDeployVolumes&#39; specifies a Restore Task that deployes volumes to a target environment. &#39;kDownloadFiles&#39; specifies a Restore Task that downloads the requested files and folders in zip format. &#39;kRecoverEmails&#39; specifies a Restore Task that recovers the mailbox/email items. &#39;kRecoverDisks&#39; specifies a Restore Task that recovers the virtual disks.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestoreTask() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreTask" /> class.
        /// </summary>
        /// <param name="acropolisParameters">acropolisParameters.</param>
        /// <param name="archiveTaskUid">Specifies the uid of the Restore Task that retrieves objects from an archive. This field is only populated when objects must be retrieved from an archive before being restored..</param>
        /// <param name="cloneViewParameters">Specifies the View settings used when cloning a View..</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="datastoreId">Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source..</param>
        /// <param name="endTimeUsecs">Specifies the end time of the Restore Task as a Unix epoch Timestamp (in microseconds). This field is only populated if the Restore Task completes..</param>
        /// <param name="error">Specifies the error reported by the Restore Task (if any) after the Task has finished..</param>
        /// <param name="fullViewName">Specifies the full name of a View..</param>
        /// <param name="hypervParameters">hypervParameters.</param>
        /// <param name="id">Specifies the id of the Restore Task assigned by Cohesity Cluster..</param>
        /// <param name="mountVolumesState">mountVolumesState.</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="outlookParameters">outlookParameters.</param>
        /// <param name="restoreObjectState">Array of Object States.  Specifies the states of all the objects for the &#39;kRecoverVMs&#39; and &#39;kCloneVMs&#39; Restore Tasks..</param>
        /// <param name="startTimeUsecs">Specifies the start time for the Restore Task as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="status">Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. &#39;kInternalViewCreated&#39; indicates that internal view for the task has been created. &#39;kZipFileRequested&#39; indicates that request has been sent to create zip files for the files to be downloaded. This state is only going to be present for kDownloadFiles Task. &#39;kCancelled&#39; indicates that task or jb has been cancelled..</param>
        /// <param name="targetViewCreated">Is true if a new View was created by a &#39;kCloneVMs&#39; Restore Task. This field is only set for a &#39;kCloneVMs&#39; Restore Task..</param>
        /// <param name="type">Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. &#39;kRecoverApp&#39; specifies a Restore Task that recovers app. &#39;kCloneApp&#39; specifies a Restore Task that clone app. &#39;kRecoverSanVolume&#39; specifies a Restore Task that recovers SAN volumes. &#39;kConvertAndDeployVMs&#39; specifies a Restore Task that converts and deploy VMs to a target environment. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. &#39;kSystem&#39; specifies a Restore Task that recovers a system. &#39;kRecoverVolumes&#39; specifies a Restore Task that recovers volumes via the physical agent. &#39;kDeployVolumes&#39; specifies a Restore Task that deployes volumes to a target environment. &#39;kDownloadFiles&#39; specifies a Restore Task that downloads the requested files and folders in zip format. &#39;kRecoverEmails&#39; specifies a Restore Task that recovers the mailbox/email items. &#39;kRecoverDisks&#39; specifies a Restore Task that recovers the virtual disks..</param>
        /// <param name="username">Specifies the Cohesity user who requested this Restore Task..</param>
        /// <param name="viewBoxId">Specifies the id of the Domain (View Box) where the View is stored..</param>
        /// <param name="virtualDiskRestoreState">virtualDiskRestoreState.</param>
        /// <param name="vlanParameters">vlanParameters.</param>
        /// <param name="vmwareParameters">vmwareParameters.</param>
        public RestoreTask(AcropolisRestoreParameters acropolisParameters = default(AcropolisRestoreParameters), UniversalId archiveTaskUid = default(UniversalId), UpdateViewParam cloneViewParameters = default(UpdateViewParam), bool? continueOnError = default(bool?), long? datastoreId = default(long?), long? endTimeUsecs = default(long?), RequestError error = default(RequestError), string fullViewName = default(string), HypervRestoreParameters hypervParameters = default(HypervRestoreParameters), long? id = default(long?), MountVolumesState mountVolumesState = default(MountVolumesState), string name = default(string), long? newParentId = default(long?), List<RestoreObjectDetails> objects = default(List<RestoreObjectDetails>), OutlookRestoreParameters outlookParameters = default(OutlookRestoreParameters), List<RestoreObjectState> restoreObjectState = default(List<RestoreObjectState>), long? startTimeUsecs = default(long?), StatusEnum? status = default(StatusEnum?), bool? targetViewCreated = default(bool?), TypeEnum? type = default(TypeEnum?), string username = default(string), long? viewBoxId = default(long?), VirtualDiskRecoverTaskState virtualDiskRestoreState = default(VirtualDiskRecoverTaskState), VlanParameters vlanParameters = default(VlanParameters), VmwareRestoreParameters vmwareParameters = default(VmwareRestoreParameters))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.CloneViewParameters = cloneViewParameters;
            this.ContinueOnError = continueOnError;
            this.DatastoreId = datastoreId;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.FullViewName = fullViewName;
            this.Id = id;
            this.Name = name;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.RestoreObjectState = restoreObjectState;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TargetViewCreated = targetViewCreated;
            this.Type = type;
            this.Username = username;
            this.ViewBoxId = viewBoxId;
            this.AcropolisParameters = acropolisParameters;
            this.ArchiveTaskUid = archiveTaskUid;
            this.CloneViewParameters = cloneViewParameters;
            this.ContinueOnError = continueOnError;
            this.DatastoreId = datastoreId;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.FullViewName = fullViewName;
            this.HypervParameters = hypervParameters;
            this.Id = id;
            this.MountVolumesState = mountVolumesState;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.OutlookParameters = outlookParameters;
            this.RestoreObjectState = restoreObjectState;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TargetViewCreated = targetViewCreated;
            this.Type = type;
            this.Username = username;
            this.ViewBoxId = viewBoxId;
            this.VirtualDiskRestoreState = virtualDiskRestoreState;
            this.VlanParameters = vlanParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Gets or Sets AcropolisParameters
        /// </summary>
        [DataMember(Name="acropolisParameters", EmitDefaultValue=false)]
        public AcropolisRestoreParameters AcropolisParameters { get; set; }

        /// <summary>
        /// Specifies the uid of the Restore Task that retrieves objects from an archive. This field is only populated when objects must be retrieved from an archive before being restored.
        /// </summary>
        /// <value>Specifies the uid of the Restore Task that retrieves objects from an archive. This field is only populated when objects must be retrieved from an archive before being restored.</value>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=true)]
        public UniversalId ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the View settings used when cloning a View.
        /// </summary>
        /// <value>Specifies the View settings used when cloning a View.</value>
        [DataMember(Name="cloneViewParameters", EmitDefaultValue=true)]
        public UpdateViewParam CloneViewParameters { get; set; }

        /// <summary>
        /// Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source.
        /// </summary>
        /// <value>Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source.</value>
        [DataMember(Name="datastoreId", EmitDefaultValue=true)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// Specifies the end time of the Restore Task as a Unix epoch Timestamp (in microseconds). This field is only populated if the Restore Task completes.
        /// </summary>
        /// <value>Specifies the end time of the Restore Task as a Unix epoch Timestamp (in microseconds). This field is only populated if the Restore Task completes.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the error reported by the Restore Task (if any) after the Task has finished.
        /// </summary>
        /// <value>Specifies the error reported by the Restore Task (if any) after the Task has finished.</value>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public RequestError Error { get; set; }

        /// <summary>
        /// Specifies the full name of a View.
        /// </summary>
        /// <value>Specifies the full name of a View.</value>
        [DataMember(Name="fullViewName", EmitDefaultValue=true)]
        public string FullViewName { get; set; }

        /// <summary>
        /// Gets or Sets HypervParameters
        /// </summary>
        [DataMember(Name="hypervParameters", EmitDefaultValue=false)]
        public HypervRestoreParameters HypervParameters { get; set; }

        /// <summary>
        /// Specifies the id of the Restore Task assigned by Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the id of the Restore Task assigned by Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets MountVolumesState
        /// </summary>
        [DataMember(Name="mountVolumesState", EmitDefaultValue=false)]
        public MountVolumesState MountVolumesState { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=true)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObjectDetails> Objects { get; set; }

        /// <summary>
        /// Gets or Sets OutlookParameters
        /// </summary>
        [DataMember(Name="outlookParameters", EmitDefaultValue=false)]
        public OutlookRestoreParameters OutlookParameters { get; set; }

        /// <summary>
        /// Array of Object States.  Specifies the states of all the objects for the &#39;kRecoverVMs&#39; and &#39;kCloneVMs&#39; Restore Tasks.
        /// </summary>
        /// <value>Array of Object States.  Specifies the states of all the objects for the &#39;kRecoverVMs&#39; and &#39;kCloneVMs&#39; Restore Tasks.</value>
        [DataMember(Name="restoreObjectState", EmitDefaultValue=true)]
        public List<RestoreObjectState> RestoreObjectState { get; set; }

        /// <summary>
        /// Specifies the start time for the Restore Task as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time for the Restore Task as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Is true if a new View was created by a &#39;kCloneVMs&#39; Restore Task. This field is only set for a &#39;kCloneVMs&#39; Restore Task.
        /// </summary>
        /// <value>Is true if a new View was created by a &#39;kCloneVMs&#39; Restore Task. This field is only set for a &#39;kCloneVMs&#39; Restore Task.</value>
        [DataMember(Name="targetViewCreated", EmitDefaultValue=true)]
        public bool? TargetViewCreated { get; set; }

        /// <summary>
        /// Specifies the Cohesity user who requested this Restore Task.
        /// </summary>
        /// <value>Specifies the Cohesity user who requested this Restore Task.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Specifies the id of the Domain (View Box) where the View is stored.
        /// </summary>
        /// <value>Specifies the id of the Domain (View Box) where the View is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDiskRestoreState
        /// </summary>
        [DataMember(Name="virtualDiskRestoreState", EmitDefaultValue=false)]
        public VirtualDiskRecoverTaskState VirtualDiskRestoreState { get; set; }

        /// <summary>
        /// Gets or Sets VlanParameters
        /// </summary>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParameters
        /// </summary>
        [DataMember(Name="vmwareParameters", EmitDefaultValue=false)]
        public VmwareRestoreParameters VmwareParameters { get; set; }

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
            return this.Equals(input as RestoreTask);
        }

        /// <summary>
        /// Returns true if RestoreTask instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisParameters == input.AcropolisParameters ||
                    (this.AcropolisParameters != null &&
                    this.AcropolisParameters.Equals(input.AcropolisParameters))
                ) && 
                (
                    this.ArchiveTaskUid == input.ArchiveTaskUid ||
                    (this.ArchiveTaskUid != null &&
                    this.ArchiveTaskUid.Equals(input.ArchiveTaskUid))
                ) && 
                (
                    this.CloneViewParameters == input.CloneViewParameters ||
                    (this.CloneViewParameters != null &&
                    this.CloneViewParameters.Equals(input.CloneViewParameters))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.DatastoreId == input.DatastoreId ||
                    (this.DatastoreId != null &&
                    this.DatastoreId.Equals(input.DatastoreId))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FullViewName == input.FullViewName ||
                    (this.FullViewName != null &&
                    this.FullViewName.Equals(input.FullViewName))
                ) && 
                (
                    this.HypervParameters == input.HypervParameters ||
                    (this.HypervParameters != null &&
                    this.HypervParameters.Equals(input.HypervParameters))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MountVolumesState == input.MountVolumesState ||
                    (this.MountVolumesState != null &&
                    this.MountVolumesState.Equals(input.MountVolumesState))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewParentId == input.NewParentId ||
                    (this.NewParentId != null &&
                    this.NewParentId.Equals(input.NewParentId))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.OutlookParameters == input.OutlookParameters ||
                    (this.OutlookParameters != null &&
                    this.OutlookParameters.Equals(input.OutlookParameters))
                ) && 
                (
                    this.RestoreObjectState == input.RestoreObjectState ||
                    this.RestoreObjectState != null &&
                    input.RestoreObjectState != null &&
                    this.RestoreObjectState.SequenceEqual(input.RestoreObjectState)
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TargetViewCreated == input.TargetViewCreated ||
                    (this.TargetViewCreated != null &&
                    this.TargetViewCreated.Equals(input.TargetViewCreated))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.VirtualDiskRestoreState == input.VirtualDiskRestoreState ||
                    (this.VirtualDiskRestoreState != null &&
                    this.VirtualDiskRestoreState.Equals(input.VirtualDiskRestoreState))
                ) && 
                (
                    this.VlanParameters == input.VlanParameters ||
                    (this.VlanParameters != null &&
                    this.VlanParameters.Equals(input.VlanParameters))
                ) && 
                (
                    this.VmwareParameters == input.VmwareParameters ||
                    (this.VmwareParameters != null &&
                    this.VmwareParameters.Equals(input.VmwareParameters))
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
                if (this.AcropolisParameters != null)
                    hashCode = hashCode * 59 + this.AcropolisParameters.GetHashCode();
                if (this.ArchiveTaskUid != null)
                    hashCode = hashCode * 59 + this.ArchiveTaskUid.GetHashCode();
                if (this.CloneViewParameters != null)
                    hashCode = hashCode * 59 + this.CloneViewParameters.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.DatastoreId != null)
                    hashCode = hashCode * 59 + this.DatastoreId.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FullViewName != null)
                    hashCode = hashCode * 59 + this.FullViewName.GetHashCode();
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MountVolumesState != null)
                    hashCode = hashCode * 59 + this.MountVolumesState.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.OutlookParameters != null)
                    hashCode = hashCode * 59 + this.OutlookParameters.GetHashCode();
                if (this.RestoreObjectState != null)
                    hashCode = hashCode * 59 + this.RestoreObjectState.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TargetViewCreated != null)
                    hashCode = hashCode * 59 + this.TargetViewCreated.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.VirtualDiskRestoreState != null)
                    hashCode = hashCode * 59 + this.VirtualDiskRestoreState.GetHashCode();
                if (this.VlanParameters != null)
                    hashCode = hashCode * 59 + this.VlanParameters.GetHashCode();
                if (this.VmwareParameters != null)
                    hashCode = hashCode * 59 + this.VmwareParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

