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
    /// CountByTier provides the disk count of each storage tier.
    /// </summary>
    [DataContract]
    public partial class CountByTier :  IEquatable<CountByTier>
    {
        /// <summary>
        /// StorageTier is the type of StorageTier. StorageTierType represents the various values for the Storage Tier. &#39;kPCIeSSD&#39; indicates storage tier type of Pci Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Hard Disk Drive. &#39;kCLOUD&#39; indicates storage tier type of Cloud.
        /// </summary>
        /// <value>StorageTier is the type of StorageTier. StorageTierType represents the various values for the Storage Tier. &#39;kPCIeSSD&#39; indicates storage tier type of Pci Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Hard Disk Drive. &#39;kCLOUD&#39; indicates storage tier type of Cloud.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StorageTierEnum
        {
            /// <summary>
            /// Enum KPCIeSSD for value: kPCIeSSD
            /// </summary>
            [EnumMember(Value = "kPCIeSSD")]
            KPCIeSSD = 1,

            /// <summary>
            /// Enum KSATASSD for value: kSATASSD
            /// </summary>
            [EnumMember(Value = "kSATASSD")]
            KSATASSD = 2,

            /// <summary>
            /// Enum KSATAHDD for value: kSATAHDD
            /// </summary>
            [EnumMember(Value = "kSATAHDD")]
            KSATAHDD = 3,

            /// <summary>
            /// Enum KCLOUD for value: kCLOUD
            /// </summary>
            [EnumMember(Value = "kCLOUD")]
            KCLOUD = 4

        }

        /// <summary>
        /// StorageTier is the type of StorageTier. StorageTierType represents the various values for the Storage Tier. &#39;kPCIeSSD&#39; indicates storage tier type of Pci Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Hard Disk Drive. &#39;kCLOUD&#39; indicates storage tier type of Cloud.
        /// </summary>
        /// <value>StorageTier is the type of StorageTier. StorageTierType represents the various values for the Storage Tier. &#39;kPCIeSSD&#39; indicates storage tier type of Pci Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Hard Disk Drive. &#39;kCLOUD&#39; indicates storage tier type of Cloud.</value>
        [DataMember(Name="storageTier", EmitDefaultValue=true)]
        public StorageTierEnum? StorageTier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CountByTier" /> class.
        /// </summary>
        /// <param name="diskCount">DiskCount is the disk number of the storage tier..</param>
        /// <param name="storageTier">StorageTier is the type of StorageTier. StorageTierType represents the various values for the Storage Tier. &#39;kPCIeSSD&#39; indicates storage tier type of Pci Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Solid State Drive. &#39;kSATAHDD&#39; indicates storage tier type of SATA Hard Disk Drive. &#39;kCLOUD&#39; indicates storage tier type of Cloud..</param>
        public CountByTier(long? diskCount = default(long?), StorageTierEnum? storageTier = default(StorageTierEnum?))
        {
            this.DiskCount = diskCount;
            this.StorageTier = storageTier;
            this.DiskCount = diskCount;
            this.StorageTier = storageTier;
        }
        
        /// <summary>
        /// DiskCount is the disk number of the storage tier.
        /// </summary>
        /// <value>DiskCount is the disk number of the storage tier.</value>
        [DataMember(Name="diskCount", EmitDefaultValue=true)]
        public long? DiskCount { get; set; }

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
            return this.Equals(input as CountByTier);
        }

        /// <summary>
        /// Returns true if CountByTier instances are equal
        /// </summary>
        /// <param name="input">Instance of CountByTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountByTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskCount == input.DiskCount ||
                    (this.DiskCount != null &&
                    this.DiskCount.Equals(input.DiskCount))
                ) && 
                (
                    this.StorageTier == input.StorageTier ||
                    this.StorageTier.Equals(input.StorageTier)
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
                if (this.DiskCount != null)
                    hashCode = hashCode * 59 + this.DiskCount.GetHashCode();
                hashCode = hashCode * 59 + this.StorageTier.GetHashCode();
                return hashCode;
            }
        }

    }

}

