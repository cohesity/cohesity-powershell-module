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
    /// S3CompatibleProtectionSource
    /// </summary>
    [DataContract]
    public partial class S3CompatibleProtectionSource :  IEquatable<S3CompatibleProtectionSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3CompatibleProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies the instance name of the S3 Compatible entity..</param>
        /// <param name="type">Specifies the type of the managed Object in S3 Compatible Protection Source..</param>
        /// <param name="uuid">Specifies the UUID for the S3 Compatible entity..</param>
        public S3CompatibleProtectionSource(string name = default(string), int? type = default(int?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the instance name of the S3 Compatible entity.
        /// </summary>
        /// <value>Specifies the instance name of the S3 Compatible entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the type of the managed Object in S3 Compatible Protection Source.
        /// </summary>
        /// <value>Specifies the type of the managed Object in S3 Compatible Protection Source.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Specifies the UUID for the S3 Compatible entity.
        /// </summary>
        /// <value>Specifies the UUID for the S3 Compatible entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as S3CompatibleProtectionSource);
        }

        /// <summary>
        /// Returns true if S3CompatibleProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of S3CompatibleProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3CompatibleProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

