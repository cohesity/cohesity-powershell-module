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
    /// Banner is used for storing the banner content in scribe and also for transferring it over the wire.
    /// </summary>
    [DataContract]
    public partial class Banner :  IEquatable<Banner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Banner" /> class.
        /// </summary>
        /// <param name="bannerId">Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe..</param>
        /// <param name="content">Specifies the content of the banner..</param>
        /// <param name="createdTimeMsecs">Timestamp at which banner was created..</param>
        /// <param name="description">Specifies the description of this banner..</param>
        /// <param name="lastUpdatedTimeMsecs">Timestamp at which banner was last updated..</param>
        public Banner(string bannerId = default(string), string content = default(string), long? createdTimeMsecs = default(long?), string description = default(string), long? lastUpdatedTimeMsecs = default(long?))
        {
            this.BannerId = bannerId;
            this.Content = content;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.BannerId = bannerId;
            this.Content = content;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
        }
        
        /// <summary>
        /// Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe.
        /// </summary>
        /// <value>Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe.</value>
        [DataMember(Name="bannerId", EmitDefaultValue=true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Specifies the content of the banner.
        /// </summary>
        /// <value>Specifies the content of the banner.</value>
        [DataMember(Name="content", EmitDefaultValue=true)]
        public string Content { get; set; }

        /// <summary>
        /// Timestamp at which banner was created.
        /// </summary>
        /// <value>Timestamp at which banner was created.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the description of this banner.
        /// </summary>
        /// <value>Specifies the description of this banner.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Timestamp at which banner was last updated.
        /// </summary>
        /// <value>Timestamp at which banner was last updated.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

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
            return this.Equals(input as Banner);
        }

        /// <summary>
        /// Returns true if Banner instances are equal
        /// </summary>
        /// <param name="input">Instance of Banner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Banner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
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
                if (this.BannerId != null)
                    hashCode = hashCode * 59 + this.BannerId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

