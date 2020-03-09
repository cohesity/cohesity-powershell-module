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
    /// Specifies an Object containing information about a HBase table.
    /// </summary>
    [DataContract]
    public partial class HBaseTable :  IEquatable<HBaseTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HBaseTable" /> class.
        /// </summary>
        /// <param name="approxSizeBytes">Specifies the approx size of the table in bytes..</param>
        public HBaseTable(long? approxSizeBytes = default(long?))
        {
            this.ApproxSizeBytes = approxSizeBytes;
            this.ApproxSizeBytes = approxSizeBytes;
        }
        
        /// <summary>
        /// Specifies the approx size of the table in bytes.
        /// </summary>
        /// <value>Specifies the approx size of the table in bytes.</value>
        [DataMember(Name="approxSizeBytes", EmitDefaultValue=true)]
        public long? ApproxSizeBytes { get; set; }

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
            return this.Equals(input as HBaseTable);
        }

        /// <summary>
        /// Returns true if HBaseTable instances are equal
        /// </summary>
        /// <param name="input">Instance of HBaseTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HBaseTable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApproxSizeBytes == input.ApproxSizeBytes ||
                    (this.ApproxSizeBytes != null &&
                    this.ApproxSizeBytes.Equals(input.ApproxSizeBytes))
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
                if (this.ApproxSizeBytes != null)
                    hashCode = hashCode * 59 + this.ApproxSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

