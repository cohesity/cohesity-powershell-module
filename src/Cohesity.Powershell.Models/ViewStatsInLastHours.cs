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
    /// Specifies the View stats for last hours.
    /// </summary>
    [DataContract]
    public partial class ViewStatsInLastHours :  IEquatable<ViewStatsInLastHours>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStatsInLastHours" /> class.
        /// </summary>
        /// <param name="lastHours">Specifies the time range..</param>
        /// <param name="nfsProtocolValue">Specifies the stats value for NFS protocol..</param>
        /// <param name="s3ProtocolValue">Specifies the stats value for S3 protocol..</param>
        /// <param name="smbProtocolValue">Specifies the stats value for SMB protocol..</param>
        /// <param name="value">Specifies the stats value for any protocols..</param>
        public ViewStatsInLastHours(long? lastHours = default(long?), long? nfsProtocolValue = default(long?), long? s3ProtocolValue = default(long?), long? smbProtocolValue = default(long?), long? value = default(long?))
        {
            this.LastHours = lastHours;
            this.NfsProtocolValue = nfsProtocolValue;
            this.S3ProtocolValue = s3ProtocolValue;
            this.SmbProtocolValue = smbProtocolValue;
            this.Value = value;
            this.LastHours = lastHours;
            this.NfsProtocolValue = nfsProtocolValue;
            this.S3ProtocolValue = s3ProtocolValue;
            this.SmbProtocolValue = smbProtocolValue;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the time range.
        /// </summary>
        /// <value>Specifies the time range.</value>
        [DataMember(Name="lastHours", EmitDefaultValue=true)]
        public long? LastHours { get; set; }

        /// <summary>
        /// Specifies the stats value for NFS protocol.
        /// </summary>
        /// <value>Specifies the stats value for NFS protocol.</value>
        [DataMember(Name="nfsProtocolValue", EmitDefaultValue=true)]
        public long? NfsProtocolValue { get; set; }

        /// <summary>
        /// Specifies the stats value for S3 protocol.
        /// </summary>
        /// <value>Specifies the stats value for S3 protocol.</value>
        [DataMember(Name="s3ProtocolValue", EmitDefaultValue=true)]
        public long? S3ProtocolValue { get; set; }

        /// <summary>
        /// Specifies the stats value for SMB protocol.
        /// </summary>
        /// <value>Specifies the stats value for SMB protocol.</value>
        [DataMember(Name="smbProtocolValue", EmitDefaultValue=true)]
        public long? SmbProtocolValue { get; set; }

        /// <summary>
        /// Specifies the stats value for any protocols.
        /// </summary>
        /// <value>Specifies the stats value for any protocols.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public long? Value { get; set; }

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
            return this.Equals(input as ViewStatsInLastHours);
        }

        /// <summary>
        /// Returns true if ViewStatsInLastHours instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStatsInLastHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStatsInLastHours input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastHours == input.LastHours ||
                    (this.LastHours != null &&
                    this.LastHours.Equals(input.LastHours))
                ) && 
                (
                    this.NfsProtocolValue == input.NfsProtocolValue ||
                    (this.NfsProtocolValue != null &&
                    this.NfsProtocolValue.Equals(input.NfsProtocolValue))
                ) && 
                (
                    this.S3ProtocolValue == input.S3ProtocolValue ||
                    (this.S3ProtocolValue != null &&
                    this.S3ProtocolValue.Equals(input.S3ProtocolValue))
                ) && 
                (
                    this.SmbProtocolValue == input.SmbProtocolValue ||
                    (this.SmbProtocolValue != null &&
                    this.SmbProtocolValue.Equals(input.SmbProtocolValue))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.LastHours != null)
                    hashCode = hashCode * 59 + this.LastHours.GetHashCode();
                if (this.NfsProtocolValue != null)
                    hashCode = hashCode * 59 + this.NfsProtocolValue.GetHashCode();
                if (this.S3ProtocolValue != null)
                    hashCode = hashCode * 59 + this.S3ProtocolValue.GetHashCode();
                if (this.SmbProtocolValue != null)
                    hashCode = hashCode * 59 + this.SmbProtocolValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

