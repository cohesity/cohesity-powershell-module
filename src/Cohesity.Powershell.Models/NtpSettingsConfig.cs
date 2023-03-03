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
    /// NtpSettingsConfig
    /// </summary>
    [DataContract]
    public partial class NtpSettingsConfig :  IEquatable<NtpSettingsConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NtpSettingsConfig" /> class.
        /// </summary>
        /// <param name="ntpAuthenticationEnabled">Flag to specify if the cluster is using NTP with authentication..</param>
        /// <param name="ntpServersInternal">Flag to specify if the NTP servers are on internal network or not..</param>
        public NtpSettingsConfig(bool? ntpAuthenticationEnabled = default(bool?), bool? ntpServersInternal = default(bool?))
        {
            this.NtpAuthenticationEnabled = ntpAuthenticationEnabled;
            this.NtpServersInternal = ntpServersInternal;
            this.NtpAuthenticationEnabled = ntpAuthenticationEnabled;
            this.NtpServersInternal = ntpServersInternal;
        }
        
        /// <summary>
        /// Flag to specify if the cluster is using NTP with authentication.
        /// </summary>
        /// <value>Flag to specify if the cluster is using NTP with authentication.</value>
        [DataMember(Name="ntpAuthenticationEnabled", EmitDefaultValue=true)]
        public bool? NtpAuthenticationEnabled { get; set; }

        /// <summary>
        /// Flag to specify if the NTP servers are on internal network or not.
        /// </summary>
        /// <value>Flag to specify if the NTP servers are on internal network or not.</value>
        [DataMember(Name="ntpServersInternal", EmitDefaultValue=true)]
        public bool? NtpServersInternal { get; set; }

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
            return this.Equals(input as NtpSettingsConfig);
        }

        /// <summary>
        /// Returns true if NtpSettingsConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NtpSettingsConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NtpSettingsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NtpAuthenticationEnabled == input.NtpAuthenticationEnabled ||
                    (this.NtpAuthenticationEnabled != null &&
                    this.NtpAuthenticationEnabled.Equals(input.NtpAuthenticationEnabled))
                ) && 
                (
                    this.NtpServersInternal == input.NtpServersInternal ||
                    (this.NtpServersInternal != null &&
                    this.NtpServersInternal.Equals(input.NtpServersInternal))
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
                if (this.NtpAuthenticationEnabled != null)
                    hashCode = hashCode * 59 + this.NtpAuthenticationEnabled.GetHashCode();
                if (this.NtpServersInternal != null)
                    hashCode = hashCode * 59 + this.NtpServersInternal.GetHashCode();
                return hashCode;
            }
        }

    }

}

