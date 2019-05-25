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
    /// Preferences
    /// </summary>
    [DataContract]
    public partial class Preferences :  IEquatable<Preferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferences" /> class.
        /// </summary>
        /// <param name="locale">Locale reflects the language settings of the user. Populate using the user preferences stored in Scribe for the user wherever needed..</param>
        public Preferences(string locale = default(string))
        {
            this.Locale = locale;
            this.Locale = locale;
        }
        
        /// <summary>
        /// Locale reflects the language settings of the user. Populate using the user preferences stored in Scribe for the user wherever needed.
        /// </summary>
        /// <value>Locale reflects the language settings of the user. Populate using the user preferences stored in Scribe for the user wherever needed.</value>
        [DataMember(Name="locale", EmitDefaultValue=true)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Preferences {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as Preferences);
        }

        /// <summary>
        /// Returns true if Preferences instances are equal
        /// </summary>
        /// <param name="input">Instance of Preferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Preferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                return hashCode;
            }
        }

    }

}
