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
    /// CreateCloudDomainMigrationParameters represents the parameters needed to schedule the cloud domain migration.
    /// </summary>
    [DataContract]
    public partial class CreateCloudDomainMigrationParameters :  IEquatable<CreateCloudDomainMigrationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudDomainMigrationParameters" /> class.
        /// </summary>
        /// <param name="cloudDomainId">Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated..</param>
        /// <param name="isCadMode">Specifies if the migration mode is CAD or not..</param>
        /// <param name="migrationUid">Specifies the Unique identifier of the domain migration request and can be used to query the status of the migration..</param>
        /// <param name="vaultId">Specifies Id of the vault..</param>
        /// <param name="viewBoxId">Specifies the id of the viewbox for the request in case migration mode is Incremental Forever. Not set for CAD mode migration..</param>
        public CreateCloudDomainMigrationParameters(long? cloudDomainId = default(long?), bool? isCadMode = default(bool?), string migrationUid = default(string), long? vaultId = default(long?), long? viewBoxId = default(long?))
        {
            this.CloudDomainId = cloudDomainId;
            this.IsCadMode = isCadMode;
            this.MigrationUid = migrationUid;
            this.VaultId = vaultId;
            this.ViewBoxId = viewBoxId;
            this.CloudDomainId = cloudDomainId;
            this.IsCadMode = isCadMode;
            this.MigrationUid = migrationUid;
            this.VaultId = vaultId;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated.
        /// </summary>
        /// <value>Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated.</value>
        [DataMember(Name="cloudDomainId", EmitDefaultValue=true)]
        public long? CloudDomainId { get; set; }

        /// <summary>
        /// Specifies if the migration mode is CAD or not.
        /// </summary>
        /// <value>Specifies if the migration mode is CAD or not.</value>
        [DataMember(Name="isCadMode", EmitDefaultValue=true)]
        public bool? IsCadMode { get; set; }

        /// <summary>
        /// Specifies the Unique identifier of the domain migration request and can be used to query the status of the migration.
        /// </summary>
        /// <value>Specifies the Unique identifier of the domain migration request and can be used to query the status of the migration.</value>
        [DataMember(Name="migrationUid", EmitDefaultValue=true)]
        public string MigrationUid { get; set; }

        /// <summary>
        /// Specifies Id of the vault.
        /// </summary>
        /// <value>Specifies Id of the vault.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the id of the viewbox for the request in case migration mode is Incremental Forever. Not set for CAD mode migration.
        /// </summary>
        /// <value>Specifies the id of the viewbox for the request in case migration mode is Incremental Forever. Not set for CAD mode migration.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as CreateCloudDomainMigrationParameters);
        }

        /// <summary>
        /// Returns true if CreateCloudDomainMigrationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCloudDomainMigrationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCloudDomainMigrationParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudDomainId == input.CloudDomainId ||
                    (this.CloudDomainId != null &&
                    this.CloudDomainId.Equals(input.CloudDomainId))
                ) && 
                (
                    this.IsCadMode == input.IsCadMode ||
                    (this.IsCadMode != null &&
                    this.IsCadMode.Equals(input.IsCadMode))
                ) && 
                (
                    this.MigrationUid == input.MigrationUid ||
                    (this.MigrationUid != null &&
                    this.MigrationUid.Equals(input.MigrationUid))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.CloudDomainId != null)
                    hashCode = hashCode * 59 + this.CloudDomainId.GetHashCode();
                if (this.IsCadMode != null)
                    hashCode = hashCode * 59 + this.IsCadMode.GetHashCode();
                if (this.MigrationUid != null)
                    hashCode = hashCode * 59 + this.MigrationUid.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}

