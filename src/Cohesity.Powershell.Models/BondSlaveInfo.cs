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
    /// BondSlaveInfo
    /// </summary>
    [DataContract]
    public partial class BondSlaveInfo :  IEquatable<BondSlaveInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BondSlaveInfo" /> class.
        /// </summary>
        /// <param name="linkState">Bond seocondary link state..</param>
        /// <param name="macAddr">Mac address of the bond secondary interface..</param>
        /// <param name="name">Bond secondary name..</param>
        /// <param name="slot">Bond seocondarys slot info..</param>
        /// <param name="speed">Bond seocondary Speed..</param>
        /// <param name="stats">stats.</param>
        /// <param name="uplinkSwitchInfo">uplinkSwitchInfo.</param>
        public BondSlaveInfo(string linkState = default(string), string macAddr = default(string), string name = default(string), string slot = default(string), string speed = default(string), InterfaceStats stats = default(InterfaceStats), UplinkSwitchInfo uplinkSwitchInfo = default(UplinkSwitchInfo))
        {
            this.LinkState = linkState;
            this.MacAddr = macAddr;
            this.Name = name;
            this.Slot = slot;
            this.Speed = speed;
            this.LinkState = linkState;
            this.MacAddr = macAddr;
            this.Name = name;
            this.Slot = slot;
            this.Speed = speed;
            this.Stats = stats;
            this.UplinkSwitchInfo = uplinkSwitchInfo;
        }
        
        /// <summary>
        /// Bond seocondary link state.
        /// </summary>
        /// <value>Bond seocondary link state.</value>
        [DataMember(Name="linkState", EmitDefaultValue=true)]
        public string LinkState { get; set; }

        /// <summary>
        /// Mac address of the bond secondary interface.
        /// </summary>
        /// <value>Mac address of the bond secondary interface.</value>
        [DataMember(Name="macAddr", EmitDefaultValue=true)]
        public string MacAddr { get; set; }

        /// <summary>
        /// Bond secondary name.
        /// </summary>
        /// <value>Bond secondary name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Bond seocondarys slot info.
        /// </summary>
        /// <value>Bond seocondarys slot info.</value>
        [DataMember(Name="slot", EmitDefaultValue=true)]
        public string Slot { get; set; }

        /// <summary>
        /// Bond seocondary Speed.
        /// </summary>
        /// <value>Bond seocondary Speed.</value>
        [DataMember(Name="speed", EmitDefaultValue=true)]
        public string Speed { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public InterfaceStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets UplinkSwitchInfo
        /// </summary>
        [DataMember(Name="uplinkSwitchInfo", EmitDefaultValue=false)]
        public UplinkSwitchInfo UplinkSwitchInfo { get; set; }

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
            return this.Equals(input as BondSlaveInfo);
        }

        /// <summary>
        /// Returns true if BondSlaveInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BondSlaveInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondSlaveInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinkState == input.LinkState ||
                    (this.LinkState != null &&
                    this.LinkState.Equals(input.LinkState))
                ) && 
                (
                    this.MacAddr == input.MacAddr ||
                    (this.MacAddr != null &&
                    this.MacAddr.Equals(input.MacAddr))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.UplinkSwitchInfo == input.UplinkSwitchInfo ||
                    (this.UplinkSwitchInfo != null &&
                    this.UplinkSwitchInfo.Equals(input.UplinkSwitchInfo))
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
                if (this.LinkState != null)
                    hashCode = hashCode * 59 + this.LinkState.GetHashCode();
                if (this.MacAddr != null)
                    hashCode = hashCode * 59 + this.MacAddr.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Slot != null)
                    hashCode = hashCode * 59 + this.Slot.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.UplinkSwitchInfo != null)
                    hashCode = hashCode * 59 + this.UplinkSwitchInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

