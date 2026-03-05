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
    /// RdsOracleDbInfo
    /// </summary>
    [DataContract]
    public partial class RdsOracleDbInfo :  IEquatable<RdsOracleDbInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RdsOracleDbInfo" /> class.
        /// </summary>
        /// <param name="isMultitenant">True if the RDS Oracle instance is configured as multi-tenant (CDB)..</param>
        /// <param name="tenantDatabases">List of tenant (pluggable) databases in the instance..</param>
        public RdsOracleDbInfo(bool? isMultitenant = default(bool?), List<TenantDbInfo> tenantDatabases = default(List<TenantDbInfo>))
        {
            this.IsMultitenant = isMultitenant;
            this.TenantDatabases = tenantDatabases;
            this.IsMultitenant = isMultitenant;
            this.TenantDatabases = tenantDatabases;
        }
        
        /// <summary>
        /// True if the RDS Oracle instance is configured as multi-tenant (CDB).
        /// </summary>
        /// <value>True if the RDS Oracle instance is configured as multi-tenant (CDB).</value>
        [DataMember(Name="isMultitenant", EmitDefaultValue=true)]
        public bool? IsMultitenant { get; set; }

        /// <summary>
        /// List of tenant (pluggable) databases in the instance.
        /// </summary>
        /// <value>List of tenant (pluggable) databases in the instance.</value>
        [DataMember(Name="tenantDatabases", EmitDefaultValue=true)]
        public List<TenantDbInfo> TenantDatabases { get; set; }

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
            return this.Equals(input as RdsOracleDbInfo);
        }

        /// <summary>
        /// Returns true if RdsOracleDbInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RdsOracleDbInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RdsOracleDbInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMultitenant == input.IsMultitenant ||
                    (this.IsMultitenant != null &&
                    this.IsMultitenant.Equals(input.IsMultitenant))
                ) && 
                (
                    this.TenantDatabases == input.TenantDatabases ||
                    this.TenantDatabases != null &&
                    input.TenantDatabases != null &&
                    this.TenantDatabases.SequenceEqual(input.TenantDatabases)
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
                if (this.IsMultitenant != null)
                    hashCode = hashCode * 59 + this.IsMultitenant.GetHashCode();
                if (this.TenantDatabases != null)
                    hashCode = hashCode * 59 + this.TenantDatabases.GetHashCode();
                return hashCode;
            }
        }

    }

}

