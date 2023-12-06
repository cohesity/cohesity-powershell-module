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
    /// SfdcRecoverParams
    /// </summary>
    [DataContract]
    public partial class SfdcRecoverParams :  IEquatable<SfdcRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcRecoverParams" /> class.
        /// </summary>
        /// <param name="restoreObjects">restoreObjects.</param>
        public SfdcRecoverParams(List<SfdcRestoreObject> restoreObjects = default(List<SfdcRestoreObject>))
        {
            this.RestoreObjects = restoreObjects;
            this.RestoreObjects = restoreObjects;
        }
        
        /// <summary>
        /// Gets or Sets RestoreObjects
        /// </summary>
        [DataMember(Name="restoreObjects", EmitDefaultValue=true)]
        public List<SfdcRestoreObject> RestoreObjects { get; set; }

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
            return this.Equals(input as SfdcRecoverParams);
        }

        /// <summary>
        /// Returns true if SfdcRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreObjects == input.RestoreObjects ||
                    this.RestoreObjects != null &&
                    input.RestoreObjects != null &&
                    this.RestoreObjects.SequenceEqual(input.RestoreObjects)
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
                if (this.RestoreObjects != null)
                    hashCode = hashCode * 59 + this.RestoreObjects.GetHashCode();
                return hashCode;
            }
        }

    }

}

