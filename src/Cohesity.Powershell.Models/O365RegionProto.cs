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
    /// O365Region proto will store the information about the region from where o365 connector apis calls are made.
    /// </summary>
    [DataContract]
    public partial class O365RegionProto :  IEquatable<O365RegionProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365RegionProto" /> class.
        /// </summary>
        /// <param name="country">The country where the o365 connector apis were called from..</param>
        public O365RegionProto(int? country = default(int?))
        {
            this.Country = country;
        }
        
        /// <summary>
        /// The country where the o365 connector apis were called from.
        /// </summary>
        /// <value>The country where the o365 connector apis were called from.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public int? Country { get; set; }

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
            return this.Equals(input as O365RegionProto);
        }

        /// <summary>
        /// Returns true if O365RegionProto instances are equal
        /// </summary>
        /// <param name="input">Instance of O365RegionProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365RegionProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }

    }

}

