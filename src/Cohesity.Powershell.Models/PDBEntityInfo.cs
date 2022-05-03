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
    /// PDBEntityInfo
    /// </summary>
    [DataContract]
    public partial class PDBEntityInfo :  IEquatable<PDBEntityInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDBEntityInfo" /> class.
        /// </summary>
        /// <param name="dbId">Pluggable database identifier..</param>
        /// <param name="name">Name of the DB..</param>
        /// <param name="openMode">PDB open mode..</param>
        /// <param name="sizeBytes">Size in bytes..</param>
        public PDBEntityInfo(string dbId = default(string), string name = default(string), int? openMode = default(int?), long? sizeBytes = default(long?))
        {
            this.DbId = dbId;
            this.Name = name;
            this.OpenMode = openMode;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Pluggable database identifier.
        /// </summary>
        /// <value>Pluggable database identifier.</value>
        [DataMember(Name="dbId", EmitDefaultValue=false)]
        public string DbId { get; set; }

        /// <summary>
        /// Name of the DB.
        /// </summary>
        /// <value>Name of the DB.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// PDB open mode.
        /// </summary>
        /// <value>PDB open mode.</value>
        [DataMember(Name="openMode", EmitDefaultValue=false)]
        public int? OpenMode { get; set; }

        /// <summary>
        /// Size in bytes.
        /// </summary>
        /// <value>Size in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as PDBEntityInfo);
        }

        /// <summary>
        /// Returns true if PDBEntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PDBEntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDBEntityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbId == input.DbId ||
                    (this.DbId != null &&
                    this.DbId.Equals(input.DbId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenMode == input.OpenMode ||
                    (this.OpenMode != null &&
                    this.OpenMode.Equals(input.OpenMode))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                if (this.DbId != null)
                    hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenMode != null)
                    hashCode = hashCode * 59 + this.OpenMode.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

