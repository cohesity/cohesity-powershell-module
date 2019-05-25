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
    public partial class CreateVirtualClusterParameters :  IEquatable<CreateVirtualClusterParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateVirtualClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualClusterParameters" /> class.
        /// </summary>
        /// <param name="clusterName">Specifies the name of the new Cluster. (required).</param>
        /// <param name="encryptionConfig">encryptionConfig.</param>
        /// <param name="metadataFaultTolerance">Specifies the metadata fault tolerance..</param>
        /// <param name="networkConfig">networkConfig (required).</param>
        /// <param name="nodeConfigs">Specifies the configuration for the nodes in the new cluster. (required).</param>
        public CreateVirtualClusterParameters(string clusterName = default(string), EncryptionConfiguration encryptionConfig = default(EncryptionConfiguration), int? metadataFaultTolerance = default(int?), NetworkConfiguration networkConfig = default(NetworkConfiguration), List<VirtualNodeConfiguration> nodeConfigs = default(List<VirtualNodeConfiguration>))
        {
            this.ClusterName = clusterName;
            this.MetadataFaultTolerance = metadataFaultTolerance;
            // to ensure "networkConfig" is required (not null)
            if (networkConfig == null)
            {
                throw new InvalidDataException("networkConfig is a required property for CreateVirtualClusterParameters and cannot be null");
            }
            else
            {
                this.NetworkConfig = networkConfig;
            }

            this.NodeConfigs = nodeConfigs;
            this.EncryptionConfig = encryptionConfig;
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
        /// Specifies the metadata fault tolerance.
        /// </summary>
        /// <value>Specifies the metadata fault tolerance.</value>
        [DataMember(Name="metadataFaultTolerance", EmitDefaultValue=true)]
        public int? MetadataFaultTolerance { get; set; }

        /// <summary>
        /// Gets or Sets NetworkConfig
        /// </summary>
        [DataMember(Name="networkConfig", EmitDefaultValue=false)]
        public NetworkConfiguration NetworkConfig { get; set; }

        /// <summary>
        /// Specifies the configuration for the nodes in the new cluster.
        /// </summary>
        /// <value>Specifies the configuration for the nodes in the new cluster.</value>
        [DataMember(Name="nodeConfigs", EmitDefaultValue=true)]
        public List<VirtualNodeConfiguration> NodeConfigs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVirtualClusterParameters {\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  EncryptionConfig: ").Append(EncryptionConfig).Append("\n");
            sb.Append("  MetadataFaultTolerance: ").Append(MetadataFaultTolerance).Append("\n");
            sb.Append("  NetworkConfig: ").Append(NetworkConfig).Append("\n");
            sb.Append("  NodeConfigs: ").Append(NodeConfigs).Append("\n");
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
            return this.Equals(input as CreateVirtualClusterParameters);
        }

        /// <summary>
        /// Returns true if CreateVirtualClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateVirtualClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVirtualClusterParameters input)
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
                    this.EncryptionConfig == input.EncryptionConfig ||
                    (this.EncryptionConfig != null &&
                    this.EncryptionConfig.Equals(input.EncryptionConfig))
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
                    this.NodeConfigs == input.NodeConfigs ||
                    this.NodeConfigs != null &&
                    input.NodeConfigs != null &&
                    this.NodeConfigs.SequenceEqual(input.NodeConfigs)
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
                if (this.EncryptionConfig != null)
                    hashCode = hashCode * 59 + this.EncryptionConfig.GetHashCode();
                if (this.MetadataFaultTolerance != null)
                    hashCode = hashCode * 59 + this.MetadataFaultTolerance.GetHashCode();
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.NodeConfigs != null)
                    hashCode = hashCode * 59 + this.NodeConfigs.GetHashCode();
                return hashCode;
            }
        }

    }

}
