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
    /// Message to capture additional backup/restore params for a Oracle source.
    /// </summary>
    [DataContract]
    public partial class OracleSourceParams :  IEquatable<OracleSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleSourceParams" /> class.
        /// </summary>
        /// <param name="additionalOracleDbParamsVec">Backup channel information for each Oracle database. NOTE: Size of this vector will be 1 for DG..</param>
        public OracleSourceParams(List<AdditionalOracleDBParams> additionalOracleDbParamsVec = default(List<AdditionalOracleDBParams>))
        {
            this.AdditionalOracleDbParamsVec = additionalOracleDbParamsVec;
            this.AdditionalOracleDbParamsVec = additionalOracleDbParamsVec;
        }
        
        /// <summary>
        /// Backup channel information for each Oracle database. NOTE: Size of this vector will be 1 for DG.
        /// </summary>
        /// <value>Backup channel information for each Oracle database. NOTE: Size of this vector will be 1 for DG.</value>
        [DataMember(Name="additionalOracleDbParamsVec", EmitDefaultValue=true)]
        public List<AdditionalOracleDBParams> AdditionalOracleDbParamsVec { get; set; }

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
            return this.Equals(input as OracleSourceParams);
        }

        /// <summary>
        /// Returns true if OracleSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalOracleDbParamsVec == input.AdditionalOracleDbParamsVec ||
                    this.AdditionalOracleDbParamsVec != null &&
                    input.AdditionalOracleDbParamsVec != null &&
                    this.AdditionalOracleDbParamsVec.SequenceEqual(input.AdditionalOracleDbParamsVec)
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
                if (this.AdditionalOracleDbParamsVec != null)
                    hashCode = hashCode * 59 + this.AdditionalOracleDbParamsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

