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
    /// Specifies the parameters of a Run Now operation. A Run Now operation will try to backup the a source and/or its databases instantly.
    /// </summary>
    [DataContract]
    public partial class RunNowParameters :  IEquatable<RunNowParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunNowParameters" /> class.
        /// </summary>
        /// <param name="databaseIds">Specifies the ids of the DB&#39;s to perform run now on..</param>
        /// <param name="sourceId">Specifies the source id of the Databases to perform the Run Now operation on..</param>
        public RunNowParameters(List<long> databaseIds = default(List<long>), long? sourceId = default(long?))
        {
            this.DatabaseIds = databaseIds;
            this.SourceId = sourceId;
            this.DatabaseIds = databaseIds;
            this.SourceId = sourceId;
        }
        
        /// <summary>
        /// Specifies the ids of the DB&#39;s to perform run now on.
        /// </summary>
        /// <value>Specifies the ids of the DB&#39;s to perform run now on.</value>
        [DataMember(Name="databaseIds", EmitDefaultValue=true)]
        public List<long> DatabaseIds { get; set; }

        /// <summary>
        /// Specifies the source id of the Databases to perform the Run Now operation on.
        /// </summary>
        /// <value>Specifies the source id of the Databases to perform the Run Now operation on.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunNowParameters {\n");
            sb.Append("  DatabaseIds: ").Append(DatabaseIds).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as RunNowParameters);
        }

        /// <summary>
        /// Returns true if RunNowParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RunNowParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunNowParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseIds == input.DatabaseIds ||
                    this.DatabaseIds != null &&
                    input.DatabaseIds != null &&
                    this.DatabaseIds.SequenceEqual(input.DatabaseIds)
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
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
                if (this.DatabaseIds != null)
                    hashCode = hashCode * 59 + this.DatabaseIds.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}
