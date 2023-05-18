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
    /// DocError
    /// </summary>
    [DataContract]
    public partial class DocError :  IEquatable<DocError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocError" /> class.
        /// </summary>
        /// <param name="documentId">DocumentId is document which caused the error..</param>
        /// <param name="errorString">ErrorString is the error converted to string..</param>
        public DocError(string documentId = default(string), string errorString = default(string))
        {
            this.DocumentId = documentId;
            this.ErrorString = errorString;
            this.DocumentId = documentId;
            this.ErrorString = errorString;
        }
        
        /// <summary>
        /// DocumentId is document which caused the error.
        /// </summary>
        /// <value>DocumentId is document which caused the error.</value>
        [DataMember(Name="documentId", EmitDefaultValue=true)]
        public string DocumentId { get; set; }

        /// <summary>
        /// ErrorString is the error converted to string.
        /// </summary>
        /// <value>ErrorString is the error converted to string.</value>
        [DataMember(Name="errorString", EmitDefaultValue=true)]
        public string ErrorString { get; set; }

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
            return this.Equals(input as DocError);
        }

        /// <summary>
        /// Returns true if DocError instances are equal
        /// </summary>
        /// <param name="input">Instance of DocError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.ErrorString == input.ErrorString ||
                    (this.ErrorString != null &&
                    this.ErrorString.Equals(input.ErrorString))
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
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.ErrorString != null)
                    hashCode = hashCode * 59 + this.ErrorString.GetHashCode();
                return hashCode;
            }
        }

    }

}

