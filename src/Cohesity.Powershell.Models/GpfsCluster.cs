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
    /// Specifies information about a GPFS Cluster.
    /// </summary>
    [DataContract]
    public partial class GpfsCluster :  IEquatable<GpfsCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GpfsCluster" /> class.
        /// </summary>
        /// <param name="cesAddresses">Specifies a list of CES(Cluster Export Services) IP addresses of a GPFS Cluster..</param>
        /// <param name="id">Specifies a globally unique id of a GPFS Cluster..</param>
        /// <param name="primaryServer">Specifies a primary server of a GPFS Cluster..</param>
        public GpfsCluster(List<string> cesAddresses = default(List<string>), int? id = default(int?), string primaryServer = default(string))
        {
            this.CesAddresses = cesAddresses;
            this.Id = id;
            this.PrimaryServer = primaryServer;
            this.CesAddresses = cesAddresses;
            this.Id = id;
            this.PrimaryServer = primaryServer;
        }
        
        /// <summary>
        /// Specifies a list of CES(Cluster Export Services) IP addresses of a GPFS Cluster.
        /// </summary>
        /// <value>Specifies a list of CES(Cluster Export Services) IP addresses of a GPFS Cluster.</value>
        [DataMember(Name="cesAddresses", EmitDefaultValue=true)]
        public List<string> CesAddresses { get; set; }

        /// <summary>
        /// Specifies a globally unique id of a GPFS Cluster.
        /// </summary>
        /// <value>Specifies a globally unique id of a GPFS Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies a primary server of a GPFS Cluster.
        /// </summary>
        /// <value>Specifies a primary server of a GPFS Cluster.</value>
        [DataMember(Name="primaryServer", EmitDefaultValue=true)]
        public string PrimaryServer { get; set; }

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
            return this.Equals(input as GpfsCluster);
        }

        /// <summary>
        /// Returns true if GpfsCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of GpfsCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GpfsCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CesAddresses == input.CesAddresses ||
                    this.CesAddresses != null &&
                    input.CesAddresses != null &&
                    this.CesAddresses.Equals(input.CesAddresses)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PrimaryServer == input.PrimaryServer ||
                    (this.PrimaryServer != null &&
                    this.PrimaryServer.Equals(input.PrimaryServer))
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
                if (this.CesAddresses != null)
                    hashCode = hashCode * 59 + this.CesAddresses.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PrimaryServer != null)
                    hashCode = hashCode * 59 + this.PrimaryServer.GetHashCode();
                return hashCode;
            }
        }

    }

}

