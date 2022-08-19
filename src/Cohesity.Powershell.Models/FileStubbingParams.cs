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
    /// File Stubbing Parameters Message to capture the additional stubbing params for a file-based environment.
    /// </summary>
    [DataContract]
    public partial class FileStubbingParams :  IEquatable<FileStubbingParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileStubbingParams" /> class.
        /// </summary>
        /// <param name="coldFileWindow">Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window msecs or are older than cold_window_msecs are migrated..</param>
        /// <param name="deleteOrphanData">Delete migrated data if no symlink at source is pointing to it..</param>
        /// <param name="enableAuditLogging">Audit log the file tiering activity..</param>
        /// <param name="enableChecksumVerification">Enable checksum verification for downtier job..</param>
        /// <param name="fileSelectPolicy">File migrate policy based on file access/modify time and age..</param>
        /// <param name="fileSize">Gives the size criteria to be used for selecting the files to be migrated. The cold files that are equal and greater than file_size or smaller than file_size are migrated..</param>
        /// <param name="fileSizePolicy">File size policy for selecting files to migrate..</param>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="migrateWithoutStub">Migrate data without stub..</param>
        /// <param name="nfsMountPath">Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data..</param>
        /// <param name="nfsMountPathPrefix">nfs_mount_path_prefix contains the parent directory path where respective view name will be suffixed to form a complete mount path where Cohesity target view will be mounted on NFS clients for accessing the migrated data..</param>
        /// <param name="targetViewMap">The object&#39;s entity id to TargetViewData map where the data will be migrated..</param>
        /// <param name="targetViewName">The target view name to which the data will be migrated..</param>
        /// <param name="targetViewPrefix">target_view_prefix is used to support multiple objects in a single tiering job. It helps in generating view name which are reasonably close to the original share name..</param>
        /// <param name="tieringGoal">Tiering Goal, i.e. the maximum amount of data that should be present on source after downtiering..</param>
        public FileStubbingParams(long? coldFileWindow = default(long?), bool? deleteOrphanData = default(bool?), bool? enableAuditLogging = default(bool?), bool? enableChecksumVerification = default(bool?), int? fileSelectPolicy = default(int?), long? fileSize = default(long?), int? fileSizePolicy = default(int?), FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), bool? migrateWithoutStub = default(bool?), string nfsMountPath = default(string), string nfsMountPathPrefix = default(string), List<FileStubbingParamsTargetViewMapEntry> targetViewMap = default(List<FileStubbingParamsTargetViewMapEntry>), string targetViewName = default(string), string targetViewPrefix = default(string), long? tieringGoal = default(long?))
        {
            this.ColdFileWindow = coldFileWindow;
            this.DeleteOrphanData = deleteOrphanData;
            this.EnableAuditLogging = enableAuditLogging;
            this.EnableChecksumVerification = enableChecksumVerification;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.FilteringPolicy = filteringPolicy;
            this.MigrateWithoutStub = migrateWithoutStub;
            this.NfsMountPath = nfsMountPath;
            this.NfsMountPathPrefix = nfsMountPathPrefix;
            this.TargetViewMap = targetViewMap;
            this.TargetViewName = targetViewName;
            this.TargetViewPrefix = targetViewPrefix;
            this.TieringGoal = tieringGoal;
        }
        
        /// <summary>
        /// Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window msecs or are older than cold_window_msecs are migrated.
        /// </summary>
        /// <value>Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window msecs or are older than cold_window_msecs are migrated.</value>
        [DataMember(Name="coldFileWindow", EmitDefaultValue=true)]
        public long? ColdFileWindow { get; set; }

        /// <summary>
        /// Delete migrated data if no symlink at source is pointing to it.
        /// </summary>
        /// <value>Delete migrated data if no symlink at source is pointing to it.</value>
        [DataMember(Name="deleteOrphanData", EmitDefaultValue=true)]
        public bool? DeleteOrphanData { get; set; }

        /// <summary>
        /// Audit log the file tiering activity.
        /// </summary>
        /// <value>Audit log the file tiering activity.</value>
        [DataMember(Name="enableAuditLogging", EmitDefaultValue=true)]
        public bool? EnableAuditLogging { get; set; }

        /// <summary>
        /// Enable checksum verification for downtier job.
        /// </summary>
        /// <value>Enable checksum verification for downtier job.</value>
        [DataMember(Name="enableChecksumVerification", EmitDefaultValue=true)]
        public bool? EnableChecksumVerification { get; set; }

        /// <summary>
        /// File migrate policy based on file access/modify time and age.
        /// </summary>
        /// <value>File migrate policy based on file access/modify time and age.</value>
        [DataMember(Name="fileSelectPolicy", EmitDefaultValue=true)]
        public int? FileSelectPolicy { get; set; }

        /// <summary>
        /// Gives the size criteria to be used for selecting the files to be migrated. The cold files that are equal and greater than file_size or smaller than file_size are migrated.
        /// </summary>
        /// <value>Gives the size criteria to be used for selecting the files to be migrated. The cold files that are equal and greater than file_size or smaller than file_size are migrated.</value>
        [DataMember(Name="fileSize", EmitDefaultValue=true)]
        public long? FileSize { get; set; }

        /// <summary>
        /// File size policy for selecting files to migrate.
        /// </summary>
        /// <value>File size policy for selecting files to migrate.</value>
        [DataMember(Name="fileSizePolicy", EmitDefaultValue=true)]
        public int? FileSizePolicy { get; set; }

        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// Migrate data without stub.
        /// </summary>
        /// <value>Migrate data without stub.</value>
        [DataMember(Name="migrateWithoutStub", EmitDefaultValue=true)]
        public bool? MigrateWithoutStub { get; set; }

        /// <summary>
        /// Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.
        /// </summary>
        /// <value>Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// nfs_mount_path_prefix contains the parent directory path where respective view name will be suffixed to form a complete mount path where Cohesity target view will be mounted on NFS clients for accessing the migrated data.
        /// </summary>
        /// <value>nfs_mount_path_prefix contains the parent directory path where respective view name will be suffixed to form a complete mount path where Cohesity target view will be mounted on NFS clients for accessing the migrated data.</value>
        [DataMember(Name="nfsMountPathPrefix", EmitDefaultValue=true)]
        public string NfsMountPathPrefix { get; set; }

        /// <summary>
        /// The object&#39;s entity id to TargetViewData map where the data will be migrated.
        /// </summary>
        /// <value>The object&#39;s entity id to TargetViewData map where the data will be migrated.</value>
        [DataMember(Name="targetViewMap", EmitDefaultValue=true)]
        public List<FileStubbingParamsTargetViewMapEntry> TargetViewMap { get; set; }

        /// <summary>
        /// The target view name to which the data will be migrated.
        /// </summary>
        /// <value>The target view name to which the data will be migrated.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// target_view_prefix is used to support multiple objects in a single tiering job. It helps in generating view name which are reasonably close to the original share name.
        /// </summary>
        /// <value>target_view_prefix is used to support multiple objects in a single tiering job. It helps in generating view name which are reasonably close to the original share name.</value>
        [DataMember(Name="targetViewPrefix", EmitDefaultValue=true)]
        public string TargetViewPrefix { get; set; }

        /// <summary>
        /// Tiering Goal, i.e. the maximum amount of data that should be present on source after downtiering.
        /// </summary>
        /// <value>Tiering Goal, i.e. the maximum amount of data that should be present on source after downtiering.</value>
        [DataMember(Name="tieringGoal", EmitDefaultValue=true)]
        public long? TieringGoal { get; set; }

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
            return this.Equals(input as FileStubbingParams);
        }

        /// <summary>
        /// Returns true if FileStubbingParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FileStubbingParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileStubbingParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColdFileWindow == input.ColdFileWindow ||
                    (this.ColdFileWindow != null &&
                    this.ColdFileWindow.Equals(input.ColdFileWindow))
                ) && 
                (
                    this.DeleteOrphanData == input.DeleteOrphanData ||
                    (this.DeleteOrphanData != null &&
                    this.DeleteOrphanData.Equals(input.DeleteOrphanData))
                ) && 
                (
                    this.EnableAuditLogging == input.EnableAuditLogging ||
                    (this.EnableAuditLogging != null &&
                    this.EnableAuditLogging.Equals(input.EnableAuditLogging))
                ) && 
                (
                    this.EnableChecksumVerification == input.EnableChecksumVerification ||
                    (this.EnableChecksumVerification != null &&
                    this.EnableChecksumVerification.Equals(input.EnableChecksumVerification))
                ) && 
                (
                    this.FileSelectPolicy == input.FileSelectPolicy ||
                    (this.FileSelectPolicy != null &&
                    this.FileSelectPolicy.Equals(input.FileSelectPolicy))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.FileSizePolicy == input.FileSizePolicy ||
                    (this.FileSizePolicy != null &&
                    this.FileSizePolicy.Equals(input.FileSizePolicy))
                ) && 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.MigrateWithoutStub == input.MigrateWithoutStub ||
                    (this.MigrateWithoutStub != null &&
                    this.MigrateWithoutStub.Equals(input.MigrateWithoutStub))
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.NfsMountPathPrefix == input.NfsMountPathPrefix ||
                    (this.NfsMountPathPrefix != null &&
                    this.NfsMountPathPrefix.Equals(input.NfsMountPathPrefix))
                ) && 
                (
                    this.TargetViewMap == input.TargetViewMap ||
                    this.TargetViewMap != null &&
                    input.TargetViewMap != null &&
                    this.TargetViewMap.Equals(input.TargetViewMap)
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
                ) && 
                (
                    this.TargetViewPrefix == input.TargetViewPrefix ||
                    (this.TargetViewPrefix != null &&
                    this.TargetViewPrefix.Equals(input.TargetViewPrefix))
                ) && 
                (
                    this.TieringGoal == input.TieringGoal ||
                    (this.TieringGoal != null &&
                    this.TieringGoal.Equals(input.TieringGoal))
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
                if (this.ColdFileWindow != null)
                    hashCode = hashCode * 59 + this.ColdFileWindow.GetHashCode();
                if (this.DeleteOrphanData != null)
                    hashCode = hashCode * 59 + this.DeleteOrphanData.GetHashCode();
                if (this.EnableAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableAuditLogging.GetHashCode();
                if (this.EnableChecksumVerification != null)
                    hashCode = hashCode * 59 + this.EnableChecksumVerification.GetHashCode();
                if (this.FileSelectPolicy != null)
                    hashCode = hashCode * 59 + this.FileSelectPolicy.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileSizePolicy != null)
                    hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.MigrateWithoutStub != null)
                    hashCode = hashCode * 59 + this.MigrateWithoutStub.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.NfsMountPathPrefix != null)
                    hashCode = hashCode * 59 + this.NfsMountPathPrefix.GetHashCode();
                if (this.TargetViewMap != null)
                    hashCode = hashCode * 59 + this.TargetViewMap.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                if (this.TargetViewPrefix != null)
                    hashCode = hashCode * 59 + this.TargetViewPrefix.GetHashCode();
                if (this.TieringGoal != null)
                    hashCode = hashCode * 59 + this.TieringGoal.GetHashCode();
                return hashCode;
            }
        }

    }

}

