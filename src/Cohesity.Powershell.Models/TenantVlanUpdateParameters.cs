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
    /// Specifies vlan update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantVlanUpdateParameters :  IEquatable<TenantVlanUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantVlanUpdateParameters" /> class.
        /// </summary>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="vlanIfaceNames">Specifies the VlanIfaceNames for respective tenant, in the format of bond1.200..</param>
        public TenantVlanUpdateParameters(string tenantId = default(string), List<string> vlanIfaceNames = default(List<string>))
        {
            this.TenantId = tenantId;
            this.VlanIfaceNames = vlanIfaceNames;
            this.TenantId = tenantId;
            this.VlanIfaceNames = vlanIfaceNames;
        }
        
        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the VlanIfaceNames for respective tenant, in the format of bond1.200.
        /// </summary>
        /// <value>Specifies the VlanIfaceNames for respective tenant, in the format of bond1.200.</value>
        [DataMember(Name="vlanIfaceNames", EmitDefaultValue=true)]
        public List<string> VlanIfaceNames { get; set; }

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
            return this.Equals(input as TenantVlanUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantVlanUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantVlanUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantVlanUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.VlanIfaceNames == input.VlanIfaceNames ||
                    this.VlanIfaceNames != null &&
                    input.VlanIfaceNames != null &&
                    this.VlanIfaceNames.SequenceEqual(input.VlanIfaceNames)
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.VlanIfaceNames != null)
                    hashCode = hashCode * 59 + this.VlanIfaceNames.GetHashCode();
                return hashCode;
            }
        }

    }

}

