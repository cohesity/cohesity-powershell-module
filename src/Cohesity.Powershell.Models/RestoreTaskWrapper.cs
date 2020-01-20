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
    /// RestoreTaskWrapper
    /// </summary>
    [DataContract]
    public partial class RestoreTaskWrapper :  IEquatable<RestoreTaskWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreTaskWrapper" /> class.
        /// </summary>
        /// <param name="restoreTask">restoreTask.</param>
        public RestoreTaskWrapper(RestoreWrapperProto restoreTask = default(RestoreWrapperProto))
        {
            this.RestoreTask = restoreTask;
        }
        
        /// <summary>
        /// Gets or Sets RestoreTask
        /// </summary>
        [DataMember(Name="restoreTask", EmitDefaultValue=false)]
        public RestoreWrapperProto RestoreTask { get; set; }

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
            return this.Equals(input as RestoreTaskWrapper);
        }

        /// <summary>
        /// Returns true if RestoreTaskWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreTaskWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreTaskWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreTask == input.RestoreTask ||
                    (this.RestoreTask != null &&
                    this.RestoreTask.Equals(input.RestoreTask))
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
                if (this.RestoreTask != null)
                    hashCode = hashCode * 59 + this.RestoreTask.GetHashCode();
                return hashCode;
            }
        }

    }

}

