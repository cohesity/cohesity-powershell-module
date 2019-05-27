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
    /// Message to capture any additional backup params for an Outlook environment.
    /// </summary>
    [DataContract]
    public partial class OutlookBackupEnvParams :  IEquatable<OutlookBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookBackupEnvParams" /> class.
        /// </summary>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        public OutlookBackupEnvParams(FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto))
        {
            this.FilteringPolicy = filteringPolicy;
        }
        
        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

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
            return this.Equals(input as OutlookBackupEnvParams);
        }

        /// <summary>
        /// Returns true if OutlookBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
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
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}

