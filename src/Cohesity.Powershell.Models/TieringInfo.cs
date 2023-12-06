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
    /// TieringInfo
    /// </summary>
    [DataContract]
    public partial class TieringInfo :  IEquatable<TieringInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TieringInfo" /> class.
        /// </summary>
        /// <param name="backendTiering">Specifies whether back-end tiering is enabled..</param>
        /// <param name="frontendTiering">Specifies whether Front End Tiering Enabled.</param>
        /// <param name="maxRetention">Specified the max retention for backup policy creation..</param>
        public TieringInfo(bool? backendTiering = default(bool?), bool? frontendTiering = default(bool?), long? maxRetention = default(long?))
        {
            this.BackendTiering = backendTiering;
            this.FrontendTiering = frontendTiering;
            this.MaxRetention = maxRetention;
            this.BackendTiering = backendTiering;
            this.FrontendTiering = frontendTiering;
            this.MaxRetention = maxRetention;
        }
        
        /// <summary>
        /// Specifies whether back-end tiering is enabled.
        /// </summary>
        /// <value>Specifies whether back-end tiering is enabled.</value>
        [DataMember(Name="backendTiering", EmitDefaultValue=true)]
        public bool? BackendTiering { get; set; }

        /// <summary>
        /// Specifies whether Front End Tiering Enabled
        /// </summary>
        /// <value>Specifies whether Front End Tiering Enabled</value>
        [DataMember(Name="frontendTiering", EmitDefaultValue=true)]
        public bool? FrontendTiering { get; set; }

        /// <summary>
        /// Specified the max retention for backup policy creation.
        /// </summary>
        /// <value>Specified the max retention for backup policy creation.</value>
        [DataMember(Name="maxRetention", EmitDefaultValue=true)]
        public long? MaxRetention { get; set; }

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
            return this.Equals(input as TieringInfo);
        }

        /// <summary>
        /// Returns true if TieringInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TieringInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TieringInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackendTiering == input.BackendTiering ||
                    (this.BackendTiering != null &&
                    this.BackendTiering.Equals(input.BackendTiering))
                ) && 
                (
                    this.FrontendTiering == input.FrontendTiering ||
                    (this.FrontendTiering != null &&
                    this.FrontendTiering.Equals(input.FrontendTiering))
                ) && 
                (
                    this.MaxRetention == input.MaxRetention ||
                    (this.MaxRetention != null &&
                    this.MaxRetention.Equals(input.MaxRetention))
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
                if (this.BackendTiering != null)
                    hashCode = hashCode * 59 + this.BackendTiering.GetHashCode();
                if (this.FrontendTiering != null)
                    hashCode = hashCode * 59 + this.FrontendTiering.GetHashCode();
                if (this.MaxRetention != null)
                    hashCode = hashCode * 59 + this.MaxRetention.GetHashCode();
                return hashCode;
            }
        }

    }

}

