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
    /// This message encapsulates the generic information required for cloning and App view.
    /// </summary>
    [DataContract]
    public partial class CloneAppViewParams :  IEquatable<CloneAppViewParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneAppViewParams" /> class.
        /// </summary>
        /// <param name="mountPathIdentifier">Mount path identifier, which identifies the sub-dir where the cohesity view for App recovery will be mounted..</param>
        /// <param name="readOnlyViewExpose">Read only view expose param, if this is set, the expose view will be mounted with read only..</param>
        public CloneAppViewParams(string mountPathIdentifier = default(string), bool? readOnlyViewExpose = default(bool?))
        {
            this.MountPathIdentifier = mountPathIdentifier;
            this.ReadOnlyViewExpose = readOnlyViewExpose;
        }
        
        /// <summary>
        /// Mount path identifier, which identifies the sub-dir where the cohesity view for App recovery will be mounted.
        /// </summary>
        /// <value>Mount path identifier, which identifies the sub-dir where the cohesity view for App recovery will be mounted.</value>
        [DataMember(Name="mountPathIdentifier", EmitDefaultValue=false)]
        public string MountPathIdentifier { get; set; }

        /// <summary>
        /// Read only view expose param, if this is set, the expose view will be mounted with read only.
        /// </summary>
        /// <value>Read only view expose param, if this is set, the expose view will be mounted with read only.</value>
        [DataMember(Name="readOnlyViewExpose", EmitDefaultValue=false)]
        public bool? ReadOnlyViewExpose { get; set; }

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
            return this.Equals(input as CloneAppViewParams);
        }

        /// <summary>
        /// Returns true if CloneAppViewParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneAppViewParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneAppViewParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountPathIdentifier == input.MountPathIdentifier ||
                    (this.MountPathIdentifier != null &&
                    this.MountPathIdentifier.Equals(input.MountPathIdentifier))
                ) && 
                (
                    this.ReadOnlyViewExpose == input.ReadOnlyViewExpose ||
                    (this.ReadOnlyViewExpose != null &&
                    this.ReadOnlyViewExpose.Equals(input.ReadOnlyViewExpose))
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
                if (this.MountPathIdentifier != null)
                    hashCode = hashCode * 59 + this.MountPathIdentifier.GetHashCode();
                if (this.ReadOnlyViewExpose != null)
                    hashCode = hashCode * 59 + this.ReadOnlyViewExpose.GetHashCode();
                return hashCode;
            }
        }

    }

}

