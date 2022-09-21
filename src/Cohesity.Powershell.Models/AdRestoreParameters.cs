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
    /// Specifies the parameters specific to Application domain controller.
    /// </summary>
    [DataContract]
    public partial class AdRestoreParameters :  IEquatable<AdRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdRestoreParameters" /> class.
        /// </summary>
        /// <param name="adOptions">adOptions.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="mountAndRestore">Specifies the option to mount the AD snapshot database and restore the AD objects in a single restore task. AdOptions must be set if this is set to true..</param>
        /// <param name="port">Specifies the port on which the AD domain controller&#39;s NTDS database will be mounted..</param>
        public AdRestoreParameters(AdRestoreOptions adOptions = default(AdRestoreOptions), Credentials credentials = default(Credentials), bool? mountAndRestore = default(bool?), int? port = default(int?))
        {
            this.MountAndRestore = mountAndRestore;
            this.Port = port;
            this.AdOptions = adOptions;
            this.Credentials = credentials;
            this.MountAndRestore = mountAndRestore;
            this.Port = port;
        }
        
        /// <summary>
        /// Gets or Sets AdOptions
        /// </summary>
        [DataMember(Name="adOptions", EmitDefaultValue=false)]
        public AdRestoreOptions AdOptions { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Specifies the option to mount the AD snapshot database and restore the AD objects in a single restore task. AdOptions must be set if this is set to true.
        /// </summary>
        /// <value>Specifies the option to mount the AD snapshot database and restore the AD objects in a single restore task. AdOptions must be set if this is set to true.</value>
        [DataMember(Name="mountAndRestore", EmitDefaultValue=true)]
        public bool? MountAndRestore { get; set; }

        /// <summary>
        /// Specifies the port on which the AD domain controller&#39;s NTDS database will be mounted.
        /// </summary>
        /// <value>Specifies the port on which the AD domain controller&#39;s NTDS database will be mounted.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

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
            return this.Equals(input as AdRestoreParameters);
        }

        /// <summary>
        /// Returns true if AdRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AdRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdOptions == input.AdOptions ||
                    (this.AdOptions != null &&
                    this.AdOptions.Equals(input.AdOptions))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.MountAndRestore == input.MountAndRestore ||
                    (this.MountAndRestore != null &&
                    this.MountAndRestore.Equals(input.MountAndRestore))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.AdOptions != null)
                    hashCode = hashCode * 59 + this.AdOptions.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.MountAndRestore != null)
                    hashCode = hashCode * 59 + this.MountAndRestore.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

