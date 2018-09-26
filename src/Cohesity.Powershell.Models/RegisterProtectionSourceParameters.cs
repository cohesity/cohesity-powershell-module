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
    /// RegisterProtectionSourceParameters
    /// </summary>
    [DataContract]
    public partial class RegisterProtectionSourceParameters :  IEquatable<RegisterProtectionSourceParameters>
    {

        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
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
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 5
        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetappTypeEnum
        {
            
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,
            
            /// <summary>
            /// Enum KVserver for value: kVserver
            /// </summary>
            [EnumMember(Value = "kVserver")]
            KVserver = 2,
            
            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 3
        }

        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [DataMember(Name="netappType", EmitDefaultValue=false)]
        public NetappTypeEnum? NetappType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhysicalTypeEnum
        {
            
            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 1,
            
            /// <summary>
            /// Enum KWindowsCluster for value: kWindowsCluster
            /// </summary>
            [EnumMember(Value = "kWindowsCluster")]
            KWindowsCluster = 2
        }

        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [DataMember(Name="physicalType", EmitDefaultValue=false)]
        public PhysicalTypeEnum? PhysicalType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PureTypeEnum
        {
            
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,
            
            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2
        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.</value>
        [DataMember(Name="pureType", EmitDefaultValue=false)]
        public PureTypeEnum? PureType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmwareTypeEnum
        {
            
            /// <summary>
            /// Enum KVCenter for value: kVCenter
            /// </summary>
            [EnumMember(Value = "kVCenter")]
            KVCenter = 1,
            
            /// <summary>
            /// Enum KFolder for value: kFolder
            /// </summary>
            [EnumMember(Value = "kFolder")]
            KFolder = 2,
            
            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,
            
            /// <summary>
            /// Enum KComputeResource for value: kComputeResource
            /// </summary>
            [EnumMember(Value = "kComputeResource")]
            KComputeResource = 4,
            
            /// <summary>
            /// Enum KClusterComputeResource for value: kClusterComputeResource
            /// </summary>
            [EnumMember(Value = "kClusterComputeResource")]
            KClusterComputeResource = 5,
            
            /// <summary>
            /// Enum KResourcePool for value: kResourcePool
            /// </summary>
            [EnumMember(Value = "kResourcePool")]
            KResourcePool = 6,
            
            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 7,
            
            /// <summary>
            /// Enum KHostSystem for value: kHostSystem
            /// </summary>
            [EnumMember(Value = "kHostSystem")]
            KHostSystem = 8,
            
            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 9,
            
            /// <summary>
            /// Enum KVirtualApp for value: kVirtualApp
            /// </summary>
            [EnumMember(Value = "kVirtualApp")]
            KVirtualApp = 10,
            
            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 11,
            
            /// <summary>
            /// Enum KStoragePod for value: kStoragePod
            /// </summary>
            [EnumMember(Value = "kStoragePod")]
            KStoragePod = 12,
            
            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 13,
            
            /// <summary>
            /// Enum KDistributedVirtualPortgroup for value: kDistributedVirtualPortgroup
            /// </summary>
            [EnumMember(Value = "kDistributedVirtualPortgroup")]
            KDistributedVirtualPortgroup = 14,
            
            /// <summary>
            /// Enum KTagCategory for value: kTagCategory
            /// </summary>
            [EnumMember(Value = "kTagCategory")]
            KTagCategory = 15,
            
            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 16
        }

        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.</value>
        [DataMember(Name="vmwareType", EmitDefaultValue=false)]
        public VmwareTypeEnum? VmwareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="environment">Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="forceRegister">forceRegister.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="nasMountCredentials">nasMountCredentials.</param>
        /// <param name="netappType">Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="physicalType">Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster..</param>
        /// <param name="pureType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;..</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="throttlingPolicy">throttlingPolicy.</param>
        /// <param name="throttlingPolicyOverrides">Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vmwareType">Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc..</param>
        public RegisterProtectionSourceParameters(string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), bool? forceRegister = default(bool?), HostTypeEnum? hostType = default(HostTypeEnum?), NASServerCredentials1 nasMountCredentials = default(NASServerCredentials1), NetappTypeEnum? netappType = default(NetappTypeEnum?), string password = default(string), PhysicalTypeEnum? physicalType = default(PhysicalTypeEnum?), PureTypeEnum? pureType = default(PureTypeEnum?), bool? sourceSideDedupEnabled = default(bool?), ThrottlingPolicy_ throttlingPolicy = default(ThrottlingPolicy_), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), string username = default(string), VmwareTypeEnum? vmwareType = default(VmwareTypeEnum?))
        {
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
            this.VmwareType = vmwareType;
        }
        
        /// <summary>
        /// Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.
        /// </summary>
        /// <value>Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }


        /// <summary>
        /// Gets or Sets ForceRegister
        /// </summary>
        [DataMember(Name="forceRegister", EmitDefaultValue=false)]
        public bool? ForceRegister { get; set; }


        /// <summary>
        /// Gets or Sets NasMountCredentials
        /// </summary>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=false)]
        public NASServerCredentials1 NasMountCredentials { get; set; }


        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }



        /// <summary>
        /// This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers).
        /// </summary>
        /// <value>This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers).</value>
        [DataMember(Name="sourceSideDedupEnabled", EmitDefaultValue=false)]
        public bool? SourceSideDedupEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ThrottlingPolicy
        /// </summary>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=false)]
        public ThrottlingPolicy_ ThrottlingPolicy { get; set; }

        /// <summary>
        /// Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.
        /// </summary>
        /// <value>Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.</value>
        [DataMember(Name="throttlingPolicyOverrides", EmitDefaultValue=false)]
        public List<ThrottlingPolicyOverride> ThrottlingPolicyOverrides { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }


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
            return this.Equals(input as RegisterProtectionSourceParameters);
        }

        /// <summary>
        /// Returns true if RegisterProtectionSourceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterProtectionSourceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterProtectionSourceParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.ForceRegister == input.ForceRegister ||
                    (this.ForceRegister != null &&
                    this.ForceRegister.Equals(input.ForceRegister))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.NetappType == input.NetappType ||
                    (this.NetappType != null &&
                    this.NetappType.Equals(input.NetappType))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PhysicalType == input.PhysicalType ||
                    (this.PhysicalType != null &&
                    this.PhysicalType.Equals(input.PhysicalType))
                ) && 
                (
                    this.PureType == input.PureType ||
                    (this.PureType != null &&
                    this.PureType.Equals(input.PureType))
                ) && 
                (
                    this.SourceSideDedupEnabled == input.SourceSideDedupEnabled ||
                    (this.SourceSideDedupEnabled != null &&
                    this.SourceSideDedupEnabled.Equals(input.SourceSideDedupEnabled))
                ) && 
                (
                    this.ThrottlingPolicy == input.ThrottlingPolicy ||
                    (this.ThrottlingPolicy != null &&
                    this.ThrottlingPolicy.Equals(input.ThrottlingPolicy))
                ) && 
                (
                    this.ThrottlingPolicyOverrides == input.ThrottlingPolicyOverrides ||
                    this.ThrottlingPolicyOverrides != null &&
                    this.ThrottlingPolicyOverrides.SequenceEqual(input.ThrottlingPolicyOverrides)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VmwareType == input.VmwareType ||
                    (this.VmwareType != null &&
                    this.VmwareType.Equals(input.VmwareType))
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
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.NetappType != null)
                    hashCode = hashCode * 59 + this.NetappType.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PhysicalType != null)
                    hashCode = hashCode * 59 + this.PhysicalType.GetHashCode();
                if (this.PureType != null)
                    hashCode = hashCode * 59 + this.PureType.GetHashCode();
                if (this.SourceSideDedupEnabled != null)
                    hashCode = hashCode * 59 + this.SourceSideDedupEnabled.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VmwareType != null)
                    hashCode = hashCode * 59 + this.VmwareType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

