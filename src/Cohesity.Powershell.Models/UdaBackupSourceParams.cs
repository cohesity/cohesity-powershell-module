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
    /// UdaBackupSourceParams
    /// </summary>
    [DataContract]
    public partial class UdaBackupSourceParams :  IEquatable<UdaBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaBackupSourceParams" /> class.
        /// </summary>
        /// <param name="throttlingParams">throttlingParams.</param>
        public UdaBackupSourceParams(UdaThrottlingParams throttlingParams = default(UdaThrottlingParams))
        {
            this.ThrottlingParams = throttlingParams;
        }
        
        /// <summary>
        /// Gets or Sets ThrottlingParams
        /// </summary>
        [DataMember(Name="throttlingParams", EmitDefaultValue=false)]
        public UdaThrottlingParams ThrottlingParams { get; set; }

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
            return this.Equals(input as UdaBackupSourceParams);
        }

        /// <summary>
        /// Returns true if UdaBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThrottlingParams == input.ThrottlingParams ||
                    (this.ThrottlingParams != null &&
                    this.ThrottlingParams.Equals(input.ThrottlingParams))
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
                if (this.ThrottlingParams != null)
                    hashCode = hashCode * 59 + this.ThrottlingParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

