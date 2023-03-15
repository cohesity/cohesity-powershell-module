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
    /// Specifies entity update details response about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantEntityUpdate :  IEquatable<TenantEntityUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantEntityUpdate" /> class.
        /// </summary>
        /// <param name="entityIds">Specifies the EntityIds for respective tenant..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantEntityUpdate(List<long> entityIds = default(List<long>), string tenantId = default(string))
        {
            this.EntityIds = entityIds;
            this.TenantId = tenantId;
            this.EntityIds = entityIds;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the EntityIds for respective tenant.
        /// </summary>
        /// <value>Specifies the EntityIds for respective tenant.</value>
        [DataMember(Name="entityIds", EmitDefaultValue=true)]
        public List<long> EntityIds { get; set; }

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
            return this.Equals(input as TenantEntityUpdate);
        }

        /// <summary>
        /// Returns true if TenantEntityUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantEntityUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantEntityUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityIds == input.EntityIds ||
                    this.EntityIds != null &&
                    input.EntityIds != null &&
                    this.EntityIds.SequenceEqual(input.EntityIds)
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
                if (this.EntityIds != null)
                    hashCode = hashCode * 59 + this.EntityIds.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

