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
    /// AlertingPolicyProto
    /// </summary>
    [DataContract]
    public partial class AlertingPolicyProto :  IEquatable<AlertingPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingPolicyProto" /> class.
        /// </summary>
        /// <param name="emails">The email addresses to send alerts to..</param>
        /// <param name="policy">&#39;policy&#39; is declared as int32 because ORing the enums will generate values which are invalid as enums. Protobuf doesn&#39;t allow those invalid enums to be set..</param>
        /// <param name="raiseObjectLevelFailureAlert">Raise per object alert for failures..</param>
        public AlertingPolicyProto(List<string> emails = default(List<string>), int? policy = default(int?), bool? raiseObjectLevelFailureAlert = default(bool?))
        {
            this.Emails = emails;
            this.Policy = policy;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
            this.Emails = emails;
            this.Policy = policy;
            this.RaiseObjectLevelFailureAlert = raiseObjectLevelFailureAlert;
        }
        
        /// <summary>
        /// The email addresses to send alerts to.
        /// </summary>
        /// <value>The email addresses to send alerts to.</value>
        [DataMember(Name="emails", EmitDefaultValue=true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// &#39;policy&#39; is declared as int32 because ORing the enums will generate values which are invalid as enums. Protobuf doesn&#39;t allow those invalid enums to be set.
        /// </summary>
        /// <value>&#39;policy&#39; is declared as int32 because ORing the enums will generate values which are invalid as enums. Protobuf doesn&#39;t allow those invalid enums to be set.</value>
        [DataMember(Name="policy", EmitDefaultValue=true)]
        public int? Policy { get; set; }

        /// <summary>
        /// Raise per object alert for failures.
        /// </summary>
        /// <value>Raise per object alert for failures.</value>
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
            return this.Equals(input as AlertingPolicyProto);
        }

        /// <summary>
        /// Returns true if AlertingPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertingPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertingPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
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
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.RaiseObjectLevelFailureAlert != null)
                    hashCode = hashCode * 59 + this.RaiseObjectLevelFailureAlert.GetHashCode();
                return hashCode;
            }
        }

    }

}

