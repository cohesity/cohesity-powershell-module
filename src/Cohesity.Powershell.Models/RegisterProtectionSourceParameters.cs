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
    /// Specifies the parameters required to register a Protection Source.
    /// </summary>
    [DataContract]
    public partial class RegisterProtectionSourceParameters :  IEquatable<RegisterProtectionSourceParameters>
    {
        /// <summary>
        /// Specifies the entity type if the environment is kAcropolis. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kAcropolis. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AcropolisTypeEnum
        {
            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 1

        }

        /// <summary>
        /// Specifies the entity type if the environment is kAcropolis. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kAcropolis. overrideDescription: true</value>
        [DataMember(Name="acropolisType", EmitDefaultValue=true)]
        public AcropolisTypeEnum? AcropolisType { get; set; }
        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            /// <summary>
            /// Enum KVMware for value: kVMware
            /// </summary>
            [EnumMember(Value = "kVMware")]
            KVMware = 1,

            /// <summary>
            /// Enum KHyperV for value: kHyperV
            /// </summary>
            [EnumMember(Value = "kHyperV")]
            KHyperV = 2,

            /// <summary>
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 3,

            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 4,

            /// <summary>
            /// Enum KPuppeteer for value: kPuppeteer
            /// </summary>
            [EnumMember(Value = "kPuppeteer")]
            KPuppeteer = 5,

            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 6,

            /// <summary>
            /// Enum KPure for value: kPure
            /// </summary>
            [EnumMember(Value = "kPure")]
            KPure = 7,

            /// <summary>
            /// Enum KNimble for value: kNimble
            /// </summary>
            [EnumMember(Value = "kNimble")]
            KNimble = 8,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 9,

            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 10,

            /// <summary>
            /// Enum KAgent for value: kAgent
            /// </summary>
            [EnumMember(Value = "kAgent")]
            KAgent = 11,

            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 12,

            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 13,

            /// <summary>
            /// Enum KPhysicalFiles for value: kPhysicalFiles
            /// </summary>
            [EnumMember(Value = "kPhysicalFiles")]
            KPhysicalFiles = 14,

            /// <summary>
            /// Enum KIsilon for value: kIsilon
            /// </summary>
            [EnumMember(Value = "kIsilon")]
            KIsilon = 15,

            /// <summary>
            /// Enum KGPFS for value: kGPFS
            /// </summary>
            [EnumMember(Value = "kGPFS")]
            KGPFS = 16,

            /// <summary>
            /// Enum KKVM for value: kKVM
            /// </summary>
            [EnumMember(Value = "kKVM")]
            KKVM = 17,

            /// <summary>
            /// Enum KAWS for value: kAWS
            /// </summary>
            [EnumMember(Value = "kAWS")]
            KAWS = 18,

            /// <summary>
            /// Enum KExchange for value: kExchange
            /// </summary>
            [EnumMember(Value = "kExchange")]
            KExchange = 19,

            /// <summary>
            /// Enum KHyperVVSS for value: kHyperVVSS
            /// </summary>
            [EnumMember(Value = "kHyperVVSS")]
            KHyperVVSS = 20,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 21,

            /// <summary>
            /// Enum KGCP for value: kGCP
            /// </summary>
            [EnumMember(Value = "kGCP")]
            KGCP = 22,

            /// <summary>
            /// Enum KFlashBlade for value: kFlashBlade
            /// </summary>
            [EnumMember(Value = "kFlashBlade")]
            KFlashBlade = 23,

            /// <summary>
            /// Enum KAWSNative for value: kAWSNative
            /// </summary>
            [EnumMember(Value = "kAWSNative")]
            KAWSNative = 24,

            /// <summary>
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 25,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 26,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 27,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 28,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 29,

            /// <summary>
            /// Enum KKubernetes for value: kKubernetes
            /// </summary>
            [EnumMember(Value = "kKubernetes")]
            KKubernetes = 30,

            /// <summary>
            /// Enum KElastifile for value: kElastifile
            /// </summary>
            [EnumMember(Value = "kElastifile")]
            KElastifile = 31,

            /// <summary>
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 32,

            /// <summary>
            /// Enum KRDSSnapshotManager for value: kRDSSnapshotManager
            /// </summary>
            [EnumMember(Value = "kRDSSnapshotManager")]
            KRDSSnapshotManager = 33

        }

        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kHyperV. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kHyperV. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HyperVTypeEnum
        {
            /// <summary>
            /// Enum KSCVMMServer for value: kSCVMMServer
            /// </summary>
            [EnumMember(Value = "kSCVMMServer")]
            KSCVMMServer = 1,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,

            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 3

        }

        /// <summary>
        /// Specifies the entity type if the environment is kHyperV. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kHyperV. overrideDescription: true</value>
        [DataMember(Name="hyperVType", EmitDefaultValue=true)]
        public HyperVTypeEnum? HyperVType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kKubernetes. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKubernetes. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KubernetesTypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1

        }

        /// <summary>
        /// Specifies the entity type if the environment is kKubernetes. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKubernetes. overrideDescription: true</value>
        [DataMember(Name="kubernetesType", EmitDefaultValue=true)]
        public KubernetesTypeEnum? KubernetesType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kKVM. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKVM. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KvmTypeEnum
        {
            /// <summary>
            /// Enum KOVirtManager for value: kOVirtManager
            /// </summary>
            [EnumMember(Value = "kOVirtManager")]
            KOVirtManager = 1

        }

        /// <summary>
        /// Specifies the entity type if the environment is kKVM. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKVM. overrideDescription: true</value>
        [DataMember(Name="kvmType", EmitDefaultValue=true)]
        public KvmTypeEnum? KvmType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetappTypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KVserver for value: kVserver
            /// </summary>
            [EnumMember(Value = "kVserver")]
            KVserver = 2

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [DataMember(Name="netappType", EmitDefaultValue=true)]
        public NetappTypeEnum? NetappType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NimbleTypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true</value>
        [DataMember(Name="nimbleType", EmitDefaultValue=true)]
        public NimbleTypeEnum? NimbleType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Office365TypeEnum
        {
            /// <summary>
            /// Enum KDomain for value: kDomain
            /// </summary>
            [EnumMember(Value = "kDomain")]
            KDomain = 1

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.</value>
        [DataMember(Name="office365Type", EmitDefaultValue=true)]
        public Office365TypeEnum? Office365Type { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhysicalTypeEnum
        {
            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 1

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true</value>
        [DataMember(Name="physicalType", EmitDefaultValue=true)]
        public PhysicalTypeEnum? PhysicalType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PureTypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true</value>
        [DataMember(Name="pureType", EmitDefaultValue=true)]
        public PureTypeEnum? PureType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmwareTypeEnum
        {
            /// <summary>
            /// Enum KVCenter for value: kVCenter
            /// </summary>
            [EnumMember(Value = "kVCenter")]
            KVCenter = 1,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,

            /// <summary>
            /// Enum KvCloudDirector for value: kvCloudDirector
            /// </summary>
            [EnumMember(Value = "kvCloudDirector")]
            KvCloudDirector = 3

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true</value>
        [DataMember(Name="vmwareType", EmitDefaultValue=true)]
        public VmwareTypeEnum? VmwareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="acropolisType">Specifies the entity type if the environment is kAcropolis. overrideDescription: true.</param>
        /// <param name="agentEndpoint">Specifies the agent endpoint if it is different from the source endpoint..</param>
        /// <param name="awsCredentials">awsCredentials.</param>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="environment">Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment..</param>
        /// <param name="exchangeDagProtectionPreference">exchangeDagProtectionPreference.</param>
        /// <param name="forceRegister">ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally..</param>
        /// <param name="gcpCredentials">gcpCredentials.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="hyperVType">Specifies the entity type if the environment is kHyperV. overrideDescription: true.</param>
        /// <param name="kubernetesCredentials">kubernetesCredentials.</param>
        /// <param name="kubernetesType">Specifies the entity type if the environment is kKubernetes. overrideDescription: true.</param>
        /// <param name="kvmType">Specifies the entity type if the environment is kKVM. overrideDescription: true.</param>
        /// <param name="nasMountCredentials">Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers..</param>
        /// <param name="netappType">Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp..</param>
        /// <param name="nimbleType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true.</param>
        /// <param name="office365CredentialsList">Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs..</param>
        /// <param name="office365Type">Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="physicalType">Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true.</param>
        /// <param name="pureType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true.</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="sslVerification">sslVerification.</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="useOAuthForExchangeOnline">Specifies whether OAuth should be used for authentication in case of Exchange Online..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vlanParams">vlanParams.</param>
        /// <param name="vmwareType">Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true.</param>
        public RegisterProtectionSourceParameters(AcropolisTypeEnum? acropolisType = default(AcropolisTypeEnum?), string agentEndpoint = default(string), AwsCredentials awsCredentials = default(AwsCredentials), AzureCredentials azureCredentials = default(AzureCredentials), string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), ExchangeDAGProtectionPreference exchangeDagProtectionPreference = default(ExchangeDAGProtectionPreference), bool? forceRegister = default(bool?), GcpCredentials gcpCredentials = default(GcpCredentials), HostTypeEnum? hostType = default(HostTypeEnum?), HyperVTypeEnum? hyperVType = default(HyperVTypeEnum?), KubernetesCredentials kubernetesCredentials = default(KubernetesCredentials), KubernetesTypeEnum? kubernetesType = default(KubernetesTypeEnum?), KvmTypeEnum? kvmType = default(KvmTypeEnum?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), NetappTypeEnum? netappType = default(NetappTypeEnum?), NimbleTypeEnum? nimbleType = default(NimbleTypeEnum?), List<Office365Credentials> office365CredentialsList = default(List<Office365Credentials>), Office365TypeEnum? office365Type = default(Office365TypeEnum?), string password = default(string), PhysicalTypeEnum? physicalType = default(PhysicalTypeEnum?), PureTypeEnum? pureType = default(PureTypeEnum?), bool? sourceSideDedupEnabled = default(bool?), SslVerification sslVerification = default(SslVerification), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), bool? useOAuthForExchangeOnline = default(bool?), string username = default(string), VlanParameters vlanParams = default(VlanParameters), VmwareTypeEnum? vmwareType = default(VmwareTypeEnum?))
        {
            this.AcropolisType = acropolisType;
            this.AgentEndpoint = agentEndpoint;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.HyperVType = hyperVType;
            this.KubernetesType = kubernetesType;
            this.KvmType = kvmType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.NimbleType = nimbleType;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.VmwareType = vmwareType;
            this.AcropolisType = acropolisType;
            this.AgentEndpoint = agentEndpoint;
            this.AwsCredentials = awsCredentials;
            this.AzureCredentials = azureCredentials;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ExchangeDagProtectionPreference = exchangeDagProtectionPreference;
            this.ForceRegister = forceRegister;
            this.GcpCredentials = gcpCredentials;
            this.HostType = hostType;
            this.HyperVType = hyperVType;
            this.KubernetesCredentials = kubernetesCredentials;
            this.KubernetesType = kubernetesType;
            this.KvmType = kvmType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.NimbleType = nimbleType;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.SslVerification = sslVerification;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.VlanParams = vlanParams;
            this.VmwareType = vmwareType;
        }
        
        /// <summary>
        /// Specifies the agent endpoint if it is different from the source endpoint.
        /// </summary>
        /// <value>Specifies the agent endpoint if it is different from the source endpoint.</value>
        [DataMember(Name="agentEndpoint", EmitDefaultValue=true)]
        public string AgentEndpoint { get; set; }

        /// <summary>
        /// Gets or Sets AwsCredentials
        /// </summary>
        [DataMember(Name="awsCredentials", EmitDefaultValue=false)]
        public AwsCredentials AwsCredentials { get; set; }

        /// <summary>
        /// Gets or Sets AzureCredentials
        /// </summary>
        [DataMember(Name="azureCredentials", EmitDefaultValue=false)]
        public AzureCredentials AzureCredentials { get; set; }

        /// <summary>
        /// Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.
        /// </summary>
        /// <value>Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeDagProtectionPreference
        /// </summary>
        [DataMember(Name="exchangeDagProtectionPreference", EmitDefaultValue=false)]
        public ExchangeDAGProtectionPreference ExchangeDagProtectionPreference { get; set; }

        /// <summary>
        /// ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally.
        /// </summary>
        /// <value>ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally.</value>
        [DataMember(Name="forceRegister", EmitDefaultValue=true)]
        public bool? ForceRegister { get; set; }

        /// <summary>
        /// Gets or Sets GcpCredentials
        /// </summary>
        [DataMember(Name="gcpCredentials", EmitDefaultValue=false)]
        public GcpCredentials GcpCredentials { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesCredentials
        /// </summary>
        [DataMember(Name="kubernetesCredentials", EmitDefaultValue=false)]
        public KubernetesCredentials KubernetesCredentials { get; set; }

        /// <summary>
        /// Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.
        /// </summary>
        /// <value>Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.</value>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=true)]
        public NasMountCredentialParams NasMountCredentials { get; set; }

        /// <summary>
        /// Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs.
        /// </summary>
        /// <value>Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs.</value>
        [DataMember(Name="office365CredentialsList", EmitDefaultValue=true)]
        public List<Office365Credentials> Office365CredentialsList { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers).
        /// </summary>
        /// <value>This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers).</value>
        [DataMember(Name="sourceSideDedupEnabled", EmitDefaultValue=true)]
        public bool? SourceSideDedupEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SslVerification
        /// </summary>
        [DataMember(Name="sslVerification", EmitDefaultValue=false)]
        public SslVerification SslVerification { get; set; }

        /// <summary>
        /// Specifies the throttling policy that should be applied to this Source.
        /// </summary>
        /// <value>Specifies the throttling policy that should be applied to this Source.</value>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=true)]
        public ThrottlingPolicyParameters ThrottlingPolicy { get; set; }

        /// <summary>
        /// Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.
        /// </summary>
        /// <value>Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.</value>
        [DataMember(Name="throttlingPolicyOverrides", EmitDefaultValue=true)]
        public List<ThrottlingPolicyOverride> ThrottlingPolicyOverrides { get; set; }

        /// <summary>
        /// Specifies whether OAuth should be used for authentication in case of Exchange Online.
        /// </summary>
        /// <value>Specifies whether OAuth should be used for authentication in case of Exchange Online.</value>
        [DataMember(Name="useOAuthForExchangeOnline", EmitDefaultValue=true)]
        public bool? UseOAuthForExchangeOnline { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParameters VlanParams { get; set; }

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
            return this.Equals(input as RegisterProtectionSourceParameters);
        }

        /// <summary>
        /// Returns true if RegisterProtectionSourceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterProtectionSourceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterProtectionSourceParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisType == input.AcropolisType ||
                    this.AcropolisType.Equals(input.AcropolisType)
                ) && 
                (
                    this.AgentEndpoint == input.AgentEndpoint ||
                    (this.AgentEndpoint != null &&
                    this.AgentEndpoint.Equals(input.AgentEndpoint))
                ) && 
                (
                    this.AwsCredentials == input.AwsCredentials ||
                    (this.AwsCredentials != null &&
                    this.AwsCredentials.Equals(input.AwsCredentials))
                ) && 
                (
                    this.AzureCredentials == input.AzureCredentials ||
                    (this.AzureCredentials != null &&
                    this.AzureCredentials.Equals(input.AzureCredentials))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.ExchangeDagProtectionPreference == input.ExchangeDagProtectionPreference ||
                    (this.ExchangeDagProtectionPreference != null &&
                    this.ExchangeDagProtectionPreference.Equals(input.ExchangeDagProtectionPreference))
                ) && 
                (
                    this.ForceRegister == input.ForceRegister ||
                    (this.ForceRegister != null &&
                    this.ForceRegister.Equals(input.ForceRegister))
                ) && 
                (
                    this.GcpCredentials == input.GcpCredentials ||
                    (this.GcpCredentials != null &&
                    this.GcpCredentials.Equals(input.GcpCredentials))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.HyperVType == input.HyperVType ||
                    this.HyperVType.Equals(input.HyperVType)
                ) && 
                (
                    this.KubernetesCredentials == input.KubernetesCredentials ||
                    (this.KubernetesCredentials != null &&
                    this.KubernetesCredentials.Equals(input.KubernetesCredentials))
                ) && 
                (
                    this.KubernetesType == input.KubernetesType ||
                    this.KubernetesType.Equals(input.KubernetesType)
                ) && 
                (
                    this.KvmType == input.KvmType ||
                    this.KvmType.Equals(input.KvmType)
                ) && 
                (
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.NetappType == input.NetappType ||
                    this.NetappType.Equals(input.NetappType)
                ) && 
                (
                    this.NimbleType == input.NimbleType ||
                    this.NimbleType.Equals(input.NimbleType)
                ) && 
                (
                    this.Office365CredentialsList == input.Office365CredentialsList ||
                    this.Office365CredentialsList != null &&
                    input.Office365CredentialsList != null &&
                    this.Office365CredentialsList.SequenceEqual(input.Office365CredentialsList)
                ) && 
                (
                    this.Office365Type == input.Office365Type ||
                    this.Office365Type.Equals(input.Office365Type)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PhysicalType == input.PhysicalType ||
                    this.PhysicalType.Equals(input.PhysicalType)
                ) && 
                (
                    this.PureType == input.PureType ||
                    this.PureType.Equals(input.PureType)
                ) && 
                (
                    this.SourceSideDedupEnabled == input.SourceSideDedupEnabled ||
                    (this.SourceSideDedupEnabled != null &&
                    this.SourceSideDedupEnabled.Equals(input.SourceSideDedupEnabled))
                ) && 
                (
                    this.SslVerification == input.SslVerification ||
                    (this.SslVerification != null &&
                    this.SslVerification.Equals(input.SslVerification))
                ) && 
                (
                    this.ThrottlingPolicy == input.ThrottlingPolicy ||
                    (this.ThrottlingPolicy != null &&
                    this.ThrottlingPolicy.Equals(input.ThrottlingPolicy))
                ) && 
                (
                    this.ThrottlingPolicyOverrides == input.ThrottlingPolicyOverrides ||
                    this.ThrottlingPolicyOverrides != null &&
                    input.ThrottlingPolicyOverrides != null &&
                    this.ThrottlingPolicyOverrides.SequenceEqual(input.ThrottlingPolicyOverrides)
                ) && 
                (
                    this.UseOAuthForExchangeOnline == input.UseOAuthForExchangeOnline ||
                    (this.UseOAuthForExchangeOnline != null &&
                    this.UseOAuthForExchangeOnline.Equals(input.UseOAuthForExchangeOnline))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
                ) && 
                (
                    this.VmwareType == input.VmwareType ||
                    this.VmwareType.Equals(input.VmwareType)
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
                hashCode = hashCode * 59 + this.AcropolisType.GetHashCode();
                if (this.AgentEndpoint != null)
                    hashCode = hashCode * 59 + this.AgentEndpoint.GetHashCode();
                if (this.AwsCredentials != null)
                    hashCode = hashCode * 59 + this.AwsCredentials.GetHashCode();
                if (this.AzureCredentials != null)
                    hashCode = hashCode * 59 + this.AzureCredentials.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ExchangeDagProtectionPreference != null)
                    hashCode = hashCode * 59 + this.ExchangeDagProtectionPreference.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.GcpCredentials != null)
                    hashCode = hashCode * 59 + this.GcpCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                hashCode = hashCode * 59 + this.HyperVType.GetHashCode();
                if (this.KubernetesCredentials != null)
                    hashCode = hashCode * 59 + this.KubernetesCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.KubernetesType.GetHashCode();
                hashCode = hashCode * 59 + this.KvmType.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.NetappType.GetHashCode();
                hashCode = hashCode * 59 + this.NimbleType.GetHashCode();
                if (this.Office365CredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365CredentialsList.GetHashCode();
                hashCode = hashCode * 59 + this.Office365Type.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                hashCode = hashCode * 59 + this.PhysicalType.GetHashCode();
                hashCode = hashCode * 59 + this.PureType.GetHashCode();
                if (this.SourceSideDedupEnabled != null)
                    hashCode = hashCode * 59 + this.SourceSideDedupEnabled.GetHashCode();
                if (this.SslVerification != null)
                    hashCode = hashCode * 59 + this.SslVerification.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.UseOAuthForExchangeOnline != null)
                    hashCode = hashCode * 59 + this.UseOAuthForExchangeOnline.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                hashCode = hashCode * 59 + this.VmwareType.GetHashCode();
                return hashCode;
            }
        }

    }

}

