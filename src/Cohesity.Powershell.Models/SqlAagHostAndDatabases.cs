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
    /// Specifies AAGs and databases information on an SQL server. If AAGs exist on the server, specifies information about the AAG and databases in the group for each AAG found on the server.
    /// </summary>
    [DataContract]
    public partial class SqlAagHostAndDatabases :  IEquatable<SqlAagHostAndDatabases>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlAagHostAndDatabases" /> class.
        /// </summary>
        /// <param name="aagDatabases">Specifies a list of AAGs and database members in each AAG..</param>
        /// <param name="applicationNode">applicationNode.</param>
        /// <param name="databases">Specifies all database entities found on the server. Database may or may not be in an AAG..</param>
        /// <param name="errorMessage">Specifies an error message when the host is not registered as an SQL host..</param>
        /// <param name="unknownHostName">Specifies the name of the host that is not registered as an SQL server on Cohesity Cluser..</param>
        public SqlAagHostAndDatabases(List<AagAndDatabases> aagDatabases = default(List<AagAndDatabases>), ProtectionSourceNode applicationNode = default(ProtectionSourceNode), List<ProtectionSource> databases = default(List<ProtectionSource>), string errorMessage = default(string), string unknownHostName = default(string))
        {
            this.AagDatabases = aagDatabases;
            this.ApplicationNode = applicationNode;
            this.Databases = databases;
            this.ErrorMessage = errorMessage;
            this.UnknownHostName = unknownHostName;
        }
        
        /// <summary>
        /// Specifies a list of AAGs and database members in each AAG.
        /// </summary>
        /// <value>Specifies a list of AAGs and database members in each AAG.</value>
        [DataMember(Name="aagDatabases", EmitDefaultValue=true)]
        public List<AagAndDatabases> AagDatabases { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationNode
        /// </summary>
        [DataMember(Name="applicationNode", EmitDefaultValue=false)]
        public ProtectionSourceNode ApplicationNode { get; set; }

        /// <summary>
        /// Specifies all database entities found on the server. Database may or may not be in an AAG.
        /// </summary>
        /// <value>Specifies all database entities found on the server. Database may or may not be in an AAG.</value>
        [DataMember(Name="databases", EmitDefaultValue=true)]
        public List<ProtectionSource> Databases { get; set; }

        /// <summary>
        /// Specifies an error message when the host is not registered as an SQL host.
        /// </summary>
        /// <value>Specifies an error message when the host is not registered as an SQL host.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the name of the host that is not registered as an SQL server on Cohesity Cluser.
        /// </summary>
        /// <value>Specifies the name of the host that is not registered as an SQL server on Cohesity Cluser.</value>
        [DataMember(Name="unknownHostName", EmitDefaultValue=true)]
        public string UnknownHostName { get; set; }

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
            return this.Equals(input as SqlAagHostAndDatabases);
        }

        /// <summary>
        /// Returns true if SqlAagHostAndDatabases instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlAagHostAndDatabases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlAagHostAndDatabases input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AagDatabases == input.AagDatabases ||
                    this.AagDatabases != null &&
                    input.AagDatabases != null &&
                    this.AagDatabases.Equals(input.AagDatabases)
                ) && 
                (
                    this.ApplicationNode == input.ApplicationNode ||
                    (this.ApplicationNode != null &&
                    this.ApplicationNode.Equals(input.ApplicationNode))
                ) && 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.Equals(input.Databases)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.UnknownHostName == input.UnknownHostName ||
                    (this.UnknownHostName != null &&
                    this.UnknownHostName.Equals(input.UnknownHostName))
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
                if (this.AagDatabases != null)
                    hashCode = hashCode * 59 + this.AagDatabases.GetHashCode();
                if (this.ApplicationNode != null)
                    hashCode = hashCode * 59 + this.ApplicationNode.GetHashCode();
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.UnknownHostName != null)
                    hashCode = hashCode * 59 + this.UnknownHostName.GetHashCode();
                return hashCode;
            }
        }

    }

}

