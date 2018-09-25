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
    /// User can upload jar files containing mappers and reducers. Iris will upload these jar files in Yoda&#39;s internal view. Yoda will mount its internal view and send Iris the mount point.
    /// </summary>
    [DataContract]
    public partial class GetMRJarUploadPathResult :  IEquatable<GetMRJarUploadPathResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMRJarUploadPathResult" /> class.
        /// </summary>
        /// <param name="error">Status code for this http rpc..</param>
        /// <param name="jarUploadPath">Path where Jars can be uploaded by Iris..</param>
        public GetMRJarUploadPathResult(ErrorProto error = default(ErrorProto), string jarUploadPath = default(string))
        {
            this.Error = error;
            this.JarUploadPath = jarUploadPath;
        }
        
        /// <summary>
        /// Status code for this http rpc.
        /// </summary>
        /// <value>Status code for this http rpc.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Path where Jars can be uploaded by Iris.
        /// </summary>
        /// <value>Path where Jars can be uploaded by Iris.</value>
        [DataMember(Name="jarUploadPath", EmitDefaultValue=false)]
        public string JarUploadPath { get; set; }

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
            return this.Equals(input as GetMRJarUploadPathResult);
        }

        /// <summary>
        /// Returns true if GetMRJarUploadPathResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMRJarUploadPathResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMRJarUploadPathResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.JarUploadPath == input.JarUploadPath ||
                    (this.JarUploadPath != null &&
                    this.JarUploadPath.Equals(input.JarUploadPath))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.JarUploadPath != null)
                    hashCode = hashCode * 59 + this.JarUploadPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

