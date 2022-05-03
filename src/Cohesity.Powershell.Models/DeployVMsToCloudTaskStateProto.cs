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
    /// DeployVMsToCloudTaskStateProto
    /// </summary>
    [DataContract]
    public partial class DeployVMsToCloudTaskStateProto :  IEquatable<DeployVMsToCloudTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVMsToCloudTaskStateProto" /> class.
        /// </summary>
        /// <param name="deployVmsToCloudParams">deployVmsToCloudParams.</param>
        public DeployVMsToCloudTaskStateProto(DeployVMsToCloudParams deployVmsToCloudParams = default(DeployVMsToCloudParams))
        {
            this.DeployVmsToCloudParams = deployVmsToCloudParams;
        }
        
        /// <summary>
        /// Gets or Sets DeployVmsToCloudParams
        /// </summary>
        [DataMember(Name="deployVmsToCloudParams", EmitDefaultValue=false)]
        public DeployVMsToCloudParams DeployVmsToCloudParams { get; set; }

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
            return this.Equals(input as DeployVMsToCloudTaskStateProto);
        }

        /// <summary>
        /// Returns true if DeployVMsToCloudTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVMsToCloudTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVMsToCloudTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployVmsToCloudParams == input.DeployVmsToCloudParams ||
                    (this.DeployVmsToCloudParams != null &&
                    this.DeployVmsToCloudParams.Equals(input.DeployVmsToCloudParams))
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
                if (this.DeployVmsToCloudParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloudParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

