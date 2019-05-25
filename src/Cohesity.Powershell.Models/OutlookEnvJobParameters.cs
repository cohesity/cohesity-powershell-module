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
    /// Specifies job parameters applicable for all &#39;kO365Outlook&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class OutlookEnvJobParameters :  IEquatable<OutlookEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookEnvJobParameters" /> class.
        /// </summary>
        /// <param name="filePathFilter">filePathFilter.</param>
        public OutlookEnvJobParameters(FilePathFilter filePathFilter = default(FilePathFilter))
        {
            this.FilePathFilter = filePathFilter;
        }
        
        /// <summary>
        /// Gets or Sets FilePathFilter
        /// </summary>
        [DataMember(Name="filePathFilter", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutlookEnvJobParameters {\n");
            sb.Append("  FilePathFilter: ").Append(FilePathFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as OutlookEnvJobParameters);
        }

        /// <summary>
        /// Returns true if OutlookEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePathFilter == input.FilePathFilter ||
                    (this.FilePathFilter != null &&
                    this.FilePathFilter.Equals(input.FilePathFilter))
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
                if (this.FilePathFilter != null)
                    hashCode = hashCode * 59 + this.FilePathFilter.GetHashCode();
                return hashCode;
            }
        }

    }

}
