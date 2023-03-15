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
    /// Represents a Rados Block Device mount that lasts the lifetime of a pod.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoRBD :  IEquatable<PodInfoPodSpecVolumeInfoRBD>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoRBD" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="image">image.</param>
        /// <param name="keyring">keyring.</param>
        /// <param name="monitors">monitors.</param>
        /// <param name="pool">pool.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretRef">secretRef.</param>
        /// <param name="user">user.</param>
        public PodInfoPodSpecVolumeInfoRBD(string fsType = default(string), string image = default(string), string keyring = default(string), List<string> monitors = default(List<string>), string pool = default(string), bool? readOnly = default(bool?), ObjectReference secretRef = default(ObjectReference), string user = default(string))
        {
            this.FsType = fsType;
            this.Image = image;
            this.Keyring = keyring;
            this.Monitors = monitors;
            this.Pool = pool;
            this.ReadOnly = readOnly;
            this.User = user;
            this.FsType = fsType;
            this.Image = image;
            this.Keyring = keyring;
            this.Monitors = monitors;
            this.Pool = pool;
            this.ReadOnly = readOnly;
            this.SecretRef = secretRef;
            this.User = user;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Keyring
        /// </summary>
        [DataMember(Name="keyring", EmitDefaultValue=true)]
        public string Keyring { get; set; }

        /// <summary>
        /// Gets or Sets Monitors
        /// </summary>
        [DataMember(Name="monitors", EmitDefaultValue=true)]
        public List<string> Monitors { get; set; }

        /// <summary>
        /// Gets or Sets Pool
        /// </summary>
        [DataMember(Name="pool", EmitDefaultValue=true)]
        public string Pool { get; set; }

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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoRBD);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoRBD instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoRBD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoRBD input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FsType == input.FsType ||
                    (this.FsType != null &&
                    this.FsType.Equals(input.FsType))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Keyring == input.Keyring ||
                    (this.Keyring != null &&
                    this.Keyring.Equals(input.Keyring))
                ) && 
                (
                    this.Monitors == input.Monitors ||
                    this.Monitors != null &&
                    input.Monitors != null &&
                    this.Monitors.SequenceEqual(input.Monitors)
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
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
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.FsType != null)
                    hashCode = hashCode * 59 + this.FsType.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Keyring != null)
                    hashCode = hashCode * 59 + this.Keyring.GetHashCode();
                if (this.Monitors != null)
                    hashCode = hashCode * 59 + this.Monitors.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.SecretRef != null)
                    hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }

    }

}

