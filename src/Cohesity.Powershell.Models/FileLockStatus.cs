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
    /// Specifies the information of lock status for a file.
    /// </summary>
    [DataContract]
    public partial class FileLockStatus :  IEquatable<FileLockStatus>
    {
        /// <summary>
        /// Specifies the mode of the file lock. &#39;kCompliance&#39;, &#39;kEnterprise&#39;. A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.
        /// </summary>
        /// <value>Specifies the mode of the file lock. &#39;kCompliance&#39;, &#39;kEnterprise&#39;. A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum KCompliance for value: kCompliance
            /// </summary>
            [EnumMember(Value = "kCompliance")]
            KCompliance = 1,

            /// <summary>
            /// Enum KEnterprise for value: kEnterprise
            /// </summary>
            [EnumMember(Value = "kEnterprise")]
            KEnterprise = 2

        }

        /// <summary>
        /// Specifies the mode of the file lock. &#39;kCompliance&#39;, &#39;kEnterprise&#39;. A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.
        /// </summary>
        /// <value>Specifies the mode of the file lock. &#39;kCompliance&#39;, &#39;kEnterprise&#39;. A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLockStatus" /> class.
        /// </summary>
        /// <param name="expiryTimestampMsecs">Specifies a expiry timestamp in milliseconds until the file is locked..</param>
        /// <param name="holdTimestampMsecs">Specifies a override timestamp in milliseconds when an expired file is kept on hold..</param>
        /// <param name="lockTimestampMsecs">Specifies the timestamp at which the file was locked..</param>
        /// <param name="mode">Specifies the mode of the file lock. &#39;kCompliance&#39;, &#39;kEnterprise&#39;. A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode..</param>
        /// <param name="state">Specifies the lock state of the file..</param>
        public FileLockStatus(long? expiryTimestampMsecs = default(long?), long? holdTimestampMsecs = default(long?), long? lockTimestampMsecs = default(long?), ModeEnum? mode = default(ModeEnum?), int? state = default(int?))
        {
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.HoldTimestampMsecs = holdTimestampMsecs;
            this.LockTimestampMsecs = lockTimestampMsecs;
            this.Mode = mode;
            this.State = state;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.HoldTimestampMsecs = holdTimestampMsecs;
            this.LockTimestampMsecs = lockTimestampMsecs;
            this.Mode = mode;
            this.State = state;
        }
        
        /// <summary>
        /// Specifies a expiry timestamp in milliseconds until the file is locked.
        /// </summary>
        /// <value>Specifies a expiry timestamp in milliseconds until the file is locked.</value>
        [DataMember(Name="expiryTimestampMsecs", EmitDefaultValue=true)]
        public long? ExpiryTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies a override timestamp in milliseconds when an expired file is kept on hold.
        /// </summary>
        /// <value>Specifies a override timestamp in milliseconds when an expired file is kept on hold.</value>
        [DataMember(Name="holdTimestampMsecs", EmitDefaultValue=true)]
        public long? HoldTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the timestamp at which the file was locked.
        /// </summary>
        /// <value>Specifies the timestamp at which the file was locked.</value>
        [DataMember(Name="lockTimestampMsecs", EmitDefaultValue=true)]
        public long? LockTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the lock state of the file.
        /// </summary>
        /// <value>Specifies the lock state of the file.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public int? State { get; set; }

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
            return this.Equals(input as FileLockStatus);
        }

        /// <summary>
        /// Returns true if FileLockStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of FileLockStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileLockStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryTimestampMsecs == input.ExpiryTimestampMsecs ||
                    (this.ExpiryTimestampMsecs != null &&
                    this.ExpiryTimestampMsecs.Equals(input.ExpiryTimestampMsecs))
                ) && 
                (
                    this.HoldTimestampMsecs == input.HoldTimestampMsecs ||
                    (this.HoldTimestampMsecs != null &&
                    this.HoldTimestampMsecs.Equals(input.HoldTimestampMsecs))
                ) && 
                (
                    this.LockTimestampMsecs == input.LockTimestampMsecs ||
                    (this.LockTimestampMsecs != null &&
                    this.LockTimestampMsecs.Equals(input.LockTimestampMsecs))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.ExpiryTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimestampMsecs.GetHashCode();
                if (this.HoldTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.HoldTimestampMsecs.GetHashCode();
                if (this.LockTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.LockTimestampMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}

