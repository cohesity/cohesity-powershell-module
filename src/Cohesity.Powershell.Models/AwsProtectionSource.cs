// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a Protection Source in AWS environment.
    /// </summary>
    [DataContract]
    public partial class AwsProtectionSource :  IEquatable<AwsProtectionSource>
    {
        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,
            
            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2
        }

        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine.
        /// </summary>
        /// <value>Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KIAMUser for value: kIAMUser
            /// </summary>
            [EnumMember(Value = "kIAMUser")]
            KIAMUser = 1,
            
            /// <summary>
            /// Enum KRegion for value: kRegion
            /// </summary>
            [EnumMember(Value = "kRegion")]
            KRegion = 2,
            
            /// <summary>
            /// Enum KAvailabilityZone for value: kAvailabilityZone
            /// </summary>
            [EnumMember(Value = "kAvailabilityZone")]
            KAvailabilityZone = 3,
            
            /// <summary>
            /// Enum KEC2Instance for value: kEC2Instance
            /// </summary>
            [EnumMember(Value = "kEC2Instance")]
            KEC2Instance = 4,
            
            /// <summary>
            /// Enum KVPC for value: kVPC
            /// </summary>
            [EnumMember(Value = "kVPC")]
            KVPC = 5,
            
            /// <summary>
            /// Enum KSubnet for value: kSubnet
            /// </summary>
            [EnumMember(Value = "kSubnet")]
            KSubnet = 6,
            
            /// <summary>
            /// Enum KNetworkSecurityGroup for value: kNetworkSecurityGroup
            /// </summary>
            [EnumMember(Value = "kNetworkSecurityGroup")]
            KNetworkSecurityGroup = 7,
            
            /// <summary>
            /// Enum KInstanceType for value: kInstanceType
            /// </summary>
            [EnumMember(Value = "kInstanceType")]
            KInstanceType = 8,
            
            /// <summary>
            /// Enum KKeyPair for value: kKeyPair
            /// </summary>
            [EnumMember(Value = "kKeyPair")]
            KKeyPair = 9
        }

        /// <summary>
        /// Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine.
        /// </summary>
        /// <value>Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsProtectionSource" /> class.
        /// </summary>
        /// <param name="hostType">Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="ipAddresses">Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="name">Specifies the name of the AWS Object set by the Cloud Provider..</param>
        /// <param name="ownerId">Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity..</param>
        /// <param name="regionId">Specifies the region Id of the entity if the entity is an EC2 instance..</param>
        /// <param name="resourceId">Specifies the unique Id of the resource given by the cloud provider..</param>
        /// <param name="type">Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine..</param>
        /// <param name="userAccountId">Specifies the account id derived from the ARN of the user..</param>
        /// <param name="userResourceName">Specifies the Amazon Resource Name (ARN) of the user..</param>
        public AwsProtectionSource(HostTypeEnum? hostType = default(HostTypeEnum?), string ipAddresses = default(string), string name = default(string), string ownerId = default(string), string regionId = default(string), string resourceId = default(string), TypeEnum? type = default(TypeEnum?), string userAccountId = default(string), string userResourceName = default(string))
        {
            this.HostType = hostType;
            this.IpAddresses = ipAddresses;
            this.Name = name;
            this.OwnerId = ownerId;
            this.RegionId = regionId;
            this.ResourceId = resourceId;
            this.Type = type;
            this.UserAccountId = userAccountId;
            this.UserResourceName = userResourceName;
        }
        

        /// <summary>
        /// Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="ipAddresses", EmitDefaultValue=false)]
        public string IpAddresses { get; set; }

        /// <summary>
        /// Specifies the name of the AWS Object set by the Cloud Provider.
        /// </summary>
        /// <value>Specifies the name of the AWS Object set by the Cloud Provider.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity.
        /// </summary>
        /// <value>Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Specifies the region Id of the entity if the entity is an EC2 instance.
        /// </summary>
        /// <value>Specifies the region Id of the entity if the entity is an EC2 instance.</value>
        [DataMember(Name="regionId", EmitDefaultValue=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the unique Id of the resource given by the cloud provider.
        /// </summary>
        /// <value>Specifies the unique Id of the resource given by the cloud provider.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public string ResourceId { get; set; }


        /// <summary>
        /// Specifies the account id derived from the ARN of the user.
        /// </summary>
        /// <value>Specifies the account id derived from the ARN of the user.</value>
        [DataMember(Name="userAccountId", EmitDefaultValue=false)]
        public string UserAccountId { get; set; }

        /// <summary>
        /// Specifies the Amazon Resource Name (ARN) of the user.
        /// </summary>
        /// <value>Specifies the Amazon Resource Name (ARN) of the user.</value>
        [DataMember(Name="userResourceName", EmitDefaultValue=false)]
        public string UserResourceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as AwsProtectionSource);
        }

        /// <summary>
        /// Returns true if AwsProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    (this.IpAddresses != null &&
                    this.IpAddresses.Equals(input.IpAddresses))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UserAccountId == input.UserAccountId ||
                    (this.UserAccountId != null &&
                    this.UserAccountId.Equals(input.UserAccountId))
                ) && 
                (
                    this.UserResourceName == input.UserResourceName ||
                    (this.UserResourceName != null &&
                    this.UserResourceName.Equals(input.UserResourceName))
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
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserAccountId != null)
                    hashCode = hashCode * 59 + this.UserAccountId.GetHashCode();
                if (this.UserResourceName != null)
                    hashCode = hashCode * 59 + this.UserResourceName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

