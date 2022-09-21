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
    /// Specifies struct with basic tenant details.
    /// </summary>
    [DataContract]
    public partial class TenantInfo :  IEquatable<TenantInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantInfo" /> class.
        /// </summary>
        /// <param name="bifrostEnabled">Specifies if this tenant is bifrost enabled or not..</param>
        /// <param name="name">Specifies name of the tenant..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantInfo(bool? bifrostEnabled = default(bool?), string name = default(string), string tenantId = default(string))
        {
            this.BifrostEnabled = bifrostEnabled;
            this.Name = name;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies if this tenant is bifrost enabled or not.
        /// </summary>
        /// <value>Specifies if this tenant is bifrost enabled or not.</value>
        [DataMember(Name="bifrostEnabled", EmitDefaultValue=true)]
        public bool? BifrostEnabled { get; set; }

        /// <summary>
        /// Specifies name of the tenant.
        /// </summary>
        /// <value>Specifies name of the tenant.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as TenantInfo);
        }

        /// <summary>
        /// Returns true if TenantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BifrostEnabled == input.BifrostEnabled ||
                    (this.BifrostEnabled != null &&
                    this.BifrostEnabled.Equals(input.BifrostEnabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.BifrostEnabled != null)
                    hashCode = hashCode * 59 + this.BifrostEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

