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
    /// Protobuf that describes the lifecycle configuration that is used to manage the lifecycle of objects in a bucket.
    /// </summary>
    [DataContract]
    public partial class LifecycleConfigProto :  IEquatable<LifecycleConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleConfigProto" /> class.
        /// </summary>
        /// <param name="rules">Specifies lifecycle configuration rules for an Amazon S3 bucket. A maximum of 1000 rules can be specified..</param>
        /// <param name="versionId">Specifies the uniq monotonically increasing version for lifecycle configuration..</param>
        public LifecycleConfigProto(List<LifecycleRule> rules = default(List<LifecycleRule>), long? versionId = default(long?))
        {
            this.Rules = rules;
            this.VersionId = versionId;
        }
        
        /// <summary>
        /// Specifies lifecycle configuration rules for an Amazon S3 bucket. A maximum of 1000 rules can be specified.
        /// </summary>
        /// <value>Specifies lifecycle configuration rules for an Amazon S3 bucket. A maximum of 1000 rules can be specified.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<LifecycleRule> Rules { get; set; }

        /// <summary>
        /// Specifies the uniq monotonically increasing version for lifecycle configuration.
        /// </summary>
        /// <value>Specifies the uniq monotonically increasing version for lifecycle configuration.</value>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public long? VersionId { get; set; }

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
            return this.Equals(input as LifecycleConfigProto);
        }

        /// <summary>
        /// Returns true if LifecycleConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    this.Rules.Equals(input.Rules)
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
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
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                return hashCode;
            }
        }

    }

}

