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
    /// Specifies an Object containing information about a registered Universal Data Adapter source.
    /// </summary>
    [DataContract]
    public partial class UdaConnectParams :  IEquatable<UdaConnectParams>
    {
        /// <summary>
        /// Specifies the environment type for the host.
        /// </summary>
        /// <value>Specifies the environment type for the host.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the environment type for the host.
        /// </summary>
        /// <value>Specifies the environment type for the host.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaConnectParams" /> class.
        /// </summary>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="hostType">Specifies the environment type for the host..</param>
        /// <param name="hosts">List of hosts forming the Universal Data Adapter cluster..</param>
        /// <param name="liveDataView">Whether to use a live view for data backups..</param>
        /// <param name="liveLogView">Whether to use a live view for log backups..</param>
        /// <param name="mountDir">This field is deprecated and its value will be ignored. It was used to specify the absolute path on the host where the view would be mounted. This is now controlled by the agent configuration and is common for all the Universal Data Adapter sources. deprecated: true.</param>
        /// <param name="mountView">Whether to mount a view during the source backup..</param>
        /// <param name="scriptDir">Path where various source scripts will be located..</param>
        /// <param name="sourceArgs">Custom arguments which will be provided to the source registration scripts..</param>
        /// <param name="sourceType">Global app source type..</param>
        public UdaConnectParams(UdaSourceCapabilities capabilities = default(UdaSourceCapabilities), HostTypeEnum? hostType = default(HostTypeEnum?), List<string> hosts = default(List<string>), bool? liveDataView = default(bool?), bool? liveLogView = default(bool?), string mountDir = default(string), bool? mountView = default(bool?), string scriptDir = default(string), string sourceArgs = default(string), string sourceType = default(string))
        {
            this.Capabilities = capabilities;
            this.HostType = hostType;
            this.Hosts = hosts;
            this.LiveDataView = liveDataView;
            this.LiveLogView = liveLogView;
            this.MountDir = mountDir;
            this.MountView = mountView;
            this.ScriptDir = scriptDir;
            this.SourceArgs = sourceArgs;
            this.SourceType = sourceType;
        }
        
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public UdaSourceCapabilities Capabilities { get; set; }


        /// <summary>
        /// List of hosts forming the Universal Data Adapter cluster.
        /// </summary>
        /// <value>List of hosts forming the Universal Data Adapter cluster.</value>
        [DataMember(Name="hosts", EmitDefaultValue=false)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Whether to use a live view for data backups.
        /// </summary>
        /// <value>Whether to use a live view for data backups.</value>
        [DataMember(Name="liveDataView", EmitDefaultValue=false)]
        public bool? LiveDataView { get; set; }

        /// <summary>
        /// Whether to use a live view for log backups.
        /// </summary>
        /// <value>Whether to use a live view for log backups.</value>
        [DataMember(Name="liveLogView", EmitDefaultValue=false)]
        public bool? LiveLogView { get; set; }

        /// <summary>
        /// This field is deprecated and its value will be ignored. It was used to specify the absolute path on the host where the view would be mounted. This is now controlled by the agent configuration and is common for all the Universal Data Adapter sources. deprecated: true
        /// </summary>
        /// <value>This field is deprecated and its value will be ignored. It was used to specify the absolute path on the host where the view would be mounted. This is now controlled by the agent configuration and is common for all the Universal Data Adapter sources. deprecated: true</value>
        [DataMember(Name="mountDir", EmitDefaultValue=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// Whether to mount a view during the source backup.
        /// </summary>
        /// <value>Whether to mount a view during the source backup.</value>
        [DataMember(Name="mountView", EmitDefaultValue=false)]
        public bool? MountView { get; set; }

        /// <summary>
        /// Path where various source scripts will be located.
        /// </summary>
        /// <value>Path where various source scripts will be located.</value>
        [DataMember(Name="scriptDir", EmitDefaultValue=false)]
        public string ScriptDir { get; set; }

        /// <summary>
        /// Custom arguments which will be provided to the source registration scripts.
        /// </summary>
        /// <value>Custom arguments which will be provided to the source registration scripts.</value>
        [DataMember(Name="sourceArgs", EmitDefaultValue=false)]
        public string SourceArgs { get; set; }

        /// <summary>
        /// Global app source type.
        /// </summary>
        /// <value>Global app source type.</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public string SourceType { get; set; }

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
            return this.Equals(input as UdaConnectParams);
        }

        /// <summary>
        /// Returns true if UdaConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    this.Hosts.Equals(input.Hosts)
                ) && 
                (
                    this.LiveDataView == input.LiveDataView ||
                    (this.LiveDataView != null &&
                    this.LiveDataView.Equals(input.LiveDataView))
                ) && 
                (
                    this.LiveLogView == input.LiveLogView ||
                    (this.LiveLogView != null &&
                    this.LiveLogView.Equals(input.LiveLogView))
                ) && 
                (
                    this.MountDir == input.MountDir ||
                    (this.MountDir != null &&
                    this.MountDir.Equals(input.MountDir))
                ) && 
                (
                    this.MountView == input.MountView ||
                    (this.MountView != null &&
                    this.MountView.Equals(input.MountView))
                ) && 
                (
                    this.ScriptDir == input.ScriptDir ||
                    (this.ScriptDir != null &&
                    this.ScriptDir.Equals(input.ScriptDir))
                ) && 
                (
                    this.SourceArgs == input.SourceArgs ||
                    (this.SourceArgs != null &&
                    this.SourceArgs.Equals(input.SourceArgs))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
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
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.LiveDataView != null)
                    hashCode = hashCode * 59 + this.LiveDataView.GetHashCode();
                if (this.LiveLogView != null)
                    hashCode = hashCode * 59 + this.LiveLogView.GetHashCode();
                if (this.MountDir != null)
                    hashCode = hashCode * 59 + this.MountDir.GetHashCode();
                if (this.MountView != null)
                    hashCode = hashCode * 59 + this.MountView.GetHashCode();
                if (this.ScriptDir != null)
                    hashCode = hashCode * 59 + this.ScriptDir.GetHashCode();
                if (this.SourceArgs != null)
                    hashCode = hashCode * 59 + this.SourceArgs.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                return hashCode;
            }
        }

    }

}

