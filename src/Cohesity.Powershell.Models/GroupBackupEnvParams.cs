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
    /// Message to capture any additional backup params for Group within the Office365 environment.
    /// </summary>
    [DataContract]
    public partial class GroupBackupEnvParams :  IEquatable<GroupBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBackupEnvParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public GroupBackupEnvParams()
        {
        }
        
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
            return this.Equals(input as GroupBackupEnvParams);
        }

        /// <summary>
        /// Returns true if GroupBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupBackupEnvParams input)
        {
            if (input == null)
                return false;

            return false;
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
                return hashCode;
            }
        }

    }

}

