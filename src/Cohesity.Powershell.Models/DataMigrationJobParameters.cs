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
    /// Specifies parameters applicable for data migration jobs in NAS environment.
    /// </summary>
    [DataContract]
    public partial class DataMigrationJobParameters :  IEquatable<DataMigrationJobParameters>
    {
        /// <summary>
        /// Specifies policy to select a file to migrate based on its creation, last access or modification time. eg. A file can be selected to migrate if it has not been accessed/modified in the ColdFileWindow. enum: kOlderThan, kLastAccessed, kLastModified. Specifies policy for file seletion in data migration jobs based on time. &#39;kOlderThan&#39;: Migrate the files that are older than cold file window. &#39;kLastAccessed&#39;: Migrate the files thar are not accessed in cold file window. &#39;kLastModified&#39;: Migrate the files that have not been modified in cold file window.
        /// </summary>
        /// <value>Specifies policy to select a file to migrate based on its creation, last access or modification time. eg. A file can be selected to migrate if it has not been accessed/modified in the ColdFileWindow. enum: kOlderThan, kLastAccessed, kLastModified. Specifies policy for file seletion in data migration jobs based on time. &#39;kOlderThan&#39;: Migrate the files that are older than cold file window. &#39;kLastAccessed&#39;: Migrate the files thar are not accessed in cold file window. &#39;kLastModified&#39;: Migrate the files that have not been modified in cold file window.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileSelectionPolicyEnum
        {
            /// <summary>
            /// Enum KOlderThan for value: kOlderThan
            /// </summary>
            [EnumMember(Value = "kOlderThan")]
            KOlderThan = 1,

            /// <summary>
            /// Enum KLastAccessed for value: kLastAccessed
            /// </summary>
            [EnumMember(Value = "kLastAccessed")]
            KLastAccessed = 2,

            /// <summary>
            /// Enum KLastModified for value: kLastModified
            /// </summary>
            [EnumMember(Value = "kLastModified")]
            KLastModified = 3

        }

        /// <summary>
        /// Specifies policy to select a file to migrate based on its creation, last access or modification time. eg. A file can be selected to migrate if it has not been accessed/modified in the ColdFileWindow. enum: kOlderThan, kLastAccessed, kLastModified. Specifies policy for file seletion in data migration jobs based on time. &#39;kOlderThan&#39;: Migrate the files that are older than cold file window. &#39;kLastAccessed&#39;: Migrate the files thar are not accessed in cold file window. &#39;kLastModified&#39;: Migrate the files that have not been modified in cold file window.
        /// </summary>
        /// <value>Specifies policy to select a file to migrate based on its creation, last access or modification time. eg. A file can be selected to migrate if it has not been accessed/modified in the ColdFileWindow. enum: kOlderThan, kLastAccessed, kLastModified. Specifies policy for file seletion in data migration jobs based on time. &#39;kOlderThan&#39;: Migrate the files that are older than cold file window. &#39;kLastAccessed&#39;: Migrate the files thar are not accessed in cold file window. &#39;kLastModified&#39;: Migrate the files that have not been modified in cold file window.</value>
        [DataMember(Name="fileSelectionPolicy", EmitDefaultValue=true)]
        public FileSelectionPolicyEnum? FileSelectionPolicy { get; set; }
        /// <summary>
        /// Specifies policy to select a file to migrate based on its size. eg. A file can be selected to migrate if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file seletion in data migration jobs based on file size. &#39;kGreaterThan&#39;: Migrate the files whose size are greater than specified file size. &#39;kSmallerThan&#39;: Migrate the files whose size are smaller than specified file size.
        /// </summary>
        /// <value>Specifies policy to select a file to migrate based on its size. eg. A file can be selected to migrate if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file seletion in data migration jobs based on file size. &#39;kGreaterThan&#39;: Migrate the files whose size are greater than specified file size. &#39;kSmallerThan&#39;: Migrate the files whose size are smaller than specified file size.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileSizePolicyEnum
        {
            /// <summary>
            /// Enum KGreaterThan for value: kGreaterThan
            /// </summary>
            [EnumMember(Value = "kGreaterThan")]
            KGreaterThan = 1,

            /// <summary>
            /// Enum KSmallerThan for value: kSmallerThan
            /// </summary>
            [EnumMember(Value = "kSmallerThan")]
            KSmallerThan = 2

        }

        /// <summary>
        /// Specifies policy to select a file to migrate based on its size. eg. A file can be selected to migrate if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file seletion in data migration jobs based on file size. &#39;kGreaterThan&#39;: Migrate the files whose size are greater than specified file size. &#39;kSmallerThan&#39;: Migrate the files whose size are smaller than specified file size.
        /// </summary>
        /// <value>Specifies policy to select a file to migrate based on its size. eg. A file can be selected to migrate if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file seletion in data migration jobs based on file size. &#39;kGreaterThan&#39;: Migrate the files whose size are greater than specified file size. &#39;kSmallerThan&#39;: Migrate the files whose size are smaller than specified file size.</value>
        [DataMember(Name="fileSizePolicy", EmitDefaultValue=true)]
        public FileSizePolicyEnum? FileSizePolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMigrationJobParameters" /> class.
        /// </summary>
        /// <param name="coldFileWindow">Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window are migrated..</param>
        /// <param name="filePathFilter">filePathFilter.</param>
        /// <param name="fileSelectionPolicy">Specifies policy to select a file to migrate based on its creation, last access or modification time. eg. A file can be selected to migrate if it has not been accessed/modified in the ColdFileWindow. enum: kOlderThan, kLastAccessed, kLastModified. Specifies policy for file seletion in data migration jobs based on time. &#39;kOlderThan&#39;: Migrate the files that are older than cold file window. &#39;kLastAccessed&#39;: Migrate the files thar are not accessed in cold file window. &#39;kLastModified&#39;: Migrate the files that have not been modified in cold file window..</param>
        /// <param name="fileSizeBytes">Gives the size criteria to be used for selecting the files to be migrated in bytes. The cold files that are equal and greater than this size are migrated..</param>
        /// <param name="fileSizePolicy">Specifies policy to select a file to migrate based on its size. eg. A file can be selected to migrate if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file seletion in data migration jobs based on file size. &#39;kGreaterThan&#39;: Migrate the files whose size are greater than specified file size. &#39;kSmallerThan&#39;: Migrate the files whose size are smaller than specified file size..</param>
        /// <param name="nfsMountPath">Mount path where the target view must be mounted on all NFS clients for accessing the migrated data..</param>
        /// <param name="targetViewName">The target view name to which the data will be migrated..</param>
        public DataMigrationJobParameters(long? coldFileWindow = default(long?), FilePathFilter filePathFilter = default(FilePathFilter), FileSelectionPolicyEnum? fileSelectionPolicy = default(FileSelectionPolicyEnum?), long? fileSizeBytes = default(long?), FileSizePolicyEnum? fileSizePolicy = default(FileSizePolicyEnum?), string nfsMountPath = default(string), string targetViewName = default(string))
        {
            this.ColdFileWindow = coldFileWindow;
            this.FileSelectionPolicy = fileSelectionPolicy;
            this.FileSizeBytes = fileSizeBytes;
            this.FileSizePolicy = fileSizePolicy;
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
            this.ColdFileWindow = coldFileWindow;
            this.FilePathFilter = filePathFilter;
            this.FileSelectionPolicy = fileSelectionPolicy;
            this.FileSizeBytes = fileSizeBytes;
            this.FileSizePolicy = fileSizePolicy;
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
        }
        
        /// <summary>
        /// Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window are migrated.
        /// </summary>
        /// <value>Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window are migrated.</value>
        [DataMember(Name="coldFileWindow", EmitDefaultValue=true)]
        public long? ColdFileWindow { get; set; }

        /// <summary>
        /// Gets or Sets FilePathFilter
        /// </summary>
        [DataMember(Name="filePathFilter", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilter { get; set; }

        /// <summary>
        /// Gives the size criteria to be used for selecting the files to be migrated in bytes. The cold files that are equal and greater than this size are migrated.
        /// </summary>
        /// <value>Gives the size criteria to be used for selecting the files to be migrated in bytes. The cold files that are equal and greater than this size are migrated.</value>
        [DataMember(Name="fileSizeBytes", EmitDefaultValue=true)]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Mount path where the target view must be mounted on all NFS clients for accessing the migrated data.
        /// </summary>
        /// <value>Mount path where the target view must be mounted on all NFS clients for accessing the migrated data.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// The target view name to which the data will be migrated.
        /// </summary>
        /// <value>The target view name to which the data will be migrated.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

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
            return this.Equals(input as DataMigrationJobParameters);
        }

        /// <summary>
        /// Returns true if DataMigrationJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DataMigrationJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataMigrationJobParameters input)
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
                    this.FilePathFilter == input.FilePathFilter ||
                    (this.FilePathFilter != null &&
                    this.FilePathFilter.Equals(input.FilePathFilter))
                ) && 
                (
                    this.FileSelectionPolicy == input.FileSelectionPolicy ||
                    this.FileSelectionPolicy.Equals(input.FileSelectionPolicy)
                ) && 
                (
                    this.FileSizeBytes == input.FileSizeBytes ||
                    (this.FileSizeBytes != null &&
                    this.FileSizeBytes.Equals(input.FileSizeBytes))
                ) && 
                (
                    this.FileSizePolicy == input.FileSizePolicy ||
                    this.FileSizePolicy.Equals(input.FileSizePolicy)
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                if (this.FilePathFilter != null)
                    hashCode = hashCode * 59 + this.FilePathFilter.GetHashCode();
                hashCode = hashCode * 59 + this.FileSelectionPolicy.GetHashCode();
                if (this.FileSizeBytes != null)
                    hashCode = hashCode * 59 + this.FileSizeBytes.GetHashCode();
                hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

