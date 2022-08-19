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
    /// VaultParamsRestoreParamsGlacier
    /// </summary>
    [DataContract]
    public partial class VaultParamsRestoreParamsGlacier :  IEquatable<VaultParamsRestoreParamsGlacier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultParamsRestoreParamsGlacier" /> class.
        /// </summary>
        /// <param name="retrievalType">retrievalType.</param>
        public VaultParamsRestoreParamsGlacier(int? retrievalType = default(int?))
        {
            this.RetrievalType = retrievalType;
            this.RetrievalType = retrievalType;
        }
        
        /// <summary>
        /// Gets or Sets RetrievalType
        /// </summary>
        [DataMember(Name="retrievalType", EmitDefaultValue=true)]
        public int? RetrievalType { get; set; }

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
            return this.Equals(input as VaultParamsRestoreParamsGlacier);
        }

        /// <summary>
        /// Returns true if VaultParamsRestoreParamsGlacier instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultParamsRestoreParamsGlacier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultParamsRestoreParamsGlacier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetrievalType == input.RetrievalType ||
                    (this.RetrievalType != null &&
                    this.RetrievalType.Equals(input.RetrievalType))
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
                if (this.RetrievalType != null)
                    hashCode = hashCode * 59 + this.RetrievalType.GetHashCode();
                return hashCode;
            }
        }

    }

}

