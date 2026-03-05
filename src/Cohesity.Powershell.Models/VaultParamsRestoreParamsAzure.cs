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
    /// VaultParamsRestoreParamsAzure
    /// </summary>
    [DataContract]
    public partial class VaultParamsRestoreParamsAzure :  IEquatable<VaultParamsRestoreParamsAzure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultParamsRestoreParamsAzure" /> class.
        /// </summary>
        /// <param name="useCopyBlob">Whether to use copy blob approach to rehydrate from archive tier..</param>
        public VaultParamsRestoreParamsAzure(bool? useCopyBlob = default(bool?))
        {
            this.UseCopyBlob = useCopyBlob;
            this.UseCopyBlob = useCopyBlob;
        }
        
        /// <summary>
        /// Whether to use copy blob approach to rehydrate from archive tier.
        /// </summary>
        /// <value>Whether to use copy blob approach to rehydrate from archive tier.</value>
        [DataMember(Name="useCopyBlob", EmitDefaultValue=true)]
        public bool? UseCopyBlob { get; set; }

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
            return this.Equals(input as VaultParamsRestoreParamsAzure);
        }

        /// <summary>
        /// Returns true if VaultParamsRestoreParamsAzure instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultParamsRestoreParamsAzure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultParamsRestoreParamsAzure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseCopyBlob == input.UseCopyBlob ||
                    (this.UseCopyBlob != null &&
                    this.UseCopyBlob.Equals(input.UseCopyBlob))
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
                if (this.UseCopyBlob != null)
                    hashCode = hashCode * 59 + this.UseCopyBlob.GetHashCode();
                return hashCode;
            }
        }

    }

}

