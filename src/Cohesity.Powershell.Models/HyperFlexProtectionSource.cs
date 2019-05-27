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
    /// Specifies a Storage Snapshot Provider in a HyperFlex environment.
    /// </summary>
    [DataContract]
    public partial class HyperFlexProtectionSource :  IEquatable<HyperFlexProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed Object in a HyperFlex protection source like kServer. Examples of a HyperFlex types include &#39;kServer&#39;. &#39;kServer&#39; indicates HyperFlex server entity.
        /// </summary>
        /// <value>Specifies the type of managed Object in a HyperFlex protection source like kServer. Examples of a HyperFlex types include &#39;kServer&#39;. &#39;kServer&#39; indicates HyperFlex server entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KServer for value: kServer
            /// </summary>
            [EnumMember(Value = "kServer")]
            KServer = 1

        }

        /// <summary>
        /// Specifies the type of managed Object in a HyperFlex protection source like kServer. Examples of a HyperFlex types include &#39;kServer&#39;. &#39;kServer&#39; indicates HyperFlex server entity.
        /// </summary>
        /// <value>Specifies the type of managed Object in a HyperFlex protection source like kServer. Examples of a HyperFlex types include &#39;kServer&#39;. &#39;kServer&#39; indicates HyperFlex server entity.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperFlexProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies a unique name of the Protection Source.</param>
        /// <param name="productVersion">Specifies the product version of the protection source..</param>
        /// <param name="type">Specifies the type of managed Object in a HyperFlex protection source like kServer. Examples of a HyperFlex types include &#39;kServer&#39;. &#39;kServer&#39; indicates HyperFlex server entity..</param>
        /// <param name="uuid">Specifies the uuid of the protection source..</param>
        public HyperFlexProtectionSource(string name = default(string), string productVersion = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.ProductVersion = productVersion;
            this.Type = type;
            this.Uuid = uuid;
            this.Name = name;
            this.ProductVersion = productVersion;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies a unique name of the Protection Source
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the product version of the protection source.
        /// </summary>
        /// <value>Specifies the product version of the protection source.</value>
        [DataMember(Name="productVersion", EmitDefaultValue=true)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// Specifies the uuid of the protection source.
        /// </summary>
        /// <value>Specifies the uuid of the protection source.</value>
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
            return this.Equals(input as HyperFlexProtectionSource);
        }

        /// <summary>
        /// Returns true if HyperFlexProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of HyperFlexProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperFlexProtectionSource input)
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
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

