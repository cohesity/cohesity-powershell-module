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
    /// Specifies the Apollo schema to list the data point.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesSchemaResponse :  IEquatable<TimeSeriesSchemaResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesSchemaResponse" /> class.
        /// </summary>
        /// <param name="schemaInfoList">Specifies the list of the schema info for an entity..</param>
        public TimeSeriesSchemaResponse(List<SchemaInfo> schemaInfoList = default(List<SchemaInfo>))
        {
            this.SchemaInfoList = schemaInfoList;
            this.SchemaInfoList = schemaInfoList;
        }
        
        /// <summary>
        /// Specifies the list of the schema info for an entity.
        /// </summary>
        /// <value>Specifies the list of the schema info for an entity.</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<SchemaInfo> SchemaInfoList { get; set; }

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
            return this.Equals(input as TimeSeriesSchemaResponse);
        }

        /// <summary>
        /// Returns true if TimeSeriesSchemaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSeriesSchemaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesSchemaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    input.SchemaInfoList != null &&
                    this.SchemaInfoList.SequenceEqual(input.SchemaInfoList)
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
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                return hashCode;
            }
        }

    }

}

