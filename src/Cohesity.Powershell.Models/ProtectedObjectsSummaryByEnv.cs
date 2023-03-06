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
    /// Specifies the protection summary of given environment type.
    /// </summary>
    [DataContract]
    public partial class ProtectedObjectsSummaryByEnv :  IEquatable<ProtectedObjectsSummaryByEnv>
    {
        /// <summary>
        /// Specifies the environment.
        /// </summary>
        /// <value>Specifies the environment.</value>
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
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 31,

            /// <summary>
            /// Enum KAWSSnapshotManager for value: kAWSSnapshotManager
            /// </summary>
            [EnumMember(Value = "kAWSSnapshotManager")]
            KAWSSnapshotManager = 32

        }

        /// <summary>
        /// Specifies the environment.
        /// </summary>
        /// <value>Specifies the environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedObjectsSummaryByEnv" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment..</param>
        /// <param name="numObjectsProtected">Specifies the total number of protected objects..</param>
        /// <param name="numObjectsUnprotected">Specifies the total number of unprotected objects..</param>
        /// <param name="protectedSizeBytes">Specifies the total size of protected objects in bytes..</param>
        /// <param name="unprotectedSizeBytes">Specifies the total size of unprotected objects in bytes..</param>
        public ProtectedObjectsSummaryByEnv(EnvironmentEnum? environment = default(EnvironmentEnum?), long? numObjectsProtected = default(long?), long? numObjectsUnprotected = default(long?), long? protectedSizeBytes = default(long?), long? unprotectedSizeBytes = default(long?))
        {
            this.Environment = environment;
            this.NumObjectsProtected = numObjectsProtected;
            this.NumObjectsUnprotected = numObjectsUnprotected;
            this.ProtectedSizeBytes = protectedSizeBytes;
            this.UnprotectedSizeBytes = unprotectedSizeBytes;
            this.Environment = environment;
            this.NumObjectsProtected = numObjectsProtected;
            this.NumObjectsUnprotected = numObjectsUnprotected;
            this.ProtectedSizeBytes = protectedSizeBytes;
            this.UnprotectedSizeBytes = unprotectedSizeBytes;
        }
        
        /// <summary>
        /// Specifies the total number of protected objects.
        /// </summary>
        /// <value>Specifies the total number of protected objects.</value>
        [DataMember(Name="numObjectsProtected", EmitDefaultValue=true)]
        public long? NumObjectsProtected { get; set; }

        /// <summary>
        /// Specifies the total number of unprotected objects.
        /// </summary>
        /// <value>Specifies the total number of unprotected objects.</value>
        [DataMember(Name="numObjectsUnprotected", EmitDefaultValue=true)]
        public long? NumObjectsUnprotected { get; set; }

        /// <summary>
        /// Specifies the total size of protected objects in bytes.
        /// </summary>
        /// <value>Specifies the total size of protected objects in bytes.</value>
        [DataMember(Name="protectedSizeBytes", EmitDefaultValue=true)]
        public long? ProtectedSizeBytes { get; set; }

        /// <summary>
        /// Specifies the total size of unprotected objects in bytes.
        /// </summary>
        /// <value>Specifies the total size of unprotected objects in bytes.</value>
        [DataMember(Name="unprotectedSizeBytes", EmitDefaultValue=true)]
        public long? UnprotectedSizeBytes { get; set; }

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
            return this.Equals(input as ProtectedObjectsSummaryByEnv);
        }

        /// <summary>
        /// Returns true if ProtectedObjectsSummaryByEnv instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedObjectsSummaryByEnv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedObjectsSummaryByEnv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.NumObjectsProtected == input.NumObjectsProtected ||
                    (this.NumObjectsProtected != null &&
                    this.NumObjectsProtected.Equals(input.NumObjectsProtected))
                ) && 
                (
                    this.NumObjectsUnprotected == input.NumObjectsUnprotected ||
                    (this.NumObjectsUnprotected != null &&
                    this.NumObjectsUnprotected.Equals(input.NumObjectsUnprotected))
                ) && 
                (
                    this.ProtectedSizeBytes == input.ProtectedSizeBytes ||
                    (this.ProtectedSizeBytes != null &&
                    this.ProtectedSizeBytes.Equals(input.ProtectedSizeBytes))
                ) && 
                (
                    this.UnprotectedSizeBytes == input.UnprotectedSizeBytes ||
                    (this.UnprotectedSizeBytes != null &&
                    this.UnprotectedSizeBytes.Equals(input.UnprotectedSizeBytes))
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
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.NumObjectsProtected != null)
                    hashCode = hashCode * 59 + this.NumObjectsProtected.GetHashCode();
                if (this.NumObjectsUnprotected != null)
                    hashCode = hashCode * 59 + this.NumObjectsUnprotected.GetHashCode();
                if (this.ProtectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.ProtectedSizeBytes.GetHashCode();
                if (this.UnprotectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.UnprotectedSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

