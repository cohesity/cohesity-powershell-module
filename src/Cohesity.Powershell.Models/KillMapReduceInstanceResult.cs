// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// KillMapReduceInstanceResult
    /// </summary>
    [DataContract]
    public partial class KillMapReduceInstanceResult :  IEquatable<KillMapReduceInstanceResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KillMapReduceInstanceResult" /> class.
        /// </summary>
        /// <param name="error">Status code of http rpc..</param>
        public KillMapReduceInstanceResult(ErrorProto error = default(ErrorProto))
        {
            this.Error = error;
        }
        
        /// <summary>
        /// Status code of http rpc.
        /// </summary>
        /// <value>Status code of http rpc.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as KillMapReduceInstanceResult);
        }

        /// <summary>
        /// Returns true if KillMapReduceInstanceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KillMapReduceInstanceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KillMapReduceInstanceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

