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
    /// AbortIncompleteMultipartUploadAction
    /// </summary>
    [DataContract]
    public partial class AbortIncompleteMultipartUploadAction :  IEquatable<AbortIncompleteMultipartUploadAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbortIncompleteMultipartUploadAction" /> class.
        /// </summary>
        /// <param name="daysAfterInitiation">Specifies the number of days after which to abort an incomplete multipart upload..</param>
        public AbortIncompleteMultipartUploadAction(long? daysAfterInitiation = default(long?))
        {
            this.DaysAfterInitiation = daysAfterInitiation;
            this.DaysAfterInitiation = daysAfterInitiation;
        }
        
        /// <summary>
        /// Specifies the number of days after which to abort an incomplete multipart upload.
        /// </summary>
        /// <value>Specifies the number of days after which to abort an incomplete multipart upload.</value>
        [DataMember(Name="daysAfterInitiation", EmitDefaultValue=true)]
        public long? DaysAfterInitiation { get; set; }

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
            return this.Equals(input as AbortIncompleteMultipartUploadAction);
        }

        /// <summary>
        /// Returns true if AbortIncompleteMultipartUploadAction instances are equal
        /// </summary>
        /// <param name="input">Instance of AbortIncompleteMultipartUploadAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbortIncompleteMultipartUploadAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysAfterInitiation == input.DaysAfterInitiation ||
                    (this.DaysAfterInitiation != null &&
                    this.DaysAfterInitiation.Equals(input.DaysAfterInitiation))
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
                if (this.DaysAfterInitiation != null)
                    hashCode = hashCode * 59 + this.DaysAfterInitiation.GetHashCode();
                return hashCode;
            }
        }

    }

}

