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
    /// Currently used for pdb restore. Extend the structure for table/datafile or any other restore.
    /// </summary>
    [DataContract]
    public partial class GranularRestoreInfo :  IEquatable<GranularRestoreInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GranularRestoreInfo" /> class.
        /// </summary>
        /// <param name="granularityType">Type of granular restore..</param>
        /// <param name="pdbRestoreParams">pdbRestoreParams.</param>
        public GranularRestoreInfo(int? granularityType = default(int?), PDBRestoreParam pdbRestoreParams = default(PDBRestoreParam))
        {
            this.GranularityType = granularityType;
            this.GranularityType = granularityType;
            this.PdbRestoreParams = pdbRestoreParams;
        }
        
        /// <summary>
        /// Type of granular restore.
        /// </summary>
        /// <value>Type of granular restore.</value>
        [DataMember(Name="granularityType", EmitDefaultValue=true)]
        public int? GranularityType { get; set; }

        /// <summary>
        /// Gets or Sets PdbRestoreParams
        /// </summary>
        [DataMember(Name="pdbRestoreParams", EmitDefaultValue=false)]
        public PDBRestoreParam PdbRestoreParams { get; set; }

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
            return this.Equals(input as GranularRestoreInfo);
        }

        /// <summary>
        /// Returns true if GranularRestoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GranularRestoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GranularRestoreInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GranularityType == input.GranularityType ||
                    (this.GranularityType != null &&
                    this.GranularityType.Equals(input.GranularityType))
                ) && 
                (
                    this.PdbRestoreParams == input.PdbRestoreParams ||
                    (this.PdbRestoreParams != null &&
                    this.PdbRestoreParams.Equals(input.PdbRestoreParams))
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
                if (this.GranularityType != null)
                    hashCode = hashCode * 59 + this.GranularityType.GetHashCode();
                if (this.PdbRestoreParams != null)
                    hashCode = hashCode * 59 + this.PdbRestoreParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

