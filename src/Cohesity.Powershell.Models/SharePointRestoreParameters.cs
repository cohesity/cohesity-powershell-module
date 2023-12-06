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
    /// Specifies information needed for recovering SharePoint Site and items.
    /// </summary>
    [DataContract]
    public partial class SharePointRestoreParameters :  IEquatable<SharePointRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointRestoreParameters" /> class.
        /// </summary>
        /// <param name="restoreToOriginalSite">Specifies whether the objects are to be restored to the original drive..</param>
        /// <param name="siteOwnerList">Specifies the list of SharePoint Sites whose Document Repositories are being restored..</param>
        /// <param name="targetDocumentLibraryName">Specifies the target document library name within the alternate site..</param>
        /// <param name="targetDocumentLibraryPrefix">Specifies a custom prefix for the document libraries when being restored to the original or an alternate site..</param>
        /// <param name="targetSite">targetSite.</param>
        public SharePointRestoreParameters(bool? restoreToOriginalSite = default(bool?), List<SiteOwner> siteOwnerList = default(List<SiteOwner>), string targetDocumentLibraryName = default(string), string targetDocumentLibraryPrefix = default(string), ProtectionSource targetSite = default(ProtectionSource))
        {
            this.RestoreToOriginalSite = restoreToOriginalSite;
            this.SiteOwnerList = siteOwnerList;
            this.TargetDocumentLibraryName = targetDocumentLibraryName;
            this.TargetDocumentLibraryPrefix = targetDocumentLibraryPrefix;
            this.RestoreToOriginalSite = restoreToOriginalSite;
            this.SiteOwnerList = siteOwnerList;
            this.TargetDocumentLibraryName = targetDocumentLibraryName;
            this.TargetDocumentLibraryPrefix = targetDocumentLibraryPrefix;
            this.TargetSite = targetSite;
        }
        
        /// <summary>
        /// Specifies whether the objects are to be restored to the original drive.
        /// </summary>
        /// <value>Specifies whether the objects are to be restored to the original drive.</value>
        [DataMember(Name="restoreToOriginalSite", EmitDefaultValue=true)]
        public bool? RestoreToOriginalSite { get; set; }

        /// <summary>
        /// Specifies the list of SharePoint Sites whose Document Repositories are being restored.
        /// </summary>
        /// <value>Specifies the list of SharePoint Sites whose Document Repositories are being restored.</value>
        [DataMember(Name="siteOwnerList", EmitDefaultValue=true)]
        public List<SiteOwner> SiteOwnerList { get; set; }

        /// <summary>
        /// Specifies the target document library name within the alternate site.
        /// </summary>
        /// <value>Specifies the target document library name within the alternate site.</value>
        [DataMember(Name="targetDocumentLibraryName", EmitDefaultValue=true)]
        public string TargetDocumentLibraryName { get; set; }

        /// <summary>
        /// Specifies a custom prefix for the document libraries when being restored to the original or an alternate site.
        /// </summary>
        /// <value>Specifies a custom prefix for the document libraries when being restored to the original or an alternate site.</value>
        [DataMember(Name="targetDocumentLibraryPrefix", EmitDefaultValue=true)]
        public string TargetDocumentLibraryPrefix { get; set; }

        /// <summary>
        /// Gets or Sets TargetSite
        /// </summary>
        [DataMember(Name="targetSite", EmitDefaultValue=false)]
        public ProtectionSource TargetSite { get; set; }

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
            return this.Equals(input as SharePointRestoreParameters);
        }

        /// <summary>
        /// Returns true if SharePointRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SharePointRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharePointRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreToOriginalSite == input.RestoreToOriginalSite ||
                    (this.RestoreToOriginalSite != null &&
                    this.RestoreToOriginalSite.Equals(input.RestoreToOriginalSite))
                ) && 
                (
                    this.SiteOwnerList == input.SiteOwnerList ||
                    this.SiteOwnerList != null &&
                    input.SiteOwnerList != null &&
                    this.SiteOwnerList.SequenceEqual(input.SiteOwnerList)
                ) && 
                (
                    this.TargetDocumentLibraryName == input.TargetDocumentLibraryName ||
                    (this.TargetDocumentLibraryName != null &&
                    this.TargetDocumentLibraryName.Equals(input.TargetDocumentLibraryName))
                ) && 
                (
                    this.TargetDocumentLibraryPrefix == input.TargetDocumentLibraryPrefix ||
                    (this.TargetDocumentLibraryPrefix != null &&
                    this.TargetDocumentLibraryPrefix.Equals(input.TargetDocumentLibraryPrefix))
                ) && 
                (
                    this.TargetSite == input.TargetSite ||
                    (this.TargetSite != null &&
                    this.TargetSite.Equals(input.TargetSite))
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
                if (this.RestoreToOriginalSite != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginalSite.GetHashCode();
                if (this.SiteOwnerList != null)
                    hashCode = hashCode * 59 + this.SiteOwnerList.GetHashCode();
                if (this.TargetDocumentLibraryName != null)
                    hashCode = hashCode * 59 + this.TargetDocumentLibraryName.GetHashCode();
                if (this.TargetDocumentLibraryPrefix != null)
                    hashCode = hashCode * 59 + this.TargetDocumentLibraryPrefix.GetHashCode();
                if (this.TargetSite != null)
                    hashCode = hashCode * 59 + this.TargetSite.GetHashCode();
                return hashCode;
            }
        }

    }

}

