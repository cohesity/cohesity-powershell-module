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
    /// Specifies the preferred storage tier for IO operations.
    /// </summary>
    [DataContract]
    public partial class IoPreferentialTier :  IEquatable<IoPreferentialTier>
    {
        /// <summary>
        /// Defines ApolloIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApolloIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the preferred storage tier used by Apollo as its working directory.
        /// </summary>
        /// <value>Specifies the preferred storage tier used by Apollo as its working directory.</value>
        [DataMember(Name="apolloIOPreferentialTier", EmitDefaultValue=false)]
        public List<ApolloIOPreferentialTierEnum> ApolloIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines ApolloWalIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApolloWalIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the preferred storage tier used by Apollo as its actions WAL.
        /// </summary>
        /// <value>Specifies the preferred storage tier used by Apollo as its actions WAL.</value>
        [DataMember(Name="apolloWalIOPreferentialTier", EmitDefaultValue=false)]
        public List<ApolloWalIOPreferentialTierEnum> ApolloWalIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines AthenaIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AthenaIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Athena.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Athena.</value>
        [DataMember(Name="athenaIOPreferentialTier", EmitDefaultValue=false)]
        public List<AthenaIOPreferentialTierEnum> AthenaIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines AthenaSlowerIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AthenaSlowerIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Athena for slower storage.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Athena for slower storage.</value>
        [DataMember(Name="athenaSlowerIOPreferentialTier", EmitDefaultValue=false)]
        public List<AthenaSlowerIOPreferentialTierEnum> AthenaSlowerIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines GrootIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GrootIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the preferred storage tier used by Groot as its working directory.
        /// </summary>
        /// <value>Specifies the preferred storage tier used by Groot as its working directory.</value>
        [DataMember(Name="grootIOPreferentialTier", EmitDefaultValue=false)]
        public List<GrootIOPreferentialTierEnum> GrootIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines HydraDowntierIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HydraDowntierIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Hydra for offloading.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Hydra for offloading.</value>
        [DataMember(Name="hydraDowntierIOPreferentialTier", EmitDefaultValue=false)]
        public List<HydraDowntierIOPreferentialTierEnum> HydraDowntierIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines HydraIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HydraIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Hydra.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Hydra.</value>
        [DataMember(Name="hydraIOPreferentialTier", EmitDefaultValue=false)]
        public List<HydraIOPreferentialTierEnum> HydraIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines LibrarianIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LibrarianIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by librarian.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by librarian.</value>
        [DataMember(Name="librarianIOPreferentialTier", EmitDefaultValue=false)]
        public List<LibrarianIOPreferentialTierEnum> LibrarianIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines RandomIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RandomIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the order of perferred storage tiers for random IO operations.
        /// </summary>
        /// <value>Specifies the order of perferred storage tiers for random IO operations.</value>
        [DataMember(Name="randomIOPreferentialTier", EmitDefaultValue=false)]
        public List<RandomIOPreferentialTierEnum> RandomIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines ScribeIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScribeIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Scribe.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Scribe.</value>
        [DataMember(Name="scribeIOPreferentialTier", EmitDefaultValue=false)]
        public List<ScribeIOPreferentialTierEnum> ScribeIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines SequentialIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SequentialIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the preferred storage tier for sequential IO operations.
        /// </summary>
        /// <value>Specifies the preferred storage tier for sequential IO operations.</value>
        [DataMember(Name="sequentialIOPreferentialTier", EmitDefaultValue=false)]
        public List<SequentialIOPreferentialTierEnum> SequentialIOPreferentialTier { get; set; }
        /// <summary>
        /// Defines YodaIOPreferentialTier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum YodaIOPreferentialTierEnum
        {
            /// <summary>
            /// Enum KPcieSsd for value: kPcieSsd
            /// </summary>
            [EnumMember(Value = "kPcieSsd")]
            KPcieSsd = 1,

            /// <summary>
            /// Enum KSataSsd for value: kSataSsd
            /// </summary>
            [EnumMember(Value = "kSataSsd")]
            KSataSsd = 2,

            /// <summary>
            /// Enum KSataHdd for value: kSataHdd
            /// </summary>
            [EnumMember(Value = "kSataHdd")]
            KSataHdd = 3,

            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 4

        }


        /// <summary>
        /// Specifies the list of perferred storage tiers used by Yoda.
        /// </summary>
        /// <value>Specifies the list of perferred storage tiers used by Yoda.</value>
        [DataMember(Name="yodaIOPreferentialTier", EmitDefaultValue=false)]
        public List<YodaIOPreferentialTierEnum> YodaIOPreferentialTier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoPreferentialTier" /> class.
        /// </summary>
        /// <param name="apolloIOPreferentialTier">Specifies the preferred storage tier used by Apollo as its working directory..</param>
        /// <param name="apolloWalIOPreferentialTier">Specifies the preferred storage tier used by Apollo as its actions WAL..</param>
        /// <param name="athenaIOPreferentialTier">Specifies the list of perferred storage tiers used by Athena..</param>
        /// <param name="athenaSlowerIOPreferentialTier">Specifies the list of perferred storage tiers used by Athena for slower storage..</param>
        /// <param name="downTierUsagePercentThresholds">Specifies the usage percentage thresholds for the correponding storage tier..</param>
        /// <param name="grootIOPreferentialTier">Specifies the preferred storage tier used by Groot as its working directory..</param>
        /// <param name="hydraDowntierIOPreferentialTier">Specifies the list of perferred storage tiers used by Hydra for offloading..</param>
        /// <param name="hydraIOPreferentialTier">Specifies the list of perferred storage tiers used by Hydra..</param>
        /// <param name="librarianIOPreferentialTier">Specifies the list of perferred storage tiers used by librarian..</param>
        /// <param name="randomIOPreferentialTier">Specifies the order of perferred storage tiers for random IO operations..</param>
        /// <param name="scribeIOPreferentialTier">Specifies the list of perferred storage tiers used by Scribe..</param>
        /// <param name="sequentialIOPreferentialTier">Specifies the preferred storage tier for sequential IO operations..</param>
        /// <param name="yodaIOPreferentialTier">Specifies the list of perferred storage tiers used by Yoda..</param>
        public IoPreferentialTier(List<ApolloIOPreferentialTierEnum> apolloIOPreferentialTier = default(List<ApolloIOPreferentialTierEnum>), List<ApolloWalIOPreferentialTierEnum> apolloWalIOPreferentialTier = default(List<ApolloWalIOPreferentialTierEnum>), List<AthenaIOPreferentialTierEnum> athenaIOPreferentialTier = default(List<AthenaIOPreferentialTierEnum>), List<AthenaSlowerIOPreferentialTierEnum> athenaSlowerIOPreferentialTier = default(List<AthenaSlowerIOPreferentialTierEnum>), List<int> downTierUsagePercentThresholds = default(List<int>), List<GrootIOPreferentialTierEnum> grootIOPreferentialTier = default(List<GrootIOPreferentialTierEnum>), List<HydraDowntierIOPreferentialTierEnum> hydraDowntierIOPreferentialTier = default(List<HydraDowntierIOPreferentialTierEnum>), List<HydraIOPreferentialTierEnum> hydraIOPreferentialTier = default(List<HydraIOPreferentialTierEnum>), List<LibrarianIOPreferentialTierEnum> librarianIOPreferentialTier = default(List<LibrarianIOPreferentialTierEnum>), List<RandomIOPreferentialTierEnum> randomIOPreferentialTier = default(List<RandomIOPreferentialTierEnum>), List<ScribeIOPreferentialTierEnum> scribeIOPreferentialTier = default(List<ScribeIOPreferentialTierEnum>), List<SequentialIOPreferentialTierEnum> sequentialIOPreferentialTier = default(List<SequentialIOPreferentialTierEnum>), List<YodaIOPreferentialTierEnum> yodaIOPreferentialTier = default(List<YodaIOPreferentialTierEnum>))
        {
            this.ApolloIOPreferentialTier = apolloIOPreferentialTier;
            this.ApolloWalIOPreferentialTier = apolloWalIOPreferentialTier;
            this.AthenaIOPreferentialTier = athenaIOPreferentialTier;
            this.AthenaSlowerIOPreferentialTier = athenaSlowerIOPreferentialTier;
            this.DownTierUsagePercentThresholds = downTierUsagePercentThresholds;
            this.GrootIOPreferentialTier = grootIOPreferentialTier;
            this.HydraDowntierIOPreferentialTier = hydraDowntierIOPreferentialTier;
            this.HydraIOPreferentialTier = hydraIOPreferentialTier;
            this.LibrarianIOPreferentialTier = librarianIOPreferentialTier;
            this.RandomIOPreferentialTier = randomIOPreferentialTier;
            this.ScribeIOPreferentialTier = scribeIOPreferentialTier;
            this.SequentialIOPreferentialTier = sequentialIOPreferentialTier;
            this.YodaIOPreferentialTier = yodaIOPreferentialTier;
        }
        
        /// <summary>
        /// Specifies the usage percentage thresholds for the correponding storage tier.
        /// </summary>
        /// <value>Specifies the usage percentage thresholds for the correponding storage tier.</value>
        [DataMember(Name="downTierUsagePercentThresholds", EmitDefaultValue=false)]
        public List<int> DownTierUsagePercentThresholds { get; set; }

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
            return this.Equals(input as IoPreferentialTier);
        }

        /// <summary>
        /// Returns true if IoPreferentialTier instances are equal
        /// </summary>
        /// <param name="input">Instance of IoPreferentialTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IoPreferentialTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApolloIOPreferentialTier == input.ApolloIOPreferentialTier ||
                    this.ApolloIOPreferentialTier.SequenceEqual(input.ApolloIOPreferentialTier)
                ) && 
                (
                    this.ApolloWalIOPreferentialTier == input.ApolloWalIOPreferentialTier ||
                    this.ApolloWalIOPreferentialTier.SequenceEqual(input.ApolloWalIOPreferentialTier)
                ) && 
                (
                    this.AthenaIOPreferentialTier == input.AthenaIOPreferentialTier ||
                    this.AthenaIOPreferentialTier.SequenceEqual(input.AthenaIOPreferentialTier)
                ) && 
                (
                    this.AthenaSlowerIOPreferentialTier == input.AthenaSlowerIOPreferentialTier ||
                    this.AthenaSlowerIOPreferentialTier.SequenceEqual(input.AthenaSlowerIOPreferentialTier)
                ) && 
                (
                    this.DownTierUsagePercentThresholds == input.DownTierUsagePercentThresholds ||
                    this.DownTierUsagePercentThresholds != null &&
                    input.DownTierUsagePercentThresholds != null &&
                    this.DownTierUsagePercentThresholds.SequenceEqual(input.DownTierUsagePercentThresholds)
                ) && 
                (
                    this.GrootIOPreferentialTier == input.GrootIOPreferentialTier ||
                    this.GrootIOPreferentialTier.SequenceEqual(input.GrootIOPreferentialTier)
                ) && 
                (
                    this.HydraDowntierIOPreferentialTier == input.HydraDowntierIOPreferentialTier ||
                    this.HydraDowntierIOPreferentialTier.SequenceEqual(input.HydraDowntierIOPreferentialTier)
                ) && 
                (
                    this.HydraIOPreferentialTier == input.HydraIOPreferentialTier ||
                    this.HydraIOPreferentialTier.SequenceEqual(input.HydraIOPreferentialTier)
                ) && 
                (
                    this.LibrarianIOPreferentialTier == input.LibrarianIOPreferentialTier ||
                    this.LibrarianIOPreferentialTier.SequenceEqual(input.LibrarianIOPreferentialTier)
                ) && 
                (
                    this.RandomIOPreferentialTier == input.RandomIOPreferentialTier ||
                    this.RandomIOPreferentialTier.SequenceEqual(input.RandomIOPreferentialTier)
                ) && 
                (
                    this.ScribeIOPreferentialTier == input.ScribeIOPreferentialTier ||
                    this.ScribeIOPreferentialTier.SequenceEqual(input.ScribeIOPreferentialTier)
                ) && 
                (
                    this.SequentialIOPreferentialTier == input.SequentialIOPreferentialTier ||
                    this.SequentialIOPreferentialTier.SequenceEqual(input.SequentialIOPreferentialTier)
                ) && 
                (
                    this.YodaIOPreferentialTier == input.YodaIOPreferentialTier ||
                    this.YodaIOPreferentialTier.SequenceEqual(input.YodaIOPreferentialTier)
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
                hashCode = hashCode * 59 + this.ApolloIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.ApolloWalIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.AthenaIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.AthenaSlowerIOPreferentialTier.GetHashCode();
                if (this.DownTierUsagePercentThresholds != null)
                    hashCode = hashCode * 59 + this.DownTierUsagePercentThresholds.GetHashCode();
                hashCode = hashCode * 59 + this.GrootIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.HydraDowntierIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.HydraIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.LibrarianIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.RandomIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.ScribeIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.SequentialIOPreferentialTier.GetHashCode();
                hashCode = hashCode * 59 + this.YodaIOPreferentialTier.GetHashCode();
                return hashCode;
            }
        }

    }

}

