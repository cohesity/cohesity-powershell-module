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
    /// Specifies Active Directory update details response about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantActiveDirectoryUpdate :  IEquatable<TenantActiveDirectoryUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantActiveDirectoryUpdate" /> class.
        /// </summary>
        /// <param name="activeDirectoryDomains">Specifies the ActiveDirectoryDomain vec for respective tenant..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantActiveDirectoryUpdate(List<string> activeDirectoryDomains = default(List<string>), string tenantId = default(string))
        {
            this.ActiveDirectoryDomains = activeDirectoryDomains;
            this.TenantId = tenantId;
            this.ActiveDirectoryDomains = activeDirectoryDomains;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the ActiveDirectoryDomain vec for respective tenant.
        /// </summary>
        /// <value>Specifies the ActiveDirectoryDomain vec for respective tenant.</value>
        [DataMember(Name="activeDirectoryDomains", EmitDefaultValue=true)]
        public List<string> ActiveDirectoryDomains { get; set; }

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
            return this.Equals(input as TenantActiveDirectoryUpdate);
        }

        /// <summary>
        /// Returns true if TenantActiveDirectoryUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantActiveDirectoryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantActiveDirectoryUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveDirectoryDomains == input.ActiveDirectoryDomains ||
                    this.ActiveDirectoryDomains != null &&
                    input.ActiveDirectoryDomains != null &&
                    this.ActiveDirectoryDomains.Equals(input.ActiveDirectoryDomains)
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
                if (this.ActiveDirectoryDomains != null)
                    hashCode = hashCode * 59 + this.ActiveDirectoryDomains.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

