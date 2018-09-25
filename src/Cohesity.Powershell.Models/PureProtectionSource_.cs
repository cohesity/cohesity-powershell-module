// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about a Pure Protection Source when the environment is set to &#39;kPure&#39;.
    /// </summary>
    [DataContract]
    public partial class PureProtectionSource_ :  IEquatable<PureProtectionSource_>
    {
        /// <summary>
        /// Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.</value>
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
        /// Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PureProtectionSource_" /> class.
        /// </summary>
        /// <param name="name">Specifies a human readable name of the Protection Source..</param>
        /// <param name="storageArray">Specifies a Pure Storage Array information. This is set only when the type is kStorageArray..</param>
        /// <param name="type">Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;..</param>
        /// <param name="volume">Specifies a Pure Volume information within a storage array. This is set only when the type is kVolume..</param>
        public PureProtectionSource_(string name = default(string), PureStorageArray storageArray = default(PureStorageArray), TypeEnum? type = default(TypeEnum?), PureVolume volume = default(PureVolume))
        {
            this.Name = name;
            this.StorageArray = storageArray;
            this.Type = type;
            this.Volume = volume;
        }
        
        /// <summary>
        /// Specifies a human readable name of the Protection Source.
        /// </summary>
        /// <value>Specifies a human readable name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a Pure Storage Array information. This is set only when the type is kStorageArray.
        /// </summary>
        /// <value>Specifies a Pure Storage Array information. This is set only when the type is kStorageArray.</value>
        [DataMember(Name="storageArray", EmitDefaultValue=false)]
        public PureStorageArray StorageArray { get; set; }


        /// <summary>
        /// Specifies a Pure Volume information within a storage array. This is set only when the type is kVolume.
        /// </summary>
        /// <value>Specifies a Pure Volume information within a storage array. This is set only when the type is kVolume.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public PureVolume Volume { get; set; }

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
            return this.Equals(input as PureProtectionSource_);
        }

        /// <summary>
        /// Returns true if PureProtectionSource_ instances are equal
        /// </summary>
        /// <param name="input">Instance of PureProtectionSource_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PureProtectionSource_ input)
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

