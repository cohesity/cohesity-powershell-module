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
    /// Specifies the settings used to create/add a new user or modify an existing user.
    /// </summary>
    [DataContract]
    public partial class UserParameters :  IEquatable<UserParameters>
    {
        /// <summary>
        /// Defines PrivilegeIds
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivilegeIdsEnum
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
        /// Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.
        /// </summary>
        /// <value>Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity.</value>
        [DataMember(Name="privilegeIds", EmitDefaultValue=true)]
        public List<PrivilegeIdsEnum> PrivilegeIds { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserParameters" /> class.
        /// </summary>
        /// <param name="additionalGroupNames">Array of Additional Groups.  Specifies the names of additional groups this User may belong to..</param>
        /// <param name="clusterIdentifiers">Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters..</param>
        /// <param name="description">Specifies a description about the user..</param>
        /// <param name="domain">Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain..</param>
        /// <param name="effectiveTimeMsecs">Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in..</param>
        /// <param name="emailAddress">Specifies the email address of the user..</param>
        /// <param name="expiredTimeMsecs">Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in..</param>
        /// <param name="password">Specifies the password of this user..</param>
        /// <param name="primaryGroupName">Specifies the name of the primary group of this User..</param>
        /// <param name="privilegeIds">Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles. Type for unique privilege Id values. All below enum values specify a value for all uniquely defined privileges in Cohesity..</param>
        /// <param name="profiles">Specifies the user profiles. NOTE: Currently used for Helios..</param>
        /// <param name="restricted">Whether the user is a restricted user. A restricted user can only view the objects he has permissions to..</param>
        /// <param name="roles">Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user..</param>
        /// <param name="tenantAccesses">Specifies the tenant access available to current user. NOTE: Currently used for Helios..</param>
        /// <param name="username">Specifies the login name of the user..</param>
        public UserParameters(List<string> additionalGroupNames = default(List<string>), List<ClusterIdentifier> clusterIdentifiers = default(List<ClusterIdentifier>), string description = default(string), string domain = default(string), long? effectiveTimeMsecs = default(long?), string emailAddress = default(string), long? expiredTimeMsecs = default(long?), string password = default(string), string primaryGroupName = default(string), List<PrivilegeIdsEnum> privilegeIds = default(List<PrivilegeIdsEnum>), List<McmUserProfile> profiles = default(List<McmUserProfile>), bool? restricted = default(bool?), List<string> roles = default(List<string>), List<TenantAccess> tenantAccesses = default(List<TenantAccess>), string username = default(string))
        {
            this.AdditionalGroupNames = additionalGroupNames;
            this.ClusterIdentifiers = clusterIdentifiers;
            this.Description = description;
            this.Domain = domain;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.EmailAddress = emailAddress;
            this.ExpiredTimeMsecs = expiredTimeMsecs;
            this.Password = password;
            this.PrimaryGroupName = primaryGroupName;
            this.PrivilegeIds = privilegeIds;
            this.Profiles = profiles;
            this.Restricted = restricted;
            this.Roles = roles;
            this.TenantAccesses = tenantAccesses;
            this.Username = username;
        }
        
        /// <summary>
        /// Array of Additional Groups.  Specifies the names of additional groups this User may belong to.
        /// </summary>
        /// <value>Array of Additional Groups.  Specifies the names of additional groups this User may belong to.</value>
        [DataMember(Name="additionalGroupNames", EmitDefaultValue=true)]
        public List<string> AdditionalGroupNames { get; set; }

        /// <summary>
        /// Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters.
        /// </summary>
        /// <value>Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters.</value>
        [DataMember(Name="clusterIdentifiers", EmitDefaultValue=true)]
        public List<ClusterIdentifier> ClusterIdentifiers { get; set; }

        /// <summary>
        /// Specifies a description about the user.
        /// </summary>
        /// <value>Specifies a description about the user.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.</value>
        [DataMember(Name="effectiveTimeMsecs", EmitDefaultValue=true)]
        public long? EffectiveTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the email address of the user.
        /// </summary>
        /// <value>Specifies the email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in.</value>
        [DataMember(Name="expiredTimeMsecs", EmitDefaultValue=true)]
        public long? ExpiredTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the password of this user.
        /// </summary>
        /// <value>Specifies the password of this user.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the name of the primary group of this User.
        /// </summary>
        /// <value>Specifies the name of the primary group of this User.</value>
        [DataMember(Name="primaryGroupName", EmitDefaultValue=true)]
        public string PrimaryGroupName { get; set; }

        /// <summary>
        /// Specifies the user profiles. NOTE: Currently used for Helios.
        /// </summary>
        /// <value>Specifies the user profiles. NOTE: Currently used for Helios.</value>
        [DataMember(Name="profiles", EmitDefaultValue=true)]
        public List<McmUserProfile> Profiles { get; set; }

        /// <summary>
        /// Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=true)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.
        /// </summary>
        /// <value>Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the tenant access available to current user. NOTE: Currently used for Helios.
        /// </summary>
        /// <value>Specifies the tenant access available to current user. NOTE: Currently used for Helios.</value>
        [DataMember(Name="tenantAccesses", EmitDefaultValue=true)]
        public List<TenantAccess> TenantAccesses { get; set; }

        /// <summary>
        /// Specifies the login name of the user.
        /// </summary>
        /// <value>Specifies the login name of the user.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
            return this.Equals(input as UserParameters);
        }

        /// <summary>
        /// Returns true if UserParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UserParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalGroupNames == input.AdditionalGroupNames ||
                    this.AdditionalGroupNames != null &&
                    input.AdditionalGroupNames != null &&
                    this.AdditionalGroupNames.Equals(input.AdditionalGroupNames)
                ) && 
                (
                    this.ClusterIdentifiers == input.ClusterIdentifiers ||
                    this.ClusterIdentifiers != null &&
                    input.ClusterIdentifiers != null &&
                    this.ClusterIdentifiers.Equals(input.ClusterIdentifiers)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.EffectiveTimeMsecs == input.EffectiveTimeMsecs ||
                    (this.EffectiveTimeMsecs != null &&
                    this.EffectiveTimeMsecs.Equals(input.EffectiveTimeMsecs))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ExpiredTimeMsecs == input.ExpiredTimeMsecs ||
                    (this.ExpiredTimeMsecs != null &&
                    this.ExpiredTimeMsecs.Equals(input.ExpiredTimeMsecs))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PrimaryGroupName == input.PrimaryGroupName ||
                    (this.PrimaryGroupName != null &&
                    this.PrimaryGroupName.Equals(input.PrimaryGroupName))
                ) && 
                (
                    this.PrivilegeIds == input.PrivilegeIds ||
                    this.PrivilegeIds.Equals(input.PrivilegeIds)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.Equals(input.Profiles)
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.Equals(input.Roles)
                ) && 
                (
                    this.TenantAccesses == input.TenantAccesses ||
                    this.TenantAccesses != null &&
                    input.TenantAccesses != null &&
                    this.TenantAccesses.Equals(input.TenantAccesses)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.AdditionalGroupNames != null)
                    hashCode = hashCode * 59 + this.AdditionalGroupNames.GetHashCode();
                if (this.ClusterIdentifiers != null)
                    hashCode = hashCode * 59 + this.ClusterIdentifiers.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EffectiveTimeMsecs != null)
                    hashCode = hashCode * 59 + this.EffectiveTimeMsecs.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.ExpiredTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiredTimeMsecs.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PrimaryGroupName != null)
                    hashCode = hashCode * 59 + this.PrimaryGroupName.GetHashCode();
                if (this.PrivilegeIds != null)
					hashCode = hashCode * 59 + this.PrivilegeIds.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.TenantAccesses != null)
                    hashCode = hashCode * 59 + this.TenantAccesses.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

