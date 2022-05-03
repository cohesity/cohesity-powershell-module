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
    /// Specifies details about the pattern which has to be saved.
    /// </summary>
    [DataContract]
    public partial class PatternRequestBody :  IEquatable<PatternRequestBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatternRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternRequestBody" /> class.
        /// </summary>
        /// <param name="applicationDataType">Specifies the data type for which supported patterns can be fetched. (required).</param>
        /// <param name="applicationId">Specifies AWB Application ID. (required).</param>
        /// <param name="userPattern">userPattern (required).</param>
        public PatternRequestBody(int? applicationDataType = default(int?), long? applicationId = default(long?), SupportedPattern userPattern = default(SupportedPattern))
        {
            // to ensure "applicationDataType" is required (not null)
            if (applicationDataType == null)
            {
                throw new InvalidDataException("applicationDataType is a required property for PatternRequestBody and cannot be null");
            }
            else
            {
                this.ApplicationDataType = applicationDataType;
            }
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for PatternRequestBody and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            // to ensure "userPattern" is required (not null)
            if (userPattern == null)
            {
                throw new InvalidDataException("userPattern is a required property for PatternRequestBody and cannot be null");
            }
            else
            {
                this.UserPattern = userPattern;
            }
        }
        
        /// <summary>
        /// Specifies the data type for which supported patterns can be fetched.
        /// </summary>
        /// <value>Specifies the data type for which supported patterns can be fetched.</value>
        [DataMember(Name="applicationDataType", EmitDefaultValue=false)]
        public int? ApplicationDataType { get; set; }

        /// <summary>
        /// Specifies AWB Application ID.
        /// </summary>
        /// <value>Specifies AWB Application ID.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets UserPattern
        /// </summary>
        [DataMember(Name="userPattern", EmitDefaultValue=false)]
        public SupportedPattern UserPattern { get; set; }

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
            return this.Equals(input as PatternRequestBody);
        }

        /// <summary>
        /// Returns true if PatternRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PatternRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatternRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationDataType == input.ApplicationDataType ||
                    (this.ApplicationDataType != null &&
                    this.ApplicationDataType.Equals(input.ApplicationDataType))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.UserPattern == input.UserPattern ||
                    (this.UserPattern != null &&
                    this.UserPattern.Equals(input.UserPattern))
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
                if (this.ApplicationDataType != null)
                    hashCode = hashCode * 59 + this.ApplicationDataType.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.UserPattern != null)
                    hashCode = hashCode * 59 + this.UserPattern.GetHashCode();
                return hashCode;
            }
        }

    }

}

