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
    /// Describes a set of files rooted under a path that need to be backed up.
    /// </summary>
    [DataContract]
    public partial class PhysicalFileBackupParamsBackupPathInfo :  IEquatable<PhysicalFileBackupParamsBackupPathInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalFileBackupParamsBackupPathInfo" /> class.
        /// </summary>
        /// <param name="excludePaths">A list of absolute paths on the Physical source that should not be backed up. Any path that is a descendant of these paths will also be skipped..</param>
        /// <param name="includePath">An absolute path on the Physical source that should be backed up. Any path that is a descendant of this path will also be backed up, unless (a) it is excluded from backup by exclude_paths below, OR (b) it belongs to a volume that is different from the volume include_path belongs to and there are no relevant paths in that volume being backed up..</param>
        /// <param name="skipNestedVolumes">Whether to skip any nested volumes (both local and network) that are mounted under &#39;include_path&#39;. Note that if a path to a nested volume is specified as an include_path in another BackupPathInfo entry, that path will still get backed up..</param>
        public PhysicalFileBackupParamsBackupPathInfo(List<string> excludePaths = default(List<string>), string includePath = default(string), bool? skipNestedVolumes = default(bool?))
        {
            this.ExcludePaths = excludePaths;
            this.IncludePath = includePath;
            this.SkipNestedVolumes = skipNestedVolumes;
            this.ExcludePaths = excludePaths;
            this.IncludePath = includePath;
            this.SkipNestedVolumes = skipNestedVolumes;
        }
        
        /// <summary>
        /// A list of absolute paths on the Physical source that should not be backed up. Any path that is a descendant of these paths will also be skipped.
        /// </summary>
        /// <value>A list of absolute paths on the Physical source that should not be backed up. Any path that is a descendant of these paths will also be skipped.</value>
        [DataMember(Name="excludePaths", EmitDefaultValue=true)]
        public List<string> ExcludePaths { get; set; }

        /// <summary>
        /// An absolute path on the Physical source that should be backed up. Any path that is a descendant of this path will also be backed up, unless (a) it is excluded from backup by exclude_paths below, OR (b) it belongs to a volume that is different from the volume include_path belongs to and there are no relevant paths in that volume being backed up.
        /// </summary>
        /// <value>An absolute path on the Physical source that should be backed up. Any path that is a descendant of this path will also be backed up, unless (a) it is excluded from backup by exclude_paths below, OR (b) it belongs to a volume that is different from the volume include_path belongs to and there are no relevant paths in that volume being backed up.</value>
        [DataMember(Name="includePath", EmitDefaultValue=true)]
        public string IncludePath { get; set; }

        /// <summary>
        /// Whether to skip any nested volumes (both local and network) that are mounted under &#39;include_path&#39;. Note that if a path to a nested volume is specified as an include_path in another BackupPathInfo entry, that path will still get backed up.
        /// </summary>
        /// <value>Whether to skip any nested volumes (both local and network) that are mounted under &#39;include_path&#39;. Note that if a path to a nested volume is specified as an include_path in another BackupPathInfo entry, that path will still get backed up.</value>
        [DataMember(Name="skipNestedVolumes", EmitDefaultValue=true)]
        public bool? SkipNestedVolumes { get; set; }

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
            return this.Equals(input as PhysicalFileBackupParamsBackupPathInfo);
        }

        /// <summary>
        /// Returns true if PhysicalFileBackupParamsBackupPathInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalFileBackupParamsBackupPathInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalFileBackupParamsBackupPathInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludePaths == input.ExcludePaths ||
                    this.ExcludePaths != null &&
                    input.ExcludePaths != null &&
                    this.ExcludePaths.SequenceEqual(input.ExcludePaths)
                ) && 
                (
                    this.IncludePath == input.IncludePath ||
                    (this.IncludePath != null &&
                    this.IncludePath.Equals(input.IncludePath))
                ) && 
                (
                    this.SkipNestedVolumes == input.SkipNestedVolumes ||
                    (this.SkipNestedVolumes != null &&
                    this.SkipNestedVolumes.Equals(input.SkipNestedVolumes))
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
                if (this.ExcludePaths != null)
                    hashCode = hashCode * 59 + this.ExcludePaths.GetHashCode();
                if (this.IncludePath != null)
                    hashCode = hashCode * 59 + this.IncludePath.GetHashCode();
                if (this.SkipNestedVolumes != null)
                    hashCode = hashCode * 59 + this.SkipNestedVolumes.GetHashCode();
                return hashCode;
            }
        }

    }

}

