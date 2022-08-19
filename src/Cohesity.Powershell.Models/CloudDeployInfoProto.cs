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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined. The extension applies to both CloudDeployInfoProto as well as CloudDeployEntity.  CloudDeployInfoProto extension                  Location           Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; aws::CloudDeployInfo::aws_cloud_deploy_info     aws/aws.proto            100 azure::CloudDeployInfo::azure_cloud_deploy_info azure/azure.proto        101 gcp::CloudDeployInfo::gcp_cloud_deploy_info     gcp/gcp.proto            102 aws::ReplicationInfo::aws_replication_info      aws/aws.proto            103 azure::ReplicationInfo::azure_replication_info  azure/azure.proto        104 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;  CloudDeployInfoProto.CloudDeployEntity extension  Location         Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; aws::CloudDeployEntityInfo::aws_cloud_deploy_entity_info aws/aws.proto          100 vmware::RestoreEntityInfo::vmware_cloud_deploy_entity_info vmware/vmware.proto    101 azure::CloudDeployEntityInfo::azure_cloud_deploy_entity_info azure/azure.proto      102 gcp::CloudDeployEntityInfo::gcp_cloud_deploy_entity_info gcp/gcp.proto          103 hyperv::RestoreEntityInfo::hyperv_cloud_deploy_entity_info hyperv/hyperv.proto    104 aws::ReplicationEntityInfo::aws_replication_entity_info aws/aws.proto          105 aws::ReplicationEntityInfo::azure_replication_entity_info azure/azure.proto      106 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class CloudDeployInfoProto :  IEquatable<CloudDeployInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDeployInfoProto" /> class.
        /// </summary>
        /// <param name="cloudDeployEntityVec">Contains the file paths and the information of the entities deployed to cloud..</param>
        /// <param name="isIncremental">Whether this Cloud deploy info is for incremental cloudspin..</param>
        /// <param name="restoreInfo">restoreInfo.</param>
        /// <param name="targetType">Specifies the target type for the task. The field is only valid if the task has got a permit..</param>
        /// <param name="totalBytesTransferredToSource">Total bytes transferred to source..</param>
        /// <param name="type">The type of environment this cloud deploy info pertains to..</param>
        /// <param name="warnings">Warnings if any. These warnings will be propogated to the UI by master..</param>
        public CloudDeployInfoProto(List<CloudDeployInfoProtoCloudDeployEntity> cloudDeployEntityVec = default(List<CloudDeployInfoProtoCloudDeployEntity>), bool? isIncremental = default(bool?), RestoreInfoProto restoreInfo = default(RestoreInfoProto), int? targetType = default(int?), long? totalBytesTransferredToSource = default(long?), int? type = default(int?), List<ErrorProto> warnings = default(List<ErrorProto>))
        {
            this.CloudDeployEntityVec = cloudDeployEntityVec;
            this.IsIncremental = isIncremental;
            this.RestoreInfo = restoreInfo;
            this.TargetType = targetType;
            this.TotalBytesTransferredToSource = totalBytesTransferredToSource;
            this.Type = type;
            this.Warnings = warnings;
        }
        
        /// <summary>
        /// Contains the file paths and the information of the entities deployed to cloud.
        /// </summary>
        /// <value>Contains the file paths and the information of the entities deployed to cloud.</value>
        [DataMember(Name="cloudDeployEntityVec", EmitDefaultValue=true)]
        public List<CloudDeployInfoProtoCloudDeployEntity> CloudDeployEntityVec { get; set; }

        /// <summary>
        /// Whether this Cloud deploy info is for incremental cloudspin.
        /// </summary>
        /// <value>Whether this Cloud deploy info is for incremental cloudspin.</value>
        [DataMember(Name="isIncremental", EmitDefaultValue=true)]
        public bool? IsIncremental { get; set; }

        /// <summary>
        /// Gets or Sets RestoreInfo
        /// </summary>
        [DataMember(Name="restoreInfo", EmitDefaultValue=false)]
        public RestoreInfoProto RestoreInfo { get; set; }

        /// <summary>
        /// Specifies the target type for the task. The field is only valid if the task has got a permit.
        /// </summary>
        /// <value>Specifies the target type for the task. The field is only valid if the task has got a permit.</value>
        [DataMember(Name="targetType", EmitDefaultValue=true)]
        public int? TargetType { get; set; }

        /// <summary>
        /// Total bytes transferred to source.
        /// </summary>
        /// <value>Total bytes transferred to source.</value>
        [DataMember(Name="totalBytesTransferredToSource", EmitDefaultValue=true)]
        public long? TotalBytesTransferredToSource { get; set; }

        /// <summary>
        /// The type of environment this cloud deploy info pertains to.
        /// </summary>
        /// <value>The type of environment this cloud deploy info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Warnings if any. These warnings will be propogated to the UI by master.
        /// </summary>
        /// <value>Warnings if any. These warnings will be propogated to the UI by master.</value>
        [DataMember(Name="warnings", EmitDefaultValue=true)]
        public List<ErrorProto> Warnings { get; set; }

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
            return this.Equals(input as CloudDeployInfoProto);
        }

        /// <summary>
        /// Returns true if CloudDeployInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDeployInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDeployInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudDeployEntityVec == input.CloudDeployEntityVec ||
                    this.CloudDeployEntityVec != null &&
                    input.CloudDeployEntityVec != null &&
                    this.CloudDeployEntityVec.Equals(input.CloudDeployEntityVec)
                ) && 
                (
                    this.IsIncremental == input.IsIncremental ||
                    (this.IsIncremental != null &&
                    this.IsIncremental.Equals(input.IsIncremental))
                ) && 
                (
                    this.RestoreInfo == input.RestoreInfo ||
                    (this.RestoreInfo != null &&
                    this.RestoreInfo.Equals(input.RestoreInfo))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TotalBytesTransferredToSource == input.TotalBytesTransferredToSource ||
                    (this.TotalBytesTransferredToSource != null &&
                    this.TotalBytesTransferredToSource.Equals(input.TotalBytesTransferredToSource))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.Equals(input.Warnings)
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
                if (this.CloudDeployEntityVec != null)
                    hashCode = hashCode * 59 + this.CloudDeployEntityVec.GetHashCode();
                if (this.IsIncremental != null)
                    hashCode = hashCode * 59 + this.IsIncremental.GetHashCode();
                if (this.RestoreInfo != null)
                    hashCode = hashCode * 59 + this.RestoreInfo.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TotalBytesTransferredToSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesTransferredToSource.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                return hashCode;
            }
        }

    }

}

