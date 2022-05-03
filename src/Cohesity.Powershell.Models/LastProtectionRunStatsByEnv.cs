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
    /// Specifies the last Protection Run stats by env.
    /// </summary>
    [DataContract]
    public partial class LastProtectionRunStatsByEnv :  IEquatable<LastProtectionRunStatsByEnv>
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
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LastProtectionRunStatsByEnv" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment..</param>
        /// <param name="numObjectsCancelled">Specifies the number of objects that were cancelled in the last Run across all Protection Jobs..</param>
        /// <param name="numObjectsFailed">Specifies the count of objects that failed last Protection Run..</param>
        /// <param name="numObjectsFailedSla">Specifies the count of objects that failed sla in the last Run..</param>
        /// <param name="numObjectsInProgress">Specifies the number of objects that are still in progress in the last Run across all Protection Jobs..</param>
        /// <param name="numObjectsMetSla">Specifies the count of objects that met sla in the last Run..</param>
        /// <param name="numObjectsSuccessful">Specifies the number of objects that were successful in the last Run across all Protection Jobs..</param>
        public LastProtectionRunStatsByEnv(EnvironmentEnum? environment = default(EnvironmentEnum?), long? numObjectsCancelled = default(long?), long? numObjectsFailed = default(long?), long? numObjectsFailedSla = default(long?), long? numObjectsInProgress = default(long?), long? numObjectsMetSla = default(long?), long? numObjectsSuccessful = default(long?))
        {
            this.Environment = environment;
            this.NumObjectsCancelled = numObjectsCancelled;
            this.NumObjectsFailed = numObjectsFailed;
            this.NumObjectsFailedSla = numObjectsFailedSla;
            this.NumObjectsInProgress = numObjectsInProgress;
            this.NumObjectsMetSla = numObjectsMetSla;
            this.NumObjectsSuccessful = numObjectsSuccessful;
        }
        

        /// <summary>
        /// Specifies the number of objects that were cancelled in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that were cancelled in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsCancelled", EmitDefaultValue=false)]
        public long? NumObjectsCancelled { get; set; }

        /// <summary>
        /// Specifies the count of objects that failed last Protection Run.
        /// </summary>
        /// <value>Specifies the count of objects that failed last Protection Run.</value>
        [DataMember(Name="numObjectsFailed", EmitDefaultValue=false)]
        public long? NumObjectsFailed { get; set; }

        /// <summary>
        /// Specifies the count of objects that failed sla in the last Run.
        /// </summary>
        /// <value>Specifies the count of objects that failed sla in the last Run.</value>
        [DataMember(Name="numObjectsFailedSla", EmitDefaultValue=false)]
        public long? NumObjectsFailedSla { get; set; }

        /// <summary>
        /// Specifies the number of objects that are still in progress in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that are still in progress in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsInProgress", EmitDefaultValue=false)]
        public long? NumObjectsInProgress { get; set; }

        /// <summary>
        /// Specifies the count of objects that met sla in the last Run.
        /// </summary>
        /// <value>Specifies the count of objects that met sla in the last Run.</value>
        [DataMember(Name="numObjectsMetSla", EmitDefaultValue=false)]
        public long? NumObjectsMetSla { get; set; }

        /// <summary>
        /// Specifies the number of objects that were successful in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that were successful in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsSuccessful", EmitDefaultValue=false)]
        public long? NumObjectsSuccessful { get; set; }

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
            return this.Equals(input as LastProtectionRunStatsByEnv);
        }

        /// <summary>
        /// Returns true if LastProtectionRunStatsByEnv instances are equal
        /// </summary>
        /// <param name="input">Instance of LastProtectionRunStatsByEnv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastProtectionRunStatsByEnv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.NumObjectsCancelled == input.NumObjectsCancelled ||
                    (this.NumObjectsCancelled != null &&
                    this.NumObjectsCancelled.Equals(input.NumObjectsCancelled))
                ) && 
                (
                    this.NumObjectsFailed == input.NumObjectsFailed ||
                    (this.NumObjectsFailed != null &&
                    this.NumObjectsFailed.Equals(input.NumObjectsFailed))
                ) && 
                (
                    this.NumObjectsFailedSla == input.NumObjectsFailedSla ||
                    (this.NumObjectsFailedSla != null &&
                    this.NumObjectsFailedSla.Equals(input.NumObjectsFailedSla))
                ) && 
                (
                    this.NumObjectsInProgress == input.NumObjectsInProgress ||
                    (this.NumObjectsInProgress != null &&
                    this.NumObjectsInProgress.Equals(input.NumObjectsInProgress))
                ) && 
                (
                    this.NumObjectsMetSla == input.NumObjectsMetSla ||
                    (this.NumObjectsMetSla != null &&
                    this.NumObjectsMetSla.Equals(input.NumObjectsMetSla))
                ) && 
                (
                    this.NumObjectsSuccessful == input.NumObjectsSuccessful ||
                    (this.NumObjectsSuccessful != null &&
                    this.NumObjectsSuccessful.Equals(input.NumObjectsSuccessful))
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
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.NumObjectsCancelled != null)
                    hashCode = hashCode * 59 + this.NumObjectsCancelled.GetHashCode();
                if (this.NumObjectsFailed != null)
                    hashCode = hashCode * 59 + this.NumObjectsFailed.GetHashCode();
                if (this.NumObjectsFailedSla != null)
                    hashCode = hashCode * 59 + this.NumObjectsFailedSla.GetHashCode();
                if (this.NumObjectsInProgress != null)
                    hashCode = hashCode * 59 + this.NumObjectsInProgress.GetHashCode();
                if (this.NumObjectsMetSla != null)
                    hashCode = hashCode * 59 + this.NumObjectsMetSla.GetHashCode();
                if (this.NumObjectsSuccessful != null)
                    hashCode = hashCode * 59 + this.NumObjectsSuccessful.GetHashCode();
                return hashCode;
            }
        }

    }

}

