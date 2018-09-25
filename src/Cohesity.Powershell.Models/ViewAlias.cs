// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// ViewAlias
    /// </summary>
    [DataContract]
    public partial class ViewAlias :  IEquatable<ViewAlias>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewAlias" /> class.
        /// </summary>
        /// <param name="aliasName">Alias name..</param>
        /// <param name="viewName">View name..</param>
        /// <param name="viewPath">View path for the alias..</param>
        public ViewAlias(string aliasName = default(string), string viewName = default(string), string viewPath = default(string))
        {
            this.AliasName = aliasName;
            this.ViewName = viewName;
            this.ViewPath = viewPath;
        }
        
        /// <summary>
        /// Alias name.
        /// </summary>
        /// <value>Alias name.</value>
        [DataMember(Name="aliasName", EmitDefaultValue=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// View name.
        /// </summary>
        /// <value>View name.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// View path for the alias.
        /// </summary>
        /// <value>View path for the alias.</value>
        [DataMember(Name="viewPath", EmitDefaultValue=false)]
        public string ViewPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ViewAlias);
        }

        /// <summary>
        /// Returns true if ViewAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewAlias input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AliasName == input.AliasName ||
                    (this.AliasName != null &&
                    this.AliasName.Equals(input.AliasName))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.ViewPath == input.ViewPath ||
                    (this.ViewPath != null &&
                    this.ViewPath.Equals(input.ViewPath))
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
                if (this.AliasName != null)
                    hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.ViewPath != null)
                    hashCode = hashCode * 59 + this.ViewPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

