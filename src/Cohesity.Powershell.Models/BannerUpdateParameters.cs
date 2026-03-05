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
    /// Specifies the settings used to update a new banner.
    /// </summary>
    [DataContract]
    public partial class BannerUpdateParameters :  IEquatable<BannerUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BannerUpdateParameters" /> class.
        /// </summary>
        /// <param name="content">Specifies the content of the banner..</param>
        /// <param name="description">description field is deprecated. Specifies the description of this banner..</param>
        /// <param name="isEnabled">IsEnabled field specifies enabled/disabled state of the banner..</param>
        public BannerUpdateParameters(string content = default(string), string description = default(string), bool? isEnabled = default(bool?))
        {
            this.Content = content;
            this.Description = description;
            this.IsEnabled = isEnabled;
            this.Content = content;
            this.Description = description;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Specifies the content of the banner.
        /// </summary>
        /// <value>Specifies the content of the banner.</value>
        [DataMember(Name="content", EmitDefaultValue=true)]
        public string Content { get; set; }

        /// <summary>
        /// description field is deprecated. Specifies the description of this banner.
        /// </summary>
        /// <value>description field is deprecated. Specifies the description of this banner.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// IsEnabled field specifies enabled/disabled state of the banner.
        /// </summary>
        /// <value>IsEnabled field specifies enabled/disabled state of the banner.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

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
            return this.Equals(input as BannerUpdateParameters);
        }

        /// <summary>
        /// Returns true if BannerUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of BannerUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BannerUpdateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}

