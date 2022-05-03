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
    /// Specifies the Container Database information along with the Pluggable DBs within the container. The multitenant architecture enables an Oracle database to function as a multitenant container database (CDB). A CDB includes zero, one, or many customer-created pluggable databases (PDBs).
    /// </summary>
    [DataContract]
    public partial class OracleContainerDatabaseInfo :  IEquatable<OracleContainerDatabaseInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleContainerDatabaseInfo" /> class.
        /// </summary>
        /// <param name="pluggableDatabaseInfoList">Specifies the list of Pluggable databases within this Container Database..</param>
        public OracleContainerDatabaseInfo(List<OraclePluggableDatabaseInfo> pluggableDatabaseInfoList = default(List<OraclePluggableDatabaseInfo>))
        {
            this.PluggableDatabaseInfoList = pluggableDatabaseInfoList;
        }
        
        /// <summary>
        /// Specifies the list of Pluggable databases within this Container Database.
        /// </summary>
        /// <value>Specifies the list of Pluggable databases within this Container Database.</value>
        [DataMember(Name="pluggableDatabaseInfoList", EmitDefaultValue=false)]
        public List<OraclePluggableDatabaseInfo> PluggableDatabaseInfoList { get; set; }

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
            return this.Equals(input as OracleContainerDatabaseInfo);
        }

        /// <summary>
        /// Returns true if OracleContainerDatabaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleContainerDatabaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleContainerDatabaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PluggableDatabaseInfoList == input.PluggableDatabaseInfoList ||
                    this.PluggableDatabaseInfoList != null &&
                    this.PluggableDatabaseInfoList.Equals(input.PluggableDatabaseInfoList)
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
                if (this.PluggableDatabaseInfoList != null)
                    hashCode = hashCode * 59 + this.PluggableDatabaseInfoList.GetHashCode();
                return hashCode;
            }
        }

    }

}

