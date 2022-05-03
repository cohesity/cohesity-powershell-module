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
    /// Specifies the parameters to lock a file in a view.
    /// </summary>
    [DataContract]
    public partial class LockFileParams :  IEquatable<LockFileParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockFileParams" /> class.
        /// </summary>
        /// <param name="expiryTimestampMsecs">Specifies a definite timestamp in milliseconds for retaining the file, or to extend it&#39;s expiry timestamp..</param>
        /// <param name="path">Specifies the file path that needs to be locked..</param>
        public LockFileParams(int? expiryTimestampMsecs = default(int?), string path = default(string))
        {
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.Path = path;
        }
        
        /// <summary>
        /// Specifies a definite timestamp in milliseconds for retaining the file, or to extend it&#39;s expiry timestamp.
        /// </summary>
        /// <value>Specifies a definite timestamp in milliseconds for retaining the file, or to extend it&#39;s expiry timestamp.</value>
        [DataMember(Name="expiryTimestampMsecs", EmitDefaultValue=false)]
        public int? ExpiryTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the file path that needs to be locked.
        /// </summary>
        /// <value>Specifies the file path that needs to be locked.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

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
            return this.Equals(input as LockFileParams);
        }

        /// <summary>
        /// Returns true if LockFileParams instances are equal
        /// </summary>
        /// <param name="input">Instance of LockFileParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockFileParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryTimestampMsecs == input.ExpiryTimestampMsecs ||
                    (this.ExpiryTimestampMsecs != null &&
                    this.ExpiryTimestampMsecs.Equals(input.ExpiryTimestampMsecs))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.ExpiryTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimestampMsecs.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

