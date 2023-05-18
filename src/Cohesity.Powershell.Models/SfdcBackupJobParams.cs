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
    /// Message to capture any additional backup params for Group within the Sfdc environment.
    /// </summary>
    [DataContract]
    public partial class SfdcBackupJobParams :  IEquatable<SfdcBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcBackupJobParams" /> class.
        /// </summary>
        /// <param name="accessTokenRefreshTimeUsecs">Last access token refresh time..</param>
        /// <param name="auroraClusterInfo">auroraClusterInfo.</param>
        /// <param name="awsIamRole">IAM role used to get access to the S3 bucket..</param>
        /// <param name="backupDatabaseName">Contains the postgres database name where the org&#39;s data will be backed up..</param>
        /// <param name="objectInfoVec">List of details per Sfdc object..</param>
        /// <param name="previousRunSfdcServerTimestampUsecs">Sfdc Server Time for the previous run.</param>
        /// <param name="registeredEntitySfdcParams">registeredEntitySfdcParams.</param>
        /// <param name="s3BucketInfo">s3BucketInfo.</param>
        /// <param name="sfdcObjectMetadataProtoPath">Path on snapfs where we persist the SfdcObjectMetadata..</param>
        /// <param name="sfdcServerTimestampUsecs">Sfdc Server Time This time is being used as a snapshot time for fetching only incremental records in the next incremental backup..</param>
        /// <param name="tenantId">Contains the DMaaS tenant id..</param>
        public SfdcBackupJobParams(long? accessTokenRefreshTimeUsecs = default(long?), AuroraClusterInfo auroraClusterInfo = default(AuroraClusterInfo), string awsIamRole = default(string), string backupDatabaseName = default(string), List<ObjectLevelParams> objectInfoVec = default(List<ObjectLevelParams>), long? previousRunSfdcServerTimestampUsecs = default(long?), RegisteredEntitySfdcParams registeredEntitySfdcParams = default(RegisteredEntitySfdcParams), S3BucketInfo s3BucketInfo = default(S3BucketInfo), string sfdcObjectMetadataProtoPath = default(string), long? sfdcServerTimestampUsecs = default(long?), string tenantId = default(string))
        {
            this.AccessTokenRefreshTimeUsecs = accessTokenRefreshTimeUsecs;
            this.AwsIamRole = awsIamRole;
            this.BackupDatabaseName = backupDatabaseName;
            this.ObjectInfoVec = objectInfoVec;
            this.PreviousRunSfdcServerTimestampUsecs = previousRunSfdcServerTimestampUsecs;
            this.SfdcObjectMetadataProtoPath = sfdcObjectMetadataProtoPath;
            this.SfdcServerTimestampUsecs = sfdcServerTimestampUsecs;
            this.TenantId = tenantId;
            this.AccessTokenRefreshTimeUsecs = accessTokenRefreshTimeUsecs;
            this.AuroraClusterInfo = auroraClusterInfo;
            this.AwsIamRole = awsIamRole;
            this.BackupDatabaseName = backupDatabaseName;
            this.ObjectInfoVec = objectInfoVec;
            this.PreviousRunSfdcServerTimestampUsecs = previousRunSfdcServerTimestampUsecs;
            this.RegisteredEntitySfdcParams = registeredEntitySfdcParams;
            this.S3BucketInfo = s3BucketInfo;
            this.SfdcObjectMetadataProtoPath = sfdcObjectMetadataProtoPath;
            this.SfdcServerTimestampUsecs = sfdcServerTimestampUsecs;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Last access token refresh time.
        /// </summary>
        /// <value>Last access token refresh time.</value>
        [DataMember(Name="accessTokenRefreshTimeUsecs", EmitDefaultValue=true)]
        public long? AccessTokenRefreshTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets AuroraClusterInfo
        /// </summary>
        [DataMember(Name="auroraClusterInfo", EmitDefaultValue=false)]
        public AuroraClusterInfo AuroraClusterInfo { get; set; }

        /// <summary>
        /// IAM role used to get access to the S3 bucket.
        /// </summary>
        /// <value>IAM role used to get access to the S3 bucket.</value>
        [DataMember(Name="awsIamRole", EmitDefaultValue=true)]
        public string AwsIamRole { get; set; }

        /// <summary>
        /// Contains the postgres database name where the org&#39;s data will be backed up.
        /// </summary>
        /// <value>Contains the postgres database name where the org&#39;s data will be backed up.</value>
        [DataMember(Name="backupDatabaseName", EmitDefaultValue=true)]
        public string BackupDatabaseName { get; set; }

        /// <summary>
        /// List of details per Sfdc object.
        /// </summary>
        /// <value>List of details per Sfdc object.</value>
        [DataMember(Name="objectInfoVec", EmitDefaultValue=true)]
        public List<ObjectLevelParams> ObjectInfoVec { get; set; }

        /// <summary>
        /// Sfdc Server Time for the previous run
        /// </summary>
        /// <value>Sfdc Server Time for the previous run</value>
        [DataMember(Name="previousRunSfdcServerTimestampUsecs", EmitDefaultValue=true)]
        public long? PreviousRunSfdcServerTimestampUsecs { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredEntitySfdcParams
        /// </summary>
        [DataMember(Name="registeredEntitySfdcParams", EmitDefaultValue=false)]
        public RegisteredEntitySfdcParams RegisteredEntitySfdcParams { get; set; }

        /// <summary>
        /// Gets or Sets S3BucketInfo
        /// </summary>
        [DataMember(Name="s3BucketInfo", EmitDefaultValue=false)]
        public S3BucketInfo S3BucketInfo { get; set; }

        /// <summary>
        /// Path on snapfs where we persist the SfdcObjectMetadata.
        /// </summary>
        /// <value>Path on snapfs where we persist the SfdcObjectMetadata.</value>
        [DataMember(Name="sfdcObjectMetadataProtoPath", EmitDefaultValue=true)]
        public string SfdcObjectMetadataProtoPath { get; set; }

        /// <summary>
        /// Sfdc Server Time This time is being used as a snapshot time for fetching only incremental records in the next incremental backup.
        /// </summary>
        /// <value>Sfdc Server Time This time is being used as a snapshot time for fetching only incremental records in the next incremental backup.</value>
        [DataMember(Name="sfdcServerTimestampUsecs", EmitDefaultValue=true)]
        public long? SfdcServerTimestampUsecs { get; set; }

        /// <summary>
        /// Contains the DMaaS tenant id.
        /// </summary>
        /// <value>Contains the DMaaS tenant id.</value>
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
            return this.Equals(input as SfdcBackupJobParams);
        }

        /// <summary>
        /// Returns true if SfdcBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessTokenRefreshTimeUsecs == input.AccessTokenRefreshTimeUsecs ||
                    (this.AccessTokenRefreshTimeUsecs != null &&
                    this.AccessTokenRefreshTimeUsecs.Equals(input.AccessTokenRefreshTimeUsecs))
                ) && 
                (
                    this.AuroraClusterInfo == input.AuroraClusterInfo ||
                    (this.AuroraClusterInfo != null &&
                    this.AuroraClusterInfo.Equals(input.AuroraClusterInfo))
                ) && 
                (
                    this.AwsIamRole == input.AwsIamRole ||
                    (this.AwsIamRole != null &&
                    this.AwsIamRole.Equals(input.AwsIamRole))
                ) && 
                (
                    this.BackupDatabaseName == input.BackupDatabaseName ||
                    (this.BackupDatabaseName != null &&
                    this.BackupDatabaseName.Equals(input.BackupDatabaseName))
                ) && 
                (
                    this.ObjectInfoVec == input.ObjectInfoVec ||
                    this.ObjectInfoVec != null &&
                    input.ObjectInfoVec != null &&
                    this.ObjectInfoVec.SequenceEqual(input.ObjectInfoVec)
                ) && 
                (
                    this.PreviousRunSfdcServerTimestampUsecs == input.PreviousRunSfdcServerTimestampUsecs ||
                    (this.PreviousRunSfdcServerTimestampUsecs != null &&
                    this.PreviousRunSfdcServerTimestampUsecs.Equals(input.PreviousRunSfdcServerTimestampUsecs))
                ) && 
                (
                    this.RegisteredEntitySfdcParams == input.RegisteredEntitySfdcParams ||
                    (this.RegisteredEntitySfdcParams != null &&
                    this.RegisteredEntitySfdcParams.Equals(input.RegisteredEntitySfdcParams))
                ) && 
                (
                    this.S3BucketInfo == input.S3BucketInfo ||
                    (this.S3BucketInfo != null &&
                    this.S3BucketInfo.Equals(input.S3BucketInfo))
                ) && 
                (
                    this.SfdcObjectMetadataProtoPath == input.SfdcObjectMetadataProtoPath ||
                    (this.SfdcObjectMetadataProtoPath != null &&
                    this.SfdcObjectMetadataProtoPath.Equals(input.SfdcObjectMetadataProtoPath))
                ) && 
                (
                    this.SfdcServerTimestampUsecs == input.SfdcServerTimestampUsecs ||
                    (this.SfdcServerTimestampUsecs != null &&
                    this.SfdcServerTimestampUsecs.Equals(input.SfdcServerTimestampUsecs))
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
                if (this.AccessTokenRefreshTimeUsecs != null)
                    hashCode = hashCode * 59 + this.AccessTokenRefreshTimeUsecs.GetHashCode();
                if (this.AuroraClusterInfo != null)
                    hashCode = hashCode * 59 + this.AuroraClusterInfo.GetHashCode();
                if (this.AwsIamRole != null)
                    hashCode = hashCode * 59 + this.AwsIamRole.GetHashCode();
                if (this.BackupDatabaseName != null)
                    hashCode = hashCode * 59 + this.BackupDatabaseName.GetHashCode();
                if (this.ObjectInfoVec != null)
                    hashCode = hashCode * 59 + this.ObjectInfoVec.GetHashCode();
                if (this.PreviousRunSfdcServerTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.PreviousRunSfdcServerTimestampUsecs.GetHashCode();
                if (this.RegisteredEntitySfdcParams != null)
                    hashCode = hashCode * 59 + this.RegisteredEntitySfdcParams.GetHashCode();
                if (this.S3BucketInfo != null)
                    hashCode = hashCode * 59 + this.S3BucketInfo.GetHashCode();
                if (this.SfdcObjectMetadataProtoPath != null)
                    hashCode = hashCode * 59 + this.SfdcObjectMetadataProtoPath.GetHashCode();
                if (this.SfdcServerTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.SfdcServerTimestampUsecs.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

