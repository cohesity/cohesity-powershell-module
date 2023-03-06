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
    /// Specifies the datalock retention type and expiry time when datalock expires
    /// </summary>
    [DataContract]
    public partial class DataLockConstraints :  IEquatable<DataLockConstraints>
    {
        /// <summary>
        /// Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WormRetentionTypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KCompliance for value: kCompliance
            /// </summary>
            [EnumMember(Value = "kCompliance")]
            KCompliance = 2,

            /// <summary>
            /// Enum KAdministrative for value: kAdministrative
            /// </summary>
            [EnumMember(Value = "kAdministrative")]
            KAdministrative = 3

        }

        /// <summary>
        /// Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [DataMember(Name="wormRetentionType", EmitDefaultValue=true)]
        public WormRetentionTypeEnum? WormRetentionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataLockConstraints" /> class.
        /// </summary>
        /// <param name="expiryTimeUsecs">Specifies expiry time to keep Snapshots under datalock in a protection group..</param>
        /// <param name="wormRetentionType">Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes..</param>
        public DataLockConstraints(long? expiryTimeUsecs = default(long?), WormRetentionTypeEnum? wormRetentionType = default(WormRetentionTypeEnum?))
        {
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.WormRetentionType = wormRetentionType;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.WormRetentionType = wormRetentionType;
        }
        
        /// <summary>
        /// Specifies expiry time to keep Snapshots under datalock in a protection group.
        /// </summary>
        /// <value>Specifies expiry time to keep Snapshots under datalock in a protection group.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

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
            return this.Equals(input as DataLockConstraints);
        }

        /// <summary>
        /// Returns true if DataLockConstraints instances are equal
        /// </summary>
        /// <param name="input">Instance of DataLockConstraints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataLockConstraints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.WormRetentionType == input.WormRetentionType ||
                    this.WormRetentionType.Equals(input.WormRetentionType)
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
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.WormRetentionType.GetHashCode();
                return hashCode;
            }
        }

    }

}

