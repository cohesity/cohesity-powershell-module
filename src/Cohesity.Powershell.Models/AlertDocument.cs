// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies documentation about the Alert such as name, description, cause and how to resolve the Alert.
    /// </summary>
    [DataContract]
    public partial class AlertDocument :  IEquatable<AlertDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertDocument" /> class.
        /// </summary>
        /// <param name="alertCause">Cause of the Alert that is included in the body of the email or any other type of notification..</param>
        /// <param name="alertDescription">Brief description about the Alert that is used in the subject line when sending a notification email for an Alert..</param>
        /// <param name="alertHelpText">Instructions describing how to resolve the Alert that is included in the body of the email or any other type of notification..</param>
        /// <param name="alertName">Short name that describes the Alert type such as DiskBad, HighCpuUsage, FrequentProcessRestarts, etc..</param>
        public AlertDocument(string alertCause = default(string), string alertDescription = default(string), string alertHelpText = default(string), string alertName = default(string))
        {
            this.AlertCause = alertCause;
            this.AlertDescription = alertDescription;
            this.AlertHelpText = alertHelpText;
            this.AlertName = alertName;
        }
        
        /// <summary>
        /// Cause of the Alert that is included in the body of the email or any other type of notification.
        /// </summary>
        /// <value>Cause of the Alert that is included in the body of the email or any other type of notification.</value>
        [DataMember(Name="alertCause", EmitDefaultValue=false)]
        public string AlertCause { get; set; }

        /// <summary>
        /// Brief description about the Alert that is used in the subject line when sending a notification email for an Alert.
        /// </summary>
        /// <value>Brief description about the Alert that is used in the subject line when sending a notification email for an Alert.</value>
        [DataMember(Name="alertDescription", EmitDefaultValue=false)]
        public string AlertDescription { get; set; }

        /// <summary>
        /// Instructions describing how to resolve the Alert that is included in the body of the email or any other type of notification.
        /// </summary>
        /// <value>Instructions describing how to resolve the Alert that is included in the body of the email or any other type of notification.</value>
        [DataMember(Name="alertHelpText", EmitDefaultValue=false)]
        public string AlertHelpText { get; set; }

        /// <summary>
        /// Short name that describes the Alert type such as DiskBad, HighCpuUsage, FrequentProcessRestarts, etc.
        /// </summary>
        /// <value>Short name that describes the Alert type such as DiskBad, HighCpuUsage, FrequentProcessRestarts, etc.</value>
        [DataMember(Name="alertName", EmitDefaultValue=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as AlertDocument);
        }

        /// <summary>
        /// Returns true if AlertDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertCause == input.AlertCause ||
                    (this.AlertCause != null &&
                    this.AlertCause.Equals(input.AlertCause))
                ) && 
                (
                    this.AlertDescription == input.AlertDescription ||
                    (this.AlertDescription != null &&
                    this.AlertDescription.Equals(input.AlertDescription))
                ) && 
                (
                    this.AlertHelpText == input.AlertHelpText ||
                    (this.AlertHelpText != null &&
                    this.AlertHelpText.Equals(input.AlertHelpText))
                ) && 
                (
                    this.AlertName == input.AlertName ||
                    (this.AlertName != null &&
                    this.AlertName.Equals(input.AlertName))
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
                if (this.AlertCause != null)
                    hashCode = hashCode * 59 + this.AlertCause.GetHashCode();
                if (this.AlertDescription != null)
                    hashCode = hashCode * 59 + this.AlertDescription.GetHashCode();
                if (this.AlertHelpText != null)
                    hashCode = hashCode * 59 + this.AlertHelpText.GetHashCode();
                if (this.AlertName != null)
                    hashCode = hashCode * 59 + this.AlertName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

