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
    /// Specifies information about SSL verification when registering certain sources.
    /// </summary>
    [DataContract]
    public partial class SslVerification :  IEquatable<SslVerification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SslVerification" /> class.
        /// </summary>
        /// <param name="caCertificate">Contains the contents of CA cert/cert chain..</param>
        /// <param name="isEnabled">Whether SSL verification should be performed..</param>
        public SslVerification(string caCertificate = default(string), bool? isEnabled = default(bool?))
        {
            this.CaCertificate = caCertificate;
            this.IsEnabled = isEnabled;
            this.CaCertificate = caCertificate;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Contains the contents of CA cert/cert chain.
        /// </summary>
        /// <value>Contains the contents of CA cert/cert chain.</value>
        [DataMember(Name="caCertificate", EmitDefaultValue=true)]
        public string CaCertificate { get; set; }

        /// <summary>
        /// Whether SSL verification should be performed.
        /// </summary>
        /// <value>Whether SSL verification should be performed.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

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
            return this.Equals(input as SslVerification);
        }

        /// <summary>
        /// Returns true if SslVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of SslVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SslVerification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaCertificate == input.CaCertificate ||
                    (this.CaCertificate != null &&
                    this.CaCertificate.Equals(input.CaCertificate))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.CaCertificate != null)
                    hashCode = hashCode * 59 + this.CaCertificate.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}

