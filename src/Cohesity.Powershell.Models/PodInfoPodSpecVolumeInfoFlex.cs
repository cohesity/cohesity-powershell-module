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
    /// Flex represents a generic persistent volume resource that is provisioned/attached using an exec based plugin.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoFlex :  IEquatable<PodInfoPodSpecVolumeInfoFlex>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoFlex" /> class.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="fsType">fsType.</param>
        /// <param name="options">options.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretRef">secretRef.</param>
        public PodInfoPodSpecVolumeInfoFlex(string driver = default(string), string fsType = default(string), List<PodInfoPodSpecVolumeInfoFlexOptionsEntry> options = default(List<PodInfoPodSpecVolumeInfoFlexOptionsEntry>), bool? readOnly = default(bool?), ObjectReference secretRef = default(ObjectReference))
        {
            this.Driver = driver;
            this.FsType = fsType;
            this.Options = options;
            this.ReadOnly = readOnly;
            this.Driver = driver;
            this.FsType = fsType;
            this.Options = options;
            this.ReadOnly = readOnly;
            this.SecretRef = secretRef;
        }
        
        /// <summary>
        /// Gets or Sets Driver
        /// </summary>
        [DataMember(Name="driver", EmitDefaultValue=true)]
        public string Driver { get; set; }

        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=true)]
        public List<PodInfoPodSpecVolumeInfoFlexOptionsEntry> Options { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets SecretRef
        /// </summary>
        [DataMember(Name="secretRef", EmitDefaultValue=false)]
        public ObjectReference SecretRef { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoFlex);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoFlex instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoFlex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoFlex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
                ) && 
                (
                    this.FsType == input.FsType ||
                    (this.FsType != null &&
                    this.FsType.Equals(input.FsType))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.Equals(input.Options)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.SecretRef == input.SecretRef ||
                    (this.SecretRef != null &&
                    this.SecretRef.Equals(input.SecretRef))
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
                if (this.Driver != null)
                    hashCode = hashCode * 59 + this.Driver.GetHashCode();
                if (this.FsType != null)
                    hashCode = hashCode * 59 + this.FsType.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.SecretRef != null)
                    hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                return hashCode;
            }
        }

    }

}

