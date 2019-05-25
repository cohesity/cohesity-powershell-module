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
    /// Specifies the legal holding of a Protection Source.
    /// </summary>
    [DataContract]
    public partial class LegalHoldings :  IEquatable<LegalHoldings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalHoldings" /> class.
        /// </summary>
        /// <param name="holdForLegalPurpose">Specifies whether the source is put on legal hold or not..</param>
        /// <param name="protectionSourceId">Specifies an Protection Source Id in the snapshot..</param>
        public LegalHoldings(bool? holdForLegalPurpose = default(bool?), long? protectionSourceId = default(long?))
        {
            this.HoldForLegalPurpose = holdForLegalPurpose;
            this.ProtectionSourceId = protectionSourceId;
            this.HoldForLegalPurpose = holdForLegalPurpose;
            this.ProtectionSourceId = protectionSourceId;
        }
        
        /// <summary>
        /// Specifies whether the source is put on legal hold or not.
        /// </summary>
        /// <value>Specifies whether the source is put on legal hold or not.</value>
        [DataMember(Name="holdForLegalPurpose", EmitDefaultValue=true)]
        public bool? HoldForLegalPurpose { get; set; }

        /// <summary>
        /// Specifies an Protection Source Id in the snapshot.
        /// </summary>
        /// <value>Specifies an Protection Source Id in the snapshot.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=true)]
        public long? ProtectionSourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalHoldings {\n");
            sb.Append("  HoldForLegalPurpose: ").Append(HoldForLegalPurpose).Append("\n");
            sb.Append("  ProtectionSourceId: ").Append(ProtectionSourceId).Append("\n");
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
            return this.Equals(input as LegalHoldings);
        }

        /// <summary>
        /// Returns true if LegalHoldings instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalHoldings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalHoldings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HoldForLegalPurpose == input.HoldForLegalPurpose ||
                    (this.HoldForLegalPurpose != null &&
                    this.HoldForLegalPurpose.Equals(input.HoldForLegalPurpose))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
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
                if (this.HoldForLegalPurpose != null)
                    hashCode = hashCode * 59 + this.HoldForLegalPurpose.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}
