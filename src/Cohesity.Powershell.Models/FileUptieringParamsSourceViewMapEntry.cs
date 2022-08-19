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
    /// FileUptieringParamsSourceViewMapEntry
    /// </summary>
    [DataContract]
    public partial class FileUptieringParamsSourceViewMapEntry :  IEquatable<FileUptieringParamsSourceViewMapEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUptieringParamsSourceViewMapEntry" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public FileUptieringParamsSourceViewMapEntry(long? key = default(long?), FileUptieringParamsSourceViewData value = default(FileUptieringParamsSourceViewData))
        {
            this.Key = key;
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public long? Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public FileUptieringParamsSourceViewData Value { get; set; }

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
            return this.Equals(input as FileUptieringParamsSourceViewMapEntry);
        }

        /// <summary>
        /// Returns true if FileUptieringParamsSourceViewMapEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUptieringParamsSourceViewMapEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUptieringParamsSourceViewMapEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

