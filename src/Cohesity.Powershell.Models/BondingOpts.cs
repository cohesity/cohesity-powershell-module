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
    /// Bonding Opts
    /// </summary>
    [DataContract]
    public partial class BondingOpts :  IEquatable<BondingOpts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BondingOpts" /> class.
        /// </summary>
        /// <param name="lacpRate">lacpRate.</param>
        /// <param name="mode">mode.</param>
        /// <param name="xmitHashPolicy">xmitHashPolicy.</param>
        public BondingOpts(string lacpRate = default(string), string mode = default(string), string xmitHashPolicy = default(string))
        {
            this.LacpRate = lacpRate;
            this.Mode = mode;
            this.XmitHashPolicy = xmitHashPolicy;
            this.LacpRate = lacpRate;
            this.Mode = mode;
            this.XmitHashPolicy = xmitHashPolicy;
        }
        
        /// <summary>
        /// Gets or Sets LacpRate
        /// </summary>
        [DataMember(Name="lacpRate", EmitDefaultValue=true)]
        public string LacpRate { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets XmitHashPolicy
        /// </summary>
        [DataMember(Name="xmitHashPolicy", EmitDefaultValue=true)]
        public string XmitHashPolicy { get; set; }

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
            return this.Equals(input as BondingOpts);
        }

        /// <summary>
        /// Returns true if BondingOpts instances are equal
        /// </summary>
        /// <param name="input">Instance of BondingOpts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondingOpts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LacpRate == input.LacpRate ||
                    (this.LacpRate != null &&
                    this.LacpRate.Equals(input.LacpRate))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.XmitHashPolicy == input.XmitHashPolicy ||
                    (this.XmitHashPolicy != null &&
                    this.XmitHashPolicy.Equals(input.XmitHashPolicy))
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
                if (this.LacpRate != null)
                    hashCode = hashCode * 59 + this.LacpRate.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.XmitHashPolicy != null)
                    hashCode = hashCode * 59 + this.XmitHashPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}

