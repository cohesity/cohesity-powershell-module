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
    /// LinuxSupportUserSudoAccessReqParams
    /// </summary>
    [DataContract]
    public partial class LinuxSupportUserSudoAccessReqParams :  IEquatable<LinuxSupportUserSudoAccessReqParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxSupportUserSudoAccessReqParams" /> class.
        /// </summary>
        /// <param name="sudoAccessEnable">If the enable flag is set to true, the sudo access will be enabled. If the enable flag is set to false, the sudo access will be disabled..</param>
        public LinuxSupportUserSudoAccessReqParams(bool? sudoAccessEnable = default(bool?))
        {
            this.SudoAccessEnable = sudoAccessEnable;
        }
        
        /// <summary>
        /// If the enable flag is set to true, the sudo access will be enabled. If the enable flag is set to false, the sudo access will be disabled.
        /// </summary>
        /// <value>If the enable flag is set to true, the sudo access will be enabled. If the enable flag is set to false, the sudo access will be disabled.</value>
        [DataMember(Name="sudoAccessEnable", EmitDefaultValue=false)]
        public bool? SudoAccessEnable { get; set; }

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
            return this.Equals(input as LinuxSupportUserSudoAccessReqParams);
        }

        /// <summary>
        /// Returns true if LinuxSupportUserSudoAccessReqParams instances are equal
        /// </summary>
        /// <param name="input">Instance of LinuxSupportUserSudoAccessReqParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinuxSupportUserSudoAccessReqParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SudoAccessEnable == input.SudoAccessEnable ||
                    (this.SudoAccessEnable != null &&
                    this.SudoAccessEnable.Equals(input.SudoAccessEnable))
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
                if (this.SudoAccessEnable != null)
                    hashCode = hashCode * 59 + this.SudoAccessEnable.GetHashCode();
                return hashCode;
            }
        }

    }

}

