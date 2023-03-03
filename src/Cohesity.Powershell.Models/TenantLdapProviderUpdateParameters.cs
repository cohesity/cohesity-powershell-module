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
    /// Specifies Ldap Provider update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantLdapProviderUpdateParameters :  IEquatable<TenantLdapProviderUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantLdapProviderUpdateParameters" /> class.
        /// </summary>
        /// <param name="ldapProviderIds">Specifies the ids of ldap providers for respective tenant..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantLdapProviderUpdateParameters(List<long> ldapProviderIds = default(List<long>), string tenantId = default(string))
        {
            this.LdapProviderIds = ldapProviderIds;
            this.TenantId = tenantId;
            this.LdapProviderIds = ldapProviderIds;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the ids of ldap providers for respective tenant.
        /// </summary>
        /// <value>Specifies the ids of ldap providers for respective tenant.</value>
        [DataMember(Name="ldapProviderIds", EmitDefaultValue=true)]
        public List<long> LdapProviderIds { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as TenantLdapProviderUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantLdapProviderUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantLdapProviderUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantLdapProviderUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LdapProviderIds == input.LdapProviderIds ||
                    this.LdapProviderIds != null &&
                    input.LdapProviderIds != null &&
                    this.LdapProviderIds.SequenceEqual(input.LdapProviderIds)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.LdapProviderIds != null)
                    hashCode = hashCode * 59 + this.LdapProviderIds.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

