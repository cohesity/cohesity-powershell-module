// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a pairing between a Storage Domain (View Box) on local Cluster with a Storage Domain (View Box) on a remote Cluster. When replication is configured between a local Cluster and a remote Cluster, the Snapshots are replicated from the specified Storage Domain (View Box) on the local Cluster to the Storage Domain (View Box) on the remote Cluster. See the online help for details about the supported Storage Domains (View Box) pairings between Clusters.
    /// </summary>
    [DataContract]
    public partial class ViewBoxPairInfo :  IEquatable<ViewBoxPairInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBoxPairInfo" /> class.
        /// </summary>
        /// <param name="localViewBoxId">Specifies the id of the Storage Domain (View Box) on the local Cluster..</param>
        /// <param name="localViewBoxName">Specifies the name of the Storage Domain (View Box) on the local Cluster..</param>
        /// <param name="remoteViewBoxId">Specifies the id of the Storage Domain (View Box) on the remote Cluster..</param>
        /// <param name="remoteViewBoxName">Specifies the name of the Storage Domain (View Box) on the remote Cluster..</param>
        public ViewBoxPairInfo(long? localViewBoxId = default(long?), string localViewBoxName = default(string), long? remoteViewBoxId = default(long?), string remoteViewBoxName = default(string))
        {
            this.LocalViewBoxId = localViewBoxId;
            this.LocalViewBoxName = localViewBoxName;
            this.RemoteViewBoxId = remoteViewBoxId;
            this.RemoteViewBoxName = remoteViewBoxName;
        }
        
        /// <summary>
        /// Specifies the id of the Storage Domain (View Box) on the local Cluster.
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box) on the local Cluster.</value>
        [DataMember(Name="localViewBoxId", EmitDefaultValue=false)]
        public long? LocalViewBoxId { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box) on the local Cluster.
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box) on the local Cluster.</value>
        [DataMember(Name="localViewBoxName", EmitDefaultValue=false)]
        public string LocalViewBoxName { get; set; }

        /// <summary>
        /// Specifies the id of the Storage Domain (View Box) on the remote Cluster.
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box) on the remote Cluster.</value>
        [DataMember(Name="remoteViewBoxId", EmitDefaultValue=false)]
        public long? RemoteViewBoxId { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box) on the remote Cluster.
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box) on the remote Cluster.</value>
        [DataMember(Name="remoteViewBoxName", EmitDefaultValue=false)]
        public string RemoteViewBoxName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ViewBoxPairInfo);
        }

        /// <summary>
        /// Returns true if ViewBoxPairInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewBoxPairInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewBoxPairInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalViewBoxId == input.LocalViewBoxId ||
                    (this.LocalViewBoxId != null &&
                    this.LocalViewBoxId.Equals(input.LocalViewBoxId))
                ) && 
                (
                    this.LocalViewBoxName == input.LocalViewBoxName ||
                    (this.LocalViewBoxName != null &&
                    this.LocalViewBoxName.Equals(input.LocalViewBoxName))
                ) && 
                (
                    this.RemoteViewBoxId == input.RemoteViewBoxId ||
                    (this.RemoteViewBoxId != null &&
                    this.RemoteViewBoxId.Equals(input.RemoteViewBoxId))
                ) && 
                (
                    this.RemoteViewBoxName == input.RemoteViewBoxName ||
                    (this.RemoteViewBoxName != null &&
                    this.RemoteViewBoxName.Equals(input.RemoteViewBoxName))
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
                if (this.LocalViewBoxId != null)
                    hashCode = hashCode * 59 + this.LocalViewBoxId.GetHashCode();
                if (this.LocalViewBoxName != null)
                    hashCode = hashCode * 59 + this.LocalViewBoxName.GetHashCode();
                if (this.RemoteViewBoxId != null)
                    hashCode = hashCode * 59 + this.RemoteViewBoxId.GetHashCode();
                if (this.RemoteViewBoxName != null)
                    hashCode = hashCode * 59 + this.RemoteViewBoxName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

