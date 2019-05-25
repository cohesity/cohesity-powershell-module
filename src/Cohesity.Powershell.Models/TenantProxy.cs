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
        /// <param name="ipAddress">Specifies the ip address of the proxy..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantProxy(string ipAddress = default(string), string tenantId = default(string))
        {
            this.IpAddress = ipAddress;
            this.TenantId = tenantId;
            this.IpAddress = ipAddress;
            this.TenantId = tenantId;
        }
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantProxy {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}
