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
    /// KeystoneACLProtoGranteesProjectUsers
    /// </summary>
    [DataContract]
    public partial class KeystoneACLProtoGranteesProjectUsers :  IEquatable<KeystoneACLProtoGranteesProjectUsers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeystoneACLProtoGranteesProjectUsers" /> class.
        /// </summary>
        /// <param name="userIdVec">userIdVec.</param>
        public KeystoneACLProtoGranteesProjectUsers(List<string> userIdVec = default(List<string>))
        {
            this.UserIdVec = userIdVec;
            this.UserIdVec = userIdVec;
        }
        
        /// <summary>
        /// Gets or Sets UserIdVec
        /// </summary>
        [DataMember(Name="userIdVec", EmitDefaultValue=true)]
        public List<string> UserIdVec { get; set; }

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
            return this.Equals(input as KeystoneACLProtoGranteesProjectUsers);
        }

        /// <summary>
        /// Returns true if KeystoneACLProtoGranteesProjectUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of KeystoneACLProtoGranteesProjectUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeystoneACLProtoGranteesProjectUsers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIdVec == input.UserIdVec ||
                    this.UserIdVec != null &&
                    input.UserIdVec != null &&
                    this.UserIdVec.SequenceEqual(input.UserIdVec)
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
                if (this.UserIdVec != null)
                    hashCode = hashCode * 59 + this.UserIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

