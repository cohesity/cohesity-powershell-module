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
        /// <param name="emailDeliveryTargets">Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent..</param>
        /// <param name="raiseObjectLevelFailureAlert">Specifies the boolean to raise per object alert for failures..</param>
        public AlertingConfig(List<EmailDeliveryTarget> emailDeliveryTargets = default(List<EmailDeliveryTarget>), bool? raiseObjectLevelFailureAlert = default(bool?))
        {
            this.EmailDeliveryTargets = emailDeliveryTargets;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
            this.EmailDeliveryTargets = emailDeliveryTargets;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
        }

        // Bug fix : Support for email configuration for older versions 6.1.1 and 6.3.1
        /// <summary>
        /// Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.
        /// </summary>
        /// <value>Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.</value>
        private List<string> __emailAddresses;
        [DataMember(Name = "emailAddresses", EmitDefaultValue = true)]
        public List<string> EmailAddresses
        {
            get
            {
                return this.__emailAddresses;
            }

            set
            {
                this.__emailAddresses = value;
                SetEmailDeliveryTargets(this.__emailAddresses);
            }
        }
        private void SetEmailDeliveryTargets(List<string> emailAddresses)
        {
            if (null != emailAddresses)
            {
                if (null == this.EmailDeliveryTargets)
                {
                    this.EmailDeliveryTargets = new List<EmailDeliveryTarget>();
                }
                this.EmailDeliveryTargets.Clear();
                foreach (string item in this.__emailAddresses)
                {
                    this.EmailDeliveryTargets.Add(new EmailDeliveryTarget(item));
                }
            }
        }
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
                    this.EmailDeliveryTargets == input.EmailDeliveryTargets ||
                    this.EmailDeliveryTargets != null &&
                    input.EmailDeliveryTargets != null &&
                    this.EmailDeliveryTargets.SequenceEqual(input.EmailDeliveryTargets)
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
                if (this.EmailDeliveryTargets != null)
                    hashCode = hashCode * 59 + this.EmailDeliveryTargets.GetHashCode();
                if (this.RaiseObjectLevelFailureAlert != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlert.GetHashCode();
                return hashCode;
            }
        }

    }

}

