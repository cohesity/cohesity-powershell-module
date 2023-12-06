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
    /// Specifies information about MFA.
    /// </summary>
    [DataContract]
    public partial class MfaInfo :  IEquatable<MfaInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaInfo" /> class.
        /// </summary>
        /// <param name="isUserExemptFromMfa">Specifies if MFA is disabled on the user..</param>
        public MfaInfo(bool? isUserExemptFromMfa = default(bool?))
        {
            this.IsUserExemptFromMfa = isUserExemptFromMfa;
            this.IsUserExemptFromMfa = isUserExemptFromMfa;
        }
        
        /// <summary>
        /// Specifies if email OTP setup is done on the user.
        /// </summary>
        /// <value>Specifies if email OTP setup is done on the user.</value>
        [DataMember(Name="isEmailOtpSetupDone", EmitDefaultValue=true)]
        public bool? IsEmailOtpSetupDone { get; private set; }

        /// <summary>
        /// Specifies if TOTP setup is done on the user.
        /// </summary>
        /// <value>Specifies if TOTP setup is done on the user.</value>
        [DataMember(Name="isTotpSetupDone", EmitDefaultValue=true)]
        public bool? IsTotpSetupDone { get; private set; }

        /// <summary>
        /// Specifies if MFA is disabled on the user.
        /// </summary>
        /// <value>Specifies if MFA is disabled on the user.</value>
        [DataMember(Name="isUserExemptFromMfa", EmitDefaultValue=true)]
        public bool? IsUserExemptFromMfa { get; set; }

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
            return this.Equals(input as MfaInfo);
        }

        /// <summary>
        /// Returns true if MfaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEmailOtpSetupDone == input.IsEmailOtpSetupDone ||
                    (this.IsEmailOtpSetupDone != null &&
                    this.IsEmailOtpSetupDone.Equals(input.IsEmailOtpSetupDone))
                ) && 
                (
                    this.IsTotpSetupDone == input.IsTotpSetupDone ||
                    (this.IsTotpSetupDone != null &&
                    this.IsTotpSetupDone.Equals(input.IsTotpSetupDone))
                ) && 
                (
                    this.IsUserExemptFromMfa == input.IsUserExemptFromMfa ||
                    (this.IsUserExemptFromMfa != null &&
                    this.IsUserExemptFromMfa.Equals(input.IsUserExemptFromMfa))
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
                if (this.IsEmailOtpSetupDone != null)
                    hashCode = hashCode * 59 + this.IsEmailOtpSetupDone.GetHashCode();
                if (this.IsTotpSetupDone != null)
                    hashCode = hashCode * 59 + this.IsTotpSetupDone.GetHashCode();
                if (this.IsUserExemptFromMfa != null)
                    hashCode = hashCode * 59 + this.IsUserExemptFromMfa.GetHashCode();
                return hashCode;
            }
        }

    }

}

