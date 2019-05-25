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
    /// SmbPrincipal
    /// </summary>
    [DataContract]
    public partial class SmbPrincipal :  IEquatable<SmbPrincipal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbPrincipal" /> class.
        /// </summary>
        /// <param name="domain">Specifies domain name of the principal..</param>
        /// <param name="name">Specifies name of the SMB principal which may be a group or user..</param>
        /// <param name="sid">Specifies unique Security ID (SID) of the principal that look similar to windows domain SID..</param>
        /// <param name="type">Specifies the type. This can be a user or a group..</param>
        public SmbPrincipal(string domain = default(string), string name = default(string), string sid = default(string), string type = default(string))
        {
            this.Domain = domain;
            this.Name = name;
            this.Sid = sid;
            this.Type = type;
            this.Domain = domain;
            this.Name = name;
            this.Sid = sid;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies domain name of the principal.
        /// </summary>
        /// <value>Specifies domain name of the principal.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies name of the SMB principal which may be a group or user.
        /// </summary>
        /// <value>Specifies name of the SMB principal which may be a group or user.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies unique Security ID (SID) of the principal that look similar to windows domain SID.
        /// </summary>
        /// <value>Specifies unique Security ID (SID) of the principal that look similar to windows domain SID.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies the type. This can be a user or a group.
        /// </summary>
        /// <value>Specifies the type. This can be a user or a group.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmbPrincipal {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SmbPrincipal);
        }

        /// <summary>
        /// Returns true if SmbPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbPrincipal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
