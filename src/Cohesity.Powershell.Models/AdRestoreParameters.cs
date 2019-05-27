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
        /// <param name="credentials">credentials.</param>
        /// <param name="port">Specifies the port on which the AD domain controller&#39;s NTDS database will be mounted..</param>
        public AdRestoreParameters(Credentials credentials = default(Credentials), int? port = default(int?))
        {
            this.Port = port;
            this.Credentials = credentials;
            this.Port = port;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

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
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

