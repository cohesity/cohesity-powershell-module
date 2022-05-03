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
    /// Specifies the parameters of a host entry that can be stored in the cluster&#39;s /etc/hosts file.
    /// </summary>
    [DataContract]
    public partial class HostEntry :  IEquatable<HostEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HostEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntry" /> class.
        /// </summary>
        /// <param name="description">Description the host entry..</param>
        /// <param name="domainNames">Specifies the domain names of the host. (required).</param>
        /// <param name="ip">Specifies the IP address of the host. (required).</param>
        public HostEntry(string description = default(string), List<string> domainNames = default(List<string>), string ip = default(string))
        {
            // to ensure "domainNames" is required (not null)
            if (domainNames == null)
            {
                throw new InvalidDataException("domainNames is a required property for HostEntry and cannot be null");
            }
            else
            {
                this.DomainNames = domainNames;
            }
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for HostEntry and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            this.Description = description;
        }
        
        /// <summary>
        /// Description the host entry.
        /// </summary>
        /// <value>Description the host entry.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the domain names of the host.
        /// </summary>
        /// <value>Specifies the domain names of the host.</value>
        [DataMember(Name="domainNames", EmitDefaultValue=false)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// Specifies the IP address of the host.
        /// </summary>
        /// <value>Specifies the IP address of the host.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

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
            return this.Equals(input as HostEntry);
        }

        /// <summary>
        /// Returns true if HostEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of HostEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DomainNames == input.DomainNames ||
                    this.DomainNames != null &&
                    this.DomainNames.Equals(input.DomainNames)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DomainNames != null)
                    hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }

    }

}

