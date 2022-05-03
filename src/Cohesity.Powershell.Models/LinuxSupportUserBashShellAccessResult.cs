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
    /// Specifies the result returned after a successful request to get the linux &#39;support&#39; user bash shell access token,
    /// </summary>
    [DataContract]
    public partial class LinuxSupportUserBashShellAccessResult :  IEquatable<LinuxSupportUserBashShellAccessResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxSupportUserBashShellAccessResult" /> class.
        /// </summary>
        /// <param name="supportUserToken">SSH identity key to login as &#39;support&#39; user..</param>
        public LinuxSupportUserBashShellAccessResult(string supportUserToken = default(string))
        {
            this.SupportUserToken = supportUserToken;
        }
        
        /// <summary>
        /// SSH identity key to login as &#39;support&#39; user.
        /// </summary>
        /// <value>SSH identity key to login as &#39;support&#39; user.</value>
        [DataMember(Name="supportUserToken", EmitDefaultValue=false)]
        public string SupportUserToken { get; set; }

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
            return this.Equals(input as LinuxSupportUserBashShellAccessResult);
        }

        /// <summary>
        /// Returns true if LinuxSupportUserBashShellAccessResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LinuxSupportUserBashShellAccessResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinuxSupportUserBashShellAccessResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportUserToken == input.SupportUserToken ||
                    (this.SupportUserToken != null &&
                    this.SupportUserToken.Equals(input.SupportUserToken))
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
                if (this.SupportUserToken != null)
                    hashCode = hashCode * 59 + this.SupportUserToken.GetHashCode();
                return hashCode;
            }
        }

    }

}

