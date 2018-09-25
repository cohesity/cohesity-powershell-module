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
    /// Specifies the Protection Sources objects and Views that the specified principal has permissions to access. The principal is specified using a security identifier (SID).
    /// </summary>
    [DataContract]
    public partial class SourcesForSid :  IEquatable<SourcesForSid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesForSid" /> class.
        /// </summary>
        /// <param name="protectionSources">Specifies the Protection Source objects that the specified principal has permissions to access..</param>
        /// <param name="sid">Specifies the security identifier (SID) of the principal..</param>
        /// <param name="views">Specifies the names of the Views that the specified principal has permissions to access..</param>
        public SourcesForSid(List<ProtectionSource> protectionSources = default(List<ProtectionSource>), string sid = default(string), List<View> views = default(List<View>))
        {
            this.ProtectionSources = protectionSources;
            this.Sid = sid;
            this.Views = views;
        }
        
        /// <summary>
        /// Specifies the Protection Source objects that the specified principal has permissions to access.
        /// </summary>
        /// <value>Specifies the Protection Source objects that the specified principal has permissions to access.</value>
        [DataMember(Name="protectionSources", EmitDefaultValue=false)]
        public List<ProtectionSource> ProtectionSources { get; set; }

        /// <summary>
        /// Specifies the security identifier (SID) of the principal.
        /// </summary>
        /// <value>Specifies the security identifier (SID) of the principal.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies the names of the Views that the specified principal has permissions to access.
        /// </summary>
        /// <value>Specifies the names of the Views that the specified principal has permissions to access.</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<View> Views { get; set; }

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
            return this.Equals(input as SourcesForSid);
        }

        /// <summary>
        /// Returns true if SourcesForSid instances are equal
        /// </summary>
        /// <param name="input">Instance of SourcesForSid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourcesForSid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionSources == input.ProtectionSources ||
                    this.ProtectionSources != null &&
                    this.ProtectionSources.SequenceEqual(input.ProtectionSources)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.ProtectionSources != null)
                    hashCode = hashCode * 59 + this.ProtectionSources.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

