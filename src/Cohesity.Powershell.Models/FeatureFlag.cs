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
    /// Specify feature flag override status.
    /// </summary>
    [DataContract]
    public partial class FeatureFlag :  IEquatable<FeatureFlag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeatureFlag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlag" /> class.
        /// </summary>
        /// <param name="isApproved">Specifies the overridden approval status..</param>
        /// <param name="isUiFeature">Specifies if it&#39;s a front-end(UI) or back-end feature..</param>
        /// <param name="name">Specifies name of the feature. (required).</param>
        /// <param name="reason">Specifies the reason for override..</param>
        /// <param name="timestamp">Specifies the timestamp of override..</param>
        public FeatureFlag(bool? isApproved = default(bool?), bool? isUiFeature = default(bool?), string name = default(string), string reason = default(string), long? timestamp = default(long?))
        {
            this.IsApproved = isApproved;
            this.IsUiFeature = isUiFeature;
            this.Name = name;
            this.Reason = reason;
            this.Timestamp = timestamp;
            this.IsApproved = isApproved;
            this.IsUiFeature = isUiFeature;
            this.Reason = reason;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Specifies the overridden approval status.
        /// </summary>
        /// <value>Specifies the overridden approval status.</value>
        [DataMember(Name="isApproved", EmitDefaultValue=true)]
        public bool? IsApproved { get; set; }

        /// <summary>
        /// Specifies if it&#39;s a front-end(UI) or back-end feature.
        /// </summary>
        /// <value>Specifies if it&#39;s a front-end(UI) or back-end feature.</value>
        [DataMember(Name="isUiFeature", EmitDefaultValue=true)]
        public bool? IsUiFeature { get; set; }

        /// <summary>
        /// Specifies name of the feature.
        /// </summary>
        /// <value>Specifies name of the feature.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the reason for override.
        /// </summary>
        /// <value>Specifies the reason for override.</value>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Specifies the timestamp of override.
        /// </summary>
        /// <value>Specifies the timestamp of override.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
        public long? Timestamp { get; set; }

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
            return this.Equals(input as FeatureFlag);
        }

        /// <summary>
        /// Returns true if FeatureFlag instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureFlag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureFlag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsApproved == input.IsApproved ||
                    (this.IsApproved != null &&
                    this.IsApproved.Equals(input.IsApproved))
                ) && 
                (
                    this.IsUiFeature == input.IsUiFeature ||
                    (this.IsUiFeature != null &&
                    this.IsUiFeature.Equals(input.IsUiFeature))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.IsApproved != null)
                    hashCode = hashCode * 59 + this.IsApproved.GetHashCode();
                if (this.IsUiFeature != null)
                    hashCode = hashCode * 59 + this.IsUiFeature.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

    }

}

