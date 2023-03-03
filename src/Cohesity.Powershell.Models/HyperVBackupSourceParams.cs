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
    /// Message to capture additional backup params for a Hyper-V type source.
    /// </summary>
    [DataContract]
    public partial class HyperVBackupSourceParams :  IEquatable<HyperVBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperVBackupSourceParams" /> class.
        /// </summary>
        /// <param name="sourceAppParams">sourceAppParams.</param>
        public HyperVBackupSourceParams(SourceAppParams sourceAppParams = default(SourceAppParams))
        {
            this.SourceAppParams = sourceAppParams;
        }
        
        /// <summary>
        /// Gets or Sets SourceAppParams
        /// </summary>
        [DataMember(Name="sourceAppParams", EmitDefaultValue=false)]
        public SourceAppParams SourceAppParams { get; set; }

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
            return this.Equals(input as HyperVBackupSourceParams);
        }

        /// <summary>
        /// Returns true if HyperVBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HyperVBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperVBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAppParams == input.SourceAppParams ||
                    (this.SourceAppParams != null &&
                    this.SourceAppParams.Equals(input.SourceAppParams))
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
                if (this.SourceAppParams != null)
                    hashCode = hashCode * 59 + this.SourceAppParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

