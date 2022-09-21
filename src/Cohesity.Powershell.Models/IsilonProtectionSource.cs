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
    /// Specifies a Protection Source in Isilon OneFs environment.
    /// </summary>
    [DataContract]
    public partial class IsilonProtectionSource :  IEquatable<IsilonProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the entity in an Isilon OneFs file system like &#39;kCluster&#39;, &#39;kZone&#39;, or, &#39;kMountPoint&#39;. &#39;kCluster&#39; indicates an Isilon OneFs Cluster. &#39;kZone&#39; indicates an access zone in an Isilon OneFs Cluster. &#39;kMountPoint&#39; indicates a mount point exposed by an Isilon OneFs Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in an Isilon OneFs file system like &#39;kCluster&#39;, &#39;kZone&#39;, or, &#39;kMountPoint&#39;. &#39;kCluster&#39; indicates an Isilon OneFs Cluster. &#39;kZone&#39; indicates an access zone in an Isilon OneFs Cluster. &#39;kMountPoint&#39; indicates a mount point exposed by an Isilon OneFs Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KZone for value: kZone
            /// </summary>
            [EnumMember(Value = "kZone")]
            KZone = 2,

            /// <summary>
            /// Enum KMountPoint for value: kMountPoint
            /// </summary>
            [EnumMember(Value = "kMountPoint")]
            KMountPoint = 3

        }

        /// <summary>
        /// Specifies the type of the entity in an Isilon OneFs file system like &#39;kCluster&#39;, &#39;kZone&#39;, or, &#39;kMountPoint&#39;. &#39;kCluster&#39; indicates an Isilon OneFs Cluster. &#39;kZone&#39; indicates an access zone in an Isilon OneFs Cluster. &#39;kMountPoint&#39; indicates a mount point exposed by an Isilon OneFs Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in an Isilon OneFs file system like &#39;kCluster&#39;, &#39;kZone&#39;, or, &#39;kMountPoint&#39;. &#39;kCluster&#39; indicates an Isilon OneFs Cluster. &#39;kZone&#39; indicates an access zone in an Isilon OneFs Cluster. &#39;kMountPoint&#39; indicates a mount point exposed by an Isilon OneFs Cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonProtectionSource" /> class.
        /// </summary>
        /// <param name="accessZone">accessZone.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="mountPoint">mountPoint.</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="type">Specifies the type of the entity in an Isilon OneFs file system like &#39;kCluster&#39;, &#39;kZone&#39;, or, &#39;kMountPoint&#39;. &#39;kCluster&#39; indicates an Isilon OneFs Cluster. &#39;kZone&#39; indicates an access zone in an Isilon OneFs Cluster. &#39;kMountPoint&#39; indicates a mount point exposed by an Isilon OneFs Cluster..</param>
        public IsilonProtectionSource(IsilonAccessZone accessZone = default(IsilonAccessZone), IsilonCluster cluster = default(IsilonCluster), IsilonMountPoint mountPoint = default(IsilonMountPoint), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
            this.AccessZone = accessZone;
            this.Cluster = cluster;
            this.MountPoint = mountPoint;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets AccessZone
        /// </summary>
        [DataMember(Name="accessZone", EmitDefaultValue=false)]
        public IsilonAccessZone AccessZone { get; set; }

        /// <summary>
        /// Gets or Sets Cluster
        /// </summary>
        [DataMember(Name="cluster", EmitDefaultValue=false)]
        public IsilonCluster Cluster { get; set; }

        /// <summary>
        /// Gets or Sets MountPoint
        /// </summary>
        [DataMember(Name="mountPoint", EmitDefaultValue=false)]
        public IsilonMountPoint MountPoint { get; set; }

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
            return this.Equals(input as IsilonProtectionSource);
        }

        /// <summary>
        /// Returns true if IsilonProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessZone == input.AccessZone ||
                    (this.AccessZone != null &&
                    this.AccessZone.Equals(input.AccessZone))
                ) && 
                (
                    this.Cluster == input.Cluster ||
                    (this.Cluster != null &&
                    this.Cluster.Equals(input.Cluster))
                ) && 
                (
                    this.MountPoint == input.MountPoint ||
                    (this.MountPoint != null &&
                    this.MountPoint.Equals(input.MountPoint))
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
                if (this.AccessZone != null)
                    hashCode = hashCode * 59 + this.AccessZone.GetHashCode();
                if (this.Cluster != null)
                    hashCode = hashCode * 59 + this.Cluster.GetHashCode();
                if (this.MountPoint != null)
                    hashCode = hashCode * 59 + this.MountPoint.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

