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
    /// Specifies the aggregated statistics for restores of a specific environment type.
    /// </summary>
    [DataContract]
    public partial class RestoreEnvStats :  IEquatable<RestoreEnvStats>
    {
        /// <summary>
        /// Specifies the environment.
        /// </summary>
        /// <value>Specifies the environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            /// <summary>
            /// Enum KPhysicalFiles for value: kPhysicalFiles
            /// </summary>
            [EnumMember(Value = "kPhysicalFiles")]
            KPhysicalFiles = 1,

            /// <summary>
            /// Enum KPuppeteer for value: kPuppeteer
            /// </summary>
            [EnumMember(Value = "kPuppeteer")]
            KPuppeteer = 2,

            /// <summary>
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 3,

            /// <summary>
            /// Enum KHyperV for value: kHyperV
            /// </summary>
            [EnumMember(Value = "kHyperV")]
            KHyperV = 4,

            /// <summary>
            /// Enum KKVM for value: kKVM
            /// </summary>
            [EnumMember(Value = "kKVM")]
            KKVM = 5,

            /// <summary>
            /// Enum KGCP for value: kGCP
            /// </summary>
            [EnumMember(Value = "kGCP")]
            KGCP = 6,

            /// <summary>
            /// Enum KAWSSnapshotManager for value: kAWSSnapshotManager
            /// </summary>
            [EnumMember(Value = "kAWSSnapshotManager")]
            KAWSSnapshotManager = 7,

            /// <summary>
            /// Enum KAgent for value: kAgent
            /// </summary>
            [EnumMember(Value = "kAgent")]
            KAgent = 8,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 9,

            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 10,

            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 11,

            /// <summary>
            /// Enum KGPFS for value: kGPFS
            /// </summary>
            [EnumMember(Value = "kGPFS")]
            KGPFS = 12,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 13,

            /// <summary>
            /// Enum KVMware for value: kVMware
            /// </summary>
            [EnumMember(Value = "kVMware")]
            KVMware = 14,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 15,

            /// <summary>
            /// Enum KFlashBlade for value: kFlashBlade
            /// </summary>
            [EnumMember(Value = "kFlashBlade")]
            KFlashBlade = 16,

            /// <summary>
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 17,

            /// <summary>
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 18,

            /// <summary>
            /// Enum KVCD for value: kVCD
            /// </summary>
            [EnumMember(Value = "kVCD")]
            KVCD = 19,

            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 20,

            /// <summary>
            /// Enum KIsilon for value: kIsilon
            /// </summary>
            [EnumMember(Value = "kIsilon")]
            KIsilon = 21,

            /// <summary>
            /// Enum KExchange for value: kExchange
            /// </summary>
            [EnumMember(Value = "kExchange")]
            KExchange = 22,

            /// <summary>
            /// Enum KAWSNative for value: kAWSNative
            /// </summary>
            [EnumMember(Value = "kAWSNative")]
            KAWSNative = 23,

            /// <summary>
            /// Enum KPure for value: kPure
            /// </summary>
            [EnumMember(Value = "kPure")]
            KPure = 24,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 25,

            /// <summary>
            /// Enum KHyperVVSS for value: kHyperVVSS
            /// </summary>
            [EnumMember(Value = "kHyperVVSS")]
            KHyperVVSS = 26,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 27,

            /// <summary>
            /// Enum KAWS for value: kAWS
            /// </summary>
            [EnumMember(Value = "kAWS")]
            KAWS = 28,

            /// <summary>
            /// Enum KNimble for value: kNimble
            /// </summary>
            [EnumMember(Value = "kNimble")]
            KNimble = 29,

            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 30,

            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 31,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 32

        }

        /// <summary>
        /// Specifies the environment.
        /// </summary>
        /// <value>Specifies the environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreEnvStats" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment..</param>
        /// <param name="objectCount">objectCount.</param>
        /// <param name="totalBytes">totalBytes.</param>
        public RestoreEnvStats(EnvironmentEnum? environment = default(EnvironmentEnum?), long? objectCount = default(long?), long? totalBytes = default(long?))
        {
            this.Environment = environment;
            this.ObjectCount = objectCount;
            this.TotalBytes = totalBytes;
            this.Environment = environment;
            this.ObjectCount = objectCount;
            this.TotalBytes = totalBytes;
        }
        
        /// <summary>
        /// Gets or Sets ObjectCount
        /// </summary>
        [DataMember(Name="objectCount", EmitDefaultValue=true)]
        public long? ObjectCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalBytes
        /// </summary>
        [DataMember(Name="totalBytes", EmitDefaultValue=true)]
        public long? TotalBytes { get; set; }

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
            return this.Equals(input as RestoreEnvStats);
        }

        /// <summary>
        /// Returns true if RestoreEnvStats instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreEnvStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreEnvStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.ObjectCount == input.ObjectCount ||
                    (this.ObjectCount != null &&
                    this.ObjectCount.Equals(input.ObjectCount))
                ) && 
                (
                    this.TotalBytes == input.TotalBytes ||
                    (this.TotalBytes != null &&
                    this.TotalBytes.Equals(input.TotalBytes))
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
                if (this.ObjectCount != null)
                    hashCode = hashCode * 59 + this.ObjectCount.GetHashCode();
                if (this.TotalBytes != null)
                    hashCode = hashCode * 59 + this.TotalBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

