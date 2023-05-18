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
    /// FileUptieringParams
    /// </summary>
    [DataContract]
    public partial class FileUptieringParams :  IEquatable<FileUptieringParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUptieringParams" /> class.
        /// </summary>
        /// <param name="enableAuditLogging">If enabled, audit log the files which are uptiered..</param>
        /// <param name="fileSelectPolicy">File uptier policy based on file access/modify time..</param>
        /// <param name="fileSize">Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered..</param>
        /// <param name="fileSizePolicy">File size policy for selecting files to uptier..</param>
        /// <param name="hotFileWindow">Identifies the hot files in the view. Files which are accessed num_file_access times in hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed and num_file_access is greater than 1..</param>
        /// <param name="nfsMountPath">Mount path where the Cohesity target view is mounted on NFS clients while migrating the data..</param>
        /// <param name="numFileAccess">Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed..</param>
        /// <param name="sourceViewMap">The object&#39;s entity id to SourceViewData map from which the data will be uptieried..</param>
        /// <param name="sourceViewName">The source view name from which the data will be uptiered..</param>
        /// <param name="uptierAllFiles">If set, all files in the view will be uptiered regardless of file_select_policy, num_file_access, hot_file_window, file_size constraints..</param>
        public FileUptieringParams(bool? enableAuditLogging = default(bool?), int? fileSelectPolicy = default(int?), long? fileSize = default(long?), int? fileSizePolicy = default(int?), long? hotFileWindow = default(long?), string nfsMountPath = default(string), int? numFileAccess = default(int?), List<FileUptieringParamsSourceViewMapEntry> sourceViewMap = default(List<FileUptieringParamsSourceViewMapEntry>), string sourceViewName = default(string), bool? uptierAllFiles = default(bool?))
        {
            this.EnableAuditLogging = enableAuditLogging;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.NfsMountPath = nfsMountPath;
            this.NumFileAccess = numFileAccess;
            this.SourceViewMap = sourceViewMap;
            this.SourceViewName = sourceViewName;
            this.UptierAllFiles = uptierAllFiles;
            this.EnableAuditLogging = enableAuditLogging;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.NfsMountPath = nfsMountPath;
            this.NumFileAccess = numFileAccess;
            this.SourceViewMap = sourceViewMap;
            this.SourceViewName = sourceViewName;
            this.UptierAllFiles = uptierAllFiles;
        }
        
        /// <summary>
        /// If enabled, audit log the files which are uptiered.
        /// </summary>
        /// <value>If enabled, audit log the files which are uptiered.</value>
        [DataMember(Name="enableAuditLogging", EmitDefaultValue=true)]
        public bool? EnableAuditLogging { get; set; }

        /// <summary>
        /// File uptier policy based on file access/modify time.
        /// </summary>
        /// <value>File uptier policy based on file access/modify time.</value>
        [DataMember(Name="fileSelectPolicy", EmitDefaultValue=true)]
        public int? FileSelectPolicy { get; set; }

        /// <summary>
        /// Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered.
        /// </summary>
        /// <value>Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered.</value>
        [DataMember(Name="fileSize", EmitDefaultValue=true)]
        public long? FileSize { get; set; }

        /// <summary>
        /// File size policy for selecting files to uptier.
        /// </summary>
        /// <value>File size policy for selecting files to uptier.</value>
        [DataMember(Name="fileSizePolicy", EmitDefaultValue=true)]
        public int? FileSizePolicy { get; set; }

        /// <summary>
        /// Identifies the hot files in the view. Files which are accessed num_file_access times in hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed and num_file_access is greater than 1.
        /// </summary>
        /// <value>Identifies the hot files in the view. Files which are accessed num_file_access times in hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed and num_file_access is greater than 1.</value>
        [DataMember(Name="hotFileWindow", EmitDefaultValue=true)]
        public long? HotFileWindow { get; set; }

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
        /// The object&#39;s entity id to SourceViewData map from which the data will be uptieried.
        /// </summary>
        /// <value>The object&#39;s entity id to SourceViewData map from which the data will be uptieried.</value>
        [DataMember(Name="sourceViewMap", EmitDefaultValue=true)]
        public List<FileUptieringParamsSourceViewMapEntry> SourceViewMap { get; set; }

        /// <summary>
        /// The source view name from which the data will be uptiered.
        /// </summary>
        /// <value>The source view name from which the data will be uptiered.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=true)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// If set, all files in the view will be uptiered regardless of file_select_policy, num_file_access, hot_file_window, file_size constraints.
        /// </summary>
        /// <value>If set, all files in the view will be uptiered regardless of file_select_policy, num_file_access, hot_file_window, file_size constraints.</value>
        [DataMember(Name="uptierAllFiles", EmitDefaultValue=true)]
        public bool? UptierAllFiles { get; set; }

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
            return this.Equals(input as FileUptieringParams);
        }

        /// <summary>
        /// Returns true if FileUptieringParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUptieringParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUptieringParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableAuditLogging == input.EnableAuditLogging ||
                    (this.EnableAuditLogging != null &&
                    this.EnableAuditLogging.Equals(input.EnableAuditLogging))
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
                    this.HotFileWindow == input.HotFileWindow ||
                    (this.HotFileWindow != null &&
                    this.HotFileWindow.Equals(input.HotFileWindow))
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
                    this.SourceViewMap == input.SourceViewMap ||
                    this.SourceViewMap != null &&
                    input.SourceViewMap != null &&
                    this.SourceViewMap.SequenceEqual(input.SourceViewMap)
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
                ) && 
                (
                    this.UptierAllFiles == input.UptierAllFiles ||
                    (this.UptierAllFiles != null &&
                    this.UptierAllFiles.Equals(input.UptierAllFiles))
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
                if (this.EnableAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableAuditLogging.GetHashCode();
                if (this.FileSelectPolicy != null)
                    hashCode = hashCode * 59 + this.FileSelectPolicy.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileSizePolicy != null)
                    hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.HotFileWindow != null)
                    hashCode = hashCode * 59 + this.HotFileWindow.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.NumFileAccess != null)
                    hashCode = hashCode * 59 + this.NumFileAccess.GetHashCode();
                if (this.SourceViewMap != null)
                    hashCode = hashCode * 59 + this.SourceViewMap.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                if (this.UptierAllFiles != null)
                    hashCode = hashCode * 59 + this.UptierAllFiles.GetHashCode();
                return hashCode;
            }
        }

    }

}

