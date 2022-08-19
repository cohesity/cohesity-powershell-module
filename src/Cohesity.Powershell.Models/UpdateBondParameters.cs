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
    /// Specifies the parameters needed to modify the bonding mode of a bond.
    /// </summary>
    [DataContract]
    public partial class UpdateBondParameters :  IEquatable<UpdateBondParameters>
    {
        /// <summary>
        /// Specifies the new bonding mode. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the new bonding mode. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BondingModeEnum
        {
            /// <summary>
            /// Enum KActiveBackup for value: kActiveBackup
            /// </summary>
            [EnumMember(Value = "kActiveBackup")]
            KActiveBackup = 1,

            /// <summary>
            /// Enum K8023ad for value: k802_3ad
            /// </summary>
            [EnumMember(Value = "k802_3ad")]
            K8023ad = 2

        }

        /// <summary>
        /// Specifies the new bonding mode. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the new bonding mode. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=true)]
        public BondingModeEnum BondingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBondParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateBondParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBondParameters" /> class.
        /// </summary>
        /// <param name="bondingMode">Specifies the new bonding mode. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode. (required).</param>
        /// <param name="lacpRate">Specifies the LACP rate. If not specified, This value will default to 0 (slow)..</param>
        /// <param name="name">Specifies the name of the bond being updated. (required).</param>
        /// <param name="xmitHashPolicy">Specifies the xmit hash policy. If not specified, This value will default to 1 (layer3+4)..</param>
        public UpdateBondParameters(BondingModeEnum bondingMode = default(BondingModeEnum), string lacpRate = default(string), string name = default(string), string xmitHashPolicy = default(string))
        {
            this.BondingMode = bondingMode;
            this.LacpRate = lacpRate;
            this.Name = name;
            this.XmitHashPolicy = xmitHashPolicy;
            this.LacpRate = lacpRate;
            this.XmitHashPolicy = xmitHashPolicy;
        }
        
        /// <summary>
        /// Specifies the LACP rate. If not specified, This value will default to 0 (slow).
        /// </summary>
        /// <value>Specifies the LACP rate. If not specified, This value will default to 0 (slow).</value>
        [DataMember(Name="lacpRate", EmitDefaultValue=true)]
        public string LacpRate { get; set; }

        /// <summary>
        /// Specifies the name of the bond being updated.
        /// </summary>
        /// <value>Specifies the name of the bond being updated.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the xmit hash policy. If not specified, This value will default to 1 (layer3+4).
        /// </summary>
        /// <value>Specifies the xmit hash policy. If not specified, This value will default to 1 (layer3+4).</value>
        [DataMember(Name="xmitHashPolicy", EmitDefaultValue=true)]
        public string XmitHashPolicy { get; set; }

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
            return this.Equals(input as UpdateBondParameters);
        }

        /// <summary>
        /// Returns true if UpdateBondParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateBondParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBondParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BondingMode == input.BondingMode ||
                    this.BondingMode.Equals(input.BondingMode)
                ) && 
                (
                    this.LacpRate == input.LacpRate ||
                    (this.LacpRate != null &&
                    this.LacpRate.Equals(input.LacpRate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.XmitHashPolicy == input.XmitHashPolicy ||
                    (this.XmitHashPolicy != null &&
                    this.XmitHashPolicy.Equals(input.XmitHashPolicy))
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
                hashCode = hashCode * 59 + this.BondingMode.GetHashCode();
                if (this.LacpRate != null)
                    hashCode = hashCode * 59 + this.LacpRate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.XmitHashPolicy != null)
                    hashCode = hashCode * 59 + this.XmitHashPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}

