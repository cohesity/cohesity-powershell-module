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
    /// UpdateAntivirusServiceGroupParams
    /// </summary>
    [DataContract]
    public partial class UpdateAntivirusServiceGroupParams :  IEquatable<UpdateAntivirusServiceGroupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAntivirusServiceGroupParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAntivirusServiceGroupParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAntivirusServiceGroupParams" /> class.
        /// </summary>
        /// <param name="antivirusServices">Specifies the Antivirus services for this provider..</param>
        /// <param name="description">Specifies the description of the Antivirus service group..</param>
        /// <param name="id">Specifies the Id of the Antivirus service group. (required).</param>
        /// <param name="isEnabled">Specifies whether the antivirus service group is enabled or not..</param>
        /// <param name="name">Specifies the name of the Antivirus service group. (required).</param>
        public UpdateAntivirusServiceGroupParams(List<AntivirusServiceConfigParams> antivirusServices = default(List<AntivirusServiceConfigParams>), string description = default(string), long? id = default(long?), bool? isEnabled = default(bool?), string name = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UpdateAntivirusServiceGroupParams and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateAntivirusServiceGroupParams and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.AntivirusServices = antivirusServices;
            this.Description = description;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Specifies the Antivirus services for this provider.
        /// </summary>
        /// <value>Specifies the Antivirus services for this provider.</value>
        [DataMember(Name="antivirusServices", EmitDefaultValue=false)]
        public List<AntivirusServiceConfigParams> AntivirusServices { get; set; }

        /// <summary>
        /// Specifies the description of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the description of the Antivirus service group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Id of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the Id of the Antivirus service group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies whether the antivirus service group is enabled or not.
        /// </summary>
        /// <value>Specifies whether the antivirus service group is enabled or not.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Specifies the name of the Antivirus service group.
        /// </summary>
        /// <value>Specifies the name of the Antivirus service group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
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
            return this.Equals(input as UpdateAntivirusServiceGroupParams);
        }

        /// <summary>
        /// Returns true if UpdateAntivirusServiceGroupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAntivirusServiceGroupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAntivirusServiceGroupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AntivirusServices == input.AntivirusServices ||
                    this.AntivirusServices != null &&
                    this.AntivirusServices.Equals(input.AntivirusServices)
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

