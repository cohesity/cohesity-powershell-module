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
    /// Specifies group update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantGroupUpdateParameters :  IEquatable<TenantGroupUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantGroupUpdateParameters" /> class.
        /// </summary>
        /// <param name="sids">Specifies the array of Sid of the groups..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantGroupUpdateParameters(List<string> sids = default(List<string>), string tenantId = default(string))
        {
            this.Sids = sids;
            this.TenantId = tenantId;
            this.Sids = sids;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the array of Sid of the groups.
        /// </summary>
        /// <value>Specifies the array of Sid of the groups.</value>
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
            return this.Equals(input as TenantGroupUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantGroupUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantGroupUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantGroupUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sids == input.Sids ||
                    this.Sids != null &&
                    input.Sids != null &&
                    this.Sids.Equals(input.Sids)
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

