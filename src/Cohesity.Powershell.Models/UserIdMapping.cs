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
    /// UserIdMapping
    /// </summary>
    [DataContract]
    public partial class UserIdMapping :  IEquatable<UserIdMapping>
    {
        /// <summary>
        /// Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain.
        /// </summary>
        /// <value>Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KRid for value: kRid
            /// </summary>
            [EnumMember(Value = "kRid")]
            KRid = 1,
            
            /// <summary>
            /// Enum KRfc2307 for value: kRfc2307
            /// </summary>
            [EnumMember(Value = "kRfc2307")]
            KRfc2307 = 2,
            
            /// <summary>
            /// Enum KSfu30 for value: kSfu30
            /// </summary>
            [EnumMember(Value = "kSfu30")]
            KSfu30 = 3,
            
            /// <summary>
            /// Enum KCentrify for value: kCentrify
            /// </summary>
            [EnumMember(Value = "kCentrify")]
            KCentrify = 4,
            
            /// <summary>
            /// Enum KFixed for value: kFixed
            /// </summary>
            [EnumMember(Value = "kFixed")]
            KFixed = 5,
            
            /// <summary>
            /// Enum KCustomAttributes for value: kCustomAttributes
            /// </summary>
            [EnumMember(Value = "kCustomAttributes")]
            KCustomAttributes = 6
        }

        /// <summary>
        /// Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain.
        /// </summary>
        /// <value>Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdMapping" /> class.
        /// </summary>
        /// <param name="centrifyZoneMapping">Specifies a centrify zone when mapping type is set to &#39;kCentrify&#39;. It defines a centrify zone from which the user id mapping info would be derived..</param>
        /// <param name="customAttributesMapping">Specifies the custom attributes when mapping type is set to &#39;kCustomAttributes&#39;. It defines the attribute names to derive the mapping for a user of an Active Directory domain..</param>
        /// <param name="fixedMapping">Specifies the fields when mapping type is set to &#39;kFixed&#39;. It maps all Active Directory users of this domain to a fixed uid, and gid..</param>
        /// <param name="type">Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain..</param>
        public UserIdMapping(CentrifyZone centrifyZoneMapping = default(CentrifyZone), CustomUnixIdAttributes customAttributesMapping = default(CustomUnixIdAttributes), FixedUnixIdMapping fixedMapping = default(FixedUnixIdMapping), TypeEnum? type = default(TypeEnum?))
        {
            this.CentrifyZoneMapping = centrifyZoneMapping;
            this.CustomAttributesMapping = customAttributesMapping;
            this.FixedMapping = fixedMapping;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies a centrify zone when mapping type is set to &#39;kCentrify&#39;. It defines a centrify zone from which the user id mapping info would be derived.
        /// </summary>
        /// <value>Specifies a centrify zone when mapping type is set to &#39;kCentrify&#39;. It defines a centrify zone from which the user id mapping info would be derived.</value>
        [DataMember(Name="centrifyZoneMapping", EmitDefaultValue=false)]
        public CentrifyZone CentrifyZoneMapping { get; set; }

        /// <summary>
        /// Specifies the custom attributes when mapping type is set to &#39;kCustomAttributes&#39;. It defines the attribute names to derive the mapping for a user of an Active Directory domain.
        /// </summary>
        /// <value>Specifies the custom attributes when mapping type is set to &#39;kCustomAttributes&#39;. It defines the attribute names to derive the mapping for a user of an Active Directory domain.</value>
        [DataMember(Name="customAttributesMapping", EmitDefaultValue=false)]
        public CustomUnixIdAttributes CustomAttributesMapping { get; set; }

        /// <summary>
        /// Specifies the fields when mapping type is set to &#39;kFixed&#39;. It maps all Active Directory users of this domain to a fixed uid, and gid.
        /// </summary>
        /// <value>Specifies the fields when mapping type is set to &#39;kFixed&#39;. It maps all Active Directory users of this domain to a fixed uid, and gid.</value>
        [DataMember(Name="fixedMapping", EmitDefaultValue=false)]
        public FixedUnixIdMapping FixedMapping { get; set; }


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
            return this.Equals(input as UserIdMapping);
        }

        /// <summary>
        /// Returns true if UserIdMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CentrifyZoneMapping == input.CentrifyZoneMapping ||
                    (this.CentrifyZoneMapping != null &&
                    this.CentrifyZoneMapping.Equals(input.CentrifyZoneMapping))
                ) && 
                (
                    this.CustomAttributesMapping == input.CustomAttributesMapping ||
                    (this.CustomAttributesMapping != null &&
                    this.CustomAttributesMapping.Equals(input.CustomAttributesMapping))
                ) && 
                (
                    this.FixedMapping == input.FixedMapping ||
                    (this.FixedMapping != null &&
                    this.FixedMapping.Equals(input.FixedMapping))
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
                if (this.CentrifyZoneMapping != null)
                    hashCode = hashCode * 59 + this.CentrifyZoneMapping.GetHashCode();
                if (this.CustomAttributesMapping != null)
                    hashCode = hashCode * 59 + this.CustomAttributesMapping.GetHashCode();
                if (this.FixedMapping != null)
                    hashCode = hashCode * 59 + this.FixedMapping.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

