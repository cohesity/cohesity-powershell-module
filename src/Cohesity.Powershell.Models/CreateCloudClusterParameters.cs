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
    /// Specifies the parameters needed for creation of a new Cluster.
    /// </summary>
    [DataContract]
    public partial class CreateCloudClusterParameters :  IEquatable<CreateCloudClusterParameters>
    {
        /// <summary>
        /// Specifies the size of the cluster. It is set as Large by default if the parameter is not specified.
        /// </summary>
        /// <value>Specifies the size of the cluster. It is set as Large by default if the parameter is not specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterSizeEnum
        {
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 1,

            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,

            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 3,

            /// <summary>
            /// Enum XLarge for value: XLarge
            /// </summary>
            [EnumMember(Value = "XLarge")]
            XLarge = 4

        }

        /// <summary>
        /// Specifies the size of the cluster. It is set as Large by default if the parameter is not specified.
        /// </summary>
        /// <value>Specifies the size of the cluster. It is set as Large by default if the parameter is not specified.</value>
        [DataMember(Name="clusterSize", EmitDefaultValue=true)]
        public ClusterSizeEnum? ClusterSize { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCloudClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudClusterParameters" /> class.
        /// </summary>
        /// <param name="clusterName">Specifies the name of the new Cluster. (required).</param>
        /// <param name="clusterSize">Specifies the size of the cluster. It is set as Large by default if the parameter is not specified..</param>
        /// <param name="encryptionConfig">encryptionConfig.</param>
        /// <param name="ipPreference">Specifies IP preference..</param>
        /// <param name="metadataFaultTolerance">Specifies the metadata fault tolerance..</param>
        /// <param name="networkConfig">networkConfig (required).</param>
        /// <param name="nodeIps">Specifies the configuration for the nodes in the new cluster. (required).</param>
        public CreateCloudClusterParameters(string clusterName = default(string), ClusterSizeEnum? clusterSize = default(ClusterSizeEnum?), EncryptionConfiguration encryptionConfig = default(EncryptionConfiguration), int? ipPreference = default(int?), int? metadataFaultTolerance = default(int?), CloudNetworkConfiguration networkConfig = default(CloudNetworkConfiguration), List<string> nodeIps = default(List<string>))
        {
            this.ClusterName = clusterName;
            this.ClusterSize = clusterSize;
            this.IpPreference = ipPreference;
            this.MetadataFaultTolerance = metadataFaultTolerance;
            // to ensure "networkConfig" is required (not null)
            if (networkConfig == null)
            {
                throw new InvalidDataException("networkConfig is a required property for CreateCloudClusterParameters and cannot be null");
            }
            else
            {
                this.NetworkConfig = networkConfig;
            }

            this.NodeIps = nodeIps;
            this.ClusterSize = clusterSize;
            this.EncryptionConfig = encryptionConfig;
            this.IpPreference = ipPreference;
            this.MetadataFaultTolerance = metadataFaultTolerance;
        }
        
        /// <summary>
        /// Specifies the name of the new Cluster.
        /// </summary>
        /// <value>Specifies the name of the new Cluster.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionConfig
        /// </summary>
        [DataMember(Name="encryptionConfig", EmitDefaultValue=false)]
        public EncryptionConfiguration EncryptionConfig { get; set; }

        /// <summary>
        /// Specifies IP preference.
        /// </summary>
        /// <value>Specifies IP preference.</value>
        [DataMember(Name="ipPreference", EmitDefaultValue=true)]
        public int? IpPreference { get; set; }

        /// <summary>
        /// Specifies the metadata fault tolerance.
        /// </summary>
        /// <value>Specifies the metadata fault tolerance.</value>
        [DataMember(Name="metadataFaultTolerance", EmitDefaultValue=true)]
        public int? MetadataFaultTolerance { get; set; }

        /// <summary>
        /// Gets or Sets NetworkConfig
        /// </summary>
        [DataMember(Name="networkConfig", EmitDefaultValue=false)]
        public CloudNetworkConfiguration NetworkConfig { get; set; }

        /// <summary>
        /// Specifies the configuration for the nodes in the new cluster.
        /// </summary>
        /// <value>Specifies the configuration for the nodes in the new cluster.</value>
        [DataMember(Name="nodeIps", EmitDefaultValue=true)]
        public List<string> NodeIps { get; set; }

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
            return this.Equals(input as CreateCloudClusterParameters);
        }

        /// <summary>
        /// Returns true if CreateCloudClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCloudClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCloudClusterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.ClusterSize == input.ClusterSize ||
                    this.ClusterSize.Equals(input.ClusterSize)
                ) && 
                (
                    this.EncryptionConfig == input.EncryptionConfig ||
                    (this.EncryptionConfig != null &&
                    this.EncryptionConfig.Equals(input.EncryptionConfig))
                ) && 
                (
                    this.IpPreference == input.IpPreference ||
                    (this.IpPreference != null &&
                    this.IpPreference.Equals(input.IpPreference))
                ) && 
                (
                    this.MetadataFaultTolerance == input.MetadataFaultTolerance ||
                    (this.MetadataFaultTolerance != null &&
                    this.MetadataFaultTolerance.Equals(input.MetadataFaultTolerance))
                ) && 
                (
                    this.NetworkConfig == input.NetworkConfig ||
                    (this.NetworkConfig != null &&
                    this.NetworkConfig.Equals(input.NetworkConfig))
                ) && 
                (
                    this.NodeIps == input.NodeIps ||
                    this.NodeIps != null &&
                    input.NodeIps != null &&
                    this.NodeIps.SequenceEqual(input.NodeIps)
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterSize.GetHashCode();
                if (this.EncryptionConfig != null)
                    hashCode = hashCode * 59 + this.EncryptionConfig.GetHashCode();
                if (this.IpPreference != null)
                    hashCode = hashCode * 59 + this.IpPreference.GetHashCode();
                if (this.MetadataFaultTolerance != null)
                    hashCode = hashCode * 59 + this.MetadataFaultTolerance.GetHashCode();
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                return hashCode;
            }
        }

    }

}

