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
    /// Specifies details about a privilege such as the category, description, name, etc.
    /// </summary>
    [DataContract]
    public partial class PrivilegeInfo :  IEquatable<PrivilegeInfo>
    {
        /// <summary>
        /// Specifies unique id for a privilege. This number must be unique when creating a new privilege. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.
        /// </summary>
        /// <value>Specifies unique id for a privilege. This number must be unique when creating a new privilege. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivilegeIdEnum
        {
            /// <summary>
            /// Enum KPrincipalView for value: kPrincipalView
            /// </summary>
            [EnumMember(Value = "kPrincipalView")]
            KPrincipalView = 1,

            /// <summary>
            /// Enum KPrincipalModify for value: kPrincipalModify
            /// </summary>
            [EnumMember(Value = "kPrincipalModify")]
            KPrincipalModify = 2,

            /// <summary>
            /// Enum KAppLaunch for value: kAppLaunch
            /// </summary>
            [EnumMember(Value = "kAppLaunch")]
            KAppLaunch = 3,

            /// <summary>
            /// Enum KAppsManagement for value: kAppsManagement
            /// </summary>
            [EnumMember(Value = "kAppsManagement")]
            KAppsManagement = 4,

            /// <summary>
            /// Enum KOrganizationView for value: kOrganizationView
            /// </summary>
            [EnumMember(Value = "kOrganizationView")]
            KOrganizationView = 5,

            /// <summary>
            /// Enum KOrganizationModify for value: kOrganizationModify
            /// </summary>
            [EnumMember(Value = "kOrganizationModify")]
            KOrganizationModify = 6,

            /// <summary>
            /// Enum KOrganizationImpersonate for value: kOrganizationImpersonate
            /// </summary>
            [EnumMember(Value = "kOrganizationImpersonate")]
            KOrganizationImpersonate = 7,

            /// <summary>
            /// Enum KCloneView for value: kCloneView
            /// </summary>
            [EnumMember(Value = "kCloneView")]
            KCloneView = 8,

            /// <summary>
            /// Enum KCloneModify for value: kCloneModify
            /// </summary>
            [EnumMember(Value = "kCloneModify")]
            KCloneModify = 9,

            /// <summary>
            /// Enum KClusterView for value: kClusterView
            /// </summary>
            [EnumMember(Value = "kClusterView")]
            KClusterView = 10,

            /// <summary>
            /// Enum KClusterModify for value: kClusterModify
            /// </summary>
            [EnumMember(Value = "kClusterModify")]
            KClusterModify = 11,

            /// <summary>
            /// Enum KClusterCreate for value: kClusterCreate
            /// </summary>
            [EnumMember(Value = "kClusterCreate")]
            KClusterCreate = 12,

            /// <summary>
            /// Enum KClusterSupport for value: kClusterSupport
            /// </summary>
            [EnumMember(Value = "kClusterSupport")]
            KClusterSupport = 13,

            /// <summary>
            /// Enum KClusterUpgrade for value: kClusterUpgrade
            /// </summary>
            [EnumMember(Value = "kClusterUpgrade")]
            KClusterUpgrade = 14,

            /// <summary>
            /// Enum KClusterRemoteView for value: kClusterRemoteView
            /// </summary>
            [EnumMember(Value = "kClusterRemoteView")]
            KClusterRemoteView = 15,

            /// <summary>
            /// Enum KClusterRemoteModify for value: kClusterRemoteModify
            /// </summary>
            [EnumMember(Value = "kClusterRemoteModify")]
            KClusterRemoteModify = 16,

            /// <summary>
            /// Enum KClusterExternalTargetView for value: kClusterExternalTargetView
            /// </summary>
            [EnumMember(Value = "kClusterExternalTargetView")]
            KClusterExternalTargetView = 17,

            /// <summary>
            /// Enum KClusterExternalTargetModify for value: kClusterExternalTargetModify
            /// </summary>
            [EnumMember(Value = "kClusterExternalTargetModify")]
            KClusterExternalTargetModify = 18,

            /// <summary>
            /// Enum KClusterAudit for value: kClusterAudit
            /// </summary>
            [EnumMember(Value = "kClusterAudit")]
            KClusterAudit = 19,

            /// <summary>
            /// Enum KAlertView for value: kAlertView
            /// </summary>
            [EnumMember(Value = "kAlertView")]
            KAlertView = 20,

            /// <summary>
            /// Enum KAlertModify for value: kAlertModify
            /// </summary>
            [EnumMember(Value = "kAlertModify")]
            KAlertModify = 21,

            /// <summary>
            /// Enum KVlanView for value: kVlanView
            /// </summary>
            [EnumMember(Value = "kVlanView")]
            KVlanView = 22,

            /// <summary>
            /// Enum KVlanModify for value: kVlanModify
            /// </summary>
            [EnumMember(Value = "kVlanModify")]
            KVlanModify = 23,

            /// <summary>
            /// Enum KHybridExtenderView for value: kHybridExtenderView
            /// </summary>
            [EnumMember(Value = "kHybridExtenderView")]
            KHybridExtenderView = 24,

            /// <summary>
            /// Enum KHybridExtenderDownload for value: kHybridExtenderDownload
            /// </summary>
            [EnumMember(Value = "kHybridExtenderDownload")]
            KHybridExtenderDownload = 25,

            /// <summary>
            /// Enum KAdLdapView for value: kAdLdapView
            /// </summary>
            [EnumMember(Value = "kAdLdapView")]
            KAdLdapView = 26,

            /// <summary>
            /// Enum KAdLdapModify for value: kAdLdapModify
            /// </summary>
            [EnumMember(Value = "kAdLdapModify")]
            KAdLdapModify = 27,

            /// <summary>
            /// Enum KSchedulerView for value: kSchedulerView
            /// </summary>
            [EnumMember(Value = "kSchedulerView")]
            KSchedulerView = 28,

            /// <summary>
            /// Enum KSchedulerModify for value: kSchedulerModify
            /// </summary>
            [EnumMember(Value = "kSchedulerModify")]
            KSchedulerModify = 29,

            /// <summary>
            /// Enum KProtectionView for value: kProtectionView
            /// </summary>
            [EnumMember(Value = "kProtectionView")]
            KProtectionView = 30,

            /// <summary>
            /// Enum KProtectionModify for value: kProtectionModify
            /// </summary>
            [EnumMember(Value = "kProtectionModify")]
            KProtectionModify = 31,

            /// <summary>
            /// Enum KProtectionJobOperate for value: kProtectionJobOperate
            /// </summary>
            [EnumMember(Value = "kProtectionJobOperate")]
            KProtectionJobOperate = 32,

            /// <summary>
            /// Enum KProtectionSourceModify for value: kProtectionSourceModify
            /// </summary>
            [EnumMember(Value = "kProtectionSourceModify")]
            KProtectionSourceModify = 33,

            /// <summary>
            /// Enum KProtectionPolicyView for value: kProtectionPolicyView
            /// </summary>
            [EnumMember(Value = "kProtectionPolicyView")]
            KProtectionPolicyView = 34,

            /// <summary>
            /// Enum KProtectionPolicyModify for value: kProtectionPolicyModify
            /// </summary>
            [EnumMember(Value = "kProtectionPolicyModify")]
            KProtectionPolicyModify = 35,

            /// <summary>
            /// Enum KRestoreView for value: kRestoreView
            /// </summary>
            [EnumMember(Value = "kRestoreView")]
            KRestoreView = 36,

            /// <summary>
            /// Enum KRestoreModify for value: kRestoreModify
            /// </summary>
            [EnumMember(Value = "kRestoreModify")]
            KRestoreModify = 37,

            /// <summary>
            /// Enum KRestoreDownload for value: kRestoreDownload
            /// </summary>
            [EnumMember(Value = "kRestoreDownload")]
            KRestoreDownload = 38,

            /// <summary>
            /// Enum KRemoteRestore for value: kRemoteRestore
            /// </summary>
            [EnumMember(Value = "kRemoteRestore")]
            KRemoteRestore = 39,

            /// <summary>
            /// Enum KStorageView for value: kStorageView
            /// </summary>
            [EnumMember(Value = "kStorageView")]
            KStorageView = 40,

            /// <summary>
            /// Enum KStorageModify for value: kStorageModify
            /// </summary>
            [EnumMember(Value = "kStorageModify")]
            KStorageModify = 41,

            /// <summary>
            /// Enum KStorageDomainView for value: kStorageDomainView
            /// </summary>
            [EnumMember(Value = "kStorageDomainView")]
            KStorageDomainView = 42,

            /// <summary>
            /// Enum KStorageDomainModify for value: kStorageDomainModify
            /// </summary>
            [EnumMember(Value = "kStorageDomainModify")]
            KStorageDomainModify = 43,

            /// <summary>
            /// Enum KAnalyticsView for value: kAnalyticsView
            /// </summary>
            [EnumMember(Value = "kAnalyticsView")]
            KAnalyticsView = 44,

            /// <summary>
            /// Enum KAnalyticsModify for value: kAnalyticsModify
            /// </summary>
            [EnumMember(Value = "kAnalyticsModify")]
            KAnalyticsModify = 45,

            /// <summary>
            /// Enum KReportsView for value: kReportsView
            /// </summary>
            [EnumMember(Value = "kReportsView")]
            KReportsView = 46,

            /// <summary>
            /// Enum KMcmModify for value: kMcmModify
            /// </summary>
            [EnumMember(Value = "kMcmModify")]
            KMcmModify = 47,

            /// <summary>
            /// Enum KDataSecurity for value: kDataSecurity
            /// </summary>
            [EnumMember(Value = "kDataSecurity")]
            KDataSecurity = 48,

            /// <summary>
            /// Enum KSmbBackup for value: kSmbBackup
            /// </summary>
            [EnumMember(Value = "kSmbBackup")]
            KSmbBackup = 49,

            /// <summary>
            /// Enum KSmbRestore for value: kSmbRestore
            /// </summary>
            [EnumMember(Value = "kSmbRestore")]
            KSmbRestore = 50,

            /// <summary>
            /// Enum KSmbTakeOwnership for value: kSmbTakeOwnership
            /// </summary>
            [EnumMember(Value = "kSmbTakeOwnership")]
            KSmbTakeOwnership = 51,

            /// <summary>
            /// Enum KSmbAuditing for value: kSmbAuditing
            /// </summary>
            [EnumMember(Value = "kSmbAuditing")]
            KSmbAuditing = 52,

            /// <summary>
            /// Enum KMcmUnregister for value: kMcmUnregister
            /// </summary>
            [EnumMember(Value = "kMcmUnregister")]
            KMcmUnregister = 53,

            /// <summary>
            /// Enum KMcmUpgrade for value: kMcmUpgrade
            /// </summary>
            [EnumMember(Value = "kMcmUpgrade")]
            KMcmUpgrade = 54,

            /// <summary>
            /// Enum KMcmModifySuperAdmin for value: kMcmModifySuperAdmin
            /// </summary>
            [EnumMember(Value = "kMcmModifySuperAdmin")]
            KMcmModifySuperAdmin = 55,

            /// <summary>
            /// Enum KMcmViewSuperAdmin for value: kMcmViewSuperAdmin
            /// </summary>
            [EnumMember(Value = "kMcmViewSuperAdmin")]
            KMcmViewSuperAdmin = 56,

            /// <summary>
            /// Enum KMcmModifyCohesityAdmin for value: kMcmModifyCohesityAdmin
            /// </summary>
            [EnumMember(Value = "kMcmModifyCohesityAdmin")]
            KMcmModifyCohesityAdmin = 57,

            /// <summary>
            /// Enum KMcmViewCohesityAdmin for value: kMcmViewCohesityAdmin
            /// </summary>
            [EnumMember(Value = "kMcmViewCohesityAdmin")]
            KMcmViewCohesityAdmin = 58,

            /// <summary>
            /// Enum KObjectSearch for value: kObjectSearch
            /// </summary>
            [EnumMember(Value = "kObjectSearch")]
            KObjectSearch = 59,

            /// <summary>
            /// Enum KFileDatalockExpiryTimeDecrease for value: kFileDatalockExpiryTimeDecrease
            /// </summary>
            [EnumMember(Value = "kFileDatalockExpiryTimeDecrease")]
            KFileDatalockExpiryTimeDecrease = 60

        }

        /// <summary>
        /// Specifies unique id for a privilege. This number must be unique when creating a new privilege. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.
        /// </summary>
        /// <value>Specifies unique id for a privilege. This number must be unique when creating a new privilege. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.</value>
        [DataMember(Name="PrivilegeId", EmitDefaultValue=true)]
        public PrivilegeIdEnum? PrivilegeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivilegeInfo" /> class.
        /// </summary>
        /// <param name="privilegeId">Specifies unique id for a privilege. This number must be unique when creating a new privilege. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity..</param>
        /// <param name="category">Specifies a category for the privilege such as &#39;Access Management&#39;..</param>
        /// <param name="description">Specifies a description defining what the privilege provides..</param>
        /// <param name="isAvailableOnHelios">Specifies that this privilege is available for Helios operations..</param>
        /// <param name="isCustomRoleDefault">Specifies if this privilege is automatically assigned to custom roles..</param>
        /// <param name="isSaaSOnly">Specifies that this privilege is available for SaaS operations..</param>
        /// <param name="isSpecial">Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;..</param>
        /// <param name="isViewOnly">Specifies if privilege is view-only privilege that cannot make changes..</param>
        /// <param name="label">Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;..</param>
        /// <param name="name">Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW..</param>
        public PrivilegeInfo(PrivilegeIdEnum? privilegeId = default(PrivilegeIdEnum?), string category = default(string), string description = default(string), bool? isAvailableOnHelios = default(bool?), bool? isCustomRoleDefault = default(bool?), bool? isSaaSOnly = default(bool?), bool? isSpecial = default(bool?), bool? isViewOnly = default(bool?), string label = default(string), string name = default(string))
        {
            this.PrivilegeId = privilegeId;
            this.Category = category;
            this.Description = description;
            this.IsAvailableOnHelios = isAvailableOnHelios;
            this.IsCustomRoleDefault = isCustomRoleDefault;
            this.IsSaaSOnly = isSaaSOnly;
            this.IsSpecial = isSpecial;
            this.IsViewOnly = isViewOnly;
            this.Label = label;
            this.Name = name;
            this.PrivilegeId = privilegeId;
            this.Category = category;
            this.Description = description;
            this.IsAvailableOnHelios = isAvailableOnHelios;
            this.IsCustomRoleDefault = isCustomRoleDefault;
            this.IsSaaSOnly = isSaaSOnly;
            this.IsSpecial = isSpecial;
            this.IsViewOnly = isViewOnly;
            this.Label = label;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies a category for the privilege such as &#39;Access Management&#39;.
        /// </summary>
        /// <value>Specifies a category for the privilege such as &#39;Access Management&#39;.</value>
        [DataMember(Name="category", EmitDefaultValue=true)]
        public string Category { get; set; }

        /// <summary>
        /// Specifies a description defining what the privilege provides.
        /// </summary>
        /// <value>Specifies a description defining what the privilege provides.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies that this privilege is available for Helios operations.
        /// </summary>
        /// <value>Specifies that this privilege is available for Helios operations.</value>
        [DataMember(Name="isAvailableOnHelios", EmitDefaultValue=true)]
        public bool? IsAvailableOnHelios { get; set; }

        /// <summary>
        /// Specifies if this privilege is automatically assigned to custom roles.
        /// </summary>
        /// <value>Specifies if this privilege is automatically assigned to custom roles.</value>
        [DataMember(Name="isCustomRoleDefault", EmitDefaultValue=true)]
        public bool? IsCustomRoleDefault { get; set; }

        /// <summary>
        /// Specifies that this privilege is available for SaaS operations.
        /// </summary>
        /// <value>Specifies that this privilege is available for SaaS operations.</value>
        [DataMember(Name="isSaaSOnly", EmitDefaultValue=true)]
        public bool? IsSaaSOnly { get; set; }

        /// <summary>
        /// Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;.
        /// </summary>
        /// <value>Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;.</value>
        [DataMember(Name="isSpecial", EmitDefaultValue=true)]
        public bool? IsSpecial { get; set; }

        /// <summary>
        /// Specifies if privilege is view-only privilege that cannot make changes.
        /// </summary>
        /// <value>Specifies if privilege is view-only privilege that cannot make changes.</value>
        [DataMember(Name="isViewOnly", EmitDefaultValue=true)]
        public bool? IsViewOnly { get; set; }

        /// <summary>
        /// Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;.
        /// </summary>
        /// <value>Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;.</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string Label { get; set; }

        /// <summary>
        /// Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW.
        /// </summary>
        /// <value>Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as PrivilegeInfo);
        }

        /// <summary>
        /// Returns true if PrivilegeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivilegeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivilegeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivilegeId == input.PrivilegeId ||
                    this.PrivilegeId.Equals(input.PrivilegeId)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsAvailableOnHelios == input.IsAvailableOnHelios ||
                    (this.IsAvailableOnHelios != null &&
                    this.IsAvailableOnHelios.Equals(input.IsAvailableOnHelios))
                ) && 
                (
                    this.IsCustomRoleDefault == input.IsCustomRoleDefault ||
                    (this.IsCustomRoleDefault != null &&
                    this.IsCustomRoleDefault.Equals(input.IsCustomRoleDefault))
                ) && 
                (
                    this.IsSaaSOnly == input.IsSaaSOnly ||
                    (this.IsSaaSOnly != null &&
                    this.IsSaaSOnly.Equals(input.IsSaaSOnly))
                ) && 
                (
                    this.IsSpecial == input.IsSpecial ||
                    (this.IsSpecial != null &&
                    this.IsSpecial.Equals(input.IsSpecial))
                ) && 
                (
                    this.IsViewOnly == input.IsViewOnly ||
                    (this.IsViewOnly != null &&
                    this.IsViewOnly.Equals(input.IsViewOnly))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = hashCode * 59 + this.PrivilegeId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsAvailableOnHelios != null)
                    hashCode = hashCode * 59 + this.IsAvailableOnHelios.GetHashCode();
                if (this.IsCustomRoleDefault != null)
                    hashCode = hashCode * 59 + this.IsCustomRoleDefault.GetHashCode();
                if (this.IsSaaSOnly != null)
                    hashCode = hashCode * 59 + this.IsSaaSOnly.GetHashCode();
                if (this.IsSpecial != null)
                    hashCode = hashCode * 59 + this.IsSpecial.GetHashCode();
                if (this.IsViewOnly != null)
                    hashCode = hashCode * 59 + this.IsViewOnly.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

