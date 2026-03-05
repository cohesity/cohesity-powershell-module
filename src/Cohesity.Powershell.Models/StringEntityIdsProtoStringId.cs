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
    /// This is enclosed in a message to give the flexibilty to add more fields in future. For eg: software version, date of creation.
    /// </summary>
    [DataContract]
    public partial class StringEntityIdsProtoStringId :  IEquatable<StringEntityIdsProtoStringId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringEntityIdsProtoStringId" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the string entity. This field is used to uniquely distinguish different entities within the system..</param>
        /// <param name="version">Version number associated with the string id. This can be used to track different versions of the entity id over time. The string ID assigned to the an entity may change (infrequently) across software versions..</param>
        public StringEntityIdsProtoStringId(string id = default(string), long? version = default(long?))
        {
            this.Id = id;
            this.Version = version;
            this.Id = id;
            this.Version = version;
        }
        
        /// <summary>
        /// Unique identifier for the string entity. This field is used to uniquely distinguish different entities within the system.
        /// </summary>
        /// <value>Unique identifier for the string entity. This field is used to uniquely distinguish different entities within the system.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Version number associated with the string id. This can be used to track different versions of the entity id over time. The string ID assigned to the an entity may change (infrequently) across software versions.
        /// </summary>
        /// <value>Version number associated with the string id. This can be used to track different versions of the entity id over time. The string ID assigned to the an entity may change (infrequently) across software versions.</value>
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
            return this.Equals(input as StringEntityIdsProtoStringId);
        }

        /// <summary>
        /// Returns true if StringEntityIdsProtoStringId instances are equal
        /// </summary>
        /// <param name="input">Instance of StringEntityIdsProtoStringId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringEntityIdsProtoStringId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

