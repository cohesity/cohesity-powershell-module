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
    /// Specifies various resources when converting and deploying a VM to GCP.
    /// </summary>
    [DataContract]
    public partial class GcpParams :  IEquatable<GcpParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpParams" /> class.
        /// </summary>
        /// <param name="instanceId">Specifies id of the GCP instance type in which to deploy the VM..</param>
        /// <param name="region">Specifies id of the GCP region in which to deploy the VM..</param>
        /// <param name="subnetId">Specifies id of the subnet within above VPC..</param>
        /// <param name="virtualPrivateCloudId">Specifies id of the Virtual Private Cloud to chose for the instance type..</param>
        public GcpParams(long? instanceId = default(long?), long? region = default(long?), long? subnetId = default(long?), long? virtualPrivateCloudId = default(long?))
        {
            this.InstanceId = instanceId;
            this.Region = region;
            this.SubnetId = subnetId;
            this.VirtualPrivateCloudId = virtualPrivateCloudId;
            this.InstanceId = instanceId;
            this.Region = region;
            this.SubnetId = subnetId;
            this.VirtualPrivateCloudId = virtualPrivateCloudId;
        }
        
        /// <summary>
        /// Specifies id of the GCP instance type in which to deploy the VM.
        /// </summary>
        /// <value>Specifies id of the GCP instance type in which to deploy the VM.</value>
        [DataMember(Name="instanceId", EmitDefaultValue=true)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// Specifies id of the GCP region in which to deploy the VM.
        /// </summary>
        /// <value>Specifies id of the GCP region in which to deploy the VM.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public long? Region { get; set; }

        /// <summary>
        /// Specifies id of the subnet within above VPC.
        /// </summary>
        /// <value>Specifies id of the subnet within above VPC.</value>
        [DataMember(Name="subnetId", EmitDefaultValue=true)]
        public long? SubnetId { get; set; }

        /// <summary>
        /// Specifies id of the Virtual Private Cloud to chose for the instance type.
        /// </summary>
        /// <value>Specifies id of the Virtual Private Cloud to chose for the instance type.</value>
        [DataMember(Name="virtualPrivateCloudId", EmitDefaultValue=true)]
        public long? VirtualPrivateCloudId { get; set; }

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
            return this.Equals(input as GcpParams);
        }

        /// <summary>
        /// Returns true if GcpParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.VirtualPrivateCloudId == input.VirtualPrivateCloudId ||
                    (this.VirtualPrivateCloudId != null &&
                    this.VirtualPrivateCloudId.Equals(input.VirtualPrivateCloudId))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.VirtualPrivateCloudId != null)
                    hashCode = hashCode * 59 + this.VirtualPrivateCloudId.GetHashCode();
                return hashCode;
            }
        }

    }

}

