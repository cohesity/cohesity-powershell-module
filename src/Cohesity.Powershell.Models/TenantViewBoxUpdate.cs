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
    /// Specifies view box update details response about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantViewBoxUpdate :  IEquatable<TenantViewBoxUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantViewBoxUpdate" /> class.
        /// </summary>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="viewBoxIds">Specifies the ViewBoxIds for respective tenant..</param>
        public TenantViewBoxUpdate(string tenantId = default(string), List<long> viewBoxIds = default(List<long>))
        {
            this.TenantId = tenantId;
            this.ViewBoxIds = viewBoxIds;
            this.TenantId = tenantId;
            this.ViewBoxIds = viewBoxIds;
        }
        
        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the ViewBoxIds for respective tenant.
        /// </summary>
        /// <value>Specifies the ViewBoxIds for respective tenant.</value>
        [DataMember(Name="viewBoxIds", EmitDefaultValue=true)]
        public List<long> ViewBoxIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantViewBoxUpdate {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ViewBoxIds: ").Append(ViewBoxIds).Append("\n");
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
            return this.Equals(input as TenantViewBoxUpdate);
        }

        /// <summary>
        /// Returns true if TenantViewBoxUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantViewBoxUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantViewBoxUpdate input)
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
                    this.ViewBoxIds == input.ViewBoxIds ||
                    this.ViewBoxIds != null &&
                    input.ViewBoxIds != null &&
                    this.ViewBoxIds.SequenceEqual(input.ViewBoxIds)
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
                if (this.ViewBoxIds != null)
                    hashCode = hashCode * 59 + this.ViewBoxIds.GetHashCode();
                return hashCode;
            }
        }

    }

}
