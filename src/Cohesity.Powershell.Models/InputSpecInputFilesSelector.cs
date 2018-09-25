// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// If mapper is going to run over files on SnapFS, this selects the input files.
    /// </summary>
    [DataContract]
    public partial class InputSpecInputFilesSelector :  IEquatable<InputSpecInputFilesSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSpecInputFilesSelector" /> class.
        /// </summary>
        /// <param name="fileTimeFilter">File time filter for file&#39;s last change time..</param>
        /// <param name="filenameGlob">Glob patterns to match on file. e.g. {*.txt, *.cc}.</param>
        /// <param name="partitionId">partitionId.</param>
        /// <param name="rootDir">Within each volume, traversal will be rooted at this directory. A typical value here might be /home.</param>
        /// <param name="viewBoxId">viewBoxId.</param>
        /// <param name="viewName">viewName.</param>
        public InputSpecInputFilesSelector(InputSpecFileTimeFilter fileTimeFilter = default(InputSpecFileTimeFilter), List<string> filenameGlob = default(List<string>), long? partitionId = default(long?), string rootDir = default(string), long? viewBoxId = default(long?), string viewName = default(string))
        {
            this.FileTimeFilter = fileTimeFilter;
            this.FilenameGlob = filenameGlob;
            this.PartitionId = partitionId;
            this.RootDir = rootDir;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// File time filter for file&#39;s last change time.
        /// </summary>
        /// <value>File time filter for file&#39;s last change time.</value>
        [DataMember(Name="fileTimeFilter", EmitDefaultValue=false)]
        public InputSpecFileTimeFilter FileTimeFilter { get; set; }

        /// <summary>
        /// Glob patterns to match on file. e.g. {*.txt, *.cc}
        /// </summary>
        /// <value>Glob patterns to match on file. e.g. {*.txt, *.cc}</value>
        [DataMember(Name="filenameGlob", EmitDefaultValue=false)]
        public List<string> FilenameGlob { get; set; }

        /// <summary>
        /// Gets or Sets PartitionId
        /// </summary>
        [DataMember(Name="partitionId", EmitDefaultValue=false)]
        public long? PartitionId { get; set; }

        /// <summary>
        /// Within each volume, traversal will be rooted at this directory. A typical value here might be /home
        /// </summary>
        /// <value>Within each volume, traversal will be rooted at this directory. A typical value here might be /home</value>
        [DataMember(Name="rootDir", EmitDefaultValue=false)]
        public string RootDir { get; set; }

        /// <summary>
        /// Gets or Sets ViewBoxId
        /// </summary>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Gets or Sets ViewName
        /// </summary>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as InputSpecInputFilesSelector);
        }

        /// <summary>
        /// Returns true if InputSpecInputFilesSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of InputSpecInputFilesSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSpecInputFilesSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileTimeFilter == input.FileTimeFilter ||
                    (this.FileTimeFilter != null &&
                    this.FileTimeFilter.Equals(input.FileTimeFilter))
                ) && 
                (
                    this.FilenameGlob == input.FilenameGlob ||
                    this.FilenameGlob != null &&
                    this.FilenameGlob.SequenceEqual(input.FilenameGlob)
                ) && 
                (
                    this.PartitionId == input.PartitionId ||
                    (this.PartitionId != null &&
                    this.PartitionId.Equals(input.PartitionId))
                ) && 
                (
                    this.RootDir == input.RootDir ||
                    (this.RootDir != null &&
                    this.RootDir.Equals(input.RootDir))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.FileTimeFilter != null)
                    hashCode = hashCode * 59 + this.FileTimeFilter.GetHashCode();
                if (this.FilenameGlob != null)
                    hashCode = hashCode * 59 + this.FilenameGlob.GetHashCode();
                if (this.PartitionId != null)
                    hashCode = hashCode * 59 + this.PartitionId.GetHashCode();
                if (this.RootDir != null)
                    hashCode = hashCode * 59 + this.RootDir.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

