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
    /// Specifies the status of an upgrade request.
    /// </summary>
    [DataContract]
    public partial class UpgradePhysicalAgentsMessage :  IEquatable<UpgradePhysicalAgentsMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradePhysicalAgentsMessage" /> class.
        /// </summary>
        /// <param name="message">Specifies the status message returned after initiating an upgrade request. Status of each agent upgrade can be obtained by listing Physical Servers using the GET /public/protectionSources operation..</param>
        public UpgradePhysicalAgentsMessage(string message = default(string))
        {
            this.Message = message;
        }
        
        /// <summary>
        /// Specifies the status message returned after initiating an upgrade request. Status of each agent upgrade can be obtained by listing Physical Servers using the GET /public/protectionSources operation.
        /// </summary>
        /// <value>Specifies the status message returned after initiating an upgrade request. Status of each agent upgrade can be obtained by listing Physical Servers using the GET /public/protectionSources operation.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

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
            return this.Equals(input as UpgradePhysicalAgentsMessage);
        }

        /// <summary>
        /// Returns true if UpgradePhysicalAgentsMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradePhysicalAgentsMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradePhysicalAgentsMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

