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
    /// M365CSMRestoreAdditionalParams
    /// </summary>
    [DataContract]
    public partial class M365CSMRestoreAdditionalParams :  IEquatable<M365CSMRestoreAdditionalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M365CSMRestoreAdditionalParams" /> class.
        /// </summary>
        /// <param name="recoveryPoint">Restore point from which recovery needs to be done..</param>
        public M365CSMRestoreAdditionalParams(string recoveryPoint = default(string))
        {
            this.RecoveryPoint = recoveryPoint;
            this.RecoveryPoint = recoveryPoint;
        }
        
        /// <summary>
        /// Restore point from which recovery needs to be done.
        /// </summary>
        /// <value>Restore point from which recovery needs to be done.</value>
        [DataMember(Name="recoveryPoint", EmitDefaultValue=true)]
        public string RecoveryPoint { get; set; }

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
            return this.Equals(input as M365CSMRestoreAdditionalParams);
        }

        /// <summary>
        /// Returns true if M365CSMRestoreAdditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of M365CSMRestoreAdditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(M365CSMRestoreAdditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecoveryPoint == input.RecoveryPoint ||
                    (this.RecoveryPoint != null &&
                    this.RecoveryPoint.Equals(input.RecoveryPoint))
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
                if (this.RecoveryPoint != null)
                    hashCode = hashCode * 59 + this.RecoveryPoint.GetHashCode();
                return hashCode;
            }
        }

    }

}

