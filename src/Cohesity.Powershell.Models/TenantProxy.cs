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
    /// Specifies the data for tenant proxy which has been deployed in tenant&#39;s enviroment.
    /// </summary>
    [DataContract]
    public partial class TenantProxy :  IEquatable<TenantProxy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantProxy" /> class.
        /// </summary>
        /// <param name="constituentId">Specifies the constituent id of the proxy..</param>
        /// <param name="ipAddress">Specifies the ip address of the proxy..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="version">Specifies the version of the proxy..</param>
        public TenantProxy(long? constituentId = default(long?), string ipAddress = default(string), string tenantId = default(string), string version = default(string))
        {
            this.ConstituentId = constituentId;
            this.IpAddress = ipAddress;
            this.TenantId = tenantId;
            this.Version = version;
            this.ConstituentId = constituentId;
            this.IpAddress = ipAddress;
            this.TenantId = tenantId;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies the constituent id of the proxy.
        /// </summary>
        /// <value>Specifies the constituent id of the proxy.</value>
        [DataMember(Name="constituentId", EmitDefaultValue=true)]
        public long? ConstituentId { get; set; }

        /// <summary>
        /// Specifies the ip address of the proxy.
        /// </summary>
        /// <value>Specifies the ip address of the proxy.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the version of the proxy.
        /// </summary>
        /// <value>Specifies the version of the proxy.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as TenantProxy);
        }

        /// <summary>
        /// Returns true if TenantProxy instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantProxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantProxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConstituentId == input.ConstituentId ||
                    (this.ConstituentId != null &&
                    this.ConstituentId.Equals(input.ConstituentId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ConstituentId != null)
                    hashCode = hashCode * 59 + this.ConstituentId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

