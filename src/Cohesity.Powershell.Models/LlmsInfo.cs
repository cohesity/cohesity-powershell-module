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
    /// LlmsInfo holds information about the list of LLM subscription infos.
    /// </summary>
    [DataContract]
    public partial class LlmsInfo :  IEquatable<LlmsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LlmsInfo" /> class.
        /// </summary>
        /// <param name="llms">Specifies the list of LLM subscription info..</param>
        public LlmsInfo(List<LlmInfo> llms = default(List<LlmInfo>))
        {
            this.Llms = llms;
            this.Llms = llms;
        }
        
        /// <summary>
        /// Specifies the list of LLM subscription info.
        /// </summary>
        /// <value>Specifies the list of LLM subscription info.</value>
        [DataMember(Name="llms", EmitDefaultValue=true)]
        public List<LlmInfo> Llms { get; set; }

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
            return this.Equals(input as LlmsInfo);
        }

        /// <summary>
        /// Returns true if LlmsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LlmsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LlmsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Llms == input.Llms ||
                    this.Llms != null &&
                    input.Llms != null &&
                    this.Llms.SequenceEqual(input.Llms)
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
                if (this.Llms != null)
                    hashCode = hashCode * 59 + this.Llms.GetHashCode();
                return hashCode;
            }
        }

    }

}

