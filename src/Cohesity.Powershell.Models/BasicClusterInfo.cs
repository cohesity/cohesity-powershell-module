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
    /// Specifies basic information about the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class BasicClusterInfo :  IEquatable<BasicClusterInfo>
    {
        /// <summary>
        /// Specifies the authentication scheme for the cluster. &#39;kPasswordOnly&#39; indicates the normal cohesity authentication type. &#39;kCertificateOnly&#39; indicates that certificate based authentication has been enabled and the password based authentication has been turned off. &#39;kPasswordAndCertificate&#39; indicates that both the authenticatio schemes are required.
        /// </summary>
        /// <value>Specifies the authentication scheme for the cluster. &#39;kPasswordOnly&#39; indicates the normal cohesity authentication type. &#39;kCertificateOnly&#39; indicates that certificate based authentication has been enabled and the password based authentication has been turned off. &#39;kPasswordAndCertificate&#39; indicates that both the authenticatio schemes are required.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationTypeEnum
        {
            /// <summary>
            /// Enum KPasswordOnly for value: kPasswordOnly
            /// </summary>
            [EnumMember(Value = "kPasswordOnly")]
            KPasswordOnly = 1,

            /// <summary>
            /// Enum KCertificateOnly for value: kCertificateOnly
            /// </summary>
            [EnumMember(Value = "kCertificateOnly")]
            KCertificateOnly = 2,

            /// <summary>
            /// Enum KPasswordAndCertificate for value: kPasswordAndCertificate
            /// </summary>
            [EnumMember(Value = "kPasswordAndCertificate")]
            KPasswordAndCertificate = 3

        }

        /// <summary>
        /// Specifies the authentication scheme for the cluster. &#39;kPasswordOnly&#39; indicates the normal cohesity authentication type. &#39;kCertificateOnly&#39; indicates that certificate based authentication has been enabled and the password based authentication has been turned off. &#39;kPasswordAndCertificate&#39; indicates that both the authenticatio schemes are required.
        /// </summary>
        /// <value>Specifies the authentication scheme for the cluster. &#39;kPasswordOnly&#39; indicates the normal cohesity authentication type. &#39;kCertificateOnly&#39; indicates that certificate based authentication has been enabled and the password based authentication has been turned off. &#39;kPasswordAndCertificate&#39; indicates that both the authenticatio schemes are required.</value>
        [DataMember(Name="authenticationType", EmitDefaultValue=true)]
        public AuthenticationTypeEnum? AuthenticationType { get; set; }
        /// <summary>
        /// Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterTypeEnum
        {
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 1,

            /// <summary>
            /// Enum KVirtualRobo for value: kVirtualRobo
            /// </summary>
            [EnumMember(Value = "kVirtualRobo")]
            KVirtualRobo = 2,

            /// <summary>
            /// Enum KMicrosoftCloud for value: kMicrosoftCloud
            /// </summary>
            [EnumMember(Value = "kMicrosoftCloud")]
            KMicrosoftCloud = 3,

            /// <summary>
            /// Enum KAmazonCloud for value: kAmazonCloud
            /// </summary>
            [EnumMember(Value = "kAmazonCloud")]
            KAmazonCloud = 4,

            /// <summary>
            /// Enum KGoogleCloud for value: kGoogleCloud
            /// </summary>
            [EnumMember(Value = "kGoogleCloud")]
            KGoogleCloud = 5

        }

        /// <summary>
        /// Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [DataMember(Name="clusterType", EmitDefaultValue=true)]
        public ClusterTypeEnum? ClusterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicClusterInfo" /> class.
        /// </summary>
        /// <param name="authenticationType">Specifies the authentication scheme for the cluster. &#39;kPasswordOnly&#39; indicates the normal cohesity authentication type. &#39;kCertificateOnly&#39; indicates that certificate based authentication has been enabled and the password based authentication has been turned off. &#39;kPasswordAndCertificate&#39; indicates that both the authenticatio schemes are required..</param>
        /// <param name="bannerEnabled">Specifies if banner is enabled on the cluster..</param>
        /// <param name="clusterDomains">Specifies a list of domains joined to the Cohesity Cluster with their trust relationships..</param>
        /// <param name="clusterSoftwareVersion">This field is deprecated. Specifies the current release of the Cohesity software running on this Cohesity Cluster. deprecated: true.</param>
        /// <param name="clusterType">Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition..</param>
        /// <param name="domains">Array of Domains.  Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users..</param>
        /// <param name="idpConfigured">Specifies Idp is configured for the Cluster..</param>
        /// <param name="idpTenantExists">Specifies Idp is configured for a Tenant..</param>
        /// <param name="languageLocale">Specifies the language and locale for the Cohesity Cluster..</param>
        /// <param name="mcmMode">Specifies whether server is running in mcm-mode. If set to true, it is in mcm-mode..</param>
        /// <param name="mcmOnPremMode">Specifies whether server is running in mcm-on-prem-mode. If set to true, it is in mcm on prem mode. This need mcm-mode to be true..</param>
        /// <param name="multiTenancyEnabled">Specifies if multi-tenancy is enabled on the cluster..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        public BasicClusterInfo(AuthenticationTypeEnum? authenticationType = default(AuthenticationTypeEnum?), bool? bannerEnabled = default(bool?), List<Domain> clusterDomains = default(List<Domain>), string clusterSoftwareVersion = default(string), ClusterTypeEnum? clusterType = default(ClusterTypeEnum?), List<string> domains = default(List<string>), bool? idpConfigured = default(bool?), bool? idpTenantExists = default(bool?), string languageLocale = default(string), bool? mcmMode = default(bool?), bool? mcmOnPremMode = default(bool?), bool? multiTenancyEnabled = default(bool?), string name = default(string))
        {
            this.AuthenticationType = authenticationType;
            this.BannerEnabled = bannerEnabled;
            this.ClusterDomains = clusterDomains;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.Domains = domains;
            this.IdpConfigured = idpConfigured;
            this.IdpTenantExists = idpTenantExists;
            this.LanguageLocale = languageLocale;
            this.McmMode = mcmMode;
            this.McmOnPremMode = mcmOnPremMode;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.AuthenticationType = authenticationType;
            this.BannerEnabled = bannerEnabled;
            this.ClusterDomains = clusterDomains;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.Domains = domains;
            this.IdpConfigured = idpConfigured;
            this.IdpTenantExists = idpTenantExists;
            this.LanguageLocale = languageLocale;
            this.McmMode = mcmMode;
            this.McmOnPremMode = mcmOnPremMode;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies if banner is enabled on the cluster.
        /// </summary>
        /// <value>Specifies if banner is enabled on the cluster.</value>
        [DataMember(Name="bannerEnabled", EmitDefaultValue=true)]
        public bool? BannerEnabled { get; set; }

        /// <summary>
        /// Specifies a list of domains joined to the Cohesity Cluster with their trust relationships.
        /// </summary>
        /// <value>Specifies a list of domains joined to the Cohesity Cluster with their trust relationships.</value>
        [DataMember(Name="clusterDomains", EmitDefaultValue=true)]
        public List<Domain> ClusterDomains { get; set; }

        /// <summary>
        /// This field is deprecated. Specifies the current release of the Cohesity software running on this Cohesity Cluster. deprecated: true
        /// </summary>
        /// <value>This field is deprecated. Specifies the current release of the Cohesity software running on this Cohesity Cluster. deprecated: true</value>
        [DataMember(Name="clusterSoftwareVersion", EmitDefaultValue=true)]
        public string ClusterSoftwareVersion { get; set; }

        /// <summary>
        /// Array of Domains.  Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users.
        /// </summary>
        /// <value>Array of Domains.  Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users.</value>
        [DataMember(Name="domains", EmitDefaultValue=true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Specifies Idp is configured for the Cluster.
        /// </summary>
        /// <value>Specifies Idp is configured for the Cluster.</value>
        [DataMember(Name="idpConfigured", EmitDefaultValue=true)]
        public bool? IdpConfigured { get; set; }

        /// <summary>
        /// Specifies Idp is configured for a Tenant.
        /// </summary>
        /// <value>Specifies Idp is configured for a Tenant.</value>
        [DataMember(Name="idpTenantExists", EmitDefaultValue=true)]
        public bool? IdpTenantExists { get; set; }

        /// <summary>
        /// Specifies the language and locale for the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for the Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=true)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Specifies whether server is running in mcm-mode. If set to true, it is in mcm-mode.
        /// </summary>
        /// <value>Specifies whether server is running in mcm-mode. If set to true, it is in mcm-mode.</value>
        [DataMember(Name="mcmMode", EmitDefaultValue=true)]
        public bool? McmMode { get; set; }

        /// <summary>
        /// Specifies whether server is running in mcm-on-prem-mode. If set to true, it is in mcm on prem mode. This need mcm-mode to be true.
        /// </summary>
        /// <value>Specifies whether server is running in mcm-on-prem-mode. If set to true, it is in mcm on prem mode. This need mcm-mode to be true.</value>
        [DataMember(Name="mcmOnPremMode", EmitDefaultValue=true)]
        public bool? McmOnPremMode { get; set; }

        /// <summary>
        /// Specifies if multi-tenancy is enabled on the cluster.
        /// </summary>
        /// <value>Specifies if multi-tenancy is enabled on the cluster.</value>
        [DataMember(Name="multiTenancyEnabled", EmitDefaultValue=true)]
        public bool? MultiTenancyEnabled { get; set; }

        /// <summary>
        /// Specifies the name of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cohesity Cluster.</value>
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
            return this.Equals(input as BasicClusterInfo);
        }

        /// <summary>
        /// Returns true if BasicClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicClusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    this.AuthenticationType.Equals(input.AuthenticationType)
                ) && 
                (
                    this.BannerEnabled == input.BannerEnabled ||
                    (this.BannerEnabled != null &&
                    this.BannerEnabled.Equals(input.BannerEnabled))
                ) && 
                (
                    this.ClusterDomains == input.ClusterDomains ||
                    this.ClusterDomains != null &&
                    input.ClusterDomains != null &&
                    this.ClusterDomains.SequenceEqual(input.ClusterDomains)
                ) && 
                (
                    this.ClusterSoftwareVersion == input.ClusterSoftwareVersion ||
                    (this.ClusterSoftwareVersion != null &&
                    this.ClusterSoftwareVersion.Equals(input.ClusterSoftwareVersion))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    this.ClusterType.Equals(input.ClusterType)
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.IdpConfigured == input.IdpConfigured ||
                    (this.IdpConfigured != null &&
                    this.IdpConfigured.Equals(input.IdpConfigured))
                ) && 
                (
                    this.IdpTenantExists == input.IdpTenantExists ||
                    (this.IdpTenantExists != null &&
                    this.IdpTenantExists.Equals(input.IdpTenantExists))
                ) && 
                (
                    this.LanguageLocale == input.LanguageLocale ||
                    (this.LanguageLocale != null &&
                    this.LanguageLocale.Equals(input.LanguageLocale))
                ) && 
                (
                    this.McmMode == input.McmMode ||
                    (this.McmMode != null &&
                    this.McmMode.Equals(input.McmMode))
                ) && 
                (
                    this.McmOnPremMode == input.McmOnPremMode ||
                    (this.McmOnPremMode != null &&
                    this.McmOnPremMode.Equals(input.McmOnPremMode))
                ) && 
                (
                    this.MultiTenancyEnabled == input.MultiTenancyEnabled ||
                    (this.MultiTenancyEnabled != null &&
                    this.MultiTenancyEnabled.Equals(input.MultiTenancyEnabled))
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
                hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.BannerEnabled != null)
                    hashCode = hashCode * 59 + this.BannerEnabled.GetHashCode();
                if (this.ClusterDomains != null)
                    hashCode = hashCode * 59 + this.ClusterDomains.GetHashCode();
                if (this.ClusterSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSoftwareVersion.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                if (this.IdpConfigured != null)
                    hashCode = hashCode * 59 + this.IdpConfigured.GetHashCode();
                if (this.IdpTenantExists != null)
                    hashCode = hashCode * 59 + this.IdpTenantExists.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.McmMode != null)
                    hashCode = hashCode * 59 + this.McmMode.GetHashCode();
                if (this.McmOnPremMode != null)
                    hashCode = hashCode * 59 + this.McmOnPremMode.GetHashCode();
                if (this.MultiTenancyEnabled != null)
                    hashCode = hashCode * 59 + this.MultiTenancyEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

