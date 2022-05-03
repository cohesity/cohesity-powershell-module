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
    /// Specifies information about an Office365 sharepoint Site.
    /// </summary>
    [DataContract]
    public partial class Office365SiteInfo :  IEquatable<Office365SiteInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365SiteInfo" /> class.
        /// </summary>
        /// <param name="isGroupSite">Specifies if the sharepoint site is associated with a group..</param>
        /// <param name="isPrivateChannelSite">Specifies if the sharepoint site is associated with a private channel of some team..</param>
        /// <param name="isTeamSite">Specifies if the sharepoint site is associated with a team..</param>
        public Office365SiteInfo(bool? isGroupSite = default(bool?), bool? isPrivateChannelSite = default(bool?), bool? isTeamSite = default(bool?))
        {
            this.IsGroupSite = isGroupSite;
            this.IsPrivateChannelSite = isPrivateChannelSite;
            this.IsTeamSite = isTeamSite;
        }
        
        /// <summary>
        /// Specifies if the sharepoint site is associated with a group.
        /// </summary>
        /// <value>Specifies if the sharepoint site is associated with a group.</value>
        [DataMember(Name="isGroupSite", EmitDefaultValue=false)]
        public bool? IsGroupSite { get; set; }

        /// <summary>
        /// Specifies if the sharepoint site is associated with a private channel of some team.
        /// </summary>
        /// <value>Specifies if the sharepoint site is associated with a private channel of some team.</value>
        [DataMember(Name="isPrivateChannelSite", EmitDefaultValue=false)]
        public bool? IsPrivateChannelSite { get; set; }

        /// <summary>
        /// Specifies if the sharepoint site is associated with a team.
        /// </summary>
        /// <value>Specifies if the sharepoint site is associated with a team.</value>
        [DataMember(Name="isTeamSite", EmitDefaultValue=false)]
        public bool? IsTeamSite { get; set; }

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
            return this.Equals(input as Office365SiteInfo);
        }

        /// <summary>
        /// Returns true if Office365SiteInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365SiteInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365SiteInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsGroupSite == input.IsGroupSite ||
                    (this.IsGroupSite != null &&
                    this.IsGroupSite.Equals(input.IsGroupSite))
                ) && 
                (
                    this.IsPrivateChannelSite == input.IsPrivateChannelSite ||
                    (this.IsPrivateChannelSite != null &&
                    this.IsPrivateChannelSite.Equals(input.IsPrivateChannelSite))
                ) && 
                (
                    this.IsTeamSite == input.IsTeamSite ||
                    (this.IsTeamSite != null &&
                    this.IsTeamSite.Equals(input.IsTeamSite))
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
                if (this.IsGroupSite != null)
                    hashCode = hashCode * 59 + this.IsGroupSite.GetHashCode();
                if (this.IsPrivateChannelSite != null)
                    hashCode = hashCode * 59 + this.IsPrivateChannelSite.GetHashCode();
                if (this.IsTeamSite != null)
                    hashCode = hashCode * 59 + this.IsTeamSite.GetHashCode();
                return hashCode;
            }
        }

    }

}

