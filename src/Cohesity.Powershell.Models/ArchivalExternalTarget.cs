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
    /// Specifies settings about the Archival External Target (such as Tape or AWS).
    /// </summary>
    [DataContract]
    public partial class ArchivalExternalTarget :  IEquatable<ArchivalExternalTarget>
    {
        /// <summary>
        /// Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).
        /// </summary>
        /// <value>Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultTypeEnum
        {
            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 1,

            /// <summary>
            /// Enum KTape for value: kTape
            /// </summary>
            [EnumMember(Value = "kTape")]
            KTape = 2,

            /// <summary>
            /// Enum KNas for value: kNas
            /// </summary>
            [EnumMember(Value = "kNas")]
            KNas = 3

        }

        /// <summary>
        /// Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).
        /// </summary>
        /// <value>Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).</value>
        [DataMember(Name="vaultType", EmitDefaultValue=true)]
        public VaultTypeEnum? VaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalExternalTarget" /> class.
        /// </summary>
        /// <param name="vaultId">Specifies the id of Archival Vault assigned by the Cohesity Cluster..</param>
        /// <param name="vaultName">Name of the Archival Vault..</param>
        /// <param name="vaultType">Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas)..</param>
        public ArchivalExternalTarget(long? vaultId = default(long?), string vaultName = default(string), VaultTypeEnum? vaultType = default(VaultTypeEnum?))
        {
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.VaultType = vaultType;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.VaultType = vaultType;
        }
        
        /// <summary>
        /// Specifies the id of Archival Vault assigned by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the id of Archival Vault assigned by the Cohesity Cluster.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Name of the Archival Vault.
        /// </summary>
        /// <value>Name of the Archival Vault.</value>
        [DataMember(Name="vaultName", EmitDefaultValue=true)]
        public string VaultName { get; set; }

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
            return this.Equals(input as ArchivalExternalTarget);
        }

        /// <summary>
        /// Returns true if ArchivalExternalTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchivalExternalTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchivalExternalTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
                ) && 
                (
                    this.VaultType == input.VaultType ||
                    this.VaultType.Equals(input.VaultType)
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
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                hashCode = hashCode * 59 + this.VaultType.GetHashCode();
                return hashCode;
            }
        }

    }

}

