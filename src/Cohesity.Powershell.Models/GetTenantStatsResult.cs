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
    /// GetTenantStatsResult is the result of get tenantStats api.
    /// </summary>
    [DataContract]
    public partial class GetTenantStatsResult :  IEquatable<GetTenantStatsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTenantStatsResult" /> class.
        /// </summary>
        /// <param name="cookie">Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens..</param>
        /// <param name="statsList">Specifies a list of tenant stats..</param>
        public GetTenantStatsResult(string cookie = default(string), List<TenantStats> statsList = default(List<TenantStats>))
        {
            this.Cookie = cookie;
            this.StatsList = statsList;
            this.Cookie = cookie;
            this.StatsList = statsList;
        }
        
        /// <summary>
        /// Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.
        /// </summary>
        /// <value>Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.</value>
        [DataMember(Name="cookie", EmitDefaultValue=true)]
        public string Cookie { get; set; }

        /// <summary>
        /// Specifies a list of tenant stats.
        /// </summary>
        /// <value>Specifies a list of tenant stats.</value>
        [DataMember(Name="statsList", EmitDefaultValue=true)]
        public List<TenantStats> StatsList { get; set; }

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
            return this.Equals(input as GetTenantStatsResult);
        }

        /// <summary>
        /// Returns true if GetTenantStatsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTenantStatsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTenantStatsResult input)
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
                    input.StatsList != null &&
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

