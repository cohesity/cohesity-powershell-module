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
    /// Specifies id of a banner.
    /// </summary>
    [DataContract]
    public partial class BannerIdData :  IEquatable<BannerIdData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BannerIdData" /> class.
        /// </summary>
        /// <param name="bannerId">Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe..</param>
        public BannerIdData(string bannerId = default(string))
        {
            this.BannerId = bannerId;
            this.BannerId = bannerId;
        }
        
        /// <summary>
        /// Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe.
        /// </summary>
        /// <value>Specifies a banner_id which can uniquely identify a banner. This may be the cluster_id, or the tenant_id, or the group_id, or the user SID etc. If this field is nil, the it is assumed to be the cluster_id. The content is stored against this &#39;row&#39; in Scribe.</value>
        [DataMember(Name="bannerId", EmitDefaultValue=true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BannerIdData {\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as BannerIdData);
        }

        /// <summary>
        /// Returns true if BannerIdData instances are equal
        /// </summary>
        /// <param name="input">Instance of BannerIdData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BannerIdData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
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
                return hashCode;
            }
        }

    }

}
