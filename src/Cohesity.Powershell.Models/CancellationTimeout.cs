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
    /// CancellationTimeout
    /// </summary>
    [DataContract]
    public partial class CancellationTimeout :  IEquatable<CancellationTimeout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationTimeout" /> class.
        /// </summary>
        /// <param name="backupType">The backup type to which this timeout applies to..</param>
        /// <param name="timeoutMins">The duration of timeout after which the run/task will get cancelled automatically..</param>
        public CancellationTimeout(int? backupType = default(int?), long? timeoutMins = default(long?))
        {
            this.BackupType = backupType;
            this.TimeoutMins = timeoutMins;
            this.BackupType = backupType;
            this.TimeoutMins = timeoutMins;
        }
        
        /// <summary>
        /// The backup type to which this timeout applies to.
        /// </summary>
        /// <value>The backup type to which this timeout applies to.</value>
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public int? BackupType { get; set; }

        /// <summary>
        /// The duration of timeout after which the run/task will get cancelled automatically.
        /// </summary>
        /// <value>The duration of timeout after which the run/task will get cancelled automatically.</value>
        [DataMember(Name="timeoutMins", EmitDefaultValue=true)]
        public long? TimeoutMins { get; set; }

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
            return this.Equals(input as CancellationTimeout);
        }

        /// <summary>
        /// Returns true if CancellationTimeout instances are equal
        /// </summary>
        /// <param name="input">Instance of CancellationTimeout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancellationTimeout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
                ) && 
                (
                    this.TimeoutMins == input.TimeoutMins ||
                    (this.TimeoutMins != null &&
                    this.TimeoutMins.Equals(input.TimeoutMins))
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
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.TimeoutMins != null)
                    hashCode = hashCode * 59 + this.TimeoutMins.GetHashCode();
                return hashCode;
            }
        }

    }

}

