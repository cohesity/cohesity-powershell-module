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
    /// Specifies the list of IP addresses that are allowed or denied at the job level. Allowed IPs and Denied IPs cannot be used together.
    /// </summary>
    [DataContract]
    public partial class FilterIpConfig :  IEquatable<FilterIpConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterIpConfig" /> class.
        /// </summary>
        /// <param name="allowedIpAddresses">Specifies the IP addresses that should be used exclusively at the job level. Cannot be set if deniedIpAddresses is set..</param>
        /// <param name="deniedIpAddresses">Specifies the IP addresses that should not be used at the job level. Cannot be set if allowedIpAddresses is set..</param>
        public FilterIpConfig(List<string> allowedIpAddresses = default(List<string>), List<string> deniedIpAddresses = default(List<string>))
        {
            this.AllowedIpAddresses = allowedIpAddresses;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.DeniedIpAddresses = deniedIpAddresses;
        }
        
        /// <summary>
        /// Specifies the IP addresses that should be used exclusively at the job level. Cannot be set if deniedIpAddresses is set.
        /// </summary>
        /// <value>Specifies the IP addresses that should be used exclusively at the job level. Cannot be set if deniedIpAddresses is set.</value>
        [DataMember(Name="allowedIpAddresses", EmitDefaultValue=true)]
        public List<string> AllowedIpAddresses { get; set; }

        /// <summary>
        /// Specifies the IP addresses that should not be used at the job level. Cannot be set if allowedIpAddresses is set.
        /// </summary>
        /// <value>Specifies the IP addresses that should not be used at the job level. Cannot be set if allowedIpAddresses is set.</value>
        [DataMember(Name="deniedIpAddresses", EmitDefaultValue=true)]
        public List<string> DeniedIpAddresses { get; set; }

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
            return this.Equals(input as FilterIpConfig);
        }

        /// <summary>
        /// Returns true if FilterIpConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterIpConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterIpConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedIpAddresses == input.AllowedIpAddresses ||
                    this.AllowedIpAddresses != null &&
                    input.AllowedIpAddresses != null &&
                    this.AllowedIpAddresses.SequenceEqual(input.AllowedIpAddresses)
                ) && 
                (
                    this.DeniedIpAddresses == input.DeniedIpAddresses ||
                    this.DeniedIpAddresses != null &&
                    input.DeniedIpAddresses != null &&
                    this.DeniedIpAddresses.SequenceEqual(input.DeniedIpAddresses)
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
                if (this.AllowedIpAddresses != null)
                    hashCode = hashCode * 59 + this.AllowedIpAddresses.GetHashCode();
                if (this.DeniedIpAddresses != null)
                    hashCode = hashCode * 59 + this.DeniedIpAddresses.GetHashCode();
                return hashCode;
            }
        }

    }

}

