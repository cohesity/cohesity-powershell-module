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
    /// ViewPinningConfig
    /// </summary>
    [DataContract]
    public partial class ViewPinningConfig :  IEquatable<ViewPinningConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPinningConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViewPinningConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPinningConfig" /> class.
        /// </summary>
        /// <param name="enabled">Specifies if view pinning is enabled. If set to true, view will be pinned to SSD. (required).</param>
        /// <param name="pinnedTimeSecs">Specifies the time to pin files after last access..</param>
        public ViewPinningConfig(bool? enabled = default(bool?), long? pinnedTimeSecs = default(long?))
        {
            this.Enabled = enabled;
            this.PinnedTimeSecs = pinnedTimeSecs;
            this.PinnedTimeSecs = pinnedTimeSecs;
        }
        
        /// <summary>
        /// Specifies if view pinning is enabled. If set to true, view will be pinned to SSD.
        /// </summary>
        /// <value>Specifies if view pinning is enabled. If set to true, view will be pinned to SSD.</value>
        [DataMember(Name="enabled", EmitDefaultValue=true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies the timestamp when view pinning config is last updated.
        /// </summary>
        /// <value>Specifies the timestamp when view pinning config is last updated.</value>
        [DataMember(Name="lastUpdatedTimestampSecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimestampSecs { get; private set; }

        /// <summary>
        /// Specifies the time to pin files after last access.
        /// </summary>
        /// <value>Specifies the time to pin files after last access.</value>
        [DataMember(Name="pinnedTimeSecs", EmitDefaultValue=true)]
        public long? PinnedTimeSecs { get; set; }

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
            return this.Equals(input as ViewPinningConfig);
        }

        /// <summary>
        /// Returns true if ViewPinningConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewPinningConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewPinningConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.LastUpdatedTimestampSecs == input.LastUpdatedTimestampSecs ||
                    (this.LastUpdatedTimestampSecs != null &&
                    this.LastUpdatedTimestampSecs.Equals(input.LastUpdatedTimestampSecs))
                ) && 
                (
                    this.PinnedTimeSecs == input.PinnedTimeSecs ||
                    (this.PinnedTimeSecs != null &&
                    this.PinnedTimeSecs.Equals(input.PinnedTimeSecs))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.LastUpdatedTimestampSecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimestampSecs.GetHashCode();
                if (this.PinnedTimeSecs != null)
                    hashCode = hashCode * 59 + this.PinnedTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

