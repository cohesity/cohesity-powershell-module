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
    /// Specifies optional settings for alerting.
    /// </summary>
    [DataContract]
    public partial class AlertingConfig :  IEquatable<AlertingConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingConfig" /> class.
        /// </summary>
        /// <param name="emailAddresses">Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent..</param>
        /// <param name="raiseObjectLevelFailureAlert">Specifies the boolean to raise per object alert for failures..</param>
        public AlertingConfig(List<string> emailAddresses = default(List<string>), bool? raiseObjectLevelFailureAlert = default(bool?))
        {
            this.EmailAddresses = emailAddresses;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
            this.EmailAddresses = emailAddresses;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
        }
        
        /// <summary>
        /// Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.
        /// </summary>
        /// <value>Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.</value>
        [DataMember(Name="emailAddresses", EmitDefaultValue=true)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Specifies the boolean to raise per object alert for failures.
        /// </summary>
        /// <value>Specifies the boolean to raise per object alert for failures.</value>
        [DataMember(Name="raiseObjectLevelFailureAlert", EmitDefaultValue=true)]
        public bool? RaiseObjectLevelFailureAlert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertingConfig {\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  RaiseObjectLevelFailureAlert: ").Append(RaiseObjectLevelFailureAlert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as AlertingConfig);
        }

        /// <summary>
        /// Returns true if AlertingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.RaiseObjectLevelFailureAlert == input.RaiseObjectLevelFailureAlert ||
                    (this.RaiseObjectLevelFailureAlert != null &&
                    this.RaiseObjectLevelFailureAlert.Equals(input.RaiseObjectLevelFailureAlert))
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
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.RaiseObjectLevelFailureAlert != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlert.GetHashCode();
                return hashCode;
            }
        }

    }

}
