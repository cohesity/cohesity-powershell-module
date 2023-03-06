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
    /// Specifies the information about all the copies of the database that is part of DAG.
    /// </summary>
    [DataContract]
    public partial class ExchangeDAGDatabase :  IEquatable<ExchangeDAGDatabase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeDAGDatabase" /> class.
        /// </summary>
        /// <param name="databaseCopyInfoList">Specifies about all the copies of this DAG database. This include active and passive copy of the database..</param>
        /// <param name="guid">Specifies the guid of the database..</param>
        /// <param name="name">Specifies the name of the database..</param>
        public ExchangeDAGDatabase(List<ExchangeDatabaseCopyInfo> databaseCopyInfoList = default(List<ExchangeDatabaseCopyInfo>), string guid = default(string), string name = default(string))
        {
            this.DatabaseCopyInfoList = databaseCopyInfoList;
            this.Guid = guid;
            this.Name = name;
            this.DatabaseCopyInfoList = databaseCopyInfoList;
            this.Guid = guid;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies about all the copies of this DAG database. This include active and passive copy of the database.
        /// </summary>
        /// <value>Specifies about all the copies of this DAG database. This include active and passive copy of the database.</value>
        [DataMember(Name="databaseCopyInfoList", EmitDefaultValue=true)]
        public List<ExchangeDatabaseCopyInfo> DatabaseCopyInfoList { get; set; }

        /// <summary>
        /// Specifies the guid of the database.
        /// </summary>
        /// <value>Specifies the guid of the database.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies the name of the database.
        /// </summary>
        /// <value>Specifies the name of the database.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as ExchangeDAGDatabase);
        }

        /// <summary>
        /// Returns true if ExchangeDAGDatabase instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeDAGDatabase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeDAGDatabase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseCopyInfoList == input.DatabaseCopyInfoList ||
                    this.DatabaseCopyInfoList != null &&
                    input.DatabaseCopyInfoList != null &&
                    this.DatabaseCopyInfoList.SequenceEqual(input.DatabaseCopyInfoList)
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.DatabaseCopyInfoList != null)
                    hashCode = hashCode * 59 + this.DatabaseCopyInfoList.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

