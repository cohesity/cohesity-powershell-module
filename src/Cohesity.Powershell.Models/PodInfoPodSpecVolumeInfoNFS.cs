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
    /// PodInfoPodSpecVolumeInfoNFS
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoNFS :  IEquatable<PodInfoPodSpecVolumeInfoNFS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoNFS" /> class.
        /// </summary>
        /// <param name="path">path.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="server">server.</param>
        public PodInfoPodSpecVolumeInfoNFS(string path = default(string), bool? readOnly = default(bool?), string server = default(string))
        {
            this.Path = path;
            this.ReadOnly = readOnly;
            this.Server = server;
            this.Path = path;
            this.ReadOnly = readOnly;
            this.Server = server;
        }
        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name="server", EmitDefaultValue=true)]
        public string Server { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoNFS);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoNFS instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoNFS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoNFS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                return hashCode;
            }
        }

    }

}

