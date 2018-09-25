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
    /// Specifies information about a logical network interface on a NetApp Vserver. The interface&#39;s IP address is the mount point for a specific data protocol, such as NFS or CIFS.
    /// </summary>
    [DataContract]
    public partial class VserverNetworkInterface :  IEquatable<VserverNetworkInterface>
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
        /// Specifies the set of data protocols supported by this interface. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.
        /// </summary>
        /// <value>Specifies the set of data protocols supported by this interface. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes.</value>
        [DataMember(Name="dataProtocols", EmitDefaultValue=false)]
        public List<DataProtocolsEnum> DataProtocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VserverNetworkInterface" /> class.
        /// </summary>
        /// <param name="dataProtocols">Specifies the set of data protocols supported by this interface. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes..</param>
        /// <param name="ipAddress">Specifies the IP address of this interface..</param>
        /// <param name="name">Specifies the name of this interface..</param>
        public VserverNetworkInterface(List<DataProtocolsEnum> dataProtocols = default(List<DataProtocolsEnum>), string ipAddress = default(string), string name = default(string))
        {
            this.DataProtocols = dataProtocols;
            this.IpAddress = ipAddress;
            this.Name = name;
        }
        

        /// <summary>
        /// Specifies the IP address of this interface.
        /// </summary>
        /// <value>Specifies the IP address of this interface.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Specifies the name of this interface.
        /// </summary>
        /// <value>Specifies the name of this interface.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as VserverNetworkInterface);
        }

        /// <summary>
        /// Returns true if VserverNetworkInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of VserverNetworkInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VserverNetworkInterface input)
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
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

