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
    /// Consumer is the storage consumer of a group.
    /// </summary>
    [DataContract]
    public partial class Consumer :  IEquatable<Consumer>
    {
        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KViews for value: kViews
            /// </summary>
            [EnumMember(Value = "kViews")]
            KViews = 1,

            /// <summary>
            /// Enum KProtectionRuns for value: kProtectionRuns
            /// </summary>
            [EnumMember(Value = "kProtectionRuns")]
            KProtectionRuns = 2,

            /// <summary>
            /// Enum KReplicationRuns for value: kReplicationRuns
            /// </summary>
            [EnumMember(Value = "kReplicationRuns")]
            KReplicationRuns = 3

        }

        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Consumer" /> class.
        /// </summary>
        /// <param name="id">Specifies the id of the consumer..</param>
        /// <param name="name">Specifies the name of the consumer..</param>
        /// <param name="type">Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain)..</param>
        public Consumer(long? id = default(long?), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the id of the consumer.
        /// </summary>
        /// <value>Specifies the id of the consumer.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the consumer.
        /// </summary>
        /// <value>Specifies the name of the consumer.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as Consumer);
        }

        /// <summary>
        /// Returns true if Consumer instances are equal
        /// </summary>
        /// <param name="input">Instance of Consumer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Consumer input)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

