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
    /// Specifies the protection information of Views on on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class ViewProtectionInfo :  IEquatable<ViewProtectionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProtectionInfo" /> class.
        /// </summary>
        /// <param name="stats">stats.</param>
        /// <param name="view">view.</param>
        public ViewProtectionInfo(ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster3 stats = default(ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster3), View1 view = default(View1))
        {
            this.Stats = stats;
            this.View = view;
        }
        
        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster3 Stats { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public View1 View { get; set; }

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
            return this.Equals(input as ViewProtectionInfo);
        }

        /// <summary>
        /// Returns true if ViewProtectionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProtectionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProtectionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.View == input.View ||
                    (this.View != null &&
                    this.View.Equals(input.View))
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
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.View != null)
                    hashCode = hashCode * 59 + this.View.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

