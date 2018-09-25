// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a volume in a NetApp cluster.
    /// </summary>
    [DataContract]
    public partial class NetappVolumeInfo :  IEquatable<NetappVolumeInfo>
    {
        /// <summary>
        /// Defines DataProtocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataProtocolsEnum
        {
            
            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 1,
            
            /// <summary>
            /// Enum KCifs for value: kCifs
            /// </summary>
            [EnumMember(Value = "kCifs")]
            KCifs = 2,
            
            /// <summary>
            /// Enum KIscsi for value: kIscsi
            /// </summary>
            [EnumMember(Value = "kIscsi")]
            KIscsi = 3,
            
            /// <summary>
            /// Enum KFc for value: kFc
            /// </summary>
            [EnumMember(Value = "kFc")]
            KFc = 4,
            
            /// <summary>
            /// Enum KFcache for value: kFcache
            /// </summary>
            [EnumMember(Value = "kFcache")]
            KFcache = 5,
            
            /// <summary>
            /// Enum KHttp for value: kHttp
            /// </summary>
            [EnumMember(Value = "kHttp")]
            KHttp = 6,
            
            /// <summary>
            /// Enum KNdmp for value: kNdmp
            /// </summary>
            [EnumMember(Value = "kNdmp")]
            KNdmp = 7,
            
            /// <summary>
            /// Enum KManagement for value: kManagement
            /// </summary>
            [EnumMember(Value = "kManagement")]
            KManagement = 8
        }


        /// <summary>
        /// Specifies the set of data protocols supported by this volume. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.
        /// </summary>
        /// <value>Specifies the set of data protocols supported by this volume. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.</value>
        [DataMember(Name="dataProtocols", EmitDefaultValue=false)]
        public List<DataProtocolsEnum> DataProtocols { get; set; }
        /// <summary>
        /// Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state.
        /// </summary>
        /// <value>Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 1,
            
            /// <summary>
            /// Enum KLoadSharing for value: kLoadSharing
            /// </summary>
            [EnumMember(Value = "kLoadSharing")]
            KLoadSharing = 2,
            
            /// <summary>
            /// Enum KDataProtection for value: kDataProtection
            /// </summary>
            [EnumMember(Value = "kDataProtection")]
            KDataProtection = 3,
            
            /// <summary>
            /// Enum KDataCache for value: kDataCache
            /// </summary>
            [EnumMember(Value = "kDataCache")]
            KDataCache = 4,
            
            /// <summary>
            /// Enum KTmp for value: kTmp
            /// </summary>
            [EnumMember(Value = "kTmp")]
            KTmp = 5,
            
            /// <summary>
            /// Enum KOnline for value: kOnline
            /// </summary>
            [EnumMember(Value = "kOnline")]
            KOnline = 6,

            /// <summary>
            /// Enum KUnknownType for value: kUnknownType
            /// </summary>
            [EnumMember(Value = "kUnknownType")]
            KUnknownType = 7
        }

        /// <summary>
        /// Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state.
        /// </summary>
        /// <value>Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type.
        /// </summary>
        /// <value>Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 1,
            
            /// <summary>
            /// Enum KLoadSharing for value: kLoadSharing
            /// </summary>
            [EnumMember(Value = "kLoadSharing")]
            KLoadSharing = 2,
            
            /// <summary>
            /// Enum KDataProtection for value: kDataProtection
            /// </summary>
            [EnumMember(Value = "kDataProtection")]
            KDataProtection = 3,
            
            /// <summary>
            /// Enum KDataCache for value: kDataCache
            /// </summary>
            [EnumMember(Value = "kDataCache")]
            KDataCache = 4,
            
            /// <summary>
            /// Enum KTmp for value: kTmp
            /// </summary>
            [EnumMember(Value = "kTmp")]
            KTmp = 5,
            
            /// <summary>
            /// Enum KUnknownType for value: kUnknownType
            /// </summary>
            [EnumMember(Value = "kUnknownType")]
            KUnknownType = 6
        }

        /// <summary>
        /// Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type.
        /// </summary>
        /// <value>Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappVolumeInfo" /> class.
        /// </summary>
        /// <param name="aggregateName">Specifies the containing aggregate name of this volume..</param>
        /// <param name="capacityBytes">Specifies the total capacity in bytes of this volume..</param>
        /// <param name="cifsShares">Specifies the set of CIFS Shares exported for this volume..</param>
        /// <param name="creationTimeUsecs">Specifies the creation time of the volume specified in Unix epoch time (in microseconds)..</param>
        /// <param name="dataProtocols">Specifies the set of data protocols supported by this volume. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes..</param>
        /// <param name="exportPolicyName">Specifies the name of the export policy (which defines the access permissions for the mount client) that has been assigned to this volume..</param>
        /// <param name="junctionPath">Specifies the junction path of this volume. This path can be used to mount this volume via protocols such as NFS..</param>
        /// <param name="name">Specifies the name of the NetApp Vserver that this volume belongs to..</param>
        /// <param name="securityInfo">Specifies the security information of this volume..</param>
        /// <param name="state">Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state..</param>
        /// <param name="type">Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type..</param>
        /// <param name="usedBytes">Specifies the total space (in bytes) used in this volume..</param>
        public NetappVolumeInfo(string aggregateName = default(string), long? capacityBytes = default(long?), List<CifsShareInfo> cifsShares = default(List<CifsShareInfo>), long? creationTimeUsecs = default(long?), List<DataProtocolsEnum> dataProtocols = default(List<DataProtocolsEnum>), string exportPolicyName = default(string), string junctionPath = default(string), string name = default(string), VolumeSecurityInfo securityInfo = default(VolumeSecurityInfo), StateEnum? state = default(StateEnum?), TypeEnum? type = default(TypeEnum?), long? usedBytes = default(long?))
        {
            this.AggregateName = aggregateName;
            this.CapacityBytes = capacityBytes;
            this.CifsShares = cifsShares;
            this.CreationTimeUsecs = creationTimeUsecs;
            this.DataProtocols = dataProtocols;
            this.ExportPolicyName = exportPolicyName;
            this.JunctionPath = junctionPath;
            this.Name = name;
            this.SecurityInfo = securityInfo;
            this.State = state;
            this.Type = type;
            this.UsedBytes = usedBytes;
        }
        
        /// <summary>
        /// Specifies the containing aggregate name of this volume.
        /// </summary>
        /// <value>Specifies the containing aggregate name of this volume.</value>
        [DataMember(Name="aggregateName", EmitDefaultValue=false)]
        public string AggregateName { get; set; }

        /// <summary>
        /// Specifies the total capacity in bytes of this volume.
        /// </summary>
        /// <value>Specifies the total capacity in bytes of this volume.</value>
        [DataMember(Name="capacityBytes", EmitDefaultValue=false)]
        public long? CapacityBytes { get; set; }

        /// <summary>
        /// Specifies the set of CIFS Shares exported for this volume.
        /// </summary>
        /// <value>Specifies the set of CIFS Shares exported for this volume.</value>
        [DataMember(Name="cifsShares", EmitDefaultValue=false)]
        public List<CifsShareInfo> CifsShares { get; set; }

        /// <summary>
        /// Specifies the creation time of the volume specified in Unix epoch time (in microseconds).
        /// </summary>
        /// <value>Specifies the creation time of the volume specified in Unix epoch time (in microseconds).</value>
        [DataMember(Name="creationTimeUsecs", EmitDefaultValue=false)]
        public long? CreationTimeUsecs { get; set; }


        /// <summary>
        /// Specifies the name of the export policy (which defines the access permissions for the mount client) that has been assigned to this volume.
        /// </summary>
        /// <value>Specifies the name of the export policy (which defines the access permissions for the mount client) that has been assigned to this volume.</value>
        [DataMember(Name="exportPolicyName", EmitDefaultValue=false)]
        public string ExportPolicyName { get; set; }

        /// <summary>
        /// Specifies the junction path of this volume. This path can be used to mount this volume via protocols such as NFS.
        /// </summary>
        /// <value>Specifies the junction path of this volume. This path can be used to mount this volume via protocols such as NFS.</value>
        [DataMember(Name="junctionPath", EmitDefaultValue=false)]
        public string JunctionPath { get; set; }

        /// <summary>
        /// Specifies the name of the NetApp Vserver that this volume belongs to.
        /// </summary>
        /// <value>Specifies the name of the NetApp Vserver that this volume belongs to.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the security information of this volume.
        /// </summary>
        /// <value>Specifies the security information of this volume.</value>
        [DataMember(Name="securityInfo", EmitDefaultValue=false)]
        public VolumeSecurityInfo SecurityInfo { get; set; }



        /// <summary>
        /// Specifies the total space (in bytes) used in this volume.
        /// </summary>
        /// <value>Specifies the total space (in bytes) used in this volume.</value>
        [DataMember(Name="usedBytes", EmitDefaultValue=false)]
        public long? UsedBytes { get; set; }

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
            return this.Equals(input as NetappVolumeInfo);
        }

        /// <summary>
        /// Returns true if NetappVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetappVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetappVolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregateName == input.AggregateName ||
                    (this.AggregateName != null &&
                    this.AggregateName.Equals(input.AggregateName))
                ) && 
                (
                    this.CapacityBytes == input.CapacityBytes ||
                    (this.CapacityBytes != null &&
                    this.CapacityBytes.Equals(input.CapacityBytes))
                ) && 
                (
                    this.CifsShares == input.CifsShares ||
                    this.CifsShares != null &&
                    this.CifsShares.SequenceEqual(input.CifsShares)
                ) && 
                (
                    this.CreationTimeUsecs == input.CreationTimeUsecs ||
                    (this.CreationTimeUsecs != null &&
                    this.CreationTimeUsecs.Equals(input.CreationTimeUsecs))
                ) && 
                (
                    this.DataProtocols == input.DataProtocols ||
                    this.DataProtocols != null &&
                    this.DataProtocols.SequenceEqual(input.DataProtocols)
                ) && 
                (
                    this.ExportPolicyName == input.ExportPolicyName ||
                    (this.ExportPolicyName != null &&
                    this.ExportPolicyName.Equals(input.ExportPolicyName))
                ) && 
                (
                    this.JunctionPath == input.JunctionPath ||
                    (this.JunctionPath != null &&
                    this.JunctionPath.Equals(input.JunctionPath))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SecurityInfo == input.SecurityInfo ||
                    (this.SecurityInfo != null &&
                    this.SecurityInfo.Equals(input.SecurityInfo))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UsedBytes == input.UsedBytes ||
                    (this.UsedBytes != null &&
                    this.UsedBytes.Equals(input.UsedBytes))
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
                if (this.AggregateName != null)
                    hashCode = hashCode * 59 + this.AggregateName.GetHashCode();
                if (this.CapacityBytes != null)
                    hashCode = hashCode * 59 + this.CapacityBytes.GetHashCode();
                if (this.CifsShares != null)
                    hashCode = hashCode * 59 + this.CifsShares.GetHashCode();
                if (this.CreationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.CreationTimeUsecs.GetHashCode();
                if (this.DataProtocols != null)
                    hashCode = hashCode * 59 + this.DataProtocols.GetHashCode();
                if (this.ExportPolicyName != null)
                    hashCode = hashCode * 59 + this.ExportPolicyName.GetHashCode();
                if (this.JunctionPath != null)
                    hashCode = hashCode * 59 + this.JunctionPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SecurityInfo != null)
                    hashCode = hashCode * 59 + this.SecurityInfo.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UsedBytes != null)
                    hashCode = hashCode * 59 + this.UsedBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

