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
    /// CdpIoFilterState specifies the current state of the CDP IO Filter for a single Protection Source.
    /// </summary>
    [DataContract]
    public partial class CdpIoFilterState :  IEquatable<CdpIoFilterState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdpIoFilterState" /> class.
        /// </summary>
        /// <param name="errorMessage">Specifies the message of the error, which was encountered duing the last upgrade. If this is specified, then it means that the last upgrade failed..</param>
        /// <param name="filterStatus">Specifies the current status of the IO Filter. See magneto/base/entities.proto &gt; IOFilterState &gt; FilterStatus.</param>
        /// <param name="upgradability">Specifies the current upgradability status of the IO Filter. See magneto/base/common.proto &gt; Upgradability.</param>
        /// <param name="version">Specifies the current version of the IO filter..</param>
        public CdpIoFilterState(string errorMessage = default(string), string filterStatus = default(string), string upgradability = default(string), string version = default(string))
        {
            this.ErrorMessage = errorMessage;
            this.FilterStatus = filterStatus;
            this.Upgradability = upgradability;
            this.Version = version;
            this.ErrorMessage = errorMessage;
            this.FilterStatus = filterStatus;
            this.Upgradability = upgradability;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies the message of the error, which was encountered duing the last upgrade. If this is specified, then it means that the last upgrade failed.
        /// </summary>
        /// <value>Specifies the message of the error, which was encountered duing the last upgrade. If this is specified, then it means that the last upgrade failed.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the current status of the IO Filter. See magneto/base/entities.proto &gt; IOFilterState &gt; FilterStatus
        /// </summary>
        /// <value>Specifies the current status of the IO Filter. See magneto/base/entities.proto &gt; IOFilterState &gt; FilterStatus</value>
        [DataMember(Name="filterStatus", EmitDefaultValue=true)]
        public string FilterStatus { get; set; }

        /// <summary>
        /// Specifies the current upgradability status of the IO Filter. See magneto/base/common.proto &gt; Upgradability
        /// </summary>
        /// <value>Specifies the current upgradability status of the IO Filter. See magneto/base/common.proto &gt; Upgradability</value>
        [DataMember(Name="upgradability", EmitDefaultValue=true)]
        public string Upgradability { get; set; }

        /// <summary>
        /// Specifies the current version of the IO filter.
        /// </summary>
        /// <value>Specifies the current version of the IO filter.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as CdpIoFilterState);
        }

        /// <summary>
        /// Returns true if CdpIoFilterState instances are equal
        /// </summary>
        /// <param name="input">Instance of CdpIoFilterState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdpIoFilterState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.FilterStatus == input.FilterStatus ||
                    (this.FilterStatus != null &&
                    this.FilterStatus.Equals(input.FilterStatus))
                ) && 
                (
                    this.Upgradability == input.Upgradability ||
                    (this.Upgradability != null &&
                    this.Upgradability.Equals(input.Upgradability))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.FilterStatus != null)
                    hashCode = hashCode * 59 + this.FilterStatus.GetHashCode();
                if (this.Upgradability != null)
                    hashCode = hashCode * 59 + this.Upgradability.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

