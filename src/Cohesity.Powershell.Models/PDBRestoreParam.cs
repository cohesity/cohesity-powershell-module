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
    /// PDBRestoreParam
    /// </summary>
    [DataContract]
    public partial class PDBRestoreParam :  IEquatable<PDBRestoreParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDBRestoreParam" /> class.
        /// </summary>
        /// <param name="dropPdbsIfExists">During the restore workflow, drop the pdb if the same name pdb exists..</param>
        /// <param name="existingCdb">Restore given list of pdbs to an existing CDB..</param>
        /// <param name="pdbEntityInfoVec">pdbEntityInfoVec.</param>
        /// <param name="renamePdbMap">If rename pdb is provided, list of new names for the pdb..</param>
        public PDBRestoreParam(bool? dropPdbsIfExists = default(bool?), bool? existingCdb = default(bool?), CDBEntityInfo pdbEntityInfoVec = default(CDBEntityInfo), List<PDBRestoreParamRenamePdbMapEntry> renamePdbMap = default(List<PDBRestoreParamRenamePdbMapEntry>))
        {
            this.DropPdbsIfExists = dropPdbsIfExists;
            this.ExistingCdb = existingCdb;
            this.RenamePdbMap = renamePdbMap;
            this.DropPdbsIfExists = dropPdbsIfExists;
            this.ExistingCdb = existingCdb;
            this.PdbEntityInfoVec = pdbEntityInfoVec;
            this.RenamePdbMap = renamePdbMap;
        }
        
        /// <summary>
        /// During the restore workflow, drop the pdb if the same name pdb exists.
        /// </summary>
        /// <value>During the restore workflow, drop the pdb if the same name pdb exists.</value>
        [DataMember(Name="dropPdbsIfExists", EmitDefaultValue=true)]
        public bool? DropPdbsIfExists { get; set; }

        /// <summary>
        /// Restore given list of pdbs to an existing CDB.
        /// </summary>
        /// <value>Restore given list of pdbs to an existing CDB.</value>
        [DataMember(Name="existingCdb", EmitDefaultValue=true)]
        public bool? ExistingCdb { get; set; }

        /// <summary>
        /// Gets or Sets PdbEntityInfoVec
        /// </summary>
        [DataMember(Name="pdbEntityInfoVec", EmitDefaultValue=false)]
        public CDBEntityInfo PdbEntityInfoVec { get; set; }

        /// <summary>
        /// If rename pdb is provided, list of new names for the pdb.
        /// </summary>
        /// <value>If rename pdb is provided, list of new names for the pdb.</value>
        [DataMember(Name="renamePdbMap", EmitDefaultValue=true)]
        public List<PDBRestoreParamRenamePdbMapEntry> RenamePdbMap { get; set; }

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
            return this.Equals(input as PDBRestoreParam);
        }

        /// <summary>
        /// Returns true if PDBRestoreParam instances are equal
        /// </summary>
        /// <param name="input">Instance of PDBRestoreParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDBRestoreParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DropPdbsIfExists == input.DropPdbsIfExists ||
                    (this.DropPdbsIfExists != null &&
                    this.DropPdbsIfExists.Equals(input.DropPdbsIfExists))
                ) && 
                (
                    this.ExistingCdb == input.ExistingCdb ||
                    (this.ExistingCdb != null &&
                    this.ExistingCdb.Equals(input.ExistingCdb))
                ) && 
                (
                    this.PdbEntityInfoVec == input.PdbEntityInfoVec ||
                    (this.PdbEntityInfoVec != null &&
                    this.PdbEntityInfoVec.Equals(input.PdbEntityInfoVec))
                ) && 
                (
                    this.RenamePdbMap == input.RenamePdbMap ||
                    this.RenamePdbMap != null &&
                    input.RenamePdbMap != null &&
                    this.RenamePdbMap.Equals(input.RenamePdbMap)
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
                if (this.DropPdbsIfExists != null)
                    hashCode = hashCode * 59 + this.DropPdbsIfExists.GetHashCode();
                if (this.ExistingCdb != null)
                    hashCode = hashCode * 59 + this.ExistingCdb.GetHashCode();
                if (this.PdbEntityInfoVec != null)
                    hashCode = hashCode * 59 + this.PdbEntityInfoVec.GetHashCode();
                if (this.RenamePdbMap != null)
                    hashCode = hashCode * 59 + this.RenamePdbMap.GetHashCode();
                return hashCode;
            }
        }

    }

}

