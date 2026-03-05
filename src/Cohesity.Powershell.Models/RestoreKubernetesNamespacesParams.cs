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
    /// RestoreKubernetesNamespacesParams
    /// </summary>
    [DataContract]
    public partial class RestoreKubernetesNamespacesParams :  IEquatable<RestoreKubernetesNamespacesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreKubernetesNamespacesParams" /> class.
        /// </summary>
        /// <param name="backupClusterId">Cluster id of the cluster which performed the backup..</param>
        /// <param name="backupJobName">Backup job that needs to be used for recovering the namespace..</param>
        /// <param name="clusterEntity">clusterEntity.</param>
        /// <param name="clusterSoftwareVersion">Cluster software version..</param>
        /// <param name="datamoverServiceType">Indicates the kubernetes service type to use..</param>
        /// <param name="enableS3ForBackupView">Whether backup job used a S3 enabled view or not.</param>
        /// <param name="excludedPvcVec">List of PVCs that user requested to be excluded while doing restore..</param>
        /// <param name="initContainerImage">Container image used to mounting PVCs in temp pods..</param>
        /// <param name="isProtectionUsingDatamoverEnabled">This indicates if magneto_kubernetes_enable_protection_using_datamover is true and the flag is enabled in the feature enabler..</param>
        /// <param name="managementNamespace">Namespace in which restore job will be created in K8s cluster..</param>
        /// <param name="podMetadataVec">Information about pods in the namespace which was backed up..</param>
        /// <param name="preserveMacAddress">Whether to preserve mac address for restored vm..</param>
        /// <param name="pvcBackupSuccessVec">List of PVCs (PVC names) that were successfully backed up..</param>
        /// <param name="pvcInfoMap">Map of PVC (names) to PvcInfo discovered in the backed up namespace..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="s3AccountId">S3 account ID that was used to register the source..</param>
        /// <param name="skipRestoreValidation">Whether to skip restore validation..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public RestoreKubernetesNamespacesParams(long? backupClusterId = default(long?), string backupJobName = default(string), EntityProto clusterEntity = default(EntityProto), string clusterSoftwareVersion = default(string), int? datamoverServiceType = default(int?), bool? enableS3ForBackupView = default(bool?), List<string> excludedPvcVec = default(List<string>), string initContainerImage = default(string), bool? isProtectionUsingDatamoverEnabled = default(bool?), string managementNamespace = default(string), List<PodMetadata> podMetadataVec = default(List<PodMetadata>), bool? preserveMacAddress = default(bool?), List<string> pvcBackupSuccessVec = default(List<string>), Dictionary<string, PvcInfo> pvcInfoMap = default(Dictionary<string, PvcInfo>), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), string s3AccountId = default(string), bool? skipRestoreValidation = default(bool?), VlanParams vlanParams = default(VlanParams))
        {
            this.BackupClusterId = backupClusterId;
            this.BackupJobName = backupJobName;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.DatamoverServiceType = datamoverServiceType;
            this.EnableS3ForBackupView = enableS3ForBackupView;
            this.ExcludedPvcVec = excludedPvcVec;
            this.InitContainerImage = initContainerImage;
            this.IsProtectionUsingDatamoverEnabled = isProtectionUsingDatamoverEnabled;
            this.ManagementNamespace = managementNamespace;
            this.PodMetadataVec = podMetadataVec;
            this.PreserveMacAddress = preserveMacAddress;
            this.PvcBackupSuccessVec = pvcBackupSuccessVec;
            this.PvcInfoMap = pvcInfoMap;
            this.S3AccountId = s3AccountId;
            this.SkipRestoreValidation = skipRestoreValidation;
            this.BackupClusterId = backupClusterId;
            this.BackupJobName = backupJobName;
            this.ClusterEntity = clusterEntity;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.DatamoverServiceType = datamoverServiceType;
            this.EnableS3ForBackupView = enableS3ForBackupView;
            this.ExcludedPvcVec = excludedPvcVec;
            this.InitContainerImage = initContainerImage;
            this.IsProtectionUsingDatamoverEnabled = isProtectionUsingDatamoverEnabled;
            this.ManagementNamespace = managementNamespace;
            this.PodMetadataVec = podMetadataVec;
            this.PreserveMacAddress = preserveMacAddress;
            this.PvcBackupSuccessVec = pvcBackupSuccessVec;
            this.PvcInfoMap = pvcInfoMap;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.S3AccountId = s3AccountId;
            this.SkipRestoreValidation = skipRestoreValidation;
            this.VlanParams = vlanParams;
        }
        
        /// <summary>
        /// Cluster id of the cluster which performed the backup.
        /// </summary>
        /// <value>Cluster id of the cluster which performed the backup.</value>
        [DataMember(Name="backupClusterId", EmitDefaultValue=true)]
        public long? BackupClusterId { get; set; }

        /// <summary>
        /// Backup job that needs to be used for recovering the namespace.
        /// </summary>
        /// <value>Backup job that needs to be used for recovering the namespace.</value>
        [DataMember(Name="backupJobName", EmitDefaultValue=true)]
        public string BackupJobName { get; set; }

        /// <summary>
        /// Gets or Sets ClusterEntity
        /// </summary>
        [DataMember(Name="clusterEntity", EmitDefaultValue=false)]
        public EntityProto ClusterEntity { get; set; }

        /// <summary>
        /// Cluster software version.
        /// </summary>
        /// <value>Cluster software version.</value>
        [DataMember(Name="clusterSoftwareVersion", EmitDefaultValue=true)]
        public string ClusterSoftwareVersion { get; set; }

        /// <summary>
        /// Indicates the kubernetes service type to use.
        /// </summary>
        /// <value>Indicates the kubernetes service type to use.</value>
        [DataMember(Name="datamoverServiceType", EmitDefaultValue=true)]
        public int? DatamoverServiceType { get; set; }

        /// <summary>
        /// Whether backup job used a S3 enabled view or not
        /// </summary>
        /// <value>Whether backup job used a S3 enabled view or not</value>
        [DataMember(Name="enableS3ForBackupView", EmitDefaultValue=true)]
        public bool? EnableS3ForBackupView { get; set; }

        /// <summary>
        /// List of PVCs that user requested to be excluded while doing restore.
        /// </summary>
        /// <value>List of PVCs that user requested to be excluded while doing restore.</value>
        [DataMember(Name="excludedPvcVec", EmitDefaultValue=true)]
        public List<string> ExcludedPvcVec { get; set; }

        /// <summary>
        /// Container image used to mounting PVCs in temp pods.
        /// </summary>
        /// <value>Container image used to mounting PVCs in temp pods.</value>
        [DataMember(Name="initContainerImage", EmitDefaultValue=true)]
        public string InitContainerImage { get; set; }

        /// <summary>
        /// This indicates if magneto_kubernetes_enable_protection_using_datamover is true and the flag is enabled in the feature enabler.
        /// </summary>
        /// <value>This indicates if magneto_kubernetes_enable_protection_using_datamover is true and the flag is enabled in the feature enabler.</value>
        [DataMember(Name="isProtectionUsingDatamoverEnabled", EmitDefaultValue=true)]
        public bool? IsProtectionUsingDatamoverEnabled { get; set; }

        /// <summary>
        /// Namespace in which restore job will be created in K8s cluster.
        /// </summary>
        /// <value>Namespace in which restore job will be created in K8s cluster.</value>
        [DataMember(Name="managementNamespace", EmitDefaultValue=true)]
        public string ManagementNamespace { get; set; }

        /// <summary>
        /// Information about pods in the namespace which was backed up.
        /// </summary>
        /// <value>Information about pods in the namespace which was backed up.</value>
        [DataMember(Name="podMetadataVec", EmitDefaultValue=true)]
        public List<PodMetadata> PodMetadataVec { get; set; }

        /// <summary>
        /// Whether to preserve mac address for restored vm.
        /// </summary>
        /// <value>Whether to preserve mac address for restored vm.</value>
        [DataMember(Name="preserveMacAddress", EmitDefaultValue=true)]
        public bool? PreserveMacAddress { get; set; }

        /// <summary>
        /// List of PVCs (PVC names) that were successfully backed up.
        /// </summary>
        /// <value>List of PVCs (PVC names) that were successfully backed up.</value>
        [DataMember(Name="pvcBackupSuccessVec", EmitDefaultValue=true)]
        public List<string> PvcBackupSuccessVec { get; set; }

        /// <summary>
        /// Map of PVC (names) to PvcInfo discovered in the backed up namespace.
        /// </summary>
        /// <value>Map of PVC (names) to PvcInfo discovered in the backed up namespace.</value>
        [DataMember(Name="pvcInfoMap", EmitDefaultValue=true)]
        public Dictionary<string, PvcInfo> PvcInfoMap { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredObjectParam
        /// </summary>
        [DataMember(Name="renameRestoredObjectParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredObjectParam { get; set; }

        /// <summary>
        /// S3 account ID that was used to register the source.
        /// </summary>
        /// <value>S3 account ID that was used to register the source.</value>
        [DataMember(Name="s3AccountId", EmitDefaultValue=true)]
        public string S3AccountId { get; set; }

        /// <summary>
        /// Whether to skip restore validation.
        /// </summary>
        /// <value>Whether to skip restore validation.</value>
        [DataMember(Name="skipRestoreValidation", EmitDefaultValue=true)]
        public bool? SkipRestoreValidation { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParams VlanParams { get; set; }

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
            return this.Equals(input as RestoreKubernetesNamespacesParams);
        }

        /// <summary>
        /// Returns true if RestoreKubernetesNamespacesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreKubernetesNamespacesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreKubernetesNamespacesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupClusterId == input.BackupClusterId ||
                    (this.BackupClusterId != null &&
                    this.BackupClusterId.Equals(input.BackupClusterId))
                ) && 
                (
                    this.BackupJobName == input.BackupJobName ||
                    (this.BackupJobName != null &&
                    this.BackupJobName.Equals(input.BackupJobName))
                ) && 
                (
                    this.ClusterEntity == input.ClusterEntity ||
                    (this.ClusterEntity != null &&
                    this.ClusterEntity.Equals(input.ClusterEntity))
                ) && 
                (
                    this.ClusterSoftwareVersion == input.ClusterSoftwareVersion ||
                    (this.ClusterSoftwareVersion != null &&
                    this.ClusterSoftwareVersion.Equals(input.ClusterSoftwareVersion))
                ) && 
                (
                    this.DatamoverServiceType == input.DatamoverServiceType ||
                    (this.DatamoverServiceType != null &&
                    this.DatamoverServiceType.Equals(input.DatamoverServiceType))
                ) && 
                (
                    this.EnableS3ForBackupView == input.EnableS3ForBackupView ||
                    (this.EnableS3ForBackupView != null &&
                    this.EnableS3ForBackupView.Equals(input.EnableS3ForBackupView))
                ) && 
                (
                    this.ExcludedPvcVec == input.ExcludedPvcVec ||
                    this.ExcludedPvcVec != null &&
                    input.ExcludedPvcVec != null &&
                    this.ExcludedPvcVec.SequenceEqual(input.ExcludedPvcVec)
                ) && 
                (
                    this.InitContainerImage == input.InitContainerImage ||
                    (this.InitContainerImage != null &&
                    this.InitContainerImage.Equals(input.InitContainerImage))
                ) && 
                (
                    this.IsProtectionUsingDatamoverEnabled == input.IsProtectionUsingDatamoverEnabled ||
                    (this.IsProtectionUsingDatamoverEnabled != null &&
                    this.IsProtectionUsingDatamoverEnabled.Equals(input.IsProtectionUsingDatamoverEnabled))
                ) && 
                (
                    this.ManagementNamespace == input.ManagementNamespace ||
                    (this.ManagementNamespace != null &&
                    this.ManagementNamespace.Equals(input.ManagementNamespace))
                ) && 
                (
                    this.PodMetadataVec == input.PodMetadataVec ||
                    this.PodMetadataVec != null &&
                    input.PodMetadataVec != null &&
                    this.PodMetadataVec.SequenceEqual(input.PodMetadataVec)
                ) && 
                (
                    this.PreserveMacAddress == input.PreserveMacAddress ||
                    (this.PreserveMacAddress != null &&
                    this.PreserveMacAddress.Equals(input.PreserveMacAddress))
                ) && 
                (
                    this.PvcBackupSuccessVec == input.PvcBackupSuccessVec ||
                    this.PvcBackupSuccessVec != null &&
                    input.PvcBackupSuccessVec != null &&
                    this.PvcBackupSuccessVec.SequenceEqual(input.PvcBackupSuccessVec)
                ) && 
                (
                    this.PvcInfoMap == input.PvcInfoMap ||
                    this.PvcInfoMap != null &&
                    input.PvcInfoMap != null &&
                    this.PvcInfoMap.SequenceEqual(input.PvcInfoMap)
                ) && 
                (
                    this.RenameRestoredObjectParam == input.RenameRestoredObjectParam ||
                    (this.RenameRestoredObjectParam != null &&
                    this.RenameRestoredObjectParam.Equals(input.RenameRestoredObjectParam))
                ) && 
                (
                    this.S3AccountId == input.S3AccountId ||
                    (this.S3AccountId != null &&
                    this.S3AccountId.Equals(input.S3AccountId))
                ) && 
                (
                    this.SkipRestoreValidation == input.SkipRestoreValidation ||
                    (this.SkipRestoreValidation != null &&
                    this.SkipRestoreValidation.Equals(input.SkipRestoreValidation))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
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
                if (this.BackupClusterId != null)
                    hashCode = hashCode * 59 + this.BackupClusterId.GetHashCode();
                if (this.BackupJobName != null)
                    hashCode = hashCode * 59 + this.BackupJobName.GetHashCode();
                if (this.ClusterEntity != null)
                    hashCode = hashCode * 59 + this.ClusterEntity.GetHashCode();
                if (this.ClusterSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSoftwareVersion.GetHashCode();
                if (this.DatamoverServiceType != null)
                    hashCode = hashCode * 59 + this.DatamoverServiceType.GetHashCode();
                if (this.EnableS3ForBackupView != null)
                    hashCode = hashCode * 59 + this.EnableS3ForBackupView.GetHashCode();
                if (this.ExcludedPvcVec != null)
                    hashCode = hashCode * 59 + this.ExcludedPvcVec.GetHashCode();
                if (this.InitContainerImage != null)
                    hashCode = hashCode * 59 + this.InitContainerImage.GetHashCode();
                if (this.IsProtectionUsingDatamoverEnabled != null)
                    hashCode = hashCode * 59 + this.IsProtectionUsingDatamoverEnabled.GetHashCode();
                if (this.ManagementNamespace != null)
                    hashCode = hashCode * 59 + this.ManagementNamespace.GetHashCode();
                if (this.PodMetadataVec != null)
                    hashCode = hashCode * 59 + this.PodMetadataVec.GetHashCode();
                if (this.PreserveMacAddress != null)
                    hashCode = hashCode * 59 + this.PreserveMacAddress.GetHashCode();
                if (this.PvcBackupSuccessVec != null)
                    hashCode = hashCode * 59 + this.PvcBackupSuccessVec.GetHashCode();
                if (this.PvcInfoMap != null)
                    hashCode = hashCode * 59 + this.PvcInfoMap.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.S3AccountId != null)
                    hashCode = hashCode * 59 + this.S3AccountId.GetHashCode();
                if (this.SkipRestoreValidation != null)
                    hashCode = hashCode * 59 + this.SkipRestoreValidation.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

