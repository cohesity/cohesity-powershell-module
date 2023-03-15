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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  RestoreFilesInfoProto extension                  Location               Extn &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::RestoreFilesInfo::vmware_restore_files_info vmware/vmware.proto     100 AgentRestoreFilesInfo::agent_restore_files_info  base/agent.proto        101 file::RestoreFilesInfo::restore_files_info file/file.proto         102 hyperv::RestoreFilesInfo::hyperv_restore_files_info hyperv/hyperv.proto     103 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class RestoreFilesInfoProto :  IEquatable<RestoreFilesInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesInfoProto" /> class.
        /// </summary>
        /// <param name="downloadFilesPath">The path that the user should use to download files through the UI. If only a single file needs to be downloaded, this will be the path to that file. If a directory or multiple files &amp; directories need to be downloaded, this will be the path to the .zip file to download. Only applicable to a download files task..</param>
        /// <param name="error">error.</param>
        /// <param name="proxyEntityConnectorParams">proxyEntityConnectorParams.</param>
        /// <param name="restoreFilesResultVec">Contains the result information of the restored files..</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="targetType">Specifies the target type for the task. The field is only valid if the task has got a permit..</param>
        /// <param name="teardownError">teardownError.</param>
        /// <param name="type">The type of environment this restore files info pertains to..</param>
        public RestoreFilesInfoProto(string downloadFilesPath = default(string), ErrorProto error = default(ErrorProto), ConnectorParams proxyEntityConnectorParams = default(ConnectorParams), List<RestoreFileResultInfo> restoreFilesResultVec = default(List<RestoreFileResultInfo>), long? slaveTaskStartTimeUsecs = default(long?), int? targetType = default(int?), ErrorProto teardownError = default(ErrorProto), int? type = default(int?))
        {
            this.DownloadFilesPath = downloadFilesPath;
            this.RestoreFilesResultVec = restoreFilesResultVec;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.TargetType = targetType;
            this.Type = type;
            this.DownloadFilesPath = downloadFilesPath;
            this.Error = error;
            this.ProxyEntityConnectorParams = proxyEntityConnectorParams;
            this.RestoreFilesResultVec = restoreFilesResultVec;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.TargetType = targetType;
            this.TeardownError = teardownError;
            this.Type = type;
        }
        
        /// <summary>
        /// The path that the user should use to download files through the UI. If only a single file needs to be downloaded, this will be the path to that file. If a directory or multiple files &amp; directories need to be downloaded, this will be the path to the .zip file to download. Only applicable to a download files task.
        /// </summary>
        /// <value>The path that the user should use to download files through the UI. If only a single file needs to be downloaded, this will be the path to that file. If a directory or multiple files &amp; directories need to be downloaded, this will be the path to the .zip file to download. Only applicable to a download files task.</value>
        [DataMember(Name="downloadFilesPath", EmitDefaultValue=true)]
        public string DownloadFilesPath { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Gets or Sets ProxyEntityConnectorParams
        /// </summary>
        [DataMember(Name="proxyEntityConnectorParams", EmitDefaultValue=false)]
        public ConnectorParams ProxyEntityConnectorParams { get; set; }

        /// <summary>
        /// Contains the result information of the restored files.
        /// </summary>
        /// <value>Contains the result information of the restored files.</value>
        [DataMember(Name="restoreFilesResultVec", EmitDefaultValue=true)]
        public List<RestoreFileResultInfo> RestoreFilesResultVec { get; set; }

        /// <summary>
        /// This is the timestamp at which the slave task started.
        /// </summary>
        /// <value>This is the timestamp at which the slave task started.</value>
        [DataMember(Name="slaveTaskStartTimeUsecs", EmitDefaultValue=true)]
        public long? SlaveTaskStartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the target type for the task. The field is only valid if the task has got a permit.
        /// </summary>
        /// <value>Specifies the target type for the task. The field is only valid if the task has got a permit.</value>
        [DataMember(Name="targetType", EmitDefaultValue=true)]
        public int? TargetType { get; set; }

        /// <summary>
        /// Gets or Sets TeardownError
        /// </summary>
        [DataMember(Name="teardownError", EmitDefaultValue=false)]
        public ErrorProto TeardownError { get; set; }

        /// <summary>
        /// The type of environment this restore files info pertains to.
        /// </summary>
        /// <value>The type of environment this restore files info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as RestoreFilesInfoProto);
        }

        /// <summary>
        /// Returns true if RestoreFilesInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DownloadFilesPath == input.DownloadFilesPath ||
                    (this.DownloadFilesPath != null &&
                    this.DownloadFilesPath.Equals(input.DownloadFilesPath))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ProxyEntityConnectorParams == input.ProxyEntityConnectorParams ||
                    (this.ProxyEntityConnectorParams != null &&
                    this.ProxyEntityConnectorParams.Equals(input.ProxyEntityConnectorParams))
                ) && 
                (
                    this.RestoreFilesResultVec == input.RestoreFilesResultVec ||
                    this.RestoreFilesResultVec != null &&
                    input.RestoreFilesResultVec != null &&
                    this.RestoreFilesResultVec.SequenceEqual(input.RestoreFilesResultVec)
                ) && 
                (
                    this.SlaveTaskStartTimeUsecs == input.SlaveTaskStartTimeUsecs ||
                    (this.SlaveTaskStartTimeUsecs != null &&
                    this.SlaveTaskStartTimeUsecs.Equals(input.SlaveTaskStartTimeUsecs))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TeardownError == input.TeardownError ||
                    (this.TeardownError != null &&
                    this.TeardownError.Equals(input.TeardownError))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DownloadFilesPath != null)
                    hashCode = hashCode * 59 + this.DownloadFilesPath.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ProxyEntityConnectorParams != null)
                    hashCode = hashCode * 59 + this.ProxyEntityConnectorParams.GetHashCode();
                if (this.RestoreFilesResultVec != null)
                    hashCode = hashCode * 59 + this.RestoreFilesResultVec.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TeardownError != null)
                    hashCode = hashCode * 59 + this.TeardownError.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

