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
    /// Contains the onprem specific information needed to identify various resources when deploying a VM.
    /// </summary>
    [DataContract]
    public partial class DeployVMsToOnPremParams :  IEquatable<DeployVMsToOnPremParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVMsToOnPremParams" /> class.
        /// </summary>
        /// <param name="deployVmsToVmwareParams">deployVmsToVmwareParams.</param>
        public DeployVMsToOnPremParams(RestoreVMwareVMParams deployVmsToVmwareParams = default(RestoreVMwareVMParams))
        {
            this.DeployVmsToVmwareParams = deployVmsToVmwareParams;
        }
        
        /// <summary>
        /// Gets or Sets DeployVmsToVmwareParams
        /// </summary>
        [DataMember(Name="deployVmsToVmwareParams", EmitDefaultValue=false)]
        public RestoreVMwareVMParams DeployVmsToVmwareParams { get; set; }

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
            return this.Equals(input as DeployVMsToOnPremParams);
        }

        /// <summary>
        /// Returns true if DeployVMsToOnPremParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVMsToOnPremParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVMsToOnPremParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployVmsToVmwareParams == input.DeployVmsToVmwareParams ||
                    (this.DeployVmsToVmwareParams != null &&
                    this.DeployVmsToVmwareParams.Equals(input.DeployVmsToVmwareParams))
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
                if (this.DeployVmsToVmwareParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToVmwareParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

