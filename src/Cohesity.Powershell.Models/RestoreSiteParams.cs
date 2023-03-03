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
    /// RestoreSiteParams
    /// </summary>
    [DataContract]
    public partial class RestoreSiteParams :  IEquatable<RestoreSiteParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSiteParams" /> class.
        /// </summary>
        /// <param name="dstSiteName">Entity name of target site in case of sharepoint restore..</param>
        /// <param name="dstSiteUuid">Entity uuid of target site in case of sharepoint restore..</param>
        /// <param name="dstSiteWebUrl">Entity web url of target site in case of sharepoint restore..</param>
        /// <param name="parentSourceSharepointDomainName">The sharepoint domain name of the registered parent source from which the site is backed up..</param>
        /// <param name="restoreTemplate">Indicates that we have to restore the Sharepoint site template also. This includes: 1) Create site if it does not exist. 2) Provision template..</param>
        /// <param name="restoreToOriginal">Whether or not all sites are restored to original location..</param>
        /// <param name="siteOwnerVec">The list of sites whose drives are being restored..</param>
        /// <param name="siteResult">siteResult.</param>
        /// <param name="siteVersion">Versions for site restores. There can be incompatible changes across process restarts or across restores. To avoid issues, maintain a version for restore..</param>
        /// <param name="snapFsRelativeSiteBackupResultPath">SnapFS relative path where the site template backup result proto is stored..</param>
        /// <param name="snapFsRelativeTemplatePath">SnapFS relative path where the template data is stored..</param>
        /// <param name="sourceSiteName">Entity name of source site in case of sharepoint restore..</param>
        /// <param name="sourceSiteUuid">Entity uuid of source site in case of sharepoint restore..</param>
        /// <param name="sourceWebUrl">Entity web url of source site in case of sharepoint restore..</param>
        /// <param name="targetDocLibName">Incase of alternate restore of granular items within document repositiories of sites to another site, a doc lib name has to be specified by the caller. NOTE: It can be safely assumed that this field will only be present in case of granular items restore only..</param>
        /// <param name="targetDocLibPrefix">If alternate site is provided, customer may want to provide a custom prefix to document libraries that we create. In any case we would also have to distinguish the newly created document library as the alternate site provided by the customer may as well turn out to be the original backup site..</param>
        /// <param name="targetFolderPathPrefix">Target folder path prefix for granular restore. This is set in case of teams or groups restore..</param>
        /// <param name="targetSite">targetSite.</param>
        public RestoreSiteParams(string dstSiteName = default(string), string dstSiteUuid = default(string), string dstSiteWebUrl = default(string), string parentSourceSharepointDomainName = default(string), bool? restoreTemplate = default(bool?), bool? restoreToOriginal = default(bool?), List<RestoreSiteParamsSiteOwner> siteOwnerVec = default(List<RestoreSiteParamsSiteOwner>), SiteBackupStatus siteResult = default(SiteBackupStatus), int? siteVersion = default(int?), string snapFsRelativeSiteBackupResultPath = default(string), string snapFsRelativeTemplatePath = default(string), string sourceSiteName = default(string), string sourceSiteUuid = default(string), string sourceWebUrl = default(string), string targetDocLibName = default(string), string targetDocLibPrefix = default(string), string targetFolderPathPrefix = default(string), EntityProto targetSite = default(EntityProto))
        {
            this.DstSiteName = dstSiteName;
            this.DstSiteUuid = dstSiteUuid;
            this.DstSiteWebUrl = dstSiteWebUrl;
            this.ParentSourceSharepointDomainName = parentSourceSharepointDomainName;
            this.RestoreTemplate = restoreTemplate;
            this.RestoreToOriginal = restoreToOriginal;
            this.SiteOwnerVec = siteOwnerVec;
            this.SiteVersion = siteVersion;
            this.SnapFsRelativeSiteBackupResultPath = snapFsRelativeSiteBackupResultPath;
            this.SnapFsRelativeTemplatePath = snapFsRelativeTemplatePath;
            this.SourceSiteName = sourceSiteName;
            this.SourceSiteUuid = sourceSiteUuid;
            this.SourceWebUrl = sourceWebUrl;
            this.TargetDocLibName = targetDocLibName;
            this.TargetDocLibPrefix = targetDocLibPrefix;
            this.TargetFolderPathPrefix = targetFolderPathPrefix;
            this.DstSiteName = dstSiteName;
            this.DstSiteUuid = dstSiteUuid;
            this.DstSiteWebUrl = dstSiteWebUrl;
            this.ParentSourceSharepointDomainName = parentSourceSharepointDomainName;
            this.RestoreTemplate = restoreTemplate;
            this.RestoreToOriginal = restoreToOriginal;
            this.SiteOwnerVec = siteOwnerVec;
            this.SiteResult = siteResult;
            this.SiteVersion = siteVersion;
            this.SnapFsRelativeSiteBackupResultPath = snapFsRelativeSiteBackupResultPath;
            this.SnapFsRelativeTemplatePath = snapFsRelativeTemplatePath;
            this.SourceSiteName = sourceSiteName;
            this.SourceSiteUuid = sourceSiteUuid;
            this.SourceWebUrl = sourceWebUrl;
            this.TargetDocLibName = targetDocLibName;
            this.TargetDocLibPrefix = targetDocLibPrefix;
            this.TargetFolderPathPrefix = targetFolderPathPrefix;
            this.TargetSite = targetSite;
        }
        
        /// <summary>
        /// Entity name of target site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity name of target site in case of sharepoint restore.</value>
        [DataMember(Name="dstSiteName", EmitDefaultValue=true)]
        public string DstSiteName { get; set; }

        /// <summary>
        /// Entity uuid of target site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity uuid of target site in case of sharepoint restore.</value>
        [DataMember(Name="dstSiteUuid", EmitDefaultValue=true)]
        public string DstSiteUuid { get; set; }

        /// <summary>
        /// Entity web url of target site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity web url of target site in case of sharepoint restore.</value>
        [DataMember(Name="dstSiteWebUrl", EmitDefaultValue=true)]
        public string DstSiteWebUrl { get; set; }

        /// <summary>
        /// The sharepoint domain name of the registered parent source from which the site is backed up.
        /// </summary>
        /// <value>The sharepoint domain name of the registered parent source from which the site is backed up.</value>
        [DataMember(Name="parentSourceSharepointDomainName", EmitDefaultValue=true)]
        public string ParentSourceSharepointDomainName { get; set; }

        /// <summary>
        /// Indicates that we have to restore the Sharepoint site template also. This includes: 1) Create site if it does not exist. 2) Provision template.
        /// </summary>
        /// <value>Indicates that we have to restore the Sharepoint site template also. This includes: 1) Create site if it does not exist. 2) Provision template.</value>
        [DataMember(Name="restoreTemplate", EmitDefaultValue=true)]
        public bool? RestoreTemplate { get; set; }

        /// <summary>
        /// Whether or not all sites are restored to original location.
        /// </summary>
        /// <value>Whether or not all sites are restored to original location.</value>
        [DataMember(Name="restoreToOriginal", EmitDefaultValue=true)]
        public bool? RestoreToOriginal { get; set; }

        /// <summary>
        /// The list of sites whose drives are being restored.
        /// </summary>
        /// <value>The list of sites whose drives are being restored.</value>
        [DataMember(Name="siteOwnerVec", EmitDefaultValue=true)]
        public List<RestoreSiteParamsSiteOwner> SiteOwnerVec { get; set; }

        /// <summary>
        /// Gets or Sets SiteResult
        /// </summary>
        [DataMember(Name="siteResult", EmitDefaultValue=false)]
        public SiteBackupStatus SiteResult { get; set; }

        /// <summary>
        /// Versions for site restores. There can be incompatible changes across process restarts or across restores. To avoid issues, maintain a version for restore.
        /// </summary>
        /// <value>Versions for site restores. There can be incompatible changes across process restarts or across restores. To avoid issues, maintain a version for restore.</value>
        [DataMember(Name="siteVersion", EmitDefaultValue=true)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// SnapFS relative path where the site template backup result proto is stored.
        /// </summary>
        /// <value>SnapFS relative path where the site template backup result proto is stored.</value>
        [DataMember(Name="snapFsRelativeSiteBackupResultPath", EmitDefaultValue=true)]
        public string SnapFsRelativeSiteBackupResultPath { get; set; }

        /// <summary>
        /// SnapFS relative path where the template data is stored.
        /// </summary>
        /// <value>SnapFS relative path where the template data is stored.</value>
        [DataMember(Name="snapFsRelativeTemplatePath", EmitDefaultValue=true)]
        public string SnapFsRelativeTemplatePath { get; set; }

        /// <summary>
        /// Entity name of source site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity name of source site in case of sharepoint restore.</value>
        [DataMember(Name="sourceSiteName", EmitDefaultValue=true)]
        public string SourceSiteName { get; set; }

        /// <summary>
        /// Entity uuid of source site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity uuid of source site in case of sharepoint restore.</value>
        [DataMember(Name="sourceSiteUuid", EmitDefaultValue=true)]
        public string SourceSiteUuid { get; set; }

        /// <summary>
        /// Entity web url of source site in case of sharepoint restore.
        /// </summary>
        /// <value>Entity web url of source site in case of sharepoint restore.</value>
        [DataMember(Name="sourceWebUrl", EmitDefaultValue=true)]
        public string SourceWebUrl { get; set; }

        /// <summary>
        /// Incase of alternate restore of granular items within document repositiories of sites to another site, a doc lib name has to be specified by the caller. NOTE: It can be safely assumed that this field will only be present in case of granular items restore only.
        /// </summary>
        /// <value>Incase of alternate restore of granular items within document repositiories of sites to another site, a doc lib name has to be specified by the caller. NOTE: It can be safely assumed that this field will only be present in case of granular items restore only.</value>
        [DataMember(Name="targetDocLibName", EmitDefaultValue=true)]
        public string TargetDocLibName { get; set; }

        /// <summary>
        /// If alternate site is provided, customer may want to provide a custom prefix to document libraries that we create. In any case we would also have to distinguish the newly created document library as the alternate site provided by the customer may as well turn out to be the original backup site.
        /// </summary>
        /// <value>If alternate site is provided, customer may want to provide a custom prefix to document libraries that we create. In any case we would also have to distinguish the newly created document library as the alternate site provided by the customer may as well turn out to be the original backup site.</value>
        [DataMember(Name="targetDocLibPrefix", EmitDefaultValue=true)]
        public string TargetDocLibPrefix { get; set; }

        /// <summary>
        /// Target folder path prefix for granular restore. This is set in case of teams or groups restore.
        /// </summary>
        /// <value>Target folder path prefix for granular restore. This is set in case of teams or groups restore.</value>
        [DataMember(Name="targetFolderPathPrefix", EmitDefaultValue=true)]
        public string TargetFolderPathPrefix { get; set; }

        /// <summary>
        /// Gets or Sets TargetSite
        /// </summary>
        [DataMember(Name="targetSite", EmitDefaultValue=false)]
        public EntityProto TargetSite { get; set; }

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
            return this.Equals(input as RestoreSiteParams);
        }

        /// <summary>
        /// Returns true if RestoreSiteParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSiteParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSiteParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DstSiteName == input.DstSiteName ||
                    (this.DstSiteName != null &&
                    this.DstSiteName.Equals(input.DstSiteName))
                ) && 
                (
                    this.DstSiteUuid == input.DstSiteUuid ||
                    (this.DstSiteUuid != null &&
                    this.DstSiteUuid.Equals(input.DstSiteUuid))
                ) && 
                (
                    this.DstSiteWebUrl == input.DstSiteWebUrl ||
                    (this.DstSiteWebUrl != null &&
                    this.DstSiteWebUrl.Equals(input.DstSiteWebUrl))
                ) && 
                (
                    this.ParentSourceSharepointDomainName == input.ParentSourceSharepointDomainName ||
                    (this.ParentSourceSharepointDomainName != null &&
                    this.ParentSourceSharepointDomainName.Equals(input.ParentSourceSharepointDomainName))
                ) && 
                (
                    this.RestoreTemplate == input.RestoreTemplate ||
                    (this.RestoreTemplate != null &&
                    this.RestoreTemplate.Equals(input.RestoreTemplate))
                ) && 
                (
                    this.RestoreToOriginal == input.RestoreToOriginal ||
                    (this.RestoreToOriginal != null &&
                    this.RestoreToOriginal.Equals(input.RestoreToOriginal))
                ) && 
                (
                    this.SiteOwnerVec == input.SiteOwnerVec ||
                    this.SiteOwnerVec != null &&
                    input.SiteOwnerVec != null &&
                    this.SiteOwnerVec.SequenceEqual(input.SiteOwnerVec)
                ) && 
                (
                    this.SiteResult == input.SiteResult ||
                    (this.SiteResult != null &&
                    this.SiteResult.Equals(input.SiteResult))
                ) && 
                (
                    this.SiteVersion == input.SiteVersion ||
                    (this.SiteVersion != null &&
                    this.SiteVersion.Equals(input.SiteVersion))
                ) && 
                (
                    this.SnapFsRelativeSiteBackupResultPath == input.SnapFsRelativeSiteBackupResultPath ||
                    (this.SnapFsRelativeSiteBackupResultPath != null &&
                    this.SnapFsRelativeSiteBackupResultPath.Equals(input.SnapFsRelativeSiteBackupResultPath))
                ) && 
                (
                    this.SnapFsRelativeTemplatePath == input.SnapFsRelativeTemplatePath ||
                    (this.SnapFsRelativeTemplatePath != null &&
                    this.SnapFsRelativeTemplatePath.Equals(input.SnapFsRelativeTemplatePath))
                ) && 
                (
                    this.SourceSiteName == input.SourceSiteName ||
                    (this.SourceSiteName != null &&
                    this.SourceSiteName.Equals(input.SourceSiteName))
                ) && 
                (
                    this.SourceSiteUuid == input.SourceSiteUuid ||
                    (this.SourceSiteUuid != null &&
                    this.SourceSiteUuid.Equals(input.SourceSiteUuid))
                ) && 
                (
                    this.SourceWebUrl == input.SourceWebUrl ||
                    (this.SourceWebUrl != null &&
                    this.SourceWebUrl.Equals(input.SourceWebUrl))
                ) && 
                (
                    this.TargetDocLibName == input.TargetDocLibName ||
                    (this.TargetDocLibName != null &&
                    this.TargetDocLibName.Equals(input.TargetDocLibName))
                ) && 
                (
                    this.TargetDocLibPrefix == input.TargetDocLibPrefix ||
                    (this.TargetDocLibPrefix != null &&
                    this.TargetDocLibPrefix.Equals(input.TargetDocLibPrefix))
                ) && 
                (
                    this.TargetFolderPathPrefix == input.TargetFolderPathPrefix ||
                    (this.TargetFolderPathPrefix != null &&
                    this.TargetFolderPathPrefix.Equals(input.TargetFolderPathPrefix))
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
                if (this.DstSiteName != null)
                    hashCode = hashCode * 59 + this.DstSiteName.GetHashCode();
                if (this.DstSiteUuid != null)
                    hashCode = hashCode * 59 + this.DstSiteUuid.GetHashCode();
                if (this.DstSiteWebUrl != null)
                    hashCode = hashCode * 59 + this.DstSiteWebUrl.GetHashCode();
                if (this.ParentSourceSharepointDomainName != null)
                    hashCode = hashCode * 59 + this.ParentSourceSharepointDomainName.GetHashCode();
                if (this.RestoreTemplate != null)
                    hashCode = hashCode * 59 + this.RestoreTemplate.GetHashCode();
                if (this.RestoreToOriginal != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginal.GetHashCode();
                if (this.SiteOwnerVec != null)
                    hashCode = hashCode * 59 + this.SiteOwnerVec.GetHashCode();
                if (this.SiteResult != null)
                    hashCode = hashCode * 59 + this.SiteResult.GetHashCode();
                if (this.SiteVersion != null)
                    hashCode = hashCode * 59 + this.SiteVersion.GetHashCode();
                if (this.SnapFsRelativeSiteBackupResultPath != null)
                    hashCode = hashCode * 59 + this.SnapFsRelativeSiteBackupResultPath.GetHashCode();
                if (this.SnapFsRelativeTemplatePath != null)
                    hashCode = hashCode * 59 + this.SnapFsRelativeTemplatePath.GetHashCode();
                if (this.SourceSiteName != null)
                    hashCode = hashCode * 59 + this.SourceSiteName.GetHashCode();
                if (this.SourceSiteUuid != null)
                    hashCode = hashCode * 59 + this.SourceSiteUuid.GetHashCode();
                if (this.SourceWebUrl != null)
                    hashCode = hashCode * 59 + this.SourceWebUrl.GetHashCode();
                if (this.TargetDocLibName != null)
                    hashCode = hashCode * 59 + this.TargetDocLibName.GetHashCode();
                if (this.TargetDocLibPrefix != null)
                    hashCode = hashCode * 59 + this.TargetDocLibPrefix.GetHashCode();
                if (this.TargetFolderPathPrefix != null)
                    hashCode = hashCode * 59 + this.TargetFolderPathPrefix.GetHashCode();
                if (this.TargetSite != null)
                    hashCode = hashCode * 59 + this.TargetSite.GetHashCode();
                return hashCode;
            }
        }

    }

}

