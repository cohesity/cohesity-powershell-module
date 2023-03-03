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
    /// VaultParamsRestoreParams
    /// </summary>
    [DataContract]
    public partial class VaultParamsRestoreParams :  IEquatable<VaultParamsRestoreParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultParamsRestoreParams" /> class.
        /// </summary>
        /// <param name="allowMarkedForRemoval">allowMarkedForRemoval.</param>
        /// <param name="glacier">glacier.</param>
        public VaultParamsRestoreParams(bool? allowMarkedForRemoval = default(bool?), VaultParamsRestoreParamsGlacier glacier = default(VaultParamsRestoreParamsGlacier))
        {
            this.AllowMarkedForRemoval = allowMarkedForRemoval;
            this.AllowMarkedForRemoval = allowMarkedForRemoval;
            this.Glacier = glacier;
        }
        
        /// <summary>
        /// Gets or Sets AllowMarkedForRemoval
        /// </summary>
        [DataMember(Name="allowMarkedForRemoval", EmitDefaultValue=true)]
        public bool? AllowMarkedForRemoval { get; set; }

        /// <summary>
        /// Gets or Sets Glacier
        /// </summary>
        [DataMember(Name="glacier", EmitDefaultValue=false)]
        public VaultParamsRestoreParamsGlacier Glacier { get; set; }

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
            return this.Equals(input as VaultParamsRestoreParams);
        }

        /// <summary>
        /// Returns true if VaultParamsRestoreParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultParamsRestoreParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultParamsRestoreParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowMarkedForRemoval == input.AllowMarkedForRemoval ||
                    (this.AllowMarkedForRemoval != null &&
                    this.AllowMarkedForRemoval.Equals(input.AllowMarkedForRemoval))
                ) && 
                (
                    this.Glacier == input.Glacier ||
                    (this.Glacier != null &&
                    this.Glacier.Equals(input.Glacier))
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
                if (this.AllowMarkedForRemoval != null)
                    hashCode = hashCode * 59 + this.AllowMarkedForRemoval.GetHashCode();
                if (this.Glacier != null)
                    hashCode = hashCode * 59 + this.Glacier.GetHashCode();
                return hashCode;
            }
        }

    }

}

