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
    /// GetViewBoxStatsResult is the result of get viewBoxStats api.
    /// </summary>
    [DataContract]
    public partial class GetViewBoxStatsResult :  IEquatable<GetViewBoxStatsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewBoxStatsResult" /> class.
        /// </summary>
        /// <param name="statsList">Specifies a list of view box stats..</param>
        public GetViewBoxStatsResult(List<StorageDomainStats> statsList = default(List<StorageDomainStats>))
        {
            this.StatsList = statsList;
        }
        
        /// <summary>
        /// Specifies a list of view box stats.
        /// </summary>
        /// <value>Specifies a list of view box stats.</value>
        [DataMember(Name="statsList", EmitDefaultValue=false)]
        public List<StorageDomainStats> StatsList { get; set; }

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
            return this.Equals(input as GetViewBoxStatsResult);
        }

        /// <summary>
        /// Returns true if GetViewBoxStatsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetViewBoxStatsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetViewBoxStatsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatsList == input.StatsList ||
                    this.StatsList != null &&
                    this.StatsList.Equals(input.StatsList)
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
                if (this.StatsList != null)
                    hashCode = hashCode * 59 + this.StatsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

