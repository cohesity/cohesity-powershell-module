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
    /// Specifies the parameters for an Antivirus service provider.
    /// </summary>
    [DataContract]
    public partial class AntivirusServiceConfigParams :  IEquatable<AntivirusServiceConfigParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceConfigParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntivirusServiceConfigParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceConfigParams" /> class.
        /// </summary>
        /// <param name="description">Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service..</param>
        /// <param name="icapUri">Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt; (required).</param>
        public AntivirusServiceConfigParams(string description = default(string), string icapUri = default(string))
        {
            this.Description = description;
            this.IcapUri = icapUri;
            this.Description = description;
        }
        
        /// <summary>
        /// Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service.
        /// </summary>
        /// <value>Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt;
        /// </summary>
        /// <value>Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt;</value>
        [DataMember(Name="icapUri", EmitDefaultValue=true)]
        public string IcapUri { get; set; }

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
            return this.Equals(input as AntivirusServiceConfigParams);
        }

        /// <summary>
        /// Returns true if AntivirusServiceConfigParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusServiceConfigParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusServiceConfigParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IcapUri == input.IcapUri ||
                    (this.IcapUri != null &&
                    this.IcapUri.Equals(input.IcapUri))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IcapUri != null)
                    hashCode = hashCode * 59 + this.IcapUri.GetHashCode();
                return hashCode;
            }
        }

    }

}

