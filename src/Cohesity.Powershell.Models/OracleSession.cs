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
    /// Specifies information about session configuration for an Oracle host.
    /// </summary>
    [DataContract]
    public partial class OracleSession :  IEquatable<OracleSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleSession" /> class.
        /// </summary>
        /// <param name="location">Location is the path where Oracle is installed..</param>
        /// <param name="systemIdentifier">SystemIdentifier is the unique Oracle System Identifier for the DB instance..</param>
        public OracleSession(string location = default(string), string systemIdentifier = default(string))
        {
            this.Location = location;
            this.SystemIdentifier = systemIdentifier;
            this.Location = location;
            this.SystemIdentifier = systemIdentifier;
        }
        
        /// <summary>
        /// Location is the path where Oracle is installed.
        /// </summary>
        /// <value>Location is the path where Oracle is installed.</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// SystemIdentifier is the unique Oracle System Identifier for the DB instance.
        /// </summary>
        /// <value>SystemIdentifier is the unique Oracle System Identifier for the DB instance.</value>
        [DataMember(Name="systemIdentifier", EmitDefaultValue=true)]
        public string SystemIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OracleSession {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  SystemIdentifier: ").Append(SystemIdentifier).Append("\n");
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
            return this.Equals(input as OracleSession);
        }

        /// <summary>
        /// Returns true if OracleSession instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.SystemIdentifier == input.SystemIdentifier ||
                    (this.SystemIdentifier != null &&
                    this.SystemIdentifier.Equals(input.SystemIdentifier))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.SystemIdentifier != null)
                    hashCode = hashCode * 59 + this.SystemIdentifier.GetHashCode();
                return hashCode;
            }
        }

    }

}
