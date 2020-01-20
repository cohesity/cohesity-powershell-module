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
    /// Specifies information about filesystem in a GPFS Cluster.
    /// </summary>
    [DataContract]
    public partial class GpfsFilesystem :  IEquatable<GpfsFilesystem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GpfsFilesystem" /> class.
        /// </summary>
        /// <param name="id">Specifies the id of the file system..</param>
        /// <param name="path">Specifies the path of the file system..</param>
        public GpfsFilesystem(string id = default(string), string path = default(string))
        {
            this.Id = id;
            this.Path = path;
            this.Id = id;
            this.Path = path;
        }
        
        /// <summary>
        /// Specifies the id of the file system.
        /// </summary>
        /// <value>Specifies the id of the file system.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the path of the file system.
        /// </summary>
        /// <value>Specifies the path of the file system.</value>
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
            return this.Equals(input as GpfsFilesystem);
        }

        /// <summary>
        /// Returns true if GpfsFilesystem instances are equal
        /// </summary>
        /// <param name="input">Instance of GpfsFilesystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GpfsFilesystem input)
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

