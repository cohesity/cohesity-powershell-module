// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the params that have to be provided to clone a directory.
    /// </summary>
    [DataContract]
    public partial class CloneDirectoryParams :  IEquatable<CloneDirectoryParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDirectoryParams" /> class.
        /// </summary>
        /// <param name="destinationDirectoryName">Name of the new directory which will contain the clone contents..</param>
        /// <param name="destinationParentDirectoryPath">Specifies the path of the destination parent directory. The source dir would be cloned as a child of dest parent dir..</param>
        /// <param name="sourceDirectoryPath">Specifies the path of the source directory.</param>
        public CloneDirectoryParams(string destinationDirectoryName = default(string), string destinationParentDirectoryPath = default(string), string sourceDirectoryPath = default(string))
        {
            this.DestinationDirectoryName = destinationDirectoryName;
            this.DestinationParentDirectoryPath = destinationParentDirectoryPath;
            this.SourceDirectoryPath = sourceDirectoryPath;
        }
        
        /// <summary>
        /// Name of the new directory which will contain the clone contents.
        /// </summary>
        /// <value>Name of the new directory which will contain the clone contents.</value>
        [DataMember(Name="destinationDirectoryName", EmitDefaultValue=false)]
        public string DestinationDirectoryName { get; set; }

        /// <summary>
        /// Specifies the path of the destination parent directory. The source dir would be cloned as a child of dest parent dir.
        /// </summary>
        /// <value>Specifies the path of the destination parent directory. The source dir would be cloned as a child of dest parent dir.</value>
        [DataMember(Name="destinationParentDirectoryPath", EmitDefaultValue=false)]
        public string DestinationParentDirectoryPath { get; set; }

        /// <summary>
        /// Specifies the path of the source directory
        /// </summary>
        /// <value>Specifies the path of the source directory</value>
        [DataMember(Name="sourceDirectoryPath", EmitDefaultValue=false)]
        public string SourceDirectoryPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as CloneDirectoryParams);
        }

        /// <summary>
        /// Returns true if CloneDirectoryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneDirectoryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneDirectoryParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationDirectoryName == input.DestinationDirectoryName ||
                    (this.DestinationDirectoryName != null &&
                    this.DestinationDirectoryName.Equals(input.DestinationDirectoryName))
                ) && 
                (
                    this.DestinationParentDirectoryPath == input.DestinationParentDirectoryPath ||
                    (this.DestinationParentDirectoryPath != null &&
                    this.DestinationParentDirectoryPath.Equals(input.DestinationParentDirectoryPath))
                ) && 
                (
                    this.SourceDirectoryPath == input.SourceDirectoryPath ||
                    (this.SourceDirectoryPath != null &&
                    this.SourceDirectoryPath.Equals(input.SourceDirectoryPath))
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
                if (this.DestinationDirectoryName != null)
                    hashCode = hashCode * 59 + this.DestinationDirectoryName.GetHashCode();
                if (this.DestinationParentDirectoryPath != null)
                    hashCode = hashCode * 59 + this.DestinationParentDirectoryPath.GetHashCode();
                if (this.SourceDirectoryPath != null)
                    hashCode = hashCode * 59 + this.SourceDirectoryPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

