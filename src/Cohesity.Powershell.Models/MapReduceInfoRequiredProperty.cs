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
    /// A required property represents a property that user must set before invoking a mapreduction instance. e.g., SimpleGrepMapper will require a property named searchPattern to be set.
    /// </summary>
    [DataContract]
    public partial class MapReduceInfoRequiredProperty :  IEquatable<MapReduceInfoRequiredProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInfoRequiredProperty" /> class.
        /// </summary>
        /// <param name="defaultValue">Default Value of the property..</param>
        /// <param name="description">Description of this property.</param>
        /// <param name="isRequired">Whether the property is required or optional..</param>
        /// <param name="name">Name of the property..</param>
        public MapReduceInfoRequiredProperty(string defaultValue = default(string), string description = default(string), bool? isRequired = default(bool?), string name = default(string))
        {
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.IsRequired = isRequired;
            this.Name = name;
        }
        
        /// <summary>
        /// Default Value of the property.
        /// </summary>
        /// <value>Default Value of the property.</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Description of this property
        /// </summary>
        /// <value>Description of this property</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the property is required or optional.
        /// </summary>
        /// <value>Whether the property is required or optional.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Name of the property.
        /// </summary>
        /// <value>Name of the property.</value>
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
            return this.Equals(input as MapReduceInfoRequiredProperty);
        }

        /// <summary>
        /// Returns true if MapReduceInfoRequiredProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInfoRequiredProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInfoRequiredProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
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
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

