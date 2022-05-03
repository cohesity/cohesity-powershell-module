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
        public PhysicalFileBackupParamsGlobalIncludeExclude(List<string> excludeVec = default(List<string>))
        {
            this.ExcludeVec = excludeVec;
        }
        
        /// <summary>
        /// Describes exclude vec at job level used in combination with to exclude_paths to exclude files.
        /// </summary>
        /// <value>Describes exclude vec at job level used in combination with to exclude_paths to exclude files.</value>
        [DataMember(Name="excludeVec", EmitDefaultValue=false)]
        public List<string> ExcludeVec { get; set; }

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
                    this.ExcludeVec.Equals(input.ExcludeVec)
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
                return hashCode;
            }
        }

    }

}

