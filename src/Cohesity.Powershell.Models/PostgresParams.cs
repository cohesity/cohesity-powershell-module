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
    /// PostgresParams
    /// </summary>
    [DataContract]
    public partial class PostgresParams :  IEquatable<PostgresParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresParams" /> class.
        /// </summary>
        /// <param name="tablespaces">Tablespaces information (used by PostgreSQL).</param>
        public PostgresParams(List<string> tablespaces = default(List<string>))
        {
            this.Tablespaces = tablespaces;
            this.Tablespaces = tablespaces;
        }
        
        /// <summary>
        /// Tablespaces information (used by PostgreSQL)
        /// </summary>
        /// <value>Tablespaces information (used by PostgreSQL)</value>
        [DataMember(Name="tablespaces", EmitDefaultValue=true)]
        public List<string> Tablespaces { get; set; }

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
            return this.Equals(input as PostgresParams);
        }

        /// <summary>
        /// Returns true if PostgresParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PostgresParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostgresParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tablespaces == input.Tablespaces ||
                    this.Tablespaces != null &&
                    input.Tablespaces != null &&
                    this.Tablespaces.SequenceEqual(input.Tablespaces)
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
                if (this.Tablespaces != null)
                    hashCode = hashCode * 59 + this.Tablespaces.GetHashCode();
                return hashCode;
            }
        }

    }

}

