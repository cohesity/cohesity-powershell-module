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
    /// API to analyse a JAR file. This JAR may contain multiple mappers/reducers. Jar will be analysed and list of all mappers/reducers found in the jar will be returned.
    /// </summary>
    [DataContract]
    public partial class AnalyseJarArg :  IEquatable<AnalyseJarArg>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyseJarArg" /> class.
        /// </summary>
        /// <param name="jarName">Name of the JAR to be analysed..</param>
        /// <param name="jarPath">Path of the jar file..</param>
        /// <param name="jarRelativePath">jarRelativePath.</param>
        /// <param name="saveEntities">If this flag is true, then also save mapper and reducers in scribe..</param>
        public AnalyseJarArg(string jarName = default(string), string jarPath = default(string), string jarRelativePath = default(string), bool? saveEntities = default(bool?))
        {
            this.JarName = jarName;
            this.JarPath = jarPath;
            this.JarRelativePath = jarRelativePath;
            this.SaveEntities = saveEntities;
            this.JarName = jarName;
            this.JarPath = jarPath;
            this.JarRelativePath = jarRelativePath;
            this.SaveEntities = saveEntities;
        }
        
        /// <summary>
        /// Name of the JAR to be analysed.
        /// </summary>
        /// <value>Name of the JAR to be analysed.</value>
        [DataMember(Name="jarName", EmitDefaultValue=true)]
        public string JarName { get; set; }

        /// <summary>
        /// Path of the jar file.
        /// </summary>
        /// <value>Path of the jar file.</value>
        [DataMember(Name="jarPath", EmitDefaultValue=true)]
        public string JarPath { get; set; }

        /// <summary>
        /// Gets or Sets JarRelativePath
        /// </summary>
        [DataMember(Name="jarRelativePath", EmitDefaultValue=true)]
        public string JarRelativePath { get; set; }

        /// <summary>
        /// If this flag is true, then also save mapper and reducers in scribe.
        /// </summary>
        /// <value>If this flag is true, then also save mapper and reducers in scribe.</value>
        [DataMember(Name="saveEntities", EmitDefaultValue=true)]
        public bool? SaveEntities { get; set; }

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
            return this.Equals(input as AnalyseJarArg);
        }

        /// <summary>
        /// Returns true if AnalyseJarArg instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyseJarArg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyseJarArg input)
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
                ) && 
                (
                    this.JarRelativePath == input.JarRelativePath ||
                    (this.JarRelativePath != null &&
                    this.JarRelativePath.Equals(input.JarRelativePath))
                ) && 
                (
                    this.SaveEntities == input.SaveEntities ||
                    (this.SaveEntities != null &&
                    this.SaveEntities.Equals(input.SaveEntities))
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
                if (this.JarRelativePath != null)
                    hashCode = hashCode * 59 + this.JarRelativePath.GetHashCode();
                if (this.SaveEntities != null)
                    hashCode = hashCode * 59 + this.SaveEntities.GetHashCode();
                return hashCode;
            }
        }

    }

}

