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
    /// Specifies information about a Datastore Object in HyperV environment.
    /// </summary>
    [DataContract]
    public partial class HypervDatastore :  IEquatable<HypervDatastore>
    {
        /// <summary>
        /// Specifies the type of the datastore object like kFileShare or kVolume. overrideDescription: true Specifies the type of a HyperV datastore object. &#39;kFileShare&#39; indicates SMB file share datastore. &#39;kVolume&#39; indicates a volume which can a LUN.
        /// </summary>
        /// <value>Specifies the type of the datastore object like kFileShare or kVolume. overrideDescription: true Specifies the type of a HyperV datastore object. &#39;kFileShare&#39; indicates SMB file share datastore. &#39;kVolume&#39; indicates a volume which can a LUN.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KFileShare for value: kFileShare
            /// </summary>
            [EnumMember(Value = "kFileShare")]
            KFileShare = 1,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2

        }

        /// <summary>
        /// Specifies the type of the datastore object like kFileShare or kVolume. overrideDescription: true Specifies the type of a HyperV datastore object. &#39;kFileShare&#39; indicates SMB file share datastore. &#39;kVolume&#39; indicates a volume which can a LUN.
        /// </summary>
        /// <value>Specifies the type of the datastore object like kFileShare or kVolume. overrideDescription: true Specifies the type of a HyperV datastore object. &#39;kFileShare&#39; indicates SMB file share datastore. &#39;kVolume&#39; indicates a volume which can a LUN.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HypervDatastore" /> class.
        /// </summary>
        /// <param name="capacity">Specifies the capacity of the datastore in bytes..</param>
        /// <param name="freeSpace">Specifies the available space on the datastore in bytes..</param>
        /// <param name="mountPoints">Specifies the available mount points on the datastore..</param>
        /// <param name="type">Specifies the type of the datastore object like kFileShare or kVolume. overrideDescription: true Specifies the type of a HyperV datastore object. &#39;kFileShare&#39; indicates SMB file share datastore. &#39;kVolume&#39; indicates a volume which can a LUN..</param>
        public HypervDatastore(long? capacity = default(long?), long? freeSpace = default(long?), List<string> mountPoints = default(List<string>), TypeEnum? type = default(TypeEnum?))
        {
            this.Capacity = capacity;
            this.FreeSpace = freeSpace;
            this.MountPoints = mountPoints;
            this.Type = type;
            this.Capacity = capacity;
            this.FreeSpace = freeSpace;
            this.MountPoints = mountPoints;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the capacity of the datastore in bytes.
        /// </summary>
        /// <value>Specifies the capacity of the datastore in bytes.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public long? Capacity { get; set; }

        /// <summary>
        /// Specifies the available space on the datastore in bytes.
        /// </summary>
        /// <value>Specifies the available space on the datastore in bytes.</value>
        [DataMember(Name="freeSpace", EmitDefaultValue=true)]
        public long? FreeSpace { get; set; }

        /// <summary>
        /// Specifies the available mount points on the datastore.
        /// </summary>
        /// <value>Specifies the available mount points on the datastore.</value>
        [DataMember(Name="mountPoints", EmitDefaultValue=true)]
        public List<string> MountPoints { get; set; }

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
            return this.Equals(input as HypervDatastore);
        }

        /// <summary>
        /// Returns true if HypervDatastore instances are equal
        /// </summary>
        /// <param name="input">Instance of HypervDatastore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypervDatastore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.FreeSpace == input.FreeSpace ||
                    (this.FreeSpace != null &&
                    this.FreeSpace.Equals(input.FreeSpace))
                ) && 
                (
                    this.MountPoints == input.MountPoints ||
                    this.MountPoints != null &&
                    input.MountPoints != null &&
                    this.MountPoints.SequenceEqual(input.MountPoints)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.FreeSpace != null)
                    hashCode = hashCode * 59 + this.FreeSpace.GetHashCode();
                if (this.MountPoints != null)
                    hashCode = hashCode * 59 + this.MountPoints.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

