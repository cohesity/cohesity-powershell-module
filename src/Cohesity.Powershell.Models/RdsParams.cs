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
    /// Specifies rds params for the restore operation.
    /// </summary>
    [DataContract]
    public partial class RdsParams :  IEquatable<RdsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RdsParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RdsParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RdsParams" /> class.
        /// </summary>
        /// <param name="availabilityZoneId">Entity representing the availability zone to use while restoring the DB..</param>
        /// <param name="dbInstanceId">The DB instance identifier to use for the restored DB. This field is required. (required).</param>
        /// <param name="dbOptionGroupId">Entity representing the RDS option group to use while restoring the DB..</param>
        /// <param name="dbParameterGroupId">Entity representing the RDS parameter group to use while restoring the DB..</param>
        /// <param name="dbPort">Port to use for the DB in the restored RDS instance..</param>
        /// <param name="enableAutoMinorVersionUpgrade">Whether to enable auto minor version upgrade in the restored DB..</param>
        /// <param name="enableCopyTagsToSnapshots">Whether to enable copying of tags to snapshots of the DB..</param>
        /// <param name="enableDbAuthentication">Whether to enable IAM authentication for the DB..</param>
        /// <param name="enablePublicAccessibility">Whether this DB will be publicly accessible or not..</param>
        /// <param name="isMultiAzDeployment">Whether this is a multi-az deployment or not..</param>
        public RdsParams(long? availabilityZoneId = default(long?), string dbInstanceId = default(string), long? dbOptionGroupId = default(long?), long? dbParameterGroupId = default(long?), int? dbPort = default(int?), bool? enableAutoMinorVersionUpgrade = default(bool?), bool? enableCopyTagsToSnapshots = default(bool?), bool? enableDbAuthentication = default(bool?), bool? enablePublicAccessibility = default(bool?), bool? isMultiAzDeployment = default(bool?))
        {
            // to ensure "dbInstanceId" is required (not null)
            if (dbInstanceId == null)
            {
                throw new InvalidDataException("dbInstanceId is a required property for RdsParams and cannot be null");
            }
            else
            {
                this.DbInstanceId = dbInstanceId;
            }
            this.AvailabilityZoneId = availabilityZoneId;
            this.DbOptionGroupId = dbOptionGroupId;
            this.DbParameterGroupId = dbParameterGroupId;
            this.DbPort = dbPort;
            this.EnableAutoMinorVersionUpgrade = enableAutoMinorVersionUpgrade;
            this.EnableCopyTagsToSnapshots = enableCopyTagsToSnapshots;
            this.EnableDbAuthentication = enableDbAuthentication;
            this.EnablePublicAccessibility = enablePublicAccessibility;
            this.IsMultiAzDeployment = isMultiAzDeployment;
        }
        
        /// <summary>
        /// Entity representing the availability zone to use while restoring the DB.
        /// </summary>
        /// <value>Entity representing the availability zone to use while restoring the DB.</value>
        [DataMember(Name="availabilityZoneId", EmitDefaultValue=false)]
        public long? AvailabilityZoneId { get; set; }

        /// <summary>
        /// The DB instance identifier to use for the restored DB. This field is required.
        /// </summary>
        /// <value>The DB instance identifier to use for the restored DB. This field is required.</value>
        [DataMember(Name="dbInstanceId", EmitDefaultValue=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// Entity representing the RDS option group to use while restoring the DB.
        /// </summary>
        /// <value>Entity representing the RDS option group to use while restoring the DB.</value>
        [DataMember(Name="dbOptionGroupId", EmitDefaultValue=false)]
        public long? DbOptionGroupId { get; set; }

        /// <summary>
        /// Entity representing the RDS parameter group to use while restoring the DB.
        /// </summary>
        /// <value>Entity representing the RDS parameter group to use while restoring the DB.</value>
        [DataMember(Name="dbParameterGroupId", EmitDefaultValue=false)]
        public long? DbParameterGroupId { get; set; }

        /// <summary>
        /// Port to use for the DB in the restored RDS instance.
        /// </summary>
        /// <value>Port to use for the DB in the restored RDS instance.</value>
        [DataMember(Name="dbPort", EmitDefaultValue=false)]
        public int? DbPort { get; set; }

        /// <summary>
        /// Whether to enable auto minor version upgrade in the restored DB.
        /// </summary>
        /// <value>Whether to enable auto minor version upgrade in the restored DB.</value>
        [DataMember(Name="enableAutoMinorVersionUpgrade", EmitDefaultValue=false)]
        public bool? EnableAutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Whether to enable copying of tags to snapshots of the DB.
        /// </summary>
        /// <value>Whether to enable copying of tags to snapshots of the DB.</value>
        [DataMember(Name="enableCopyTagsToSnapshots", EmitDefaultValue=false)]
        public bool? EnableCopyTagsToSnapshots { get; set; }

        /// <summary>
        /// Whether to enable IAM authentication for the DB.
        /// </summary>
        /// <value>Whether to enable IAM authentication for the DB.</value>
        [DataMember(Name="enableDbAuthentication", EmitDefaultValue=false)]
        public bool? EnableDbAuthentication { get; set; }

        /// <summary>
        /// Whether this DB will be publicly accessible or not.
        /// </summary>
        /// <value>Whether this DB will be publicly accessible or not.</value>
        [DataMember(Name="enablePublicAccessibility", EmitDefaultValue=false)]
        public bool? EnablePublicAccessibility { get; set; }

        /// <summary>
        /// Whether this is a multi-az deployment or not.
        /// </summary>
        /// <value>Whether this is a multi-az deployment or not.</value>
        [DataMember(Name="isMultiAzDeployment", EmitDefaultValue=false)]
        public bool? IsMultiAzDeployment { get; set; }

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
            return this.Equals(input as RdsParams);
        }

        /// <summary>
        /// Returns true if RdsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RdsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RdsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityZoneId == input.AvailabilityZoneId ||
                    (this.AvailabilityZoneId != null &&
                    this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))
                ) && 
                (
                    this.DbInstanceId == input.DbInstanceId ||
                    (this.DbInstanceId != null &&
                    this.DbInstanceId.Equals(input.DbInstanceId))
                ) && 
                (
                    this.DbOptionGroupId == input.DbOptionGroupId ||
                    (this.DbOptionGroupId != null &&
                    this.DbOptionGroupId.Equals(input.DbOptionGroupId))
                ) && 
                (
                    this.DbParameterGroupId == input.DbParameterGroupId ||
                    (this.DbParameterGroupId != null &&
                    this.DbParameterGroupId.Equals(input.DbParameterGroupId))
                ) && 
                (
                    this.DbPort == input.DbPort ||
                    (this.DbPort != null &&
                    this.DbPort.Equals(input.DbPort))
                ) && 
                (
                    this.EnableAutoMinorVersionUpgrade == input.EnableAutoMinorVersionUpgrade ||
                    (this.EnableAutoMinorVersionUpgrade != null &&
                    this.EnableAutoMinorVersionUpgrade.Equals(input.EnableAutoMinorVersionUpgrade))
                ) && 
                (
                    this.EnableCopyTagsToSnapshots == input.EnableCopyTagsToSnapshots ||
                    (this.EnableCopyTagsToSnapshots != null &&
                    this.EnableCopyTagsToSnapshots.Equals(input.EnableCopyTagsToSnapshots))
                ) && 
                (
                    this.EnableDbAuthentication == input.EnableDbAuthentication ||
                    (this.EnableDbAuthentication != null &&
                    this.EnableDbAuthentication.Equals(input.EnableDbAuthentication))
                ) && 
                (
                    this.EnablePublicAccessibility == input.EnablePublicAccessibility ||
                    (this.EnablePublicAccessibility != null &&
                    this.EnablePublicAccessibility.Equals(input.EnablePublicAccessibility))
                ) && 
                (
                    this.IsMultiAzDeployment == input.IsMultiAzDeployment ||
                    (this.IsMultiAzDeployment != null &&
                    this.IsMultiAzDeployment.Equals(input.IsMultiAzDeployment))
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
                if (this.AvailabilityZoneId != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.DbInstanceId != null)
                    hashCode = hashCode * 59 + this.DbInstanceId.GetHashCode();
                if (this.DbOptionGroupId != null)
                    hashCode = hashCode * 59 + this.DbOptionGroupId.GetHashCode();
                if (this.DbParameterGroupId != null)
                    hashCode = hashCode * 59 + this.DbParameterGroupId.GetHashCode();
                if (this.DbPort != null)
                    hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.EnableAutoMinorVersionUpgrade != null)
                    hashCode = hashCode * 59 + this.EnableAutoMinorVersionUpgrade.GetHashCode();
                if (this.EnableCopyTagsToSnapshots != null)
                    hashCode = hashCode * 59 + this.EnableCopyTagsToSnapshots.GetHashCode();
                if (this.EnableDbAuthentication != null)
                    hashCode = hashCode * 59 + this.EnableDbAuthentication.GetHashCode();
                if (this.EnablePublicAccessibility != null)
                    hashCode = hashCode * 59 + this.EnablePublicAccessibility.GetHashCode();
                if (this.IsMultiAzDeployment != null)
                    hashCode = hashCode * 59 + this.IsMultiAzDeployment.GetHashCode();
                return hashCode;
            }
        }

    }

}

