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
    /// Specifies S3 specific information about an S3 Entity.
    /// </summary>
    [DataContract]
    public partial class S3EntityInfo :  IEquatable<S3EntityInfo>
    {
        /// <summary>
        /// Specifies the Versioning state of S3 bucket. Specifies the versioning state of S3 bucket. &#39;kUnversioned&#39; implies versioning is not enabled. &#39;kEnabled&#39; implies versioning is enabled. &#39;kSuspended&#39; versioning is suspended.
        /// </summary>
        /// <value>Specifies the Versioning state of S3 bucket. Specifies the versioning state of S3 bucket. &#39;kUnversioned&#39; implies versioning is not enabled. &#39;kEnabled&#39; implies versioning is enabled. &#39;kSuspended&#39; versioning is suspended.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersioningEnum
        {
            /// <summary>
            /// Enum KUnversioned for value: kUnversioned
            /// </summary>
            [EnumMember(Value = "kUnversioned")]
            KUnversioned = 1,

            /// <summary>
            /// Enum KEnabled for value: kEnabled
            /// </summary>
            [EnumMember(Value = "kEnabled")]
            KEnabled = 2,

            /// <summary>
            /// Enum KSuspended for value: kSuspended
            /// </summary>
            [EnumMember(Value = "kSuspended")]
            KSuspended = 3

        }

        /// <summary>
        /// Specifies the Versioning state of S3 bucket. Specifies the versioning state of S3 bucket. &#39;kUnversioned&#39; implies versioning is not enabled. &#39;kEnabled&#39; implies versioning is enabled. &#39;kSuspended&#39; versioning is suspended.
        /// </summary>
        /// <value>Specifies the Versioning state of S3 bucket. Specifies the versioning state of S3 bucket. &#39;kUnversioned&#39; implies versioning is not enabled. &#39;kEnabled&#39; implies versioning is enabled. &#39;kSuspended&#39; versioning is suspended.</value>
        [DataMember(Name="versioning", EmitDefaultValue=true)]
        public VersioningEnum? Versioning { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3EntityInfo" /> class.
        /// </summary>
        /// <param name="createTimeMsecs">Specifies the creation time of the entity..</param>
        /// <param name="versioning">Specifies the Versioning state of S3 bucket. Specifies the versioning state of S3 bucket. &#39;kUnversioned&#39; implies versioning is not enabled. &#39;kEnabled&#39; implies versioning is enabled. &#39;kSuspended&#39; versioning is suspended..</param>
        public S3EntityInfo(long? createTimeMsecs = default(long?), VersioningEnum? versioning = default(VersioningEnum?))
        {
            this.CreateTimeMsecs = createTimeMsecs;
            this.Versioning = versioning;
            this.CreateTimeMsecs = createTimeMsecs;
            this.Versioning = versioning;
        }
        
        /// <summary>
        /// Specifies the creation time of the entity.
        /// </summary>
        /// <value>Specifies the creation time of the entity.</value>
        [DataMember(Name="createTimeMsecs", EmitDefaultValue=true)]
        public long? CreateTimeMsecs { get; set; }

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
            return this.Equals(input as S3EntityInfo);
        }

        /// <summary>
        /// Returns true if S3EntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of S3EntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3EntityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateTimeMsecs == input.CreateTimeMsecs ||
                    (this.CreateTimeMsecs != null &&
                    this.CreateTimeMsecs.Equals(input.CreateTimeMsecs))
                ) && 
                (
                    this.Versioning == input.Versioning ||
                    this.Versioning.Equals(input.Versioning)
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
                if (this.CreateTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreateTimeMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Versioning.GetHashCode();
                return hashCode;
            }
        }

    }

}

