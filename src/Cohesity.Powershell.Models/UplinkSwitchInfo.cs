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
    /// UplinkSwitchInfo
    /// </summary>
    [DataContract]
    public partial class UplinkSwitchInfo :  IEquatable<UplinkSwitchInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UplinkSwitchInfo" /> class.
        /// </summary>
        /// <param name="portId">Port ID..</param>
        /// <param name="sysDescr">System description..</param>
        /// <param name="sysName">System name..</param>
        public UplinkSwitchInfo(string portId = default(string), string sysDescr = default(string), string sysName = default(string))
        {
            this.PortId = portId;
            this.SysDescr = sysDescr;
            this.SysName = sysName;
            this.PortId = portId;
            this.SysDescr = sysDescr;
            this.SysName = sysName;
        }
        
        /// <summary>
        /// Port ID.
        /// </summary>
        /// <value>Port ID.</value>
        [DataMember(Name="portId", EmitDefaultValue=true)]
        public string PortId { get; set; }

        /// <summary>
        /// System description.
        /// </summary>
        /// <value>System description.</value>
        [DataMember(Name="sysDescr", EmitDefaultValue=true)]
        public string SysDescr { get; set; }

        /// <summary>
        /// System name.
        /// </summary>
        /// <value>System name.</value>
        [DataMember(Name="sysName", EmitDefaultValue=true)]
        public string SysName { get; set; }

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
            return this.Equals(input as UplinkSwitchInfo);
        }

        /// <summary>
        /// Returns true if UplinkSwitchInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UplinkSwitchInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UplinkSwitchInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.SysDescr == input.SysDescr ||
                    (this.SysDescr != null &&
                    this.SysDescr.Equals(input.SysDescr))
                ) && 
                (
                    this.SysName == input.SysName ||
                    (this.SysName != null &&
                    this.SysName.Equals(input.SysName))
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
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.SysDescr != null)
                    hashCode = hashCode * 59 + this.SysDescr.GetHashCode();
                if (this.SysName != null)
                    hashCode = hashCode * 59 + this.SysName.GetHashCode();
                return hashCode;
            }
        }

    }

}

