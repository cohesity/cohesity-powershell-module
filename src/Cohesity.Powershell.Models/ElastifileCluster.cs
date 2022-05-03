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
    /// Specifies information about a Elastifile Cluster.
    /// </summary>
    [DataContract]
    public partial class ElastifileCluster :  IEquatable<ElastifileCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElastifileCluster" /> class.
        /// </summary>
        /// <param name="enodeIpAddressVec">IP addresses of Elastifile nodes..</param>
        /// <param name="loadBalancerVip">Specifies the load balancer VIP if present..</param>
        /// <param name="name">Specifies name of a Elastifile Cluster.</param>
        /// <param name="uuid">Specifies the UUID of a Elastifile Cluster..</param>
        /// <param name="version">Specifies the version of a Elastifile Cluster..</param>
        public ElastifileCluster(List<string> enodeIpAddressVec = default(List<string>), string loadBalancerVip = default(string), string name = default(string), string uuid = default(string), string version = default(string))
        {
            this.EnodeIpAddressVec = enodeIpAddressVec;
            this.LoadBalancerVip = loadBalancerVip;
            this.Name = name;
            this.Uuid = uuid;
            this.Version = version;
        }
        
        /// <summary>
        /// IP addresses of Elastifile nodes.
        /// </summary>
        /// <value>IP addresses of Elastifile nodes.</value>
        [DataMember(Name="enodeIpAddressVec", EmitDefaultValue=false)]
        public List<string> EnodeIpAddressVec { get; set; }

        /// <summary>
        /// Specifies the load balancer VIP if present.
        /// </summary>
        /// <value>Specifies the load balancer VIP if present.</value>
        [DataMember(Name="loadBalancerVip", EmitDefaultValue=false)]
        public string LoadBalancerVip { get; set; }

        /// <summary>
        /// Specifies name of a Elastifile Cluster
        /// </summary>
        /// <value>Specifies name of a Elastifile Cluster</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID of a Elastifile Cluster.
        /// </summary>
        /// <value>Specifies the UUID of a Elastifile Cluster.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the version of a Elastifile Cluster.
        /// </summary>
        /// <value>Specifies the version of a Elastifile Cluster.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

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
            return this.Equals(input as ElastifileCluster);
        }

        /// <summary>
        /// Returns true if ElastifileCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of ElastifileCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElastifileCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnodeIpAddressVec == input.EnodeIpAddressVec ||
                    this.EnodeIpAddressVec != null &&
                    this.EnodeIpAddressVec.Equals(input.EnodeIpAddressVec)
                ) && 
                (
                    this.LoadBalancerVip == input.LoadBalancerVip ||
                    (this.LoadBalancerVip != null &&
                    this.LoadBalancerVip.Equals(input.LoadBalancerVip))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.EnodeIpAddressVec != null)
                    hashCode = hashCode * 59 + this.EnodeIpAddressVec.GetHashCode();
                if (this.LoadBalancerVip != null)
                    hashCode = hashCode * 59 + this.LoadBalancerVip.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

