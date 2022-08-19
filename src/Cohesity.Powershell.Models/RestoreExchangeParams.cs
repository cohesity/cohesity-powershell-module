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
    /// RestoreExchangeParams
    /// </summary>
    [DataContract]
    public partial class RestoreExchangeParams :  IEquatable<RestoreExchangeParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreExchangeParams" /> class.
        /// </summary>
        /// <param name="databaseOptions">databaseOptions.</param>
        /// <param name="type">Restore type..</param>
        /// <param name="viewOptions">viewOptions.</param>
        public RestoreExchangeParams(RestoreExchangeParamsDatabaseOptions databaseOptions = default(RestoreExchangeParamsDatabaseOptions), int? type = default(int?), RestoreExchangeParamsViewOptions viewOptions = default(RestoreExchangeParamsViewOptions))
        {
            this.Type = type;
            this.DatabaseOptions = databaseOptions;
            this.Type = type;
            this.ViewOptions = viewOptions;
        }
        
        /// <summary>
        /// Gets or Sets DatabaseOptions
        /// </summary>
        [DataMember(Name="databaseOptions", EmitDefaultValue=false)]
        public RestoreExchangeParamsDatabaseOptions DatabaseOptions { get; set; }

        /// <summary>
        /// Restore type.
        /// </summary>
        /// <value>Restore type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets ViewOptions
        /// </summary>
        [DataMember(Name="viewOptions", EmitDefaultValue=false)]
        public RestoreExchangeParamsViewOptions ViewOptions { get; set; }

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
            return this.Equals(input as RestoreExchangeParams);
        }

        /// <summary>
        /// Returns true if RestoreExchangeParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreExchangeParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreExchangeParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseOptions == input.DatabaseOptions ||
                    (this.DatabaseOptions != null &&
                    this.DatabaseOptions.Equals(input.DatabaseOptions))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ViewOptions == input.ViewOptions ||
                    (this.ViewOptions != null &&
                    this.ViewOptions.Equals(input.ViewOptions))
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
                if (this.DatabaseOptions != null)
                    hashCode = hashCode * 59 + this.DatabaseOptions.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewOptions != null)
                    hashCode = hashCode * 59 + this.ViewOptions.GetHashCode();
                return hashCode;
            }
        }

    }

}

