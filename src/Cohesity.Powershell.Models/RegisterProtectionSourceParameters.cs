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
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment.</value>
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
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 8,

            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 9,

            /// <summary>
            /// Enum KAgent for value: kAgent
            /// </summary>
            [EnumMember(Value = "kAgent")]
            KAgent = 10,

            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 11,

            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 12,

            /// <summary>
            /// Enum KPhysicalFiles for value: kPhysicalFiles
            /// </summary>
            [EnumMember(Value = "kPhysicalFiles")]
            KPhysicalFiles = 13,

            /// <summary>
            /// Enum KIsilon for value: kIsilon
            /// </summary>
            [EnumMember(Value = "kIsilon")]
            KIsilon = 14,

            /// <summary>
            /// Enum KKVM for value: kKVM
            /// </summary>
            [EnumMember(Value = "kKVM")]
            KKVM = 15,

            /// <summary>
            /// Enum KAWS for value: kAWS
            /// </summary>
            [EnumMember(Value = "kAWS")]
            KAWS = 16,

            /// <summary>
            /// Enum KExchange for value: kExchange
            /// </summary>
            [EnumMember(Value = "kExchange")]
            KExchange = 17,

            /// <summary>
            /// Enum KHyperVVSS for value: kHyperVVSS
            /// </summary>
            [EnumMember(Value = "kHyperVVSS")]
            KHyperVVSS = 18,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 19,

            /// <summary>
            /// Enum KGCP for value: kGCP
            /// </summary>
            [EnumMember(Value = "kGCP")]
            KGCP = 20,

            /// <summary>
            /// Enum KFlashBlade for value: kFlashBlade
            /// </summary>
            [EnumMember(Value = "kFlashBlade")]
            KFlashBlade = 21,

            /// <summary>
            /// Enum KAWSNative for value: kAWSNative
            /// </summary>
            [EnumMember(Value = "kAWSNative")]
            KAWSNative = 22,

            /// <summary>
            /// Enum KVCD for value: kVCD
            /// </summary>
            [EnumMember(Value = "kVCD")]
            KVCD = 23,

            /// <summary>
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 24,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 25,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 26,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 27,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 28

        }

        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.</value>
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
            KSolaris = 4

        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.</value>
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
            KVserver = 2,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 3

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.</value>
        [DataMember(Name="netappType", EmitDefaultValue=true)]
        public NetappTypeEnum? NetappType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhysicalTypeEnum
        {
            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 1,

            /// <summary>
            /// Enum KWindowsCluster for value: kWindowsCluster
            /// </summary>
            [EnumMember(Value = "kWindowsCluster")]
            KWindowsCluster = 2

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [DataMember(Name="physicalType", EmitDefaultValue=true)]
        public PhysicalTypeEnum? PhysicalType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire pure storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire pure storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PureTypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire pure storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire pure storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected.</value>
        [DataMember(Name="pureType", EmitDefaultValue=true)]
        public PureTypeEnum? PureType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. &#39;kVCenter&#39; indicates the vCenter entity in a VMware protection source type. &#39;kFolder indicates the folder entity (of any kind) in a VMware protection source type. &#39;kDatacenter&#39; indicates the datacenter entity in a VMware protection source type. &#39;kComputeResource&#39; indicates the physical compute resource entity in a VMware protection source type. &#39;kResourcePool&#39; indicates the set of physical resourses within a compute resource or cloudcompute resource. &#39;kDataStore&#39; indicates the datastore entity in a VMware protection source type. &#39;kHostSystem&#39; indicates the ESXi host entity in a VMware protection source type. &#39;kVirtualMachine&#39; indicates the virtual machine entity in a VMware protection source type. &#39;kVirtualApp&#39; indicates the virtual app entity in a VMware protection source type. &#39;kStandaloneHost&#39; indicates the standalone ESXi host entity (not managed by vCenter) in a VMware protection source type. &#39;kStoragePod&#39; indicates the storage pod entity in a VMware protection source type. &#39;kNetwork&#39; indicates the standard vSwitch in a VMware protection source type. &#39;kDistributedVirtualPortgroup&#39; indicates a distributed vSwitch port group in a VMware protection source type. &#39;kTagCategory&#39; indicates a tag category entity in a VMware protection source type. &#39;kTag&#39; indocates a tag entity in a VMware protection source type. &#39;kOpaqueNetwork&#39; indicates a opaque network which is created and managed by an entity outside of vSphere. &#39;kVCloudDirector&#39; indicates a vCloud director entity in a VMware protection source type. &#39;kOrganization&#39; indicates an Organization under a vCD in a VMware protection source type. &#39;kVirtualDatacenter&#39; indicates a virtual datacenter entity in a VMware protection source type. &#39;kCatalog&#39; indocates a VCD catalog entity in a VMware protection source type. &#39;kOrgMetadata&#39; indicates an VCD organization metadata in a VMware protection source type. &#39;kStoragePolicy&#39; indicates a storage policy associated with the vApp in a VMware protection source type.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. &#39;kVCenter&#39; indicates the vCenter entity in a VMware protection source type. &#39;kFolder indicates the folder entity (of any kind) in a VMware protection source type. &#39;kDatacenter&#39; indicates the datacenter entity in a VMware protection source type. &#39;kComputeResource&#39; indicates the physical compute resource entity in a VMware protection source type. &#39;kResourcePool&#39; indicates the set of physical resourses within a compute resource or cloudcompute resource. &#39;kDataStore&#39; indicates the datastore entity in a VMware protection source type. &#39;kHostSystem&#39; indicates the ESXi host entity in a VMware protection source type. &#39;kVirtualMachine&#39; indicates the virtual machine entity in a VMware protection source type. &#39;kVirtualApp&#39; indicates the virtual app entity in a VMware protection source type. &#39;kStandaloneHost&#39; indicates the standalone ESXi host entity (not managed by vCenter) in a VMware protection source type. &#39;kStoragePod&#39; indicates the storage pod entity in a VMware protection source type. &#39;kNetwork&#39; indicates the standard vSwitch in a VMware protection source type. &#39;kDistributedVirtualPortgroup&#39; indicates a distributed vSwitch port group in a VMware protection source type. &#39;kTagCategory&#39; indicates a tag category entity in a VMware protection source type. &#39;kTag&#39; indocates a tag entity in a VMware protection source type. &#39;kOpaqueNetwork&#39; indicates a opaque network which is created and managed by an entity outside of vSphere. &#39;kVCloudDirector&#39; indicates a vCloud director entity in a VMware protection source type. &#39;kOrganization&#39; indicates an Organization under a vCD in a VMware protection source type. &#39;kVirtualDatacenter&#39; indicates a virtual datacenter entity in a VMware protection source type. &#39;kCatalog&#39; indocates a VCD catalog entity in a VMware protection source type. &#39;kOrgMetadata&#39; indicates an VCD organization metadata in a VMware protection source type. &#39;kStoragePolicy&#39; indicates a storage policy associated with the vApp in a VMware protection source type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmwareTypeEnum
        {
            /// <summary>
            /// Enum KVCenter for value: kVCenter
            /// </summary>
            [EnumMember(Value = "kVCenter")]
            KVCenter = 1,

            /// <summary>
            /// Enum KFolder for value: kFolder
            /// </summary>
            [EnumMember(Value = "kFolder")]
            KFolder = 2,

            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,

            /// <summary>
            /// Enum KComputeResource for value: kComputeResource
            /// </summary>
            [EnumMember(Value = "kComputeResource")]
            KComputeResource = 4,

            /// <summary>
            /// Enum KClusterComputeResource for value: kClusterComputeResource
            /// </summary>
            [EnumMember(Value = "kClusterComputeResource")]
            KClusterComputeResource = 5,

            /// <summary>
            /// Enum KResourcePool for value: kResourcePool
            /// </summary>
            [EnumMember(Value = "kResourcePool")]
            KResourcePool = 6,

            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 7,

            /// <summary>
            /// Enum KHostSystem for value: kHostSystem
            /// </summary>
            [EnumMember(Value = "kHostSystem")]
            KHostSystem = 8,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 9,

            /// <summary>
            /// Enum KVirtualApp for value: kVirtualApp
            /// </summary>
            [EnumMember(Value = "kVirtualApp")]
            KVirtualApp = 10,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 11,

            /// <summary>
            /// Enum KStoragePod for value: kStoragePod
            /// </summary>
            [EnumMember(Value = "kStoragePod")]
            KStoragePod = 12,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 13,

            /// <summary>
            /// Enum KDistributedVirtualPortgroup for value: kDistributedVirtualPortgroup
            /// </summary>
            [EnumMember(Value = "kDistributedVirtualPortgroup")]
            KDistributedVirtualPortgroup = 14,

            /// <summary>
            /// Enum KTagCategory for value: kTagCategory
            /// </summary>
            [EnumMember(Value = "kTagCategory")]
            KTagCategory = 15,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 16,

            /// <summary>
            /// Enum KOpaqueNetwork for value: kOpaqueNetwork
            /// </summary>
            [EnumMember(Value = "kOpaqueNetwork")]
            KOpaqueNetwork = 17,

            /// <summary>
            /// Enum KVCloudDirector for value: kVCloudDirector
            /// </summary>
            [EnumMember(Value = "kVCloudDirector")]
            KVCloudDirector = 18,

            /// <summary>
            /// Enum KOrganization for value: kOrganization
            /// </summary>
            [EnumMember(Value = "kOrganization")]
            KOrganization = 19,

            /// <summary>
            /// Enum KVirtualDatacenter for value: kVirtualDatacenter
            /// </summary>
            [EnumMember(Value = "kVirtualDatacenter")]
            KVirtualDatacenter = 20,

            /// <summary>
            /// Enum KCatalog for value: kCatalog
            /// </summary>
            [EnumMember(Value = "kCatalog")]
            KCatalog = 21,

            /// <summary>
            /// Enum KOrgMetadata for value: kOrgMetadata
            /// </summary>
            [EnumMember(Value = "kOrgMetadata")]
            KOrgMetadata = 22,

            /// <summary>
            /// Enum KStoragePolicy for value: kStoragePolicy
            /// </summary>
            [EnumMember(Value = "kStoragePolicy")]
            KStoragePolicy = 23

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. &#39;kVCenter&#39; indicates the vCenter entity in a VMware protection source type. &#39;kFolder indicates the folder entity (of any kind) in a VMware protection source type. &#39;kDatacenter&#39; indicates the datacenter entity in a VMware protection source type. &#39;kComputeResource&#39; indicates the physical compute resource entity in a VMware protection source type. &#39;kResourcePool&#39; indicates the set of physical resourses within a compute resource or cloudcompute resource. &#39;kDataStore&#39; indicates the datastore entity in a VMware protection source type. &#39;kHostSystem&#39; indicates the ESXi host entity in a VMware protection source type. &#39;kVirtualMachine&#39; indicates the virtual machine entity in a VMware protection source type. &#39;kVirtualApp&#39; indicates the virtual app entity in a VMware protection source type. &#39;kStandaloneHost&#39; indicates the standalone ESXi host entity (not managed by vCenter) in a VMware protection source type. &#39;kStoragePod&#39; indicates the storage pod entity in a VMware protection source type. &#39;kNetwork&#39; indicates the standard vSwitch in a VMware protection source type. &#39;kDistributedVirtualPortgroup&#39; indicates a distributed vSwitch port group in a VMware protection source type. &#39;kTagCategory&#39; indicates a tag category entity in a VMware protection source type. &#39;kTag&#39; indocates a tag entity in a VMware protection source type. &#39;kOpaqueNetwork&#39; indicates a opaque network which is created and managed by an entity outside of vSphere. &#39;kVCloudDirector&#39; indicates a vCloud director entity in a VMware protection source type. &#39;kOrganization&#39; indicates an Organization under a vCD in a VMware protection source type. &#39;kVirtualDatacenter&#39; indicates a virtual datacenter entity in a VMware protection source type. &#39;kCatalog&#39; indocates a VCD catalog entity in a VMware protection source type. &#39;kOrgMetadata&#39; indicates an VCD organization metadata in a VMware protection source type. &#39;kStoragePolicy&#39; indicates a storage policy associated with the vApp in a VMware protection source type.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. &#39;kVCenter&#39; indicates the vCenter entity in a VMware protection source type. &#39;kFolder indicates the folder entity (of any kind) in a VMware protection source type. &#39;kDatacenter&#39; indicates the datacenter entity in a VMware protection source type. &#39;kComputeResource&#39; indicates the physical compute resource entity in a VMware protection source type. &#39;kResourcePool&#39; indicates the set of physical resourses within a compute resource or cloudcompute resource. &#39;kDataStore&#39; indicates the datastore entity in a VMware protection source type. &#39;kHostSystem&#39; indicates the ESXi host entity in a VMware protection source type. &#39;kVirtualMachine&#39; indicates the virtual machine entity in a VMware protection source type. &#39;kVirtualApp&#39; indicates the virtual app entity in a VMware protection source type. &#39;kStandaloneHost&#39; indicates the standalone ESXi host entity (not managed by vCenter) in a VMware protection source type. &#39;kStoragePod&#39; indicates the storage pod entity in a VMware protection source type. &#39;kNetwork&#39; indicates the standard vSwitch in a VMware protection source type. &#39;kDistributedVirtualPortgroup&#39; indicates a distributed vSwitch port group in a VMware protection source type. &#39;kTagCategory&#39; indicates a tag category entity in a VMware protection source type. &#39;kTag&#39; indocates a tag entity in a VMware protection source type. &#39;kOpaqueNetwork&#39; indicates a opaque network which is created and managed by an entity outside of vSphere. &#39;kVCloudDirector&#39; indicates a vCloud director entity in a VMware protection source type. &#39;kOrganization&#39; indicates an Organization under a vCD in a VMware protection source type. &#39;kVirtualDatacenter&#39; indicates a virtual datacenter entity in a VMware protection source type. &#39;kCatalog&#39; indocates a VCD catalog entity in a VMware protection source type. &#39;kOrgMetadata&#39; indicates an VCD organization metadata in a VMware protection source type. &#39;kStoragePolicy&#39; indicates a storage policy associated with the vApp in a VMware protection source type.</value>
        [DataMember(Name="vmwareType", EmitDefaultValue=true)]
        public VmwareTypeEnum? VmwareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="awsCredentials">awsCredentials.</param>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="environment">Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment..</param>
        /// <param name="forceRegister">forceRegister.</param>
        /// <param name="gcpCredentials">gcpCredentials.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system..</param>
        /// <param name="nasMountCredentials">Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers..</param>
        /// <param name="netappType">Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source..</param>
        /// <param name="office365Credentials">office365Credentials.</param>
        /// <param name="office365Type">Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="physicalType">Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster..</param>
        /// <param name="pureType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. &#39;kStorageArray&#39; indicates that entire pure storage array is being protected. &#39;kVolume&#39; indicates that volume within the array is being protected..</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="sslVerification">sslVerification.</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vmwareType">Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. &#39;kVCenter&#39; indicates the vCenter entity in a VMware protection source type. &#39;kFolder indicates the folder entity (of any kind) in a VMware protection source type. &#39;kDatacenter&#39; indicates the datacenter entity in a VMware protection source type. &#39;kComputeResource&#39; indicates the physical compute resource entity in a VMware protection source type. &#39;kResourcePool&#39; indicates the set of physical resourses within a compute resource or cloudcompute resource. &#39;kDataStore&#39; indicates the datastore entity in a VMware protection source type. &#39;kHostSystem&#39; indicates the ESXi host entity in a VMware protection source type. &#39;kVirtualMachine&#39; indicates the virtual machine entity in a VMware protection source type. &#39;kVirtualApp&#39; indicates the virtual app entity in a VMware protection source type. &#39;kStandaloneHost&#39; indicates the standalone ESXi host entity (not managed by vCenter) in a VMware protection source type. &#39;kStoragePod&#39; indicates the storage pod entity in a VMware protection source type. &#39;kNetwork&#39; indicates the standard vSwitch in a VMware protection source type. &#39;kDistributedVirtualPortgroup&#39; indicates a distributed vSwitch port group in a VMware protection source type. &#39;kTagCategory&#39; indicates a tag category entity in a VMware protection source type. &#39;kTag&#39; indocates a tag entity in a VMware protection source type. &#39;kOpaqueNetwork&#39; indicates a opaque network which is created and managed by an entity outside of vSphere. &#39;kVCloudDirector&#39; indicates a vCloud director entity in a VMware protection source type. &#39;kOrganization&#39; indicates an Organization under a vCD in a VMware protection source type. &#39;kVirtualDatacenter&#39; indicates a virtual datacenter entity in a VMware protection source type. &#39;kCatalog&#39; indocates a VCD catalog entity in a VMware protection source type. &#39;kOrgMetadata&#39; indicates an VCD organization metadata in a VMware protection source type. &#39;kStoragePolicy&#39; indicates a storage policy associated with the vApp in a VMware protection source type..</param>
        public RegisterProtectionSourceParameters(AwsCredentials awsCredentials = default(AwsCredentials), AzureCredentials azureCredentials = default(AzureCredentials), string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), bool? forceRegister = default(bool?), GcpCredentials gcpCredentials = default(GcpCredentials), HostTypeEnum? hostType = default(HostTypeEnum?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), NetappTypeEnum? netappType = default(NetappTypeEnum?), Office365Credentials office365Credentials = default(Office365Credentials), int? office365Type = default(int?), string password = default(string), PhysicalTypeEnum? physicalType = default(PhysicalTypeEnum?), PureTypeEnum? pureType = default(PureTypeEnum?), bool? sourceSideDedupEnabled = default(bool?), SslVerification sslVerification = default(SslVerification), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), string username = default(string), VmwareTypeEnum? vmwareType = default(VmwareTypeEnum?))
        {
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
            this.VmwareType = vmwareType;
            this.AwsCredentials = awsCredentials;
            this.AzureCredentials = azureCredentials;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ForceRegister = forceRegister;
            this.GcpCredentials = gcpCredentials;
            this.HostType = hostType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.Office365Credentials = office365Credentials;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.SslVerification = sslVerification;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
            this.VmwareType = vmwareType;
        }
        
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
        /// Gets or Sets ForceRegister
        /// </summary>
        [DataMember(Name="forceRegister", EmitDefaultValue=true)]
        public bool? ForceRegister { get; set; }

        /// <summary>
        /// Gets or Sets GcpCredentials
        /// </summary>
        [DataMember(Name="gcpCredentials", EmitDefaultValue=false)]
        public GcpCredentials GcpCredentials { get; set; }

        /// <summary>
        /// Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.
        /// </summary>
        /// <value>Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.</value>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=true)]
        public NasMountCredentialParams NasMountCredentials { get; set; }

        /// <summary>
        /// Gets or Sets Office365Credentials
        /// </summary>
        [DataMember(Name="office365Credentials", EmitDefaultValue=false)]
        public Office365Credentials Office365Credentials { get; set; }

        /// <summary>
        /// Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.</value>
        [DataMember(Name="office365Type", EmitDefaultValue=true)]
        public int? Office365Type { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers).
        /// </summary>
        /// <value>This controls whether to use source side dedup on the source or not. This is only applicable to Protection Sources which support source side dedup (e.g., Linux physical servers).</value>
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
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
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
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.NetappType == input.NetappType ||
                    this.NetappType.Equals(input.NetappType)
                ) && 
                (
                    this.Office365Credentials == input.Office365Credentials ||
                    (this.Office365Credentials != null &&
                    this.Office365Credentials.Equals(input.Office365Credentials))
                ) && 
                (
                    this.Office365Type == input.Office365Type ||
                    (this.Office365Type != null &&
                    this.Office365Type.Equals(input.Office365Type))
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.AwsCredentials != null)
                    hashCode = hashCode * 59 + this.AwsCredentials.GetHashCode();
                if (this.AzureCredentials != null)
                    hashCode = hashCode * 59 + this.AzureCredentials.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.GcpCredentials != null)
                    hashCode = hashCode * 59 + this.GcpCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.NetappType.GetHashCode();
                if (this.Office365Credentials != null)
                    hashCode = hashCode * 59 + this.Office365Credentials.GetHashCode();
                if (this.Office365Type != null)
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                hashCode = hashCode * 59 + this.VmwareType.GetHashCode();
                return hashCode;
            }
        }

    }

}

