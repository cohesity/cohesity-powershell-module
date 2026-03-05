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
    /// S3TaggingFilter
    /// </summary>
    [DataContract]
    public partial class S3TaggingFilter :  IEquatable<S3TaggingFilter>
    {
        /// <summary>
        /// The mode applied to the list of S3 tags &#39;kWhitelist&#39; indicates a allowlist extension filter. &#39;kBlacklist&#39; indicates a denylist extension filter.
        /// </summary>
        /// <value>The mode applied to the list of S3 tags &#39;kWhitelist&#39; indicates a allowlist extension filter. &#39;kBlacklist&#39; indicates a denylist extension filter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum KWhitelist for value: kWhitelist
            /// </summary>
            [EnumMember(Value = "kWhitelist")]
            KWhitelist = 1,

            /// <summary>
            /// Enum KBlacklist for value: kBlacklist
            /// </summary>
            [EnumMember(Value = "kBlacklist")]
            KBlacklist = 2

        }

        /// <summary>
        /// The mode applied to the list of S3 tags &#39;kWhitelist&#39; indicates a allowlist extension filter. &#39;kBlacklist&#39; indicates a denylist extension filter.
        /// </summary>
        /// <value>The mode applied to the list of S3 tags &#39;kWhitelist&#39; indicates a allowlist extension filter. &#39;kBlacklist&#39; indicates a denylist extension filter.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3TaggingFilter" /> class.
        /// </summary>
        /// <param name="isEnabled">If set, it enables the S3 tagging filter.</param>
        /// <param name="mode">The mode applied to the list of S3 tags &#39;kWhitelist&#39; indicates a allowlist extension filter. &#39;kBlacklist&#39; indicates a denylist extension filter..</param>
        /// <param name="tagSet">The list of S3 tags to apply.</param>
        public S3TaggingFilter(bool? isEnabled = default(bool?), ModeEnum? mode = default(ModeEnum?), Dictionary<string, string> tagSet = default(Dictionary<string, string>))
        {
            this.IsEnabled = isEnabled;
            this.Mode = mode;
            this.TagSet = tagSet;
            this.IsEnabled = isEnabled;
            this.Mode = mode;
            this.TagSet = tagSet;
        }
        
        /// <summary>
        /// If set, it enables the S3 tagging filter
        /// </summary>
        /// <value>If set, it enables the S3 tagging filter</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// The list of S3 tags to apply
        /// </summary>
        /// <value>The list of S3 tags to apply</value>
        [DataMember(Name="tagSet", EmitDefaultValue=true)]
        public Dictionary<string, string> TagSet { get; set; }

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
            return this.Equals(input as S3TaggingFilter);
        }

        /// <summary>
        /// Returns true if S3TaggingFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of S3TaggingFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3TaggingFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.TagSet == input.TagSet ||
                    this.TagSet != null &&
                    input.TagSet != null &&
                    this.TagSet.SequenceEqual(input.TagSet)
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
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.TagSet != null)
                    hashCode = hashCode * 59 + this.TagSet.GetHashCode();
                return hashCode;
            }
        }

    }

}

