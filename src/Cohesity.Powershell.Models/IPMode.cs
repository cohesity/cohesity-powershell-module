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
    /// IPMode
    /// </summary>
    [DataContract]
    public partial class IPMode :  IEquatable<IPMode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPMode" /> class.
        /// </summary>
        /// <param name="ipFamilyPolicy">IP family policy in use..</param>
        /// <param name="preferredIpFamily">IP family preferred (in case of dual stack) or in use (for single stack)..</param>
        public IPMode(int? ipFamilyPolicy = default(int?), int? preferredIpFamily = default(int?))
        {
            this.IpFamilyPolicy = ipFamilyPolicy;
            this.PreferredIpFamily = preferredIpFamily;
            this.IpFamilyPolicy = ipFamilyPolicy;
            this.PreferredIpFamily = preferredIpFamily;
        }
        
        /// <summary>
        /// IP family policy in use.
        /// </summary>
        /// <value>IP family policy in use.</value>
        [DataMember(Name="ipFamilyPolicy", EmitDefaultValue=true)]
        public int? IpFamilyPolicy { get; set; }

        /// <summary>
        /// IP family preferred (in case of dual stack) or in use (for single stack).
        /// </summary>
        /// <value>IP family preferred (in case of dual stack) or in use (for single stack).</value>
        [DataMember(Name="preferredIpFamily", EmitDefaultValue=true)]
        public int? PreferredIpFamily { get; set; }

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
            return this.Equals(input as IPMode);
        }

        /// <summary>
        /// Returns true if IPMode instances are equal
        /// </summary>
        /// <param name="input">Instance of IPMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPMode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpFamilyPolicy == input.IpFamilyPolicy ||
                    (this.IpFamilyPolicy != null &&
                    this.IpFamilyPolicy.Equals(input.IpFamilyPolicy))
                ) && 
                (
                    this.PreferredIpFamily == input.PreferredIpFamily ||
                    (this.PreferredIpFamily != null &&
                    this.PreferredIpFamily.Equals(input.PreferredIpFamily))
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
                if (this.IpFamilyPolicy != null)
                    hashCode = hashCode * 59 + this.IpFamilyPolicy.GetHashCode();
                if (this.PreferredIpFamily != null)
                    hashCode = hashCode * 59 + this.PreferredIpFamily.GetHashCode();
                return hashCode;
            }
        }

    }

}

