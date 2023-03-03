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
    /// Specifies an Object containing information about a Salseforce object.
    /// </summary>
    [DataContract]
    public partial class SfdcObject :  IEquatable<SfdcObject>
    {
        /// <summary>
        /// Type of this object Specifies the type of an Universal Data Adapter source entity. &#39;kStandard&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kCustom&#39; indicates a generic object within the UDA environment.
        /// </summary>
        /// <value>Type of this object Specifies the type of an Universal Data Adapter source entity. &#39;kStandard&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kCustom&#39; indicates a generic object within the UDA environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            /// <summary>
            /// Enum KStandard for value: kStandard
            /// </summary>
            [EnumMember(Value = "kStandard")]
            KStandard = 1,

            /// <summary>
            /// Enum KCustom for value: kCustom
            /// </summary>
            [EnumMember(Value = "kCustom")]
            KCustom = 2

        }

        /// <summary>
        /// Type of this object Specifies the type of an Universal Data Adapter source entity. &#39;kStandard&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kCustom&#39; indicates a generic object within the UDA environment.
        /// </summary>
        /// <value>Type of this object Specifies the type of an Universal Data Adapter source entity. &#39;kStandard&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kCustom&#39; indicates a generic object within the UDA environment.</value>
        [DataMember(Name="objectType", EmitDefaultValue=true)]
        public ObjectTypeEnum? ObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcObject" /> class.
        /// </summary>
        /// <param name="objectType">Type of this object Specifies the type of an Universal Data Adapter source entity. &#39;kStandard&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kCustom&#39; indicates a generic object within the UDA environment..</param>
        /// <param name="recordCount">Number of records in this object..</param>
        public SfdcObject(ObjectTypeEnum? objectType = default(ObjectTypeEnum?), int? recordCount = default(int?))
        {
            this.ObjectType = objectType;
            this.RecordCount = recordCount;
            this.ObjectType = objectType;
            this.RecordCount = recordCount;
        }
        
        /// <summary>
        /// Number of records in this object.
        /// </summary>
        /// <value>Number of records in this object.</value>
        [DataMember(Name="recordCount", EmitDefaultValue=true)]
        public int? RecordCount { get; set; }

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
            return this.Equals(input as SfdcObject);
        }

        /// <summary>
        /// Returns true if SfdcObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
                ) && 
                (
                    this.RecordCount == input.RecordCount ||
                    (this.RecordCount != null &&
                    this.RecordCount.Equals(input.RecordCount))
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
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.RecordCount != null)
                    hashCode = hashCode * 59 + this.RecordCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

