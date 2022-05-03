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
    /// ViewPrivileges specifies which views are allowed to be accessed by an app instance.
    /// </summary>
    [DataContract]
    public partial class ViewPrivileges :  IEquatable<ViewPrivileges>
    {
        /// <summary>
        /// Specifies if all, none or specific views are allowed to be accessed. Specifies if all, none or specific views are allowed to be accessed. kNone - None of the views have access. kAll - All the views have access. kSpecific - Only specific views have access.
        /// </summary>
        /// <value>Specifies if all, none or specific views are allowed to be accessed. Specifies if all, none or specific views are allowed to be accessed. kNone - None of the views have access. kAll - All the views have access. kSpecific - Only specific views have access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivilegesTypeEnum
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
        /// Specifies if all, none or specific views are allowed to be accessed. Specifies if all, none or specific views are allowed to be accessed. kNone - None of the views have access. kAll - All the views have access. kSpecific - Only specific views have access.
        /// </summary>
        /// <value>Specifies if all, none or specific views are allowed to be accessed. Specifies if all, none or specific views are allowed to be accessed. kNone - None of the views have access. kAll - All the views have access. kSpecific - Only specific views have access.</value>
        [DataMember(Name="privilegesType", EmitDefaultValue=false)]
        public PrivilegesTypeEnum? PrivilegesType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPrivileges" /> class.
        /// </summary>
        /// <param name="privilegesType">Specifies if all, none or specific views are allowed to be accessed. Specifies if all, none or specific views are allowed to be accessed. kNone - None of the views have access. kAll - All the views have access. kSpecific - Only specific views have access..</param>
        /// <param name="viewIds">Specifies the ids of the views which are allowed to be accessed in case the privilege type is kSpecific..</param>
        public ViewPrivileges(PrivilegesTypeEnum? privilegesType = default(PrivilegesTypeEnum?), List<long?> viewIds = default(List<long?>))
        {
            this.PrivilegesType = privilegesType;
            this.ViewIds = viewIds;
        }
        

        /// <summary>
        /// Specifies the ids of the views which are allowed to be accessed in case the privilege type is kSpecific.
        /// </summary>
        /// <value>Specifies the ids of the views which are allowed to be accessed in case the privilege type is kSpecific.</value>
        [DataMember(Name="viewIds", EmitDefaultValue=false)]
        public List<long?> ViewIds { get; set; }

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
            return this.Equals(input as ViewPrivileges);
        }

        /// <summary>
        /// Returns true if ViewPrivileges instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewPrivileges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewPrivileges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivilegesType == input.PrivilegesType ||
                    (this.PrivilegesType != null &&
                    this.PrivilegesType.Equals(input.PrivilegesType))
                ) && 
                (
                    this.ViewIds == input.ViewIds ||
                    this.ViewIds != null &&
                    this.ViewIds.Equals(input.ViewIds)
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
                if (this.PrivilegesType != null)
                    hashCode = hashCode * 59 + this.PrivilegesType.GetHashCode();
                if (this.ViewIds != null)
                    hashCode = hashCode * 59 + this.ViewIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

