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
        /// <param name="emailAddresses">Exists to maintain backwards compatibility with versions before eff8198..</param>
        /// <param name="emailDeliveryTargets">Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent..</param>
        /// <param name="raiseObjectLevelFailureAlert">Specifies the boolean to raise per object alert for failures..</param>
        /// <param name="raiseObjectLevelFailureAlertAfterEachAttempt">Specifies the boolean to raise per object alert for failures after each attempt..</param>
        /// <param name="raiseObjectLevelFailureAlertAfterLastAttempt">Specifies the boolean to raise per object alert for failures after last attempt..</param>
        public AlertingConfig(List<string> emailAddresses = default(List<string>), List<EmailDeliveryTarget> emailDeliveryTargets = default(List<EmailDeliveryTarget>), bool? raiseObjectLevelFailureAlert = default(bool?), bool? raiseObjectLevelFailureAlertAfterEachAttempt = default(bool?), bool? raiseObjectLevelFailureAlertAfterLastAttempt = default(bool?))
        {
            this.EmailAddresses = emailAddresses;
            this.EmailDeliveryTargets = emailDeliveryTargets;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
            this.RaiseObjectLevelFailureAlertAfterEachAttempt = raiseObjectLevelFailureAlertAfterEachAttempt;
            this.RaiseObjectLevelFailureAlertAfterLastAttempt = raiseObjectLevelFailureAlertAfterLastAttempt;
            this.EmailAddresses = emailAddresses;
            this.EmailDeliveryTargets = emailDeliveryTargets;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
            this.RaiseObjectLevelFailureAlertAfterEachAttempt = raiseObjectLevelFailureAlertAfterEachAttempt;
            this.RaiseObjectLevelFailureAlertAfterLastAttempt = raiseObjectLevelFailureAlertAfterLastAttempt;
        }
        
        /// <summary>
        /// Exists to maintain backwards compatibility with versions before eff8198.
        /// </summary>
        /// <value>Exists to maintain backwards compatibility with versions before eff8198.</value>
        [DataMember(Name="emailAddresses", EmitDefaultValue=true)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.
        /// </summary>
        /// <value>Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.</value>
        [DataMember(Name="emailDeliveryTargets", EmitDefaultValue=true)]
        public List<EmailDeliveryTarget> EmailDeliveryTargets { get; set; }

        /// <summary>
        /// Specifies the boolean to raise per object alert for failures.
        /// </summary>
        /// <value>Specifies the boolean to raise per object alert for failures.</value>
        [DataMember(Name="raiseObjectLevelFailureAlert", EmitDefaultValue=true)]
        public bool? RaiseObjectLevelFailureAlert { get; set; }

        /// <summary>
        /// Specifies the boolean to raise per object alert for failures after each attempt.
        /// </summary>
        /// <value>Specifies the boolean to raise per object alert for failures after each attempt.</value>
        [DataMember(Name="raiseObjectLevelFailureAlertAfterEachAttempt", EmitDefaultValue=true)]
        public bool? RaiseObjectLevelFailureAlertAfterEachAttempt { get; set; }

        /// <summary>
        /// Specifies the boolean to raise per object alert for failures after last attempt.
        /// </summary>
        /// <value>Specifies the boolean to raise per object alert for failures after last attempt.</value>
        [DataMember(Name="raiseObjectLevelFailureAlertAfterLastAttempt", EmitDefaultValue=true)]
        public bool? RaiseObjectLevelFailureAlertAfterLastAttempt { get; set; }

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
                    this.EmailDeliveryTargets == input.EmailDeliveryTargets ||
                    this.EmailDeliveryTargets != null &&
                    input.EmailDeliveryTargets != null &&
                    this.EmailDeliveryTargets.SequenceEqual(input.EmailDeliveryTargets)
                ) && 
                (
                    this.RaiseObjectLevelFailureAlert == input.RaiseObjectLevelFailureAlert ||
                    (this.RaiseObjectLevelFailureAlert != null &&
                    this.RaiseObjectLevelFailureAlert.Equals(input.RaiseObjectLevelFailureAlert))
                ) && 
                (
                    this.RaiseObjectLevelFailureAlertAfterEachAttempt == input.RaiseObjectLevelFailureAlertAfterEachAttempt ||
                    (this.RaiseObjectLevelFailureAlertAfterEachAttempt != null &&
                    this.RaiseObjectLevelFailureAlertAfterEachAttempt.Equals(input.RaiseObjectLevelFailureAlertAfterEachAttempt))
                ) && 
                (
                    this.RaiseObjectLevelFailureAlertAfterLastAttempt == input.RaiseObjectLevelFailureAlertAfterLastAttempt ||
                    (this.RaiseObjectLevelFailureAlertAfterLastAttempt != null &&
                    this.RaiseObjectLevelFailureAlertAfterLastAttempt.Equals(input.RaiseObjectLevelFailureAlertAfterLastAttempt))
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
                if (this.EmailDeliveryTargets != null)
                    hashCode = hashCode * 59 + this.EmailDeliveryTargets.GetHashCode();
                if (this.RaiseObjectLevelFailureAlert != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlert.GetHashCode();
                if (this.RaiseObjectLevelFailureAlertAfterEachAttempt != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlertAfterEachAttempt.GetHashCode();
                if (this.RaiseObjectLevelFailureAlertAfterLastAttempt != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlertAfterLastAttempt.GetHashCode();
                return hashCode;
            }
        }

    }

}

