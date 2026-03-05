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
    /// M365CsmParams
    /// </summary>
    [DataContract]
    public partial class M365CsmParams :  IEquatable<M365CsmParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M365CsmParams" /> class.
        /// </summary>
        /// <param name="backupAllowed">Specifies whether the current source allows data backup through M365 Backup Storage APIs. Enabling this, data can be optionally backed up within either Cohesity or MSFT or both depending on the backup configuration..</param>
        public M365CsmParams(bool? backupAllowed = default(bool?))
        {
            this.BackupAllowed = backupAllowed;
            this.BackupAllowed = backupAllowed;
        }
        
        /// <summary>
        /// Specifies whether the current source allows data backup through M365 Backup Storage APIs. Enabling this, data can be optionally backed up within either Cohesity or MSFT or both depending on the backup configuration.
        /// </summary>
        /// <value>Specifies whether the current source allows data backup through M365 Backup Storage APIs. Enabling this, data can be optionally backed up within either Cohesity or MSFT or both depending on the backup configuration.</value>
        [DataMember(Name="backupAllowed", EmitDefaultValue=true)]
        public bool? BackupAllowed { get; set; }

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
            return this.Equals(input as M365CsmParams);
        }

        /// <summary>
        /// Returns true if M365CsmParams instances are equal
        /// </summary>
        /// <param name="input">Instance of M365CsmParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(M365CsmParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupAllowed == input.BackupAllowed ||
                    (this.BackupAllowed != null &&
                    this.BackupAllowed.Equals(input.BackupAllowed))
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
                if (this.BackupAllowed != null)
                    hashCode = hashCode * 59 + this.BackupAllowed.GetHashCode();
                return hashCode;
            }
        }

    }

}

