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
    /// CDBEntityInfo
    /// </summary>
    [DataContract]
    public partial class CDBEntityInfo :  IEquatable<CDBEntityInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CDBEntityInfo" /> class.
        /// </summary>
        /// <param name="pdbEntityInfoVec">Repeated field of pdb entity information for a given CDB. This structure is used to retrieve the information about all the pdbs inside a given db..</param>
        public CDBEntityInfo(List<PDBEntityInfo> pdbEntityInfoVec = default(List<PDBEntityInfo>))
        {
            this.PdbEntityInfoVec = pdbEntityInfoVec;
            this.PdbEntityInfoVec = pdbEntityInfoVec;
        }
        
        /// <summary>
        /// Repeated field of pdb entity information for a given CDB. This structure is used to retrieve the information about all the pdbs inside a given db.
        /// </summary>
        /// <value>Repeated field of pdb entity information for a given CDB. This structure is used to retrieve the information about all the pdbs inside a given db.</value>
        [DataMember(Name="pdbEntityInfoVec", EmitDefaultValue=true)]
        public List<PDBEntityInfo> PdbEntityInfoVec { get; set; }

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
            return this.Equals(input as CDBEntityInfo);
        }

        /// <summary>
        /// Returns true if CDBEntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CDBEntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CDBEntityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PdbEntityInfoVec == input.PdbEntityInfoVec ||
                    this.PdbEntityInfoVec != null &&
                    input.PdbEntityInfoVec != null &&
                    this.PdbEntityInfoVec.SequenceEqual(input.PdbEntityInfoVec)
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
                if (this.PdbEntityInfoVec != null)
                    hashCode = hashCode * 59 + this.PdbEntityInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

