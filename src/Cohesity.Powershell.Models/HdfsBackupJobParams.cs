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
    /// Contains any additional hdfs environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class HdfsBackupJobParams :  IEquatable<HdfsBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HdfsBackupJobParams" /> class.
        /// </summary>
        /// <param name="hdfsExcludePattern">Any path/Glob pattern from HDFS that is to excluded..</param>
        /// <param name="hdfsProtectPattern">Any path/Glob pattern from HDFS that is to protected..</param>
        public HdfsBackupJobParams(List<string> hdfsExcludePattern = default(List<string>), List<string> hdfsProtectPattern = default(List<string>))
        {
            this.HdfsExcludePattern = hdfsExcludePattern;
            this.HdfsProtectPattern = hdfsProtectPattern;
            this.HdfsExcludePattern = hdfsExcludePattern;
            this.HdfsProtectPattern = hdfsProtectPattern;
        }
        
        /// <summary>
        /// Any path/Glob pattern from HDFS that is to excluded.
        /// </summary>
        /// <value>Any path/Glob pattern from HDFS that is to excluded.</value>
        [DataMember(Name="hdfsExcludePattern", EmitDefaultValue=true)]
        public List<string> HdfsExcludePattern { get; set; }

        /// <summary>
        /// Any path/Glob pattern from HDFS that is to protected.
        /// </summary>
        /// <value>Any path/Glob pattern from HDFS that is to protected.</value>
        [DataMember(Name="hdfsProtectPattern", EmitDefaultValue=true)]
        public List<string> HdfsProtectPattern { get; set; }

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
            return this.Equals(input as HdfsBackupJobParams);
        }

        /// <summary>
        /// Returns true if HdfsBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HdfsBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HdfsBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HdfsExcludePattern == input.HdfsExcludePattern ||
                    this.HdfsExcludePattern != null &&
                    input.HdfsExcludePattern != null &&
                    this.HdfsExcludePattern.SequenceEqual(input.HdfsExcludePattern)
                ) && 
                (
                    this.HdfsProtectPattern == input.HdfsProtectPattern ||
                    this.HdfsProtectPattern != null &&
                    input.HdfsProtectPattern != null &&
                    this.HdfsProtectPattern.SequenceEqual(input.HdfsProtectPattern)
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
                if (this.HdfsProtectPattern != null)
                    hashCode = hashCode * 59 + this.HdfsProtectPattern.GetHashCode();
                return hashCode;
            }
        }

    }

}

