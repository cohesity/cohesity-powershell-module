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
        /// <param name="fileSelectPolicy">File migrate policy based on file access/modify time and age..</param>
        /// <param name="fileSize">Gives the size criteria to be used for selecting the files to be migrated. The cold files that are equal and greater than file_size or smaller than file_size are migrated..</param>
        /// <param name="fileSizePolicy">File size policy for selecting files to migrate..</param>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="nfsMountPath">Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data..</param>
        /// <param name="targetViewName">The target view name to which the data will be migrated..</param>
        public FileStubbingParams(long? coldFileWindow = default(long?), int? fileSelectPolicy = default(int?), long? fileSize = default(long?), int? fileSizePolicy = default(int?), FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), string nfsMountPath = default(string), string targetViewName = default(string))
        {
            this.ColdFileWindow = coldFileWindow;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
            this.ColdFileWindow = coldFileWindow;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.FilteringPolicy = filteringPolicy;
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
        }
        
        /// <summary>
        /// Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window msecs or are older than cold_window_msecs are migrated.
        /// </summary>
        /// <value>Identifies the cold files in the NAS source. Files that haven&#39;t been accessed/modified in the last cold_file_window msecs or are older than cold_window_msecs are migrated.</value>
        [DataMember(Name="coldFileWindow", EmitDefaultValue=true)]
        public long? ColdFileWindow { get; set; }

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
        /// Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.
        /// </summary>
        /// <value>Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.</value>
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
                if (this.FileSelectPolicy != null)
                    hashCode = hashCode * 59 + this.FileSelectPolicy.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileSizePolicy != null)
                    hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

