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
    /// IRIS will then send that information to the nexus to program in the backend.
    /// </summary>
    [DataContract]
    public partial class PutLinuxSupportUser2FAParamsWithTOTP :  IEquatable<PutLinuxSupportUser2FAParamsWithTOTP>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutLinuxSupportUser2FAParamsWithTOTP" /> class.
        /// </summary>
        /// <param name="tOTPQRUrl">tOTPQRUrl.</param>
        /// <param name="tOTPSecretKey">tOTPSecretKey.</param>
        /// <param name="twoFAMode">Value 0 means disable the 2FA. i.e., Password only authentication. Value 1 means TOTP 2FA. If the TOTP 2FA has already been configured then it&#39;ll be re-keyed. Value 2 means Email 2FA. Request should have Email ID (or) The backend should already have the Email ID configured..</param>
        /// <param name="emailID">Specify Email ID for the Email based OTP..</param>
        public PutLinuxSupportUser2FAParamsWithTOTP(string tOTPQRUrl = default(string), string tOTPSecretKey = default(string), long? twoFAMode = default(long?), string emailID = default(string))
        {
            this.TOTPQRUrl = tOTPQRUrl;
            this.TOTPSecretKey = tOTPSecretKey;
            this.TwoFAMode = twoFAMode;
            this.EmailID = emailID;
            this.TOTPQRUrl = tOTPQRUrl;
            this.TOTPSecretKey = tOTPSecretKey;
            this.TwoFAMode = twoFAMode;
            this.EmailID = emailID;
        }
        
        /// <summary>
        /// Gets or Sets TOTPQRUrl
        /// </summary>
        [DataMember(Name="TOTPQRUrl", EmitDefaultValue=true)]
        public string TOTPQRUrl { get; set; }

        /// <summary>
        /// Gets or Sets TOTPSecretKey
        /// </summary>
        [DataMember(Name="TOTPSecretKey", EmitDefaultValue=true)]
        public string TOTPSecretKey { get; set; }

        /// <summary>
        /// Value 0 means disable the 2FA. i.e., Password only authentication. Value 1 means TOTP 2FA. If the TOTP 2FA has already been configured then it&#39;ll be re-keyed. Value 2 means Email 2FA. Request should have Email ID (or) The backend should already have the Email ID configured.
        /// </summary>
        /// <value>Value 0 means disable the 2FA. i.e., Password only authentication. Value 1 means TOTP 2FA. If the TOTP 2FA has already been configured then it&#39;ll be re-keyed. Value 2 means Email 2FA. Request should have Email ID (or) The backend should already have the Email ID configured.</value>
        [DataMember(Name="TwoFAMode", EmitDefaultValue=true)]
        public long? TwoFAMode { get; set; }

        /// <summary>
        /// Specify Email ID for the Email based OTP.
        /// </summary>
        /// <value>Specify Email ID for the Email based OTP.</value>
        [DataMember(Name="emailID", EmitDefaultValue=true)]
        public string EmailID { get; set; }

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
            return this.Equals(input as PutLinuxSupportUser2FAParamsWithTOTP);
        }

        /// <summary>
        /// Returns true if PutLinuxSupportUser2FAParamsWithTOTP instances are equal
        /// </summary>
        /// <param name="input">Instance of PutLinuxSupportUser2FAParamsWithTOTP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutLinuxSupportUser2FAParamsWithTOTP input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TOTPQRUrl == input.TOTPQRUrl ||
                    (this.TOTPQRUrl != null &&
                    this.TOTPQRUrl.Equals(input.TOTPQRUrl))
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
                ) && 
                (
                    this.EmailID == input.EmailID ||
                    (this.EmailID != null &&
                    this.EmailID.Equals(input.EmailID))
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
                if (this.TOTPQRUrl != null)
                    hashCode = hashCode * 59 + this.TOTPQRUrl.GetHashCode();
                if (this.TOTPSecretKey != null)
                    hashCode = hashCode * 59 + this.TOTPSecretKey.GetHashCode();
                if (this.TwoFAMode != null)
                    hashCode = hashCode * 59 + this.TwoFAMode.GetHashCode();
                if (this.EmailID != null)
                    hashCode = hashCode * 59 + this.EmailID.GetHashCode();
                return hashCode;
            }
        }

    }

}

