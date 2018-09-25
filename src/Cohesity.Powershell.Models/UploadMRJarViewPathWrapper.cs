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
    /// UploadMRJarViewPathWrapper contains jar name and local mount path where the Jars will be uploaded.
    /// </summary>
    [DataContract]
    public partial class UploadMRJarViewPathWrapper :  IEquatable<UploadMRJarViewPathWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMRJarViewPathWrapper" /> class.
        /// </summary>
        /// <param name="jarName">JarName is the name of the uploaded jar..</param>
        /// <param name="jarPath">JarPath is the path for the directory where uploaded jar is stored..</param>
        public UploadMRJarViewPathWrapper(string jarName = default(string), string jarPath = default(string))
        {
            this.JarName = jarName;
            this.JarPath = jarPath;
        }
        
        /// <summary>
        /// JarName is the name of the uploaded jar.
        /// </summary>
        /// <value>JarName is the name of the uploaded jar.</value>
        [DataMember(Name="jarName", EmitDefaultValue=false)]
        public string JarName { get; set; }

        /// <summary>
        /// JarPath is the path for the directory where uploaded jar is stored.
        /// </summary>
        /// <value>JarPath is the path for the directory where uploaded jar is stored.</value>
        [DataMember(Name="jarPath", EmitDefaultValue=false)]
        public string JarPath { get; set; }

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
            return this.Equals(input as UploadMRJarViewPathWrapper);
        }

        /// <summary>
        /// Returns true if UploadMRJarViewPathWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadMRJarViewPathWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadMRJarViewPathWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JarName == input.JarName ||
                    (this.JarName != null &&
                    this.JarName.Equals(input.JarName))
                ) && 
                (
                    this.JarPath == input.JarPath ||
                    (this.JarPath != null &&
                    this.JarPath.Equals(input.JarPath))
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
                if (this.JarName != null)
                    hashCode = hashCode * 59 + this.JarName.GetHashCode();
                if (this.JarPath != null)
                    hashCode = hashCode * 59 + this.JarPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

