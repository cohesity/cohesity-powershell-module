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
    /// This message encapsulates the information of Clone operation of backup view of an App.
    /// </summary>
    [DataContract]
    public partial class CloneAppViewInfoProto :  IEquatable<CloneAppViewInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneAppViewInfoProto" /> class.
        /// </summary>
        /// <param name="oracleAppViewRestoreInfo">oracleAppViewRestoreInfo.</param>
        public CloneAppViewInfoProto(CloneAppViewInfoOracle oracleAppViewRestoreInfo = default(CloneAppViewInfoOracle))
        {
            this.OracleAppViewRestoreInfo = oracleAppViewRestoreInfo;
        }
        
        /// <summary>
        /// Gets or Sets OracleAppViewRestoreInfo
        /// </summary>
        [DataMember(Name="oracleAppViewRestoreInfo", EmitDefaultValue=false)]
        public CloneAppViewInfoOracle OracleAppViewRestoreInfo { get; set; }

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
            return this.Equals(input as CloneAppViewInfoProto);
        }

        /// <summary>
        /// Returns true if CloneAppViewInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneAppViewInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneAppViewInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OracleAppViewRestoreInfo == input.OracleAppViewRestoreInfo ||
                    (this.OracleAppViewRestoreInfo != null &&
                    this.OracleAppViewRestoreInfo.Equals(input.OracleAppViewRestoreInfo))
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
                if (this.OracleAppViewRestoreInfo != null)
                    hashCode = hashCode * 59 + this.OracleAppViewRestoreInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

