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
    /// Specifies protection policy update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantProtectionPolicyUpdateParameters :  IEquatable<TenantProtectionPolicyUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantProtectionPolicyUpdateParameters" /> class.
        /// </summary>
        /// <param name="policyIds">Specifies the PolicyIds for respective tenant..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantProtectionPolicyUpdateParameters(List<string> policyIds = default(List<string>), string tenantId = default(string))
        {
            this.PolicyIds = policyIds;
            this.TenantId = tenantId;
            this.PolicyIds = policyIds;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the PolicyIds for respective tenant.
        /// </summary>
        /// <value>Specifies the PolicyIds for respective tenant.</value>
        [DataMember(Name="policyIds", EmitDefaultValue=true)]
        public List<string> PolicyIds { get; set; }

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
            return this.Equals(input as TenantProtectionPolicyUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantProtectionPolicyUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantProtectionPolicyUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantProtectionPolicyUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyIds == input.PolicyIds ||
                    this.PolicyIds != null &&
                    input.PolicyIds != null &&
                    this.PolicyIds.SequenceEqual(input.PolicyIds)
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
                if (this.PolicyIds != null)
                    hashCode = hashCode * 59 + this.PolicyIds.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

