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
    /// Message to capture any additional backup params for SAN environment.
    /// </summary>
    [DataContract]
    public partial class SanBackupJobParams :  IEquatable<SanBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanBackupJobParams" /> class.
        /// </summary>
        /// <param name="useSecuredSnapshot">Whether backup should continue use secured snapshot. For example IBM FlashSystem SAN env uses this param to create safeguarded snapshot..</param>
        public SanBackupJobParams(bool? useSecuredSnapshot = default(bool?))
        {
            this.UseSecuredSnapshot = useSecuredSnapshot;
            this.UseSecuredSnapshot = useSecuredSnapshot;
        }
        
        /// <summary>
        /// Whether backup should continue use secured snapshot. For example IBM FlashSystem SAN env uses this param to create safeguarded snapshot.
        /// </summary>
        /// <value>Whether backup should continue use secured snapshot. For example IBM FlashSystem SAN env uses this param to create safeguarded snapshot.</value>
        [DataMember(Name="useSecuredSnapshot", EmitDefaultValue=true)]
        public bool? UseSecuredSnapshot { get; set; }

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
            return this.Equals(input as SanBackupJobParams);
        }

        /// <summary>
        /// Returns true if SanBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SanBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseSecuredSnapshot == input.UseSecuredSnapshot ||
                    (this.UseSecuredSnapshot != null &&
                    this.UseSecuredSnapshot.Equals(input.UseSecuredSnapshot))
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
                if (this.UseSecuredSnapshot != null)
                    hashCode = hashCode * 59 + this.UseSecuredSnapshot.GetHashCode();
                return hashCode;
            }
        }

    }

}

