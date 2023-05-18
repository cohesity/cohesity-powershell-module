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
    /// Specifies view update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantViewUpdateParameters :  IEquatable<TenantViewUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantViewUpdateParameters" /> class.
        /// </summary>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="viewNames">Specifies the PolicyIds for respective tenant..</param>
        public TenantViewUpdateParameters(string tenantId = default(string), List<string> viewNames = default(List<string>))
        {
            this.TenantId = tenantId;
            this.ViewNames = viewNames;
            this.TenantId = tenantId;
            this.ViewNames = viewNames;
        }
        
        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the PolicyIds for respective tenant.
        /// </summary>
        /// <value>Specifies the PolicyIds for respective tenant.</value>
        [DataMember(Name="viewNames", EmitDefaultValue=true)]
        public List<string> ViewNames { get; set; }

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
            return this.Equals(input as TenantViewUpdateParameters);
        }

        /// <summary>
        /// Returns true if TenantViewUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantViewUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantViewUpdateParameters input)
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
                    this.ViewNames == input.ViewNames ||
                    this.ViewNames != null &&
                    input.ViewNames != null &&
                    this.ViewNames.SequenceEqual(input.ViewNames)
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
                if (this.ViewNames != null)
                    hashCode = hashCode * 59 + this.ViewNames.GetHashCode();
                return hashCode;
            }
        }

    }

}

