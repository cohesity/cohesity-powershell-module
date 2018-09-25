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
    /// MapReduceInstanceWrapper is the struct containing the map reduce instance information along with the output file path information required to download the results set.
    /// </summary>
    [DataContract]
    public partial class MapReduceInstanceWrapper :  IEquatable<MapReduceInstanceWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInstanceWrapper" /> class.
        /// </summary>
        /// <param name="logPath">LogPath is the path of the log files for the MR instance run..</param>
        /// <param name="mrInstance">InstanceInfo is the information about the map reduce application instance..</param>
        /// <param name="outputFilePathList">OutputFilePathList is the list containing the output files path suffix that Yoda uses to build the full path of the MR instance run output files..</param>
        public MapReduceInstanceWrapper(string logPath = default(string), MapReduceInstance mrInstance = default(MapReduceInstance), List<string> outputFilePathList = default(List<string>))
        {
            this.LogPath = logPath;
            this.MrInstance = mrInstance;
            this.OutputFilePathList = outputFilePathList;
        }
        
        /// <summary>
        /// LogPath is the path of the log files for the MR instance run.
        /// </summary>
        /// <value>LogPath is the path of the log files for the MR instance run.</value>
        [DataMember(Name="logPath", EmitDefaultValue=false)]
        public string LogPath { get; set; }

        /// <summary>
        /// InstanceInfo is the information about the map reduce application instance.
        /// </summary>
        /// <value>InstanceInfo is the information about the map reduce application instance.</value>
        [DataMember(Name="mrInstance", EmitDefaultValue=false)]
        public MapReduceInstance MrInstance { get; set; }

        /// <summary>
        /// OutputFilePathList is the list containing the output files path suffix that Yoda uses to build the full path of the MR instance run output files.
        /// </summary>
        /// <value>OutputFilePathList is the list containing the output files path suffix that Yoda uses to build the full path of the MR instance run output files.</value>
        [DataMember(Name="outputFilePathList", EmitDefaultValue=false)]
        public List<string> OutputFilePathList { get; set; }

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
            return this.Equals(input as MapReduceInstanceWrapper);
        }

        /// <summary>
        /// Returns true if MapReduceInstanceWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInstanceWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInstanceWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogPath == input.LogPath ||
                    (this.LogPath != null &&
                    this.LogPath.Equals(input.LogPath))
                ) && 
                (
                    this.MrInstance == input.MrInstance ||
                    (this.MrInstance != null &&
                    this.MrInstance.Equals(input.MrInstance))
                ) && 
                (
                    this.OutputFilePathList == input.OutputFilePathList ||
                    this.OutputFilePathList != null &&
                    this.OutputFilePathList.SequenceEqual(input.OutputFilePathList)
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
                if (this.LogPath != null)
                    hashCode = hashCode * 59 + this.LogPath.GetHashCode();
                if (this.MrInstance != null)
                    hashCode = hashCode * 59 + this.MrInstance.GetHashCode();
                if (this.OutputFilePathList != null)
                    hashCode = hashCode * 59 + this.OutputFilePathList.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

