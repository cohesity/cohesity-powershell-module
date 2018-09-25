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
    /// RunMapReduceInstanceResult
    /// </summary>
    [DataContract]
    public partial class RunMapReduceInstanceResult :  IEquatable<RunMapReduceInstanceResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunMapReduceInstanceResult" /> class.
        /// </summary>
        /// <param name="error">Status code of http rpc..</param>
        /// <param name="mapReduceInstanceId">Return the ID of instance..</param>
        public RunMapReduceInstanceResult(ErrorProto error = default(ErrorProto), long? mapReduceInstanceId = default(long?))
        {
            this.Error = error;
            this.MapReduceInstanceId = mapReduceInstanceId;
        }
        
        /// <summary>
        /// Status code of http rpc.
        /// </summary>
        /// <value>Status code of http rpc.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Return the ID of instance.
        /// </summary>
        /// <value>Return the ID of instance.</value>
        [DataMember(Name="mapReduceInstanceId", EmitDefaultValue=false)]
        public long? MapReduceInstanceId { get; set; }

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
            return this.Equals(input as RunMapReduceInstanceResult);
        }

        /// <summary>
        /// Returns true if RunMapReduceInstanceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RunMapReduceInstanceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunMapReduceInstanceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.MapReduceInstanceId == input.MapReduceInstanceId ||
                    (this.MapReduceInstanceId != null &&
                    this.MapReduceInstanceId.Equals(input.MapReduceInstanceId))
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
                if (this.MapReduceInstanceId != null)
                    hashCode = hashCode * 59 + this.MapReduceInstanceId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

