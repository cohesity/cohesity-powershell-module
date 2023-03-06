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
    /// Specifies vss writer information about a Physical Protection Source.
    /// </summary>
    [DataContract]
    public partial class VssWriter :  IEquatable<VssWriter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VssWriter" /> class.
        /// </summary>
        /// <param name="isWriterExcluded">If true, the writer will be excluded by default..</param>
        /// <param name="writerName">Specifies the name of the writer..</param>
        public VssWriter(bool? isWriterExcluded = default(bool?), string writerName = default(string))
        {
            this.IsWriterExcluded = isWriterExcluded;
            this.WriterName = writerName;
            this.IsWriterExcluded = isWriterExcluded;
            this.WriterName = writerName;
        }
        
        /// <summary>
        /// If true, the writer will be excluded by default.
        /// </summary>
        /// <value>If true, the writer will be excluded by default.</value>
        [DataMember(Name="isWriterExcluded", EmitDefaultValue=true)]
        public bool? IsWriterExcluded { get; set; }

        /// <summary>
        /// Specifies the name of the writer.
        /// </summary>
        /// <value>Specifies the name of the writer.</value>
        [DataMember(Name="writerName", EmitDefaultValue=true)]
        public string WriterName { get; set; }

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
            return this.Equals(input as VssWriter);
        }

        /// <summary>
        /// Returns true if VssWriter instances are equal
        /// </summary>
        /// <param name="input">Instance of VssWriter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VssWriter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsWriterExcluded == input.IsWriterExcluded ||
                    (this.IsWriterExcluded != null &&
                    this.IsWriterExcluded.Equals(input.IsWriterExcluded))
                ) && 
                (
                    this.WriterName == input.WriterName ||
                    (this.WriterName != null &&
                    this.WriterName.Equals(input.WriterName))
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
                if (this.IsWriterExcluded != null)
                    hashCode = hashCode * 59 + this.IsWriterExcluded.GetHashCode();
                if (this.WriterName != null)
                    hashCode = hashCode * 59 + this.WriterName.GetHashCode();
                return hashCode;
            }
        }

    }

}

