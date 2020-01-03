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
    /// Specifies a Protection Source in GPFS environment.
    /// </summary>
    [DataContract]
    public partial class GpfsProtectionSource :  IEquatable<GpfsProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the entity in an GPFS file system like &#39;kCluster&#39;, &#39;kFilesystem&#39;, or, &#39;kFileset&#39;. &#39;kCluster&#39; indicates an GPFS Cluster. &#39;kFilesystem&#39; indicates a top level filesystem on GPFS cluster. &#39;kFileset&#39; indicates a fileset within a filesystem.
        /// </summary>
        /// <value>Specifies the type of the entity in an GPFS file system like &#39;kCluster&#39;, &#39;kFilesystem&#39;, or, &#39;kFileset&#39;. &#39;kCluster&#39; indicates an GPFS Cluster. &#39;kFilesystem&#39; indicates a top level filesystem on GPFS cluster. &#39;kFileset&#39; indicates a fileset within a filesystem.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KFilesystem for value: kFilesystem
            /// </summary>
            [EnumMember(Value = "kFilesystem")]
            KFilesystem = 2,

            /// <summary>
            /// Enum KFileset for value: kFileset
            /// </summary>
            [EnumMember(Value = "kFileset")]
            KFileset = 3

        }

        /// <summary>
        /// Specifies the type of the entity in an GPFS file system like &#39;kCluster&#39;, &#39;kFilesystem&#39;, or, &#39;kFileset&#39;. &#39;kCluster&#39; indicates an GPFS Cluster. &#39;kFilesystem&#39; indicates a top level filesystem on GPFS cluster. &#39;kFileset&#39; indicates a fileset within a filesystem.
        /// </summary>
        /// <value>Specifies the type of the entity in an GPFS file system like &#39;kCluster&#39;, &#39;kFilesystem&#39;, or, &#39;kFileset&#39;. &#39;kCluster&#39; indicates an GPFS Cluster. &#39;kFilesystem&#39; indicates a top level filesystem on GPFS cluster. &#39;kFileset&#39; indicates a fileset within a filesystem.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GpfsProtectionSource" /> class.
        /// </summary>
        /// <param name="cluster">cluster.</param>
        /// <param name="fileset">fileset.</param>
        /// <param name="filesystem">filesystem.</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="type">Specifies the type of the entity in an GPFS file system like &#39;kCluster&#39;, &#39;kFilesystem&#39;, or, &#39;kFileset&#39;. &#39;kCluster&#39; indicates an GPFS Cluster. &#39;kFilesystem&#39; indicates a top level filesystem on GPFS cluster. &#39;kFileset&#39; indicates a fileset within a filesystem..</param>
        public GpfsProtectionSource(GpfsCluster cluster = default(GpfsCluster), GpfsFileset fileset = default(GpfsFileset), GpfsFilesystem filesystem = default(GpfsFilesystem), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
            this.Cluster = cluster;
            this.Fileset = fileset;
            this.Filesystem = filesystem;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Cluster
        /// </summary>
        [DataMember(Name="cluster", EmitDefaultValue=false)]
        public GpfsCluster Cluster { get; set; }

        /// <summary>
        /// Gets or Sets Fileset
        /// </summary>
        [DataMember(Name="fileset", EmitDefaultValue=false)]
        public GpfsFileset Fileset { get; set; }

        /// <summary>
        /// Gets or Sets Filesystem
        /// </summary>
        [DataMember(Name="filesystem", EmitDefaultValue=false)]
        public GpfsFilesystem Filesystem { get; set; }

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
            return this.Equals(input as GpfsProtectionSource);
        }

        /// <summary>
        /// Returns true if GpfsProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of GpfsProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GpfsProtectionSource input)
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
                    this.Fileset == input.Fileset ||
                    (this.Fileset != null &&
                    this.Fileset.Equals(input.Fileset))
                ) && 
                (
                    this.Filesystem == input.Filesystem ||
                    (this.Filesystem != null &&
                    this.Filesystem.Equals(input.Filesystem))
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
                if (this.Fileset != null)
                    hashCode = hashCode * 59 + this.Fileset.GetHashCode();
                if (this.Filesystem != null)
                    hashCode = hashCode * 59 + this.Filesystem.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

