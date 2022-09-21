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
    /// Specifies the list statistics for each View for a given timestamp.
    /// </summary>
    [DataContract]
    public partial class ViewStatsSnapshot :  IEquatable<ViewStatsSnapshot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStatsSnapshot" /> class.
        /// </summary>
        /// <param name="timestamp">Specifies the unix time in milliseconds when these values were generated.</param>
        /// <param name="viewStatsList">Specifies the list of Views and their statistics at the given timestamp..</param>
        public ViewStatsSnapshot(long? timestamp = default(long?), List<ViewStatInfo> viewStatsList = default(List<ViewStatInfo>))
        {
            this.Timestamp = timestamp;
            this.Timestamp = timestamp;
            this.ViewStatsList = viewStatsList;
        }
        
        /// <summary>
        /// Specifies the unix time in milliseconds when these values were generated
        /// </summary>
        /// <value>Specifies the unix time in milliseconds when these values were generated</value>
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Specifies the list of Views and their statistics at the given timestamp.
        /// </summary>
        /// <value>Specifies the list of Views and their statistics at the given timestamp.</value>
        [DataMember(Name="viewStatsList", EmitDefaultValue=false)]
        public List<ViewStatInfo> ViewStatsList { get; set; }

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
            return this.Equals(input as ViewStatsSnapshot);
        }

        /// <summary>
        /// Returns true if ViewStatsSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStatsSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStatsSnapshot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ViewStatsList == input.ViewStatsList ||
                    this.ViewStatsList != null &&
                    input.ViewStatsList != null &&
                    this.ViewStatsList.Equals(input.ViewStatsList)
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.ViewStatsList != null)
                    hashCode = hashCode * 59 + this.ViewStatsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

