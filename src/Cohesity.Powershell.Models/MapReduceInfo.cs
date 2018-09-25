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
    /// On UI this will be used to show the list of available apps to the user.
    /// </summary>
    [DataContract]
    public partial class MapReduceInfo :  IEquatable<MapReduceInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInfo" /> class.
        /// </summary>
        /// <param name="description">Map reduce job description..</param>
        /// <param name="excludedDataSourceVec">excludedDataSourceVec.</param>
        /// <param name="id">ID of map reduce job..</param>
        /// <param name="isSystemDefined">Flag to denote if this is system pre-defined app or user has written this app..</param>
        /// <param name="mapperId">ID of the mapper to process the input..</param>
        /// <param name="name">Map reduce job name..</param>
        /// <param name="reducerId">ID of the reducer..</param>
        /// <param name="requiredPropertyVec">requiredPropertyVec.</param>
        public MapReduceInfo(string description = default(string), List<int?> excludedDataSourceVec = default(List<int?>), long? id = default(long?), bool? isSystemDefined = default(bool?), long? mapperId = default(long?), string name = default(string), long? reducerId = default(long?), List<MapReduceInfoRequiredProperty> requiredPropertyVec = default(List<MapReduceInfoRequiredProperty>))
        {
            this.Description = description;
            this.ExcludedDataSourceVec = excludedDataSourceVec;
            this.Id = id;
            this.IsSystemDefined = isSystemDefined;
            this.MapperId = mapperId;
            this.Name = name;
            this.ReducerId = reducerId;
            this.RequiredPropertyVec = requiredPropertyVec;
        }
        
        /// <summary>
        /// Map reduce job description.
        /// </summary>
        /// <value>Map reduce job description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedDataSourceVec
        /// </summary>
        [DataMember(Name="excludedDataSourceVec", EmitDefaultValue=false)]
        public List<int?> ExcludedDataSourceVec { get; set; }

        /// <summary>
        /// ID of map reduce job.
        /// </summary>
        /// <value>ID of map reduce job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Flag to denote if this is system pre-defined app or user has written this app.
        /// </summary>
        /// <value>Flag to denote if this is system pre-defined app or user has written this app.</value>
        [DataMember(Name="isSystemDefined", EmitDefaultValue=false)]
        public bool? IsSystemDefined { get; set; }

        /// <summary>
        /// ID of the mapper to process the input.
        /// </summary>
        /// <value>ID of the mapper to process the input.</value>
        [DataMember(Name="mapperId", EmitDefaultValue=false)]
        public long? MapperId { get; set; }

        /// <summary>
        /// Map reduce job name.
        /// </summary>
        /// <value>Map reduce job name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ID of the reducer.
        /// </summary>
        /// <value>ID of the reducer.</value>
        [DataMember(Name="reducerId", EmitDefaultValue=false)]
        public long? ReducerId { get; set; }

        /// <summary>
        /// Gets or Sets RequiredPropertyVec
        /// </summary>
        [DataMember(Name="requiredPropertyVec", EmitDefaultValue=false)]
        public List<MapReduceInfoRequiredProperty> RequiredPropertyVec { get; set; }

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
            return this.Equals(input as MapReduceInfo);
        }

        /// <summary>
        /// Returns true if MapReduceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExcludedDataSourceVec == input.ExcludedDataSourceVec ||
                    this.ExcludedDataSourceVec != null &&
                    this.ExcludedDataSourceVec.SequenceEqual(input.ExcludedDataSourceVec)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsSystemDefined == input.IsSystemDefined ||
                    (this.IsSystemDefined != null &&
                    this.IsSystemDefined.Equals(input.IsSystemDefined))
                ) && 
                (
                    this.MapperId == input.MapperId ||
                    (this.MapperId != null &&
                    this.MapperId.Equals(input.MapperId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReducerId == input.ReducerId ||
                    (this.ReducerId != null &&
                    this.ReducerId.Equals(input.ReducerId))
                ) && 
                (
                    this.RequiredPropertyVec == input.RequiredPropertyVec ||
                    this.RequiredPropertyVec != null &&
                    this.RequiredPropertyVec.SequenceEqual(input.RequiredPropertyVec)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExcludedDataSourceVec != null)
                    hashCode = hashCode * 59 + this.ExcludedDataSourceVec.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsSystemDefined != null)
                    hashCode = hashCode * 59 + this.IsSystemDefined.GetHashCode();
                if (this.MapperId != null)
                    hashCode = hashCode * 59 + this.MapperId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReducerId != null)
                    hashCode = hashCode * 59 + this.ReducerId.GetHashCode();
                if (this.RequiredPropertyVec != null)
                    hashCode = hashCode * 59 + this.RequiredPropertyVec.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

