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
    /// ObjectFieldSelector
    /// </summary>
    [DataContract]
    public partial class ObjectFieldSelector :  IEquatable<ObjectFieldSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFieldSelector" /> class.
        /// </summary>
        /// <param name="apiVersion">Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;..</param>
        /// <param name="fieldPath">Path of the field to select in the specified API version..</param>
        public ObjectFieldSelector(string apiVersion = default(string), string fieldPath = default(string))
        {
            this.ApiVersion = apiVersion;
            this.FieldPath = fieldPath;
            this.ApiVersion = apiVersion;
            this.FieldPath = fieldPath;
        }
        
        /// <summary>
        /// Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;.
        /// </summary>
        /// <value>Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;.</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=true)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Path of the field to select in the specified API version.
        /// </summary>
        /// <value>Path of the field to select in the specified API version.</value>
        [DataMember(Name="fieldPath", EmitDefaultValue=true)]
        public string FieldPath { get; set; }

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
            return this.Equals(input as ObjectFieldSelector);
        }

        /// <summary>
        /// Returns true if ObjectFieldSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectFieldSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectFieldSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.FieldPath == input.FieldPath ||
                    (this.FieldPath != null &&
                    this.FieldPath.Equals(input.FieldPath))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.FieldPath != null)
                    hashCode = hashCode * 59 + this.FieldPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

