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
    /// AppInstance provides application instance&#39;s information.
    /// </summary>
    [DataContract]
    public partial class AppInstance :  IEquatable<AppInstance>
    {
        /// <summary>
        /// Specifies the current state of the app instance. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.
        /// </summary>
        /// <value>Specifies the current state of the app instance. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum KInitializing for value: kInitializing
            /// </summary>
            [EnumMember(Value = "kInitializing")]
            KInitializing = 1,

            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,

            /// <summary>
            /// Enum KPausing for value: kPausing
            /// </summary>
            [EnumMember(Value = "kPausing")]
            KPausing = 3,

            /// <summary>
            /// Enum KPaused for value: kPaused
            /// </summary>
            [EnumMember(Value = "kPaused")]
            KPaused = 4,

            /// <summary>
            /// Enum KTerminating for value: kTerminating
            /// </summary>
            [EnumMember(Value = "kTerminating")]
            KTerminating = 5,

            /// <summary>
            /// Enum KTerminated for value: kTerminated
            /// </summary>
            [EnumMember(Value = "kTerminated")]
            KTerminated = 6,

            /// <summary>
            /// Enum KFailed for value: kFailed
            /// </summary>
            [EnumMember(Value = "kFailed")]
            KFailed = 7

        }

        /// <summary>
        /// Specifies the current state of the app instance. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.
        /// </summary>
        /// <value>Specifies the current state of the app instance. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstance" /> class.
        /// </summary>
        /// <param name="appAccessToken">Specifies the token to access with the app..</param>
        /// <param name="appInstanceId">Specifies unique id across all instances of all apps..</param>
        /// <param name="appName">Specifies name of the app that is launched in this instance..</param>
        /// <param name="appUid">Specifies id of the app that is launched in this instance..</param>
        /// <param name="appVersion">Specifies the version of the app that is launched in this instance..</param>
        /// <param name="createdTimeUsecs">Specifies timestamp (in microseconds) when the app instance was first created..</param>
        /// <param name="creationUid">Specifies an unique identifier generated by the client to let the backend identify retries of the app launch request..</param>
        /// <param name="description">Specifies user configured description for the app instance..</param>
        /// <param name="durationUsecs">Specifies duration (in microseconds) for which the app instance has run..</param>
        /// <param name="healthDetail">Specifies the reason the app instance is unhealthy. Only set if app instance is unhealthy..</param>
        /// <param name="healthStatus">Specifies the current health status of the app instance..</param>
        /// <param name="nodeIp">Specifies the ip of the node which can be used to contact app instance external services..</param>
        /// <param name="nodePort">Specifies the node port on which the app instance services external requests..</param>
        /// <param name="settings">settings.</param>
        /// <param name="state">Specifies the current state of the app instance. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error..</param>
        /// <param name="stateDetail">Specifies the failure reason when the app instance&#39;s state is kFailed..</param>
        public AppInstance(string appAccessToken = default(string), long? appInstanceId = default(long?), string appName = default(string), long? appUid = default(long?), long? appVersion = default(long?), long? createdTimeUsecs = default(long?), string creationUid = default(string), string description = default(string), long? durationUsecs = default(long?), string healthDetail = default(string), int? healthStatus = default(int?), string nodeIp = default(string), int? nodePort = default(int?), AppInstanceSettings settings = default(AppInstanceSettings), StateEnum? state = default(StateEnum?), string stateDetail = default(string))
        {
            this.AppAccessToken = appAccessToken;
            this.AppInstanceId = appInstanceId;
            this.AppName = appName;
            this.AppUid = appUid;
            this.AppVersion = appVersion;
            this.CreatedTimeUsecs = createdTimeUsecs;
            this.CreationUid = creationUid;
            this.Description = description;
            this.DurationUsecs = durationUsecs;
            this.HealthDetail = healthDetail;
            this.HealthStatus = healthStatus;
            this.NodeIp = nodeIp;
            this.NodePort = nodePort;
            this.State = state;
            this.StateDetail = stateDetail;
            this.AppAccessToken = appAccessToken;
            this.AppInstanceId = appInstanceId;
            this.AppName = appName;
            this.AppUid = appUid;
            this.AppVersion = appVersion;
            this.CreatedTimeUsecs = createdTimeUsecs;
            this.CreationUid = creationUid;
            this.Description = description;
            this.DurationUsecs = durationUsecs;
            this.HealthDetail = healthDetail;
            this.HealthStatus = healthStatus;
            this.NodeIp = nodeIp;
            this.NodePort = nodePort;
            this.Settings = settings;
            this.State = state;
            this.StateDetail = stateDetail;
        }
        
        /// <summary>
        /// Specifies the token to access with the app.
        /// </summary>
        /// <value>Specifies the token to access with the app.</value>
        [DataMember(Name="appAccessToken", EmitDefaultValue=true)]
        public string AppAccessToken { get; set; }

        /// <summary>
        /// Specifies unique id across all instances of all apps.
        /// </summary>
        /// <value>Specifies unique id across all instances of all apps.</value>
        [DataMember(Name="appInstanceId", EmitDefaultValue=true)]
        public long? AppInstanceId { get; set; }

        /// <summary>
        /// Specifies name of the app that is launched in this instance.
        /// </summary>
        /// <value>Specifies name of the app that is launched in this instance.</value>
        [DataMember(Name="appName", EmitDefaultValue=true)]
        public string AppName { get; set; }

        /// <summary>
        /// Specifies id of the app that is launched in this instance.
        /// </summary>
        /// <value>Specifies id of the app that is launched in this instance.</value>
        [DataMember(Name="appUid", EmitDefaultValue=true)]
        public long? AppUid { get; set; }

        /// <summary>
        /// Specifies the version of the app that is launched in this instance.
        /// </summary>
        /// <value>Specifies the version of the app that is launched in this instance.</value>
        [DataMember(Name="appVersion", EmitDefaultValue=true)]
        public long? AppVersion { get; set; }

        /// <summary>
        /// Specifies timestamp (in microseconds) when the app instance was first created.
        /// </summary>
        /// <value>Specifies timestamp (in microseconds) when the app instance was first created.</value>
        [DataMember(Name="createdTimeUsecs", EmitDefaultValue=true)]
        public long? CreatedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies an unique identifier generated by the client to let the backend identify retries of the app launch request.
        /// </summary>
        /// <value>Specifies an unique identifier generated by the client to let the backend identify retries of the app launch request.</value>
        [DataMember(Name="creationUid", EmitDefaultValue=true)]
        public string CreationUid { get; set; }

        /// <summary>
        /// Specifies user configured description for the app instance.
        /// </summary>
        /// <value>Specifies user configured description for the app instance.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies duration (in microseconds) for which the app instance has run.
        /// </summary>
        /// <value>Specifies duration (in microseconds) for which the app instance has run.</value>
        [DataMember(Name="durationUsecs", EmitDefaultValue=true)]
        public long? DurationUsecs { get; set; }

        /// <summary>
        /// Specifies the reason the app instance is unhealthy. Only set if app instance is unhealthy.
        /// </summary>
        /// <value>Specifies the reason the app instance is unhealthy. Only set if app instance is unhealthy.</value>
        [DataMember(Name="healthDetail", EmitDefaultValue=true)]
        public string HealthDetail { get; set; }

        /// <summary>
        /// Specifies the current health status of the app instance.
        /// </summary>
        /// <value>Specifies the current health status of the app instance.</value>
        [DataMember(Name="healthStatus", EmitDefaultValue=true)]
        public int? HealthStatus { get; set; }

        /// <summary>
        /// Specifies the ip of the node which can be used to contact app instance external services.
        /// </summary>
        /// <value>Specifies the ip of the node which can be used to contact app instance external services.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=true)]
        public string NodeIp { get; set; }

        /// <summary>
        /// Specifies the node port on which the app instance services external requests.
        /// </summary>
        /// <value>Specifies the node port on which the app instance services external requests.</value>
        [DataMember(Name="nodePort", EmitDefaultValue=true)]
        public int? NodePort { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AppInstanceSettings Settings { get; set; }

        /// <summary>
        /// Specifies the failure reason when the app instance&#39;s state is kFailed.
        /// </summary>
        /// <value>Specifies the failure reason when the app instance&#39;s state is kFailed.</value>
        [DataMember(Name="stateDetail", EmitDefaultValue=true)]
        public string StateDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppInstance {\n");
            sb.Append("  AppAccessToken: ").Append(AppAccessToken).Append("\n");
            sb.Append("  AppInstanceId: ").Append(AppInstanceId).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppUid: ").Append(AppUid).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  CreatedTimeUsecs: ").Append(CreatedTimeUsecs).Append("\n");
            sb.Append("  CreationUid: ").Append(CreationUid).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DurationUsecs: ").Append(DurationUsecs).Append("\n");
            sb.Append("  HealthDetail: ").Append(HealthDetail).Append("\n");
            sb.Append("  HealthStatus: ").Append(HealthStatus).Append("\n");
            sb.Append("  NodeIp: ").Append(NodeIp).Append("\n");
            sb.Append("  NodePort: ").Append(NodePort).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateDetail: ").Append(StateDetail).Append("\n");
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
            return this.Equals(input as AppInstance);
        }

        /// <summary>
        /// Returns true if AppInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppAccessToken == input.AppAccessToken ||
                    (this.AppAccessToken != null &&
                    this.AppAccessToken.Equals(input.AppAccessToken))
                ) && 
                (
                    this.AppInstanceId == input.AppInstanceId ||
                    (this.AppInstanceId != null &&
                    this.AppInstanceId.Equals(input.AppInstanceId))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppUid == input.AppUid ||
                    (this.AppUid != null &&
                    this.AppUid.Equals(input.AppUid))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.CreatedTimeUsecs == input.CreatedTimeUsecs ||
                    (this.CreatedTimeUsecs != null &&
                    this.CreatedTimeUsecs.Equals(input.CreatedTimeUsecs))
                ) && 
                (
                    this.CreationUid == input.CreationUid ||
                    (this.CreationUid != null &&
                    this.CreationUid.Equals(input.CreationUid))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DurationUsecs == input.DurationUsecs ||
                    (this.DurationUsecs != null &&
                    this.DurationUsecs.Equals(input.DurationUsecs))
                ) && 
                (
                    this.HealthDetail == input.HealthDetail ||
                    (this.HealthDetail != null &&
                    this.HealthDetail.Equals(input.HealthDetail))
                ) && 
                (
                    this.HealthStatus == input.HealthStatus ||
                    (this.HealthStatus != null &&
                    this.HealthStatus.Equals(input.HealthStatus))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.NodePort == input.NodePort ||
                    (this.NodePort != null &&
                    this.NodePort.Equals(input.NodePort))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.StateDetail == input.StateDetail ||
                    (this.StateDetail != null &&
                    this.StateDetail.Equals(input.StateDetail))
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
                if (this.AppAccessToken != null)
                    hashCode = hashCode * 59 + this.AppAccessToken.GetHashCode();
                if (this.AppInstanceId != null)
                    hashCode = hashCode * 59 + this.AppInstanceId.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppUid != null)
                    hashCode = hashCode * 59 + this.AppUid.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.CreatedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeUsecs.GetHashCode();
                if (this.CreationUid != null)
                    hashCode = hashCode * 59 + this.CreationUid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DurationUsecs != null)
                    hashCode = hashCode * 59 + this.DurationUsecs.GetHashCode();
                if (this.HealthDetail != null)
                    hashCode = hashCode * 59 + this.HealthDetail.GetHashCode();
                if (this.HealthStatus != null)
                    hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.NodePort != null)
                    hashCode = hashCode * 59 + this.NodePort.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateDetail != null)
                    hashCode = hashCode * 59 + this.StateDetail.GetHashCode();
                return hashCode;
            }
        }

    }

}
