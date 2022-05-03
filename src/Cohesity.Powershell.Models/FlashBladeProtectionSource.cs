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
    /// Specifies a Protection Source in Pure Storage FlashBlade environment.
    /// </summary>
    [DataContract]
    public partial class FlashBladeProtectionSource :  IEquatable<FlashBladeProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed object in a Pure Storage FlashBlade like &#39;kStorageArray&#39; or &#39;kFileSystem&#39;. &#39;kStorageArray&#39; indicates a top level Pure Storage FlashBlade array. &#39;kFileSystem&#39; indicates a Pure Storage FlashBlade file system within the array.
        /// </summary>
        /// <value>Specifies the type of managed object in a Pure Storage FlashBlade like &#39;kStorageArray&#39; or &#39;kFileSystem&#39;. &#39;kStorageArray&#39; indicates a top level Pure Storage FlashBlade array. &#39;kFileSystem&#39; indicates a Pure Storage FlashBlade file system within the array.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,

            /// <summary>
            /// Enum KFileSystem for value: kFileSystem
            /// </summary>
            [EnumMember(Value = "kFileSystem")]
            KFileSystem = 2

        }

        /// <summary>
        /// Specifies the type of managed object in a Pure Storage FlashBlade like &#39;kStorageArray&#39; or &#39;kFileSystem&#39;. &#39;kStorageArray&#39; indicates a top level Pure Storage FlashBlade array. &#39;kFileSystem&#39; indicates a Pure Storage FlashBlade file system within the array.
        /// </summary>
        /// <value>Specifies the type of managed object in a Pure Storage FlashBlade like &#39;kStorageArray&#39; or &#39;kFileSystem&#39;. &#39;kStorageArray&#39; indicates a top level Pure Storage FlashBlade array. &#39;kFileSystem&#39; indicates a Pure Storage FlashBlade file system within the array.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeProtectionSource" /> class.
        /// </summary>
        /// <param name="fileSystem">fileSystem.</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="storageArray">storageArray.</param>
        /// <param name="type">Specifies the type of managed object in a Pure Storage FlashBlade like &#39;kStorageArray&#39; or &#39;kFileSystem&#39;. &#39;kStorageArray&#39; indicates a top level Pure Storage FlashBlade array. &#39;kFileSystem&#39; indicates a Pure Storage FlashBlade file system within the array..</param>
        public FlashBladeProtectionSource(FlashBladeFileSystem fileSystem = default(FlashBladeFileSystem), string name = default(string), FlashBladeStorageArray storageArray = default(FlashBladeStorageArray), TypeEnum? type = default(TypeEnum?))
        {
            this.FileSystem = fileSystem;
            this.Name = name;
            this.StorageArray = storageArray;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets FileSystem
        /// </summary>
        [DataMember(Name="fileSystem", EmitDefaultValue=false)]
        public FlashBladeFileSystem FileSystem { get; set; }

        /// <summary>
        /// Specifies a unique name of the Protection Source.
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StorageArray
        /// </summary>
        [DataMember(Name="storageArray", EmitDefaultValue=false)]
        public FlashBladeStorageArray StorageArray { get; set; }


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
            return this.Equals(input as FlashBladeProtectionSource);
        }

        /// <summary>
        /// Returns true if FlashBladeProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSystem == input.FileSystem ||
                    (this.FileSystem != null &&
                    this.FileSystem.Equals(input.FileSystem))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StorageArray == input.StorageArray ||
                    (this.StorageArray != null &&
                    this.StorageArray.Equals(input.StorageArray))
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
                if (this.FileSystem != null)
                    hashCode = hashCode * 59 + this.FileSystem.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StorageArray != null)
                    hashCode = hashCode * 59 + this.StorageArray.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

