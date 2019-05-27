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
    /// AdditionalOracleDBParams
    /// </summary>
    [DataContract]
    public partial class AdditionalOracleDBParams :  IEquatable<AdditionalOracleDBParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalOracleDBParams" /> class.
        /// </summary>
        /// <param name="appEntityId">Database app id..</param>
        /// <param name="dbInfoChannelVec">Contains the information for each database and the corresponding hosts configured for each. NOTE: Size of this vector will be 1 for RAC and Standalone setups..</param>
        public AdditionalOracleDBParams(long? appEntityId = default(long?), List<OracleDBChannelInfo> dbInfoChannelVec = default(List<OracleDBChannelInfo>))
        {
            this.AppEntityId = appEntityId;
            this.DbInfoChannelVec = dbInfoChannelVec;
            this.AppEntityId = appEntityId;
            this.DbInfoChannelVec = dbInfoChannelVec;
        }
        
        /// <summary>
        /// Database app id.
        /// </summary>
        /// <value>Database app id.</value>
        [DataMember(Name="appEntityId", EmitDefaultValue=true)]
        public long? AppEntityId { get; set; }

        /// <summary>
        /// Contains the information for each database and the corresponding hosts configured for each. NOTE: Size of this vector will be 1 for RAC and Standalone setups.
        /// </summary>
        /// <value>Contains the information for each database and the corresponding hosts configured for each. NOTE: Size of this vector will be 1 for RAC and Standalone setups.</value>
        [DataMember(Name="dbInfoChannelVec", EmitDefaultValue=true)]
        public List<OracleDBChannelInfo> DbInfoChannelVec { get; set; }

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
            return this.Equals(input as AdditionalOracleDBParams);
        }

        /// <summary>
        /// Returns true if AdditionalOracleDBParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalOracleDBParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalOracleDBParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppEntityId == input.AppEntityId ||
                    (this.AppEntityId != null &&
                    this.AppEntityId.Equals(input.AppEntityId))
                ) && 
                (
                    this.DbInfoChannelVec == input.DbInfoChannelVec ||
                    this.DbInfoChannelVec != null &&
                    input.DbInfoChannelVec != null &&
                    this.DbInfoChannelVec.SequenceEqual(input.DbInfoChannelVec)
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
                if (this.AppEntityId != null)
                    hashCode = hashCode * 59 + this.AppEntityId.GetHashCode();
                if (this.DbInfoChannelVec != null)
                    hashCode = hashCode * 59 + this.DbInfoChannelVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

