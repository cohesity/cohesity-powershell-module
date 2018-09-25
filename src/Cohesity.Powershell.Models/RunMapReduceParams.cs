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
    /// RunMapReduceParams
    /// </summary>
    [DataContract]
    public partial class RunMapReduceParams :  IEquatable<RunMapReduceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunMapReduceParams" /> class.
        /// </summary>
        /// <param name="appId">ApplicationId is the Id of the map reduce application to run..</param>
        /// <param name="inputParams">InputParams specifies optional list of key&#x3D;value input params specified for running the map reduce instance..</param>
        /// <param name="mrInput">InputSpecification specifies the input information to run the specific map reduce instance..</param>
        /// <param name="mrOutput">OutputSpecification specifies the output information to run the specific map reduce instance..</param>
        public RunMapReduceParams(long? appId = default(long?), List<MapReduceInstanceInputParam> inputParams = default(List<MapReduceInstanceInputParam>), InputSpec mrInput = default(InputSpec), OutputSpec mrOutput = default(OutputSpec))
        {
            this.AppId = appId;
            this.InputParams = inputParams;
            this.MrInput = mrInput;
            this.MrOutput = mrOutput;
        }
        
        /// <summary>
        /// ApplicationId is the Id of the map reduce application to run.
        /// </summary>
        /// <value>ApplicationId is the Id of the map reduce application to run.</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// InputParams specifies optional list of key&#x3D;value input params specified for running the map reduce instance.
        /// </summary>
        /// <value>InputParams specifies optional list of key&#x3D;value input params specified for running the map reduce instance.</value>
        [DataMember(Name="inputParams", EmitDefaultValue=false)]
        public List<MapReduceInstanceInputParam> InputParams { get; set; }

        /// <summary>
        /// InputSpecification specifies the input information to run the specific map reduce instance.
        /// </summary>
        /// <value>InputSpecification specifies the input information to run the specific map reduce instance.</value>
        [DataMember(Name="mrInput", EmitDefaultValue=false)]
        public InputSpec MrInput { get; set; }

        /// <summary>
        /// OutputSpecification specifies the output information to run the specific map reduce instance.
        /// </summary>
        /// <value>OutputSpecification specifies the output information to run the specific map reduce instance.</value>
        [DataMember(Name="mrOutput", EmitDefaultValue=false)]
        public OutputSpec MrOutput { get; set; }

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
            return this.Equals(input as RunMapReduceParams);
        }

        /// <summary>
        /// Returns true if RunMapReduceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RunMapReduceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunMapReduceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.InputParams == input.InputParams ||
                    this.InputParams != null &&
                    this.InputParams.SequenceEqual(input.InputParams)
                ) && 
                (
                    this.MrInput == input.MrInput ||
                    (this.MrInput != null &&
                    this.MrInput.Equals(input.MrInput))
                ) && 
                (
                    this.MrOutput == input.MrOutput ||
                    (this.MrOutput != null &&
                    this.MrOutput.Equals(input.MrOutput))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.InputParams != null)
                    hashCode = hashCode * 59 + this.InputParams.GetHashCode();
                if (this.MrInput != null)
                    hashCode = hashCode * 59 + this.MrInput.GetHashCode();
                if (this.MrOutput != null)
                    hashCode = hashCode * 59 + this.MrOutput.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

