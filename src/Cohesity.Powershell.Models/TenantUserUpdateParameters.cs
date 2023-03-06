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
    /// Specifies user update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantUserUpdateParameters :  IEquatable<TenantUserUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUserUpdateParameters" /> class.
        /// </summary>
        /// <param name="sids">Specifies the array of Sid of the users..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantUserUpdateParameters(List<string> sids = default(List<string>), string tenantId = default(string))
        {
            this.Sids = sids;
            this.TenantId = tenantId;
            this.Sids = sids;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the array of Sid of the users.
        /// </summary>
        /// <value>Specifies the array of Sid of the users.</value>
        [DataMember(Name="sids", EmitDefaultValue=true)]
        public List<string> Sids { get; set; }

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
            return this.Equals(input as TenantUserUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantUserUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantUserUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantUserUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sids == input.Sids ||
                    this.Sids != null &&
                    input.Sids != null &&
                    this.Sids.SequenceEqual(input.Sids)
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
                if (this.Sids != null)
                    hashCode = hashCode * 59 + this.Sids.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

