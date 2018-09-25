// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// For the specified principal, grant access permissions to the the specified Protection Sources and View names.
    /// </summary>
    [DataContract]
    public partial class SourceForPrincipalParam :  IEquatable<SourceForPrincipalParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceForPrincipalParam" /> class.
        /// </summary>
        /// <param name="protectionSourceIds">For the specified principal, grant access permissions to the Protection Sources listed in this array..</param>
        /// <param name="sid">Specifies the SID of the principal to grant access permissions to..</param>
        /// <param name="viewNames">For the specified principal, grant access permissions to the Views names listed in this array..</param>
        public SourceForPrincipalParam(List<long?> protectionSourceIds = default(List<long?>), string sid = default(string), List<string> viewNames = default(List<string>))
        {
            this.ProtectionSourceIds = protectionSourceIds;
            this.Sid = sid;
            this.ViewNames = viewNames;
        }
        
        /// <summary>
        /// For the specified principal, grant access permissions to the Protection Sources listed in this array.
        /// </summary>
        /// <value>For the specified principal, grant access permissions to the Protection Sources listed in this array.</value>
        [DataMember(Name="protectionSourceIds", EmitDefaultValue=false)]
        public List<long?> ProtectionSourceIds { get; set; }

        /// <summary>
        /// Specifies the SID of the principal to grant access permissions to.
        /// </summary>
        /// <value>Specifies the SID of the principal to grant access permissions to.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// For the specified principal, grant access permissions to the Views names listed in this array.
        /// </summary>
        /// <value>For the specified principal, grant access permissions to the Views names listed in this array.</value>
        [DataMember(Name="viewNames", EmitDefaultValue=false)]
        public List<string> ViewNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as SourceForPrincipalParam);
        }

        /// <summary>
        /// Returns true if SourceForPrincipalParam instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceForPrincipalParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceForPrincipalParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionSourceIds == input.ProtectionSourceIds ||
                    this.ProtectionSourceIds != null &&
                    this.ProtectionSourceIds.SequenceEqual(input.ProtectionSourceIds)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.ViewNames == input.ViewNames ||
                    this.ViewNames != null &&
                    this.ViewNames.SequenceEqual(input.ViewNames)
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
                if (this.ProtectionSourceIds != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceIds.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.ViewNames != null)
                    hashCode = hashCode * 59 + this.ViewNames.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

