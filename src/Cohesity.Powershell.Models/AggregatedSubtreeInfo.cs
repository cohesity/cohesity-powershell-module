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
    /// Aggregated information about a node subtree.
    /// </summary>
    [DataContract]
    public partial class AggregatedSubtreeInfo :  IEquatable<AggregatedSubtreeInfo>
    {
        
        /// <summary>
        /// Specifies the environment such as &#39;kSQL&#39; or &#39;kVMware&#39;, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kSQL&#39; or &#39;kVMware&#39;, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedSubtreeInfo" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment such as &#39;kSQL&#39; or &#39;kVMware&#39;, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="leavesCount">Specifies the number of leaf nodes under the subtree of this node..</param>
        /// <param name="totalLogicalSize">Specifies the total logical size of the data under the subtree of this node..</param>
        public AggregatedSubtreeInfo(EnvironmentEnum? environment = default(EnvironmentEnum?), long? leavesCount = default(long?), long? totalLogicalSize = default(long?))
        {
            this.Environment = environment;
            this.LeavesCount = leavesCount;
            this.TotalLogicalSize = totalLogicalSize;
        }
        

        /// <summary>
        /// Specifies the number of leaf nodes under the subtree of this node.
        /// </summary>
        /// <value>Specifies the number of leaf nodes under the subtree of this node.</value>
        [DataMember(Name="leavesCount", EmitDefaultValue=false)]
        public long? LeavesCount { get; set; }

        /// <summary>
        /// Specifies the total logical size of the data under the subtree of this node.
        /// </summary>
        /// <value>Specifies the total logical size of the data under the subtree of this node.</value>
        [DataMember(Name="totalLogicalSize", EmitDefaultValue=false)]
        public long? TotalLogicalSize { get; set; }

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
            return this.Equals(input as AggregatedSubtreeInfo);
        }

        /// <summary>
        /// Returns true if AggregatedSubtreeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregatedSubtreeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatedSubtreeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.LeavesCount == input.LeavesCount ||
                    (this.LeavesCount != null &&
                    this.LeavesCount.Equals(input.LeavesCount))
                ) && 
                (
                    this.TotalLogicalSize == input.TotalLogicalSize ||
                    (this.TotalLogicalSize != null &&
                    this.TotalLogicalSize.Equals(input.TotalLogicalSize))
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
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.LeavesCount != null)
                    hashCode = hashCode * 59 + this.LeavesCount.GetHashCode();
                if (this.TotalLogicalSize != null)
                    hashCode = hashCode * 59 + this.TotalLogicalSize.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

