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
    /// Message to capture the size information of an object or its snapshot. The calculation method can vary depending on the adapter and based on the evolving needs. E.g. This information can be used for billing calculations in DMaaS.
    /// </summary>
    [DataContract]
    public partial class SizeInfo :  IEquatable<SizeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeInfo" /> class.
        /// </summary>
        /// <param name="computationMethod">The computation method used for \&quot;size_bytes\&quot;..</param>
        /// <param name="sizeBytes">Size in bytes..</param>
        public SizeInfo(int? computationMethod = default(int?), long? sizeBytes = default(long?))
        {
            this.ComputationMethod = computationMethod;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// The computation method used for \&quot;size_bytes\&quot;.
        /// </summary>
        /// <value>The computation method used for \&quot;size_bytes\&quot;.</value>
        [DataMember(Name="computationMethod", EmitDefaultValue=false)]
        public int? ComputationMethod { get; set; }

        /// <summary>
        /// Size in bytes.
        /// </summary>
        /// <value>Size in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as SizeInfo);
        }

        /// <summary>
        /// Returns true if SizeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SizeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SizeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComputationMethod == input.ComputationMethod ||
                    (this.ComputationMethod != null &&
                    this.ComputationMethod.Equals(input.ComputationMethod))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                if (this.ComputationMethod != null)
                    hashCode = hashCode * 59 + this.ComputationMethod.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

