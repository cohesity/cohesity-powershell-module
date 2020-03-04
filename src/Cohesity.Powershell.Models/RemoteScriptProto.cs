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
    /// Message to encapsulate the information of script that can be executed either before or after the backup is taken.
    /// </summary>
    [DataContract]
    public partial class RemoteScriptProto :  IEquatable<RemoteScriptProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteScriptProto" /> class.
        /// </summary>
        /// <param name="remoteHostParams">remoteHostParams.</param>
        /// <param name="script">script.</param>
        /// <param name="status">status.</param>
        public RemoteScriptProto(RemoteHostConnectorParams remoteHostParams = default(RemoteHostConnectorParams), ScriptPathAndParams script = default(ScriptPathAndParams), ScriptExecutionStatus status = default(ScriptExecutionStatus))
        {
            this.RemoteHostParams = remoteHostParams;
            this.Script = script;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets RemoteHostParams
        /// </summary>
        [DataMember(Name="remoteHostParams", EmitDefaultValue=false)]
        public RemoteHostConnectorParams RemoteHostParams { get; set; }

        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public ScriptPathAndParams Script { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ScriptExecutionStatus Status { get; set; }

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
            return this.Equals(input as RemoteScriptProto);
        }

        /// <summary>
        /// Returns true if RemoteScriptProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteScriptProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteScriptProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteHostParams == input.RemoteHostParams ||
                    (this.RemoteHostParams != null &&
                    this.RemoteHostParams.Equals(input.RemoteHostParams))
                ) && 
                (
                    this.Script == input.Script ||
                    (this.Script != null &&
                    this.Script.Equals(input.Script))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.RemoteHostParams != null)
                    hashCode = hashCode * 59 + this.RemoteHostParams.GetHashCode();
                if (this.Script != null)
                    hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

