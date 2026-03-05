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
    /// Specifies an Object containing information about a Cassandra Table.
    /// </summary>
    [DataContract]
    public partial class CassandraTable :  IEquatable<CassandraTable>
    {
        /// <summary>
        /// Specifies Type of Table. Specifies the type of an Cassandra table entity.
        /// </summary>
        /// <value>Specifies Type of Table. Specifies the type of an Cassandra table entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 1,

            /// <summary>
            /// Enum KGraph for value: kGraph
            /// </summary>
            [EnumMember(Value = "kGraph")]
            KGraph = 2,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 3

        }

        /// <summary>
        /// Specifies Type of Table. Specifies the type of an Cassandra table entity.
        /// </summary>
        /// <value>Specifies Type of Table. Specifies the type of an Cassandra table entity.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraTable" /> class.
        /// </summary>
        /// <param name="type">Specifies Type of Table. Specifies the type of an Cassandra table entity..</param>
        public CassandraTable(TypeEnum? type = default(TypeEnum?))
        {
            this.Type = type;
            this.Type = type;
        }
        
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
            return this.Equals(input as CassandraTable);
        }

        /// <summary>
        /// Returns true if CassandraTable instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraTable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

