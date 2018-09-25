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
    /// Specifies filters to match files and directories on a Server. Two kinds of filters are supported. a) prefix which always starts with &#39;/&#39;. b) posix which always starts with &#39;*&#39; (cannot be \&quot;*\&quot; only). Regular expressions are not supported. If a directory is matched, the action is applicable to all of its descendants. File paths not matching any protectFilters are not backed up.  An example is: Protect Filters: \&quot;/\&quot; Exclude Filters: \&quot;/tmp\&quot;, \&quot;*.mp4\&quot; Using such a policy will include everything under the root directory except the /tmp directory and all the mp4 files.
    /// </summary>
    [DataContract]
    public partial class FilePathFilter :  IEquatable<FilePathFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePathFilter" /> class.
        /// </summary>
        /// <param name="excludeFilters">Specifies filters to match files or directories that should be removed from the list of objects matching ProtectFilters..</param>
        /// <param name="protectFilters">Specifies filters to match files or directories that should be protected..</param>
        public FilePathFilter(List<string> excludeFilters = default(List<string>), List<string> protectFilters = default(List<string>))
        {
            this.ExcludeFilters = excludeFilters;
            this.ProtectFilters = protectFilters;
        }
        
        /// <summary>
        /// Specifies filters to match files or directories that should be removed from the list of objects matching ProtectFilters.
        /// </summary>
        /// <value>Specifies filters to match files or directories that should be removed from the list of objects matching ProtectFilters.</value>
        [DataMember(Name="excludeFilters", EmitDefaultValue=false)]
        public List<string> ExcludeFilters { get; set; }

        /// <summary>
        /// Specifies filters to match files or directories that should be protected.
        /// </summary>
        /// <value>Specifies filters to match files or directories that should be protected.</value>
        [DataMember(Name="protectFilters", EmitDefaultValue=false)]
        public List<string> ProtectFilters { get; set; }

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
            return this.Equals(input as FilePathFilter);
        }

        /// <summary>
        /// Returns true if FilePathFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FilePathFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilePathFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeFilters == input.ExcludeFilters ||
                    this.ExcludeFilters != null &&
                    this.ExcludeFilters.SequenceEqual(input.ExcludeFilters)
                ) && 
                (
                    this.ProtectFilters == input.ProtectFilters ||
                    this.ProtectFilters != null &&
                    this.ProtectFilters.SequenceEqual(input.ProtectFilters)
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
                if (this.ExcludeFilters != null)
                    hashCode = hashCode * 59 + this.ExcludeFilters.GetHashCode();
                if (this.ProtectFilters != null)
                    hashCode = hashCode * 59 + this.ProtectFilters.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

