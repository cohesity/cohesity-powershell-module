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
    /// Specifies an Object representing Universal Data Adapter.
    /// </summary>
    [DataContract]
    public partial class UdaProtectionSource :  IEquatable<UdaProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Universal Data Adapter Protection Source. Specifies the type of an Universal Data Adapter source entity. &#39;kCluster&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kObject&#39; indicates a generic object within the UDA environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Universal Data Adapter Protection Source. Specifies the type of an Universal Data Adapter source entity. &#39;kCluster&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kObject&#39; indicates a generic object within the UDA environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KObject for value: kObject
            /// </summary>
            [EnumMember(Value = "kObject")]
            KObject = 2

        }

        /// <summary>
        /// Specifies the type of the managed Object in Universal Data Adapter Protection Source. Specifies the type of an Universal Data Adapter source entity. &#39;kCluster&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kObject&#39; indicates a generic object within the UDA environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Universal Data Adapter Protection Source. Specifies the type of an Universal Data Adapter source entity. &#39;kCluster&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kObject&#39; indicates a generic object within the UDA environment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="name">Specifies the instance name of the Universal Data Adapter entity..</param>
        /// <param name="objectInfo">objectInfo.</param>
        /// <param name="type">Specifies the type of the managed Object in Universal Data Adapter Protection Source. Specifies the type of an Universal Data Adapter source entity. &#39;kCluster&#39; indicates a Universal Data Adapter source, possibly distributed over several physical nodes. &#39;kObject&#39; indicates a generic object within the UDA environment..</param>
        /// <param name="uuid">Specifies the UUID for the Universal Data Adapter entity..</param>
        public UdaProtectionSource(UdaCluster clusterInfo = default(UdaCluster), string name = default(string), UdaObject objectInfo = default(UdaObject), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.ClusterInfo = clusterInfo;
            this.Name = name;
            this.ObjectInfo = objectInfo;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public UdaCluster ClusterInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the Universal Data Adapter entity.
        /// </summary>
        /// <value>Specifies the instance name of the Universal Data Adapter entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ObjectInfo
        /// </summary>
        [DataMember(Name="objectInfo", EmitDefaultValue=false)]
        public UdaObject ObjectInfo { get; set; }

        /// <summary>
        /// Specifies the UUID for the Universal Data Adapter entity.
        /// </summary>
        /// <value>Specifies the UUID for the Universal Data Adapter entity.</value>
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
            return this.Equals(input as UdaProtectionSource);
        }

        /// <summary>
        /// Returns true if UdaProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterInfo == input.ClusterInfo ||
                    (this.ClusterInfo != null &&
                    this.ClusterInfo.Equals(input.ClusterInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    (this.ObjectInfo != null &&
                    this.ObjectInfo.Equals(input.ObjectInfo))
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
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

