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
    /// StaticVip
    /// </summary>
    [DataContract]
    public partial class StaticVip :  IEquatable<StaticVip>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticVip" /> class.
        /// </summary>
        /// <param name="component">Specifies the component.</param>
        /// <param name="fqdn">Specifies the NetBackup media server FQDNs..</param>
        /// <param name="nodeid">Specifies the NetBackup media server host node Ids..</param>
        /// <param name="vip">Specifies the NetBackup media server VIPs..</param>
        public StaticVip(string component = default(string), string fqdn = default(string), long? nodeid = default(long?), string vip = default(string))
        {
            this.Component = component;
            this.Fqdn = fqdn;
            this.Nodeid = nodeid;
            this.Vip = vip;
            this.Component = component;
            this.Fqdn = fqdn;
            this.Nodeid = nodeid;
            this.Vip = vip;
        }
        
        /// <summary>
        /// Specifies the component
        /// </summary>
        /// <value>Specifies the component</value>
        [DataMember(Name="component", EmitDefaultValue=true)]
        public string Component { get; set; }

        /// <summary>
        /// Specifies the NetBackup media server FQDNs.
        /// </summary>
        /// <value>Specifies the NetBackup media server FQDNs.</value>
        [DataMember(Name="fqdn", EmitDefaultValue=true)]
        public string Fqdn { get; set; }

        /// <summary>
        /// Specifies the NetBackup media server host node Ids.
        /// </summary>
        /// <value>Specifies the NetBackup media server host node Ids.</value>
        [DataMember(Name="nodeid", EmitDefaultValue=true)]
        public long? Nodeid { get; set; }

        /// <summary>
        /// Specifies the NetBackup media server VIPs.
        /// </summary>
        /// <value>Specifies the NetBackup media server VIPs.</value>
        [DataMember(Name="vip", EmitDefaultValue=true)]
        public string Vip { get; set; }

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
            return this.Equals(input as StaticVip);
        }

        /// <summary>
        /// Returns true if StaticVip instances are equal
        /// </summary>
        /// <param name="input">Instance of StaticVip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticVip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
                ) && 
                (
                    this.Fqdn == input.Fqdn ||
                    (this.Fqdn != null &&
                    this.Fqdn.Equals(input.Fqdn))
                ) && 
                (
                    this.Nodeid == input.Nodeid ||
                    (this.Nodeid != null &&
                    this.Nodeid.Equals(input.Nodeid))
                ) && 
                (
                    this.Vip == input.Vip ||
                    (this.Vip != null &&
                    this.Vip.Equals(input.Vip))
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
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Fqdn != null)
                    hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                if (this.Nodeid != null)
                    hashCode = hashCode * 59 + this.Nodeid.GetHashCode();
                if (this.Vip != null)
                    hashCode = hashCode * 59 + this.Vip.GetHashCode();
                return hashCode;
            }
        }

    }

}

