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
    /// Specifies the path to the remote script and any parameters expected by the remote script.
    /// </summary>
    [DataContract]
    public partial class RemoteScriptPathAndParams :  IEquatable<RemoteScriptPathAndParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteScriptPathAndParams" /> class.
        /// </summary>
        /// <param name="continueOnError">Specifies if the script needs to continue even if there is an occurence of an error. If this flag is set to true, then backup job will start even if the pre backup script fails. Applicable only for pre backup scripts..</param>
        /// <param name="isActive">Specifies if the script is active. If set to false, this script will not be executed even if it is part of the backup job..</param>
        /// <param name="scriptParams">Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;..</param>
        /// <param name="scriptPath">Specifies the path to the script on the remote host..</param>
        /// <param name="timeoutSecs">Specifies the timeout of the script in seconds. The script will be killed if it exceeds this value. If the value of the field is &#39;-1&#39; then timeout is not set for the script..</param>
        public RemoteScriptPathAndParams(bool? continueOnError = default(bool?), bool? isActive = default(bool?), string scriptParams = default(string), string scriptPath = default(string), int? timeoutSecs = default(int?))
        {
            this.ContinueOnError = continueOnError;
            this.IsActive = isActive;
            this.ScriptParams = scriptParams;
            this.ScriptPath = scriptPath;
            this.TimeoutSecs = timeoutSecs;
            this.ContinueOnError = continueOnError;
            this.IsActive = isActive;
            this.ScriptParams = scriptParams;
            this.ScriptPath = scriptPath;
            this.TimeoutSecs = timeoutSecs;
        }
        
        /// <summary>
        /// Specifies if the script needs to continue even if there is an occurence of an error. If this flag is set to true, then backup job will start even if the pre backup script fails. Applicable only for pre backup scripts.
        /// </summary>
        /// <value>Specifies if the script needs to continue even if there is an occurence of an error. If this flag is set to true, then backup job will start even if the pre backup script fails. Applicable only for pre backup scripts.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Specifies if the script is active. If set to false, this script will not be executed even if it is part of the backup job.
        /// </summary>
        /// <value>Specifies if the script is active. If set to false, this script will not be executed even if it is part of the backup job.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.
        /// </summary>
        /// <value>Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.</value>
        [DataMember(Name="scriptParams", EmitDefaultValue=true)]
        public string ScriptParams { get; set; }

        /// <summary>
        /// Specifies the path to the script on the remote host.
        /// </summary>
        /// <value>Specifies the path to the script on the remote host.</value>
        [DataMember(Name="scriptPath", EmitDefaultValue=true)]
        public string ScriptPath { get; set; }

        /// <summary>
        /// Specifies the timeout of the script in seconds. The script will be killed if it exceeds this value. If the value of the field is &#39;-1&#39; then timeout is not set for the script.
        /// </summary>
        /// <value>Specifies the timeout of the script in seconds. The script will be killed if it exceeds this value. If the value of the field is &#39;-1&#39; then timeout is not set for the script.</value>
        [DataMember(Name="timeoutSecs", EmitDefaultValue=true)]
        public int? TimeoutSecs { get; set; }

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
            return this.Equals(input as RemoteScriptPathAndParams);
        }

        /// <summary>
        /// Returns true if RemoteScriptPathAndParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteScriptPathAndParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteScriptPathAndParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.ScriptParams == input.ScriptParams ||
                    (this.ScriptParams != null &&
                    this.ScriptParams.Equals(input.ScriptParams))
                ) && 
                (
                    this.ScriptPath == input.ScriptPath ||
                    (this.ScriptPath != null &&
                    this.ScriptPath.Equals(input.ScriptPath))
                ) && 
                (
                    this.TimeoutSecs == input.TimeoutSecs ||
                    (this.TimeoutSecs != null &&
                    this.TimeoutSecs.Equals(input.TimeoutSecs))
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
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.ScriptParams != null)
                    hashCode = hashCode * 59 + this.ScriptParams.GetHashCode();
                if (this.ScriptPath != null)
                    hashCode = hashCode * 59 + this.ScriptPath.GetHashCode();
                if (this.TimeoutSecs != null)
                    hashCode = hashCode * 59 + this.TimeoutSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

