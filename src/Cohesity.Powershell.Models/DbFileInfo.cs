// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// DbFileInfo
    /// </summary>
    [DataContract]
    public partial class DbFileInfo :  IEquatable<DbFileInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbFileInfo" /> class.
        /// </summary>
        /// <param name="fullPath">Specifies the full path of the database file on the SQL host machine..</param>
        /// <param name="sizeBytes">Specifies the last known size of the database file..</param>
        public DbFileInfo(string fullPath = default(string), long? sizeBytes = default(long?))
        {
            this.FullPath = fullPath;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Specifies the full path of the database file on the SQL host machine.
        /// </summary>
        /// <value>Specifies the full path of the database file on the SQL host machine.</value>
        [DataMember(Name="fullPath", EmitDefaultValue=false)]
        public string FullPath { get; set; }

        /// <summary>
        /// Specifies the last known size of the database file.
        /// </summary>
        /// <value>Specifies the last known size of the database file.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as DbFileInfo);
        }

        /// <summary>
        /// Returns true if DbFileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DbFileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DbFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
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
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

