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
    /// ADUpdateRestoreTaskOptions
    /// </summary>
    [DataContract]
    public partial class ADUpdateRestoreTaskOptions :  IEquatable<ADUpdateRestoreTaskOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADUpdateRestoreTaskOptions" /> class.
        /// </summary>
        /// <param name="objectAttributesParam">objectAttributesParam.</param>
        /// <param name="objectParam">objectParam.</param>
        /// <param name="type">Specifies the AD restore request type..</param>
        public ADUpdateRestoreTaskOptions(ADAttributeRestoreParam objectAttributesParam = default(ADAttributeRestoreParam), ADObjectRestoreParam objectParam = default(ADObjectRestoreParam), int? type = default(int?))
        {
            this.Type = type;
            this.ObjectAttributesParam = objectAttributesParam;
            this.ObjectParam = objectParam;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ObjectAttributesParam
        /// </summary>
        [DataMember(Name="objectAttributesParam", EmitDefaultValue=false)]
        public ADAttributeRestoreParam ObjectAttributesParam { get; set; }

        /// <summary>
        /// Gets or Sets ObjectParam
        /// </summary>
        [DataMember(Name="objectParam", EmitDefaultValue=false)]
        public ADObjectRestoreParam ObjectParam { get; set; }

        /// <summary>
        /// Specifies the AD restore request type.
        /// </summary>
        /// <value>Specifies the AD restore request type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as ADUpdateRestoreTaskOptions);
        }

        /// <summary>
        /// Returns true if ADUpdateRestoreTaskOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ADUpdateRestoreTaskOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADUpdateRestoreTaskOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectAttributesParam == input.ObjectAttributesParam ||
                    (this.ObjectAttributesParam != null &&
                    this.ObjectAttributesParam.Equals(input.ObjectAttributesParam))
                ) && 
                (
                    this.ObjectParam == input.ObjectParam ||
                    (this.ObjectParam != null &&
                    this.ObjectParam.Equals(input.ObjectParam))
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
                if (this.ObjectAttributesParam != null)
                    hashCode = hashCode * 59 + this.ObjectAttributesParam.GetHashCode();
                if (this.ObjectParam != null)
                    hashCode = hashCode * 59 + this.ObjectParam.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

