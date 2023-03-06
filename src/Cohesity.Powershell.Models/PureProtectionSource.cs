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
    /// Specifies a Protection Source in a Pure environment.
    /// </summary>
    [DataContract]
    public partial class PureProtectionSource :  IEquatable<PureProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed Object in a SAN/Pure Protection Source like a kStorageArray or kVolume. Examples of SAN Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire SAN storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.
        /// </summary>
        /// <value>Specifies the type of managed Object in a SAN/Pure Protection Source like a kStorageArray or kVolume. Examples of SAN Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire SAN storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2

        }

        /// <summary>
        /// Specifies the type of managed Object in a SAN/Pure Protection Source like a kStorageArray or kVolume. Examples of SAN Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire SAN storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.
        /// </summary>
        /// <value>Specifies the type of managed Object in a SAN/Pure Protection Source like a kStorageArray or kVolume. Examples of SAN Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire SAN storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PureProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies a unique name of the Protection Source.</param>
        /// <param name="storageArray">storageArray.</param>
        /// <param name="type">Specifies the type of managed Object in a SAN/Pure Protection Source like a kStorageArray or kVolume. Examples of SAN Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire SAN storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected..</param>
        /// <param name="volume">volume.</param>
        public PureProtectionSource(string name = default(string), SanStorageArray storageArray = default(SanStorageArray), TypeEnum? type = default(TypeEnum?), SanVolume volume = default(SanVolume))
        {
            this.Name = name;
            this.Type = type;
            this.Name = name;
            this.StorageArray = storageArray;
            this.Type = type;
            this.Volume = volume;
        }
        
        /// <summary>
        /// Specifies a unique name of the Protection Source
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StorageArray
        /// </summary>
        [DataMember(Name="storageArray", EmitDefaultValue=false)]
        public SanStorageArray StorageArray { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public SanVolume Volume { get; set; }

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
            return this.Equals(input as PureProtectionSource);
        }

        /// <summary>
        /// Returns true if PureProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of PureProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PureProtectionSource input)
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
                    this.StorageArray == input.StorageArray ||
                    (this.StorageArray != null &&
                    this.StorageArray.Equals(input.StorageArray))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
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
                if (this.StorageArray != null)
                    hashCode = hashCode * 59 + this.StorageArray.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }

    }

}

