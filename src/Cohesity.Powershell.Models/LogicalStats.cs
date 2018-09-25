// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Provides logical statistics for logical entities such as Clusters and Domains (View Boxes). The logical size is the size of the data when it is fully hydrated or expanded. The actual physical data stored on the Cohesity Cluster is reduced by change-block tracking, compression and deduplication.
    /// </summary>
    [DataContract]
    public partial class LogicalStats :  IEquatable<LogicalStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalStats" /> class.
        /// </summary>
        /// <param name="totalLogicalUsageBytes">Provides the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication..</param>
        public LogicalStats(long? totalLogicalUsageBytes = default(long?))
        {
            this.TotalLogicalUsageBytes = totalLogicalUsageBytes;
        }
        
        /// <summary>
        /// Provides the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Provides the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalLogicalUsageBytes", EmitDefaultValue=false)]
        public long? TotalLogicalUsageBytes { get; set; }

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
            return this.Equals(input as LogicalStats);
        }

        /// <summary>
        /// Returns true if LogicalStats instances are equal
        /// </summary>
        /// <param name="input">Instance of LogicalStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogicalStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalLogicalUsageBytes == input.TotalLogicalUsageBytes ||
                    (this.TotalLogicalUsageBytes != null &&
                    this.TotalLogicalUsageBytes.Equals(input.TotalLogicalUsageBytes))
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
                if (this.TotalLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalUsageBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

