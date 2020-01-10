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
    /// Specifies Office365 parameters applicable for all Office365 Environment type Protection Sources in a Protection Job. This encapsulates both OneDrive &amp; Mailbox parameters.
    /// </summary>
    [DataContract]
    public partial class Office365EnvJobParameters :  IEquatable<Office365EnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365EnvJobParameters" /> class.
        /// </summary>
        /// <param name="onedriveParameters">onedriveParameters.</param>
        /// <param name="outlookParameters">outlookParameters.</param>
        public Office365EnvJobParameters(OneDriveEnvJobParameters onedriveParameters = default(OneDriveEnvJobParameters), OutlookEnvJobParameters outlookParameters = default(OutlookEnvJobParameters))
        {
            this.OnedriveParameters = onedriveParameters;
            this.OutlookParameters = outlookParameters;
        }
        
        /// <summary>
        /// Gets or Sets OnedriveParameters
        /// </summary>
        [DataMember(Name="onedriveParameters", EmitDefaultValue=false)]
        public OneDriveEnvJobParameters OnedriveParameters { get; set; }

        /// <summary>
        /// Gets or Sets OutlookParameters
        /// </summary>
        [DataMember(Name="outlookParameters", EmitDefaultValue=false)]
        public OutlookEnvJobParameters OutlookParameters { get; set; }

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
            return this.Equals(input as Office365EnvJobParameters);
        }

        /// <summary>
        /// Returns true if Office365EnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365EnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365EnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnedriveParameters == input.OnedriveParameters ||
                    (this.OnedriveParameters != null &&
                    this.OnedriveParameters.Equals(input.OnedriveParameters))
                ) && 
                (
                    this.OutlookParameters == input.OutlookParameters ||
                    (this.OutlookParameters != null &&
                    this.OutlookParameters.Equals(input.OutlookParameters))
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
                if (this.OnedriveParameters != null)
                    hashCode = hashCode * 59 + this.OnedriveParameters.GetHashCode();
                if (this.OutlookParameters != null)
                    hashCode = hashCode * 59 + this.OutlookParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

