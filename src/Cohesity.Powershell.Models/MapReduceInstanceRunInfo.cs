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
    /// MapReduceInstanceRunInfo
    /// </summary>
    [DataContract]
    public partial class MapReduceInstanceRunInfo :  IEquatable<MapReduceInstanceRunInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInstanceRunInfo" /> class.
        /// </summary>
        /// <param name="endTime">Time when map redcue job completed..</param>
        /// <param name="errorMessage">If this run failed, then error message for failure..</param>
        /// <param name="executionStartTimeUsecs">Time (in usecs) when job was picked up for execution..</param>
        /// <param name="filesProcessed">Number of files processed in this run..</param>
        /// <param name="mapDoneTimeUsecs">Time (in usecs) when map tasks were done..</param>
        /// <param name="mapInputBytes">Total size of data processed by this run in bytes..</param>
        /// <param name="mappersSpawned">Number of mappers spawned till now..</param>
        /// <param name="numMapOutputs">Number of outputs from mappers..</param>
        /// <param name="numReduceOutputs">Number of outputs from reducers..</param>
        /// <param name="percentageCompletion">Percentage completion of this run so far..</param>
        /// <param name="percentageMapperCompletion">Percentage of mapper phase completed..</param>
        /// <param name="percentageReducerCompletion">Percentage of reducer phase completed..</param>
        /// <param name="reducersSpawned">Number of reducers spawned till now..</param>
        /// <param name="remainingTimeMins">Expected remaining time in minutes for completion of this run..</param>
        /// <param name="startTime">Time when map reduce job was started by user..</param>
        /// <param name="status">Status of this run..</param>
        /// <param name="totalNumMappers">Total number of mappers to be spawned..</param>
        /// <param name="totalNumReducers">Total number of reducers to be spawned..</param>
        public MapReduceInstanceRunInfo(long? endTime = default(long?), string errorMessage = default(string), long? executionStartTimeUsecs = default(long?), int? filesProcessed = default(int?), long? mapDoneTimeUsecs = default(long?), long? mapInputBytes = default(long?), int? mappersSpawned = default(int?), long? numMapOutputs = default(long?), long? numReduceOutputs = default(long?), float? percentageCompletion = default(float?), float? percentageMapperCompletion = default(float?), float? percentageReducerCompletion = default(float?), int? reducersSpawned = default(int?), int? remainingTimeMins = default(int?), long? startTime = default(long?), int? status = default(int?), int? totalNumMappers = default(int?), int? totalNumReducers = default(int?))
        {
            this.EndTime = endTime;
            this.ErrorMessage = errorMessage;
            this.ExecutionStartTimeUsecs = executionStartTimeUsecs;
            this.FilesProcessed = filesProcessed;
            this.MapDoneTimeUsecs = mapDoneTimeUsecs;
            this.MapInputBytes = mapInputBytes;
            this.MappersSpawned = mappersSpawned;
            this.NumMapOutputs = numMapOutputs;
            this.NumReduceOutputs = numReduceOutputs;
            this.PercentageCompletion = percentageCompletion;
            this.PercentageMapperCompletion = percentageMapperCompletion;
            this.PercentageReducerCompletion = percentageReducerCompletion;
            this.ReducersSpawned = reducersSpawned;
            this.RemainingTimeMins = remainingTimeMins;
            this.StartTime = startTime;
            this.Status = status;
            this.TotalNumMappers = totalNumMappers;
            this.TotalNumReducers = totalNumReducers;
        }
        
        /// <summary>
        /// Time when map redcue job completed.
        /// </summary>
        /// <value>Time when map redcue job completed.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// If this run failed, then error message for failure.
        /// </summary>
        /// <value>If this run failed, then error message for failure.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Time (in usecs) when job was picked up for execution.
        /// </summary>
        /// <value>Time (in usecs) when job was picked up for execution.</value>
        [DataMember(Name="executionStartTimeUsecs", EmitDefaultValue=false)]
        public long? ExecutionStartTimeUsecs { get; set; }

        /// <summary>
        /// Number of files processed in this run.
        /// </summary>
        /// <value>Number of files processed in this run.</value>
        [DataMember(Name="filesProcessed", EmitDefaultValue=false)]
        public int? FilesProcessed { get; set; }

        /// <summary>
        /// Time (in usecs) when map tasks were done.
        /// </summary>
        /// <value>Time (in usecs) when map tasks were done.</value>
        [DataMember(Name="mapDoneTimeUsecs", EmitDefaultValue=false)]
        public long? MapDoneTimeUsecs { get; set; }

        /// <summary>
        /// Total size of data processed by this run in bytes.
        /// </summary>
        /// <value>Total size of data processed by this run in bytes.</value>
        [DataMember(Name="mapInputBytes", EmitDefaultValue=false)]
        public long? MapInputBytes { get; set; }

        /// <summary>
        /// Number of mappers spawned till now.
        /// </summary>
        /// <value>Number of mappers spawned till now.</value>
        [DataMember(Name="mappersSpawned", EmitDefaultValue=false)]
        public int? MappersSpawned { get; set; }

        /// <summary>
        /// Number of outputs from mappers.
        /// </summary>
        /// <value>Number of outputs from mappers.</value>
        [DataMember(Name="numMapOutputs", EmitDefaultValue=false)]
        public long? NumMapOutputs { get; set; }

        /// <summary>
        /// Number of outputs from reducers.
        /// </summary>
        /// <value>Number of outputs from reducers.</value>
        [DataMember(Name="numReduceOutputs", EmitDefaultValue=false)]
        public long? NumReduceOutputs { get; set; }

        /// <summary>
        /// Percentage completion of this run so far.
        /// </summary>
        /// <value>Percentage completion of this run so far.</value>
        [DataMember(Name="percentageCompletion", EmitDefaultValue=false)]
        public float? PercentageCompletion { get; set; }

        /// <summary>
        /// Percentage of mapper phase completed.
        /// </summary>
        /// <value>Percentage of mapper phase completed.</value>
        [DataMember(Name="percentageMapperCompletion", EmitDefaultValue=false)]
        public float? PercentageMapperCompletion { get; set; }

        /// <summary>
        /// Percentage of reducer phase completed.
        /// </summary>
        /// <value>Percentage of reducer phase completed.</value>
        [DataMember(Name="percentageReducerCompletion", EmitDefaultValue=false)]
        public float? PercentageReducerCompletion { get; set; }

        /// <summary>
        /// Number of reducers spawned till now.
        /// </summary>
        /// <value>Number of reducers spawned till now.</value>
        [DataMember(Name="reducersSpawned", EmitDefaultValue=false)]
        public int? ReducersSpawned { get; set; }

        /// <summary>
        /// Expected remaining time in minutes for completion of this run.
        /// </summary>
        /// <value>Expected remaining time in minutes for completion of this run.</value>
        [DataMember(Name="remainingTimeMins", EmitDefaultValue=false)]
        public int? RemainingTimeMins { get; set; }

        /// <summary>
        /// Time when map reduce job was started by user.
        /// </summary>
        /// <value>Time when map reduce job was started by user.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// Status of this run.
        /// </summary>
        /// <value>Status of this run.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Total number of mappers to be spawned.
        /// </summary>
        /// <value>Total number of mappers to be spawned.</value>
        [DataMember(Name="totalNumMappers", EmitDefaultValue=false)]
        public int? TotalNumMappers { get; set; }

        /// <summary>
        /// Total number of reducers to be spawned.
        /// </summary>
        /// <value>Total number of reducers to be spawned.</value>
        [DataMember(Name="totalNumReducers", EmitDefaultValue=false)]
        public int? TotalNumReducers { get; set; }

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
            return this.Equals(input as MapReduceInstanceRunInfo);
        }

        /// <summary>
        /// Returns true if MapReduceInstanceRunInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInstanceRunInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInstanceRunInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ExecutionStartTimeUsecs == input.ExecutionStartTimeUsecs ||
                    (this.ExecutionStartTimeUsecs != null &&
                    this.ExecutionStartTimeUsecs.Equals(input.ExecutionStartTimeUsecs))
                ) && 
                (
                    this.FilesProcessed == input.FilesProcessed ||
                    (this.FilesProcessed != null &&
                    this.FilesProcessed.Equals(input.FilesProcessed))
                ) && 
                (
                    this.MapDoneTimeUsecs == input.MapDoneTimeUsecs ||
                    (this.MapDoneTimeUsecs != null &&
                    this.MapDoneTimeUsecs.Equals(input.MapDoneTimeUsecs))
                ) && 
                (
                    this.MapInputBytes == input.MapInputBytes ||
                    (this.MapInputBytes != null &&
                    this.MapInputBytes.Equals(input.MapInputBytes))
                ) && 
                (
                    this.MappersSpawned == input.MappersSpawned ||
                    (this.MappersSpawned != null &&
                    this.MappersSpawned.Equals(input.MappersSpawned))
                ) && 
                (
                    this.NumMapOutputs == input.NumMapOutputs ||
                    (this.NumMapOutputs != null &&
                    this.NumMapOutputs.Equals(input.NumMapOutputs))
                ) && 
                (
                    this.NumReduceOutputs == input.NumReduceOutputs ||
                    (this.NumReduceOutputs != null &&
                    this.NumReduceOutputs.Equals(input.NumReduceOutputs))
                ) && 
                (
                    this.PercentageCompletion == input.PercentageCompletion ||
                    (this.PercentageCompletion != null &&
                    this.PercentageCompletion.Equals(input.PercentageCompletion))
                ) && 
                (
                    this.PercentageMapperCompletion == input.PercentageMapperCompletion ||
                    (this.PercentageMapperCompletion != null &&
                    this.PercentageMapperCompletion.Equals(input.PercentageMapperCompletion))
                ) && 
                (
                    this.PercentageReducerCompletion == input.PercentageReducerCompletion ||
                    (this.PercentageReducerCompletion != null &&
                    this.PercentageReducerCompletion.Equals(input.PercentageReducerCompletion))
                ) && 
                (
                    this.ReducersSpawned == input.ReducersSpawned ||
                    (this.ReducersSpawned != null &&
                    this.ReducersSpawned.Equals(input.ReducersSpawned))
                ) && 
                (
                    this.RemainingTimeMins == input.RemainingTimeMins ||
                    (this.RemainingTimeMins != null &&
                    this.RemainingTimeMins.Equals(input.RemainingTimeMins))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalNumMappers == input.TotalNumMappers ||
                    (this.TotalNumMappers != null &&
                    this.TotalNumMappers.Equals(input.TotalNumMappers))
                ) && 
                (
                    this.TotalNumReducers == input.TotalNumReducers ||
                    (this.TotalNumReducers != null &&
                    this.TotalNumReducers.Equals(input.TotalNumReducers))
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
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ExecutionStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExecutionStartTimeUsecs.GetHashCode();
                if (this.FilesProcessed != null)
                    hashCode = hashCode * 59 + this.FilesProcessed.GetHashCode();
                if (this.MapDoneTimeUsecs != null)
                    hashCode = hashCode * 59 + this.MapDoneTimeUsecs.GetHashCode();
                if (this.MapInputBytes != null)
                    hashCode = hashCode * 59 + this.MapInputBytes.GetHashCode();
                if (this.MappersSpawned != null)
                    hashCode = hashCode * 59 + this.MappersSpawned.GetHashCode();
                if (this.NumMapOutputs != null)
                    hashCode = hashCode * 59 + this.NumMapOutputs.GetHashCode();
                if (this.NumReduceOutputs != null)
                    hashCode = hashCode * 59 + this.NumReduceOutputs.GetHashCode();
                if (this.PercentageCompletion != null)
                    hashCode = hashCode * 59 + this.PercentageCompletion.GetHashCode();
                if (this.PercentageMapperCompletion != null)
                    hashCode = hashCode * 59 + this.PercentageMapperCompletion.GetHashCode();
                if (this.PercentageReducerCompletion != null)
                    hashCode = hashCode * 59 + this.PercentageReducerCompletion.GetHashCode();
                if (this.ReducersSpawned != null)
                    hashCode = hashCode * 59 + this.ReducersSpawned.GetHashCode();
                if (this.RemainingTimeMins != null)
                    hashCode = hashCode * 59 + this.RemainingTimeMins.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalNumMappers != null)
                    hashCode = hashCode * 59 + this.TotalNumMappers.GetHashCode();
                if (this.TotalNumReducers != null)
                    hashCode = hashCode * 59 + this.TotalNumReducers.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

