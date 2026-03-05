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
    /// Represents the count of folders associated with different roots during the backup process.
    /// </summary>
    [DataContract]
    public partial class SnapshotFolderCounts :  IEquatable<SnapshotFolderCounts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotFolderCounts" /> class.
        /// </summary>
        /// <param name="backedUpFolderCount">Total count of folders that are backed up for given root during backup..</param>
        /// <param name="folderRootType">The root folder of the current folder..</param>
        /// <param name="skippedFolderCount">Total count of folders that are skipped for given root during backup..</param>
        public SnapshotFolderCounts(long? backedUpFolderCount = default(long?), int? folderRootType = default(int?), long? skippedFolderCount = default(long?))
        {
            this.BackedUpFolderCount = backedUpFolderCount;
            this.FolderRootType = folderRootType;
            this.SkippedFolderCount = skippedFolderCount;
            this.BackedUpFolderCount = backedUpFolderCount;
            this.FolderRootType = folderRootType;
            this.SkippedFolderCount = skippedFolderCount;
        }
        
        /// <summary>
        /// Total count of folders that are backed up for given root during backup.
        /// </summary>
        /// <value>Total count of folders that are backed up for given root during backup.</value>
        [DataMember(Name="backedUpFolderCount", EmitDefaultValue=true)]
        public long? BackedUpFolderCount { get; set; }

        /// <summary>
        /// The root folder of the current folder.
        /// </summary>
        /// <value>The root folder of the current folder.</value>
        [DataMember(Name="folderRootType", EmitDefaultValue=true)]
        public int? FolderRootType { get; set; }

        /// <summary>
        /// Total count of folders that are skipped for given root during backup.
        /// </summary>
        /// <value>Total count of folders that are skipped for given root during backup.</value>
        [DataMember(Name="skippedFolderCount", EmitDefaultValue=true)]
        public long? SkippedFolderCount { get; set; }

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
            return this.Equals(input as SnapshotFolderCounts);
        }

        /// <summary>
        /// Returns true if SnapshotFolderCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotFolderCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotFolderCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackedUpFolderCount == input.BackedUpFolderCount ||
                    (this.BackedUpFolderCount != null &&
                    this.BackedUpFolderCount.Equals(input.BackedUpFolderCount))
                ) && 
                (
                    this.FolderRootType == input.FolderRootType ||
                    (this.FolderRootType != null &&
                    this.FolderRootType.Equals(input.FolderRootType))
                ) && 
                (
                    this.SkippedFolderCount == input.SkippedFolderCount ||
                    (this.SkippedFolderCount != null &&
                    this.SkippedFolderCount.Equals(input.SkippedFolderCount))
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
                if (this.BackedUpFolderCount != null)
                    hashCode = hashCode * 59 + this.BackedUpFolderCount.GetHashCode();
                if (this.FolderRootType != null)
                    hashCode = hashCode * 59 + this.FolderRootType.GetHashCode();
                if (this.SkippedFolderCount != null)
                    hashCode = hashCode * 59 + this.SkippedFolderCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

