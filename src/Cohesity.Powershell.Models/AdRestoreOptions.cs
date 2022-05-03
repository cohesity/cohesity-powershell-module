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
    /// AdRestoreOptions are the AD specific options for the restore task being updated
    /// </summary>
    [DataContract]
    public partial class AdRestoreOptions :  IEquatable<AdRestoreOptions>
    {
        /// <summary>
        /// Specifies the AD restore request type. Specifies the action type of AD restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kObjects&#39; specifies the user action to restore AD objects from a mounted AD snapshot database. &#39;kObjectAttributes&#39; specifies the user action to restore attributes of an AD object from a mounted AD snapshot database.
        /// </summary>
        /// <value>Specifies the AD restore request type. Specifies the action type of AD restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kObjects&#39; specifies the user action to restore AD objects from a mounted AD snapshot database. &#39;kObjectAttributes&#39; specifies the user action to restore attributes of an AD object from a mounted AD snapshot database.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KObjects for value: kObjects
            /// </summary>
            [EnumMember(Value = "kObjects")]
            KObjects = 2,

            /// <summary>
            /// Enum KObjectAttributes for value: kObjectAttributes
            /// </summary>
            [EnumMember(Value = "kObjectAttributes")]
            KObjectAttributes = 3

        }

        /// <summary>
        /// Specifies the AD restore request type. Specifies the action type of AD restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kObjects&#39; specifies the user action to restore AD objects from a mounted AD snapshot database. &#39;kObjectAttributes&#39; specifies the user action to restore attributes of an AD object from a mounted AD snapshot database.
        /// </summary>
        /// <value>Specifies the AD restore request type. Specifies the action type of AD restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kObjects&#39; specifies the user action to restore AD objects from a mounted AD snapshot database. &#39;kObjectAttributes&#39; specifies the user action to restore attributes of an AD object from a mounted AD snapshot database.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdRestoreOptions" /> class.
        /// </summary>
        /// <param name="objectAttributeParameters">objectAttributeParameters.</param>
        /// <param name="objectParameters">objectParameters.</param>
        /// <param name="type">Specifies the AD restore request type. Specifies the action type of AD restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kObjects&#39; specifies the user action to restore AD objects from a mounted AD snapshot database. &#39;kObjectAttributes&#39; specifies the user action to restore attributes of an AD object from a mounted AD snapshot database..</param>
        public AdRestoreOptions(AdObjectAttributeParameters objectAttributeParameters = default(AdObjectAttributeParameters), AdObjectRestoreParameters objectParameters = default(AdObjectRestoreParameters), TypeEnum? type = default(TypeEnum?))
        {
            this.ObjectAttributeParameters = objectAttributeParameters;
            this.ObjectParameters = objectParameters;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ObjectAttributeParameters
        /// </summary>
        [DataMember(Name="objectAttributeParameters", EmitDefaultValue=false)]
        public AdObjectAttributeParameters ObjectAttributeParameters { get; set; }

        /// <summary>
        /// Gets or Sets ObjectParameters
        /// </summary>
        [DataMember(Name="objectParameters", EmitDefaultValue=false)]
        public AdObjectRestoreParameters ObjectParameters { get; set; }


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
            return this.Equals(input as AdRestoreOptions);
        }

        /// <summary>
        /// Returns true if AdRestoreOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of AdRestoreOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdRestoreOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectAttributeParameters == input.ObjectAttributeParameters ||
                    (this.ObjectAttributeParameters != null &&
                    this.ObjectAttributeParameters.Equals(input.ObjectAttributeParameters))
                ) && 
                (
                    this.ObjectParameters == input.ObjectParameters ||
                    (this.ObjectParameters != null &&
                    this.ObjectParameters.Equals(input.ObjectParameters))
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
                if (this.ObjectAttributeParameters != null)
                    hashCode = hashCode * 59 + this.ObjectAttributeParameters.GetHashCode();
                if (this.ObjectParameters != null)
                    hashCode = hashCode * 59 + this.ObjectParameters.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

