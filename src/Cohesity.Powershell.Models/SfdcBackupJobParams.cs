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
        /// <param name="auroraClusterInfo">auroraClusterInfo.</param>
        /// <param name="awsIamRole">IAM role used to get access to the Aurora cluster and S3 bucket..</param>
        /// <param name="objectInfoVec">List of details per Sfdc object..</param>
        /// <param name="registeredEntitySfdcParams">registeredEntitySfdcParams.</param>
        /// <param name="s3BucketInfo">s3BucketInfo.</param>
        public SfdcBackupJobParams(AuroraClusterInfo auroraClusterInfo = default(AuroraClusterInfo), string awsIamRole = default(string), List<ObjectLevelParams> objectInfoVec = default(List<ObjectLevelParams>), RegisteredEntitySfdcParams registeredEntitySfdcParams = default(RegisteredEntitySfdcParams), S3BucketInfo s3BucketInfo = default(S3BucketInfo))
        {
            this.AwsIamRole = awsIamRole;
            this.ObjectInfoVec = objectInfoVec;
            this.AuroraClusterInfo = auroraClusterInfo;
            this.AwsIamRole = awsIamRole;
            this.ObjectInfoVec = objectInfoVec;
            this.RegisteredEntitySfdcParams = registeredEntitySfdcParams;
            this.S3BucketInfo = s3BucketInfo;
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
        /// List of details per Sfdc object.
        /// </summary>
        /// <value>List of details per Sfdc object.</value>
        [DataMember(Name="objectInfoVec", EmitDefaultValue=true)]
        public List<ObjectLevelParams> ObjectInfoVec { get; set; }

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
                    this.ObjectInfoVec == input.ObjectInfoVec ||
                    this.ObjectInfoVec != null &&
                    input.ObjectInfoVec != null &&
                    this.ObjectInfoVec.Equals(input.ObjectInfoVec)
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
                if (this.ObjectInfoVec != null)
                    hashCode = hashCode * 59 + this.ObjectInfoVec.GetHashCode();
                if (this.RegisteredEntitySfdcParams != null)
                    hashCode = hashCode * 59 + this.RegisteredEntitySfdcParams.GetHashCode();
                if (this.S3BucketInfo != null)
                    hashCode = hashCode * 59 + this.S3BucketInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

