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
    /// Message to capture additional backup job params specific to Exchange.
    /// </summary>
    [DataContract]
    public partial class ExchangeBackupJobParams :  IEquatable<ExchangeBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeBackupJobParams" /> class.
        /// </summary>
        /// <param name="isCopyOnlyFull">Whether the backups should be copy-only. If this is set to true, then Exchange server will not truncate logs after backup..</param>
        public ExchangeBackupJobParams(bool? isCopyOnlyFull = default(bool?))
        {
            this.IsCopyOnlyFull = isCopyOnlyFull;
        }
        
        /// <summary>
        /// Whether the backups should be copy-only. If this is set to true, then Exchange server will not truncate logs after backup.
        /// </summary>
        /// <value>Whether the backups should be copy-only. If this is set to true, then Exchange server will not truncate logs after backup.</value>
        [DataMember(Name="isCopyOnlyFull", EmitDefaultValue=false)]
        public bool? IsCopyOnlyFull { get; set; }

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
            return this.Equals(input as ExchangeBackupJobParams);
        }

        /// <summary>
        /// Returns true if ExchangeBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCopyOnlyFull == input.IsCopyOnlyFull ||
                    (this.IsCopyOnlyFull != null &&
                    this.IsCopyOnlyFull.Equals(input.IsCopyOnlyFull))
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
                if (this.IsCopyOnlyFull != null)
                    hashCode = hashCode * 59 + this.IsCopyOnlyFull.GetHashCode();
                return hashCode;
            }
        }

    }

}

