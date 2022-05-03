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
    /// GetConsumerStatsResult is the result of get consumerStats api.
    /// </summary>
    [DataContract]
    public partial class GetConsumerStatsResult :  IEquatable<GetConsumerStatsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetConsumerStatsResult" /> class.
        /// </summary>
        /// <param name="cookie">Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens..</param>
        /// <param name="statsList">Specifies a list of consumer stats..</param>
        public GetConsumerStatsResult(string cookie = default(string), List<ConsumerStats> statsList = default(List<ConsumerStats>))
        {
            this.Cookie = cookie;
            this.StatsList = statsList;
        }
        
        /// <summary>
        /// Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.
        /// </summary>
        /// <value>Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.</value>
        [DataMember(Name="cookie", EmitDefaultValue=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// Specifies a list of consumer stats.
        /// </summary>
        /// <value>Specifies a list of consumer stats.</value>
        [DataMember(Name="statsList", EmitDefaultValue=false)]
        public List<ConsumerStats> StatsList { get; set; }

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
            return this.Equals(input as GetConsumerStatsResult);
        }

        /// <summary>
        /// Returns true if GetConsumerStatsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetConsumerStatsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetConsumerStatsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
                ) && 
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
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                if (this.StatsList != null)
                    hashCode = hashCode * 59 + this.StatsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

