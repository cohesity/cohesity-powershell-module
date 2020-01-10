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
    /// Specifies a generic structure that represents a node in the Protection Source tree. Node details will depend on the environment of the Protection Source.
    /// </summary>
    [DataContract]
    public partial class ProtectionSource :  IEquatable<ProtectionSource>
    {
        /// <summary>
        /// Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
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
            /// Enum KVCD for value: kVCD
            /// </summary>
            [EnumMember(Value = "kVCD")]
            KVCD = 25,

            /// <summary>
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 26,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 27,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 28,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 29,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 30,

            /// <summary>
            /// Enum KKubernetes for value: kKubernetes
            /// </summary>
            [EnumMember(Value = "kKubernetes")]
            KKubernetes = 31,

            /// <summary>
            /// Enum KElastifile for value: kElastifile
            /// </summary>
            [EnumMember(Value = "kElastifile")]
            KElastifile = 32,

            /// <summary>
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 33

        }

        /// <summary>
        /// Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSource" /> class.
        /// </summary>
        /// <param name="acropolisProtectionSource">Specifies details about an Acropolis Protection Source when the environment is set to &#39;kAcropolis&#39;..</param>
        /// <param name="adProtectionSource">Specifies details about an AD Protection Source when the environment is set to &#39;kAD&#39;..</param>
        /// <param name="awsProtectionSource">Specifies details about an AWS Protection Source when the environment is set to &#39;kAWS&#39;..</param>
        /// <param name="azureProtectionSource">Specifies details about an Azure Protection Source when the environment is set to &#39;kAzure&#39;..</param>
        /// <param name="elastifileProtectionSource">Specifies details about a Elastifile Protection Source when the environment is set to &#39;kElastifile&#39;..</param>
        /// <param name="environment">Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment..</param>
        /// <param name="flashBladeProtectionSource">Specifies details about a Pure Storage FlashBlade Protection Source when the environment is set to &#39;kFlashBlade&#39;..</param>
        /// <param name="gcpProtectionSource">Specifies details about an GCP Protection Source when the environment is set to &#39;kGCP&#39;..</param>
        /// <param name="gpfsProtectionSource">Specifies details about an GPFS Protection Source when the environment is set to &#39;kGPFS&#39;..</param>
        /// <param name="hyperFlexProtectionSource">Specifies details about a HyperFlex Storage Snapshot source when the environment is set to &#39;kHyperFlex&#39;.</param>
        /// <param name="hypervProtectionSource">Specifies details about a HyperV Protection Source when the environment is set to &#39;kHyperV&#39;..</param>
        /// <param name="id">Specifies an id of the Protection Source..</param>
        /// <param name="isilonProtectionSource">Specifies details about an Isilon OneFs Protection Source when the environment is set to &#39;kIsilon&#39;..</param>
        /// <param name="kubernetesProtectionSource">Specifies details about a Kubernetes Protection Source when the environment is set to &#39;kKubernetes&#39;..</param>
        /// <param name="kvmProtectionSource">Specifies details about a KVM Protection Source when the environment is set to &#39;kKVM&#39;..</param>
        /// <param name="name">Specifies a name of the Protection Source..</param>
        /// <param name="nasProtectionSource">Specifies details about a Generic NAS Protection Source when the environment is set to &#39;kGenericNas&#39;..</param>
        /// <param name="netappProtectionSource">Specifies details about a NetApp Protection Source when the environment is set to &#39;kNetapp&#39;..</param>
        /// <param name="nimbleProtectionSource">Specifies details about a SAN Protection Source when the environment is set to &#39;kNimble&#39;..</param>
        /// <param name="office365ProtectionSource">Specifies details about an Office 365 Protection Source when the environment is set to &#39;kO365&#39;..</param>
        /// <param name="oracleProtectionSource">Specifies details about an Oracle Protection Source when the environment is set to &#39;kOracle&#39;..</param>
        /// <param name="parentId">Specifies an id of the parent of the Protection Source..</param>
        /// <param name="physicalProtectionSource">Specifies details about a Physical Protection Source when the environment is set to &#39;kPhysical&#39;..</param>
        /// <param name="pureProtectionSource">Specifies details about a Pure Protection Source when the environment is set to &#39;kPure&#39;..</param>
        /// <param name="sqlProtectionSource">Specifies details about a SQL Protection Source when the environment is set to &#39;kSQL&#39;..</param>
        /// <param name="viewProtectionSource">Specifies details about a View Protection Source when the environment is set to &#39;kView&#39;..</param>
        /// <param name="vmWareProtectionSource">Specifies details about a VMware Protection Source when the environment is set to &#39;kVMware&#39;..</param>
        public ProtectionSource(AcropolisProtectionSource acropolisProtectionSource = default(AcropolisProtectionSource), AdProtectionSource adProtectionSource = default(AdProtectionSource), AwsProtectionSource awsProtectionSource = default(AwsProtectionSource), AzureProtectionSource azureProtectionSource = default(AzureProtectionSource), ElastifileProtectionSource elastifileProtectionSource = default(ElastifileProtectionSource), EnvironmentEnum? environment = default(EnvironmentEnum?), FlashBladeProtectionSource flashBladeProtectionSource = default(FlashBladeProtectionSource), GcpProtectionSource gcpProtectionSource = default(GcpProtectionSource), GpfsProtectionSource gpfsProtectionSource = default(GpfsProtectionSource), HyperFlexProtectionSource hyperFlexProtectionSource = default(HyperFlexProtectionSource), HypervProtectionSource hypervProtectionSource = default(HypervProtectionSource), long? id = default(long?), IsilonProtectionSource isilonProtectionSource = default(IsilonProtectionSource), KubernetesProtectionSource kubernetesProtectionSource = default(KubernetesProtectionSource), KvmProtectionSource kvmProtectionSource = default(KvmProtectionSource), string name = default(string), NasProtectionSource nasProtectionSource = default(NasProtectionSource), NetappProtectionSource netappProtectionSource = default(NetappProtectionSource), NimbleProtectionSource nimbleProtectionSource = default(NimbleProtectionSource), Office365ProtectionSource office365ProtectionSource = default(Office365ProtectionSource), OracleProtectionSource oracleProtectionSource = default(OracleProtectionSource), long? parentId = default(long?), PhysicalProtectionSource physicalProtectionSource = default(PhysicalProtectionSource), PureProtectionSource pureProtectionSource = default(PureProtectionSource), SqlProtectionSource sqlProtectionSource = default(SqlProtectionSource), ViewProtectionSource viewProtectionSource = default(ViewProtectionSource), VMwareProtectionSource vmWareProtectionSource = default(VMwareProtectionSource))
        {
            this.AcropolisProtectionSource = acropolisProtectionSource;
            this.AdProtectionSource = adProtectionSource;
            this.AwsProtectionSource = awsProtectionSource;
            this.AzureProtectionSource = azureProtectionSource;
            this.ElastifileProtectionSource = elastifileProtectionSource;
            this.Environment = environment;
            this.FlashBladeProtectionSource = flashBladeProtectionSource;
            this.GcpProtectionSource = gcpProtectionSource;
            this.GpfsProtectionSource = gpfsProtectionSource;
            this.HyperFlexProtectionSource = hyperFlexProtectionSource;
            this.HypervProtectionSource = hypervProtectionSource;
            this.Id = id;
            this.IsilonProtectionSource = isilonProtectionSource;
            this.KubernetesProtectionSource = kubernetesProtectionSource;
            this.KvmProtectionSource = kvmProtectionSource;
            this.Name = name;
            this.NasProtectionSource = nasProtectionSource;
            this.NetappProtectionSource = netappProtectionSource;
            this.NimbleProtectionSource = nimbleProtectionSource;
            this.Office365ProtectionSource = office365ProtectionSource;
            this.OracleProtectionSource = oracleProtectionSource;
            this.ParentId = parentId;
            this.PhysicalProtectionSource = physicalProtectionSource;
            this.PureProtectionSource = pureProtectionSource;
            this.SqlProtectionSource = sqlProtectionSource;
            this.ViewProtectionSource = viewProtectionSource;
            this.VmWareProtectionSource = vmWareProtectionSource;
            this.AcropolisProtectionSource = acropolisProtectionSource;
            this.AdProtectionSource = adProtectionSource;
            this.AwsProtectionSource = awsProtectionSource;
            this.AzureProtectionSource = azureProtectionSource;
            this.ElastifileProtectionSource = elastifileProtectionSource;
            this.Environment = environment;
            this.FlashBladeProtectionSource = flashBladeProtectionSource;
            this.GcpProtectionSource = gcpProtectionSource;
            this.GpfsProtectionSource = gpfsProtectionSource;
            this.HyperFlexProtectionSource = hyperFlexProtectionSource;
            this.HypervProtectionSource = hypervProtectionSource;
            this.Id = id;
            this.IsilonProtectionSource = isilonProtectionSource;
            this.KubernetesProtectionSource = kubernetesProtectionSource;
            this.KvmProtectionSource = kvmProtectionSource;
            this.Name = name;
            this.NasProtectionSource = nasProtectionSource;
            this.NetappProtectionSource = netappProtectionSource;
            this.NimbleProtectionSource = nimbleProtectionSource;
            this.Office365ProtectionSource = office365ProtectionSource;
            this.OracleProtectionSource = oracleProtectionSource;
            this.ParentId = parentId;
            this.PhysicalProtectionSource = physicalProtectionSource;
            this.PureProtectionSource = pureProtectionSource;
            this.SqlProtectionSource = sqlProtectionSource;
            this.ViewProtectionSource = viewProtectionSource;
            this.VmWareProtectionSource = vmWareProtectionSource;
        }
        
        /// <summary>
        /// Specifies details about an Acropolis Protection Source when the environment is set to &#39;kAcropolis&#39;.
        /// </summary>
        /// <value>Specifies details about an Acropolis Protection Source when the environment is set to &#39;kAcropolis&#39;.</value>
        [DataMember(Name="acropolisProtectionSource", EmitDefaultValue=true)]
        public AcropolisProtectionSource AcropolisProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an AD Protection Source when the environment is set to &#39;kAD&#39;.
        /// </summary>
        /// <value>Specifies details about an AD Protection Source when the environment is set to &#39;kAD&#39;.</value>
        [DataMember(Name="adProtectionSource", EmitDefaultValue=true)]
        public AdProtectionSource AdProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an AWS Protection Source when the environment is set to &#39;kAWS&#39;.
        /// </summary>
        /// <value>Specifies details about an AWS Protection Source when the environment is set to &#39;kAWS&#39;.</value>
        [DataMember(Name="awsProtectionSource", EmitDefaultValue=true)]
        public AwsProtectionSource AwsProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an Azure Protection Source when the environment is set to &#39;kAzure&#39;.
        /// </summary>
        /// <value>Specifies details about an Azure Protection Source when the environment is set to &#39;kAzure&#39;.</value>
        [DataMember(Name="azureProtectionSource", EmitDefaultValue=true)]
        public AzureProtectionSource AzureProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a Elastifile Protection Source when the environment is set to &#39;kElastifile&#39;.
        /// </summary>
        /// <value>Specifies details about a Elastifile Protection Source when the environment is set to &#39;kElastifile&#39;.</value>
        [DataMember(Name="elastifileProtectionSource", EmitDefaultValue=true)]
        public ElastifileProtectionSource ElastifileProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a Pure Storage FlashBlade Protection Source when the environment is set to &#39;kFlashBlade&#39;.
        /// </summary>
        /// <value>Specifies details about a Pure Storage FlashBlade Protection Source when the environment is set to &#39;kFlashBlade&#39;.</value>
        [DataMember(Name="flashBladeProtectionSource", EmitDefaultValue=true)]
        public FlashBladeProtectionSource FlashBladeProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an GCP Protection Source when the environment is set to &#39;kGCP&#39;.
        /// </summary>
        /// <value>Specifies details about an GCP Protection Source when the environment is set to &#39;kGCP&#39;.</value>
        [DataMember(Name="gcpProtectionSource", EmitDefaultValue=true)]
        public GcpProtectionSource GcpProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an GPFS Protection Source when the environment is set to &#39;kGPFS&#39;.
        /// </summary>
        /// <value>Specifies details about an GPFS Protection Source when the environment is set to &#39;kGPFS&#39;.</value>
        [DataMember(Name="gpfsProtectionSource", EmitDefaultValue=true)]
        public GpfsProtectionSource GpfsProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a HyperFlex Storage Snapshot source when the environment is set to &#39;kHyperFlex&#39;
        /// </summary>
        /// <value>Specifies details about a HyperFlex Storage Snapshot source when the environment is set to &#39;kHyperFlex&#39;</value>
        [DataMember(Name="hyperFlexProtectionSource", EmitDefaultValue=true)]
        public HyperFlexProtectionSource HyperFlexProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a HyperV Protection Source when the environment is set to &#39;kHyperV&#39;.
        /// </summary>
        /// <value>Specifies details about a HyperV Protection Source when the environment is set to &#39;kHyperV&#39;.</value>
        [DataMember(Name="hypervProtectionSource", EmitDefaultValue=true)]
        public HypervProtectionSource HypervProtectionSource { get; set; }

        /// <summary>
        /// Specifies an id of the Protection Source.
        /// </summary>
        /// <value>Specifies an id of the Protection Source.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies details about an Isilon OneFs Protection Source when the environment is set to &#39;kIsilon&#39;.
        /// </summary>
        /// <value>Specifies details about an Isilon OneFs Protection Source when the environment is set to &#39;kIsilon&#39;.</value>
        [DataMember(Name="isilonProtectionSource", EmitDefaultValue=true)]
        public IsilonProtectionSource IsilonProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a Kubernetes Protection Source when the environment is set to &#39;kKubernetes&#39;.
        /// </summary>
        /// <value>Specifies details about a Kubernetes Protection Source when the environment is set to &#39;kKubernetes&#39;.</value>
        [DataMember(Name="kubernetesProtectionSource", EmitDefaultValue=true)]
        public KubernetesProtectionSource KubernetesProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a KVM Protection Source when the environment is set to &#39;kKVM&#39;.
        /// </summary>
        /// <value>Specifies details about a KVM Protection Source when the environment is set to &#39;kKVM&#39;.</value>
        [DataMember(Name="kvmProtectionSource", EmitDefaultValue=true)]
        public KvmProtectionSource KvmProtectionSource { get; set; }

        /// <summary>
        /// Specifies a name of the Protection Source.
        /// </summary>
        /// <value>Specifies a name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies details about a Generic NAS Protection Source when the environment is set to &#39;kGenericNas&#39;.
        /// </summary>
        /// <value>Specifies details about a Generic NAS Protection Source when the environment is set to &#39;kGenericNas&#39;.</value>
        [DataMember(Name="nasProtectionSource", EmitDefaultValue=true)]
        public NasProtectionSource NasProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a NetApp Protection Source when the environment is set to &#39;kNetapp&#39;.
        /// </summary>
        /// <value>Specifies details about a NetApp Protection Source when the environment is set to &#39;kNetapp&#39;.</value>
        [DataMember(Name="netappProtectionSource", EmitDefaultValue=true)]
        public NetappProtectionSource NetappProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a SAN Protection Source when the environment is set to &#39;kNimble&#39;.
        /// </summary>
        /// <value>Specifies details about a SAN Protection Source when the environment is set to &#39;kNimble&#39;.</value>
        [DataMember(Name="nimbleProtectionSource", EmitDefaultValue=true)]
        public NimbleProtectionSource NimbleProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an Office 365 Protection Source when the environment is set to &#39;kO365&#39;.
        /// </summary>
        /// <value>Specifies details about an Office 365 Protection Source when the environment is set to &#39;kO365&#39;.</value>
        [DataMember(Name="office365ProtectionSource", EmitDefaultValue=true)]
        public Office365ProtectionSource Office365ProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about an Oracle Protection Source when the environment is set to &#39;kOracle&#39;.
        /// </summary>
        /// <value>Specifies details about an Oracle Protection Source when the environment is set to &#39;kOracle&#39;.</value>
        [DataMember(Name="oracleProtectionSource", EmitDefaultValue=true)]
        public OracleProtectionSource OracleProtectionSource { get; set; }

        /// <summary>
        /// Specifies an id of the parent of the Protection Source.
        /// </summary>
        /// <value>Specifies an id of the parent of the Protection Source.</value>
        [DataMember(Name="parentId", EmitDefaultValue=true)]
        public long? ParentId { get; set; }

        /// <summary>
        /// Specifies details about a Physical Protection Source when the environment is set to &#39;kPhysical&#39;.
        /// </summary>
        /// <value>Specifies details about a Physical Protection Source when the environment is set to &#39;kPhysical&#39;.</value>
        [DataMember(Name="physicalProtectionSource", EmitDefaultValue=true)]
        public PhysicalProtectionSource PhysicalProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a Pure Protection Source when the environment is set to &#39;kPure&#39;.
        /// </summary>
        /// <value>Specifies details about a Pure Protection Source when the environment is set to &#39;kPure&#39;.</value>
        [DataMember(Name="pureProtectionSource", EmitDefaultValue=true)]
        public PureProtectionSource PureProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a SQL Protection Source when the environment is set to &#39;kSQL&#39;.
        /// </summary>
        /// <value>Specifies details about a SQL Protection Source when the environment is set to &#39;kSQL&#39;.</value>
        [DataMember(Name="sqlProtectionSource", EmitDefaultValue=true)]
        public SqlProtectionSource SqlProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a View Protection Source when the environment is set to &#39;kView&#39;.
        /// </summary>
        /// <value>Specifies details about a View Protection Source when the environment is set to &#39;kView&#39;.</value>
        [DataMember(Name="viewProtectionSource", EmitDefaultValue=true)]
        public ViewProtectionSource ViewProtectionSource { get; set; }

        /// <summary>
        /// Specifies details about a VMware Protection Source when the environment is set to &#39;kVMware&#39;.
        /// </summary>
        /// <value>Specifies details about a VMware Protection Source when the environment is set to &#39;kVMware&#39;.</value>
        [DataMember(Name="vmWareProtectionSource", EmitDefaultValue=true)]
        public VMwareProtectionSource VmWareProtectionSource { get; set; }

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
            return this.Equals(input as ProtectionSource);
        }

        /// <summary>
        /// Returns true if ProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisProtectionSource == input.AcropolisProtectionSource ||
                    (this.AcropolisProtectionSource != null &&
                    this.AcropolisProtectionSource.Equals(input.AcropolisProtectionSource))
                ) && 
                (
                    this.AdProtectionSource == input.AdProtectionSource ||
                    (this.AdProtectionSource != null &&
                    this.AdProtectionSource.Equals(input.AdProtectionSource))
                ) && 
                (
                    this.AwsProtectionSource == input.AwsProtectionSource ||
                    (this.AwsProtectionSource != null &&
                    this.AwsProtectionSource.Equals(input.AwsProtectionSource))
                ) && 
                (
                    this.AzureProtectionSource == input.AzureProtectionSource ||
                    (this.AzureProtectionSource != null &&
                    this.AzureProtectionSource.Equals(input.AzureProtectionSource))
                ) && 
                (
                    this.ElastifileProtectionSource == input.ElastifileProtectionSource ||
                    (this.ElastifileProtectionSource != null &&
                    this.ElastifileProtectionSource.Equals(input.ElastifileProtectionSource))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.FlashBladeProtectionSource == input.FlashBladeProtectionSource ||
                    (this.FlashBladeProtectionSource != null &&
                    this.FlashBladeProtectionSource.Equals(input.FlashBladeProtectionSource))
                ) && 
                (
                    this.GcpProtectionSource == input.GcpProtectionSource ||
                    (this.GcpProtectionSource != null &&
                    this.GcpProtectionSource.Equals(input.GcpProtectionSource))
                ) && 
                (
                    this.GpfsProtectionSource == input.GpfsProtectionSource ||
                    (this.GpfsProtectionSource != null &&
                    this.GpfsProtectionSource.Equals(input.GpfsProtectionSource))
                ) && 
                (
                    this.HyperFlexProtectionSource == input.HyperFlexProtectionSource ||
                    (this.HyperFlexProtectionSource != null &&
                    this.HyperFlexProtectionSource.Equals(input.HyperFlexProtectionSource))
                ) && 
                (
                    this.HypervProtectionSource == input.HypervProtectionSource ||
                    (this.HypervProtectionSource != null &&
                    this.HypervProtectionSource.Equals(input.HypervProtectionSource))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsilonProtectionSource == input.IsilonProtectionSource ||
                    (this.IsilonProtectionSource != null &&
                    this.IsilonProtectionSource.Equals(input.IsilonProtectionSource))
                ) && 
                (
                    this.KubernetesProtectionSource == input.KubernetesProtectionSource ||
                    (this.KubernetesProtectionSource != null &&
                    this.KubernetesProtectionSource.Equals(input.KubernetesProtectionSource))
                ) && 
                (
                    this.KvmProtectionSource == input.KvmProtectionSource ||
                    (this.KvmProtectionSource != null &&
                    this.KvmProtectionSource.Equals(input.KvmProtectionSource))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NasProtectionSource == input.NasProtectionSource ||
                    (this.NasProtectionSource != null &&
                    this.NasProtectionSource.Equals(input.NasProtectionSource))
                ) && 
                (
                    this.NetappProtectionSource == input.NetappProtectionSource ||
                    (this.NetappProtectionSource != null &&
                    this.NetappProtectionSource.Equals(input.NetappProtectionSource))
                ) && 
                (
                    this.NimbleProtectionSource == input.NimbleProtectionSource ||
                    (this.NimbleProtectionSource != null &&
                    this.NimbleProtectionSource.Equals(input.NimbleProtectionSource))
                ) && 
                (
                    this.Office365ProtectionSource == input.Office365ProtectionSource ||
                    (this.Office365ProtectionSource != null &&
                    this.Office365ProtectionSource.Equals(input.Office365ProtectionSource))
                ) && 
                (
                    this.OracleProtectionSource == input.OracleProtectionSource ||
                    (this.OracleProtectionSource != null &&
                    this.OracleProtectionSource.Equals(input.OracleProtectionSource))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.PhysicalProtectionSource == input.PhysicalProtectionSource ||
                    (this.PhysicalProtectionSource != null &&
                    this.PhysicalProtectionSource.Equals(input.PhysicalProtectionSource))
                ) && 
                (
                    this.PureProtectionSource == input.PureProtectionSource ||
                    (this.PureProtectionSource != null &&
                    this.PureProtectionSource.Equals(input.PureProtectionSource))
                ) && 
                (
                    this.SqlProtectionSource == input.SqlProtectionSource ||
                    (this.SqlProtectionSource != null &&
                    this.SqlProtectionSource.Equals(input.SqlProtectionSource))
                ) && 
                (
                    this.ViewProtectionSource == input.ViewProtectionSource ||
                    (this.ViewProtectionSource != null &&
                    this.ViewProtectionSource.Equals(input.ViewProtectionSource))
                ) && 
                (
                    this.VmWareProtectionSource == input.VmWareProtectionSource ||
                    (this.VmWareProtectionSource != null &&
                    this.VmWareProtectionSource.Equals(input.VmWareProtectionSource))
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
                if (this.AcropolisProtectionSource != null)
                    hashCode = hashCode * 59 + this.AcropolisProtectionSource.GetHashCode();
                if (this.AdProtectionSource != null)
                    hashCode = hashCode * 59 + this.AdProtectionSource.GetHashCode();
                if (this.AwsProtectionSource != null)
                    hashCode = hashCode * 59 + this.AwsProtectionSource.GetHashCode();
                if (this.AzureProtectionSource != null)
                    hashCode = hashCode * 59 + this.AzureProtectionSource.GetHashCode();
                if (this.ElastifileProtectionSource != null)
                    hashCode = hashCode * 59 + this.ElastifileProtectionSource.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.FlashBladeProtectionSource != null)
                    hashCode = hashCode * 59 + this.FlashBladeProtectionSource.GetHashCode();
                if (this.GcpProtectionSource != null)
                    hashCode = hashCode * 59 + this.GcpProtectionSource.GetHashCode();
                if (this.GpfsProtectionSource != null)
                    hashCode = hashCode * 59 + this.GpfsProtectionSource.GetHashCode();
                if (this.HyperFlexProtectionSource != null)
                    hashCode = hashCode * 59 + this.HyperFlexProtectionSource.GetHashCode();
                if (this.HypervProtectionSource != null)
                    hashCode = hashCode * 59 + this.HypervProtectionSource.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsilonProtectionSource != null)
                    hashCode = hashCode * 59 + this.IsilonProtectionSource.GetHashCode();
                if (this.KubernetesProtectionSource != null)
                    hashCode = hashCode * 59 + this.KubernetesProtectionSource.GetHashCode();
                if (this.KvmProtectionSource != null)
                    hashCode = hashCode * 59 + this.KvmProtectionSource.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NasProtectionSource != null)
                    hashCode = hashCode * 59 + this.NasProtectionSource.GetHashCode();
                if (this.NetappProtectionSource != null)
                    hashCode = hashCode * 59 + this.NetappProtectionSource.GetHashCode();
                if (this.NimbleProtectionSource != null)
                    hashCode = hashCode * 59 + this.NimbleProtectionSource.GetHashCode();
                if (this.Office365ProtectionSource != null)
                    hashCode = hashCode * 59 + this.Office365ProtectionSource.GetHashCode();
                if (this.OracleProtectionSource != null)
                    hashCode = hashCode * 59 + this.OracleProtectionSource.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.PhysicalProtectionSource != null)
                    hashCode = hashCode * 59 + this.PhysicalProtectionSource.GetHashCode();
                if (this.PureProtectionSource != null)
                    hashCode = hashCode * 59 + this.PureProtectionSource.GetHashCode();
                if (this.SqlProtectionSource != null)
                    hashCode = hashCode * 59 + this.SqlProtectionSource.GetHashCode();
                if (this.ViewProtectionSource != null)
                    hashCode = hashCode * 59 + this.ViewProtectionSource.GetHashCode();
                if (this.VmWareProtectionSource != null)
                    hashCode = hashCode * 59 + this.VmWareProtectionSource.GetHashCode();
                return hashCode;
            }
        }

    }

}

