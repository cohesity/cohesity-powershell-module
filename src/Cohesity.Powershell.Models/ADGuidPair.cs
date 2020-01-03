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
    /// ADGuidPair
    /// </summary>
    [DataContract]
    public partial class ADGuidPair :  IEquatable<ADGuidPair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADGuidPair" /> class.
        /// </summary>
        /// <param name="destination">Destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid..</param>
        /// <param name="source">Source guid string of an AD object in mounted AD snapshot. This cannot be empty..</param>
        public ADGuidPair(string destination = default(string), string source = default(string))
        {
            this.Destination = destination;
            this.Source = source;
            this.Destination = destination;
            this.Source = source;
        }
        
        /// <summary>
        /// Destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid.
        /// </summary>
        /// <value>Destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid.</value>
        [DataMember(Name="destination", EmitDefaultValue=true)]
        public string Destination { get; set; }

        /// <summary>
        /// Source guid string of an AD object in mounted AD snapshot. This cannot be empty.
        /// </summary>
        /// <value>Source guid string of an AD object in mounted AD snapshot. This cannot be empty.</value>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }

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
            return this.Equals(input as ADGuidPair);
        }

        /// <summary>
        /// Returns true if ADGuidPair instances are equal
        /// </summary>
        /// <param name="input">Instance of ADGuidPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADGuidPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }

    }

}

