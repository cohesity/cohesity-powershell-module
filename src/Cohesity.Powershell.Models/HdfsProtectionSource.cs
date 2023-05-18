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
    /// Specifies an Object representing Hdfs.
    /// </summary>
    [DataContract]
    public partial class HdfsProtectionSource :  IEquatable<HdfsProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Hdfs Protection Source. Specifies the type of an Hdfs source entity. &#39;kCluster&#39; indicates a Hdfs cluster distributed over several physical nodes.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Hdfs Protection Source. Specifies the type of an Hdfs source entity. &#39;kCluster&#39; indicates a Hdfs cluster distributed over several physical nodes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1

        }

        /// <summary>
        /// Specifies the type of the managed Object in Hdfs Protection Source. Specifies the type of an Hdfs source entity. &#39;kCluster&#39; indicates a Hdfs cluster distributed over several physical nodes.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Hdfs Protection Source. Specifies the type of an Hdfs source entity. &#39;kCluster&#39; indicates a Hdfs cluster distributed over several physical nodes.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HdfsProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies the instance name of the Hdfs entity..</param>
        /// <param name="type">Specifies the type of the managed Object in Hdfs Protection Source. Specifies the type of an Hdfs source entity. &#39;kCluster&#39; indicates a Hdfs cluster distributed over several physical nodes..</param>
        /// <param name="uuid">Specifies the UUID for the Hdfs entity..</param>
        public HdfsProtectionSource(string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the instance name of the Hdfs entity.
        /// </summary>
        /// <value>Specifies the instance name of the Hdfs entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID for the Hdfs entity.
        /// </summary>
        /// <value>Specifies the UUID for the Hdfs entity.</value>
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
            return this.Equals(input as HdfsProtectionSource);
        }

        /// <summary>
        /// Returns true if HdfsProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of HdfsProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HdfsProtectionSource input)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

