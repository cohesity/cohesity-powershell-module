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
    /// This message encapsulates backup view Clone operation information of a Oracle DB.
    /// </summary>
    [DataContract]
    public partial class CloneAppViewInfoOracle :  IEquatable<CloneAppViewInfoOracle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneAppViewInfoOracle" /> class.
        /// </summary>
        /// <param name="mountPathInfoVec">mountPathInfoVec.</param>
        public CloneAppViewInfoOracle(List<string> mountPathInfoVec = default(List<string>))
        {
            this.MountPathInfoVec = mountPathInfoVec;
        }
        
        /// <summary>
        /// Gets or Sets MountPathInfoVec
        /// </summary>
        [DataMember(Name="mountPathInfoVec", EmitDefaultValue=false)]
        public List<string> MountPathInfoVec { get; set; }

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
            return this.Equals(input as CloneAppViewInfoOracle);
        }

        /// <summary>
        /// Returns true if CloneAppViewInfoOracle instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneAppViewInfoOracle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneAppViewInfoOracle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountPathInfoVec == input.MountPathInfoVec ||
                    this.MountPathInfoVec != null &&
                    this.MountPathInfoVec.Equals(input.MountPathInfoVec)
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
                if (this.MountPathInfoVec != null)
                    hashCode = hashCode * 59 + this.MountPathInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

