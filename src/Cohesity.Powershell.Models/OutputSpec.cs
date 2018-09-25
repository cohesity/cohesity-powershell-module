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
    /// OutputSpec
    /// </summary>
    [DataContract]
    public partial class OutputSpec :  IEquatable<OutputSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSpec" /> class.
        /// </summary>
        /// <param name="numReduceShards">Number of reduce shards..</param>
        /// <param name="outputDir">Name of output directory..</param>
        /// <param name="partitionId">Partition id where output will go..</param>
        /// <param name="reduceOutputPrefix">Prefix of the reduce output files. File names will be: ${reduce_output_prefix}-00000-of-00100 if num_reduce_shards&#x3D;100 This name can contain some path components. e.g. \&quot;awb_results/run1\&quot; is a valid value. output_dir is deprecated..</param>
        /// <param name="viewBoxId">Viewbox id where the output will go..</param>
        /// <param name="viewName">Name of the view where output will go. This will be filled up by yoda..</param>
        public OutputSpec(int? numReduceShards = default(int?), string outputDir = default(string), long? partitionId = default(long?), string reduceOutputPrefix = default(string), long? viewBoxId = default(long?), string viewName = default(string))
        {
            this.NumReduceShards = numReduceShards;
            this.OutputDir = outputDir;
            this.PartitionId = partitionId;
            this.ReduceOutputPrefix = reduceOutputPrefix;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Number of reduce shards.
        /// </summary>
        /// <value>Number of reduce shards.</value>
        [DataMember(Name="numReduceShards", EmitDefaultValue=false)]
        public int? NumReduceShards { get; set; }

        /// <summary>
        /// Name of output directory.
        /// </summary>
        /// <value>Name of output directory.</value>
        [DataMember(Name="outputDir", EmitDefaultValue=false)]
        public string OutputDir { get; set; }

        /// <summary>
        /// Partition id where output will go.
        /// </summary>
        /// <value>Partition id where output will go.</value>
        [DataMember(Name="partitionId", EmitDefaultValue=false)]
        public long? PartitionId { get; set; }

        /// <summary>
        /// Prefix of the reduce output files. File names will be: ${reduce_output_prefix}-00000-of-00100 if num_reduce_shards&#x3D;100 This name can contain some path components. e.g. \&quot;awb_results/run1\&quot; is a valid value. output_dir is deprecated.
        /// </summary>
        /// <value>Prefix of the reduce output files. File names will be: ${reduce_output_prefix}-00000-of-00100 if num_reduce_shards&#x3D;100 This name can contain some path components. e.g. \&quot;awb_results/run1\&quot; is a valid value. output_dir is deprecated.</value>
        [DataMember(Name="reduceOutputPrefix", EmitDefaultValue=false)]
        public string ReduceOutputPrefix { get; set; }

        /// <summary>
        /// Viewbox id where the output will go.
        /// </summary>
        /// <value>Viewbox id where the output will go.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Name of the view where output will go. This will be filled up by yoda.
        /// </summary>
        /// <value>Name of the view where output will go. This will be filled up by yoda.</value>
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
            return this.Equals(input as OutputSpec);
        }

        /// <summary>
        /// Returns true if OutputSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumReduceShards == input.NumReduceShards ||
                    (this.NumReduceShards != null &&
                    this.NumReduceShards.Equals(input.NumReduceShards))
                ) && 
                (
                    this.OutputDir == input.OutputDir ||
                    (this.OutputDir != null &&
                    this.OutputDir.Equals(input.OutputDir))
                ) && 
                (
                    this.PartitionId == input.PartitionId ||
                    (this.PartitionId != null &&
                    this.PartitionId.Equals(input.PartitionId))
                ) && 
                (
                    this.ReduceOutputPrefix == input.ReduceOutputPrefix ||
                    (this.ReduceOutputPrefix != null &&
                    this.ReduceOutputPrefix.Equals(input.ReduceOutputPrefix))
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
                if (this.NumReduceShards != null)
                    hashCode = hashCode * 59 + this.NumReduceShards.GetHashCode();
                if (this.OutputDir != null)
                    hashCode = hashCode * 59 + this.OutputDir.GetHashCode();
                if (this.PartitionId != null)
                    hashCode = hashCode * 59 + this.PartitionId.GetHashCode();
                if (this.ReduceOutputPrefix != null)
                    hashCode = hashCode * 59 + this.ReduceOutputPrefix.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

