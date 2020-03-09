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
    /// Specifies a Protection Source in GCP environment.
    /// </summary>
    [DataContract]
    public partial class GcpProtectionSource :  IEquatable<GcpProtectionSource>
    {
        /// <summary>
        /// Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GcpTypeEnum
        {
            /// <summary>
            /// Enum KIAMUser for value: kIAMUser
            /// </summary>
            [EnumMember(Value = "kIAMUser")]
            KIAMUser = 1,

            /// <summary>
            /// Enum KProject for value: kProject
            /// </summary>
            [EnumMember(Value = "kProject")]
            KProject = 2,

            /// <summary>
            /// Enum KRegion for value: kRegion
            /// </summary>
            [EnumMember(Value = "kRegion")]
            KRegion = 3,

            /// <summary>
            /// Enum KAvailabilityZone for value: kAvailabilityZone
            /// </summary>
            [EnumMember(Value = "kAvailabilityZone")]
            KAvailabilityZone = 4,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 5,

            /// <summary>
            /// Enum KVPC for value: kVPC
            /// </summary>
            [EnumMember(Value = "kVPC")]
            KVPC = 6,

            /// <summary>
            /// Enum KSubnet for value: kSubnet
            /// </summary>
            [EnumMember(Value = "kSubnet")]
            KSubnet = 7,

            /// <summary>
            /// Enum KNetworkSecurityGroup for value: kNetworkSecurityGroup
            /// </summary>
            [EnumMember(Value = "kNetworkSecurityGroup")]
            KNetworkSecurityGroup = 8,

            /// <summary>
            /// Enum KInstanceType for value: kInstanceType
            /// </summary>
            [EnumMember(Value = "kInstanceType")]
            KInstanceType = 9,

            /// <summary>
            /// Enum KLabel for value: kLabel
            /// </summary>
            [EnumMember(Value = "kLabel")]
            KLabel = 10,

            /// <summary>
            /// Enum KMetadata for value: kMetadata
            /// </summary>
            [EnumMember(Value = "kMetadata")]
            KMetadata = 11,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 12,

            /// <summary>
            /// Enum KVPCConnector for value: kVPCConnector
            /// </summary>
            [EnumMember(Value = "kVPCConnector")]
            KVPCConnector = 13

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.</value>
        [DataMember(Name="gcpType", EmitDefaultValue=true)]
        public GcpTypeEnum? GcpType { get; set; }
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
        /// Specifies the type of an GCP Protection Source Object such as &#39;kIAMUser&#39;, &#39;kProject&#39;, &#39;kRegion&#39;, etc. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.
        /// </summary>
        /// <value>Specifies the type of an GCP Protection Source Object such as &#39;kIAMUser&#39;, &#39;kProject&#39;, &#39;kRegion&#39;, etc. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KIAMUser for value: kIAMUser
            /// </summary>
            [EnumMember(Value = "kIAMUser")]
            KIAMUser = 1,

            /// <summary>
            /// Enum KProject for value: kProject
            /// </summary>
            [EnumMember(Value = "kProject")]
            KProject = 2,

            /// <summary>
            /// Enum KRegion for value: kRegion
            /// </summary>
            [EnumMember(Value = "kRegion")]
            KRegion = 3,

            /// <summary>
            /// Enum KAvailabilityZone for value: kAvailabilityZone
            /// </summary>
            [EnumMember(Value = "kAvailabilityZone")]
            KAvailabilityZone = 4,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 5,

            /// <summary>
            /// Enum KVPC for value: kVPC
            /// </summary>
            [EnumMember(Value = "kVPC")]
            KVPC = 6,

            /// <summary>
            /// Enum KSubnet for value: kSubnet
            /// </summary>
            [EnumMember(Value = "kSubnet")]
            KSubnet = 7,

            /// <summary>
            /// Enum KNetworkSecurityGroup for value: kNetworkSecurityGroup
            /// </summary>
            [EnumMember(Value = "kNetworkSecurityGroup")]
            KNetworkSecurityGroup = 8,

            /// <summary>
            /// Enum KInstanceType for value: kInstanceType
            /// </summary>
            [EnumMember(Value = "kInstanceType")]
            KInstanceType = 9,

            /// <summary>
            /// Enum KLabel for value: kLabel
            /// </summary>
            [EnumMember(Value = "kLabel")]
            KLabel = 10,

            /// <summary>
            /// Enum KMetadata for value: kMetadata
            /// </summary>
            [EnumMember(Value = "kMetadata")]
            KMetadata = 11,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 12,

            /// <summary>
            /// Enum KVPCConnector for value: kVPCConnector
            /// </summary>
            [EnumMember(Value = "kVPCConnector")]
            KVPCConnector = 13

        }

        /// <summary>
        /// Specifies the type of an GCP Protection Source Object such as &#39;kIAMUser&#39;, &#39;kProject&#39;, &#39;kRegion&#39;, etc. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.
        /// </summary>
        /// <value>Specifies the type of an GCP Protection Source Object such as &#39;kIAMUser&#39;, &#39;kProject&#39;, &#39;kRegion&#39;, etc. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpProtectionSource" /> class.
        /// </summary>
        /// <param name="clientEmailAddress">Specifies Client email address associated with the service account..</param>
        /// <param name="clientPrivateKey">Specifies Client private associated with the service account..</param>
        /// <param name="gcpType">Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access..</param>
        /// <param name="hostType">Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="ipAddressesVM">Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="name">Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set..</param>
        /// <param name="ownerId">Specifies the owner id of the resource in GCP environment. With type, name and ownerId gives a globally unique identity to the GCP entity..</param>
        /// <param name="physicalSourceId">Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host..</param>
        /// <param name="projectId">Specifies the project Id. For the kIAMUser entity this contains the id of the project to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the id of the project the virtual machine belongs to..</param>
        /// <param name="regionId">Specifies the region Id. For the kIAMUser entity this contains the region to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the region the virtual machine belongs to..</param>
        /// <param name="resourceId">Specifies the unique Id of the resource given by the cloud provider..</param>
        /// <param name="restoreTaskId">Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension..</param>
        /// <param name="tagAttributes">Specifies the list of GCP tag attributes..</param>
        /// <param name="type">Specifies the type of an GCP Protection Source Object such as &#39;kIAMUser&#39;, &#39;kProject&#39;, &#39;kRegion&#39;, etc. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access..</param>
        /// <param name="vpcNetwork">Specifies the VPC Network to deploy proxy VMs..</param>
        /// <param name="vpcSubnetwork">Specifies the subnetwork to deploy proxy VMs..</param>
        public GcpProtectionSource(string clientEmailAddress = default(string), string clientPrivateKey = default(string), GcpTypeEnum? gcpType = default(GcpTypeEnum?), HostTypeEnum? hostType = default(HostTypeEnum?), string ipAddressesVM = default(string), string name = default(string), string ownerId = default(string), long? physicalSourceId = default(long?), string projectId = default(string), string regionId = default(string), string resourceId = default(string), long? restoreTaskId = default(long?), List<TagAttribute> tagAttributes = default(List<TagAttribute>), TypeEnum? type = default(TypeEnum?), string vpcNetwork = default(string), string vpcSubnetwork = default(string))
        {
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.GcpType = gcpType;
            this.HostType = hostType;
            this.IpAddressesVM = ipAddressesVM;
            this.Name = name;
            this.OwnerId = ownerId;
            this.PhysicalSourceId = physicalSourceId;
            this.ProjectId = projectId;
            this.RegionId = regionId;
            this.ResourceId = resourceId;
            this.RestoreTaskId = restoreTaskId;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.VpcNetwork = vpcNetwork;
            this.VpcSubnetwork = vpcSubnetwork;
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.GcpType = gcpType;
            this.HostType = hostType;
            this.IpAddressesVM = ipAddressesVM;
            this.Name = name;
            this.OwnerId = ownerId;
            this.PhysicalSourceId = physicalSourceId;
            this.ProjectId = projectId;
            this.RegionId = regionId;
            this.ResourceId = resourceId;
            this.RestoreTaskId = restoreTaskId;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.VpcNetwork = vpcNetwork;
            this.VpcSubnetwork = vpcSubnetwork;
        }
        
        /// <summary>
        /// Specifies Client email address associated with the service account.
        /// </summary>
        /// <value>Specifies Client email address associated with the service account.</value>
        [DataMember(Name="clientEmailAddress", EmitDefaultValue=true)]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// Specifies Client private associated with the service account.
        /// </summary>
        /// <value>Specifies Client private associated with the service account.</value>
        [DataMember(Name="clientPrivateKey", EmitDefaultValue=true)]
        public string ClientPrivateKey { get; set; }

        /// <summary>
        /// Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="ipAddressesVM", EmitDefaultValue=true)]
        public string IpAddressesVM { get; set; }

        /// <summary>
        /// Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.
        /// </summary>
        /// <value>Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the owner id of the resource in GCP environment. With type, name and ownerId gives a globally unique identity to the GCP entity.
        /// </summary>
        /// <value>Specifies the owner id of the resource in GCP environment. With type, name and ownerId gives a globally unique identity to the GCP entity.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.
        /// </summary>
        /// <value>Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.</value>
        [DataMember(Name="physicalSourceId", EmitDefaultValue=true)]
        public long? PhysicalSourceId { get; set; }

        /// <summary>
        /// Specifies the project Id. For the kIAMUser entity this contains the id of the project to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the id of the project the virtual machine belongs to.
        /// </summary>
        /// <value>Specifies the project Id. For the kIAMUser entity this contains the id of the project to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the id of the project the virtual machine belongs to.</value>
        [DataMember(Name="projectId", EmitDefaultValue=true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Specifies the region Id. For the kIAMUser entity this contains the region to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the region the virtual machine belongs to.
        /// </summary>
        /// <value>Specifies the region Id. For the kIAMUser entity this contains the region to be used to deploy proxy VMs. For entities of type kVirtualMachine this contains the region the virtual machine belongs to.</value>
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
        /// Specifies the list of GCP tag attributes.
        /// </summary>
        /// <value>Specifies the list of GCP tag attributes.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=true)]
        public List<TagAttribute> TagAttributes { get; set; }

        /// <summary>
        /// Specifies the VPC Network to deploy proxy VMs.
        /// </summary>
        /// <value>Specifies the VPC Network to deploy proxy VMs.</value>
        [DataMember(Name="vpcNetwork", EmitDefaultValue=true)]
        public string VpcNetwork { get; set; }

        /// <summary>
        /// Specifies the subnetwork to deploy proxy VMs.
        /// </summary>
        /// <value>Specifies the subnetwork to deploy proxy VMs.</value>
        [DataMember(Name="vpcSubnetwork", EmitDefaultValue=true)]
        public string VpcSubnetwork { get; set; }

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
            return this.Equals(input as GcpProtectionSource);
        }

        /// <summary>
        /// Returns true if GcpProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientEmailAddress == input.ClientEmailAddress ||
                    (this.ClientEmailAddress != null &&
                    this.ClientEmailAddress.Equals(input.ClientEmailAddress))
                ) && 
                (
                    this.ClientPrivateKey == input.ClientPrivateKey ||
                    (this.ClientPrivateKey != null &&
                    this.ClientPrivateKey.Equals(input.ClientPrivateKey))
                ) && 
                (
                    this.GcpType == input.GcpType ||
                    this.GcpType.Equals(input.GcpType)
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.IpAddressesVM == input.IpAddressesVM ||
                    (this.IpAddressesVM != null &&
                    this.IpAddressesVM.Equals(input.IpAddressesVM))
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                    this.VpcNetwork == input.VpcNetwork ||
                    (this.VpcNetwork != null &&
                    this.VpcNetwork.Equals(input.VpcNetwork))
                ) && 
                (
                    this.VpcSubnetwork == input.VpcSubnetwork ||
                    (this.VpcSubnetwork != null &&
                    this.VpcSubnetwork.Equals(input.VpcSubnetwork))
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
                if (this.ClientEmailAddress != null)
                    hashCode = hashCode * 59 + this.ClientEmailAddress.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                hashCode = hashCode * 59 + this.GcpType.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IpAddressesVM != null)
                    hashCode = hashCode * 59 + this.IpAddressesVM.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.PhysicalSourceId != null)
                    hashCode = hashCode * 59 + this.PhysicalSourceId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VpcNetwork != null)
                    hashCode = hashCode * 59 + this.VpcNetwork.GetHashCode();
                if (this.VpcSubnetwork != null)
                    hashCode = hashCode * 59 + this.VpcSubnetwork.GetHashCode();
                return hashCode;
            }
        }

    }

}

