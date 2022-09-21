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
    /// Parameters for a bulk install app task.
    /// </summary>
    [DataContract]
    public partial class BulkInstallAppTaskInfo :  IEquatable<BulkInstallAppTaskInfo>
    {
        /// <summary>
        /// Application being registered. This param is used to indicate the app for which the job is created. &#39;oracle&#39; indicates that the job was created for oracle app. &#39;msSql&#39; indicates that the job was created for msSql app. &#39;physical&#39; indicates that the job was created for physical machine.
        /// </summary>
        /// <value>Application being registered. This param is used to indicate the app for which the job is created. &#39;oracle&#39; indicates that the job was created for oracle app. &#39;msSql&#39; indicates that the job was created for msSql app. &#39;physical&#39; indicates that the job was created for physical machine.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegisteringAppEnum
        {
            /// <summary>
            /// Enum Oracle for value: oracle
            /// </summary>
            [EnumMember(Value = "oracle")]
            Oracle = 1,

            /// <summary>
            /// Enum MsSql for value: msSql
            /// </summary>
            [EnumMember(Value = "msSql")]
            MsSql = 2,

            /// <summary>
            /// Enum Physical for value: physical
            /// </summary>
            [EnumMember(Value = "physical")]
            Physical = 3

        }

        /// <summary>
        /// Application being registered. This param is used to indicate the app for which the job is created. &#39;oracle&#39; indicates that the job was created for oracle app. &#39;msSql&#39; indicates that the job was created for msSql app. &#39;physical&#39; indicates that the job was created for physical machine.
        /// </summary>
        /// <value>Application being registered. This param is used to indicate the app for which the job is created. &#39;oracle&#39; indicates that the job was created for oracle app. &#39;msSql&#39; indicates that the job was created for msSql app. &#39;physical&#39; indicates that the job was created for physical machine.</value>
        [DataMember(Name="registeringApp", EmitDefaultValue=true)]
        public RegisteringAppEnum? RegisteringApp { get; set; }
        /// <summary>
        /// Current state of the task. This param is used to indicate the state of the job created by the bulk install app. &#39;started&#39; indicates that the job has been started by the user. &#39;completed&#39; indicates that the job has completed.
        /// </summary>
        /// <value>Current state of the task. This param is used to indicate the state of the job created by the bulk install app. &#39;started&#39; indicates that the job has been started by the user. &#39;completed&#39; indicates that the job has completed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Started for value: started
            /// </summary>
            [EnumMember(Value = "started")]
            Started = 1,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 2

        }

        /// <summary>
        /// Current state of the task. This param is used to indicate the state of the job created by the bulk install app. &#39;started&#39; indicates that the job has been started by the user. &#39;completed&#39; indicates that the job has completed.
        /// </summary>
        /// <value>Current state of the task. This param is used to indicate the state of the job created by the bulk install app. &#39;started&#39; indicates that the job has been started by the user. &#39;completed&#39; indicates that the job has completed.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkInstallAppTaskInfo" /> class.
        /// </summary>
        /// <param name="jobId">Job id of the task..</param>
        /// <param name="numMachinesFailed">Number of machines on which task is started..</param>
        /// <param name="numMachinesPassed">Number of machines on which task is started..</param>
        /// <param name="numMachinesTotal">Number of machines on which task is started..</param>
        /// <param name="registeringApp">Application being registered. This param is used to indicate the app for which the job is created. &#39;oracle&#39; indicates that the job was created for oracle app. &#39;msSql&#39; indicates that the job was created for msSql app. &#39;physical&#39; indicates that the job was created for physical machine..</param>
        /// <param name="state">Current state of the task. This param is used to indicate the state of the job created by the bulk install app. &#39;started&#39; indicates that the job has been started by the user. &#39;completed&#39; indicates that the job has completed..</param>
        public BulkInstallAppTaskInfo(string jobId = default(string), int? numMachinesFailed = default(int?), int? numMachinesPassed = default(int?), int? numMachinesTotal = default(int?), RegisteringAppEnum? registeringApp = default(RegisteringAppEnum?), StateEnum? state = default(StateEnum?))
        {
            this.JobId = jobId;
            this.NumMachinesFailed = numMachinesFailed;
            this.NumMachinesPassed = numMachinesPassed;
            this.NumMachinesTotal = numMachinesTotal;
            this.RegisteringApp = registeringApp;
            this.State = state;
            this.JobId = jobId;
            this.NumMachinesFailed = numMachinesFailed;
            this.NumMachinesPassed = numMachinesPassed;
            this.NumMachinesTotal = numMachinesTotal;
            this.RegisteringApp = registeringApp;
            this.State = state;
        }
        
        /// <summary>
        /// Job id of the task.
        /// </summary>
        /// <value>Job id of the task.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public string JobId { get; set; }

        /// <summary>
        /// Number of machines on which task is started.
        /// </summary>
        /// <value>Number of machines on which task is started.</value>
        [DataMember(Name="numMachinesFailed", EmitDefaultValue=true)]
        public int? NumMachinesFailed { get; set; }

        /// <summary>
        /// Number of machines on which task is started.
        /// </summary>
        /// <value>Number of machines on which task is started.</value>
        [DataMember(Name="numMachinesPassed", EmitDefaultValue=true)]
        public int? NumMachinesPassed { get; set; }

        /// <summary>
        /// Number of machines on which task is started.
        /// </summary>
        /// <value>Number of machines on which task is started.</value>
        [DataMember(Name="numMachinesTotal", EmitDefaultValue=true)]
        public int? NumMachinesTotal { get; set; }

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
            return this.Equals(input as BulkInstallAppTaskInfo);
        }

        /// <summary>
        /// Returns true if BulkInstallAppTaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkInstallAppTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkInstallAppTaskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.NumMachinesFailed == input.NumMachinesFailed ||
                    (this.NumMachinesFailed != null &&
                    this.NumMachinesFailed.Equals(input.NumMachinesFailed))
                ) && 
                (
                    this.NumMachinesPassed == input.NumMachinesPassed ||
                    (this.NumMachinesPassed != null &&
                    this.NumMachinesPassed.Equals(input.NumMachinesPassed))
                ) && 
                (
                    this.NumMachinesTotal == input.NumMachinesTotal ||
                    (this.NumMachinesTotal != null &&
                    this.NumMachinesTotal.Equals(input.NumMachinesTotal))
                ) && 
                (
                    this.RegisteringApp == input.RegisteringApp ||
                    this.RegisteringApp.Equals(input.RegisteringApp)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.NumMachinesFailed != null)
                    hashCode = hashCode * 59 + this.NumMachinesFailed.GetHashCode();
                if (this.NumMachinesPassed != null)
                    hashCode = hashCode * 59 + this.NumMachinesPassed.GetHashCode();
                if (this.NumMachinesTotal != null)
                    hashCode = hashCode * 59 + this.NumMachinesTotal.GetHashCode();
                hashCode = hashCode * 59 + this.RegisteringApp.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}

