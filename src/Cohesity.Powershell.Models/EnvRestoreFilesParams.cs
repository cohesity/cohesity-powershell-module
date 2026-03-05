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
    /// Message to capture any additional environment specific recovery params at the job level.
    /// </summary>
    [DataContract]
    public partial class EnvRestoreFilesParams :  IEquatable<EnvRestoreFilesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvRestoreFilesParams" /> class.
        /// </summary>
        /// <param name="o365Params">o365Params.</param>
        public EnvRestoreFilesParams(O365RestoreFilesParams o365Params = default(O365RestoreFilesParams))
        {
            this.O365Params = o365Params;
        }
        
        /// <summary>
        /// Gets or Sets O365Params
        /// </summary>
        [DataMember(Name="o365Params", EmitDefaultValue=false)]
        public O365RestoreFilesParams O365Params { get; set; }

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
            return this.Equals(input as EnvRestoreFilesParams);
        }

        /// <summary>
        /// Returns true if EnvRestoreFilesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvRestoreFilesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvRestoreFilesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.O365Params == input.O365Params ||
                    (this.O365Params != null &&
                    this.O365Params.Equals(input.O365Params))
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
                if (this.O365Params != null)
                    hashCode = hashCode * 59 + this.O365Params.GetHashCode();
                return hashCode;
            }
        }

    }

}

