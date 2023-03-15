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
    /// If mapper is going to run over files on SnapFS, this selects the input files.
    /// </summary>
    [DataContract]
    public partial class InputSpecInputFilesSelector :  IEquatable<InputSpecInputFilesSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSpecInputFilesSelector" /> class.
        /// </summary>
        /// <param name="fileTimeFilter">fileTimeFilter.</param>
        /// <param name="filenameGlob">Glob patterns to match on file. e.g. {*.txt, *.cc}.</param>
        /// <param name="jobIds">jobIds.</param>
        /// <param name="maxSnapshotTimestamp">Exclusive end of snapshot_timestamp range. If missing, inf will be used as the timestamp range..</param>
        /// <param name="minSnapshotTimestamp">Inclusive. If missing, 0 will the default lower end of timestamp range.</param>
        /// <param name="partitionIds">partitionIds.</param>
        /// <param name="processLatestOnly">Boolean flag to indicate if only latest snapshot of each object should be processed..</param>
        /// <param name="rootDir">Within each volume, traversal will be rooted at this directory. A typical value here might be /home.</param>
        /// <param name="viewBoxIds">viewBoxIds.</param>
        /// <param name="viewName">This is the view name user enters manually. If this is set we will process this view only. partition_id and view_box_id will be populated only if view_name is present..</param>
        public InputSpecInputFilesSelector(InputSpecFileTimeFilter fileTimeFilter = default(InputSpecFileTimeFilter), List<string> filenameGlob = default(List<string>), List<long> jobIds = default(List<long>), long? maxSnapshotTimestamp = default(long?), long? minSnapshotTimestamp = default(long?), List<long> partitionIds = default(List<long>), bool? processLatestOnly = default(bool?), string rootDir = default(string), List<long> viewBoxIds = default(List<long>), string viewName = default(string))
        {
            this.FilenameGlob = filenameGlob;
            this.JobIds = jobIds;
            this.MaxSnapshotTimestamp = maxSnapshotTimestamp;
            this.MinSnapshotTimestamp = minSnapshotTimestamp;
            this.PartitionIds = partitionIds;
            this.ProcessLatestOnly = processLatestOnly;
            this.RootDir = rootDir;
            this.ViewBoxIds = viewBoxIds;
            this.ViewName = viewName;
            this.FileTimeFilter = fileTimeFilter;
            this.FilenameGlob = filenameGlob;
            this.JobIds = jobIds;
            this.MaxSnapshotTimestamp = maxSnapshotTimestamp;
            this.MinSnapshotTimestamp = minSnapshotTimestamp;
            this.PartitionIds = partitionIds;
            this.ProcessLatestOnly = processLatestOnly;
            this.RootDir = rootDir;
            this.ViewBoxIds = viewBoxIds;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Gets or Sets FileTimeFilter
        /// </summary>
        [DataMember(Name="fileTimeFilter", EmitDefaultValue=false)]
        public InputSpecFileTimeFilter FileTimeFilter { get; set; }

        /// <summary>
        /// Glob patterns to match on file. e.g. {*.txt, *.cc}
        /// </summary>
        /// <value>Glob patterns to match on file. e.g. {*.txt, *.cc}</value>
        [DataMember(Name="filenameGlob", EmitDefaultValue=true)]
        public List<string> FilenameGlob { get; set; }

        /// <summary>
        /// Gets or Sets JobIds
        /// </summary>
        [DataMember(Name="jobIds", EmitDefaultValue=true)]
        public List<long> JobIds { get; set; }

        /// <summary>
        /// Exclusive end of snapshot_timestamp range. If missing, inf will be used as the timestamp range.
        /// </summary>
        /// <value>Exclusive end of snapshot_timestamp range. If missing, inf will be used as the timestamp range.</value>
        [DataMember(Name="maxSnapshotTimestamp", EmitDefaultValue=true)]
        public long? MaxSnapshotTimestamp { get; set; }

        /// <summary>
        /// Inclusive. If missing, 0 will the default lower end of timestamp range
        /// </summary>
        /// <value>Inclusive. If missing, 0 will the default lower end of timestamp range</value>
        [DataMember(Name="minSnapshotTimestamp", EmitDefaultValue=true)]
        public long? MinSnapshotTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets PartitionIds
        /// </summary>
        [DataMember(Name="partitionIds", EmitDefaultValue=true)]
        public List<long> PartitionIds { get; set; }

        /// <summary>
        /// Boolean flag to indicate if only latest snapshot of each object should be processed.
        /// </summary>
        /// <value>Boolean flag to indicate if only latest snapshot of each object should be processed.</value>
        [DataMember(Name="processLatestOnly", EmitDefaultValue=true)]
        public bool? ProcessLatestOnly { get; set; }

        /// <summary>
        /// Within each volume, traversal will be rooted at this directory. A typical value here might be /home
        /// </summary>
        /// <value>Within each volume, traversal will be rooted at this directory. A typical value here might be /home</value>
        [DataMember(Name="rootDir", EmitDefaultValue=true)]
        public string RootDir { get; set; }

        /// <summary>
        /// Gets or Sets ViewBoxIds
        /// </summary>
        [DataMember(Name="viewBoxIds", EmitDefaultValue=true)]
        public List<long> ViewBoxIds { get; set; }

        /// <summary>
        /// This is the view name user enters manually. If this is set we will process this view only. partition_id and view_box_id will be populated only if view_name is present.
        /// </summary>
        /// <value>This is the view name user enters manually. If this is set we will process this view only. partition_id and view_box_id will be populated only if view_name is present.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
                    input.FilenameGlob != null &&
                    this.FilenameGlob.SequenceEqual(input.FilenameGlob)
                ) && 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
                ) && 
                (
                    this.MaxSnapshotTimestamp == input.MaxSnapshotTimestamp ||
                    (this.MaxSnapshotTimestamp != null &&
                    this.MaxSnapshotTimestamp.Equals(input.MaxSnapshotTimestamp))
                ) && 
                (
                    this.MinSnapshotTimestamp == input.MinSnapshotTimestamp ||
                    (this.MinSnapshotTimestamp != null &&
                    this.MinSnapshotTimestamp.Equals(input.MinSnapshotTimestamp))
                ) && 
                (
                    this.PartitionIds == input.PartitionIds ||
                    this.PartitionIds != null &&
                    input.PartitionIds != null &&
                    this.PartitionIds.SequenceEqual(input.PartitionIds)
                ) && 
                (
                    this.ProcessLatestOnly == input.ProcessLatestOnly ||
                    (this.ProcessLatestOnly != null &&
                    this.ProcessLatestOnly.Equals(input.ProcessLatestOnly))
                ) && 
                (
                    this.RootDir == input.RootDir ||
                    (this.RootDir != null &&
                    this.RootDir.Equals(input.RootDir))
                ) && 
                (
                    this.ViewBoxIds == input.ViewBoxIds ||
                    this.ViewBoxIds != null &&
                    input.ViewBoxIds != null &&
                    this.ViewBoxIds.SequenceEqual(input.ViewBoxIds)
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
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.MaxSnapshotTimestamp != null)
                    hashCode = hashCode * 59 + this.MaxSnapshotTimestamp.GetHashCode();
                if (this.MinSnapshotTimestamp != null)
                    hashCode = hashCode * 59 + this.MinSnapshotTimestamp.GetHashCode();
                if (this.PartitionIds != null)
                    hashCode = hashCode * 59 + this.PartitionIds.GetHashCode();
                if (this.ProcessLatestOnly != null)
                    hashCode = hashCode * 59 + this.ProcessLatestOnly.GetHashCode();
                if (this.RootDir != null)
                    hashCode = hashCode * 59 + this.RootDir.GetHashCode();
                if (this.ViewBoxIds != null)
                    hashCode = hashCode * 59 + this.ViewBoxIds.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

