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
    /// Specifies information about a NetApp Vserver in a NetApp Protection Source.
    /// </summary>
    [DataContract]
    public partial class NetappVserverInfo :  IEquatable<NetappVserverInfo>
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
        /// Specifies the set of data protocols supported by this Vserver. The kManagement protocol is not supported for this case. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.
        /// </summary>
        /// <value>Specifies the set of data protocols supported by this Vserver. The kManagement protocol is not supported for this case. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.</value>
        [DataMember(Name="dataProtocols", EmitDefaultValue=false)]
        public List<DataProtocolsEnum> DataProtocols { get; set; }
        /// <summary>
        /// Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose.
        /// </summary>
        /// <value>Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KData for value: kData
            /// </summary>
            [EnumMember(Value = "kData")]
            KData = 1,
            
            /// <summary>
            /// Enum KAdmin for value: kAdmin
            /// </summary>
            [EnumMember(Value = "kAdmin")]
            KAdmin = 2,
            
            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 3,
            
            /// <summary>
            /// Enum KNode for value: kNode
            /// </summary>
            [EnumMember(Value = "kNode")]
            KNode = 4,
            
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 5
        }

        /// <summary>
        /// Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose.
        /// </summary>
        /// <value>Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappVserverInfo" /> class.
        /// </summary>
        /// <param name="dataProtocols">Specifies the set of data protocols supported by this Vserver. The kManagement protocol is not supported for this case. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes..</param>
        /// <param name="interfaces">Specifies information about all interfaces on this Vserver..</param>
        /// <param name="rootCifsShare">Specifies the root &#39;c$&#39; CIFS share of this Vserver. If it exists, it can be used to mount all CIFS volumes that are junctioned under &#39;/&#39; on this Vserver..</param>
        /// <param name="type">Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose..</param>
        public NetappVserverInfo(List<DataProtocolsEnum> dataProtocols = default(List<DataProtocolsEnum>), List<VserverNetworkInterface> interfaces = default(List<VserverNetworkInterface>), CifsShareInfo rootCifsShare = default(CifsShareInfo), TypeEnum? type = default(TypeEnum?))
        {
            this.DataProtocols = dataProtocols;
            this.Interfaces = interfaces;
            this.RootCifsShare = rootCifsShare;
            this.Type = type;
        }
        

        /// <summary>
        /// Specifies information about all interfaces on this Vserver.
        /// </summary>
        /// <value>Specifies information about all interfaces on this Vserver.</value>
        [DataMember(Name="interfaces", EmitDefaultValue=false)]
        public List<VserverNetworkInterface> Interfaces { get; set; }

        /// <summary>
        /// Specifies the root &#39;c$&#39; CIFS share of this Vserver. If it exists, it can be used to mount all CIFS volumes that are junctioned under &#39;/&#39; on this Vserver.
        /// </summary>
        /// <value>Specifies the root &#39;c$&#39; CIFS share of this Vserver. If it exists, it can be used to mount all CIFS volumes that are junctioned under &#39;/&#39; on this Vserver.</value>
        [DataMember(Name="rootCifsShare", EmitDefaultValue=false)]
        public CifsShareInfo RootCifsShare { get; set; }


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
            return this.Equals(input as NetappVserverInfo);
        }

        /// <summary>
        /// Returns true if NetappVserverInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetappVserverInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetappVserverInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataProtocols == input.DataProtocols ||
                    this.DataProtocols != null &&
                    this.DataProtocols.SequenceEqual(input.DataProtocols)
                ) && 
                (
                    this.Interfaces == input.Interfaces ||
                    this.Interfaces != null &&
                    this.Interfaces.SequenceEqual(input.Interfaces)
                ) && 
                (
                    this.RootCifsShare == input.RootCifsShare ||
                    (this.RootCifsShare != null &&
                    this.RootCifsShare.Equals(input.RootCifsShare))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DataProtocols != null)
                    hashCode = hashCode * 59 + this.DataProtocols.GetHashCode();
                if (this.Interfaces != null)
                    hashCode = hashCode * 59 + this.Interfaces.GetHashCode();
                if (this.RootCifsShare != null)
                    hashCode = hashCode * 59 + this.RootCifsShare.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

