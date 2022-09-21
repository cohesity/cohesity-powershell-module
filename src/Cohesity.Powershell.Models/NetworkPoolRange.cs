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
    /// NetworkPoolRange
    /// </summary>
    [DataContract]
    public partial class NetworkPoolRange :  IEquatable<NetworkPoolRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPoolRange" /> class.
        /// </summary>
        /// <param name="high">Specifies the high range of the IP address..</param>
        /// <param name="low">Specifies the low range of the IP address..</param>
        public NetworkPoolRange(string high = default(string), string low = default(string))
        {
            this.High = high;
            this.Low = low;
            this.High = high;
            this.Low = low;
        }
        
        /// <summary>
        /// Specifies the high range of the IP address.
        /// </summary>
        /// <value>Specifies the high range of the IP address.</value>
        [DataMember(Name="high", EmitDefaultValue=true)]
        public string High { get; set; }

        /// <summary>
        /// Specifies the low range of the IP address.
        /// </summary>
        /// <value>Specifies the low range of the IP address.</value>
        [DataMember(Name="low", EmitDefaultValue=true)]
        public string Low { get; set; }

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
            return this.Equals(input as NetworkPoolRange);
        }

        /// <summary>
        /// Returns true if NetworkPoolRange instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkPoolRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkPoolRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
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
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                return hashCode;
            }
        }

    }

}

