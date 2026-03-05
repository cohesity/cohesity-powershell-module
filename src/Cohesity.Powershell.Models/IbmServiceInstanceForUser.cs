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
    /// IbmServiceInstanceForUser specifies the data model for representing the service instance details that are needed by Helios for currently logged in IBM IAM user. Note that this data model have some similaraties with IbmServiceInstance defined in ibm_data.go. But the use is different for both structs.
    /// </summary>
    [DataContract]
    public partial class IbmServiceInstanceForUser :  IEquatable<IbmServiceInstanceForUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IbmServiceInstanceForUser" /> class.
        /// </summary>
        /// <param name="clusterId">Cluster id of the cluster which the service instance belongs to.</param>
        /// <param name="clusterIncarnationId">Cluster incarnation id of the cluster which the service instance belongs to.</param>
        /// <param name="regionId">Specifies the IBM Region of the instance.</param>
        /// <param name="serviceInstanceId">Unique instance id of the service instance.</param>
        /// <param name="serviceInstanceName">Service instance name.</param>
        /// <param name="status">Status of the service instance.</param>
        /// <param name="tenantId">Tenant id of the tenant which the service instance belongs to.</param>
        public IbmServiceInstanceForUser(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), string regionId = default(string), string serviceInstanceId = default(string), string serviceInstanceName = default(string), string status = default(string), string tenantId = default(string))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.RegionId = regionId;
            this.ServiceInstanceId = serviceInstanceId;
            this.ServiceInstanceName = serviceInstanceName;
            this.Status = status;
            this.TenantId = tenantId;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.RegionId = regionId;
            this.ServiceInstanceId = serviceInstanceId;
            this.ServiceInstanceName = serviceInstanceName;
            this.Status = status;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Cluster id of the cluster which the service instance belongs to
        /// </summary>
        /// <value>Cluster id of the cluster which the service instance belongs to</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Cluster incarnation id of the cluster which the service instance belongs to
        /// </summary>
        /// <value>Cluster incarnation id of the cluster which the service instance belongs to</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies the IBM Region of the instance
        /// </summary>
        /// <value>Specifies the IBM Region of the instance</value>
        [DataMember(Name="regionId", EmitDefaultValue=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// Unique instance id of the service instance
        /// </summary>
        /// <value>Unique instance id of the service instance</value>
        [DataMember(Name="serviceInstanceId", EmitDefaultValue=true)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// Service instance name
        /// </summary>
        /// <value>Service instance name</value>
        [DataMember(Name="serviceInstanceName", EmitDefaultValue=true)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Status of the service instance
        /// </summary>
        /// <value>Status of the service instance</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// Tenant id of the tenant which the service instance belongs to
        /// </summary>
        /// <value>Tenant id of the tenant which the service instance belongs to</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as IbmServiceInstanceForUser);
        }

        /// <summary>
        /// Returns true if IbmServiceInstanceForUser instances are equal
        /// </summary>
        /// <param name="input">Instance of IbmServiceInstanceForUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IbmServiceInstanceForUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.ServiceInstanceId == input.ServiceInstanceId ||
                    (this.ServiceInstanceId != null &&
                    this.ServiceInstanceId.Equals(input.ServiceInstanceId))
                ) && 
                (
                    this.ServiceInstanceName == input.ServiceInstanceName ||
                    (this.ServiceInstanceName != null &&
                    this.ServiceInstanceName.Equals(input.ServiceInstanceName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ServiceInstanceId != null)
                    hashCode = hashCode * 59 + this.ServiceInstanceId.GetHashCode();
                if (this.ServiceInstanceName != null)
                    hashCode = hashCode * 59 + this.ServiceInstanceName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

