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
    /// AppMetadata provides metadata information about an application.
    /// </summary>
    [DataContract]
    public partial class AppMetadata :  IEquatable<AppMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppMetadata" /> class.
        /// </summary>
        /// <param name="author">Specifies author of the app..</param>
        /// <param name="createdDate">Specifies date when the first version of the app was created..</param>
        /// <param name="description">Specifies description about what app does..</param>
        /// <param name="devVersion">Specifies version of the app provided by the developer..</param>
        /// <param name="iconImage">Specifies application icon..</param>
        /// <param name="lastModifiedDate">Specifies date when the app was last modified..</param>
        /// <param name="name">Specifies name of the app..</param>
        public AppMetadata(string author = default(string), string createdDate = default(string), string description = default(string), string devVersion = default(string), string iconImage = default(string), string lastModifiedDate = default(string), string name = default(string))
        {
            this.Author = author;
            this.CreatedDate = createdDate;
            this.Description = description;
            this.DevVersion = devVersion;
            this.IconImage = iconImage;
            this.LastModifiedDate = lastModifiedDate;
            this.Name = name;
            this.Author = author;
            this.CreatedDate = createdDate;
            this.Description = description;
            this.DevVersion = devVersion;
            this.IconImage = iconImage;
            this.LastModifiedDate = lastModifiedDate;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies author of the app.
        /// </summary>
        /// <value>Specifies author of the app.</value>
        [DataMember(Name="author", EmitDefaultValue=true)]
        public string Author { get; set; }

        /// <summary>
        /// Specifies date when the first version of the app was created.
        /// </summary>
        /// <value>Specifies date when the first version of the app was created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=true)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Specifies description about what app does.
        /// </summary>
        /// <value>Specifies description about what app does.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies version of the app provided by the developer.
        /// </summary>
        /// <value>Specifies version of the app provided by the developer.</value>
        [DataMember(Name="devVersion", EmitDefaultValue=true)]
        public string DevVersion { get; set; }

        /// <summary>
        /// Specifies application icon.
        /// </summary>
        /// <value>Specifies application icon.</value>
        [DataMember(Name="iconImage", EmitDefaultValue=true)]
        public string IconImage { get; set; }

        /// <summary>
        /// Specifies date when the app was last modified.
        /// </summary>
        /// <value>Specifies date when the app was last modified.</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=true)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Specifies name of the app.
        /// </summary>
        /// <value>Specifies name of the app.</value>
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
            return this.Equals(input as AppMetadata);
        }

        /// <summary>
        /// Returns true if AppMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of AppMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DevVersion == input.DevVersion ||
                    (this.DevVersion != null &&
                    this.DevVersion.Equals(input.DevVersion))
                ) && 
                (
                    this.IconImage == input.IconImage ||
                    (this.IconImage != null &&
                    this.IconImage.Equals(input.IconImage))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DevVersion != null)
                    hashCode = hashCode * 59 + this.DevVersion.GetHashCode();
                if (this.IconImage != null)
                    hashCode = hashCode * 59 + this.IconImage.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

