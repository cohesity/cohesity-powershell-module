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
    /// Apply an existing Resolution to a new list of Alerts, which are specified by Alert Ids.
    /// </summary>
    [DataContract]
    public partial class UpdateResolutionParams :  IEquatable<UpdateResolutionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResolutionParams" /> class.
        /// </summary>
        /// <param name="alertIdList">Specifies the Alerts to resolve, which are specified by Alert Ids..</param>
        public UpdateResolutionParams(List<string> alertIdList = default(List<string>))
        {
            this.AlertIdList = alertIdList;
        }
        
        /// <summary>
        /// Specifies the Alerts to resolve, which are specified by Alert Ids.
        /// </summary>
        /// <value>Specifies the Alerts to resolve, which are specified by Alert Ids.</value>
        [DataMember(Name="alertIdList", EmitDefaultValue=false)]
        public List<string> AlertIdList { get; set; }

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
            return this.Equals(input as UpdateResolutionParams);
        }

        /// <summary>
        /// Returns true if UpdateResolutionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateResolutionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateResolutionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertIdList == input.AlertIdList ||
                    this.AlertIdList != null &&
                    this.AlertIdList.SequenceEqual(input.AlertIdList)
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
                if (this.AlertIdList != null)
                    hashCode = hashCode * 59 + this.AlertIdList.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

