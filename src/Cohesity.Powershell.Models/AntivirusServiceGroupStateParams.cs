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
    /// Specifies the configuration settings to change the state of an Antivirus service group.
    /// </summary>
    [DataContract]
    public partial class AntivirusServiceGroupStateParams :  IEquatable<AntivirusServiceGroupStateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroupStateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntivirusServiceGroupStateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroupStateParams" /> class.
        /// </summary>
        /// <param name="enable">Specifies the enable flag to enable the Antivirus service group. (required).</param>
        /// <param name="id">Specifies the Id of the Antivirus service group. (required).</param>
        public AntivirusServiceGroupStateParams(bool? enable = default(bool?), long? id = default(long?))
        {
            // to ensure "enable" is required (not null)
            if (enable == null)
            {
                throw new InvalidDataException("enable is a required property for AntivirusServiceGroupStateParams and cannot be null");
            }
            else
            {
                this.Enable = enable;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AntivirusServiceGroupStateParams and cannot be null");
            }
            else
            {
                this.Id = id;
            }
        }
        
        /// <summary>
        /// Specifies the enable flag to enable the Antivirus service group.
        /// </summary>
        /// <value>Specifies the enable flag to enable the Antivirus service group.</value>
        [DataMember(Name="enable", EmitDefaultValue=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Specifies the Id of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the Id of the Antivirus service group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

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
            return this.Equals(input as AntivirusServiceGroupStateParams);
        }

        /// <summary>
        /// Returns true if AntivirusServiceGroupStateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusServiceGroupStateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusServiceGroupStateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}

