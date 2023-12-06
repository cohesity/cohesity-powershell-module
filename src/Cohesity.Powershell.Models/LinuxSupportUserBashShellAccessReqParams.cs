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
    /// LinuxSupportUserBashShellAccessReqParams
    /// </summary>
    [DataContract]
    public partial class LinuxSupportUserBashShellAccessReqParams :  IEquatable<LinuxSupportUserBashShellAccessReqParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxSupportUserBashShellAccessReqParams" /> class.
        /// </summary>
        /// <param name="regenerateToken">If RegenerateToken is set to true, the token would be regenerated and the new token will be returned..</param>
        public LinuxSupportUserBashShellAccessReqParams(bool? regenerateToken = default(bool?))
        {
            this.RegenerateToken = regenerateToken;
            this.RegenerateToken = regenerateToken;
        }
        
        /// <summary>
        /// If RegenerateToken is set to true, the token would be regenerated and the new token will be returned.
        /// </summary>
        /// <value>If RegenerateToken is set to true, the token would be regenerated and the new token will be returned.</value>
        [DataMember(Name="regenerateToken", EmitDefaultValue=true)]
        public bool? RegenerateToken { get; set; }

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
            return this.Equals(input as LinuxSupportUserBashShellAccessReqParams);
        }

        /// <summary>
        /// Returns true if LinuxSupportUserBashShellAccessReqParams instances are equal
        /// </summary>
        /// <param name="input">Instance of LinuxSupportUserBashShellAccessReqParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinuxSupportUserBashShellAccessReqParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegenerateToken == input.RegenerateToken ||
                    (this.RegenerateToken != null &&
                    this.RegenerateToken.Equals(input.RegenerateToken))
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
                if (this.RegenerateToken != null)
                    hashCode = hashCode * 59 + this.RegenerateToken.GetHashCode();
                return hashCode;
            }
        }

    }

}

