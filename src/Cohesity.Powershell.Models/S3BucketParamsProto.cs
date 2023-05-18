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
    /// S3BucketParamsProto
    /// </summary>
    [DataContract]
    public partial class S3BucketParamsProto :  IEquatable<S3BucketParamsProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BucketParamsProto" /> class.
        /// </summary>
        /// <param name="filteringPolicies">The filtering policy to decide which objects within a source should be backed up. If this is not specified, then all of the objects within the source will be backed up..</param>
        public S3BucketParamsProto(List<FilteringPolicyProto> filteringPolicies = default(List<FilteringPolicyProto>))
        {
            this.FilteringPolicies = filteringPolicies;
            this.FilteringPolicies = filteringPolicies;
        }
        
        /// <summary>
        /// The filtering policy to decide which objects within a source should be backed up. If this is not specified, then all of the objects within the source will be backed up.
        /// </summary>
        /// <value>The filtering policy to decide which objects within a source should be backed up. If this is not specified, then all of the objects within the source will be backed up.</value>
        [DataMember(Name="filteringPolicies", EmitDefaultValue=true)]
        public List<FilteringPolicyProto> FilteringPolicies { get; set; }

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
            return this.Equals(input as S3BucketParamsProto);
        }

        /// <summary>
        /// Returns true if S3BucketParamsProto instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BucketParamsProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BucketParamsProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilteringPolicies == input.FilteringPolicies ||
                    this.FilteringPolicies != null &&
                    input.FilteringPolicies != null &&
                    this.FilteringPolicies.SequenceEqual(input.FilteringPolicies)
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
                if (this.FilteringPolicies != null)
                    hashCode = hashCode * 59 + this.FilteringPolicies.GetHashCode();
                return hashCode;
            }
        }

    }

}

