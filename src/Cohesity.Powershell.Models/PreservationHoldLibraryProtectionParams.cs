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
    /// Specifies params specific to protecting the preservation hold library.
    /// </summary>
    [DataContract]
    public partial class PreservationHoldLibraryProtectionParams :  IEquatable<PreservationHoldLibraryProtectionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreservationHoldLibraryProtectionParams" /> class.
        /// </summary>
        /// <param name="shouldProtectPhl">Whether or not the preservation hold library should be protected..</param>
        public PreservationHoldLibraryProtectionParams(bool? shouldProtectPhl = default(bool?))
        {
            this.ShouldProtectPhl = shouldProtectPhl;
            this.ShouldProtectPhl = shouldProtectPhl;
        }
        
        /// <summary>
        /// Whether or not the preservation hold library should be protected.
        /// </summary>
        /// <value>Whether or not the preservation hold library should be protected.</value>
        [DataMember(Name="shouldProtectPhl", EmitDefaultValue=true)]
        public bool? ShouldProtectPhl { get; set; }

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
            return this.Equals(input as PreservationHoldLibraryProtectionParams);
        }

        /// <summary>
        /// Returns true if PreservationHoldLibraryProtectionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PreservationHoldLibraryProtectionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreservationHoldLibraryProtectionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShouldProtectPhl == input.ShouldProtectPhl ||
                    (this.ShouldProtectPhl != null &&
                    this.ShouldProtectPhl.Equals(input.ShouldProtectPhl))
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
                if (this.ShouldProtectPhl != null)
                    hashCode = hashCode * 59 + this.ShouldProtectPhl.GetHashCode();
                return hashCode;
            }
        }

    }

}

