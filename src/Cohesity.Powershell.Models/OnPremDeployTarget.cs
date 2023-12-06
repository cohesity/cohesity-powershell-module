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
    /// Message that specifies the details about OnPremDeploy target where backup snapshots may be converted and deployed.
    /// </summary>
    [DataContract]
    public partial class OnPremDeployTarget :  IEquatable<OnPremDeployTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnPremDeployTarget" /> class.
        /// </summary>
        /// <param name="deployVmsToOnpremParams">deployVmsToOnpremParams.</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="type">The type of the OnPremDeploy target. Only VMware is supported for now..</param>
        public OnPremDeployTarget(DeployVMsToOnPremParams deployVmsToOnpremParams = default(DeployVMsToOnPremParams), EntityProto targetEntity = default(EntityProto), int? type = default(int?))
        {
            this.Type = type;
            this.DeployVmsToOnpremParams = deployVmsToOnpremParams;
            this.TargetEntity = targetEntity;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets DeployVmsToOnpremParams
        /// </summary>
        [DataMember(Name="deployVmsToOnpremParams", EmitDefaultValue=false)]
        public DeployVMsToOnPremParams DeployVmsToOnpremParams { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// The type of the OnPremDeploy target. Only VMware is supported for now.
        /// </summary>
        /// <value>The type of the OnPremDeploy target. Only VMware is supported for now.</value>
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
            return this.Equals(input as OnPremDeployTarget);
        }

        /// <summary>
        /// Returns true if OnPremDeployTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of OnPremDeployTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnPremDeployTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployVmsToOnpremParams == input.DeployVmsToOnpremParams ||
                    (this.DeployVmsToOnpremParams != null &&
                    this.DeployVmsToOnpremParams.Equals(input.DeployVmsToOnpremParams))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
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
                if (this.DeployVmsToOnpremParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToOnpremParams.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

