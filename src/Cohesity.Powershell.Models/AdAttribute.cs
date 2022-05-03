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
    /// Represnts the information about the AD attribute of the object. It also contains information regarding whether it is system attribute and whether the attribute is equal on both Snapshot and Production AD.
    /// </summary>
    [DataContract]
    public partial class AdAttribute :  IEquatable<AdAttribute>
    {
        /// <summary>
        /// Defines AdAttributeFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdAttributeFlagsEnum
        {
            /// <summary>
            /// Enum KEqual for value: kEqual
            /// </summary>
            [EnumMember(Value = "kEqual")]
            KEqual = 1,

            /// <summary>
            /// Enum KNotEqual for value: kNotEqual
            /// </summary>
            [EnumMember(Value = "kNotEqual")]
            KNotEqual = 2,

            /// <summary>
            /// Enum KNotFound for value: kNotFound
            /// </summary>
            [EnumMember(Value = "kNotFound")]
            KNotFound = 3,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 4,

            /// <summary>
            /// Enum KMultiValue for value: kMultiValue
            /// </summary>
            [EnumMember(Value = "kMultiValue")]
            KMultiValue = 5

        }


        /// <summary>
        /// Specifies the flags related to the attribute of the AD object. &#39;kEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are not equal. &#39;kNotFound&#39; indicates attribute of the AD object is missing from both Snapshot and Production AD. &#39;kSystem&#39; indicates this is system attribute. This can only be updated by the AD internal component. &#39;kMultiValue&#39; indicates that the attribute is mutli-value attribute. This attribute supports mutli-value merge during attribute restore operation.
        /// </summary>
        /// <value>Specifies the flags related to the attribute of the AD object. &#39;kEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are not equal. &#39;kNotFound&#39; indicates attribute of the AD object is missing from both Snapshot and Production AD. &#39;kSystem&#39; indicates this is system attribute. This can only be updated by the AD internal component. &#39;kMultiValue&#39; indicates that the attribute is mutli-value attribute. This attribute supports mutli-value merge during attribute restore operation.</value>
        [DataMember(Name="adAttributeFlags", EmitDefaultValue=false)]
        public List<AdAttributeFlagsEnum> AdAttributeFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAttribute" /> class.
        /// </summary>
        /// <param name="adAttributeFlags">Specifies the flags related to the attribute of the AD object. &#39;kEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the attribute value of AD object from Snapshot and Production AD are not equal. &#39;kNotFound&#39; indicates attribute of the AD object is missing from both Snapshot and Production AD. &#39;kSystem&#39; indicates this is system attribute. This can only be updated by the AD internal component. &#39;kMultiValue&#39; indicates that the attribute is mutli-value attribute. This attribute supports mutli-value merge during attribute restore operation..</param>
        /// <param name="destinationValue">destinationValue.</param>
        /// <param name="errorMessage">Specifies the error message regarding the attribute.</param>
        /// <param name="name">Specifies the name of the attribute of the AD object..</param>
        /// <param name="sameValue">sameValue.</param>
        /// <param name="sourceValue">sourceValue.</param>
        public AdAttribute(List<AdAttributeFlagsEnum> adAttributeFlags = default(List<AdAttributeFlagsEnum>), AttributeValue destinationValue = default(AttributeValue), string errorMessage = default(string), string name = default(string), AttributeValue sameValue = default(AttributeValue), AttributeValue sourceValue = default(AttributeValue))
        {
            this.AdAttributeFlags = adAttributeFlags;
            this.DestinationValue = destinationValue;
            this.ErrorMessage = errorMessage;
            this.Name = name;
            this.SameValue = sameValue;
            this.SourceValue = sourceValue;
        }
        

        /// <summary>
        /// Gets or Sets DestinationValue
        /// </summary>
        [DataMember(Name="destinationValue", EmitDefaultValue=false)]
        public AttributeValue DestinationValue { get; set; }

        /// <summary>
        /// Specifies the error message regarding the attribute
        /// </summary>
        /// <value>Specifies the error message regarding the attribute</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the name of the attribute of the AD object.
        /// </summary>
        /// <value>Specifies the name of the attribute of the AD object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SameValue
        /// </summary>
        [DataMember(Name="sameValue", EmitDefaultValue=false)]
        public AttributeValue SameValue { get; set; }

        /// <summary>
        /// Gets or Sets SourceValue
        /// </summary>
        [DataMember(Name="sourceValue", EmitDefaultValue=false)]
        public AttributeValue SourceValue { get; set; }

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
            return this.Equals(input as AdAttribute);
        }

        /// <summary>
        /// Returns true if AdAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of AdAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdAttributeFlags == input.AdAttributeFlags ||
                    this.AdAttributeFlags != null &&
                    this.AdAttributeFlags.Equals(input.AdAttributeFlags)
                ) && 
                (
                    this.DestinationValue == input.DestinationValue ||
                    (this.DestinationValue != null &&
                    this.DestinationValue.Equals(input.DestinationValue))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SameValue == input.SameValue ||
                    (this.SameValue != null &&
                    this.SameValue.Equals(input.SameValue))
                ) && 
                (
                    this.SourceValue == input.SourceValue ||
                    (this.SourceValue != null &&
                    this.SourceValue.Equals(input.SourceValue))
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
                if (this.AdAttributeFlags != null)
                    hashCode = hashCode * 59 + this.AdAttributeFlags.GetHashCode();
                if (this.DestinationValue != null)
                    hashCode = hashCode * 59 + this.DestinationValue.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SameValue != null)
                    hashCode = hashCode * 59 + this.SameValue.GetHashCode();
                if (this.SourceValue != null)
                    hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                return hashCode;
            }
        }

    }

}

