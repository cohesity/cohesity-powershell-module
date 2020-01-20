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
    /// Specifies information about a fileset in a GPFS file system.
    /// </summary>
    [DataContract]
    public partial class GpfsFileset :  IEquatable<GpfsFileset>
    {
        /// <summary>
        /// Defines Protocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolsEnum
        {
            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 1,

            /// <summary>
            /// Enum KSmb for value: kSmb
            /// </summary>
            [EnumMember(Value = "kSmb")]
            KSmb = 2

        }


        /// <summary>
        /// Specifies GPFS supported Protocol information enabled on GPFS File System &#39;kNfs&#39; indicates NFS exports in a GPFS fileset. &#39;kSmb&#39; indicates CIFS/SMB Shares in a GPFS fileset.
        /// </summary>
        /// <value>Specifies GPFS supported Protocol information enabled on GPFS File System &#39;kNfs&#39; indicates NFS exports in a GPFS fileset. &#39;kSmb&#39; indicates CIFS/SMB Shares in a GPFS fileset.</value>
        [DataMember(Name="protocols", EmitDefaultValue=true)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GpfsFileset" /> class.
        /// </summary>
        /// <param name="id">Specifies the id of the fileset..</param>
        /// <param name="name">Name of the filesystem associated with the fileset.</param>
        /// <param name="path">Specifies the absolute path of the fileset..</param>
        /// <param name="protocols">Specifies GPFS supported Protocol information enabled on GPFS File System &#39;kNfs&#39; indicates NFS exports in a GPFS fileset. &#39;kSmb&#39; indicates CIFS/SMB Shares in a GPFS fileset..</param>
        public GpfsFileset(int? id = default(int?), string name = default(string), string path = default(string), List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>))
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
            this.Protocols = protocols;
            this.Id = id;
            this.Name = name;
            this.Path = path;
            this.Protocols = protocols;
        }
        
        /// <summary>
        /// Specifies the id of the fileset.
        /// </summary>
        /// <value>Specifies the id of the fileset.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the filesystem associated with the fileset
        /// </summary>
        /// <value>Name of the filesystem associated with the fileset</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the absolute path of the fileset.
        /// </summary>
        /// <value>Specifies the absolute path of the fileset.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

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
            return this.Equals(input as GpfsFileset);
        }

        /// <summary>
        /// Returns true if GpfsFileset instances are equal
        /// </summary>
        /// <param name="input">Instance of GpfsFileset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GpfsFileset input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                return hashCode;
            }
        }

    }

}

