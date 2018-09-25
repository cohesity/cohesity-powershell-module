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
    /// Specifies a unique id for a SQL Protection Source.
    /// </summary>
    [DataContract]
    public partial class SqlSourceId :  IEquatable<SqlSourceId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlSourceId" /> class.
        /// </summary>
        /// <param name="createdDateMsecs">Specifies a unique identifier generated from the date the database is created or renamed. Cohesity uses this identifier in combination with the databaseId to uniquely identify a database..</param>
        /// <param name="databaseId">Specifies a unique id of the database but only for the life of the database. SQL Server may reuse database ids. Cohesity uses the createDateMsecs in combination with this databaseId to uniquely identify a database..</param>
        /// <param name="instanceId">Specifies unique id for the SQL Server instance. This id does not change during the life of the instance..</param>
        public SqlSourceId(long? createdDateMsecs = default(long?), long? databaseId = default(long?), List<int?> instanceId = default(List<int?>))
        {
            this.CreatedDateMsecs = createdDateMsecs;
            this.DatabaseId = databaseId;
            this.InstanceId = instanceId;
        }
        
        /// <summary>
        /// Specifies a unique identifier generated from the date the database is created or renamed. Cohesity uses this identifier in combination with the databaseId to uniquely identify a database.
        /// </summary>
        /// <value>Specifies a unique identifier generated from the date the database is created or renamed. Cohesity uses this identifier in combination with the databaseId to uniquely identify a database.</value>
        [DataMember(Name="createdDateMsecs", EmitDefaultValue=false)]
        public long? CreatedDateMsecs { get; set; }

        /// <summary>
        /// Specifies a unique id of the database but only for the life of the database. SQL Server may reuse database ids. Cohesity uses the createDateMsecs in combination with this databaseId to uniquely identify a database.
        /// </summary>
        /// <value>Specifies a unique id of the database but only for the life of the database. SQL Server may reuse database ids. Cohesity uses the createDateMsecs in combination with this databaseId to uniquely identify a database.</value>
        [DataMember(Name="databaseId", EmitDefaultValue=false)]
        public long? DatabaseId { get; set; }

        /// <summary>
        /// Specifies unique id for the SQL Server instance. This id does not change during the life of the instance.
        /// </summary>
        /// <value>Specifies unique id for the SQL Server instance. This id does not change during the life of the instance.</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public List<int?> InstanceId { get; set; }

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
            return this.Equals(input as SqlSourceId);
        }

        /// <summary>
        /// Returns true if SqlSourceId instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlSourceId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlSourceId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedDateMsecs == input.CreatedDateMsecs ||
                    (this.CreatedDateMsecs != null &&
                    this.CreatedDateMsecs.Equals(input.CreatedDateMsecs))
                ) && 
                (
                    this.DatabaseId == input.DatabaseId ||
                    (this.DatabaseId != null &&
                    this.DatabaseId.Equals(input.DatabaseId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    this.InstanceId != null &&
                    this.InstanceId.SequenceEqual(input.InstanceId)
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
                if (this.CreatedDateMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedDateMsecs.GetHashCode();
                if (this.DatabaseId != null)
                    hashCode = hashCode * 59 + this.DatabaseId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

