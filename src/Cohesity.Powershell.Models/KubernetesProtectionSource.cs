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
    /// Specifies a Protection Source in Kubernetes environment.
    /// </summary>
    [DataContract]
    public partial class KubernetesProtectionSource :  IEquatable<KubernetesProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KNamespace for value: kNamespace
            /// </summary>
            [EnumMember(Value = "kNamespace")]
            KNamespace = 2,

            /// <summary>
            /// Enum KService for value: kService
            /// </summary>
            [EnumMember(Value = "kService")]
            KService = 3

        }

        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesProtectionSource" /> class.
        /// </summary>
        /// <param name="description">Specifies an optional description of the object..</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="type">Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster..</param>
        /// <param name="uuid">Specifies the UUID of the object..</param>
        public KubernetesProtectionSource(string description = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Description = description;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.Description = description;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies an optional description of the object.
        /// </summary>
        /// <value>Specifies an optional description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies a unique name of the Protection Source.
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID of the object.
        /// </summary>
        /// <value>Specifies the UUID of the object.</value>
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
            return this.Equals(input as KubernetesProtectionSource);
        }

        /// <summary>
        /// Returns true if KubernetesProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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

