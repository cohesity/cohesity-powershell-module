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
    /// Specifies information about container in an Elastifile Cluster.
    /// </summary>
    [DataContract]
    public partial class ElastifileContainer :  IEquatable<ElastifileContainer>
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
        /// Specifies Elastifile supported Protocol information enabled on Elastifile container. &#39;kNfs&#39; indicates NFS protocol in an elastifile container. &#39;kSmb&#39; indicates SMB protocol in an elastifile container.
        /// </summary>
        /// <value>Specifies Elastifile supported Protocol information enabled on Elastifile container. &#39;kNfs&#39; indicates NFS protocol in an elastifile container. &#39;kSmb&#39; indicates SMB protocol in an elastifile container.</value>
        [DataMember(Name="protocols", EmitDefaultValue=true)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElastifileContainer" /> class.
        /// </summary>
        /// <param name="createdAt">Specifies the creation date of the container..</param>
        /// <param name="id">Specifies id of a Elastifile Container in a Cluster..</param>
        /// <param name="isNfsInterface">Specifies if the container has NFS volumes or not..</param>
        /// <param name="isSmbInterface">Specifies if the container has SMB volumes or not..</param>
        /// <param name="name">Specifies the name of the container..</param>
        /// <param name="protocols">Specifies Elastifile supported Protocol information enabled on Elastifile container. &#39;kNfs&#39; indicates NFS protocol in an elastifile container. &#39;kSmb&#39; indicates SMB protocol in an elastifile container..</param>
        /// <param name="usedBytes">Specifies the bytes used by the container..</param>
        /// <param name="uuid">Specifies the UUID of the container..</param>
        public ElastifileContainer(string createdAt = default(string), int? id = default(int?), bool? isNfsInterface = default(bool?), bool? isSmbInterface = default(bool?), string name = default(string), List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>), long? usedBytes = default(long?), string uuid = default(string))
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.IsNfsInterface = isNfsInterface;
            this.IsSmbInterface = isSmbInterface;
            this.Name = name;
            this.Protocols = protocols;
            this.UsedBytes = usedBytes;
            this.Uuid = uuid;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.IsNfsInterface = isNfsInterface;
            this.IsSmbInterface = isSmbInterface;
            this.Name = name;
            this.Protocols = protocols;
            this.UsedBytes = usedBytes;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the creation date of the container.
        /// </summary>
        /// <value>Specifies the creation date of the container.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Specifies id of a Elastifile Container in a Cluster.
        /// </summary>
        /// <value>Specifies id of a Elastifile Container in a Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies if the container has NFS volumes or not.
        /// </summary>
        /// <value>Specifies if the container has NFS volumes or not.</value>
        [DataMember(Name="isNfsInterface", EmitDefaultValue=true)]
        public bool? IsNfsInterface { get; set; }

        /// <summary>
        /// Specifies if the container has SMB volumes or not.
        /// </summary>
        /// <value>Specifies if the container has SMB volumes or not.</value>
        [DataMember(Name="isSmbInterface", EmitDefaultValue=true)]
        public bool? IsSmbInterface { get; set; }

        /// <summary>
        /// Specifies the name of the container.
        /// </summary>
        /// <value>Specifies the name of the container.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the bytes used by the container.
        /// </summary>
        /// <value>Specifies the bytes used by the container.</value>
        [DataMember(Name="usedBytes", EmitDefaultValue=true)]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// Specifies the UUID of the container.
        /// </summary>
        /// <value>Specifies the UUID of the container.</value>
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
            return this.Equals(input as ElastifileContainer);
        }

        /// <summary>
        /// Returns true if ElastifileContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of ElastifileContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElastifileContainer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsNfsInterface == input.IsNfsInterface ||
                    (this.IsNfsInterface != null &&
                    this.IsNfsInterface.Equals(input.IsNfsInterface))
                ) && 
                (
                    this.IsSmbInterface == input.IsSmbInterface ||
                    (this.IsSmbInterface != null &&
                    this.IsSmbInterface.Equals(input.IsSmbInterface))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.UsedBytes == input.UsedBytes ||
                    (this.UsedBytes != null &&
                    this.UsedBytes.Equals(input.UsedBytes))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsNfsInterface != null)
                    hashCode = hashCode * 59 + this.IsNfsInterface.GetHashCode();
                if (this.IsSmbInterface != null)
                    hashCode = hashCode * 59 + this.IsSmbInterface.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.UsedBytes != null)
                    hashCode = hashCode * 59 + this.UsedBytes.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

