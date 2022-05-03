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
    /// AuditLogSettings specifies struct with audt log configuration. Make these settings in such a way that zero values are cluster default when bb is not present.
    /// </summary>
    [DataContract]
    public partial class AuditLogSettings :  IEquatable<AuditLogSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogSettings" /> class.
        /// </summary>
        /// <param name="readLogging">ReadLogging specifies whether read logs needs to be captured..</param>
        public AuditLogSettings(bool? readLogging = default(bool?))
        {
            this.ReadLogging = readLogging;
        }
        
        /// <summary>
        /// ReadLogging specifies whether read logs needs to be captured.
        /// </summary>
        /// <value>ReadLogging specifies whether read logs needs to be captured.</value>
        [DataMember(Name="readLogging", EmitDefaultValue=false)]
        public bool? ReadLogging { get; set; }

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
            return this.Equals(input as AuditLogSettings);
        }

        /// <summary>
        /// Returns true if AuditLogSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadLogging == input.ReadLogging ||
                    (this.ReadLogging != null &&
                    this.ReadLogging.Equals(input.ReadLogging))
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
                if (this.ReadLogging != null)
                    hashCode = hashCode * 59 + this.ReadLogging.GetHashCode();
                return hashCode;
            }
        }

    }

}

