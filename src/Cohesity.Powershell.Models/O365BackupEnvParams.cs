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
    /// O365BackupEnvParams
    /// </summary>
    [DataContract]
    public partial class O365BackupEnvParams :  IEquatable<O365BackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365BackupEnvParams" /> class.
        /// </summary>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        public O365BackupEnvParams(FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto))
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
            return this.Equals(input as O365BackupEnvParams);
        }

        /// <summary>
        /// Returns true if O365BackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365BackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365BackupEnvParams input)
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

