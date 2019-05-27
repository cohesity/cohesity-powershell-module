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
    /// EmailDeliveryTarget Specifies the email address and the locale setting for it.
    /// </summary>
    [DataContract]
    public partial class EmailDeliveryTarget :  IEquatable<EmailDeliveryTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDeliveryTarget" /> class.
        /// </summary>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="locale">Specifies the language in which the emails sent to the above defined mail address should be in..</param>
        public EmailDeliveryTarget(string emailAddress = default(string), string locale = default(string))
        {
            this.EmailAddress = emailAddress;
            this.Locale = locale;
            this.EmailAddress = emailAddress;
            this.Locale = locale;
        }
        
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Specifies the language in which the emails sent to the above defined mail address should be in.
        /// </summary>
        /// <value>Specifies the language in which the emails sent to the above defined mail address should be in.</value>
        [DataMember(Name="locale", EmitDefaultValue=true)]
        public string Locale { get; set; }

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
            return this.Equals(input as EmailDeliveryTarget);
        }

        /// <summary>
        /// Returns true if EmailDeliveryTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailDeliveryTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDeliveryTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                return hashCode;
            }
        }

    }

}

