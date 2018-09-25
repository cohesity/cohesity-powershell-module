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
    /// ApplicationParameters
    /// </summary>
    [DataContract]
    public partial class ApplicationParameters :  IEquatable<ApplicationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationParameters" /> class.
        /// </summary>
        /// <param name="truncateExchangeLog">If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false..</param>
        public ApplicationParameters(bool? truncateExchangeLog = default(bool?))
        {
            this.TruncateExchangeLog = truncateExchangeLog;
        }
        
        /// <summary>
        /// If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false.
        /// </summary>
        /// <value>If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false.</value>
        [DataMember(Name="truncateExchangeLog", EmitDefaultValue=false)]
        public bool? TruncateExchangeLog { get; set; }

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
            return this.Equals(input as ApplicationParameters);
        }

        /// <summary>
        /// Returns true if ApplicationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TruncateExchangeLog == input.TruncateExchangeLog ||
                    (this.TruncateExchangeLog != null &&
                    this.TruncateExchangeLog.Equals(input.TruncateExchangeLog))
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
                if (this.TruncateExchangeLog != null)
                    hashCode = hashCode * 59 + this.TruncateExchangeLog.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

