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
    /// Message to encapsulate the additional parameters associated with a restore task.
    /// </summary>
    [DataContract]
    public partial class RestoreTaskAdditionalParams :  IEquatable<RestoreTaskAdditionalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreTaskAdditionalParams" /> class.
        /// </summary>
        /// <param name="postScript">postScript.</param>
        /// <param name="preScript">preScript.</param>
        public RestoreTaskAdditionalParams(RemoteScriptProto postScript = default(RemoteScriptProto), RemoteScriptProto preScript = default(RemoteScriptProto))
        {
            this.PostScript = postScript;
            this.PreScript = preScript;
        }
        
        /// <summary>
        /// Gets or Sets PostScript
        /// </summary>
        [DataMember(Name="postScript", EmitDefaultValue=false)]
        public RemoteScriptProto PostScript { get; set; }

        /// <summary>
        /// Gets or Sets PreScript
        /// </summary>
        [DataMember(Name="preScript", EmitDefaultValue=false)]
        public RemoteScriptProto PreScript { get; set; }

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
            return this.Equals(input as RestoreTaskAdditionalParams);
        }

        /// <summary>
        /// Returns true if RestoreTaskAdditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreTaskAdditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreTaskAdditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostScript == input.PostScript ||
                    (this.PostScript != null &&
                    this.PostScript.Equals(input.PostScript))
                ) && 
                (
                    this.PreScript == input.PreScript ||
                    (this.PreScript != null &&
                    this.PreScript.Equals(input.PreScript))
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
                if (this.PostScript != null)
                    hashCode = hashCode * 59 + this.PostScript.GetHashCode();
                if (this.PreScript != null)
                    hashCode = hashCode * 59 + this.PreScript.GetHashCode();
                return hashCode;
            }
        }

    }

}

