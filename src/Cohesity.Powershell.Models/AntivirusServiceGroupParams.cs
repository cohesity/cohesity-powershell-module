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
    /// AntivirusServiceGroupParams
    /// </summary>
    [DataContract]
    public partial class AntivirusServiceGroupParams :  IEquatable<AntivirusServiceGroupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroupParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntivirusServiceGroupParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroupParams" /> class.
        /// </summary>
        /// <param name="antivirusServices">Specifies the Antivirus services for this provider..</param>
        /// <param name="description">Specifies the description of the Antivirus service group..</param>
        /// <param name="name">Specifies the name of the Antivirus service group. (required).</param>
        public AntivirusServiceGroupParams(List<AntivirusServiceConfigParams> antivirusServices = default(List<AntivirusServiceConfigParams>), string description = default(string), string name = default(string))
        {
            this.AntivirusServices = antivirusServices;
            this.Description = description;
            this.Name = name;
            this.AntivirusServices = antivirusServices;
            this.Description = description;
        }
        
        /// <summary>
        /// Specifies the Antivirus services for this provider.
        /// </summary>
        /// <value>Specifies the Antivirus services for this provider.</value>
        [DataMember(Name="antivirusServices", EmitDefaultValue=true)]
        public List<AntivirusServiceConfigParams> AntivirusServices { get; set; }

        /// <summary>
        /// Specifies the description of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the description of the Antivirus service group.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the name of the Antivirus service group.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as AntivirusServiceGroupParams);
        }

        /// <summary>
        /// Returns true if AntivirusServiceGroupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusServiceGroupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusServiceGroupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AntivirusServices == input.AntivirusServices ||
                    this.AntivirusServices != null &&
                    input.AntivirusServices != null &&
                    this.AntivirusServices.SequenceEqual(input.AntivirusServices)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AntivirusServices != null)
                    hashCode = hashCode * 59 + this.AntivirusServices.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

