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
    /// InputSpecInputVMsSelector
    /// </summary>
    [DataContract]
    public partial class InputSpecInputVMsSelector :  IEquatable<InputSpecInputVMsSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSpecInputVMsSelector" /> class.
        /// </summary>
        /// <param name="fileTimeFilter">fileTimeFilter.</param>
        /// <param name="filenameGlob">After VMDKs are selected as above, the files within them can be selected by using these predicates..</param>
        /// <param name="jobIds">jobIds.</param>
        /// <param name="maxSnapshotTimestamp">Exclusive end of snapshot_timestamp range. If missing, inf will be used as the timestamp range..</param>
        /// <param name="minSnapshotTimestamp">Inclusive. If missing, 0 will the default lower end of timestamp range.</param>
        /// <param name="partitionIds">Filters are AND of ORs..</param>
        /// <param name="processLatestOnly">Boolean flag to indicate if only latest snapshot of each object should be processed..</param>
        /// <param name="rootDir">Within each volume, traversal will be rooted at this directory. A typical value here might be /home.</param>
        /// <param name="sourceEntityIds">sourceEntityIds.</param>
        /// <param name="viewBoxIds">viewBoxIds.</param>
        /// <param name="viewNames">viewNames.</param>
        public InputSpecInputVMsSelector(InputSpecFileTimeFilter fileTimeFilter = default(InputSpecFileTimeFilter), List<string> filenameGlob = default(List<string>), List<long> jobIds = default(List<long>), long? maxSnapshotTimestamp = default(long?), long? minSnapshotTimestamp = default(long?), List<long> partitionIds = default(List<long>), bool? processLatestOnly = default(bool?), string rootDir = default(string), List<long> sourceEntityIds = default(List<long>), List<long> viewBoxIds = default(List<long>), List<string> viewNames = default(List<string>))
        {
            this.FilenameGlob = filenameGlob;
            this.JobIds = jobIds;
            this.MaxSnapshotTimestamp = maxSnapshotTimestamp;
            this.MinSnapshotTimestamp = minSnapshotTimestamp;
            this.PartitionIds = partitionIds;
            this.ProcessLatestOnly = processLatestOnly;
            this.RootDir = rootDir;
            this.SourceEntityIds = sourceEntityIds;
            this.ViewBoxIds = viewBoxIds;
            this.ViewNames = viewNames;
            this.FileTimeFilter = fileTimeFilter;
            this.FilenameGlob = filenameGlob;
            this.JobIds = jobIds;
            this.MaxSnapshotTimestamp = maxSnapshotTimestamp;
            this.MinSnapshotTimestamp = minSnapshotTimestamp;
            this.PartitionIds = partitionIds;
            this.ProcessLatestOnly = processLatestOnly;
            this.RootDir = rootDir;
            this.SourceEntityIds = sourceEntityIds;
            this.ViewBoxIds = viewBoxIds;
            this.ViewNames = viewNames;
        }
        
        /// <summary>
        /// Gets or Sets FileTimeFilter
        /// </summary>
        [DataMember(Name="fileTimeFilter", EmitDefaultValue=false)]
        public InputSpecFileTimeFilter FileTimeFilter { get; set; }

        /// <summary>
        /// After VMDKs are selected as above, the files within them can be selected by using these predicates.
        /// </summary>
        /// <value>After VMDKs are selected as above, the files within them can be selected by using these predicates.</value>
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
        /// Filters are AND of ORs.
        /// </summary>
        /// <value>Filters are AND of ORs.</value>
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
        /// Gets or Sets SourceEntityIds
        /// </summary>
        [DataMember(Name="sourceEntityIds", EmitDefaultValue=true)]
        public List<long> SourceEntityIds { get; set; }

        /// <summary>
        /// Gets or Sets ViewBoxIds
        /// </summary>
        [DataMember(Name="viewBoxIds", EmitDefaultValue=true)]
        public List<long> ViewBoxIds { get; set; }

        /// <summary>
        /// Gets or Sets ViewNames
        /// </summary>
        [DataMember(Name="viewNames", EmitDefaultValue=true)]
        public List<string> ViewNames { get; set; }

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
            return this.Equals(input as InputSpecInputVMsSelector);
        }

        /// <summary>
        /// Returns true if InputSpecInputVMsSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of InputSpecInputVMsSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSpecInputVMsSelector input)
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
                    this.FilenameGlob.Equals(input.FilenameGlob)
                ) && 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.Equals(input.JobIds)
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
                    this.PartitionIds.Equals(input.PartitionIds)
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
                    this.SourceEntityIds == input.SourceEntityIds ||
                    this.SourceEntityIds != null &&
                    input.SourceEntityIds != null &&
                    this.SourceEntityIds.Equals(input.SourceEntityIds)
                ) && 
                (
                    this.ViewBoxIds == input.ViewBoxIds ||
                    this.ViewBoxIds != null &&
                    input.ViewBoxIds != null &&
                    this.ViewBoxIds.Equals(input.ViewBoxIds)
                ) && 
                (
                    this.ViewNames == input.ViewNames ||
                    this.ViewNames != null &&
                    input.ViewNames != null &&
                    this.ViewNames.Equals(input.ViewNames)
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
                if (this.SourceEntityIds != null)
                    hashCode = hashCode * 59 + this.SourceEntityIds.GetHashCode();
                if (this.ViewBoxIds != null)
                    hashCode = hashCode * 59 + this.ViewBoxIds.GetHashCode();
                if (this.ViewNames != null)
                    hashCode = hashCode * 59 + this.ViewNames.GetHashCode();
                return hashCode;
            }
        }

    }

}

