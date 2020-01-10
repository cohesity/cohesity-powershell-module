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
    /// NetworkParams
    /// </summary>
    [DataContract]
    public partial class NetworkParams :  IEquatable<NetworkParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkParams" /> class.
        /// </summary>
        /// <param name="bondingOpts">bondingOpts.</param>
        /// <param name="mtu">mtu.</param>
        public NetworkParams(BondingOpts bondingOpts = default(BondingOpts), int? mtu = default(int?))
        {
            this.Mtu = mtu;
            this.BondingOpts = bondingOpts;
            this.Mtu = mtu;
        }
        
        /// <summary>
        /// Gets or Sets BondingOpts
        /// </summary>
        [DataMember(Name="bondingOpts", EmitDefaultValue=false)]
        public BondingOpts BondingOpts { get; set; }

        /// <summary>
        /// Gets or Sets Mtu
        /// </summary>
        [DataMember(Name="mtu", EmitDefaultValue=true)]
        public int? Mtu { get; set; }

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
            return this.Equals(input as NetworkParams);
        }

        /// <summary>
        /// Returns true if NetworkParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BondingOpts == input.BondingOpts ||
                    (this.BondingOpts != null &&
                    this.BondingOpts.Equals(input.BondingOpts))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
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
                if (this.BondingOpts != null)
                    hashCode = hashCode * 59 + this.BondingOpts.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                return hashCode;
            }
        }

    }

}

