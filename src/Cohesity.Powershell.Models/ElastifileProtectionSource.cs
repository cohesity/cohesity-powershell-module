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
    /// Specifies a Protection Source in Elastifile environment.
    /// </summary>
    [DataContract]
    public partial class ElastifileProtectionSource :  IEquatable<ElastifileProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the entity in an Elastifile file system like &#39;kCluster&#39;, &#39;kContainer&#39;. &#39;kCluster&#39; indicates an Elastifile Cluster. &#39;kContainer&#39; indicates a container on Elastifile cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in an Elastifile file system like &#39;kCluster&#39;, &#39;kContainer&#39;. &#39;kCluster&#39; indicates an Elastifile Cluster. &#39;kContainer&#39; indicates a container on Elastifile cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KContainer for value: kContainer
            /// </summary>
            [EnumMember(Value = "kContainer")]
            KContainer = 2

        }

        /// <summary>
        /// Specifies the type of the entity in an Elastifile file system like &#39;kCluster&#39;, &#39;kContainer&#39;. &#39;kCluster&#39; indicates an Elastifile Cluster. &#39;kContainer&#39; indicates a container on Elastifile cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in an Elastifile file system like &#39;kCluster&#39;, &#39;kContainer&#39;. &#39;kCluster&#39; indicates an Elastifile Cluster. &#39;kContainer&#39; indicates a container on Elastifile cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElastifileProtectionSource" /> class.
        /// </summary>
        /// <param name="cluster">cluster.</param>
        /// <param name="container">container.</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="type">Specifies the type of the entity in an Elastifile file system like &#39;kCluster&#39;, &#39;kContainer&#39;. &#39;kCluster&#39; indicates an Elastifile Cluster. &#39;kContainer&#39; indicates a container on Elastifile cluster..</param>
        public ElastifileProtectionSource(ElastifileCluster cluster = default(ElastifileCluster), ElastifileContainer container = default(ElastifileContainer), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
            this.Cluster = cluster;
            this.Container = container;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Cluster
        /// </summary>
        [DataMember(Name="cluster", EmitDefaultValue=false)]
        public ElastifileCluster Cluster { get; set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name="container", EmitDefaultValue=false)]
        public ElastifileContainer Container { get; set; }

        /// <summary>
        /// Specifies a unique name of the Protection Source.
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source.</value>
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
            return this.Equals(input as ElastifileProtectionSource);
        }

        /// <summary>
        /// Returns true if ElastifileProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ElastifileProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElastifileProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cluster == input.Cluster ||
                    (this.Cluster != null &&
                    this.Cluster.Equals(input.Cluster))
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
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
                if (this.Cluster != null)
                    hashCode = hashCode * 59 + this.Cluster.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

