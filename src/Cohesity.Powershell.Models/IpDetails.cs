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
    /// Entity Type      |  IP Address Details             | Details field  kHostSystem      |  VMKernel Adapter IP Addresses  | VMKernelAdapter  TODO(Matthew) : Use an enum for the &#39;Details&#39;.
    /// </summary>
    [DataContract]
    public partial class IpDetails :  IEquatable<IpDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpDetails" /> class.
        /// </summary>
        /// <param name="details">Details of the IP Addresses captured below.</param>
        /// <param name="ipAddresses">The IP Addresses.</param>
        public IpDetails(string details = default(string), List<string> ipAddresses = default(List<string>))
        {
            this.Details = details;
            this.IpAddresses = ipAddresses;
            this.Details = details;
            this.IpAddresses = ipAddresses;
        }
        
        /// <summary>
        /// Details of the IP Addresses captured below
        /// </summary>
        /// <value>Details of the IP Addresses captured below</value>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public string Details { get; set; }

        /// <summary>
        /// The IP Addresses
        /// </summary>
        /// <value>The IP Addresses</value>
        [DataMember(Name="ipAddresses", EmitDefaultValue=true)]
        public List<string> IpAddresses { get; set; }

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
            return this.Equals(input as IpDetails);
        }

        /// <summary>
        /// Returns true if IpDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of IpDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.Equals(input.IpAddresses)
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                return hashCode;
            }
        }

    }

}

