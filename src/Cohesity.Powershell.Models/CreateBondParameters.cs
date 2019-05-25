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
    /// Specifies the parameters needed to create a bond.
    /// </summary>
    [DataContract]
    public partial class CreateBondParameters :  IEquatable<CreateBondParameters>
    {
        /// <summary>
        /// Specifies the bonding mode to use for this bond. If not specified, this value will default to &#39;kActiveBackup&#39;. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use for this bond. If not specified, this value will default to &#39;kActiveBackup&#39;. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
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
        /// Specifies the bonding mode to use for this bond. If not specified, this value will default to &#39;kActiveBackup&#39;. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use for this bond. If not specified, this value will default to &#39;kActiveBackup&#39;. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=true)]
        public BondingModeEnum? BondingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBondParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBondParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBondParameters" /> class.
        /// </summary>
        /// <param name="bondingMode">Specifies the bonding mode to use for this bond. If not specified, this value will default to &#39;kActiveBackup&#39;. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode..</param>
        /// <param name="name">Specifies a unique name to identify the bond being created. (required).</param>
        /// <param name="slaves">Specifies the names of the slaves of this bond. (required).</param>
        public CreateBondParameters(BondingModeEnum? bondingMode = default(BondingModeEnum?), string name = default(string), List<string> slaves = default(List<string>))
        {
            this.BondingMode = bondingMode;
            this.Name = name;
            this.Slaves = slaves;
            this.BondingMode = bondingMode;
        }
        
        /// <summary>
        /// Specifies a unique name to identify the bond being created.
        /// </summary>
        /// <value>Specifies a unique name to identify the bond being created.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the names of the slaves of this bond.
        /// </summary>
        /// <value>Specifies the names of the slaves of this bond.</value>
        [DataMember(Name="slaves", EmitDefaultValue=true)]
        public List<string> Slaves { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBondParameters {\n");
            sb.Append("  BondingMode: ").Append(BondingMode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slaves: ").Append(Slaves).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as CreateBondParameters);
        }

        /// <summary>
        /// Returns true if CreateBondParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBondParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBondParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BondingMode == input.BondingMode ||
                    this.BondingMode.Equals(input.BondingMode)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Slaves == input.Slaves ||
                    this.Slaves != null &&
                    input.Slaves != null &&
                    this.Slaves.SequenceEqual(input.Slaves)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Slaves != null)
                    hashCode = hashCode * 59 + this.Slaves.GetHashCode();
                return hashCode;
            }
        }

    }

}
