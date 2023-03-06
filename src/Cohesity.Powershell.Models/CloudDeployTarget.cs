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
    /// Message that specifies the details about CloudDeploy target where backup snapshots may be converted and stored.
    /// </summary>
    [DataContract]
    public partial class CloudDeployTarget :  IEquatable<CloudDeployTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDeployTarget" /> class.
        /// </summary>
        /// <param name="deployVmsToCloudParams">deployVmsToCloudParams.</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="type">The type of the CloudDeploy target..</param>
        public CloudDeployTarget(DeployVMsToCloudParams deployVmsToCloudParams = default(DeployVMsToCloudParams), EntityProto targetEntity = default(EntityProto), int? type = default(int?))
        {
            this.Type = type;
            this.DeployVmsToCloudParams = deployVmsToCloudParams;
            this.TargetEntity = targetEntity;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets DeployVmsToCloudParams
        /// </summary>
        [DataMember(Name="deployVmsToCloudParams", EmitDefaultValue=false)]
        public DeployVMsToCloudParams DeployVmsToCloudParams { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// The type of the CloudDeploy target.
        /// </summary>
        /// <value>The type of the CloudDeploy target.</value>
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
            return this.Equals(input as CloudDeployTarget);
        }

        /// <summary>
        /// Returns true if CloudDeployTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDeployTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDeployTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployVmsToCloudParams == input.DeployVmsToCloudParams ||
                    (this.DeployVmsToCloudParams != null &&
                    this.DeployVmsToCloudParams.Equals(input.DeployVmsToCloudParams))
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
                if (this.DeployVmsToCloudParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloudParams.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

