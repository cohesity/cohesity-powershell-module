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
    /// Specifies the result returned after a successful request to enable/disable the linux &#39;support&#39; user sudo access.
    /// </summary>
    [DataContract]
    public partial class LinuxSupportUserSudoAccessResult :  IEquatable<LinuxSupportUserSudoAccessResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxSupportUserSudoAccessResult" /> class.
        /// </summary>
        /// <param name="result">Date format is in MM/DD/YYYY HH:MM:SS.</param>
        public LinuxSupportUserSudoAccessResult(string result = default(string))
        {
            this.Result = result;
        }
        
        /// <summary>
        /// Date format is in MM/DD/YYYY HH:MM:SS
        /// </summary>
        /// <value>Date format is in MM/DD/YYYY HH:MM:SS</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

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
            return this.Equals(input as LinuxSupportUserSudoAccessResult);
        }

        /// <summary>
        /// Returns true if LinuxSupportUserSudoAccessResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LinuxSupportUserSudoAccessResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinuxSupportUserSudoAccessResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }

    }

}

