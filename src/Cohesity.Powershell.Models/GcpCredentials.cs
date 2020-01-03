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
    /// Specifies the credentials to authenticate with Google Cloud Platform.
    /// </summary>
    [DataContract]
    public partial class GcpCredentials :  IEquatable<GcpCredentials>
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
        /// Initializes a new instance of the <see cref="GcpCredentials" /> class.
        /// </summary>
        /// <param name="clientEmailAddress">Specifies Client email address associated with the service account..</param>
        /// <param name="clientPrivateKey">Specifies Client private associated with the service account..</param>
        /// <param name="gcpType">Specifies the entity type such as &#39;kIAMUser&#39; if the environment is kGCP. Specifies the type of a GCP source entity. &#39;kIAMUser&#39; indicates a unique user within a GCP account. &#39;kProject&#39; represents compute resources and storage. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kVirtualMachine&#39; indicates a Virtual Machine running in GCP environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within GCP. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kLabel&#39; represents a label present on the instances. &#39;kMetaData&#39; represents a custom metadata present on instances. &#39;kTag&#39; represents a network tag on instances. &#39;kVPCConnector&#39; represents a VPC connector used for serverless VPC access..</param>
        /// <param name="projectId">Specifies Id of the project associated with Google cloud account..</param>
        /// <param name="vpcNetwork">Specifies the VPC Network to deploy proxy VMs..</param>
        /// <param name="vpcSubnetwork">Specifies the subnetwork to deploy proxy VMs..</param>
        public GcpCredentials(string clientEmailAddress = default(string), string clientPrivateKey = default(string), GcpTypeEnum? gcpType = default(GcpTypeEnum?), string projectId = default(string), string vpcNetwork = default(string), string vpcSubnetwork = default(string))
        {
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.GcpType = gcpType;
            this.ProjectId = projectId;
            this.VpcNetwork = vpcNetwork;
            this.VpcSubnetwork = vpcSubnetwork;
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.GcpType = gcpType;
            this.ProjectId = projectId;
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
        /// Specifies Id of the project associated with Google cloud account.
        /// </summary>
        /// <value>Specifies Id of the project associated with Google cloud account.</value>
        [DataMember(Name="projectId", EmitDefaultValue=true)]
        public string ProjectId { get; set; }

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
            return this.Equals(input as GcpCredentials);
        }

        /// <summary>
        /// Returns true if GcpCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpCredentials input)
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.VpcNetwork != null)
                    hashCode = hashCode * 59 + this.VpcNetwork.GetHashCode();
                if (this.VpcSubnetwork != null)
                    hashCode = hashCode * 59 + this.VpcSubnetwork.GetHashCode();
                return hashCode;
            }
        }

    }

}

