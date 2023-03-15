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
    /// Information about the site backed up that is used to restore. For example we need to create the extract site type that was backed up if the site does not exist. All fields are case insensitive. This is an aggregation of all required and optional parameters in New-PnPSite/New-TenantSite/New-PnPWeb cmdlets.
    /// </summary>
    [DataContract]
    public partial class SiteInfo :  IEquatable<SiteInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteInfo" /> class.
        /// </summary>
        /// <param name="classification">Site classification assigned by administrator..</param>
        /// <param name="compatibilityLevel">Compatibility level . Its the site&#39;s compatibility to SPO server version..</param>
        /// <param name="description">Admin entered description of this site..</param>
        /// <param name="design">Needed for site collection create. Maps to CommunicationSiteDesign enum (Topic &#x3D; 0,Showcase &#x3D; 1,Blank &#x3D; 2).</param>
        /// <param name="designId">Design template id..</param>
        /// <param name="geolocation">Geo location of the site..</param>
        /// <param name="groupId">Group Id to which this site belongs..</param>
        /// <param name="hubsiteId">If it is a hub member site, the parent hub site id..</param>
        /// <param name="hubsiteUrl">If it is a hub member site, the parent hub site url. This can be used to restore a hub site member to same hub site even when the site is deleted and recreated or across tenants..</param>
        /// <param name="isHubsite">Is it a Hub? This will be false for a hub member..</param>
        /// <param name="isMultilingual">Site is multilingual, needs to get multilingual resource pages..</param>
        /// <param name="isPersonalsite">Is this a personal site with &#39;https://_*-my.sharepoint.com/_*&#39; pattern..</param>
        /// <param name="isPublic">Is this a public or private site?.</param>
        /// <param name="isSubsite">Is this a subsite or root site? If this is a subsite, it will inherit the template of root site..</param>
        /// <param name="lcid">Site LcId&#x3D;1033 etc...</param>
        /// <param name="localeId">Locale id of the site. Normally 1033 for US English locale..</param>
        /// <param name="ownerVec">Owner. This is an email. Note that across tenants, this email address may be invalid. user@tenant.com. At least one owner must be there..</param>
        /// <param name="readOnly">Site is read-only, locked, and unavailable for write access..</param>
        /// <param name="rootWebId">Rootwebid..</param>
        /// <param name="site">site.</param>
        /// <param name="sitepropVec">Vector of sites collection properties (for classic site collections). Got from Get-PnPSite..</param>
        /// <param name="template">Site Template such as GROUP#0, POINTPUBLISHINGTOPIC#0,....</param>
        /// <param name="tenantsitepropVec">Vector of tenant sites collection properties (for modern site collections). Got from Get-PnPTenantSite..</param>
        /// <param name="timezoneId">Timezone Id. This is needed to create a site collection(tenant site)..</param>
        /// <param name="webpropVec">Vector of sites collection properties (for subsites). Got from Get-PnPWeb..</param>
        public SiteInfo(string classification = default(string), int? compatibilityLevel = default(int?), string description = default(string), string design = default(string), string designId = default(string), string geolocation = default(string), string groupId = default(string), string hubsiteId = default(string), string hubsiteUrl = default(string), bool? isHubsite = default(bool?), bool? isMultilingual = default(bool?), bool? isPersonalsite = default(bool?), bool? isPublic = default(bool?), bool? isSubsite = default(bool?), int? lcid = default(int?), int? localeId = default(int?), List<string> ownerVec = default(List<string>), bool? readOnly = default(bool?), string rootWebId = default(string), SiteIdentity site = default(SiteIdentity), List<SiteProperty> sitepropVec = default(List<SiteProperty>), string template = default(string), List<SiteProperty> tenantsitepropVec = default(List<SiteProperty>), int? timezoneId = default(int?), List<SiteProperty> webpropVec = default(List<SiteProperty>))
        {
            this.Classification = classification;
            this.CompatibilityLevel = compatibilityLevel;
            this.Description = description;
            this.Design = design;
            this.DesignId = designId;
            this.Geolocation = geolocation;
            this.GroupId = groupId;
            this.HubsiteId = hubsiteId;
            this.HubsiteUrl = hubsiteUrl;
            this.IsHubsite = isHubsite;
            this.IsMultilingual = isMultilingual;
            this.IsPersonalsite = isPersonalsite;
            this.IsPublic = isPublic;
            this.IsSubsite = isSubsite;
            this.Lcid = lcid;
            this.LocaleId = localeId;
            this.OwnerVec = ownerVec;
            this.ReadOnly = readOnly;
            this.RootWebId = rootWebId;
            this.SitepropVec = sitepropVec;
            this.Template = template;
            this.TenantsitepropVec = tenantsitepropVec;
            this.TimezoneId = timezoneId;
            this.WebpropVec = webpropVec;
            this.Classification = classification;
            this.CompatibilityLevel = compatibilityLevel;
            this.Description = description;
            this.Design = design;
            this.DesignId = designId;
            this.Geolocation = geolocation;
            this.GroupId = groupId;
            this.HubsiteId = hubsiteId;
            this.HubsiteUrl = hubsiteUrl;
            this.IsHubsite = isHubsite;
            this.IsMultilingual = isMultilingual;
            this.IsPersonalsite = isPersonalsite;
            this.IsPublic = isPublic;
            this.IsSubsite = isSubsite;
            this.Lcid = lcid;
            this.LocaleId = localeId;
            this.OwnerVec = ownerVec;
            this.ReadOnly = readOnly;
            this.RootWebId = rootWebId;
            this.Site = site;
            this.SitepropVec = sitepropVec;
            this.Template = template;
            this.TenantsitepropVec = tenantsitepropVec;
            this.TimezoneId = timezoneId;
            this.WebpropVec = webpropVec;
        }
        
        /// <summary>
        /// Site classification assigned by administrator.
        /// </summary>
        /// <value>Site classification assigned by administrator.</value>
        [DataMember(Name="classification", EmitDefaultValue=true)]
        public string Classification { get; set; }

        /// <summary>
        /// Compatibility level . Its the site&#39;s compatibility to SPO server version.
        /// </summary>
        /// <value>Compatibility level . Its the site&#39;s compatibility to SPO server version.</value>
        [DataMember(Name="compatibilityLevel", EmitDefaultValue=true)]
        public int? CompatibilityLevel { get; set; }

        /// <summary>
        /// Admin entered description of this site.
        /// </summary>
        /// <value>Admin entered description of this site.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Needed for site collection create. Maps to CommunicationSiteDesign enum (Topic &#x3D; 0,Showcase &#x3D; 1,Blank &#x3D; 2)
        /// </summary>
        /// <value>Needed for site collection create. Maps to CommunicationSiteDesign enum (Topic &#x3D; 0,Showcase &#x3D; 1,Blank &#x3D; 2)</value>
        [DataMember(Name="design", EmitDefaultValue=true)]
        public string Design { get; set; }

        /// <summary>
        /// Design template id.
        /// </summary>
        /// <value>Design template id.</value>
        [DataMember(Name="designId", EmitDefaultValue=true)]
        public string DesignId { get; set; }

        /// <summary>
        /// Geo location of the site.
        /// </summary>
        /// <value>Geo location of the site.</value>
        [DataMember(Name="geolocation", EmitDefaultValue=true)]
        public string Geolocation { get; set; }

        /// <summary>
        /// Group Id to which this site belongs.
        /// </summary>
        /// <value>Group Id to which this site belongs.</value>
        [DataMember(Name="groupId", EmitDefaultValue=true)]
        public string GroupId { get; set; }

        /// <summary>
        /// If it is a hub member site, the parent hub site id.
        /// </summary>
        /// <value>If it is a hub member site, the parent hub site id.</value>
        [DataMember(Name="hubsiteId", EmitDefaultValue=true)]
        public string HubsiteId { get; set; }

        /// <summary>
        /// If it is a hub member site, the parent hub site url. This can be used to restore a hub site member to same hub site even when the site is deleted and recreated or across tenants.
        /// </summary>
        /// <value>If it is a hub member site, the parent hub site url. This can be used to restore a hub site member to same hub site even when the site is deleted and recreated or across tenants.</value>
        [DataMember(Name="hubsiteUrl", EmitDefaultValue=true)]
        public string HubsiteUrl { get; set; }

        /// <summary>
        /// Is it a Hub? This will be false for a hub member.
        /// </summary>
        /// <value>Is it a Hub? This will be false for a hub member.</value>
        [DataMember(Name="isHubsite", EmitDefaultValue=true)]
        public bool? IsHubsite { get; set; }

        /// <summary>
        /// Site is multilingual, needs to get multilingual resource pages.
        /// </summary>
        /// <value>Site is multilingual, needs to get multilingual resource pages.</value>
        [DataMember(Name="isMultilingual", EmitDefaultValue=true)]
        public bool? IsMultilingual { get; set; }

        /// <summary>
        /// Is this a personal site with &#39;https://_*-my.sharepoint.com/_*&#39; pattern.
        /// </summary>
        /// <value>Is this a personal site with &#39;https://_*-my.sharepoint.com/_*&#39; pattern.</value>
        [DataMember(Name="isPersonalsite", EmitDefaultValue=true)]
        public bool? IsPersonalsite { get; set; }

        /// <summary>
        /// Is this a public or private site?
        /// </summary>
        /// <value>Is this a public or private site?</value>
        [DataMember(Name="isPublic", EmitDefaultValue=true)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Is this a subsite or root site? If this is a subsite, it will inherit the template of root site.
        /// </summary>
        /// <value>Is this a subsite or root site? If this is a subsite, it will inherit the template of root site.</value>
        [DataMember(Name="isSubsite", EmitDefaultValue=true)]
        public bool? IsSubsite { get; set; }

        /// <summary>
        /// Site LcId&#x3D;1033 etc..
        /// </summary>
        /// <value>Site LcId&#x3D;1033 etc..</value>
        [DataMember(Name="lcid", EmitDefaultValue=true)]
        public int? Lcid { get; set; }

        /// <summary>
        /// Locale id of the site. Normally 1033 for US English locale.
        /// </summary>
        /// <value>Locale id of the site. Normally 1033 for US English locale.</value>
        [DataMember(Name="localeId", EmitDefaultValue=true)]
        public int? LocaleId { get; set; }

        /// <summary>
        /// Owner. This is an email. Note that across tenants, this email address may be invalid. user@tenant.com. At least one owner must be there.
        /// </summary>
        /// <value>Owner. This is an email. Note that across tenants, this email address may be invalid. user@tenant.com. At least one owner must be there.</value>
        [DataMember(Name="ownerVec", EmitDefaultValue=true)]
        public List<string> OwnerVec { get; set; }

        /// <summary>
        /// Site is read-only, locked, and unavailable for write access.
        /// </summary>
        /// <value>Site is read-only, locked, and unavailable for write access.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Rootwebid.
        /// </summary>
        /// <value>Rootwebid.</value>
        [DataMember(Name="rootWebId", EmitDefaultValue=true)]
        public string RootWebId { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public SiteIdentity Site { get; set; }

        /// <summary>
        /// Vector of sites collection properties (for classic site collections). Got from Get-PnPSite.
        /// </summary>
        /// <value>Vector of sites collection properties (for classic site collections). Got from Get-PnPSite.</value>
        [DataMember(Name="sitepropVec", EmitDefaultValue=true)]
        public List<SiteProperty> SitepropVec { get; set; }

        /// <summary>
        /// Site Template such as GROUP#0, POINTPUBLISHINGTOPIC#0,...
        /// </summary>
        /// <value>Site Template such as GROUP#0, POINTPUBLISHINGTOPIC#0,...</value>
        [DataMember(Name="template", EmitDefaultValue=true)]
        public string Template { get; set; }

        /// <summary>
        /// Vector of tenant sites collection properties (for modern site collections). Got from Get-PnPTenantSite.
        /// </summary>
        /// <value>Vector of tenant sites collection properties (for modern site collections). Got from Get-PnPTenantSite.</value>
        [DataMember(Name="tenantsitepropVec", EmitDefaultValue=true)]
        public List<SiteProperty> TenantsitepropVec { get; set; }

        /// <summary>
        /// Timezone Id. This is needed to create a site collection(tenant site).
        /// </summary>
        /// <value>Timezone Id. This is needed to create a site collection(tenant site).</value>
        [DataMember(Name="timezoneId", EmitDefaultValue=true)]
        public int? TimezoneId { get; set; }

        /// <summary>
        /// Vector of sites collection properties (for subsites). Got from Get-PnPWeb.
        /// </summary>
        /// <value>Vector of sites collection properties (for subsites). Got from Get-PnPWeb.</value>
        [DataMember(Name="webpropVec", EmitDefaultValue=true)]
        public List<SiteProperty> WebpropVec { get; set; }

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
            return this.Equals(input as SiteInfo);
        }

        /// <summary>
        /// Returns true if SiteInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.CompatibilityLevel == input.CompatibilityLevel ||
                    (this.CompatibilityLevel != null &&
                    this.CompatibilityLevel.Equals(input.CompatibilityLevel))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Design == input.Design ||
                    (this.Design != null &&
                    this.Design.Equals(input.Design))
                ) && 
                (
                    this.DesignId == input.DesignId ||
                    (this.DesignId != null &&
                    this.DesignId.Equals(input.DesignId))
                ) && 
                (
                    this.Geolocation == input.Geolocation ||
                    (this.Geolocation != null &&
                    this.Geolocation.Equals(input.Geolocation))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.HubsiteId == input.HubsiteId ||
                    (this.HubsiteId != null &&
                    this.HubsiteId.Equals(input.HubsiteId))
                ) && 
                (
                    this.HubsiteUrl == input.HubsiteUrl ||
                    (this.HubsiteUrl != null &&
                    this.HubsiteUrl.Equals(input.HubsiteUrl))
                ) && 
                (
                    this.IsHubsite == input.IsHubsite ||
                    (this.IsHubsite != null &&
                    this.IsHubsite.Equals(input.IsHubsite))
                ) && 
                (
                    this.IsMultilingual == input.IsMultilingual ||
                    (this.IsMultilingual != null &&
                    this.IsMultilingual.Equals(input.IsMultilingual))
                ) && 
                (
                    this.IsPersonalsite == input.IsPersonalsite ||
                    (this.IsPersonalsite != null &&
                    this.IsPersonalsite.Equals(input.IsPersonalsite))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.IsSubsite == input.IsSubsite ||
                    (this.IsSubsite != null &&
                    this.IsSubsite.Equals(input.IsSubsite))
                ) && 
                (
                    this.Lcid == input.Lcid ||
                    (this.Lcid != null &&
                    this.Lcid.Equals(input.Lcid))
                ) && 
                (
                    this.LocaleId == input.LocaleId ||
                    (this.LocaleId != null &&
                    this.LocaleId.Equals(input.LocaleId))
                ) && 
                (
                    this.OwnerVec == input.OwnerVec ||
                    this.OwnerVec != null &&
                    input.OwnerVec != null &&
                    this.OwnerVec.SequenceEqual(input.OwnerVec)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.RootWebId == input.RootWebId ||
                    (this.RootWebId != null &&
                    this.RootWebId.Equals(input.RootWebId))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.SitepropVec == input.SitepropVec ||
                    this.SitepropVec != null &&
                    input.SitepropVec != null &&
                    this.SitepropVec.SequenceEqual(input.SitepropVec)
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TenantsitepropVec == input.TenantsitepropVec ||
                    this.TenantsitepropVec != null &&
                    input.TenantsitepropVec != null &&
                    this.TenantsitepropVec.SequenceEqual(input.TenantsitepropVec)
                ) && 
                (
                    this.TimezoneId == input.TimezoneId ||
                    (this.TimezoneId != null &&
                    this.TimezoneId.Equals(input.TimezoneId))
                ) && 
                (
                    this.WebpropVec == input.WebpropVec ||
                    this.WebpropVec != null &&
                    input.WebpropVec != null &&
                    this.WebpropVec.SequenceEqual(input.WebpropVec)
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
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.CompatibilityLevel != null)
                    hashCode = hashCode * 59 + this.CompatibilityLevel.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Design != null)
                    hashCode = hashCode * 59 + this.Design.GetHashCode();
                if (this.DesignId != null)
                    hashCode = hashCode * 59 + this.DesignId.GetHashCode();
                if (this.Geolocation != null)
                    hashCode = hashCode * 59 + this.Geolocation.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HubsiteId != null)
                    hashCode = hashCode * 59 + this.HubsiteId.GetHashCode();
                if (this.HubsiteUrl != null)
                    hashCode = hashCode * 59 + this.HubsiteUrl.GetHashCode();
                if (this.IsHubsite != null)
                    hashCode = hashCode * 59 + this.IsHubsite.GetHashCode();
                if (this.IsMultilingual != null)
                    hashCode = hashCode * 59 + this.IsMultilingual.GetHashCode();
                if (this.IsPersonalsite != null)
                    hashCode = hashCode * 59 + this.IsPersonalsite.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.IsSubsite != null)
                    hashCode = hashCode * 59 + this.IsSubsite.GetHashCode();
                if (this.Lcid != null)
                    hashCode = hashCode * 59 + this.Lcid.GetHashCode();
                if (this.LocaleId != null)
                    hashCode = hashCode * 59 + this.LocaleId.GetHashCode();
                if (this.OwnerVec != null)
                    hashCode = hashCode * 59 + this.OwnerVec.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.RootWebId != null)
                    hashCode = hashCode * 59 + this.RootWebId.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.SitepropVec != null)
                    hashCode = hashCode * 59 + this.SitepropVec.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TenantsitepropVec != null)
                    hashCode = hashCode * 59 + this.TenantsitepropVec.GetHashCode();
                if (this.TimezoneId != null)
                    hashCode = hashCode * 59 + this.TimezoneId.GetHashCode();
                if (this.WebpropVec != null)
                    hashCode = hashCode * 59 + this.WebpropVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

