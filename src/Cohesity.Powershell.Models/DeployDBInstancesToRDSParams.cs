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
    /// Contains RDS specfic options that can be supplied while restoring the RDS DB instance.
    /// </summary>
    [DataContract]
    public partial class DeployDBInstancesToRDSParams :  IEquatable<DeployDBInstancesToRDSParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployDBInstancesToRDSParams" /> class.
        /// </summary>
        /// <param name="autoMinorVersionUpgrade">Whether to enable auto minor version upgrade in the restored DB..</param>
        /// <param name="availabilityZone">availabilityZone.</param>
        /// <param name="copyTagsToSnapshots">Whether to enable copying of tags to snapshots of the DB..</param>
        /// <param name="dbInstanceId">The DB instance identifier to use for the restored DB. This field is required..</param>
        /// <param name="dbOptionGroup">dbOptionGroup.</param>
        /// <param name="dbParameterGroup">dbParameterGroup.</param>
        /// <param name="dbPort">Port to use for the DB in the restored RDS instance..</param>
        /// <param name="iamDbAuthentication">Whether to enable IAM authentication for the DB..</param>
        /// <param name="multiAzDeployment">Whether this is a multi-az deployment or not..</param>
        /// <param name="pointInTimeParams">pointInTimeParams.</param>
        /// <param name="publicAccessibility">Whether this DB will be publicly accessible or not..</param>
        public DeployDBInstancesToRDSParams(bool? autoMinorVersionUpgrade = default(bool?), EntityProto availabilityZone = default(EntityProto), bool? copyTagsToSnapshots = default(bool?), string dbInstanceId = default(string), EntityProto dbOptionGroup = default(EntityProto), EntityProto dbParameterGroup = default(EntityProto), int? dbPort = default(int?), bool? iamDbAuthentication = default(bool?), bool? multiAzDeployment = default(bool?), DeployDBInstancesToRDSParamsPointInTimeRestoreParams pointInTimeParams = default(DeployDBInstancesToRDSParamsPointInTimeRestoreParams), bool? publicAccessibility = default(bool?))
        {
            this.AutoMinorVersionUpgrade = autoMinorVersionUpgrade;
            this.AvailabilityZone = availabilityZone;
            this.CopyTagsToSnapshots = copyTagsToSnapshots;
            this.DbInstanceId = dbInstanceId;
            this.DbOptionGroup = dbOptionGroup;
            this.DbParameterGroup = dbParameterGroup;
            this.DbPort = dbPort;
            this.IamDbAuthentication = iamDbAuthentication;
            this.MultiAzDeployment = multiAzDeployment;
            this.PointInTimeParams = pointInTimeParams;
            this.PublicAccessibility = publicAccessibility;
        }
        
        /// <summary>
        /// Whether to enable auto minor version upgrade in the restored DB.
        /// </summary>
        /// <value>Whether to enable auto minor version upgrade in the restored DB.</value>
        [DataMember(Name="autoMinorVersionUpgrade", EmitDefaultValue=false)]
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityZone
        /// </summary>
        [DataMember(Name="availabilityZone", EmitDefaultValue=false)]
        public EntityProto AvailabilityZone { get; set; }

        /// <summary>
        /// Whether to enable copying of tags to snapshots of the DB.
        /// </summary>
        /// <value>Whether to enable copying of tags to snapshots of the DB.</value>
        [DataMember(Name="copyTagsToSnapshots", EmitDefaultValue=false)]
        public bool? CopyTagsToSnapshots { get; set; }

        /// <summary>
        /// The DB instance identifier to use for the restored DB. This field is required.
        /// </summary>
        /// <value>The DB instance identifier to use for the restored DB. This field is required.</value>
        [DataMember(Name="dbInstanceId", EmitDefaultValue=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets DbOptionGroup
        /// </summary>
        [DataMember(Name="dbOptionGroup", EmitDefaultValue=false)]
        public EntityProto DbOptionGroup { get; set; }

        /// <summary>
        /// Gets or Sets DbParameterGroup
        /// </summary>
        [DataMember(Name="dbParameterGroup", EmitDefaultValue=false)]
        public EntityProto DbParameterGroup { get; set; }

        /// <summary>
        /// Port to use for the DB in the restored RDS instance.
        /// </summary>
        /// <value>Port to use for the DB in the restored RDS instance.</value>
        [DataMember(Name="dbPort", EmitDefaultValue=false)]
        public int? DbPort { get; set; }

        /// <summary>
        /// Whether to enable IAM authentication for the DB.
        /// </summary>
        /// <value>Whether to enable IAM authentication for the DB.</value>
        [DataMember(Name="iamDbAuthentication", EmitDefaultValue=false)]
        public bool? IamDbAuthentication { get; set; }

        /// <summary>
        /// Whether this is a multi-az deployment or not.
        /// </summary>
        /// <value>Whether this is a multi-az deployment or not.</value>
        [DataMember(Name="multiAzDeployment", EmitDefaultValue=false)]
        public bool? MultiAzDeployment { get; set; }

        /// <summary>
        /// Gets or Sets PointInTimeParams
        /// </summary>
        [DataMember(Name="pointInTimeParams", EmitDefaultValue=false)]
        public DeployDBInstancesToRDSParamsPointInTimeRestoreParams PointInTimeParams { get; set; }

        /// <summary>
        /// Whether this DB will be publicly accessible or not.
        /// </summary>
        /// <value>Whether this DB will be publicly accessible or not.</value>
        [DataMember(Name="publicAccessibility", EmitDefaultValue=false)]
        public bool? PublicAccessibility { get; set; }

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
            return this.Equals(input as DeployDBInstancesToRDSParams);
        }

        /// <summary>
        /// Returns true if DeployDBInstancesToRDSParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployDBInstancesToRDSParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployDBInstancesToRDSParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoMinorVersionUpgrade == input.AutoMinorVersionUpgrade ||
                    (this.AutoMinorVersionUpgrade != null &&
                    this.AutoMinorVersionUpgrade.Equals(input.AutoMinorVersionUpgrade))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.CopyTagsToSnapshots == input.CopyTagsToSnapshots ||
                    (this.CopyTagsToSnapshots != null &&
                    this.CopyTagsToSnapshots.Equals(input.CopyTagsToSnapshots))
                ) && 
                (
                    this.DbInstanceId == input.DbInstanceId ||
                    (this.DbInstanceId != null &&
                    this.DbInstanceId.Equals(input.DbInstanceId))
                ) && 
                (
                    this.DbOptionGroup == input.DbOptionGroup ||
                    (this.DbOptionGroup != null &&
                    this.DbOptionGroup.Equals(input.DbOptionGroup))
                ) && 
                (
                    this.DbParameterGroup == input.DbParameterGroup ||
                    (this.DbParameterGroup != null &&
                    this.DbParameterGroup.Equals(input.DbParameterGroup))
                ) && 
                (
                    this.DbPort == input.DbPort ||
                    (this.DbPort != null &&
                    this.DbPort.Equals(input.DbPort))
                ) && 
                (
                    this.IamDbAuthentication == input.IamDbAuthentication ||
                    (this.IamDbAuthentication != null &&
                    this.IamDbAuthentication.Equals(input.IamDbAuthentication))
                ) && 
                (
                    this.MultiAzDeployment == input.MultiAzDeployment ||
                    (this.MultiAzDeployment != null &&
                    this.MultiAzDeployment.Equals(input.MultiAzDeployment))
                ) && 
                (
                    this.PointInTimeParams == input.PointInTimeParams ||
                    (this.PointInTimeParams != null &&
                    this.PointInTimeParams.Equals(input.PointInTimeParams))
                ) && 
                (
                    this.PublicAccessibility == input.PublicAccessibility ||
                    (this.PublicAccessibility != null &&
                    this.PublicAccessibility.Equals(input.PublicAccessibility))
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
                if (this.AutoMinorVersionUpgrade != null)
                    hashCode = hashCode * 59 + this.AutoMinorVersionUpgrade.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.CopyTagsToSnapshots != null)
                    hashCode = hashCode * 59 + this.CopyTagsToSnapshots.GetHashCode();
                if (this.DbInstanceId != null)
                    hashCode = hashCode * 59 + this.DbInstanceId.GetHashCode();
                if (this.DbOptionGroup != null)
                    hashCode = hashCode * 59 + this.DbOptionGroup.GetHashCode();
                if (this.DbParameterGroup != null)
                    hashCode = hashCode * 59 + this.DbParameterGroup.GetHashCode();
                if (this.DbPort != null)
                    hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.IamDbAuthentication != null)
                    hashCode = hashCode * 59 + this.IamDbAuthentication.GetHashCode();
                if (this.MultiAzDeployment != null)
                    hashCode = hashCode * 59 + this.MultiAzDeployment.GetHashCode();
                if (this.PointInTimeParams != null)
                    hashCode = hashCode * 59 + this.PointInTimeParams.GetHashCode();
                if (this.PublicAccessibility != null)
                    hashCode = hashCode * 59 + this.PublicAccessibility.GetHashCode();
                return hashCode;
            }
        }

    }

}

