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
    /// ThrottlingPolicyDatastoreStreamsConfig
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyDatastoreStreamsConfig :  IEquatable<ThrottlingPolicyDatastoreStreamsConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyDatastoreStreamsConfig" /> class.
        /// </summary>
        /// <param name="maxConcurrentStreams">If this value is &gt; 0 and the number of streams concurrently active on a datastore is equal to it, then any further requests to access the datastore would be denied until the number of active streams reduces..</param>
        public ThrottlingPolicyDatastoreStreamsConfig(int? maxConcurrentStreams = default(int?))
        {
            this.MaxConcurrentStreams = maxConcurrentStreams;
            this.MaxConcurrentStreams = maxConcurrentStreams;
        }
        
        /// <summary>
        /// If this value is &gt; 0 and the number of streams concurrently active on a datastore is equal to it, then any further requests to access the datastore would be denied until the number of active streams reduces.
        /// </summary>
        /// <value>If this value is &gt; 0 and the number of streams concurrently active on a datastore is equal to it, then any further requests to access the datastore would be denied until the number of active streams reduces.</value>
        [DataMember(Name="maxConcurrentStreams", EmitDefaultValue=true)]
        public int? MaxConcurrentStreams { get; set; }

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
            return this.Equals(input as ThrottlingPolicyDatastoreStreamsConfig);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyDatastoreStreamsConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyDatastoreStreamsConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyDatastoreStreamsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxConcurrentStreams == input.MaxConcurrentStreams ||
                    (this.MaxConcurrentStreams != null &&
                    this.MaxConcurrentStreams.Equals(input.MaxConcurrentStreams))
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
                if (this.MaxConcurrentStreams != null)
                    hashCode = hashCode * 59 + this.MaxConcurrentStreams.GetHashCode();
                return hashCode;
            }
        }

    }

}

