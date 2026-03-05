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
    /// Specifies the identifiers for an entity
    /// </summary>
    [DataContract]
    public partial class EntityIdentifiers :  IEquatable<EntityIdentifiers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifiers" /> class.
        /// </summary>
        /// <param name="documentationLink">Specifies the link to documentation or additional information about the entity. This URL can be used to access more detailed information, guidelines, or metadata related to the entity id. It helps in understanding the context or usage of the entity id.\&quot;.</param>
        /// <param name="key">Specifies the type of identifier. For example, a Virtual Machine (VM) can be identified through various types of IDs, such as UUID, Managed Object Reference (moref), or other unique identifiers..</param>
        /// <param name="value">Specifies the value of the identifier corresponding to the type specified in the key..</param>
        /// <param name="version">Specifies the version number associated with this EntityIdentifier.</param>
        public EntityIdentifiers(string documentationLink = default(string), string key = default(string), string value = default(string), long? version = default(long?))
        {
            this.DocumentationLink = documentationLink;
            this.Key = key;
            this.Value = value;
            this.Version = version;
            this.DocumentationLink = documentationLink;
            this.Key = key;
            this.Value = value;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies the link to documentation or additional information about the entity. This URL can be used to access more detailed information, guidelines, or metadata related to the entity id. It helps in understanding the context or usage of the entity id.\&quot;
        /// </summary>
        /// <value>Specifies the link to documentation or additional information about the entity. This URL can be used to access more detailed information, guidelines, or metadata related to the entity id. It helps in understanding the context or usage of the entity id.\&quot;</value>
        [DataMember(Name="documentationLink", EmitDefaultValue=true)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// Specifies the type of identifier. For example, a Virtual Machine (VM) can be identified through various types of IDs, such as UUID, Managed Object Reference (moref), or other unique identifiers.
        /// </summary>
        /// <value>Specifies the type of identifier. For example, a Virtual Machine (VM) can be identified through various types of IDs, such as UUID, Managed Object Reference (moref), or other unique identifiers.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies the value of the identifier corresponding to the type specified in the key.
        /// </summary>
        /// <value>Specifies the value of the identifier corresponding to the type specified in the key.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Specifies the version number associated with this EntityIdentifier
        /// </summary>
        /// <value>Specifies the version number associated with this EntityIdentifier</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public long? Version { get; set; }

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
            return this.Equals(input as EntityIdentifiers);
        }

        /// <summary>
        /// Returns true if EntityIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentationLink == input.DocumentationLink ||
                    (this.DocumentationLink != null &&
                    this.DocumentationLink.Equals(input.DocumentationLink))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DocumentationLink != null)
                    hashCode = hashCode * 59 + this.DocumentationLink.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

