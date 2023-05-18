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
    /// Specifies discovery params for kSite entities. It should only be populated when the &#39;DiscoveryParams.discoverableObjectTypeList&#39; includes &#39;kSites&#39;.
    /// </summary>
    [DataContract]
    public partial class SitesDiscoveryParams :  IEquatable<SitesDiscoveryParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitesDiscoveryParams" /> class.
        /// </summary>
        /// <param name="enableSiteTagging">Specifies whether the SharePoint Sites will be tagged whether they belong to a group site or teams site..</param>
        public SitesDiscoveryParams(bool? enableSiteTagging = default(bool?))
        {
            this.EnableSiteTagging = enableSiteTagging;
            this.EnableSiteTagging = enableSiteTagging;
        }
        
        /// <summary>
        /// Specifies whether the SharePoint Sites will be tagged whether they belong to a group site or teams site.
        /// </summary>
        /// <value>Specifies whether the SharePoint Sites will be tagged whether they belong to a group site or teams site.</value>
        [DataMember(Name="enableSiteTagging", EmitDefaultValue=true)]
        public bool? EnableSiteTagging { get; set; }

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
            return this.Equals(input as SitesDiscoveryParams);
        }

        /// <summary>
        /// Returns true if SitesDiscoveryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SitesDiscoveryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SitesDiscoveryParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableSiteTagging == input.EnableSiteTagging ||
                    (this.EnableSiteTagging != null &&
                    this.EnableSiteTagging.Equals(input.EnableSiteTagging))
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
                if (this.EnableSiteTagging != null)
                    hashCode = hashCode * 59 + this.EnableSiteTagging.GetHashCode();
                return hashCode;
            }
        }

    }

}

