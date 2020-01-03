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
    /// Specifies a Protection Source in AWS environment.
    /// </summary>
    [DataContract]
    public partial class AwsProtectionSource :  IEquatable<AwsProtectionSource>
    {
        /// <summary>
        /// Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kAWS. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kAWS. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AwsTypeEnum
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
            KKeyPair = 9,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 10,

            /// <summary>
            /// Enum KRDSOptionGroup for value: kRDSOptionGroup
            /// </summary>
            [EnumMember(Value = "kRDSOptionGroup")]
            KRDSOptionGroup = 11,

            /// <summary>
            /// Enum KRDSParameterGroup for value: kRDSParameterGroup
            /// </summary>
            [EnumMember(Value = "kRDSParameterGroup")]
            KRDSParameterGroup = 12,

            /// <summary>
            /// Enum KRDSInstance for value: kRDSInstance
            /// </summary>
            [EnumMember(Value = "kRDSInstance")]
            KRDSInstance = 13,

            /// <summary>
            /// Enum KRDSSubnet for value: kRDSSubnet
            /// </summary>
            [EnumMember(Value = "kRDSSubnet")]
            KRDSSubnet = 14,

            /// <summary>
            /// Enum KRDSSecurityGroup for value: kRDSSecurityGroup
            /// </summary>
            [EnumMember(Value = "kRDSSecurityGroup")]
            KRDSSecurityGroup = 15,

            /// <summary>
            /// Enum KRDSTag for value: kRDSTag
            /// </summary>
            [EnumMember(Value = "kRDSTag")]
            KRDSTag = 16

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kAWS. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kAWS. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.</value>
        [DataMember(Name="awsType", EmitDefaultValue=true)]
        public AwsTypeEnum? AwsType { get; set; }
        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
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
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the subscription type of AWS such as &#39;kAWSCommercial&#39; or &#39;kAWSGovCloud&#39;. Specifies the subscription type of an AWS source entity. &#39;kAWSCommercial&#39; indicates a standard AWS subscription. &#39;kAWSGovCloud&#39; indicates a govt AWS subscription.
        /// </summary>
        /// <value>Specifies the subscription type of AWS such as &#39;kAWSCommercial&#39; or &#39;kAWSGovCloud&#39;. Specifies the subscription type of an AWS source entity. &#39;kAWSCommercial&#39; indicates a standard AWS subscription. &#39;kAWSGovCloud&#39; indicates a govt AWS subscription.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubscriptionTypeEnum
        {
            /// <summary>
            /// Enum KAWSCommercial for value: kAWSCommercial
            /// </summary>
            [EnumMember(Value = "kAWSCommercial")]
            KAWSCommercial = 1,

            /// <summary>
            /// Enum KAWSGovCloud for value: kAWSGovCloud
            /// </summary>
            [EnumMember(Value = "kAWSGovCloud")]
            KAWSGovCloud = 2

        }

        /// <summary>
        /// Specifies the subscription type of AWS such as &#39;kAWSCommercial&#39; or &#39;kAWSGovCloud&#39;. Specifies the subscription type of an AWS source entity. &#39;kAWSCommercial&#39; indicates a standard AWS subscription. &#39;kAWSGovCloud&#39; indicates a govt AWS subscription.
        /// </summary>
        /// <value>Specifies the subscription type of AWS such as &#39;kAWSCommercial&#39; or &#39;kAWSGovCloud&#39;. Specifies the subscription type of an AWS source entity. &#39;kAWSCommercial&#39; indicates a standard AWS subscription. &#39;kAWSGovCloud&#39; indicates a govt AWS subscription.</value>
        [DataMember(Name="subscriptionType", EmitDefaultValue=true)]
        public SubscriptionTypeEnum? SubscriptionType { get; set; }
        /// <summary>
        /// Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.
        /// </summary>
        /// <value>Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.</value>
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
            KKeyPair = 9,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 10,

            /// <summary>
            /// Enum KRDSOptionGroup for value: kRDSOptionGroup
            /// </summary>
            [EnumMember(Value = "kRDSOptionGroup")]
            KRDSOptionGroup = 11,

            /// <summary>
            /// Enum KRDSParameterGroup for value: kRDSParameterGroup
            /// </summary>
            [EnumMember(Value = "kRDSParameterGroup")]
            KRDSParameterGroup = 12,

            /// <summary>
            /// Enum KRDSInstance for value: kRDSInstance
            /// </summary>
            [EnumMember(Value = "kRDSInstance")]
            KRDSInstance = 13,

            /// <summary>
            /// Enum KRDSSubnet for value: kRDSSubnet
            /// </summary>
            [EnumMember(Value = "kRDSSubnet")]
            KRDSSubnet = 14,

            /// <summary>
            /// Enum KRDSSecurityGroup for value: kRDSSecurityGroup
            /// </summary>
            [EnumMember(Value = "kRDSSecurityGroup")]
            KRDSSecurityGroup = 15,

            /// <summary>
            /// Enum KRDSTag for value: kRDSTag
            /// </summary>
            [EnumMember(Value = "kRDSTag")]
            KRDSTag = 16

        }

        /// <summary>
        /// Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.
        /// </summary>
        /// <value>Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsProtectionSource" /> class.
        /// </summary>
        /// <param name="accessKey">Specifies Access key of the AWS account..</param>
        /// <param name="amazonResourceName">Specifies Amazon Resource Name (owner ID) of the IAM user, act as an unique identifier of as AWS entity..</param>
        /// <param name="awsType">Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kAWS. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance..</param>
        /// <param name="dbEngineId">Specifies DB engine version info of the entity. This is populated only for RDSInstance, RDSOptionGroup and RDSParameterGroup entity types..</param>
        /// <param name="hostType">Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="ipAddresses">Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="name">Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set..</param>
        /// <param name="ownerId">Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity..</param>
        /// <param name="physicalSourceId">Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host..</param>
        /// <param name="regionId">Specifies the region Id of the entity if the entity is an EC2 instance..</param>
        /// <param name="resourceId">Specifies the unique Id of the resource given by the cloud provider..</param>
        /// <param name="restoreTaskId">Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension..</param>
        /// <param name="secretAccessKey">Specifies Secret Access key of the AWS account..</param>
        /// <param name="subscriptionType">Specifies the subscription type of AWS such as &#39;kAWSCommercial&#39; or &#39;kAWSGovCloud&#39;. Specifies the subscription type of an AWS source entity. &#39;kAWSCommercial&#39; indicates a standard AWS subscription. &#39;kAWSGovCloud&#39; indicates a govt AWS subscription..</param>
        /// <param name="tagAttributes">Specifies the list of AWS tag attributes..</param>
        /// <param name="type">Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. &#39;kTag&#39; represents a tag attached to EC2 instance. &#39;kRDSOptionGroup&#39; represents a RDS option group for configuring database features. &#39;kRDSParameterGroup&#39; represents a RDS parameter group. &#39;kRDSInstance&#39; represents a RDS DB instance. &#39;kRDSSubnet&#39; represents a RDS subnet. &#39;kRDSTag&#39; represents a tag attached to RDS instance..</param>
        /// <param name="userAccountId">Specifies the account id derived from the ARN of the user..</param>
        /// <param name="userResourceName">Specifies the Amazon Resource Name (ARN) of the user..</param>
        public AwsProtectionSource(string accessKey = default(string), string amazonResourceName = default(string), AwsTypeEnum? awsType = default(AwsTypeEnum?), string dbEngineId = default(string), HostTypeEnum? hostType = default(HostTypeEnum?), string ipAddresses = default(string), string name = default(string), string ownerId = default(string), long? physicalSourceId = default(long?), string regionId = default(string), string resourceId = default(string), long? restoreTaskId = default(long?), string secretAccessKey = default(string), SubscriptionTypeEnum? subscriptionType = default(SubscriptionTypeEnum?), List<TagAttribute> tagAttributes = default(List<TagAttribute>), TypeEnum? type = default(TypeEnum?), string userAccountId = default(string), string userResourceName = default(string))
        {
            this.AccessKey = accessKey;
            this.AmazonResourceName = amazonResourceName;
            this.AwsType = awsType;
            this.DbEngineId = dbEngineId;
            this.HostType = hostType;
            this.IpAddresses = ipAddresses;
            this.Name = name;
            this.OwnerId = ownerId;
            this.PhysicalSourceId = physicalSourceId;
            this.RegionId = regionId;
            this.ResourceId = resourceId;
            this.RestoreTaskId = restoreTaskId;
            this.SecretAccessKey = secretAccessKey;
            this.SubscriptionType = subscriptionType;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.UserAccountId = userAccountId;
            this.UserResourceName = userResourceName;
            this.AccessKey = accessKey;
            this.AmazonResourceName = amazonResourceName;
            this.AwsType = awsType;
            this.DbEngineId = dbEngineId;
            this.HostType = hostType;
            this.IpAddresses = ipAddresses;
            this.Name = name;
            this.OwnerId = ownerId;
            this.PhysicalSourceId = physicalSourceId;
            this.RegionId = regionId;
            this.ResourceId = resourceId;
            this.RestoreTaskId = restoreTaskId;
            this.SecretAccessKey = secretAccessKey;
            this.SubscriptionType = subscriptionType;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.UserAccountId = userAccountId;
            this.UserResourceName = userResourceName;
        }
        
        /// <summary>
        /// Specifies Access key of the AWS account.
        /// </summary>
        /// <value>Specifies Access key of the AWS account.</value>
        [DataMember(Name="accessKey", EmitDefaultValue=true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Specifies Amazon Resource Name (owner ID) of the IAM user, act as an unique identifier of as AWS entity.
        /// </summary>
        /// <value>Specifies Amazon Resource Name (owner ID) of the IAM user, act as an unique identifier of as AWS entity.</value>
        [DataMember(Name="amazonResourceName", EmitDefaultValue=true)]
        public string AmazonResourceName { get; set; }

        /// <summary>
        /// Specifies DB engine version info of the entity. This is populated only for RDSInstance, RDSOptionGroup and RDSParameterGroup entity types.
        /// </summary>
        /// <value>Specifies DB engine version info of the entity. This is populated only for RDSInstance, RDSOptionGroup and RDSParameterGroup entity types.</value>
        [DataMember(Name="dbEngineId", EmitDefaultValue=true)]
        public string DbEngineId { get; set; }

        /// <summary>
        /// Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="ipAddresses", EmitDefaultValue=true)]
        public string IpAddresses { get; set; }

        /// <summary>
        /// Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.
        /// </summary>
        /// <value>Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity.
        /// </summary>
        /// <value>Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.
        /// </summary>
        /// <value>Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.</value>
        [DataMember(Name="physicalSourceId", EmitDefaultValue=true)]
        public long? PhysicalSourceId { get; set; }

        /// <summary>
        /// Specifies the region Id of the entity if the entity is an EC2 instance.
        /// </summary>
        /// <value>Specifies the region Id of the entity if the entity is an EC2 instance.</value>
        [DataMember(Name="regionId", EmitDefaultValue=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the unique Id of the resource given by the cloud provider.
        /// </summary>
        /// <value>Specifies the unique Id of the resource given by the cloud provider.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension.
        /// </summary>
        /// <value>Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension.</value>
        [DataMember(Name="restoreTaskId", EmitDefaultValue=true)]
        public long? RestoreTaskId { get; set; }

        /// <summary>
        /// Specifies Secret Access key of the AWS account.
        /// </summary>
        /// <value>Specifies Secret Access key of the AWS account.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Specifies the list of AWS tag attributes.
        /// </summary>
        /// <value>Specifies the list of AWS tag attributes.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=true)]
        public List<TagAttribute> TagAttributes { get; set; }

        /// <summary>
        /// Specifies the account id derived from the ARN of the user.
        /// </summary>
        /// <value>Specifies the account id derived from the ARN of the user.</value>
        [DataMember(Name="userAccountId", EmitDefaultValue=true)]
        public string UserAccountId { get; set; }

        /// <summary>
        /// Specifies the Amazon Resource Name (ARN) of the user.
        /// </summary>
        /// <value>Specifies the Amazon Resource Name (ARN) of the user.</value>
        [DataMember(Name="userResourceName", EmitDefaultValue=true)]
        public string UserResourceName { get; set; }

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
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.AmazonResourceName == input.AmazonResourceName ||
                    (this.AmazonResourceName != null &&
                    this.AmazonResourceName.Equals(input.AmazonResourceName))
                ) && 
                (
                    this.AwsType == input.AwsType ||
                    this.AwsType.Equals(input.AwsType)
                ) && 
                (
                    this.DbEngineId == input.DbEngineId ||
                    (this.DbEngineId != null &&
                    this.DbEngineId.Equals(input.DbEngineId))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
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
                    this.PhysicalSourceId == input.PhysicalSourceId ||
                    (this.PhysicalSourceId != null &&
                    this.PhysicalSourceId.Equals(input.PhysicalSourceId))
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
                    this.RestoreTaskId == input.RestoreTaskId ||
                    (this.RestoreTaskId != null &&
                    this.RestoreTaskId.Equals(input.RestoreTaskId))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    (this.SecretAccessKey != null &&
                    this.SecretAccessKey.Equals(input.SecretAccessKey))
                ) && 
                (
                    this.SubscriptionType == input.SubscriptionType ||
                    this.SubscriptionType.Equals(input.SubscriptionType)
                ) && 
                (
                    this.TagAttributes == input.TagAttributes ||
                    this.TagAttributes != null &&
                    input.TagAttributes != null &&
                    this.TagAttributes.SequenceEqual(input.TagAttributes)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.AmazonResourceName != null)
                    hashCode = hashCode * 59 + this.AmazonResourceName.GetHashCode();
                hashCode = hashCode * 59 + this.AwsType.GetHashCode();
                if (this.DbEngineId != null)
                    hashCode = hashCode * 59 + this.DbEngineId.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.PhysicalSourceId != null)
                    hashCode = hashCode * 59 + this.PhysicalSourceId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
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

