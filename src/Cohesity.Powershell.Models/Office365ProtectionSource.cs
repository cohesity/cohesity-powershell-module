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
    /// Specifies a Protection Source in Office 365 environment.
    /// </summary>
    [DataContract]
    public partial class Office365ProtectionSource :  IEquatable<Office365ProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the type of the Office 365 entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KDomain for value: kDomain
            /// </summary>
            [EnumMember(Value = "kDomain")]
            KDomain = 1,

            /// <summary>
            /// Enum KOutlook for value: kOutlook
            /// </summary>
            [EnumMember(Value = "kOutlook")]
            KOutlook = 2,

            /// <summary>
            /// Enum KMailbox for value: kMailbox
            /// </summary>
            [EnumMember(Value = "kMailbox")]
            KMailbox = 3,

            /// <summary>
            /// Enum KUsers for value: kUsers
            /// </summary>
            [EnumMember(Value = "kUsers")]
            KUsers = 4,

            /// <summary>
            /// Enum KGroups for value: kGroups
            /// </summary>
            [EnumMember(Value = "kGroups")]
            KGroups = 5,

            /// <summary>
            /// Enum KSites for value: kSites
            /// </summary>
            [EnumMember(Value = "kSites")]
            KSites = 6,

            /// <summary>
            /// Enum KUser for value: kUser
            /// </summary>
            [EnumMember(Value = "kUser")]
            KUser = 7,

            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 8,

            /// <summary>
            /// Enum KSite for value: kSite
            /// </summary>
            [EnumMember(Value = "kSite")]
            KSite = 9,

            /// <summary>
            /// Enum KApplication for value: kApplication
            /// </summary>
            [EnumMember(Value = "kApplication")]
            KApplication = 10,

            /// <summary>
            /// Enum KGraphUser for value: kGraphUser
            /// </summary>
            [EnumMember(Value = "kGraphUser")]
            KGraphUser = 11,

            /// <summary>
            /// Enum KPublicFolders for value: kPublicFolders
            /// </summary>
            [EnumMember(Value = "kPublicFolders")]
            KPublicFolders = 12,

            /// <summary>
            /// Enum KPublicFolder for value: kPublicFolder
            /// </summary>
            [EnumMember(Value = "kPublicFolder")]
            KPublicFolder = 13,

            /// <summary>
            /// Enum KTeams for value: kTeams
            /// </summary>
            [EnumMember(Value = "kTeams")]
            KTeams = 14,

            /// <summary>
            /// Enum KTeam for value: kTeam
            /// </summary>
            [EnumMember(Value = "kTeam")]
            KTeam = 15,

            /// <summary>
            /// Enum KRootPublicFolder for value: kRootPublicFolder
            /// </summary>
            [EnumMember(Value = "kRootPublicFolder")]
            KRootPublicFolder = 16

        }

        /// <summary>
        /// Specifies the type of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the type of the Office 365 entity.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ProtectionSource" /> class.
        /// </summary>
        /// <param name="description">Specifies the description of the Office 365 entity..</param>
        /// <param name="name">Specifies the name of the office 365 entity..</param>
        /// <param name="primarySMTPAddress">Specifies the SMTP address for the Outlook source..</param>
        /// <param name="proxyHostSourceIdList">Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to an office365 domain. This will be used for Exchange Online PST download as well..</param>
        /// <param name="siteInfo">siteInfo.</param>
        /// <param name="teamInfo">teamInfo.</param>
        /// <param name="type">Specifies the type of the Office 365 entity..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="uuid">Specifies the UUID of the Office 365 entity..</param>
        /// <param name="webUrl">URL that displays the site in the browser. This is applicable for Sharepoint entity..</param>
        public Office365ProtectionSource(string description = default(string), string name = default(string), string primarySMTPAddress = default(string), List<long> proxyHostSourceIdList = default(List<long>), Office365SiteInfo siteInfo = default(Office365SiteInfo), Office365TeamInfo teamInfo = default(Office365TeamInfo), TypeEnum? type = default(TypeEnum?), Office365UserInfo userInfo = default(Office365UserInfo), string uuid = default(string), string webUrl = default(string))
        {
            this.Description = description;
            this.Name = name;
            this.PrimarySMTPAddress = primarySMTPAddress;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.Type = type;
            this.Uuid = uuid;
            this.WebUrl = webUrl;
            this.Description = description;
            this.Name = name;
            this.PrimarySMTPAddress = primarySMTPAddress;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.SiteInfo = siteInfo;
            this.TeamInfo = teamInfo;
            this.Type = type;
            this.UserInfo = userInfo;
            this.Uuid = uuid;
            this.WebUrl = webUrl;
        }
        
        /// <summary>
        /// Specifies the description of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the description of the Office 365 entity.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the office 365 entity.
        /// </summary>
        /// <value>Specifies the name of the office 365 entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the SMTP address for the Outlook source.
        /// </summary>
        /// <value>Specifies the SMTP address for the Outlook source.</value>
        [DataMember(Name="primarySMTPAddress", EmitDefaultValue=true)]
        public string PrimarySMTPAddress { get; set; }

        /// <summary>
        /// Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to an office365 domain. This will be used for Exchange Online PST download as well.
        /// </summary>
        /// <value>Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to an office365 domain. This will be used for Exchange Online PST download as well.</value>
        [DataMember(Name="proxyHostSourceIdList", EmitDefaultValue=true)]
        public List<long> ProxyHostSourceIdList { get; set; }

        /// <summary>
        /// Gets or Sets SiteInfo
        /// </summary>
        [DataMember(Name="siteInfo", EmitDefaultValue=false)]
        public Office365SiteInfo SiteInfo { get; set; }

        /// <summary>
        /// Gets or Sets TeamInfo
        /// </summary>
        [DataMember(Name="teamInfo", EmitDefaultValue=false)]
        public Office365TeamInfo TeamInfo { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public Office365UserInfo UserInfo { get; set; }

        /// <summary>
        /// Specifies the UUID of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the UUID of the Office 365 entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// URL that displays the site in the browser. This is applicable for Sharepoint entity.
        /// </summary>
        /// <value>URL that displays the site in the browser. This is applicable for Sharepoint entity.</value>
        [DataMember(Name="webUrl", EmitDefaultValue=true)]
        public string WebUrl { get; set; }

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
            return this.Equals(input as Office365ProtectionSource);
        }

        /// <summary>
        /// Returns true if Office365ProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365ProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365ProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrimarySMTPAddress == input.PrimarySMTPAddress ||
                    (this.PrimarySMTPAddress != null &&
                    this.PrimarySMTPAddress.Equals(input.PrimarySMTPAddress))
                ) && 
                (
                    this.ProxyHostSourceIdList == input.ProxyHostSourceIdList ||
                    this.ProxyHostSourceIdList != null &&
                    input.ProxyHostSourceIdList != null &&
                    this.ProxyHostSourceIdList.SequenceEqual(input.ProxyHostSourceIdList)
                ) && 
                (
                    this.SiteInfo == input.SiteInfo ||
                    (this.SiteInfo != null &&
                    this.SiteInfo.Equals(input.SiteInfo))
                ) && 
                (
                    this.TeamInfo == input.TeamInfo ||
                    (this.TeamInfo != null &&
                    this.TeamInfo.Equals(input.TeamInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrimarySMTPAddress != null)
                    hashCode = hashCode * 59 + this.PrimarySMTPAddress.GetHashCode();
                if (this.ProxyHostSourceIdList != null)
                    hashCode = hashCode * 59 + this.ProxyHostSourceIdList.GetHashCode();
                if (this.SiteInfo != null)
                    hashCode = hashCode * 59 + this.SiteInfo.GetHashCode();
                if (this.TeamInfo != null)
                    hashCode = hashCode * 59 + this.TeamInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

