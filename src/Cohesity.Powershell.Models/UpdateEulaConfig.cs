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
    /// Specifies the update to the End User License Agreement information.
    /// </summary>
    [DataContract]
    public partial class UpdateEulaConfig :  IEquatable<UpdateEulaConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEulaConfig" /> class.
        /// </summary>
        /// <param name="signedVersion">Specifies the version of the End User License Agreement that was accepted..</param>
        public UpdateEulaConfig(long? signedVersion = default(long?))
        {
            this.SignedVersion = signedVersion;
            this.SignedVersion = signedVersion;
        }
        
        /// <summary>
        /// Specifies the version of the End User License Agreement that was accepted.
        /// </summary>
        /// <value>Specifies the version of the End User License Agreement that was accepted.</value>
        [DataMember(Name="signedVersion", EmitDefaultValue=true)]
        public long? SignedVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEulaConfig {\n");
            sb.Append("  SignedVersion: ").Append(SignedVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as UpdateEulaConfig);
        }

        /// <summary>
        /// Returns true if UpdateEulaConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateEulaConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateEulaConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignedVersion == input.SignedVersion ||
                    (this.SignedVersion != null &&
                    this.SignedVersion.Equals(input.SignedVersion))
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
                if (this.SignedVersion != null)
                    hashCode = hashCode * 59 + this.SignedVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}
