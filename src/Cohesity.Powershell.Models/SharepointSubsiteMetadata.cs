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
    /// SharepointSubsiteMetadata
    /// </summary>
    [DataContract]
    public partial class SharepointSubsiteMetadata :  IEquatable<SharepointSubsiteMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointSubsiteMetadata" /> class.
        /// </summary>
        /// <param name="absoluteSubsiteItemPath">The item full path from the root site with subsite names in the path and this is used to display the path with display names in the UI. Eg. for subsite_3 path will be, root_site/subsite_1/subsite_2/subsite_3/doclib_name/folder_path..</param>
        /// <param name="relativeSubsiteItemPath">Relative subsite display path i.e the path from the subsite level. For eg. /subsite_1/subsite_2/doclib_name/file1.txt relative_subsite_item_path represents /doclib_name/file1.txt..</param>
        /// <param name="siteType">The type of subsite, it can be PrivateChannelSubsite or GroupSubsite..</param>
        /// <param name="siteUuid">The site uuid this subsite belongs..</param>
        public SharepointSubsiteMetadata(string absoluteSubsiteItemPath = default(string), string relativeSubsiteItemPath = default(string), string siteType = default(string), string siteUuid = default(string))
        {
            this.AbsoluteSubsiteItemPath = absoluteSubsiteItemPath;
            this.RelativeSubsiteItemPath = relativeSubsiteItemPath;
            this.SiteType = siteType;
            this.SiteUuid = siteUuid;
            this.AbsoluteSubsiteItemPath = absoluteSubsiteItemPath;
            this.RelativeSubsiteItemPath = relativeSubsiteItemPath;
            this.SiteType = siteType;
            this.SiteUuid = siteUuid;
        }
        
        /// <summary>
        /// The item full path from the root site with subsite names in the path and this is used to display the path with display names in the UI. Eg. for subsite_3 path will be, root_site/subsite_1/subsite_2/subsite_3/doclib_name/folder_path.
        /// </summary>
        /// <value>The item full path from the root site with subsite names in the path and this is used to display the path with display names in the UI. Eg. for subsite_3 path will be, root_site/subsite_1/subsite_2/subsite_3/doclib_name/folder_path.</value>
        [DataMember(Name="absoluteSubsiteItemPath", EmitDefaultValue=true)]
        public string AbsoluteSubsiteItemPath { get; set; }

        /// <summary>
        /// Relative subsite display path i.e the path from the subsite level. For eg. /subsite_1/subsite_2/doclib_name/file1.txt relative_subsite_item_path represents /doclib_name/file1.txt.
        /// </summary>
        /// <value>Relative subsite display path i.e the path from the subsite level. For eg. /subsite_1/subsite_2/doclib_name/file1.txt relative_subsite_item_path represents /doclib_name/file1.txt.</value>
        [DataMember(Name="relativeSubsiteItemPath", EmitDefaultValue=true)]
        public string RelativeSubsiteItemPath { get; set; }

        /// <summary>
        /// The type of subsite, it can be PrivateChannelSubsite or GroupSubsite.
        /// </summary>
        /// <value>The type of subsite, it can be PrivateChannelSubsite or GroupSubsite.</value>
        [DataMember(Name="siteType", EmitDefaultValue=true)]
        public string SiteType { get; set; }

        /// <summary>
        /// The site uuid this subsite belongs.
        /// </summary>
        /// <value>The site uuid this subsite belongs.</value>
        [DataMember(Name="siteUuid", EmitDefaultValue=true)]
        public string SiteUuid { get; set; }

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
            return this.Equals(input as SharepointSubsiteMetadata);
        }

        /// <summary>
        /// Returns true if SharepointSubsiteMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of SharepointSubsiteMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharepointSubsiteMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbsoluteSubsiteItemPath == input.AbsoluteSubsiteItemPath ||
                    (this.AbsoluteSubsiteItemPath != null &&
                    this.AbsoluteSubsiteItemPath.Equals(input.AbsoluteSubsiteItemPath))
                ) && 
                (
                    this.RelativeSubsiteItemPath == input.RelativeSubsiteItemPath ||
                    (this.RelativeSubsiteItemPath != null &&
                    this.RelativeSubsiteItemPath.Equals(input.RelativeSubsiteItemPath))
                ) && 
                (
                    this.SiteType == input.SiteType ||
                    (this.SiteType != null &&
                    this.SiteType.Equals(input.SiteType))
                ) && 
                (
                    this.SiteUuid == input.SiteUuid ||
                    (this.SiteUuid != null &&
                    this.SiteUuid.Equals(input.SiteUuid))
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
                if (this.AbsoluteSubsiteItemPath != null)
                    hashCode = hashCode * 59 + this.AbsoluteSubsiteItemPath.GetHashCode();
                if (this.RelativeSubsiteItemPath != null)
                    hashCode = hashCode * 59 + this.RelativeSubsiteItemPath.GetHashCode();
                if (this.SiteType != null)
                    hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.SiteUuid != null)
                    hashCode = hashCode * 59 + this.SiteUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

