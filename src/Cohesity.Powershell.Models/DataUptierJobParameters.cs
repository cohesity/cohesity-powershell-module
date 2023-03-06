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
    /// DataUptierJobParameters
    /// </summary>
    [DataContract]
    public partial class DataUptierJobParameters :  IEquatable<DataUptierJobParameters>
    {
        /// <summary>
        /// Specifies policy to select a file to uptier based on file access or modification time. eg. A file can be selected to uptier if it has been accessed in the HotFileWindow or it is modified. enum: kLastAccessed, kLastModified. Specifies policy for file selection in data uptier jobs. &#39;kLastAccessed&#39;: Uptier the files which are accessed for at least num_file_access in hot_file_window. &#39;kLastModified&#39;: Uptier the files which are modified.
        /// </summary>
        /// <value>Specifies policy to select a file to uptier based on file access or modification time. eg. A file can be selected to uptier if it has been accessed in the HotFileWindow or it is modified. enum: kLastAccessed, kLastModified. Specifies policy for file selection in data uptier jobs. &#39;kLastAccessed&#39;: Uptier the files which are accessed for at least num_file_access in hot_file_window. &#39;kLastModified&#39;: Uptier the files which are modified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileSelectionPolicyEnum
        {
            /// <summary>
            /// Enum KLastAccessed for value: kLastAccessed
            /// </summary>
            [EnumMember(Value = "kLastAccessed")]
            KLastAccessed = 1,

            /// <summary>
            /// Enum KLastModified for value: kLastModified
            /// </summary>
            [EnumMember(Value = "kLastModified")]
            KLastModified = 2

        }

        /// <summary>
        /// Specifies policy to select a file to uptier based on file access or modification time. eg. A file can be selected to uptier if it has been accessed in the HotFileWindow or it is modified. enum: kLastAccessed, kLastModified. Specifies policy for file selection in data uptier jobs. &#39;kLastAccessed&#39;: Uptier the files which are accessed for at least num_file_access in hot_file_window. &#39;kLastModified&#39;: Uptier the files which are modified.
        /// </summary>
        /// <value>Specifies policy to select a file to uptier based on file access or modification time. eg. A file can be selected to uptier if it has been accessed in the HotFileWindow or it is modified. enum: kLastAccessed, kLastModified. Specifies policy for file selection in data uptier jobs. &#39;kLastAccessed&#39;: Uptier the files which are accessed for at least num_file_access in hot_file_window. &#39;kLastModified&#39;: Uptier the files which are modified.</value>
        [DataMember(Name="fileSelectionPolicy", EmitDefaultValue=true)]
        public FileSelectionPolicyEnum? FileSelectionPolicy { get; set; }
        /// <summary>
        /// Specifies policy to select a file to uptier based on its size. eg. A file can be selected to uptier if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file selection in data uptier jobs based on file size. &#39;kGreaterThan&#39;: Uptier the files having size greater than file_size. &#39;kSmallerThan&#39;: Uptier the files having size smaller than file_size.
        /// </summary>
        /// <value>Specifies policy to select a file to uptier based on its size. eg. A file can be selected to uptier if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file selection in data uptier jobs based on file size. &#39;kGreaterThan&#39;: Uptier the files having size greater than file_size. &#39;kSmallerThan&#39;: Uptier the files having size smaller than file_size.</value>
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
        /// Specifies policy to select a file to uptier based on its size. eg. A file can be selected to uptier if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file selection in data uptier jobs based on file size. &#39;kGreaterThan&#39;: Uptier the files having size greater than file_size. &#39;kSmallerThan&#39;: Uptier the files having size smaller than file_size.
        /// </summary>
        /// <value>Specifies policy to select a file to uptier based on its size. eg. A file can be selected to uptier if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file selection in data uptier jobs based on file size. &#39;kGreaterThan&#39;: Uptier the files having size greater than file_size. &#39;kSmallerThan&#39;: Uptier the files having size smaller than file_size.</value>
        [DataMember(Name="fileSizePolicy", EmitDefaultValue=true)]
        public FileSizePolicyEnum? FileSizePolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataUptierJobParameters" /> class.
        /// </summary>
        /// <param name="fileSelectionPolicy">Specifies policy to select a file to uptier based on file access or modification time. eg. A file can be selected to uptier if it has been accessed in the HotFileWindow or it is modified. enum: kLastAccessed, kLastModified. Specifies policy for file selection in data uptier jobs. &#39;kLastAccessed&#39;: Uptier the files which are accessed for at least num_file_access in hot_file_window. &#39;kLastModified&#39;: Uptier the files which are modified..</param>
        /// <param name="fileSizeBytes">Gives the size criteria to be used for selecting the files to be uptiered in bytes. The hot files that are smaller or greater than this size are uptiered..</param>
        /// <param name="fileSizePolicy">Specifies policy to select a file to uptier based on its size. eg. A file can be selected to uptier if its size is greater than or smaller than the FileSizeBytes. enum: kGreaterThan, kSmallerThan. Specifies policy for file selection in data uptier jobs based on file size. &#39;kGreaterThan&#39;: Uptier the files having size greater than file_size. &#39;kSmallerThan&#39;: Uptier the files having size smaller than file_size..</param>
        /// <param name="hotFileWindow">Identifies the hot files in the NAS source. Files that have been modified in the last hot_file_window are uptiered. Applicable only when file_select_policy is kLastAccessed..</param>
        /// <param name="includeAllFiles">Specifies whether uptier all files found in the view by overriding the FileUptierSelectionPolicy &amp; FileUptierSizePolicy constraints. Default value false..</param>
        /// <param name="nfsMountPath">Mount path where the Cohesity target view is mounted on NFS clients while migrating the data..</param>
        /// <param name="numFileAccess">Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed..</param>
        /// <param name="sourceViewName">The source view name from which the data will be uptiered..</param>
        public DataUptierJobParameters(FileSelectionPolicyEnum? fileSelectionPolicy = default(FileSelectionPolicyEnum?), long? fileSizeBytes = default(long?), FileSizePolicyEnum? fileSizePolicy = default(FileSizePolicyEnum?), long? hotFileWindow = default(long?), bool? includeAllFiles = default(bool?), string nfsMountPath = default(string), int? numFileAccess = default(int?), string sourceViewName = default(string))
        {
            this.FileSelectionPolicy = fileSelectionPolicy;
            this.FileSizeBytes = fileSizeBytes;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.IncludeAllFiles = includeAllFiles;
            this.NfsMountPath = nfsMountPath;
            this.NumFileAccess = numFileAccess;
            this.SourceViewName = sourceViewName;
            this.FileSelectionPolicy = fileSelectionPolicy;
            this.FileSizeBytes = fileSizeBytes;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.IncludeAllFiles = includeAllFiles;
            this.NfsMountPath = nfsMountPath;
            this.NumFileAccess = numFileAccess;
            this.SourceViewName = sourceViewName;
        }
        
        /// <summary>
        /// Gives the size criteria to be used for selecting the files to be uptiered in bytes. The hot files that are smaller or greater than this size are uptiered.
        /// </summary>
        /// <value>Gives the size criteria to be used for selecting the files to be uptiered in bytes. The hot files that are smaller or greater than this size are uptiered.</value>
        [DataMember(Name="fileSizeBytes", EmitDefaultValue=true)]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Identifies the hot files in the NAS source. Files that have been modified in the last hot_file_window are uptiered. Applicable only when file_select_policy is kLastAccessed.
        /// </summary>
        /// <value>Identifies the hot files in the NAS source. Files that have been modified in the last hot_file_window are uptiered. Applicable only when file_select_policy is kLastAccessed.</value>
        [DataMember(Name="hotFileWindow", EmitDefaultValue=true)]
        public long? HotFileWindow { get; set; }

        /// <summary>
        /// Specifies whether uptier all files found in the view by overriding the FileUptierSelectionPolicy &amp; FileUptierSizePolicy constraints. Default value false.
        /// </summary>
        /// <value>Specifies whether uptier all files found in the view by overriding the FileUptierSelectionPolicy &amp; FileUptierSizePolicy constraints. Default value false.</value>
        [DataMember(Name="includeAllFiles", EmitDefaultValue=true)]
        public bool? IncludeAllFiles { get; set; }

        /// <summary>
        /// Mount path where the Cohesity target view is mounted on NFS clients while migrating the data.
        /// </summary>
        /// <value>Mount path where the Cohesity target view is mounted on NFS clients while migrating the data.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed.
        /// </summary>
        /// <value>Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed.</value>
        [DataMember(Name="numFileAccess", EmitDefaultValue=true)]
        public int? NumFileAccess { get; set; }

        /// <summary>
        /// The source view name from which the data will be uptiered.
        /// </summary>
        /// <value>The source view name from which the data will be uptiered.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=true)]
        public string SourceViewName { get; set; }

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
            return this.Equals(input as DataUptierJobParameters);
        }

        /// <summary>
        /// Returns true if DataUptierJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DataUptierJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataUptierJobParameters input)
        {
            if (input == null)
                return false;

            return 
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
                    this.HotFileWindow == input.HotFileWindow ||
                    (this.HotFileWindow != null &&
                    this.HotFileWindow.Equals(input.HotFileWindow))
                ) && 
                (
                    this.IncludeAllFiles == input.IncludeAllFiles ||
                    (this.IncludeAllFiles != null &&
                    this.IncludeAllFiles.Equals(input.IncludeAllFiles))
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.NumFileAccess == input.NumFileAccess ||
                    (this.NumFileAccess != null &&
                    this.NumFileAccess.Equals(input.NumFileAccess))
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
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
                hashCode = hashCode * 59 + this.FileSelectionPolicy.GetHashCode();
                if (this.FileSizeBytes != null)
                    hashCode = hashCode * 59 + this.FileSizeBytes.GetHashCode();
                hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.HotFileWindow != null)
                    hashCode = hashCode * 59 + this.HotFileWindow.GetHashCode();
                if (this.IncludeAllFiles != null)
                    hashCode = hashCode * 59 + this.IncludeAllFiles.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.NumFileAccess != null)
                    hashCode = hashCode * 59 + this.NumFileAccess.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

