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
    public partial class CreatePhysicalClusterParameters :  IEquatable<CreatePhysicalClusterParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhysicalClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePhysicalClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhysicalClusterParameters" /> class.
        /// </summary>
        /// <param name="allowApiBasedFetch">Specifies if API based GET should be enabled for cluster destroy params..</param>
        /// <param name="clusterDestroyHmacKey">Specifies HMAC secret key that will be used to validate OTP used for destroy request. This is b32 format of the HMAC key. This should only be set/modified during cluster creation..</param>
        /// <param name="clusterName">Specifies the name of the new Cluster. (required).</param>
        /// <param name="enableClusterDestroy">Specifies if cluster destroy op is enabled on this cluster. This should only be set/modified during cluster creation..</param>
        /// <param name="encryptionConfig">encryptionConfig.</param>
        /// <param name="ipPreference">Specifies IP preference..</param>
        /// <param name="ipmiConfig">ipmiConfig (required).</param>
        /// <param name="metadataFaultTolerance">Specifies the metadata fault tolerance..</param>
        /// <param name="networkConfig">networkConfig (required).</param>
        /// <param name="nodeConfigs">Specifies the configuration for the nodes in the new cluster. (required).</param>
        /// <param name="trustDomain">Specifies Trust Domain used for Service Identity..</param>
        public CreatePhysicalClusterParameters(bool? allowApiBasedFetch = default(bool?), string clusterDestroyHmacKey = default(string), string clusterName = default(string), bool? enableClusterDestroy = default(bool?), EncryptionConfiguration encryptionConfig = default(EncryptionConfiguration), int? ipPreference = default(int?), IpmiConfiguration ipmiConfig = default(IpmiConfiguration), int? metadataFaultTolerance = default(int?), NetworkConfiguration networkConfig = default(NetworkConfiguration), List<PhysicalNodeConfiguration> nodeConfigs = default(List<PhysicalNodeConfiguration>), string trustDomain = default(string))
        {
            this.AllowApiBasedFetch = allowApiBasedFetch;
            this.ClusterDestroyHmacKey = clusterDestroyHmacKey;
            this.ClusterName = clusterName;
            this.EnableClusterDestroy = enableClusterDestroy;
            this.IpPreference = ipPreference;
            // to ensure "ipmiConfig" is required (not null)
            if (ipmiConfig == null)
            {
                throw new InvalidDataException("ipmiConfig is a required property for CreatePhysicalClusterParameters and cannot be null");
            }
            else
            {
                this.IpmiConfig = ipmiConfig;
            }

            this.MetadataFaultTolerance = metadataFaultTolerance;
            // to ensure "networkConfig" is required (not null)
            if (networkConfig == null)
            {
                throw new InvalidDataException("networkConfig is a required property for CreatePhysicalClusterParameters and cannot be null");
            }
            else
            {
                this.NetworkConfig = networkConfig;
            }

            this.NodeConfigs = nodeConfigs;
            this.EncryptionConfig = encryptionConfig;
            this.TrustDomain = trustDomain;
        }
        
        /// <summary>
        /// Specifies if API based GET should be enabled for cluster destroy params.
        /// </summary>
        /// <value>Specifies if API based GET should be enabled for cluster destroy params.</value>
        [DataMember(Name="allowApiBasedFetch", EmitDefaultValue=true)]
        public bool? AllowApiBasedFetch { get; set; }

        /// <summary>
        /// Specifies HMAC secret key that will be used to validate OTP used for destroy request. This is b32 format of the HMAC key. This should only be set/modified during cluster creation.
        /// </summary>
        /// <value>Specifies HMAC secret key that will be used to validate OTP used for destroy request. This is b32 format of the HMAC key. This should only be set/modified during cluster creation.</value>
        [DataMember(Name="clusterDestroyHmacKey", EmitDefaultValue=true)]
        public string ClusterDestroyHmacKey { get; set; }

        /// <summary>
        /// Specifies the name of the new Cluster.
        /// </summary>
        /// <value>Specifies the name of the new Cluster.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies if cluster destroy op is enabled on this cluster. This should only be set/modified during cluster creation.
        /// </summary>
        /// <value>Specifies if cluster destroy op is enabled on this cluster. This should only be set/modified during cluster creation.</value>
        [DataMember(Name="enableClusterDestroy", EmitDefaultValue=true)]
        public bool? EnableClusterDestroy { get; set; }

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
        /// Gets or Sets IpmiConfig
        /// </summary>
        [DataMember(Name="ipmiConfig", EmitDefaultValue=false)]
        public IpmiConfiguration IpmiConfig { get; set; }

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
        public List<PhysicalNodeConfiguration> NodeConfigs { get; set; }

        /// <summary>
        /// Specifies Trust Domain used for Service Identity.
        /// </summary>
        /// <value>Specifies Trust Domain used for Service Identity.</value>
        [DataMember(Name="trustDomain", EmitDefaultValue=true)]
        public string TrustDomain { get; set; }

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
            return this.Equals(input as CreatePhysicalClusterParameters);
        }

        /// <summary>
        /// Returns true if CreatePhysicalClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePhysicalClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePhysicalClusterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowApiBasedFetch == input.AllowApiBasedFetch ||
                    (this.AllowApiBasedFetch != null &&
                    this.AllowApiBasedFetch.Equals(input.AllowApiBasedFetch))
                ) && 
                (
                    this.ClusterDestroyHmacKey == input.ClusterDestroyHmacKey ||
                    (this.ClusterDestroyHmacKey != null &&
                    this.ClusterDestroyHmacKey.Equals(input.ClusterDestroyHmacKey))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.EnableClusterDestroy == input.EnableClusterDestroy ||
                    (this.EnableClusterDestroy != null &&
                    this.EnableClusterDestroy.Equals(input.EnableClusterDestroy))
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
                    this.IpmiConfig == input.IpmiConfig ||
                    (this.IpmiConfig != null &&
                    this.IpmiConfig.Equals(input.IpmiConfig))
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
                    this.NodeConfigs.Equals(input.NodeConfigs)
                ) && 
                (
                    this.TrustDomain == input.TrustDomain ||
                    (this.TrustDomain != null &&
                    this.TrustDomain.Equals(input.TrustDomain))
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
                if (this.AllowApiBasedFetch != null)
                    hashCode = hashCode * 59 + this.AllowApiBasedFetch.GetHashCode();
                if (this.ClusterDestroyHmacKey != null)
                    hashCode = hashCode * 59 + this.ClusterDestroyHmacKey.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.EnableClusterDestroy != null)
                    hashCode = hashCode * 59 + this.EnableClusterDestroy.GetHashCode();
                if (this.EncryptionConfig != null)
                    hashCode = hashCode * 59 + this.EncryptionConfig.GetHashCode();
                if (this.IpPreference != null)
                    hashCode = hashCode * 59 + this.IpPreference.GetHashCode();
                if (this.IpmiConfig != null)
                    hashCode = hashCode * 59 + this.IpmiConfig.GetHashCode();
                if (this.MetadataFaultTolerance != null)
                    hashCode = hashCode * 59 + this.MetadataFaultTolerance.GetHashCode();
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.NodeConfigs != null)
                    hashCode = hashCode * 59 + this.NodeConfigs.GetHashCode();
                if (this.TrustDomain != null)
                    hashCode = hashCode * 59 + this.TrustDomain.GetHashCode();
                return hashCode;
            }
        }

    }

}

