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
    /// Specifies information about an AD Domain.
    /// </summary>
    [DataContract]
    public partial class AdDomain :  IEquatable<AdDomain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdDomain" /> class.
        /// </summary>
        /// <param name="dnsRoot">Specifies DNS root..</param>
        /// <param name="forest">Specifies AD forest name..</param>
        /// <param name="identity">identity.</param>
        /// <param name="netbiosName">Specifies AD NetBIOS name..</param>
        /// <param name="parentDomain">Specifies parent domain name..</param>
        /// <param name="tombstoneDays">Specifies tombstone time in days..</param>
        public AdDomain(string dnsRoot = default(string), string forest = default(string), AdDomainIdentity identity = default(AdDomainIdentity), string netbiosName = default(string), string parentDomain = default(string), int? tombstoneDays = default(int?))
        {
            this.DnsRoot = dnsRoot;
            this.Forest = forest;
            this.NetbiosName = netbiosName;
            this.ParentDomain = parentDomain;
            this.TombstoneDays = tombstoneDays;
            this.DnsRoot = dnsRoot;
            this.Forest = forest;
            this.Identity = identity;
            this.NetbiosName = netbiosName;
            this.ParentDomain = parentDomain;
            this.TombstoneDays = tombstoneDays;
        }
        
        /// <summary>
        /// Specifies DNS root.
        /// </summary>
        /// <value>Specifies DNS root.</value>
        [DataMember(Name="dnsRoot", EmitDefaultValue=true)]
        public string DnsRoot { get; set; }

        /// <summary>
        /// Specifies AD forest name.
        /// </summary>
        /// <value>Specifies AD forest name.</value>
        [DataMember(Name="forest", EmitDefaultValue=true)]
        public string Forest { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public AdDomainIdentity Identity { get; set; }

        /// <summary>
        /// Specifies AD NetBIOS name.
        /// </summary>
        /// <value>Specifies AD NetBIOS name.</value>
        [DataMember(Name="netbiosName", EmitDefaultValue=true)]
        public string NetbiosName { get; set; }

        /// <summary>
        /// Specifies parent domain name.
        /// </summary>
        /// <value>Specifies parent domain name.</value>
        [DataMember(Name="parentDomain", EmitDefaultValue=true)]
        public string ParentDomain { get; set; }

        /// <summary>
        /// Specifies tombstone time in days.
        /// </summary>
        /// <value>Specifies tombstone time in days.</value>
        [DataMember(Name="tombstoneDays", EmitDefaultValue=true)]
        public int? TombstoneDays { get; set; }

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
            return this.Equals(input as AdDomain);
        }

        /// <summary>
        /// Returns true if AdDomain instances are equal
        /// </summary>
        /// <param name="input">Instance of AdDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdDomain input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsRoot == input.DnsRoot ||
                    (this.DnsRoot != null &&
                    this.DnsRoot.Equals(input.DnsRoot))
                ) && 
                (
                    this.Forest == input.Forest ||
                    (this.Forest != null &&
                    this.Forest.Equals(input.Forest))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.NetbiosName == input.NetbiosName ||
                    (this.NetbiosName != null &&
                    this.NetbiosName.Equals(input.NetbiosName))
                ) && 
                (
                    this.ParentDomain == input.ParentDomain ||
                    (this.ParentDomain != null &&
                    this.ParentDomain.Equals(input.ParentDomain))
                ) && 
                (
                    this.TombstoneDays == input.TombstoneDays ||
                    (this.TombstoneDays != null &&
                    this.TombstoneDays.Equals(input.TombstoneDays))
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
                if (this.DnsRoot != null)
                    hashCode = hashCode * 59 + this.DnsRoot.GetHashCode();
                if (this.Forest != null)
                    hashCode = hashCode * 59 + this.Forest.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.NetbiosName != null)
                    hashCode = hashCode * 59 + this.NetbiosName.GetHashCode();
                if (this.ParentDomain != null)
                    hashCode = hashCode * 59 + this.ParentDomain.GetHashCode();
                if (this.TombstoneDays != null)
                    hashCode = hashCode * 59 + this.TombstoneDays.GetHashCode();
                return hashCode;
            }
        }

    }

}

