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
    /// UptieringRunOnceParams
    /// </summary>
    [DataContract]
    public partial class UptieringRunOnceParams :  IEquatable<UptieringRunOnceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UptieringRunOnceParams" /> class.
        /// </summary>
        /// <param name="uptierPath">Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything..</param>
        /// <param name="useEntityIdForUptierRange">Flag to determine whether entity id is used for uptier range. This is applicable only for uptier jobs. TODO: Exists to support upgrade scenario. Can be deprecated once all customers have upgraded beyond 7.0.1..</param>
        public UptieringRunOnceParams(string uptierPath = default(string), bool? useEntityIdForUptierRange = default(bool?))
        {
            this.UptierPath = uptierPath;
            this.UseEntityIdForUptierRange = useEntityIdForUptierRange;
            this.UptierPath = uptierPath;
            this.UseEntityIdForUptierRange = useEntityIdForUptierRange;
        }
        
        /// <summary>
        /// Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything.
        /// </summary>
        /// <value>Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything.</value>
        [DataMember(Name="uptierPath", EmitDefaultValue=true)]
        public string UptierPath { get; set; }

        /// <summary>
        /// Flag to determine whether entity id is used for uptier range. This is applicable only for uptier jobs. TODO: Exists to support upgrade scenario. Can be deprecated once all customers have upgraded beyond 7.0.1.
        /// </summary>
        /// <value>Flag to determine whether entity id is used for uptier range. This is applicable only for uptier jobs. TODO: Exists to support upgrade scenario. Can be deprecated once all customers have upgraded beyond 7.0.1.</value>
        [DataMember(Name="useEntityIdForUptierRange", EmitDefaultValue=true)]
        public bool? UseEntityIdForUptierRange { get; set; }

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
            return this.Equals(input as UptieringRunOnceParams);
        }

        /// <summary>
        /// Returns true if UptieringRunOnceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UptieringRunOnceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UptieringRunOnceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UptierPath == input.UptierPath ||
                    (this.UptierPath != null &&
                    this.UptierPath.Equals(input.UptierPath))
                ) && 
                (
                    this.UseEntityIdForUptierRange == input.UseEntityIdForUptierRange ||
                    (this.UseEntityIdForUptierRange != null &&
                    this.UseEntityIdForUptierRange.Equals(input.UseEntityIdForUptierRange))
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
                if (this.UptierPath != null)
                    hashCode = hashCode * 59 + this.UptierPath.GetHashCode();
                if (this.UseEntityIdForUptierRange != null)
                    hashCode = hashCode * 59 + this.UseEntityIdForUptierRange.GetHashCode();
                return hashCode;
            }
        }

    }

}

