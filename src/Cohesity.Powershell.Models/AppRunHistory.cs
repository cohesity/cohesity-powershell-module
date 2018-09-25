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
    /// AppRunHistory is the struct containing the run information of the application instances. An application instance can be run only once. Each run of the application creates a new application instance.
    /// </summary>
    [DataContract]
    public partial class AppRunHistory :  IEquatable<AppRunHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRunHistory" /> class.
        /// </summary>
        /// <param name="appInfo">AppInfo is the information about the map reduce application..</param>
        /// <param name="mrInstances">InstancesWrapper is the slice containing the information about the map reduce application instances..</param>
        public AppRunHistory(MapReduceInfo appInfo = default(MapReduceInfo), List<MapReduceInstanceWrapper> mrInstances = default(List<MapReduceInstanceWrapper>))
        {
            this.AppInfo = appInfo;
            this.MrInstances = mrInstances;
        }
        
        /// <summary>
        /// AppInfo is the information about the map reduce application.
        /// </summary>
        /// <value>AppInfo is the information about the map reduce application.</value>
        [DataMember(Name="appInfo", EmitDefaultValue=false)]
        public MapReduceInfo AppInfo { get; set; }

        /// <summary>
        /// InstancesWrapper is the slice containing the information about the map reduce application instances.
        /// </summary>
        /// <value>InstancesWrapper is the slice containing the information about the map reduce application instances.</value>
        [DataMember(Name="mrInstances", EmitDefaultValue=false)]
        public List<MapReduceInstanceWrapper> MrInstances { get; set; }

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
            return this.Equals(input as AppRunHistory);
        }

        /// <summary>
        /// Returns true if AppRunHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRunHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRunHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppInfo == input.AppInfo ||
                    (this.AppInfo != null &&
                    this.AppInfo.Equals(input.AppInfo))
                ) && 
                (
                    this.MrInstances == input.MrInstances ||
                    this.MrInstances != null &&
                    this.MrInstances.SequenceEqual(input.MrInstances)
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
                if (this.AppInfo != null)
                    hashCode = hashCode * 59 + this.AppInfo.GetHashCode();
                if (this.MrInstances != null)
                    hashCode = hashCode * 59 + this.MrInstances.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

