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
    /// S3BucketConfigProtoPrefixToChildBucketMapEntry
    /// </summary>
    [DataContract]
    public partial class S3BucketConfigProtoPrefixToChildBucketMapEntry :  IEquatable<S3BucketConfigProtoPrefixToChildBucketMapEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BucketConfigProtoPrefixToChildBucketMapEntry" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public S3BucketConfigProtoPrefixToChildBucketMapEntry(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

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
            return this.Equals(input as S3BucketConfigProtoPrefixToChildBucketMapEntry);
        }

        /// <summary>
        /// Returns true if S3BucketConfigProtoPrefixToChildBucketMapEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BucketConfigProtoPrefixToChildBucketMapEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BucketConfigProtoPrefixToChildBucketMapEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

