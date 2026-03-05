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
    /// TenantDbInfo represents a single tenant (pluggable) database inside an RDS Oracle multi-tenant instance.
    /// </summary>
    [DataContract]
    public partial class TenantDbInfo :  IEquatable<TenantDbInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDbInfo" /> class.
        /// </summary>
        /// <param name="dbInstanceId">The ID of the DB instance that contains the tenant database..</param>
        /// <param name="dbiResourceId">Region-unique, immutable identifier for the DB instance..</param>
        /// <param name="masterUsername">The master username of the tenant database..</param>
        /// <param name="status">The status of the tenant database..</param>
        /// <param name="tags">Tags attached to the tenant database..</param>
        /// <param name="tenantDatabaseArn">The Amazon Resource Name (ARN) for the tenant database..</param>
        /// <param name="tenantDatabaseResourceId">Region-unique, immutable identifier for the tenant database..</param>
        /// <param name="tenantDbName">The database name of the tenant database..</param>
        public TenantDbInfo(string dbInstanceId = default(string), string dbiResourceId = default(string), string masterUsername = default(string), string status = default(string), List<TagAttribute> tags = default(List<TagAttribute>), string tenantDatabaseArn = default(string), string tenantDatabaseResourceId = default(string), string tenantDbName = default(string))
        {
            this.DbInstanceId = dbInstanceId;
            this.DbiResourceId = dbiResourceId;
            this.MasterUsername = masterUsername;
            this.Status = status;
            this.Tags = tags;
            this.TenantDatabaseArn = tenantDatabaseArn;
            this.TenantDatabaseResourceId = tenantDatabaseResourceId;
            this.TenantDbName = tenantDbName;
            this.DbInstanceId = dbInstanceId;
            this.DbiResourceId = dbiResourceId;
            this.MasterUsername = masterUsername;
            this.Status = status;
            this.Tags = tags;
            this.TenantDatabaseArn = tenantDatabaseArn;
            this.TenantDatabaseResourceId = tenantDatabaseResourceId;
            this.TenantDbName = tenantDbName;
        }
        
        /// <summary>
        /// The ID of the DB instance that contains the tenant database.
        /// </summary>
        /// <value>The ID of the DB instance that contains the tenant database.</value>
        [DataMember(Name="dbInstanceId", EmitDefaultValue=true)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// Region-unique, immutable identifier for the DB instance.
        /// </summary>
        /// <value>Region-unique, immutable identifier for the DB instance.</value>
        [DataMember(Name="dbiResourceId", EmitDefaultValue=true)]
        public string DbiResourceId { get; set; }

        /// <summary>
        /// The master username of the tenant database.
        /// </summary>
        /// <value>The master username of the tenant database.</value>
        [DataMember(Name="masterUsername", EmitDefaultValue=true)]
        public string MasterUsername { get; set; }

        /// <summary>
        /// The status of the tenant database.
        /// </summary>
        /// <value>The status of the tenant database.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// Tags attached to the tenant database.
        /// </summary>
        /// <value>Tags attached to the tenant database.</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<TagAttribute> Tags { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the tenant database.
        /// </summary>
        /// <value>The Amazon Resource Name (ARN) for the tenant database.</value>
        [DataMember(Name="tenantDatabaseArn", EmitDefaultValue=true)]
        public string TenantDatabaseArn { get; set; }

        /// <summary>
        /// Region-unique, immutable identifier for the tenant database.
        /// </summary>
        /// <value>Region-unique, immutable identifier for the tenant database.</value>
        [DataMember(Name="tenantDatabaseResourceId", EmitDefaultValue=true)]
        public string TenantDatabaseResourceId { get; set; }

        /// <summary>
        /// The database name of the tenant database.
        /// </summary>
        /// <value>The database name of the tenant database.</value>
        [DataMember(Name="tenantDbName", EmitDefaultValue=true)]
        public string TenantDbName { get; set; }

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
            return this.Equals(input as TenantDbInfo);
        }

        /// <summary>
        /// Returns true if TenantDbInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantDbInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantDbInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbInstanceId == input.DbInstanceId ||
                    (this.DbInstanceId != null &&
                    this.DbInstanceId.Equals(input.DbInstanceId))
                ) && 
                (
                    this.DbiResourceId == input.DbiResourceId ||
                    (this.DbiResourceId != null &&
                    this.DbiResourceId.Equals(input.DbiResourceId))
                ) && 
                (
                    this.MasterUsername == input.MasterUsername ||
                    (this.MasterUsername != null &&
                    this.MasterUsername.Equals(input.MasterUsername))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TenantDatabaseArn == input.TenantDatabaseArn ||
                    (this.TenantDatabaseArn != null &&
                    this.TenantDatabaseArn.Equals(input.TenantDatabaseArn))
                ) && 
                (
                    this.TenantDatabaseResourceId == input.TenantDatabaseResourceId ||
                    (this.TenantDatabaseResourceId != null &&
                    this.TenantDatabaseResourceId.Equals(input.TenantDatabaseResourceId))
                ) && 
                (
                    this.TenantDbName == input.TenantDbName ||
                    (this.TenantDbName != null &&
                    this.TenantDbName.Equals(input.TenantDbName))
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
                if (this.DbInstanceId != null)
                    hashCode = hashCode * 59 + this.DbInstanceId.GetHashCode();
                if (this.DbiResourceId != null)
                    hashCode = hashCode * 59 + this.DbiResourceId.GetHashCode();
                if (this.MasterUsername != null)
                    hashCode = hashCode * 59 + this.MasterUsername.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TenantDatabaseArn != null)
                    hashCode = hashCode * 59 + this.TenantDatabaseArn.GetHashCode();
                if (this.TenantDatabaseResourceId != null)
                    hashCode = hashCode * 59 + this.TenantDatabaseResourceId.GetHashCode();
                if (this.TenantDbName != null)
                    hashCode = hashCode * 59 + this.TenantDbName.GetHashCode();
                return hashCode;
            }
        }

    }

}

