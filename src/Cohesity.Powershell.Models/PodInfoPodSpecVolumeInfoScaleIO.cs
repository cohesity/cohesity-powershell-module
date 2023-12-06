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
    /// PodInfoPodSpecVolumeInfoScaleIO
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoScaleIO :  IEquatable<PodInfoPodSpecVolumeInfoScaleIO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoScaleIO" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="protectionDomain">protectionDomain.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretRef">secretRef.</param>
        /// <param name="sslEnabled">sslEnabled.</param>
        /// <param name="storageMode">storageMode.</param>
        /// <param name="storagePool">storagePool.</param>
        /// <param name="system">system.</param>
        /// <param name="volumeName">volumeName.</param>
        public PodInfoPodSpecVolumeInfoScaleIO(string fsType = default(string), string gateway = default(string), string protectionDomain = default(string), bool? readOnly = default(bool?), ObjectReference secretRef = default(ObjectReference), bool? sslEnabled = default(bool?), string storageMode = default(string), string storagePool = default(string), string system = default(string), string volumeName = default(string))
        {
            this.FsType = fsType;
            this.Gateway = gateway;
            this.ProtectionDomain = protectionDomain;
            this.ReadOnly = readOnly;
            this.SslEnabled = sslEnabled;
            this.StorageMode = storageMode;
            this.StoragePool = storagePool;
            this.System = system;
            this.VolumeName = volumeName;
            this.FsType = fsType;
            this.Gateway = gateway;
            this.ProtectionDomain = protectionDomain;
            this.ReadOnly = readOnly;
            this.SecretRef = secretRef;
            this.SslEnabled = sslEnabled;
            this.StorageMode = storageMode;
            this.StoragePool = storagePool;
            this.System = system;
            this.VolumeName = volumeName;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets Gateway
        /// </summary>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionDomain
        /// </summary>
        [DataMember(Name="protectionDomain", EmitDefaultValue=true)]
        public string ProtectionDomain { get; set; }

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
        /// Gets or Sets SslEnabled
        /// </summary>
        [DataMember(Name="sslEnabled", EmitDefaultValue=true)]
        public bool? SslEnabled { get; set; }

        /// <summary>
        /// Gets or Sets StorageMode
        /// </summary>
        [DataMember(Name="storageMode", EmitDefaultValue=true)]
        public string StorageMode { get; set; }

        /// <summary>
        /// Gets or Sets StoragePool
        /// </summary>
        [DataMember(Name="storagePool", EmitDefaultValue=true)]
        public string StoragePool { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=true)]
        public string System { get; set; }

        /// <summary>
        /// Gets or Sets VolumeName
        /// </summary>
        [DataMember(Name="volumeName", EmitDefaultValue=true)]
        public string VolumeName { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoScaleIO);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoScaleIO instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoScaleIO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoScaleIO input)
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
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.ProtectionDomain == input.ProtectionDomain ||
                    (this.ProtectionDomain != null &&
                    this.ProtectionDomain.Equals(input.ProtectionDomain))
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
                    this.SslEnabled == input.SslEnabled ||
                    (this.SslEnabled != null &&
                    this.SslEnabled.Equals(input.SslEnabled))
                ) && 
                (
                    this.StorageMode == input.StorageMode ||
                    (this.StorageMode != null &&
                    this.StorageMode.Equals(input.StorageMode))
                ) && 
                (
                    this.StoragePool == input.StoragePool ||
                    (this.StoragePool != null &&
                    this.StoragePool.Equals(input.StoragePool))
                ) && 
                (
                    this.System == input.System ||
                    (this.System != null &&
                    this.System.Equals(input.System))
                ) && 
                (
                    this.VolumeName == input.VolumeName ||
                    (this.VolumeName != null &&
                    this.VolumeName.Equals(input.VolumeName))
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
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.ProtectionDomain != null)
                    hashCode = hashCode * 59 + this.ProtectionDomain.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.SecretRef != null)
                    hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                if (this.SslEnabled != null)
                    hashCode = hashCode * 59 + this.SslEnabled.GetHashCode();
                if (this.StorageMode != null)
                    hashCode = hashCode * 59 + this.StorageMode.GetHashCode();
                if (this.StoragePool != null)
                    hashCode = hashCode * 59 + this.StoragePool.GetHashCode();
                if (this.System != null)
                    hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}

