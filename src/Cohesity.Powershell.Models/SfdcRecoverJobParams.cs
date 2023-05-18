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
    /// SfdcRecoverJobParams
    /// </summary>
    [DataContract]
    public partial class SfdcRecoverJobParams :  IEquatable<SfdcRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcRecoverJobParams" /> class.
        /// </summary>
        /// <param name="auroraClusterInfo">auroraClusterInfo.</param>
        /// <param name="awsIamRole">IAM role used to get access to the Aurora cluster and S3 bucket..</param>
        /// <param name="isAlternateRestore">Flag to specify if this is an alternate source restore..</param>
        /// <param name="overwrite">Whether to overwrite or keep the object if the object being recovered already exists in the destination..</param>
        /// <param name="prevFullSfdcServerTimestampUsecsMap">A map containing prev_full_sfdc_server_timestamp_usecs for the dependent objects..</param>
        /// <param name="restoreChildsObjectVec">restoreChildsObjectVec.</param>
        /// <param name="restoreParentObjectVec">List of parent/child objects that need to be restored..</param>
        /// <param name="runStartTimeUsecs">The time when the corresponding backup run was started..</param>
        /// <param name="s3BucketInfo">s3BucketInfo.</param>
        public SfdcRecoverJobParams(AuroraClusterInfo auroraClusterInfo = default(AuroraClusterInfo), string awsIamRole = default(string), bool? isAlternateRestore = default(bool?), bool? overwrite = default(bool?), List<SfdcRecoverJobParamsPrevFullSfdcServerTimestampUsecsMapEntry> prevFullSfdcServerTimestampUsecsMap = default(List<SfdcRecoverJobParamsPrevFullSfdcServerTimestampUsecsMapEntry>), List<string> restoreChildsObjectVec = default(List<string>), List<string> restoreParentObjectVec = default(List<string>), long? runStartTimeUsecs = default(long?), S3BucketInfo s3BucketInfo = default(S3BucketInfo))
        {
            this.AwsIamRole = awsIamRole;
            this.IsAlternateRestore = isAlternateRestore;
            this.Overwrite = overwrite;
            this.PrevFullSfdcServerTimestampUsecsMap = prevFullSfdcServerTimestampUsecsMap;
            this.RestoreChildsObjectVec = restoreChildsObjectVec;
            this.RestoreParentObjectVec = restoreParentObjectVec;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.AuroraClusterInfo = auroraClusterInfo;
            this.AwsIamRole = awsIamRole;
            this.IsAlternateRestore = isAlternateRestore;
            this.Overwrite = overwrite;
            this.PrevFullSfdcServerTimestampUsecsMap = prevFullSfdcServerTimestampUsecsMap;
            this.RestoreChildsObjectVec = restoreChildsObjectVec;
            this.RestoreParentObjectVec = restoreParentObjectVec;
            this.RunStartTimeUsecs = runStartTimeUsecs;
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
        /// Flag to specify if this is an alternate source restore.
        /// </summary>
        /// <value>Flag to specify if this is an alternate source restore.</value>
        [DataMember(Name="isAlternateRestore", EmitDefaultValue=true)]
        public bool? IsAlternateRestore { get; set; }

        /// <summary>
        /// Whether to overwrite or keep the object if the object being recovered already exists in the destination.
        /// </summary>
        /// <value>Whether to overwrite or keep the object if the object being recovered already exists in the destination.</value>
        [DataMember(Name="overwrite", EmitDefaultValue=true)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// A map containing prev_full_sfdc_server_timestamp_usecs for the dependent objects.
        /// </summary>
        /// <value>A map containing prev_full_sfdc_server_timestamp_usecs for the dependent objects.</value>
        [DataMember(Name="prevFullSfdcServerTimestampUsecsMap", EmitDefaultValue=true)]
        public List<SfdcRecoverJobParamsPrevFullSfdcServerTimestampUsecsMapEntry> PrevFullSfdcServerTimestampUsecsMap { get; set; }

        /// <summary>
        /// Gets or Sets RestoreChildsObjectVec
        /// </summary>
        [DataMember(Name="restoreChildsObjectVec", EmitDefaultValue=true)]
        public List<string> RestoreChildsObjectVec { get; set; }

        /// <summary>
        /// List of parent/child objects that need to be restored.
        /// </summary>
        /// <value>List of parent/child objects that need to be restored.</value>
        [DataMember(Name="restoreParentObjectVec", EmitDefaultValue=true)]
        public List<string> RestoreParentObjectVec { get; set; }

        /// <summary>
        /// The time when the corresponding backup run was started.
        /// </summary>
        /// <value>The time when the corresponding backup run was started.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=true)]
        public long? RunStartTimeUsecs { get; set; }

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
            return this.Equals(input as SfdcRecoverJobParams);
        }

        /// <summary>
        /// Returns true if SfdcRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcRecoverJobParams input)
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
                    this.IsAlternateRestore == input.IsAlternateRestore ||
                    (this.IsAlternateRestore != null &&
                    this.IsAlternateRestore.Equals(input.IsAlternateRestore))
                ) && 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
                ) && 
                (
                    this.PrevFullSfdcServerTimestampUsecsMap == input.PrevFullSfdcServerTimestampUsecsMap ||
                    this.PrevFullSfdcServerTimestampUsecsMap != null &&
                    input.PrevFullSfdcServerTimestampUsecsMap != null &&
                    this.PrevFullSfdcServerTimestampUsecsMap.SequenceEqual(input.PrevFullSfdcServerTimestampUsecsMap)
                ) && 
                (
                    this.RestoreChildsObjectVec == input.RestoreChildsObjectVec ||
                    this.RestoreChildsObjectVec != null &&
                    input.RestoreChildsObjectVec != null &&
                    this.RestoreChildsObjectVec.SequenceEqual(input.RestoreChildsObjectVec)
                ) && 
                (
                    this.RestoreParentObjectVec == input.RestoreParentObjectVec ||
                    this.RestoreParentObjectVec != null &&
                    input.RestoreParentObjectVec != null &&
                    this.RestoreParentObjectVec.SequenceEqual(input.RestoreParentObjectVec)
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
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
                if (this.IsAlternateRestore != null)
                    hashCode = hashCode * 59 + this.IsAlternateRestore.GetHashCode();
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.PrevFullSfdcServerTimestampUsecsMap != null)
                    hashCode = hashCode * 59 + this.PrevFullSfdcServerTimestampUsecsMap.GetHashCode();
                if (this.RestoreChildsObjectVec != null)
                    hashCode = hashCode * 59 + this.RestoreChildsObjectVec.GetHashCode();
                if (this.RestoreParentObjectVec != null)
                    hashCode = hashCode * 59 + this.RestoreParentObjectVec.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                if (this.S3BucketInfo != null)
                    hashCode = hashCode * 59 + this.S3BucketInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

