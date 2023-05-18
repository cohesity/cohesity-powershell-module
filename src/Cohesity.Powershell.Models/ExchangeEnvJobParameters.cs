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
    /// Specifies job parameters applicable for the Exchange Protection Jobs.
    /// </summary>
    [DataContract]
    public partial class ExchangeEnvJobParameters :  IEquatable<ExchangeEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeEnvJobParameters" /> class.
        /// </summary>
        /// <param name="backupsCopyOnly">Specifies whether the backups should be copy-only..</param>
        public ExchangeEnvJobParameters(bool? backupsCopyOnly = default(bool?))
        {
            this.BackupsCopyOnly = backupsCopyOnly;
            this.BackupsCopyOnly = backupsCopyOnly;
        }
        
        /// <summary>
        /// Specifies whether the backups should be copy-only.
        /// </summary>
        /// <value>Specifies whether the backups should be copy-only.</value>
        [DataMember(Name="backupsCopyOnly", EmitDefaultValue=true)]
        public bool? BackupsCopyOnly { get; set; }

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
            return this.Equals(input as ExchangeEnvJobParameters);
        }

        /// <summary>
        /// Returns true if ExchangeEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupsCopyOnly == input.BackupsCopyOnly ||
                    (this.BackupsCopyOnly != null &&
                    this.BackupsCopyOnly.Equals(input.BackupsCopyOnly))
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
                if (this.BackupsCopyOnly != null)
                    hashCode = hashCode * 59 + this.BackupsCopyOnly.GetHashCode();
                return hashCode;
            }
        }

    }

}

