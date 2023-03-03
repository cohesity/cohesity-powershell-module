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
    /// Message to capture additional backup params for an Sfdc source.  This proto is used in object based protection of Sfdc source.
    /// </summary>
    [DataContract]
    public partial class SfdcBackupSourceParamsProto :  IEquatable<SfdcBackupSourceParamsProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcBackupSourceParamsProto" /> class.
        /// </summary>
        /// <param name="auroraClusterInfo">auroraClusterInfo.</param>
        /// <param name="awsIamRole">IAM role used to get access to the Aurora cluster and S3 bucket..</param>
        /// <param name="excludedObjectIdsVec">List of entity ids of the Sfdc objects that are excluded by the user in object protection..</param>
        /// <param name="objectLevelParamsVec">This list is a mapping between an Sfdc object&#39;s entity Id and the list of field names that user has specified to exclude from this object&#39;s backup..</param>
        /// <param name="s3BucketPrefix">S3 bucket prefix to be used while uploading the data to Aurora-postgres..</param>
        public SfdcBackupSourceParamsProto(AuroraClusterInfo auroraClusterInfo = default(AuroraClusterInfo), string awsIamRole = default(string), List<long> excludedObjectIdsVec = default(List<long>), List<ObjectLevelParams> objectLevelParamsVec = default(List<ObjectLevelParams>), string s3BucketPrefix = default(string))
        {
            this.AwsIamRole = awsIamRole;
            this.ExcludedObjectIdsVec = excludedObjectIdsVec;
            this.ObjectLevelParamsVec = objectLevelParamsVec;
            this.S3BucketPrefix = s3BucketPrefix;
            this.AuroraClusterInfo = auroraClusterInfo;
            this.AwsIamRole = awsIamRole;
            this.ExcludedObjectIdsVec = excludedObjectIdsVec;
            this.ObjectLevelParamsVec = objectLevelParamsVec;
            this.S3BucketPrefix = s3BucketPrefix;
        }
        
        /// <summary>
        /// Gets or Sets AuroraClusterInfo
        /// </summary>
        [DataMember(Name="auroraClusterInfo", EmitDefaultValue=false)]
        public AuroraClusterInfo AuroraClusterInfo { get; set; }

        /// <summary>
        /// IAM role used to get access to the Aurora cluster and S3 bucket.
        /// </summary>
        /// <value>IAM role used to get access to the Aurora cluster and S3 bucket.</value>
        [DataMember(Name="awsIamRole", EmitDefaultValue=true)]
        public string AwsIamRole { get; set; }

        /// <summary>
        /// List of entity ids of the Sfdc objects that are excluded by the user in object protection.
        /// </summary>
        /// <value>List of entity ids of the Sfdc objects that are excluded by the user in object protection.</value>
        [DataMember(Name="excludedObjectIdsVec", EmitDefaultValue=true)]
        public List<long> ExcludedObjectIdsVec { get; set; }

        /// <summary>
        /// This list is a mapping between an Sfdc object&#39;s entity Id and the list of field names that user has specified to exclude from this object&#39;s backup.
        /// </summary>
        /// <value>This list is a mapping between an Sfdc object&#39;s entity Id and the list of field names that user has specified to exclude from this object&#39;s backup.</value>
        [DataMember(Name="objectLevelParamsVec", EmitDefaultValue=true)]
        public List<ObjectLevelParams> ObjectLevelParamsVec { get; set; }

        /// <summary>
        /// S3 bucket prefix to be used while uploading the data to Aurora-postgres.
        /// </summary>
        /// <value>S3 bucket prefix to be used while uploading the data to Aurora-postgres.</value>
        [DataMember(Name="s3BucketPrefix", EmitDefaultValue=true)]
        public string S3BucketPrefix { get; set; }

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
            return this.Equals(input as SfdcBackupSourceParamsProto);
        }

        /// <summary>
        /// Returns true if SfdcBackupSourceParamsProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcBackupSourceParamsProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcBackupSourceParamsProto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ExcludedObjectIdsVec == input.ExcludedObjectIdsVec ||
                    this.ExcludedObjectIdsVec != null &&
                    input.ExcludedObjectIdsVec != null &&
                    this.ExcludedObjectIdsVec.SequenceEqual(input.ExcludedObjectIdsVec)
                ) && 
                (
                    this.ObjectLevelParamsVec == input.ObjectLevelParamsVec ||
                    this.ObjectLevelParamsVec != null &&
                    input.ObjectLevelParamsVec != null &&
                    this.ObjectLevelParamsVec.SequenceEqual(input.ObjectLevelParamsVec)
                ) && 
                (
                    this.S3BucketPrefix == input.S3BucketPrefix ||
                    (this.S3BucketPrefix != null &&
                    this.S3BucketPrefix.Equals(input.S3BucketPrefix))
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
                if (this.AuroraClusterInfo != null)
                    hashCode = hashCode * 59 + this.AuroraClusterInfo.GetHashCode();
                if (this.AwsIamRole != null)
                    hashCode = hashCode * 59 + this.AwsIamRole.GetHashCode();
                if (this.ExcludedObjectIdsVec != null)
                    hashCode = hashCode * 59 + this.ExcludedObjectIdsVec.GetHashCode();
                if (this.ObjectLevelParamsVec != null)
                    hashCode = hashCode * 59 + this.ObjectLevelParamsVec.GetHashCode();
                if (this.S3BucketPrefix != null)
                    hashCode = hashCode * 59 + this.S3BucketPrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}

