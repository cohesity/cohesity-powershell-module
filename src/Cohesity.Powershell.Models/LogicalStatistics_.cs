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
    /// Specifies the total logical data size of all the local and Cloud Tier data stored by the Cohesity Cluster before the data is reduced by change-block tracking, compression and deduplication. The size of the data if the data is fully hydrated or expanded.
    /// </summary>
    [DataContract]
    public partial class LogicalStatistics_ :  IEquatable<LogicalStatistics_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalStatistics_" /> class.
        /// </summary>
        /// <param name="totalLogicalUsageBytes">Provides the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication..</param>
        public LogicalStatistics_(long? totalLogicalUsageBytes = default(long?))
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
            return this.Equals(input as LogicalStatistics_);
        }

        /// <summary>
        /// Returns true if LogicalStatistics_ instances are equal
        /// </summary>
        /// <param name="input">Instance of LogicalStatistics_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogicalStatistics_ input)
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

