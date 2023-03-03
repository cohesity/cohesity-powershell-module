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
    /// Provides statistics about the View.
    /// </summary>
    [DataContract]
    public partial class ViewStats :  IEquatable<ViewStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStats" /> class.
        /// </summary>
        /// <param name="dataUsageStats">dataUsageStats.</param>
        /// <param name="id">Specifies the id of the View..</param>
        public ViewStats(DataUsageStats dataUsageStats = default(DataUsageStats), long? id = default(long?))
        {
            this.Id = id;
            this.DataUsageStats = dataUsageStats;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets DataUsageStats
        /// </summary>
        [DataMember(Name="dataUsageStats", EmitDefaultValue=false)]
        public DataUsageStats DataUsageStats { get; set; }

        /// <summary>
        /// Specifies the id of the View.
        /// </summary>
        /// <value>Specifies the id of the View.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

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
            return this.Equals(input as ViewStats);
        }

        /// <summary>
        /// Returns true if ViewStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataUsageStats == input.DataUsageStats ||
                    (this.DataUsageStats != null &&
                    this.DataUsageStats.Equals(input.DataUsageStats))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.DataUsageStats != null)
                    hashCode = hashCode * 59 + this.DataUsageStats.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}

