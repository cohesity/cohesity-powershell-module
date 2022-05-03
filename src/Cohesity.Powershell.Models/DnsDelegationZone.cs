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
    /// DnsDelegationZone
    /// </summary>
    [DataContract]
    public partial class DnsDelegationZone :  IEquatable<DnsDelegationZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsDelegationZone" /> class.
        /// </summary>
        /// <param name="dnsZoneName">Specifies the dns zone name..</param>
        /// <param name="dnsZoneResolvedVips">Specifies list of vips that will be resolved to..</param>
        /// <param name="dnsZoneVips">Specifies list of vips part of dns delegation zone..</param>
        public DnsDelegationZone(string dnsZoneName = default(string), List<string> dnsZoneResolvedVips = default(List<string>), List<string> dnsZoneVips = default(List<string>))
        {
            this.DnsZoneName = dnsZoneName;
            this.DnsZoneResolvedVips = dnsZoneResolvedVips;
            this.DnsZoneVips = dnsZoneVips;
        }
        
        /// <summary>
        /// Specifies the dns zone name.
        /// </summary>
        /// <value>Specifies the dns zone name.</value>
        [DataMember(Name="dnsZoneName", EmitDefaultValue=false)]
        public string DnsZoneName { get; set; }

        /// <summary>
        /// Specifies list of vips that will be resolved to.
        /// </summary>
        /// <value>Specifies list of vips that will be resolved to.</value>
        [DataMember(Name="dnsZoneResolvedVips", EmitDefaultValue=false)]
        public List<string> DnsZoneResolvedVips { get; set; }

        /// <summary>
        /// Specifies list of vips part of dns delegation zone.
        /// </summary>
        /// <value>Specifies list of vips part of dns delegation zone.</value>
        [DataMember(Name="dnsZoneVips", EmitDefaultValue=false)]
        public List<string> DnsZoneVips { get; set; }

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
            return this.Equals(input as DnsDelegationZone);
        }

        /// <summary>
        /// Returns true if DnsDelegationZone instances are equal
        /// </summary>
        /// <param name="input">Instance of DnsDelegationZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DnsDelegationZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsZoneName == input.DnsZoneName ||
                    (this.DnsZoneName != null &&
                    this.DnsZoneName.Equals(input.DnsZoneName))
                ) && 
                (
                    this.DnsZoneResolvedVips == input.DnsZoneResolvedVips ||
                    this.DnsZoneResolvedVips != null &&
                    this.DnsZoneResolvedVips.Equals(input.DnsZoneResolvedVips)
                ) && 
                (
                    this.DnsZoneVips == input.DnsZoneVips ||
                    this.DnsZoneVips != null &&
                    this.DnsZoneVips.Equals(input.DnsZoneVips)
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
                if (this.DnsZoneName != null)
                    hashCode = hashCode * 59 + this.DnsZoneName.GetHashCode();
                if (this.DnsZoneResolvedVips != null)
                    hashCode = hashCode * 59 + this.DnsZoneResolvedVips.GetHashCode();
                if (this.DnsZoneVips != null)
                    hashCode = hashCode * 59 + this.DnsZoneVips.GetHashCode();
                return hashCode;
            }
        }

    }

}

