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
    /// Specifies the parameters to protect an object.
    /// </summary>
    [DataContract]
    public partial class ProtectObjectParameters :  IEquatable<ProtectObjectParameters>
    {
        /// <summary>
        /// Specifies the environment type of the Protection Source object. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment type of the Protection Source object. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectionSourceEnvironmentEnum
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
        /// Specifies the environment type of the Protection Source object. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment type of the Protection Source object. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [DataMember(Name="protectionSourceEnvironment", EmitDefaultValue=true)]
        public ProtectionSourceEnvironmentEnum? ProtectionSourceEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectObjectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProtectObjectParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectObjectParameters" /> class.
        /// </summary>
        /// <param name="protectionSourceEnvironment">Specifies the environment type of the Protection Source object. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment..</param>
        /// <param name="protectionSourceIds">Specifies the ids of the Protection Sources to protect. (required).</param>
        /// <param name="rpoPolicyId">Specifies the Rpo policy id. (required).</param>
        public ProtectObjectParameters(ProtectionSourceEnvironmentEnum? protectionSourceEnvironment = default(ProtectionSourceEnvironmentEnum?), List<long> protectionSourceIds = default(List<long>), string rpoPolicyId = default(string))
        {
            this.ProtectionSourceEnvironment = protectionSourceEnvironment;
            this.ProtectionSourceIds = protectionSourceIds;
            this.RpoPolicyId = rpoPolicyId;
            this.ProtectionSourceEnvironment = protectionSourceEnvironment;
        }
        
        /// <summary>
        /// Specifies the ids of the Protection Sources to protect.
        /// </summary>
        /// <value>Specifies the ids of the Protection Sources to protect.</value>
        [DataMember(Name="protectionSourceIds", EmitDefaultValue=true)]
        public List<long> ProtectionSourceIds { get; set; }

        /// <summary>
        /// Specifies the Rpo policy id.
        /// </summary>
        /// <value>Specifies the Rpo policy id.</value>
        [DataMember(Name="rpoPolicyId", EmitDefaultValue=true)]
        public string RpoPolicyId { get; set; }

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
            return this.Equals(input as ProtectObjectParameters);
        }

        /// <summary>
        /// Returns true if ProtectObjectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectObjectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectObjectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionSourceEnvironment == input.ProtectionSourceEnvironment ||
                    this.ProtectionSourceEnvironment.Equals(input.ProtectionSourceEnvironment)
                ) && 
                (
                    this.ProtectionSourceIds == input.ProtectionSourceIds ||
                    this.ProtectionSourceIds != null &&
                    input.ProtectionSourceIds != null &&
                    this.ProtectionSourceIds.SequenceEqual(input.ProtectionSourceIds)
                ) && 
                (
                    this.RpoPolicyId == input.RpoPolicyId ||
                    (this.RpoPolicyId != null &&
                    this.RpoPolicyId.Equals(input.RpoPolicyId))
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
                hashCode = hashCode * 59 + this.ProtectionSourceEnvironment.GetHashCode();
                if (this.ProtectionSourceIds != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceIds.GetHashCode();
                if (this.RpoPolicyId != null)
                    hashCode = hashCode * 59 + this.RpoPolicyId.GetHashCode();
                return hashCode;
            }
        }

    }

}

