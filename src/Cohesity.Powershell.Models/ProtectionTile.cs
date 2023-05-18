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
    /// Protection information and statistics.
    /// </summary>
    [DataContract]
    public partial class ProtectionTile :  IEquatable<ProtectionTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionTile" /> class.
        /// </summary>
        /// <param name="lastDayArchival">lastDayArchival.</param>
        /// <param name="lastDayBackup">lastDayBackup.</param>
        /// <param name="lastDayReplicationIn">lastDayReplicationIn.</param>
        /// <param name="lastDayReplicationOut">lastDayReplicationOut.</param>
        public ProtectionTile(ProtectionStats lastDayArchival = default(ProtectionStats), ProtectionStats lastDayBackup = default(ProtectionStats), ProtectionStats lastDayReplicationIn = default(ProtectionStats), ProtectionStats lastDayReplicationOut = default(ProtectionStats))
        {
            this.LastDayArchival = lastDayArchival;
            this.LastDayBackup = lastDayBackup;
            this.LastDayReplicationIn = lastDayReplicationIn;
            this.LastDayReplicationOut = lastDayReplicationOut;
        }
        
        /// <summary>
        /// Gets or Sets LastDayArchival
        /// </summary>
        [DataMember(Name="lastDayArchival", EmitDefaultValue=false)]
        public ProtectionStats LastDayArchival { get; set; }

        /// <summary>
        /// Gets or Sets LastDayBackup
        /// </summary>
        [DataMember(Name="lastDayBackup", EmitDefaultValue=false)]
        public ProtectionStats LastDayBackup { get; set; }

        /// <summary>
        /// Gets or Sets LastDayReplicationIn
        /// </summary>
        [DataMember(Name="lastDayReplicationIn", EmitDefaultValue=false)]
        public ProtectionStats LastDayReplicationIn { get; set; }

        /// <summary>
        /// Gets or Sets LastDayReplicationOut
        /// </summary>
        [DataMember(Name="lastDayReplicationOut", EmitDefaultValue=false)]
        public ProtectionStats LastDayReplicationOut { get; set; }

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
            return this.Equals(input as ProtectionTile);
        }

        /// <summary>
        /// Returns true if ProtectionTile instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastDayArchival == input.LastDayArchival ||
                    (this.LastDayArchival != null &&
                    this.LastDayArchival.Equals(input.LastDayArchival))
                ) && 
                (
                    this.LastDayBackup == input.LastDayBackup ||
                    (this.LastDayBackup != null &&
                    this.LastDayBackup.Equals(input.LastDayBackup))
                ) && 
                (
                    this.LastDayReplicationIn == input.LastDayReplicationIn ||
                    (this.LastDayReplicationIn != null &&
                    this.LastDayReplicationIn.Equals(input.LastDayReplicationIn))
                ) && 
                (
                    this.LastDayReplicationOut == input.LastDayReplicationOut ||
                    (this.LastDayReplicationOut != null &&
                    this.LastDayReplicationOut.Equals(input.LastDayReplicationOut))
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
                if (this.LastDayArchival != null)
                    hashCode = hashCode * 59 + this.LastDayArchival.GetHashCode();
                if (this.LastDayBackup != null)
                    hashCode = hashCode * 59 + this.LastDayBackup.GetHashCode();
                if (this.LastDayReplicationIn != null)
                    hashCode = hashCode * 59 + this.LastDayReplicationIn.GetHashCode();
                if (this.LastDayReplicationOut != null)
                    hashCode = hashCode * 59 + this.LastDayReplicationOut.GetHashCode();
                return hashCode;
            }
        }

    }

}

