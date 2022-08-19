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
    /// A message to encapsulate pre or post script associated with a backup job policy.
    /// </summary>
    [DataContract]
    public partial class ScriptPathAndParams :  IEquatable<ScriptPathAndParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptPathAndParams" /> class.
        /// </summary>
        /// <param name="continueOnError">Applicable only for pre backup scripts. If this flag is set to true, then backup job will start even if the pre backup script fails..</param>
        /// <param name="isActive">Indicates if the script is active. If &#39;is_active&#39; is set to false, this script will not be executed even if it is part of the backup job..</param>
        /// <param name="scriptParams">Custom parameters that users want to pass to the script. For example, if user wants to pass following params: 1. foo&#x3D;bar 2. v&#x3D;10. User can construct the param string as \&quot;far&#x3D;bar v&#x3D;10\&quot;..</param>
        /// <param name="scriptPath">For backup jobs of type &#39;kPuppeteer&#39;, &#39;script_path&#39; is full path of location of the script within the host. For Pre/Post scripts of agent-based backup jobs, &#39;script_path&#39; is just name of the script, not full path..</param>
        /// <param name="timeoutSecs">Timeout of the script. The script will be killed if it exceeds this value. &#39;-1&#39; indicates that the timeout is not set for the script..</param>
        public ScriptPathAndParams(bool? continueOnError = default(bool?), bool? isActive = default(bool?), string scriptParams = default(string), string scriptPath = default(string), int? timeoutSecs = default(int?))
        {
            this.ContinueOnError = continueOnError;
            this.IsActive = isActive;
            this.ScriptParams = scriptParams;
            this.ScriptPath = scriptPath;
            this.TimeoutSecs = timeoutSecs;
        }
        
        /// <summary>
        /// Applicable only for pre backup scripts. If this flag is set to true, then backup job will start even if the pre backup script fails.
        /// </summary>
        /// <value>Applicable only for pre backup scripts. If this flag is set to true, then backup job will start even if the pre backup script fails.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Indicates if the script is active. If &#39;is_active&#39; is set to false, this script will not be executed even if it is part of the backup job.
        /// </summary>
        /// <value>Indicates if the script is active. If &#39;is_active&#39; is set to false, this script will not be executed even if it is part of the backup job.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Custom parameters that users want to pass to the script. For example, if user wants to pass following params: 1. foo&#x3D;bar 2. v&#x3D;10. User can construct the param string as \&quot;far&#x3D;bar v&#x3D;10\&quot;.
        /// </summary>
        /// <value>Custom parameters that users want to pass to the script. For example, if user wants to pass following params: 1. foo&#x3D;bar 2. v&#x3D;10. User can construct the param string as \&quot;far&#x3D;bar v&#x3D;10\&quot;.</value>
        [DataMember(Name="scriptParams", EmitDefaultValue=true)]
        public string ScriptParams { get; set; }

        /// <summary>
        /// For backup jobs of type &#39;kPuppeteer&#39;, &#39;script_path&#39; is full path of location of the script within the host. For Pre/Post scripts of agent-based backup jobs, &#39;script_path&#39; is just name of the script, not full path.
        /// </summary>
        /// <value>For backup jobs of type &#39;kPuppeteer&#39;, &#39;script_path&#39; is full path of location of the script within the host. For Pre/Post scripts of agent-based backup jobs, &#39;script_path&#39; is just name of the script, not full path.</value>
        [DataMember(Name="scriptPath", EmitDefaultValue=true)]
        public string ScriptPath { get; set; }

        /// <summary>
        /// Timeout of the script. The script will be killed if it exceeds this value. &#39;-1&#39; indicates that the timeout is not set for the script.
        /// </summary>
        /// <value>Timeout of the script. The script will be killed if it exceeds this value. &#39;-1&#39; indicates that the timeout is not set for the script.</value>
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
            return this.Equals(input as ScriptPathAndParams);
        }

        /// <summary>
        /// Returns true if ScriptPathAndParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptPathAndParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptPathAndParams input)
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

