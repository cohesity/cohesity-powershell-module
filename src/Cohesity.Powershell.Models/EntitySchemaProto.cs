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
    /// Specifies the meta-data associated with entity such as the list of attributes and time series data.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProto :  IEquatable<EntitySchemaProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProto" /> class.
        /// </summary>
        /// <param name="attributesDescriptor">attributesDescriptor.</param>
        /// <param name="isInternalSchema">Specifies if this schema should be displayed in Advanced Diagnostics of the Cohesity Dashboard. If false, the schema is displayed..</param>
        /// <param name="name">Specifies a name that uniquely identifies an entity schema such as &#39;kBridgeClusterStats&#39;..</param>
        /// <param name="schemaDescriptiveName">Specifies the name of the Schema as displayed in Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kBridgeClusterStats&#39; Schema, the descriptive name is &#39;Cluster Physical Stats&#39;..</param>
        /// <param name="schemaHelpText">Specifies an optional informational description about the schema..</param>
        /// <param name="timeSeriesDescriptorVec">List of time series of data (set of data points) for metrics..</param>
        /// <param name="version">Specifies the version of the entity schema..</param>
        public EntitySchemaProto(EntitySchemaProtoAttributesDescriptor attributesDescriptor = default(EntitySchemaProtoAttributesDescriptor), bool? isInternalSchema = default(bool?), string name = default(string), string schemaDescriptiveName = default(string), string schemaHelpText = default(string), List<EntitySchemaProtoTimeSeriesDescriptor> timeSeriesDescriptorVec = default(List<EntitySchemaProtoTimeSeriesDescriptor>), long? version = default(long?))
        {
            this.AttributesDescriptor = attributesDescriptor;
            this.IsInternalSchema = isInternalSchema;
            this.Name = name;
            this.SchemaDescriptiveName = schemaDescriptiveName;
            this.SchemaHelpText = schemaHelpText;
            this.TimeSeriesDescriptorVec = timeSeriesDescriptorVec;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets AttributesDescriptor
        /// </summary>
        [DataMember(Name="attributesDescriptor", EmitDefaultValue=false)]
        public EntitySchemaProtoAttributesDescriptor AttributesDescriptor { get; set; }

        /// <summary>
        /// Specifies if this schema should be displayed in Advanced Diagnostics of the Cohesity Dashboard. If false, the schema is displayed.
        /// </summary>
        /// <value>Specifies if this schema should be displayed in Advanced Diagnostics of the Cohesity Dashboard. If false, the schema is displayed.</value>
        [DataMember(Name="isInternalSchema", EmitDefaultValue=false)]
        public bool? IsInternalSchema { get; set; }

        /// <summary>
        /// Specifies a name that uniquely identifies an entity schema such as &#39;kBridgeClusterStats&#39;.
        /// </summary>
        /// <value>Specifies a name that uniquely identifies an entity schema such as &#39;kBridgeClusterStats&#39;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the name of the Schema as displayed in Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kBridgeClusterStats&#39; Schema, the descriptive name is &#39;Cluster Physical Stats&#39;.
        /// </summary>
        /// <value>Specifies the name of the Schema as displayed in Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kBridgeClusterStats&#39; Schema, the descriptive name is &#39;Cluster Physical Stats&#39;.</value>
        [DataMember(Name="schemaDescriptiveName", EmitDefaultValue=false)]
        public string SchemaDescriptiveName { get; set; }

        /// <summary>
        /// Specifies an optional informational description about the schema.
        /// </summary>
        /// <value>Specifies an optional informational description about the schema.</value>
        [DataMember(Name="schemaHelpText", EmitDefaultValue=false)]
        public string SchemaHelpText { get; set; }

        /// <summary>
        /// List of time series of data (set of data points) for metrics.
        /// </summary>
        /// <value>List of time series of data (set of data points) for metrics.</value>
        [DataMember(Name="timeSeriesDescriptorVec", EmitDefaultValue=false)]
        public List<EntitySchemaProtoTimeSeriesDescriptor> TimeSeriesDescriptorVec { get; set; }

        /// <summary>
        /// Specifies the version of the entity schema.
        /// </summary>
        /// <value>Specifies the version of the entity schema.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(input as EntitySchemaProto);
        }

        /// <summary>
        /// Returns true if EntitySchemaProto instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributesDescriptor == input.AttributesDescriptor ||
                    (this.AttributesDescriptor != null &&
                    this.AttributesDescriptor.Equals(input.AttributesDescriptor))
                ) && 
                (
                    this.IsInternalSchema == input.IsInternalSchema ||
                    (this.IsInternalSchema != null &&
                    this.IsInternalSchema.Equals(input.IsInternalSchema))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SchemaDescriptiveName == input.SchemaDescriptiveName ||
                    (this.SchemaDescriptiveName != null &&
                    this.SchemaDescriptiveName.Equals(input.SchemaDescriptiveName))
                ) && 
                (
                    this.SchemaHelpText == input.SchemaHelpText ||
                    (this.SchemaHelpText != null &&
                    this.SchemaHelpText.Equals(input.SchemaHelpText))
                ) && 
                (
                    this.TimeSeriesDescriptorVec == input.TimeSeriesDescriptorVec ||
                    this.TimeSeriesDescriptorVec != null &&
                    this.TimeSeriesDescriptorVec.SequenceEqual(input.TimeSeriesDescriptorVec)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AttributesDescriptor != null)
                    hashCode = hashCode * 59 + this.AttributesDescriptor.GetHashCode();
                if (this.IsInternalSchema != null)
                    hashCode = hashCode * 59 + this.IsInternalSchema.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SchemaDescriptiveName != null)
                    hashCode = hashCode * 59 + this.SchemaDescriptiveName.GetHashCode();
                if (this.SchemaHelpText != null)
                    hashCode = hashCode * 59 + this.SchemaHelpText.GetHashCode();
                if (this.TimeSeriesDescriptorVec != null)
                    hashCode = hashCode * 59 + this.TimeSeriesDescriptorVec.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

