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
    /// MapReduceInstance
    /// </summary>
    [DataContract]
    public partial class MapReduceInstance :  IEquatable<MapReduceInstance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInstance" /> class.
        /// </summary>
        /// <param name="id">System generated ID of map reduce instance..</param>
        /// <param name="inputParams">inputParams.</param>
        /// <param name="inputSpec">Input spec for the MR..</param>
        /// <param name="mapReduceInfoId">ID of Map reduce info..</param>
        /// <param name="outputSpec">Output spec for the MR..</param>
        /// <param name="runInfo">Information about run of this instance. All fields of RunInfo will be populated by yoda/analytics components..</param>
        public MapReduceInstance(long? id = default(long?), List<MapReduceInstanceInputParam> inputParams = default(List<MapReduceInstanceInputParam>), InputSpec inputSpec = default(InputSpec), long? mapReduceInfoId = default(long?), OutputSpec outputSpec = default(OutputSpec), MapReduceInstanceRunInfo runInfo = default(MapReduceInstanceRunInfo))
        {
            this.Id = id;
            this.InputParams = inputParams;
            this.InputSpec = inputSpec;
            this.MapReduceInfoId = mapReduceInfoId;
            this.OutputSpec = outputSpec;
            this.RunInfo = runInfo;
        }
        
        /// <summary>
        /// System generated ID of map reduce instance.
        /// </summary>
        /// <value>System generated ID of map reduce instance.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets InputParams
        /// </summary>
        [DataMember(Name="inputParams", EmitDefaultValue=false)]
        public List<MapReduceInstanceInputParam> InputParams { get; set; }

        /// <summary>
        /// Input spec for the MR.
        /// </summary>
        /// <value>Input spec for the MR.</value>
        [DataMember(Name="inputSpec", EmitDefaultValue=false)]
        public InputSpec InputSpec { get; set; }

        /// <summary>
        /// ID of Map reduce info.
        /// </summary>
        /// <value>ID of Map reduce info.</value>
        [DataMember(Name="mapReduceInfoId", EmitDefaultValue=false)]
        public long? MapReduceInfoId { get; set; }

        /// <summary>
        /// Output spec for the MR.
        /// </summary>
        /// <value>Output spec for the MR.</value>
        [DataMember(Name="outputSpec", EmitDefaultValue=false)]
        public OutputSpec OutputSpec { get; set; }

        /// <summary>
        /// Information about run of this instance. All fields of RunInfo will be populated by yoda/analytics components.
        /// </summary>
        /// <value>Information about run of this instance. All fields of RunInfo will be populated by yoda/analytics components.</value>
        [DataMember(Name="runInfo", EmitDefaultValue=false)]
        public MapReduceInstanceRunInfo RunInfo { get; set; }

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
            return this.Equals(input as MapReduceInstance);
        }

        /// <summary>
        /// Returns true if MapReduceInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InputParams == input.InputParams ||
                    this.InputParams != null &&
                    this.InputParams.SequenceEqual(input.InputParams)
                ) && 
                (
                    this.InputSpec == input.InputSpec ||
                    (this.InputSpec != null &&
                    this.InputSpec.Equals(input.InputSpec))
                ) && 
                (
                    this.MapReduceInfoId == input.MapReduceInfoId ||
                    (this.MapReduceInfoId != null &&
                    this.MapReduceInfoId.Equals(input.MapReduceInfoId))
                ) && 
                (
                    this.OutputSpec == input.OutputSpec ||
                    (this.OutputSpec != null &&
                    this.OutputSpec.Equals(input.OutputSpec))
                ) && 
                (
                    this.RunInfo == input.RunInfo ||
                    (this.RunInfo != null &&
                    this.RunInfo.Equals(input.RunInfo))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InputParams != null)
                    hashCode = hashCode * 59 + this.InputParams.GetHashCode();
                if (this.InputSpec != null)
                    hashCode = hashCode * 59 + this.InputSpec.GetHashCode();
                if (this.MapReduceInfoId != null)
                    hashCode = hashCode * 59 + this.MapReduceInfoId.GetHashCode();
                if (this.OutputSpec != null)
                    hashCode = hashCode * 59 + this.OutputSpec.GetHashCode();
                if (this.RunInfo != null)
                    hashCode = hashCode * 59 + this.RunInfo.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

