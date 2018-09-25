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
    /// Specifies information about the Protection Jobs that are protecting the View.
    /// </summary>
    [DataContract]
    public partial class ViewProtection :  IEquatable<ViewProtection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProtection" /> class.
        /// </summary>
        /// <param name="inactive">Specifies if this View is an inactive View that was created on this Remote Cluster to store the Snapshots created by replication. This inactive View cannot be NFS or SMB mounted..</param>
        /// <param name="magnetoEntityId">Specifies the id of the Protection Source that is using this View..</param>
        /// <param name="protectionJobs">Specifies the Protection Jobs that are protecting the View..</param>
        public ViewProtection(bool? inactive = default(bool?), long? magnetoEntityId = default(long?), List<ProtectionJobInfo> protectionJobs = default(List<ProtectionJobInfo>))
        {
            this.Inactive = inactive;
            this.MagnetoEntityId = magnetoEntityId;
            this.ProtectionJobs = protectionJobs;
        }
        
        /// <summary>
        /// Specifies if this View is an inactive View that was created on this Remote Cluster to store the Snapshots created by replication. This inactive View cannot be NFS or SMB mounted.
        /// </summary>
        /// <value>Specifies if this View is an inactive View that was created on this Remote Cluster to store the Snapshots created by replication. This inactive View cannot be NFS or SMB mounted.</value>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public bool? Inactive { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Source that is using this View.
        /// </summary>
        /// <value>Specifies the id of the Protection Source that is using this View.</value>
        [DataMember(Name="magnetoEntityId", EmitDefaultValue=false)]
        public long? MagnetoEntityId { get; set; }

        /// <summary>
        /// Specifies the Protection Jobs that are protecting the View.
        /// </summary>
        /// <value>Specifies the Protection Jobs that are protecting the View.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=false)]
        public List<ProtectionJobInfo> ProtectionJobs { get; set; }

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
            return this.Equals(input as ViewProtection);
        }

        /// <summary>
        /// Returns true if ViewProtection instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProtection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProtection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inactive == input.Inactive ||
                    (this.Inactive != null &&
                    this.Inactive.Equals(input.Inactive))
                ) && 
                (
                    this.MagnetoEntityId == input.MagnetoEntityId ||
                    (this.MagnetoEntityId != null &&
                    this.MagnetoEntityId.Equals(input.MagnetoEntityId))
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
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
                if (this.Inactive != null)
                    hashCode = hashCode * 59 + this.Inactive.GetHashCode();
                if (this.MagnetoEntityId != null)
                    hashCode = hashCode * 59 + this.MagnetoEntityId.GetHashCode();
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

