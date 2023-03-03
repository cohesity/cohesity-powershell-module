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
    /// NetappVersionTuple
    /// </summary>
    [DataContract]
    public partial class NetappVersionTuple :  IEquatable<NetappVersionTuple>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappVersionTuple" /> class.
        /// </summary>
        /// <param name="generation">Netapp generation..</param>
        /// <param name="majorVersion">Major version number..</param>
        /// <param name="minorVersion">Minor version number..</param>
        public NetappVersionTuple(int? generation = default(int?), int? majorVersion = default(int?), int? minorVersion = default(int?))
        {
            this.Generation = generation;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
            this.Generation = generation;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }
        
        /// <summary>
        /// Netapp generation.
        /// </summary>
        /// <value>Netapp generation.</value>
        [DataMember(Name="generation", EmitDefaultValue=true)]
        public int? Generation { get; set; }

        /// <summary>
        /// Major version number.
        /// </summary>
        /// <value>Major version number.</value>
        [DataMember(Name="majorVersion", EmitDefaultValue=true)]
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Minor version number.
        /// </summary>
        /// <value>Minor version number.</value>
        [DataMember(Name="minorVersion", EmitDefaultValue=true)]
        public int? MinorVersion { get; set; }

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
            return this.Equals(input as NetappVersionTuple);
        }

        /// <summary>
        /// Returns true if NetappVersionTuple instances are equal
        /// </summary>
        /// <param name="input">Instance of NetappVersionTuple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetappVersionTuple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generation == input.Generation ||
                    (this.Generation != null &&
                    this.Generation.Equals(input.Generation))
                ) && 
                (
                    this.MajorVersion == input.MajorVersion ||
                    (this.MajorVersion != null &&
                    this.MajorVersion.Equals(input.MajorVersion))
                ) && 
                (
                    this.MinorVersion == input.MinorVersion ||
                    (this.MinorVersion != null &&
                    this.MinorVersion.Equals(input.MinorVersion))
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
                if (this.Generation != null)
                    hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.MajorVersion != null)
                    hashCode = hashCode * 59 + this.MajorVersion.GetHashCode();
                if (this.MinorVersion != null)
                    hashCode = hashCode * 59 + this.MinorVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}

