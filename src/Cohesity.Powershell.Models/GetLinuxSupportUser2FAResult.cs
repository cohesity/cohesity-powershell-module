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
    /// GetLinuxSupportUser2FAResult
    /// </summary>
    [DataContract]
    public partial class GetLinuxSupportUser2FAResult :  IEquatable<GetLinuxSupportUser2FAResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLinuxSupportUser2FAResult" /> class.
        /// </summary>
        /// <param name="emailID">emailID.</param>
        /// <param name="tOTPQRCodeUrl">tOTPQRCodeUrl.</param>
        /// <param name="tOTPSecretKey">tOTPSecretKey.</param>
        /// <param name="twoFAMode">twoFAMode.</param>
        public GetLinuxSupportUser2FAResult(string emailID = default(string), string tOTPQRCodeUrl = default(string), string tOTPSecretKey = default(string), long? twoFAMode = default(long?))
        {
            this.EmailID = emailID;
            this.TOTPQRCodeUrl = tOTPQRCodeUrl;
            this.TOTPSecretKey = tOTPSecretKey;
            this.TwoFAMode = twoFAMode;
            this.EmailID = emailID;
            this.TOTPQRCodeUrl = tOTPQRCodeUrl;
            this.TOTPSecretKey = tOTPSecretKey;
            this.TwoFAMode = twoFAMode;
        }
        
        /// <summary>
        /// Gets or Sets EmailID
        /// </summary>
        [DataMember(Name="EmailID", EmitDefaultValue=true)]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or Sets TOTPQRCodeUrl
        /// </summary>
        [DataMember(Name="TOTPQRCodeUrl", EmitDefaultValue=true)]
        public string TOTPQRCodeUrl { get; set; }

        /// <summary>
        /// Gets or Sets TOTPSecretKey
        /// </summary>
        [DataMember(Name="TOTPSecretKey", EmitDefaultValue=true)]
        public string TOTPSecretKey { get; set; }

        /// <summary>
        /// Gets or Sets TwoFAMode
        /// </summary>
        [DataMember(Name="TwoFAMode", EmitDefaultValue=true)]
        public long? TwoFAMode { get; set; }

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
            return this.Equals(input as GetLinuxSupportUser2FAResult);
        }

        /// <summary>
        /// Returns true if GetLinuxSupportUser2FAResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLinuxSupportUser2FAResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLinuxSupportUser2FAResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailID == input.EmailID ||
                    (this.EmailID != null &&
                    this.EmailID.Equals(input.EmailID))
                ) && 
                (
                    this.TOTPQRCodeUrl == input.TOTPQRCodeUrl ||
                    (this.TOTPQRCodeUrl != null &&
                    this.TOTPQRCodeUrl.Equals(input.TOTPQRCodeUrl))
                ) && 
                (
                    this.TOTPSecretKey == input.TOTPSecretKey ||
                    (this.TOTPSecretKey != null &&
                    this.TOTPSecretKey.Equals(input.TOTPSecretKey))
                ) && 
                (
                    this.TwoFAMode == input.TwoFAMode ||
                    (this.TwoFAMode != null &&
                    this.TwoFAMode.Equals(input.TwoFAMode))
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
                if (this.EmailID != null)
                    hashCode = hashCode * 59 + this.EmailID.GetHashCode();
                if (this.TOTPQRCodeUrl != null)
                    hashCode = hashCode * 59 + this.TOTPQRCodeUrl.GetHashCode();
                if (this.TOTPSecretKey != null)
                    hashCode = hashCode * 59 + this.TOTPSecretKey.GetHashCode();
                if (this.TwoFAMode != null)
                    hashCode = hashCode * 59 + this.TwoFAMode.GetHashCode();
                return hashCode;
            }
        }

    }

}

