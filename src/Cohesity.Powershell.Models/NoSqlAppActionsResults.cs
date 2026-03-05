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
    /// Specifies the results for performing various action on NoSQL app instance.
    /// </summary>
    [DataContract]
    public partial class NoSqlAppActionsResults :  IEquatable<NoSqlAppActionsResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlAppActionsResults" /> class.
        /// </summary>
        /// <param name="listConfigResult">listConfigResult.</param>
        /// <param name="refreshConfigResult">refreshConfigResult.</param>
        /// <param name="restartServiceResult">restartServiceResult.</param>
        public NoSqlAppActionsResults(ListConfigResult listConfigResult = default(ListConfigResult), RefreshConfigResult refreshConfigResult = default(RefreshConfigResult), RestartServiceResult restartServiceResult = default(RestartServiceResult))
        {
            this.ListConfigResult = listConfigResult;
            this.RefreshConfigResult = refreshConfigResult;
            this.RestartServiceResult = restartServiceResult;
        }
        
        /// <summary>
        /// Gets or Sets ListConfigResult
        /// </summary>
        [DataMember(Name="listConfigResult", EmitDefaultValue=false)]
        public ListConfigResult ListConfigResult { get; set; }

        /// <summary>
        /// Gets or Sets RefreshConfigResult
        /// </summary>
        [DataMember(Name="refreshConfigResult", EmitDefaultValue=false)]
        public RefreshConfigResult RefreshConfigResult { get; set; }

        /// <summary>
        /// Gets or Sets RestartServiceResult
        /// </summary>
        [DataMember(Name="restartServiceResult", EmitDefaultValue=false)]
        public RestartServiceResult RestartServiceResult { get; set; }

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
            return this.Equals(input as NoSqlAppActionsResults);
        }

        /// <summary>
        /// Returns true if NoSqlAppActionsResults instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlAppActionsResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlAppActionsResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListConfigResult == input.ListConfigResult ||
                    (this.ListConfigResult != null &&
                    this.ListConfigResult.Equals(input.ListConfigResult))
                ) && 
                (
                    this.RefreshConfigResult == input.RefreshConfigResult ||
                    (this.RefreshConfigResult != null &&
                    this.RefreshConfigResult.Equals(input.RefreshConfigResult))
                ) && 
                (
                    this.RestartServiceResult == input.RestartServiceResult ||
                    (this.RestartServiceResult != null &&
                    this.RestartServiceResult.Equals(input.RestartServiceResult))
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
                if (this.ListConfigResult != null)
                    hashCode = hashCode * 59 + this.ListConfigResult.GetHashCode();
                if (this.RefreshConfigResult != null)
                    hashCode = hashCode * 59 + this.RefreshConfigResult.GetHashCode();
                if (this.RestartServiceResult != null)
                    hashCode = hashCode * 59 + this.RestartServiceResult.GetHashCode();
                return hashCode;
            }
        }

    }

}

