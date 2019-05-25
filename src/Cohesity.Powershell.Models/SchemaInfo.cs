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
    /// Specifies the metric data point where public data metric name as key and the schema defined metric name as a value.
    /// </summary>
    [DataContract]
    public partial class SchemaInfo :  IEquatable<SchemaInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaInfo" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the id of the entity represented as a string..</param>
        /// <param name="key">Specifies the key which is public facing name for metric name..</param>
        /// <param name="metricName">Specifies the Apollo schema metric name..</param>
        /// <param name="schemaName">Specifies the name of entity schema such as &#39;ApolloViewBoxStats&#39;..</param>
        public SchemaInfo(string entityId = default(string), string key = default(string), string metricName = default(string), string schemaName = default(string))
        {
            this.EntityId = entityId;
            this.Key = key;
            this.MetricName = metricName;
            this.SchemaName = schemaName;
            this.EntityId = entityId;
            this.Key = key;
            this.MetricName = metricName;
            this.SchemaName = schemaName;
        }
        
        /// <summary>
        /// Specifies the id of the entity represented as a string.
        /// </summary>
        /// <value>Specifies the id of the entity represented as a string.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public string EntityId { get; set; }

        /// <summary>
        /// Specifies the key which is public facing name for metric name.
        /// </summary>
        /// <value>Specifies the key which is public facing name for metric name.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies the Apollo schema metric name.
        /// </summary>
        /// <value>Specifies the Apollo schema metric name.</value>
        [DataMember(Name="metricName", EmitDefaultValue=true)]
        public string MetricName { get; set; }

        /// <summary>
        /// Specifies the name of entity schema such as &#39;ApolloViewBoxStats&#39;.
        /// </summary>
        /// <value>Specifies the name of entity schema such as &#39;ApolloViewBoxStats&#39;.</value>
        [DataMember(Name="schemaName", EmitDefaultValue=true)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaInfo {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("  SchemaName: ").Append(SchemaName).Append("\n");
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
            return this.Equals(input as SchemaInfo);
        }

        /// <summary>
        /// Returns true if SchemaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                return hashCode;
            }
        }

    }

}
