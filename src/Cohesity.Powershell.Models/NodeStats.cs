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
    /// NodeStats
    /// </summary>
    [DataContract]
    public partial class NodeStats :  IEquatable<NodeStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStats" /> class.
        /// </summary>
        /// <param name="id">Id is the Id of the Node..</param>
        /// <param name="usagePerfStats">UsagePerfStats provides the usage and performance stats for the node..</param>
        public NodeStats(long? id = default(long?), UsageAndPerformanceStats usagePerfStats = default(UsageAndPerformanceStats))
        {
            this.Id = id;
            this.UsagePerfStats = usagePerfStats;
        }
        
        /// <summary>
        /// Id is the Id of the Node.
        /// </summary>
        /// <value>Id is the Id of the Node.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// UsagePerfStats provides the usage and performance stats for the node.
        /// </summary>
        /// <value>UsagePerfStats provides the usage and performance stats for the node.</value>
        [DataMember(Name="usagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats UsagePerfStats { get; set; }

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
            return this.Equals(input as NodeStats);
        }

        /// <summary>
        /// Returns true if NodeStats instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UsagePerfStats == input.UsagePerfStats ||
                    (this.UsagePerfStats != null &&
                    this.UsagePerfStats.Equals(input.UsagePerfStats))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UsagePerfStats != null)
                    hashCode = hashCode * 59 + this.UsagePerfStats.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

