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
    /// Specifies the parameters to verify OTP code.
    /// </summary>
    [DataContract]
    public partial class VerifyOtpCodeParams :  IEquatable<VerifyOtpCodeParams>
    {
        /// <summary>
        /// Specifies OTP type. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.
        /// </summary>
        /// <value>Specifies OTP type. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OtpTypeEnum
        {
            /// <summary>
            /// Enum Totp for value: Totp
            /// </summary>
            [EnumMember(Value = "Totp")]
            Totp = 1,

            /// <summary>
            /// Enum Email for value: Email
            /// </summary>
            [EnumMember(Value = "Email")]
            Email = 2

        }

        /// <summary>
        /// Specifies OTP type. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.
        /// </summary>
        /// <value>Specifies OTP type. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.</value>
        [DataMember(Name="otpType", EmitDefaultValue=false)]
        public OtpTypeEnum? OtpType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyOtpCodeParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyOtpCodeParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyOtpCodeParams" /> class.
        /// </summary>
        /// <param name="otpCode">Specifies the OTP code. (required).</param>
        /// <param name="otpType">Specifies OTP type. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP..</param>
        public VerifyOtpCodeParams(string otpCode = default(string), OtpTypeEnum? otpType = default(OtpTypeEnum?))
        {
            // to ensure "otpCode" is required (not null)
            if (otpCode == null)
            {
                throw new InvalidDataException("otpCode is a required property for VerifyOtpCodeParams and cannot be null");
            }
            else
            {
                this.OtpCode = otpCode;
            }
            this.OtpType = otpType;
        }
        
        /// <summary>
        /// Specifies the OTP code.
        /// </summary>
        /// <value>Specifies the OTP code.</value>
        [DataMember(Name="otpCode", EmitDefaultValue=false)]
        public string OtpCode { get; set; }


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
            return this.Equals(input as VerifyOtpCodeParams);
        }

        /// <summary>
        /// Returns true if VerifyOtpCodeParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyOtpCodeParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyOtpCodeParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OtpCode == input.OtpCode ||
                    (this.OtpCode != null &&
                    this.OtpCode.Equals(input.OtpCode))
                ) && 
                (
                    this.OtpType == input.OtpType ||
                    (this.OtpType != null &&
                    this.OtpType.Equals(input.OtpType))
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
                if (this.OtpCode != null)
                    hashCode = hashCode * 59 + this.OtpCode.GetHashCode();
                if (this.OtpType != null)
                    hashCode = hashCode * 59 + this.OtpType.GetHashCode();
                return hashCode;
            }
        }

    }

}

