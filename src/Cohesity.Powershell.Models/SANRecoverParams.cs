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
    /// SANRecoverParams
    /// </summary>
    [DataContract]
    public partial class SANRecoverParams :  IEquatable<SANRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SANRecoverParams" /> class.
        /// </summary>
        /// <param name="sanGroupRecoverParams">sanGroupRecoverParams.</param>
        public SANRecoverParams(SANGroupEntityRecoverParams sanGroupRecoverParams = default(SANGroupEntityRecoverParams))
        {
            this.SanGroupRecoverParams = sanGroupRecoverParams;
        }
        
        /// <summary>
        /// Gets or Sets SanGroupRecoverParams
        /// </summary>
        [DataMember(Name="sanGroupRecoverParams", EmitDefaultValue=false)]
        public SANGroupEntityRecoverParams SanGroupRecoverParams { get; set; }

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
            return this.Equals(input as SANRecoverParams);
        }

        /// <summary>
        /// Returns true if SANRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SANRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SANRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SanGroupRecoverParams == input.SanGroupRecoverParams ||
                    (this.SanGroupRecoverParams != null &&
                    this.SanGroupRecoverParams.Equals(input.SanGroupRecoverParams))
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
                if (this.SanGroupRecoverParams != null)
                    hashCode = hashCode * 59 + this.SanGroupRecoverParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

