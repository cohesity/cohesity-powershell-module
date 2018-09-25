// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the configuration settings that can be updated on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class UpdateClusterParams :  IEquatable<UpdateClusterParams>
    {
        /// <summary>
        /// Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BondingModeEnum
        {
            
            /// <summary>
            /// Enum ActiveBackup for value: ActiveBackup
            /// </summary>
            [EnumMember(Value = "ActiveBackup")]
            ActiveBackup = 1,
            
            /// <summary>
            /// Enum _8023ad for value: 802_3ad
            /// </summary>
            [EnumMember(Value = "802_3ad")]
            _8023ad = 2,
            
            /// <summary>
            /// Enum BalanceAlb for value: BalanceAlb
            /// </summary>
            [EnumMember(Value = "BalanceAlb")]
            BalanceAlb = 3
        }

        /// <summary>
        /// Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=false)]
        public BondingModeEnum? BondingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusterParams" /> class.
        /// </summary>
        /// <param name="bondingMode">Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode..</param>
        /// <param name="clusterAuditLogConfig">Cluster Audit Log Configuration..</param>
        /// <param name="dnsServerIps">Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster..</param>
        /// <param name="domainNames">The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up..</param>
        /// <param name="enableActiveMonitoring">Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed..</param>
        /// <param name="enableUpgradePkgPolling">If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases..</param>
        /// <param name="encryptionKeyRotationPeriodSecs">Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days)..</param>
        /// <param name="filerAuditLogConfig">Filer Audit Log Configuration..</param>
        /// <param name="gateway">Specifies the gateway IP address..</param>
        /// <param name="isDocumentationLocal">Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help..</param>
        /// <param name="languageLocale">Specifies the language and locale for this Cohesity Cluster..</param>
        /// <param name="mtu">Specifies the Maxium Transmission Unit (MTU) in bytes of the network..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        /// <param name="ntpSettings">Specifies if the ntp/master slave scheme should be disabled for this cluster..</param>
        /// <param name="reverseTunnelEnabled">If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel..</param>
        /// <param name="smbAdDisabled">Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled..</param>
        /// <param name="syslogServers">Specifies a list of Syslog servers to send audit logs to..</param>
        /// <param name="timezone">Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc..</param>
        /// <param name="turboMode">Specifies if the cluster is in Turbo mode..</param>
        public UpdateClusterParams(BondingModeEnum? bondingMode = default(BondingModeEnum?), ClusterAuditLogConfiguration clusterAuditLogConfig = default(ClusterAuditLogConfiguration), List<string> dnsServerIps = default(List<string>), List<string> domainNames = default(List<string>), bool? enableActiveMonitoring = default(bool?), bool? enableUpgradePkgPolling = default(bool?), long? encryptionKeyRotationPeriodSecs = default(long?), FilerAuditLogConfiguration filerAuditLogConfig = default(FilerAuditLogConfiguration), string gateway = default(string), bool? isDocumentationLocal = default(bool?), string languageLocale = default(string), int? mtu = default(int?), string name = default(string), NtpSettingsConfig ntpSettings = default(NtpSettingsConfig), bool? reverseTunnelEnabled = default(bool?), bool? smbAdDisabled = default(bool?), List<SyslogServer> syslogServers = default(List<SyslogServer>), string timezone = default(string), bool? turboMode = default(bool?))
        {
            this.BondingMode = bondingMode;
            this.ClusterAuditLogConfig = clusterAuditLogConfig;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.FilerAuditLogConfig = filerAuditLogConfig;
            this.Gateway = gateway;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.LanguageLocale = languageLocale;
            this.Mtu = mtu;
            this.Name = name;
            this.NtpSettings = ntpSettings;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.SmbAdDisabled = smbAdDisabled;
            this.SyslogServers = syslogServers;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
        }
        

        /// <summary>
        /// Cluster Audit Log Configuration.
        /// </summary>
        /// <value>Cluster Audit Log Configuration.</value>
        [DataMember(Name="clusterAuditLogConfig", EmitDefaultValue=false)]
        public ClusterAuditLogConfiguration ClusterAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.</value>
        [DataMember(Name="dnsServerIps", EmitDefaultValue=false)]
        public List<string> DnsServerIps { get; set; }

        /// <summary>
        /// The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.
        /// </summary>
        /// <value>The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.</value>
        [DataMember(Name="domainNames", EmitDefaultValue=false)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.
        /// </summary>
        /// <value>Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.</value>
        [DataMember(Name="enableActiveMonitoring", EmitDefaultValue=false)]
        public bool? EnableActiveMonitoring { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.</value>
        [DataMember(Name="enableUpgradePkgPolling", EmitDefaultValue=false)]
        public bool? EnableUpgradePkgPolling { get; set; }

        /// <summary>
        /// Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).
        /// </summary>
        /// <value>Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).</value>
        [DataMember(Name="encryptionKeyRotationPeriodSecs", EmitDefaultValue=false)]
        public long? EncryptionKeyRotationPeriodSecs { get; set; }

        /// <summary>
        /// Filer Audit Log Configuration.
        /// </summary>
        /// <value>Filer Audit Log Configuration.</value>
        [DataMember(Name="filerAuditLogConfig", EmitDefaultValue=false)]
        public FilerAuditLogConfiguration FilerAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the gateway IP address.
        /// </summary>
        /// <value>Specifies the gateway IP address.</value>
        [DataMember(Name="gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.
        /// </summary>
        /// <value>Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.</value>
        [DataMember(Name="isDocumentationLocal", EmitDefaultValue=false)]
        public bool? IsDocumentationLocal { get; set; }

        /// <summary>
        /// Specifies the language and locale for this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for this Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=false)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Specifies the Maxium Transmission Unit (MTU) in bytes of the network.
        /// </summary>
        /// <value>Specifies the Maxium Transmission Unit (MTU) in bytes of the network.</value>
        [DataMember(Name="mtu", EmitDefaultValue=false)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the name of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cohesity Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies if the ntp/master slave scheme should be disabled for this cluster.
        /// </summary>
        /// <value>Specifies if the ntp/master slave scheme should be disabled for this cluster.</value>
        [DataMember(Name="ntpSettings", EmitDefaultValue=false)]
        public NtpSettingsConfig NtpSettings { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.</value>
        [DataMember(Name="reverseTunnelEnabled", EmitDefaultValue=false)]
        public bool? ReverseTunnelEnabled { get; set; }

        /// <summary>
        /// Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.
        /// </summary>
        /// <value>Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.</value>
        [DataMember(Name="smbAdDisabled", EmitDefaultValue=false)]
        public bool? SmbAdDisabled { get; set; }

        /// <summary>
        /// Specifies a list of Syslog servers to send audit logs to.
        /// </summary>
        /// <value>Specifies a list of Syslog servers to send audit logs to.</value>
        [DataMember(Name="syslogServers", EmitDefaultValue=false)]
        public List<SyslogServer> SyslogServers { get; set; }

        /// <summary>
        /// Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.
        /// </summary>
        /// <value>Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies if the cluster is in Turbo mode.
        /// </summary>
        /// <value>Specifies if the cluster is in Turbo mode.</value>
        [DataMember(Name="turboMode", EmitDefaultValue=false)]
        public bool? TurboMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as UpdateClusterParams);
        }

        /// <summary>
        /// Returns true if UpdateClusterParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateClusterParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateClusterParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BondingMode == input.BondingMode ||
                    (this.BondingMode != null &&
                    this.BondingMode.Equals(input.BondingMode))
                ) && 
                (
                    this.ClusterAuditLogConfig == input.ClusterAuditLogConfig ||
                    (this.ClusterAuditLogConfig != null &&
                    this.ClusterAuditLogConfig.Equals(input.ClusterAuditLogConfig))
                ) && 
                (
                    this.DnsServerIps == input.DnsServerIps ||
                    this.DnsServerIps != null &&
                    this.DnsServerIps.SequenceEqual(input.DnsServerIps)
                ) && 
                (
                    this.DomainNames == input.DomainNames ||
                    this.DomainNames != null &&
                    this.DomainNames.SequenceEqual(input.DomainNames)
                ) && 
                (
                    this.EnableActiveMonitoring == input.EnableActiveMonitoring ||
                    (this.EnableActiveMonitoring != null &&
                    this.EnableActiveMonitoring.Equals(input.EnableActiveMonitoring))
                ) && 
                (
                    this.EnableUpgradePkgPolling == input.EnableUpgradePkgPolling ||
                    (this.EnableUpgradePkgPolling != null &&
                    this.EnableUpgradePkgPolling.Equals(input.EnableUpgradePkgPolling))
                ) && 
                (
                    this.EncryptionKeyRotationPeriodSecs == input.EncryptionKeyRotationPeriodSecs ||
                    (this.EncryptionKeyRotationPeriodSecs != null &&
                    this.EncryptionKeyRotationPeriodSecs.Equals(input.EncryptionKeyRotationPeriodSecs))
                ) && 
                (
                    this.FilerAuditLogConfig == input.FilerAuditLogConfig ||
                    (this.FilerAuditLogConfig != null &&
                    this.FilerAuditLogConfig.Equals(input.FilerAuditLogConfig))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.IsDocumentationLocal == input.IsDocumentationLocal ||
                    (this.IsDocumentationLocal != null &&
                    this.IsDocumentationLocal.Equals(input.IsDocumentationLocal))
                ) && 
                (
                    this.LanguageLocale == input.LanguageLocale ||
                    (this.LanguageLocale != null &&
                    this.LanguageLocale.Equals(input.LanguageLocale))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NtpSettings == input.NtpSettings ||
                    (this.NtpSettings != null &&
                    this.NtpSettings.Equals(input.NtpSettings))
                ) && 
                (
                    this.ReverseTunnelEnabled == input.ReverseTunnelEnabled ||
                    (this.ReverseTunnelEnabled != null &&
                    this.ReverseTunnelEnabled.Equals(input.ReverseTunnelEnabled))
                ) && 
                (
                    this.SmbAdDisabled == input.SmbAdDisabled ||
                    (this.SmbAdDisabled != null &&
                    this.SmbAdDisabled.Equals(input.SmbAdDisabled))
                ) && 
                (
                    this.SyslogServers == input.SyslogServers ||
                    this.SyslogServers != null &&
                    this.SyslogServers.SequenceEqual(input.SyslogServers)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TurboMode == input.TurboMode ||
                    (this.TurboMode != null &&
                    this.TurboMode.Equals(input.TurboMode))
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
                if (this.BondingMode != null)
                    hashCode = hashCode * 59 + this.BondingMode.GetHashCode();
                if (this.ClusterAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogConfig.GetHashCode();
                if (this.DnsServerIps != null)
                    hashCode = hashCode * 59 + this.DnsServerIps.GetHashCode();
                if (this.DomainNames != null)
                    hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.EnableActiveMonitoring != null)
                    hashCode = hashCode * 59 + this.EnableActiveMonitoring.GetHashCode();
                if (this.EnableUpgradePkgPolling != null)
                    hashCode = hashCode * 59 + this.EnableUpgradePkgPolling.GetHashCode();
                if (this.EncryptionKeyRotationPeriodSecs != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyRotationPeriodSecs.GetHashCode();
                if (this.FilerAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.FilerAuditLogConfig.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.IsDocumentationLocal != null)
                    hashCode = hashCode * 59 + this.IsDocumentationLocal.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NtpSettings != null)
                    hashCode = hashCode * 59 + this.NtpSettings.GetHashCode();
                if (this.ReverseTunnelEnabled != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnabled.GetHashCode();
                if (this.SmbAdDisabled != null)
                    hashCode = hashCode * 59 + this.SmbAdDisabled.GetHashCode();
                if (this.SyslogServers != null)
                    hashCode = hashCode * 59 + this.SyslogServers.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TurboMode != null)
                    hashCode = hashCode * 59 + this.TurboMode.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

