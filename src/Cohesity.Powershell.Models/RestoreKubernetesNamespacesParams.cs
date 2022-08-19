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
        /// <param name="initContainerImage">Container image used to mounting PVCs in temp pods..</param>
        /// <param name="isProtectionUsingDatamoverEnabled">This indicates if magneto_kubernetes_enable_protection_using_datamover is true and the flag is enabled in the feature enabler..</param>
        /// <param name="managementNamespace">Namespace in which restore job will be created in K8s cluster..</param>
        /// <param name="podMetadataVec">Information about pods in the namespace which was backed up..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="s3AccountId">S3 account ID that was used to register the source..</param>
        public RestoreKubernetesNamespacesParams(long? backupClusterId = default(long?), string backupJobName = default(string), EntityProto clusterEntity = default(EntityProto), string clusterSoftwareVersion = default(string), string initContainerImage = default(string), bool? isProtectionUsingDatamoverEnabled = default(bool?), string managementNamespace = default(string), List<PodMetadata> podMetadataVec = default(List<PodMetadata>), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), string s3AccountId = default(string))
        {
            this.BackupClusterId = backupClusterId;
            this.BackupJobName = backupJobName;
            this.ClusterEntity = clusterEntity;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.InitContainerImage = initContainerImage;
            this.IsProtectionUsingDatamoverEnabled = isProtectionUsingDatamoverEnabled;
            this.ManagementNamespace = managementNamespace;
            this.PodMetadataVec = podMetadataVec;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.S3AccountId = s3AccountId;
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
                    this.PodMetadataVec.Equals(input.PodMetadataVec)
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
                if (this.InitContainerImage != null)
                    hashCode = hashCode * 59 + this.InitContainerImage.GetHashCode();
                if (this.IsProtectionUsingDatamoverEnabled != null)
                    hashCode = hashCode * 59 + this.IsProtectionUsingDatamoverEnabled.GetHashCode();
                if (this.ManagementNamespace != null)
                    hashCode = hashCode * 59 + this.ManagementNamespace.GetHashCode();
                if (this.PodMetadataVec != null)
                    hashCode = hashCode * 59 + this.PodMetadataVec.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.S3AccountId != null)
                    hashCode = hashCode * 59 + this.S3AccountId.GetHashCode();
                return hashCode;
            }
        }

    }

}

