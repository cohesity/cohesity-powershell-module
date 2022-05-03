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
    /// ProtectedObjectPrivileges specifies which protected objects are allowed to be accessed by an app instance.
    /// </summary>
    [DataContract]
    public partial class ProtectedObjectPrivileges :  IEquatable<ProtectedObjectPrivileges>
    {
        /// <summary>
        /// Specifies if all, none or specific protected objects are allowed to be accessed. Specifies if all, none or specific protected objects are allowed to be accessed. kNone - None of the protected objects have access. kAll - All the protected objects have access. kSpecific - Only specific protected objects have access.
        /// </summary>
        /// <value>Specifies if all, none or specific protected objects are allowed to be accessed. Specifies if all, none or specific protected objects are allowed to be accessed. kNone - None of the protected objects have access. kAll - All the protected objects have access. kSpecific - Only specific protected objects have access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectedObjectsprivilegesTypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 2,

            /// <summary>
            /// Enum KSpecific for value: kSpecific
            /// </summary>
            [EnumMember(Value = "kSpecific")]
            KSpecific = 3

        }

        /// <summary>
        /// Specifies if all, none or specific protected objects are allowed to be accessed. Specifies if all, none or specific protected objects are allowed to be accessed. kNone - None of the protected objects have access. kAll - All the protected objects have access. kSpecific - Only specific protected objects have access.
        /// </summary>
        /// <value>Specifies if all, none or specific protected objects are allowed to be accessed. Specifies if all, none or specific protected objects are allowed to be accessed. kNone - None of the protected objects have access. kAll - All the protected objects have access. kSpecific - Only specific protected objects have access.</value>
        [DataMember(Name="protectedObjectsprivilegesType", EmitDefaultValue=false)]
        public ProtectedObjectsprivilegesTypeEnum? ProtectedObjectsprivilegesType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedObjectPrivileges" /> class.
        /// </summary>
        /// <param name="protectedObjectsprivilegesType">Specifies if all, none or specific protected objects are allowed to be accessed. Specifies if all, none or specific protected objects are allowed to be accessed. kNone - None of the protected objects have access. kAll - All the protected objects have access. kSpecific - Only specific protected objects have access..</param>
        /// <param name="protectionSourceIds">Specifies the ids of the protection sources which are allowed to be accessed in case the privilege type is kSpecific..</param>
        public ProtectedObjectPrivileges(ProtectedObjectsprivilegesTypeEnum? protectedObjectsprivilegesType = default(ProtectedObjectsprivilegesTypeEnum?), List<long?> protectionSourceIds = default(List<long?>))
        {
            this.ProtectedObjectsprivilegesType = protectedObjectsprivilegesType;
            this.ProtectionSourceIds = protectionSourceIds;
        }
        

        /// <summary>
        /// Specifies the ids of the protection sources which are allowed to be accessed in case the privilege type is kSpecific.
        /// </summary>
        /// <value>Specifies the ids of the protection sources which are allowed to be accessed in case the privilege type is kSpecific.</value>
        [DataMember(Name="protectionSourceIds", EmitDefaultValue=false)]
        public List<long?> ProtectionSourceIds { get; set; }

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
            return this.Equals(input as ProtectedObjectPrivileges);
        }

        /// <summary>
        /// Returns true if ProtectedObjectPrivileges instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedObjectPrivileges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedObjectPrivileges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectedObjectsprivilegesType == input.ProtectedObjectsprivilegesType ||
                    (this.ProtectedObjectsprivilegesType != null &&
                    this.ProtectedObjectsprivilegesType.Equals(input.ProtectedObjectsprivilegesType))
                ) && 
                (
                    this.ProtectionSourceIds == input.ProtectionSourceIds ||
                    this.ProtectionSourceIds != null &&
                    this.ProtectionSourceIds.Equals(input.ProtectionSourceIds)
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
                if (this.ProtectedObjectsprivilegesType != null)
                    hashCode = hashCode * 59 + this.ProtectedObjectsprivilegesType.GetHashCode();
                if (this.ProtectionSourceIds != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

