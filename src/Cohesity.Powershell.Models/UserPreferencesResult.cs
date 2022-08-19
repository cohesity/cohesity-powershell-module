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
    /// Specifies the result of user preference.
    /// </summary>
    [DataContract]
    public partial class UserPreferencesResult :  IEquatable<UserPreferencesResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesResult" /> class.
        /// </summary>
        /// <param name="preferences">Preferences is a key-value map of preferences..</param>
        public UserPreferencesResult(Dictionary<string, string> preferences = default(Dictionary<string, string>))
        {
            this.Preferences = preferences;
            this.Preferences = preferences;
        }
        
        /// <summary>
        /// Preferences is a key-value map of preferences.
        /// </summary>
        /// <value>Preferences is a key-value map of preferences.</value>
        [DataMember(Name="preferences", EmitDefaultValue=true)]
        public Dictionary<string, string> Preferences { get; set; }

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
            return this.Equals(input as UserPreferencesResult);
        }

        /// <summary>
        /// Returns true if UserPreferencesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPreferencesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPreferencesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Preferences == input.Preferences ||
                    this.Preferences != null &&
                    input.Preferences != null &&
                    this.Preferences.Equals(input.Preferences)
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
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                return hashCode;
            }
        }

    }

}

