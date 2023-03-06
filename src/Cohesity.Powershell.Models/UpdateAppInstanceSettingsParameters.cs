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
    /// Specifies update app instance settings parameters.
    /// </summary>
    [DataContract]
    public partial class UpdateAppInstanceSettingsParameters :  IEquatable<UpdateAppInstanceSettingsParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppInstanceSettingsParameters" /> class.
        /// </summary>
        /// <param name="description">Description of the app instance..</param>
        /// <param name="settings">settings.</param>
        public UpdateAppInstanceSettingsParameters(string description = default(string), AppInstanceSettings settings = default(AppInstanceSettings))
        {
            this.Description = description;
            this.Description = description;
            this.Settings = settings;
        }
        
        /// <summary>
        /// Description of the app instance.
        /// </summary>
        /// <value>Description of the app instance.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AppInstanceSettings Settings { get; set; }

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
            return this.Equals(input as UpdateAppInstanceSettingsParameters);
        }

        /// <summary>
        /// Returns true if UpdateAppInstanceSettingsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAppInstanceSettingsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAppInstanceSettingsParameters input)
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
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                return hashCode;
            }
        }

    }

}

