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
    /// Contains AWS specific information needed to identify various resources when converting and deploying a VM to AWS.
    /// </summary>
    [DataContract]
    public partial class DeployVMsToAWSParams :  IEquatable<DeployVMsToAWSParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVMsToAWSParams" /> class.
        /// </summary>
        /// <param name="instanceType">instanceType.</param>
        /// <param name="keyPairName">keyPairName.</param>
        /// <param name="networkSecurityGroups">Names of the network security groups within the above VPC. At least one entry should be present..</param>
        /// <param name="region">region.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="vpc">vpc.</param>
        public DeployVMsToAWSParams(EntityProto instanceType = default(EntityProto), EntityProto keyPairName = default(EntityProto), List<EntityProto> networkSecurityGroups = default(List<EntityProto>), EntityProto region = default(EntityProto), EntityProto subnet = default(EntityProto), EntityProto vpc = default(EntityProto))
        {
            this.NetworkSecurityGroups = networkSecurityGroups;
            this.InstanceType = instanceType;
            this.KeyPairName = keyPairName;
            this.NetworkSecurityGroups = networkSecurityGroups;
            this.Region = region;
            this.Subnet = subnet;
            this.Vpc = vpc;
        }
        
        /// <summary>
        /// Gets or Sets InstanceType
        /// </summary>
        [DataMember(Name="instanceType", EmitDefaultValue=false)]
        public EntityProto InstanceType { get; set; }

        /// <summary>
        /// Gets or Sets KeyPairName
        /// </summary>
        [DataMember(Name="keyPairName", EmitDefaultValue=false)]
        public EntityProto KeyPairName { get; set; }

        /// <summary>
        /// Names of the network security groups within the above VPC. At least one entry should be present.
        /// </summary>
        /// <value>Names of the network security groups within the above VPC. At least one entry should be present.</value>
        [DataMember(Name="networkSecurityGroups", EmitDefaultValue=true)]
        public List<EntityProto> NetworkSecurityGroups { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public EntityProto Region { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public EntityProto Subnet { get; set; }

        /// <summary>
        /// Gets or Sets Vpc
        /// </summary>
        [DataMember(Name="vpc", EmitDefaultValue=false)]
        public EntityProto Vpc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeployVMsToAWSParams {\n");
            sb.Append("  InstanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  KeyPairName: ").Append(KeyPairName).Append("\n");
            sb.Append("  NetworkSecurityGroups: ").Append(NetworkSecurityGroups).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Subnet: ").Append(Subnet).Append("\n");
            sb.Append("  Vpc: ").Append(Vpc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as DeployVMsToAWSParams);
        }

        /// <summary>
        /// Returns true if DeployVMsToAWSParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVMsToAWSParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVMsToAWSParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.KeyPairName == input.KeyPairName ||
                    (this.KeyPairName != null &&
                    this.KeyPairName.Equals(input.KeyPairName))
                ) && 
                (
                    this.NetworkSecurityGroups == input.NetworkSecurityGroups ||
                    this.NetworkSecurityGroups != null &&
                    input.NetworkSecurityGroups != null &&
                    this.NetworkSecurityGroups.SequenceEqual(input.NetworkSecurityGroups)
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
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
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.KeyPairName != null)
                    hashCode = hashCode * 59 + this.KeyPairName.GetHashCode();
                if (this.NetworkSecurityGroups != null)
                    hashCode = hashCode * 59 + this.NetworkSecurityGroups.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                return hashCode;
            }
        }

    }

}
