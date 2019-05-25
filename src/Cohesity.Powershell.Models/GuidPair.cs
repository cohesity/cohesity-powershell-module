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
    /// Represents the guid pair of an AD Object.
    /// </summary>
    [DataContract]
    public partial class GuidPair :  IEquatable<GuidPair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidPair" /> class.
        /// </summary>
        /// <param name="destGuid">Specifies the guid of an AD object in the Production AD..</param>
        /// <param name="sourceGuid">Specifies the guid of an AD object in the Snapshot AD..</param>
        public GuidPair(string destGuid = default(string), string sourceGuid = default(string))
        {
            this.DestGuid = destGuid;
            this.SourceGuid = sourceGuid;
            this.DestGuid = destGuid;
            this.SourceGuid = sourceGuid;
        }
        
        /// <summary>
        /// Specifies the guid of an AD object in the Production AD.
        /// </summary>
        /// <value>Specifies the guid of an AD object in the Production AD.</value>
        [DataMember(Name="destGuid", EmitDefaultValue=true)]
        public string DestGuid { get; set; }

        /// <summary>
        /// Specifies the guid of an AD object in the Snapshot AD.
        /// </summary>
        /// <value>Specifies the guid of an AD object in the Snapshot AD.</value>
        [DataMember(Name="sourceGuid", EmitDefaultValue=true)]
        public string SourceGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuidPair {\n");
            sb.Append("  DestGuid: ").Append(DestGuid).Append("\n");
            sb.Append("  SourceGuid: ").Append(SourceGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as GuidPair);
        }

        /// <summary>
        /// Returns true if GuidPair instances are equal
        /// </summary>
        /// <param name="input">Instance of GuidPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuidPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestGuid == input.DestGuid ||
                    (this.DestGuid != null &&
                    this.DestGuid.Equals(input.DestGuid))
                ) && 
                (
                    this.SourceGuid == input.SourceGuid ||
                    (this.SourceGuid != null &&
                    this.SourceGuid.Equals(input.SourceGuid))
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
                if (this.DestGuid != null)
                    hashCode = hashCode * 59 + this.DestGuid.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                return hashCode;
            }
        }

    }

}
