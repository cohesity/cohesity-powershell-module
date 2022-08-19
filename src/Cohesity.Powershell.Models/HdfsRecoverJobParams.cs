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
    /// Contains any additional hdfs environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class HdfsRecoverJobParams :  IEquatable<HdfsRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HdfsRecoverJobParams" /> class.
        /// </summary>
        /// <param name="hdfsExcludePattern">Any path/Glob pattern from HDFS that is to excluded..</param>
        /// <param name="hdfsRecoverPattern">Any path/Glob pattern from HDFS that is to recovered..</param>
        /// <param name="targetDirectory">A target directory where all the recovered entities are created.</param>
        public HdfsRecoverJobParams(List<string> hdfsExcludePattern = default(List<string>), List<string> hdfsRecoverPattern = default(List<string>), string targetDirectory = default(string))
        {
            this.HdfsExcludePattern = hdfsExcludePattern;
            this.HdfsRecoverPattern = hdfsRecoverPattern;
            this.TargetDirectory = targetDirectory;
            this.HdfsExcludePattern = hdfsExcludePattern;
            this.HdfsRecoverPattern = hdfsRecoverPattern;
            this.TargetDirectory = targetDirectory;
        }
        
        /// <summary>
        /// Any path/Glob pattern from HDFS that is to excluded.
        /// </summary>
        /// <value>Any path/Glob pattern from HDFS that is to excluded.</value>
        [DataMember(Name="hdfsExcludePattern", EmitDefaultValue=true)]
        public List<string> HdfsExcludePattern { get; set; }

        /// <summary>
        /// Any path/Glob pattern from HDFS that is to recovered.
        /// </summary>
        /// <value>Any path/Glob pattern from HDFS that is to recovered.</value>
        [DataMember(Name="hdfsRecoverPattern", EmitDefaultValue=true)]
        public List<string> HdfsRecoverPattern { get; set; }

        /// <summary>
        /// A target directory where all the recovered entities are created
        /// </summary>
        /// <value>A target directory where all the recovered entities are created</value>
        [DataMember(Name="targetDirectory", EmitDefaultValue=true)]
        public string TargetDirectory { get; set; }

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
            return this.Equals(input as HdfsRecoverJobParams);
        }

        /// <summary>
        /// Returns true if HdfsRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HdfsRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HdfsRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HdfsExcludePattern == input.HdfsExcludePattern ||
                    this.HdfsExcludePattern != null &&
                    input.HdfsExcludePattern != null &&
                    this.HdfsExcludePattern.Equals(input.HdfsExcludePattern)
                ) && 
                (
                    this.HdfsRecoverPattern == input.HdfsRecoverPattern ||
                    this.HdfsRecoverPattern != null &&
                    input.HdfsRecoverPattern != null &&
                    this.HdfsRecoverPattern.Equals(input.HdfsRecoverPattern)
                ) && 
                (
                    this.TargetDirectory == input.TargetDirectory ||
                    (this.TargetDirectory != null &&
                    this.TargetDirectory.Equals(input.TargetDirectory))
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
                if (this.HdfsExcludePattern != null)
                    hashCode = hashCode * 59 + this.HdfsExcludePattern.GetHashCode();
                if (this.HdfsRecoverPattern != null)
                    hashCode = hashCode * 59 + this.HdfsRecoverPattern.GetHashCode();
                if (this.TargetDirectory != null)
                    hashCode = hashCode * 59 + this.TargetDirectory.GetHashCode();
                return hashCode;
            }
        }

    }

}

