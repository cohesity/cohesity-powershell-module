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
    /// ObjectLevelParams
    /// </summary>
    [DataContract]
    public partial class ObjectLevelParams :  IEquatable<ObjectLevelParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLevelParams" /> class.
        /// </summary>
        /// <param name="entityId">Entity id of the object..</param>
        /// <param name="excludedFieldsVec">List of the field names that the user excluded in this object..</param>
        public ObjectLevelParams(long? entityId = default(long?), List<string> excludedFieldsVec = default(List<string>))
        {
            this.EntityId = entityId;
            this.ExcludedFieldsVec = excludedFieldsVec;
            this.EntityId = entityId;
            this.ExcludedFieldsVec = excludedFieldsVec;
        }
        
        /// <summary>
        /// Entity id of the object.
        /// </summary>
        /// <value>Entity id of the object.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// List of the field names that the user excluded in this object.
        /// </summary>
        /// <value>List of the field names that the user excluded in this object.</value>
        [DataMember(Name="excludedFieldsVec", EmitDefaultValue=true)]
        public List<string> ExcludedFieldsVec { get; set; }

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
            return this.Equals(input as ObjectLevelParams);
        }

        /// <summary>
        /// Returns true if ObjectLevelParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectLevelParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectLevelParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.ExcludedFieldsVec == input.ExcludedFieldsVec ||
                    this.ExcludedFieldsVec != null &&
                    input.ExcludedFieldsVec != null &&
                    this.ExcludedFieldsVec.SequenceEqual(input.ExcludedFieldsVec)
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.ExcludedFieldsVec != null)
                    hashCode = hashCode * 59 + this.ExcludedFieldsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

