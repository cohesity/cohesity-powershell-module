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
    /// Specifies the configuration settings for an Antivirus service group.
    /// </summary>
    [DataContract]
    public partial class AntivirusServiceGroup :  IEquatable<AntivirusServiceGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntivirusServiceGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceGroup" /> class.
        /// </summary>
        /// <param name="antivirusServices">Specifies the Antivirus Services belonging to this antivirus group..</param>
        /// <param name="description">Specifies the description of the Antivirus service group..</param>
        /// <param name="id">Specifies the Id of the Antivirus service group. (required).</param>
        /// <param name="isEnabled">Specifies whether the antivirus service group is enabled or not..</param>
        /// <param name="name">Specifies the name of the Antivirus service group. (required).</param>
        public AntivirusServiceGroup(List<AntivirusServiceConfig> antivirusServices = default(List<AntivirusServiceConfig>), string description = default(string), long? id = default(long?), bool? isEnabled = default(bool?), string name = default(string))
        {
            this.AntivirusServices = antivirusServices;
            this.Description = description;
            this.Id = id;
            this.IsEnabled = isEnabled;
            this.Name = name;
            this.AntivirusServices = antivirusServices;
            this.Description = description;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Specifies the Antivirus Services belonging to this antivirus group.
        /// </summary>
        /// <value>Specifies the Antivirus Services belonging to this antivirus group.</value>
        [DataMember(Name="antivirusServices", EmitDefaultValue=true)]
        public List<AntivirusServiceConfig> AntivirusServices { get; set; }

        /// <summary>
        /// Specifies the description of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the description of the Antivirus service group.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Id of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the Id of the Antivirus service group.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies whether the antivirus service group is enabled or not.
        /// </summary>
        /// <value>Specifies whether the antivirus service group is enabled or not.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

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
            return this.Equals(input as AntivirusServiceGroup);
        }

        /// <summary>
        /// Returns true if AntivirusServiceGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusServiceGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusServiceGroup input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

