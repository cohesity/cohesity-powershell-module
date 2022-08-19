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
    /// Descibes job level includes and excludes. Right now, only supports excludes but includes will be added in future.
    /// </summary>
    [DataContract]
    public partial class PhysicalFileBackupParamsGlobalIncludeExclude :  IEquatable<PhysicalFileBackupParamsGlobalIncludeExclude>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalFileBackupParamsGlobalIncludeExclude" /> class.
        /// </summary>
        /// <param name="excludeVec">Describes exclude vec at job level used in combination with to exclude_paths to exclude files..</param>
        /// <param name="fsExclude">Global filesystem exclude vec.</param>
        public PhysicalFileBackupParamsGlobalIncludeExclude(List<string> excludeVec = default(List<string>), List<string> fsExclude = default(List<string>))
        {
            this.ExcludeVec = excludeVec;
            this.FsExclude = fsExclude;
        }
        
        /// <summary>
        /// Describes exclude vec at job level used in combination with to exclude_paths to exclude files.
        /// </summary>
        /// <value>Describes exclude vec at job level used in combination with to exclude_paths to exclude files.</value>
        [DataMember(Name="excludeVec", EmitDefaultValue=true)]
        public List<string> ExcludeVec { get; set; }

        /// <summary>
        /// Global filesystem exclude vec
        /// </summary>
        /// <value>Global filesystem exclude vec</value>
        [DataMember(Name="fsExclude", EmitDefaultValue=true)]
        public List<string> FsExclude { get; set; }

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
            return this.Equals(input as PhysicalFileBackupParamsGlobalIncludeExclude);
        }

        /// <summary>
        /// Returns true if PhysicalFileBackupParamsGlobalIncludeExclude instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalFileBackupParamsGlobalIncludeExclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalFileBackupParamsGlobalIncludeExclude input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeVec == input.ExcludeVec ||
                    this.ExcludeVec != null &&
                    input.ExcludeVec != null &&
                    this.ExcludeVec.Equals(input.ExcludeVec)
                ) && 
                (
                    this.FsExclude == input.FsExclude ||
                    this.FsExclude != null &&
                    input.FsExclude != null &&
                    this.FsExclude.Equals(input.FsExclude)
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
                if (this.ExcludeVec != null)
                    hashCode = hashCode * 59 + this.ExcludeVec.GetHashCode();
                if (this.FsExclude != null)
                    hashCode = hashCode * 59 + this.FsExclude.GetHashCode();
                return hashCode;
            }
        }

    }

}

