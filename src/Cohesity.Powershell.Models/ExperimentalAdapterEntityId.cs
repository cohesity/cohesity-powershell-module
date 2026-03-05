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
    /// ExperimentalAdapterEntityId
    /// </summary>
    [DataContract]
    public partial class ExperimentalAdapterEntityId :  IEquatable<ExperimentalAdapterEntityId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalAdapterEntityId" /> class.
        /// </summary>
        /// <param name="idHash">Unique hash for the entity within a source..</param>
        /// <param name="version">Version number associated with the id hash..</param>
        public ExperimentalAdapterEntityId(string idHash = default(string), long? version = default(long?))
        {
            this.IdHash = idHash;
            this.Version = version;
            this.IdHash = idHash;
            this.Version = version;
        }
        
        /// <summary>
        /// Unique hash for the entity within a source.
        /// </summary>
        /// <value>Unique hash for the entity within a source.</value>
        [DataMember(Name="idHash", EmitDefaultValue=true)]
        public string IdHash { get; set; }

        /// <summary>
        /// Version number associated with the id hash.
        /// </summary>
        /// <value>Version number associated with the id hash.</value>
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
            return this.Equals(input as ExperimentalAdapterEntityId);
        }

        /// <summary>
        /// Returns true if ExperimentalAdapterEntityId instances are equal
        /// </summary>
        /// <param name="input">Instance of ExperimentalAdapterEntityId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperimentalAdapterEntityId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdHash == input.IdHash ||
                    (this.IdHash != null &&
                    this.IdHash.Equals(input.IdHash))
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
                if (this.IdHash != null)
                    hashCode = hashCode * 59 + this.IdHash.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

