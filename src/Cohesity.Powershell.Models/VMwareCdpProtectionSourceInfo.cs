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
    /// Specifies the details about the Continuous Data Protection (CDP) info of a VMware Protection Source.
    /// </summary>
    [DataContract]
    public partial class VMwareCdpProtectionSourceInfo :  IEquatable<VMwareCdpProtectionSourceInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareCdpProtectionSourceInfo" /> class.
        /// </summary>
        /// <param name="ioFilterState">ioFilterState.</param>
        public VMwareCdpProtectionSourceInfo(CdpIoFilterState ioFilterState = default(CdpIoFilterState))
        {
            this.IoFilterState = ioFilterState;
        }
        
        /// <summary>
        /// Gets or Sets IoFilterState
        /// </summary>
        [DataMember(Name="ioFilterState", EmitDefaultValue=false)]
        public CdpIoFilterState IoFilterState { get; set; }

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
            return this.Equals(input as VMwareCdpProtectionSourceInfo);
        }

        /// <summary>
        /// Returns true if VMwareCdpProtectionSourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareCdpProtectionSourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareCdpProtectionSourceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IoFilterState == input.IoFilterState ||
                    (this.IoFilterState != null &&
                    this.IoFilterState.Equals(input.IoFilterState))
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
                if (this.IoFilterState != null)
                    hashCode = hashCode * 59 + this.IoFilterState.GetHashCode();
                return hashCode;
            }
        }

    }

}

