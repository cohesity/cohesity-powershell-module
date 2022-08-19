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
    /// ExpirationAction
    /// </summary>
    [DataContract]
    public partial class ExpirationAction :  IEquatable<ExpirationAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpirationAction" /> class.
        /// </summary>
        /// <param name="dateUsecs">Timestamp in usecs for the date the object is subject to the rule..</param>
        /// <param name="days">Lifetime in days, of the objects that are subject to the rule..</param>
        /// <param name="expiredObjectDeleteMarker">Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set, the delete marker will be expired..</param>
        public ExpirationAction(long? dateUsecs = default(long?), int? days = default(int?), bool? expiredObjectDeleteMarker = default(bool?))
        {
            this.DateUsecs = dateUsecs;
            this.Days = days;
            this.ExpiredObjectDeleteMarker = expiredObjectDeleteMarker;
            this.DateUsecs = dateUsecs;
            this.Days = days;
            this.ExpiredObjectDeleteMarker = expiredObjectDeleteMarker;
        }
        
        /// <summary>
        /// Timestamp in usecs for the date the object is subject to the rule.
        /// </summary>
        /// <value>Timestamp in usecs for the date the object is subject to the rule.</value>
        [DataMember(Name="dateUsecs", EmitDefaultValue=true)]
        public long? DateUsecs { get; set; }

        /// <summary>
        /// Lifetime in days, of the objects that are subject to the rule.
        /// </summary>
        /// <value>Lifetime in days, of the objects that are subject to the rule.</value>
        [DataMember(Name="days", EmitDefaultValue=true)]
        public int? Days { get; set; }

        /// <summary>
        /// Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set, the delete marker will be expired.
        /// </summary>
        /// <value>Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set, the delete marker will be expired.</value>
        [DataMember(Name="expiredObjectDeleteMarker", EmitDefaultValue=true)]
        public bool? ExpiredObjectDeleteMarker { get; set; }

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
            return this.Equals(input as ExpirationAction);
        }

        /// <summary>
        /// Returns true if ExpirationAction instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpirationAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpirationAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateUsecs == input.DateUsecs ||
                    (this.DateUsecs != null &&
                    this.DateUsecs.Equals(input.DateUsecs))
                ) && 
                (
                    this.Days == input.Days ||
                    (this.Days != null &&
                    this.Days.Equals(input.Days))
                ) && 
                (
                    this.ExpiredObjectDeleteMarker == input.ExpiredObjectDeleteMarker ||
                    (this.ExpiredObjectDeleteMarker != null &&
                    this.ExpiredObjectDeleteMarker.Equals(input.ExpiredObjectDeleteMarker))
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
                if (this.DateUsecs != null)
                    hashCode = hashCode * 59 + this.DateUsecs.GetHashCode();
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.ExpiredObjectDeleteMarker != null)
                    hashCode = hashCode * 59 + this.ExpiredObjectDeleteMarker.GetHashCode();
                return hashCode;
            }
        }

    }

}

