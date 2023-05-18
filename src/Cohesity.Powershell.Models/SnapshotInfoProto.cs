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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined. The only exception is view.proto and physical.proto which reside in magneto/base.  SnapshotInfoProto extension                     Location              Extn &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::SnapshotInfo::vmware_snapshot_info     vmware/vmware.proto       100 sql::SnapshotInfo::sql_snapshot_info           sql/sql.proto             101 view::SnapshotInfo::view_snapshot_info         base/view.proto           102 physical::SnapshotInfo::physical_snapshot_info base/physical.proto       103 san::SnapshotInfo::san_snapshot_info           san/san.proto             104 file::SnapshotInfo::file_snapshot_info         file/file.proto           105 hyperv::SnapshotInfo::hyperv_snapshot_info     hyperv/hyperv.proto       106 acropolis::SnapshotInfo:: acropolis_snapshot_info                        acropolis/acropolis.proto 107 kvm::SnapshotInfo::kvm_snapshot_info           kvm/kvm.proto             108 app_file::SnapshotInfo::app_file_snapshot_info app_file/app_file.proto   109 oracle::SnapshotInfo::oracle_snapshot_info     oracle/oracle.proto       110 aws::SnapshotInfo::aws_snapshot_info           aws/aws.proto             111 outlook::SnapshotInfo::outlook_snapshot_info   outlook/outlook.proto     112 azure::SnapshotInfo::azure_snapshot_info       azure/azure.proto         113 gcp::SnapshotInfo::gcp_snapshot_info           gcp/gcp.proto             114 ad::SnapshotInfo::ad_snapshot_info             ad/ad.proto               115 MSGraph::SnapshotInfo::one_drive_snapshot_info ms_graph/graph.proto      116 kubernetes::SnapshotInfo:: kubernetes_snapshot_info kubernetes/kubernetes.proto 117 aws::RDSSnapshotInfo::rds_snapshot_info        aws/aws.proto             118 o365::SnapshotInfo::o365_snapshot_info         o365/o365.proto           119 exchange::SnapshotInfo::exchange_snapshot_info exchange/exchange.proto   120 o365::SharepointSnapshotInfo::sharepoint_snapshot_info o365/o365.proto           121 MSGraph::SharepointListSnapshotInfo::sharepoint_list_snapshot_info ms_graph/graph.proto      122 cdp::SnapshotInfo::cdp_snapshot_info           base/cdp.proto            123 imanis::SnapshotInfo::nosql_snapshot_info      imanis/nosql.proto        124 o365::PublicFolderSnapshotInfo::public_folder_snapshot_info o365/o365.proto           125 SnapshotInfo::uda_snapshot_info                uda.proto                 126 o365::TeamsSnapshotInfo::teams_snapshot_info   o365/o365.proto           127 o365::O365GroupSnapshotInfo::o365_group_snapshot_info o365/o365.proto           128 SnapshotInfo::sfdc_snapshot_info               sfdc_service.proto        129 san::GroupSnapshotInfo::group_snapshot_info    san/san.proto             130 rds::OracleRmanSnapshotInfo::rds_oracle_rman_snapshot_info rds/rds.proto             131 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class SnapshotInfoProto :  IEquatable<SnapshotInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotInfoProto" /> class.
        /// </summary>
        /// <param name="changeRocksdbName">The name of the rocksdb directory for writing high change directories. It is stored in &#39;config&#39; directory of the current view..</param>
        /// <param name="errorRocksdbName">The name of the rocksdb directory for errors seen during this backup, stored in &#39;config&#39; directory of the current view..</param>
        /// <param name="fileWalkDone">This field is only applicable for NAS and file backup jobs. It indicates whether the file walk portion of the backup has completed. TODO(amandeep): Rename this as this can be used for multiple workflows..</param>
        /// <param name="frontEndSizeInfo">frontEndSizeInfo.</param>
        /// <param name="metadataViewName">The metadata view name in which the backup metadata was created. NOTE: This is populated only for CADv2 NAS backup..</param>
        /// <param name="numAppInstances">Number of application instances backed up by this task. For example, if the environment type is kSQL, this number is for the SQL server instances..</param>
        /// <param name="numAppObjects">Number of application objects in total backed up by this task. For example, if the environment type is kSQL, this number is for all of the SQL server databases.</param>
        /// <param name="postBackupScriptStatus">postBackupScriptStatus.</param>
        /// <param name="postSnapshotScriptStatus">postSnapshotScriptStatus.</param>
        /// <param name="preBackupScriptStatus">preBackupScriptStatus.</param>
        /// <param name="reacquirePermit">If the permit of this task is released on pausing backup, this boolean informs the task to re-acquire it..</param>
        /// <param name="relativeSnapshotDir">This is the path relative to &#39;root_path&#39; under which the snapshot lives. This does not begin with a &#39;/&#39; and is of the form foo/bar/baz..</param>
        /// <param name="rootPath">The root path under which the snapshot is stored. This is of the form \&quot;/ViewBox/ViewName/fs\&quot;..</param>
        /// <param name="scribeTableColumn">If this backup task stores any auxiliary state in Scribe table, this field will be populated with the column key in that table where such state is stored. Data stored in the column is extension of SnapshotScribeInfoProto message..</param>
        /// <param name="scribeTableRow">If this backup task stores any auxiliary state in Scribe table, this field will be populated with the row key in that table where such state is stored..</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="snapshotExpiryTime">Snapshot expiry time..</param>
        /// <param name="snapshotType">snapshotType.</param>
        /// <param name="sourceSnapshotCreateTimeUsecs">The source snapshot create time..</param>
        /// <param name="sourceSnapshotName">This field is only relevant for NAS backups where we are backing up from a ReadOnly or DataProtect volume, or an RW volume with Snapdiff. For RW volumes, Cohesity will create the snapshot on NetApp, while for DP volumes, Cohesity will use the existing snapshot..</param>
        /// <param name="sourceSnapshotStatus">Indicates the state of the source snapshot if it is being managed by the master op. &#39;source_snapshot_name&#39; will be set to indicate the snapshot name. At the moment, this feature is enabled only for Netapp &amp; Isilon adapters to support continuous snapshotting feature..</param>
        /// <param name="storageSnapshotProvider">storageSnapshotProvider.</param>
        /// <param name="targetType">Specifies the target type for the task. The field is only valid if the task has got a permit..</param>
        /// <param name="totalBytesReadFromSource">Contains the information regarding number of bytes that are read from the source (such as VM) so far..</param>
        /// <param name="totalBytesTiered">Total amount of data successfully tiered from the NAS source..</param>
        /// <param name="totalBytesToReadFromSource">Contains the total number of bytes that will be read from the source (such as VM) for this snapshot..</param>
        /// <param name="totalChangedEntityCount">The total number of file and directory entities that have changed since last backup. Only applicable to file based backups..</param>
        /// <param name="totalEntityCount">The total number of file and directory entities visited in this backup. Only applicable to file based backups..</param>
        /// <param name="totalLogicalBackupSizeBytes">Logical size of the source whose snapshot is being taken. This is the amount of data we would have read from the source had this been a full backup..</param>
        /// <param name="totalPrimaryPhysicalSizeBytes">Contains the information regarding number of bytes that the source (such as VM) has taken up on the primary storage..</param>
        /// <param name="totalZeroFillBytes">Total number of bytes to be zero-filled in Snap FS as part of this backup. Currently applicable only for VMware backups..</param>
        /// <param name="type">The type of environment this snapshot info pertains to..</param>
        /// <param name="viewCaseInsensitivityAltered">Whether during the backup, the backup view&#39;s case insensitivity property has been altered. If so, Madrox needs to take corresponding actions during replication..</param>
        /// <param name="viewName">The data view name under which the snapshot was created. NOTE: This is populated only for View, Puppeteer, NAS and Oracle backup..</param>
        /// <param name="viewNameToGc">The view name under which the snapshot of the migrated data was created. NOTE: This is populated only for data migration tasks..</param>
        /// <param name="warnings">Warnings if any. These warnings will be propogated to the UI by master..</param>
        /// <param name="zeroFillTaskWeightScaleDownFactor">Factor by which weight of a zero-fill sub-task should be scaled down. This is used while creating sub-task monitors..</param>
        public SnapshotInfoProto(string changeRocksdbName = default(string), string errorRocksdbName = default(string), bool? fileWalkDone = default(bool?), SizeInfo frontEndSizeInfo = default(SizeInfo), string metadataViewName = default(string), int? numAppInstances = default(int?), int? numAppObjects = default(int?), ScriptExecutionStatus postBackupScriptStatus = default(ScriptExecutionStatus), ScriptExecutionStatus postSnapshotScriptStatus = default(ScriptExecutionStatus), ScriptExecutionStatus preBackupScriptStatus = default(ScriptExecutionStatus), bool? reacquirePermit = default(bool?), string relativeSnapshotDir = default(string), string rootPath = default(string), string scribeTableColumn = default(string), string scribeTableRow = default(string), long? slaveTaskStartTimeUsecs = default(long?), int? snapshotExpiryTime = default(int?), ObjectSnapshotType snapshotType = default(ObjectSnapshotType), long? sourceSnapshotCreateTimeUsecs = default(long?), string sourceSnapshotName = default(string), int? sourceSnapshotStatus = default(int?), StorageSnapshotProviderParams storageSnapshotProvider = default(StorageSnapshotProviderParams), int? targetType = default(int?), long? totalBytesReadFromSource = default(long?), long? totalBytesTiered = default(long?), long? totalBytesToReadFromSource = default(long?), long? totalChangedEntityCount = default(long?), long? totalEntityCount = default(long?), long? totalLogicalBackupSizeBytes = default(long?), long? totalPrimaryPhysicalSizeBytes = default(long?), long? totalZeroFillBytes = default(long?), int? type = default(int?), bool? viewCaseInsensitivityAltered = default(bool?), string viewName = default(string), string viewNameToGc = default(string), List<ErrorProto> warnings = default(List<ErrorProto>), long? zeroFillTaskWeightScaleDownFactor = default(long?))
        {
            this.ChangeRocksdbName = changeRocksdbName;
            this.ErrorRocksdbName = errorRocksdbName;
            this.FileWalkDone = fileWalkDone;
            this.MetadataViewName = metadataViewName;
            this.NumAppInstances = numAppInstances;
            this.NumAppObjects = numAppObjects;
            this.ReacquirePermit = reacquirePermit;
            this.RelativeSnapshotDir = relativeSnapshotDir;
            this.RootPath = rootPath;
            this.ScribeTableColumn = scribeTableColumn;
            this.ScribeTableRow = scribeTableRow;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.SnapshotExpiryTime = snapshotExpiryTime;
            this.SourceSnapshotCreateTimeUsecs = sourceSnapshotCreateTimeUsecs;
            this.SourceSnapshotName = sourceSnapshotName;
            this.SourceSnapshotStatus = sourceSnapshotStatus;
            this.TargetType = targetType;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalBytesTiered = totalBytesTiered;
            this.TotalBytesToReadFromSource = totalBytesToReadFromSource;
            this.TotalChangedEntityCount = totalChangedEntityCount;
            this.TotalEntityCount = totalEntityCount;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPrimaryPhysicalSizeBytes = totalPrimaryPhysicalSizeBytes;
            this.TotalZeroFillBytes = totalZeroFillBytes;
            this.Type = type;
            this.ViewCaseInsensitivityAltered = viewCaseInsensitivityAltered;
            this.ViewName = viewName;
            this.ViewNameToGc = viewNameToGc;
            this.Warnings = warnings;
            this.ZeroFillTaskWeightScaleDownFactor = zeroFillTaskWeightScaleDownFactor;
            this.ChangeRocksdbName = changeRocksdbName;
            this.ErrorRocksdbName = errorRocksdbName;
            this.FileWalkDone = fileWalkDone;
            this.FrontEndSizeInfo = frontEndSizeInfo;
            this.MetadataViewName = metadataViewName;
            this.NumAppInstances = numAppInstances;
            this.NumAppObjects = numAppObjects;
            this.PostBackupScriptStatus = postBackupScriptStatus;
            this.PostSnapshotScriptStatus = postSnapshotScriptStatus;
            this.PreBackupScriptStatus = preBackupScriptStatus;
            this.ReacquirePermit = reacquirePermit;
            this.RelativeSnapshotDir = relativeSnapshotDir;
            this.RootPath = rootPath;
            this.ScribeTableColumn = scribeTableColumn;
            this.ScribeTableRow = scribeTableRow;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.SnapshotExpiryTime = snapshotExpiryTime;
            this.SnapshotType = snapshotType;
            this.SourceSnapshotCreateTimeUsecs = sourceSnapshotCreateTimeUsecs;
            this.SourceSnapshotName = sourceSnapshotName;
            this.SourceSnapshotStatus = sourceSnapshotStatus;
            this.StorageSnapshotProvider = storageSnapshotProvider;
            this.TargetType = targetType;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalBytesTiered = totalBytesTiered;
            this.TotalBytesToReadFromSource = totalBytesToReadFromSource;
            this.TotalChangedEntityCount = totalChangedEntityCount;
            this.TotalEntityCount = totalEntityCount;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPrimaryPhysicalSizeBytes = totalPrimaryPhysicalSizeBytes;
            this.TotalZeroFillBytes = totalZeroFillBytes;
            this.Type = type;
            this.ViewCaseInsensitivityAltered = viewCaseInsensitivityAltered;
            this.ViewName = viewName;
            this.ViewNameToGc = viewNameToGc;
            this.Warnings = warnings;
            this.ZeroFillTaskWeightScaleDownFactor = zeroFillTaskWeightScaleDownFactor;
        }
        
        /// <summary>
        /// The name of the rocksdb directory for writing high change directories. It is stored in &#39;config&#39; directory of the current view.
        /// </summary>
        /// <value>The name of the rocksdb directory for writing high change directories. It is stored in &#39;config&#39; directory of the current view.</value>
        [DataMember(Name="changeRocksdbName", EmitDefaultValue=true)]
        public string ChangeRocksdbName { get; set; }

        /// <summary>
        /// The name of the rocksdb directory for errors seen during this backup, stored in &#39;config&#39; directory of the current view.
        /// </summary>
        /// <value>The name of the rocksdb directory for errors seen during this backup, stored in &#39;config&#39; directory of the current view.</value>
        [DataMember(Name="errorRocksdbName", EmitDefaultValue=true)]
        public string ErrorRocksdbName { get; set; }

        /// <summary>
        /// This field is only applicable for NAS and file backup jobs. It indicates whether the file walk portion of the backup has completed. TODO(amandeep): Rename this as this can be used for multiple workflows.
        /// </summary>
        /// <value>This field is only applicable for NAS and file backup jobs. It indicates whether the file walk portion of the backup has completed. TODO(amandeep): Rename this as this can be used for multiple workflows.</value>
        [DataMember(Name="fileWalkDone", EmitDefaultValue=true)]
        public bool? FileWalkDone { get; set; }

        /// <summary>
        /// Gets or Sets FrontEndSizeInfo
        /// </summary>
        [DataMember(Name="frontEndSizeInfo", EmitDefaultValue=false)]
        public SizeInfo FrontEndSizeInfo { get; set; }

        /// <summary>
        /// The metadata view name in which the backup metadata was created. NOTE: This is populated only for CADv2 NAS backup.
        /// </summary>
        /// <value>The metadata view name in which the backup metadata was created. NOTE: This is populated only for CADv2 NAS backup.</value>
        [DataMember(Name="metadataViewName", EmitDefaultValue=true)]
        public string MetadataViewName { get; set; }

        /// <summary>
        /// Number of application instances backed up by this task. For example, if the environment type is kSQL, this number is for the SQL server instances.
        /// </summary>
        /// <value>Number of application instances backed up by this task. For example, if the environment type is kSQL, this number is for the SQL server instances.</value>
        [DataMember(Name="numAppInstances", EmitDefaultValue=true)]
        public int? NumAppInstances { get; set; }

        /// <summary>
        /// Number of application objects in total backed up by this task. For example, if the environment type is kSQL, this number is for all of the SQL server databases
        /// </summary>
        /// <value>Number of application objects in total backed up by this task. For example, if the environment type is kSQL, this number is for all of the SQL server databases</value>
        [DataMember(Name="numAppObjects", EmitDefaultValue=true)]
        public int? NumAppObjects { get; set; }

        /// <summary>
        /// Gets or Sets PostBackupScriptStatus
        /// </summary>
        [DataMember(Name="postBackupScriptStatus", EmitDefaultValue=false)]
        public ScriptExecutionStatus PostBackupScriptStatus { get; set; }

        /// <summary>
        /// Gets or Sets PostSnapshotScriptStatus
        /// </summary>
        [DataMember(Name="postSnapshotScriptStatus", EmitDefaultValue=false)]
        public ScriptExecutionStatus PostSnapshotScriptStatus { get; set; }

        /// <summary>
        /// Gets or Sets PreBackupScriptStatus
        /// </summary>
        [DataMember(Name="preBackupScriptStatus", EmitDefaultValue=false)]
        public ScriptExecutionStatus PreBackupScriptStatus { get; set; }

        /// <summary>
        /// If the permit of this task is released on pausing backup, this boolean informs the task to re-acquire it.
        /// </summary>
        /// <value>If the permit of this task is released on pausing backup, this boolean informs the task to re-acquire it.</value>
        [DataMember(Name="reacquirePermit", EmitDefaultValue=true)]
        public bool? ReacquirePermit { get; set; }

        /// <summary>
        /// This is the path relative to &#39;root_path&#39; under which the snapshot lives. This does not begin with a &#39;/&#39; and is of the form foo/bar/baz.
        /// </summary>
        /// <value>This is the path relative to &#39;root_path&#39; under which the snapshot lives. This does not begin with a &#39;/&#39; and is of the form foo/bar/baz.</value>
        [DataMember(Name="relativeSnapshotDir", EmitDefaultValue=true)]
        public string RelativeSnapshotDir { get; set; }

        /// <summary>
        /// The root path under which the snapshot is stored. This is of the form \&quot;/ViewBox/ViewName/fs\&quot;.
        /// </summary>
        /// <value>The root path under which the snapshot is stored. This is of the form \&quot;/ViewBox/ViewName/fs\&quot;.</value>
        [DataMember(Name="rootPath", EmitDefaultValue=true)]
        public string RootPath { get; set; }

        /// <summary>
        /// If this backup task stores any auxiliary state in Scribe table, this field will be populated with the column key in that table where such state is stored. Data stored in the column is extension of SnapshotScribeInfoProto message.
        /// </summary>
        /// <value>If this backup task stores any auxiliary state in Scribe table, this field will be populated with the column key in that table where such state is stored. Data stored in the column is extension of SnapshotScribeInfoProto message.</value>
        [DataMember(Name="scribeTableColumn", EmitDefaultValue=true)]
        public string ScribeTableColumn { get; set; }

        /// <summary>
        /// If this backup task stores any auxiliary state in Scribe table, this field will be populated with the row key in that table where such state is stored.
        /// </summary>
        /// <value>If this backup task stores any auxiliary state in Scribe table, this field will be populated with the row key in that table where such state is stored.</value>
        [DataMember(Name="scribeTableRow", EmitDefaultValue=true)]
        public string ScribeTableRow { get; set; }

        /// <summary>
        /// This is the timestamp at which the slave task started.
        /// </summary>
        /// <value>This is the timestamp at which the slave task started.</value>
        [DataMember(Name="slaveTaskStartTimeUsecs", EmitDefaultValue=true)]
        public long? SlaveTaskStartTimeUsecs { get; set; }

        /// <summary>
        /// Snapshot expiry time.
        /// </summary>
        /// <value>Snapshot expiry time.</value>
        [DataMember(Name="snapshotExpiryTime", EmitDefaultValue=true)]
        public int? SnapshotExpiryTime { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotType
        /// </summary>
        [DataMember(Name="snapshotType", EmitDefaultValue=false)]
        public ObjectSnapshotType SnapshotType { get; set; }

        /// <summary>
        /// The source snapshot create time.
        /// </summary>
        /// <value>The source snapshot create time.</value>
        [DataMember(Name="sourceSnapshotCreateTimeUsecs", EmitDefaultValue=true)]
        public long? SourceSnapshotCreateTimeUsecs { get; set; }

        /// <summary>
        /// This field is only relevant for NAS backups where we are backing up from a ReadOnly or DataProtect volume, or an RW volume with Snapdiff. For RW volumes, Cohesity will create the snapshot on NetApp, while for DP volumes, Cohesity will use the existing snapshot.
        /// </summary>
        /// <value>This field is only relevant for NAS backups where we are backing up from a ReadOnly or DataProtect volume, or an RW volume with Snapdiff. For RW volumes, Cohesity will create the snapshot on NetApp, while for DP volumes, Cohesity will use the existing snapshot.</value>
        [DataMember(Name="sourceSnapshotName", EmitDefaultValue=true)]
        public string SourceSnapshotName { get; set; }

        /// <summary>
        /// Indicates the state of the source snapshot if it is being managed by the master op. &#39;source_snapshot_name&#39; will be set to indicate the snapshot name. At the moment, this feature is enabled only for Netapp &amp; Isilon adapters to support continuous snapshotting feature.
        /// </summary>
        /// <value>Indicates the state of the source snapshot if it is being managed by the master op. &#39;source_snapshot_name&#39; will be set to indicate the snapshot name. At the moment, this feature is enabled only for Netapp &amp; Isilon adapters to support continuous snapshotting feature.</value>
        [DataMember(Name="sourceSnapshotStatus", EmitDefaultValue=true)]
        public int? SourceSnapshotStatus { get; set; }

        /// <summary>
        /// Gets or Sets StorageSnapshotProvider
        /// </summary>
        [DataMember(Name="storageSnapshotProvider", EmitDefaultValue=false)]
        public StorageSnapshotProviderParams StorageSnapshotProvider { get; set; }

        /// <summary>
        /// Specifies the target type for the task. The field is only valid if the task has got a permit.
        /// </summary>
        /// <value>Specifies the target type for the task. The field is only valid if the task has got a permit.</value>
        [DataMember(Name="targetType", EmitDefaultValue=true)]
        public int? TargetType { get; set; }

        /// <summary>
        /// Contains the information regarding number of bytes that are read from the source (such as VM) so far.
        /// </summary>
        /// <value>Contains the information regarding number of bytes that are read from the source (such as VM) so far.</value>
        [DataMember(Name="totalBytesReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesReadFromSource { get; set; }

        /// <summary>
        /// Total amount of data successfully tiered from the NAS source.
        /// </summary>
        /// <value>Total amount of data successfully tiered from the NAS source.</value>
        [DataMember(Name="totalBytesTiered", EmitDefaultValue=true)]
        public long? TotalBytesTiered { get; set; }

        /// <summary>
        /// Contains the total number of bytes that will be read from the source (such as VM) for this snapshot.
        /// </summary>
        /// <value>Contains the total number of bytes that will be read from the source (such as VM) for this snapshot.</value>
        [DataMember(Name="totalBytesToReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesToReadFromSource { get; set; }

        /// <summary>
        /// The total number of file and directory entities that have changed since last backup. Only applicable to file based backups.
        /// </summary>
        /// <value>The total number of file and directory entities that have changed since last backup. Only applicable to file based backups.</value>
        [DataMember(Name="totalChangedEntityCount", EmitDefaultValue=true)]
        public long? TotalChangedEntityCount { get; set; }

        /// <summary>
        /// The total number of file and directory entities visited in this backup. Only applicable to file based backups.
        /// </summary>
        /// <value>The total number of file and directory entities visited in this backup. Only applicable to file based backups.</value>
        [DataMember(Name="totalEntityCount", EmitDefaultValue=true)]
        public long? TotalEntityCount { get; set; }

        /// <summary>
        /// Logical size of the source whose snapshot is being taken. This is the amount of data we would have read from the source had this been a full backup.
        /// </summary>
        /// <value>Logical size of the source whose snapshot is being taken. This is the amount of data we would have read from the source had this been a full backup.</value>
        [DataMember(Name="totalLogicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalLogicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Contains the information regarding number of bytes that the source (such as VM) has taken up on the primary storage.
        /// </summary>
        /// <value>Contains the information regarding number of bytes that the source (such as VM) has taken up on the primary storage.</value>
        [DataMember(Name="totalPrimaryPhysicalSizeBytes", EmitDefaultValue=true)]
        public long? TotalPrimaryPhysicalSizeBytes { get; set; }

        /// <summary>
        /// Total number of bytes to be zero-filled in Snap FS as part of this backup. Currently applicable only for VMware backups.
        /// </summary>
        /// <value>Total number of bytes to be zero-filled in Snap FS as part of this backup. Currently applicable only for VMware backups.</value>
        [DataMember(Name="totalZeroFillBytes", EmitDefaultValue=true)]
        public long? TotalZeroFillBytes { get; set; }

        /// <summary>
        /// The type of environment this snapshot info pertains to.
        /// </summary>
        /// <value>The type of environment this snapshot info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Whether during the backup, the backup view&#39;s case insensitivity property has been altered. If so, Madrox needs to take corresponding actions during replication.
        /// </summary>
        /// <value>Whether during the backup, the backup view&#39;s case insensitivity property has been altered. If so, Madrox needs to take corresponding actions during replication.</value>
        [DataMember(Name="viewCaseInsensitivityAltered", EmitDefaultValue=true)]
        public bool? ViewCaseInsensitivityAltered { get; set; }

        /// <summary>
        /// The data view name under which the snapshot was created. NOTE: This is populated only for View, Puppeteer, NAS and Oracle backup.
        /// </summary>
        /// <value>The data view name under which the snapshot was created. NOTE: This is populated only for View, Puppeteer, NAS and Oracle backup.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// The view name under which the snapshot of the migrated data was created. NOTE: This is populated only for data migration tasks.
        /// </summary>
        /// <value>The view name under which the snapshot of the migrated data was created. NOTE: This is populated only for data migration tasks.</value>
        [DataMember(Name="viewNameToGc", EmitDefaultValue=true)]
        public string ViewNameToGc { get; set; }

        /// <summary>
        /// Warnings if any. These warnings will be propogated to the UI by master.
        /// </summary>
        /// <value>Warnings if any. These warnings will be propogated to the UI by master.</value>
        [DataMember(Name="warnings", EmitDefaultValue=true)]
        public List<ErrorProto> Warnings { get; set; }

        /// <summary>
        /// Factor by which weight of a zero-fill sub-task should be scaled down. This is used while creating sub-task monitors.
        /// </summary>
        /// <value>Factor by which weight of a zero-fill sub-task should be scaled down. This is used while creating sub-task monitors.</value>
        [DataMember(Name="zeroFillTaskWeightScaleDownFactor", EmitDefaultValue=true)]
        public long? ZeroFillTaskWeightScaleDownFactor { get; set; }

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
            return this.Equals(input as SnapshotInfoProto);
        }

        /// <summary>
        /// Returns true if SnapshotInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangeRocksdbName == input.ChangeRocksdbName ||
                    (this.ChangeRocksdbName != null &&
                    this.ChangeRocksdbName.Equals(input.ChangeRocksdbName))
                ) && 
                (
                    this.ErrorRocksdbName == input.ErrorRocksdbName ||
                    (this.ErrorRocksdbName != null &&
                    this.ErrorRocksdbName.Equals(input.ErrorRocksdbName))
                ) && 
                (
                    this.FileWalkDone == input.FileWalkDone ||
                    (this.FileWalkDone != null &&
                    this.FileWalkDone.Equals(input.FileWalkDone))
                ) && 
                (
                    this.FrontEndSizeInfo == input.FrontEndSizeInfo ||
                    (this.FrontEndSizeInfo != null &&
                    this.FrontEndSizeInfo.Equals(input.FrontEndSizeInfo))
                ) && 
                (
                    this.MetadataViewName == input.MetadataViewName ||
                    (this.MetadataViewName != null &&
                    this.MetadataViewName.Equals(input.MetadataViewName))
                ) && 
                (
                    this.NumAppInstances == input.NumAppInstances ||
                    (this.NumAppInstances != null &&
                    this.NumAppInstances.Equals(input.NumAppInstances))
                ) && 
                (
                    this.NumAppObjects == input.NumAppObjects ||
                    (this.NumAppObjects != null &&
                    this.NumAppObjects.Equals(input.NumAppObjects))
                ) && 
                (
                    this.PostBackupScriptStatus == input.PostBackupScriptStatus ||
                    (this.PostBackupScriptStatus != null &&
                    this.PostBackupScriptStatus.Equals(input.PostBackupScriptStatus))
                ) && 
                (
                    this.PostSnapshotScriptStatus == input.PostSnapshotScriptStatus ||
                    (this.PostSnapshotScriptStatus != null &&
                    this.PostSnapshotScriptStatus.Equals(input.PostSnapshotScriptStatus))
                ) && 
                (
                    this.PreBackupScriptStatus == input.PreBackupScriptStatus ||
                    (this.PreBackupScriptStatus != null &&
                    this.PreBackupScriptStatus.Equals(input.PreBackupScriptStatus))
                ) && 
                (
                    this.ReacquirePermit == input.ReacquirePermit ||
                    (this.ReacquirePermit != null &&
                    this.ReacquirePermit.Equals(input.ReacquirePermit))
                ) && 
                (
                    this.RelativeSnapshotDir == input.RelativeSnapshotDir ||
                    (this.RelativeSnapshotDir != null &&
                    this.RelativeSnapshotDir.Equals(input.RelativeSnapshotDir))
                ) && 
                (
                    this.RootPath == input.RootPath ||
                    (this.RootPath != null &&
                    this.RootPath.Equals(input.RootPath))
                ) && 
                (
                    this.ScribeTableColumn == input.ScribeTableColumn ||
                    (this.ScribeTableColumn != null &&
                    this.ScribeTableColumn.Equals(input.ScribeTableColumn))
                ) && 
                (
                    this.ScribeTableRow == input.ScribeTableRow ||
                    (this.ScribeTableRow != null &&
                    this.ScribeTableRow.Equals(input.ScribeTableRow))
                ) && 
                (
                    this.SlaveTaskStartTimeUsecs == input.SlaveTaskStartTimeUsecs ||
                    (this.SlaveTaskStartTimeUsecs != null &&
                    this.SlaveTaskStartTimeUsecs.Equals(input.SlaveTaskStartTimeUsecs))
                ) && 
                (
                    this.SnapshotExpiryTime == input.SnapshotExpiryTime ||
                    (this.SnapshotExpiryTime != null &&
                    this.SnapshotExpiryTime.Equals(input.SnapshotExpiryTime))
                ) && 
                (
                    this.SnapshotType == input.SnapshotType ||
                    (this.SnapshotType != null &&
                    this.SnapshotType.Equals(input.SnapshotType))
                ) && 
                (
                    this.SourceSnapshotCreateTimeUsecs == input.SourceSnapshotCreateTimeUsecs ||
                    (this.SourceSnapshotCreateTimeUsecs != null &&
                    this.SourceSnapshotCreateTimeUsecs.Equals(input.SourceSnapshotCreateTimeUsecs))
                ) && 
                (
                    this.SourceSnapshotName == input.SourceSnapshotName ||
                    (this.SourceSnapshotName != null &&
                    this.SourceSnapshotName.Equals(input.SourceSnapshotName))
                ) && 
                (
                    this.SourceSnapshotStatus == input.SourceSnapshotStatus ||
                    (this.SourceSnapshotStatus != null &&
                    this.SourceSnapshotStatus.Equals(input.SourceSnapshotStatus))
                ) && 
                (
                    this.StorageSnapshotProvider == input.StorageSnapshotProvider ||
                    (this.StorageSnapshotProvider != null &&
                    this.StorageSnapshotProvider.Equals(input.StorageSnapshotProvider))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TotalBytesReadFromSource == input.TotalBytesReadFromSource ||
                    (this.TotalBytesReadFromSource != null &&
                    this.TotalBytesReadFromSource.Equals(input.TotalBytesReadFromSource))
                ) && 
                (
                    this.TotalBytesTiered == input.TotalBytesTiered ||
                    (this.TotalBytesTiered != null &&
                    this.TotalBytesTiered.Equals(input.TotalBytesTiered))
                ) && 
                (
                    this.TotalBytesToReadFromSource == input.TotalBytesToReadFromSource ||
                    (this.TotalBytesToReadFromSource != null &&
                    this.TotalBytesToReadFromSource.Equals(input.TotalBytesToReadFromSource))
                ) && 
                (
                    this.TotalChangedEntityCount == input.TotalChangedEntityCount ||
                    (this.TotalChangedEntityCount != null &&
                    this.TotalChangedEntityCount.Equals(input.TotalChangedEntityCount))
                ) && 
                (
                    this.TotalEntityCount == input.TotalEntityCount ||
                    (this.TotalEntityCount != null &&
                    this.TotalEntityCount.Equals(input.TotalEntityCount))
                ) && 
                (
                    this.TotalLogicalBackupSizeBytes == input.TotalLogicalBackupSizeBytes ||
                    (this.TotalLogicalBackupSizeBytes != null &&
                    this.TotalLogicalBackupSizeBytes.Equals(input.TotalLogicalBackupSizeBytes))
                ) && 
                (
                    this.TotalPrimaryPhysicalSizeBytes == input.TotalPrimaryPhysicalSizeBytes ||
                    (this.TotalPrimaryPhysicalSizeBytes != null &&
                    this.TotalPrimaryPhysicalSizeBytes.Equals(input.TotalPrimaryPhysicalSizeBytes))
                ) && 
                (
                    this.TotalZeroFillBytes == input.TotalZeroFillBytes ||
                    (this.TotalZeroFillBytes != null &&
                    this.TotalZeroFillBytes.Equals(input.TotalZeroFillBytes))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ViewCaseInsensitivityAltered == input.ViewCaseInsensitivityAltered ||
                    (this.ViewCaseInsensitivityAltered != null &&
                    this.ViewCaseInsensitivityAltered.Equals(input.ViewCaseInsensitivityAltered))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.ViewNameToGc == input.ViewNameToGc ||
                    (this.ViewNameToGc != null &&
                    this.ViewNameToGc.Equals(input.ViewNameToGc))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.ZeroFillTaskWeightScaleDownFactor == input.ZeroFillTaskWeightScaleDownFactor ||
                    (this.ZeroFillTaskWeightScaleDownFactor != null &&
                    this.ZeroFillTaskWeightScaleDownFactor.Equals(input.ZeroFillTaskWeightScaleDownFactor))
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
                if (this.ChangeRocksdbName != null)
                    hashCode = hashCode * 59 + this.ChangeRocksdbName.GetHashCode();
                if (this.ErrorRocksdbName != null)
                    hashCode = hashCode * 59 + this.ErrorRocksdbName.GetHashCode();
                if (this.FileWalkDone != null)
                    hashCode = hashCode * 59 + this.FileWalkDone.GetHashCode();
                if (this.FrontEndSizeInfo != null)
                    hashCode = hashCode * 59 + this.FrontEndSizeInfo.GetHashCode();
                if (this.MetadataViewName != null)
                    hashCode = hashCode * 59 + this.MetadataViewName.GetHashCode();
                if (this.NumAppInstances != null)
                    hashCode = hashCode * 59 + this.NumAppInstances.GetHashCode();
                if (this.NumAppObjects != null)
                    hashCode = hashCode * 59 + this.NumAppObjects.GetHashCode();
                if (this.PostBackupScriptStatus != null)
                    hashCode = hashCode * 59 + this.PostBackupScriptStatus.GetHashCode();
                if (this.PostSnapshotScriptStatus != null)
                    hashCode = hashCode * 59 + this.PostSnapshotScriptStatus.GetHashCode();
                if (this.PreBackupScriptStatus != null)
                    hashCode = hashCode * 59 + this.PreBackupScriptStatus.GetHashCode();
                if (this.ReacquirePermit != null)
                    hashCode = hashCode * 59 + this.ReacquirePermit.GetHashCode();
                if (this.RelativeSnapshotDir != null)
                    hashCode = hashCode * 59 + this.RelativeSnapshotDir.GetHashCode();
                if (this.RootPath != null)
                    hashCode = hashCode * 59 + this.RootPath.GetHashCode();
                if (this.ScribeTableColumn != null)
                    hashCode = hashCode * 59 + this.ScribeTableColumn.GetHashCode();
                if (this.ScribeTableRow != null)
                    hashCode = hashCode * 59 + this.ScribeTableRow.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.SnapshotExpiryTime != null)
                    hashCode = hashCode * 59 + this.SnapshotExpiryTime.GetHashCode();
                if (this.SnapshotType != null)
                    hashCode = hashCode * 59 + this.SnapshotType.GetHashCode();
                if (this.SourceSnapshotCreateTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SourceSnapshotCreateTimeUsecs.GetHashCode();
                if (this.SourceSnapshotName != null)
                    hashCode = hashCode * 59 + this.SourceSnapshotName.GetHashCode();
                if (this.SourceSnapshotStatus != null)
                    hashCode = hashCode * 59 + this.SourceSnapshotStatus.GetHashCode();
                if (this.StorageSnapshotProvider != null)
                    hashCode = hashCode * 59 + this.StorageSnapshotProvider.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TotalBytesReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesReadFromSource.GetHashCode();
                if (this.TotalBytesTiered != null)
                    hashCode = hashCode * 59 + this.TotalBytesTiered.GetHashCode();
                if (this.TotalBytesToReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesToReadFromSource.GetHashCode();
                if (this.TotalChangedEntityCount != null)
                    hashCode = hashCode * 59 + this.TotalChangedEntityCount.GetHashCode();
                if (this.TotalEntityCount != null)
                    hashCode = hashCode * 59 + this.TotalEntityCount.GetHashCode();
                if (this.TotalLogicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalBackupSizeBytes.GetHashCode();
                if (this.TotalPrimaryPhysicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalPrimaryPhysicalSizeBytes.GetHashCode();
                if (this.TotalZeroFillBytes != null)
                    hashCode = hashCode * 59 + this.TotalZeroFillBytes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewCaseInsensitivityAltered != null)
                    hashCode = hashCode * 59 + this.ViewCaseInsensitivityAltered.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.ViewNameToGc != null)
                    hashCode = hashCode * 59 + this.ViewNameToGc.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.ZeroFillTaskWeightScaleDownFactor != null)
                    hashCode = hashCode * 59 + this.ZeroFillTaskWeightScaleDownFactor.GetHashCode();
                return hashCode;
            }
        }

    }

}

