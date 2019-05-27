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
    /// A Proto needed in case objects backed up by this job need to DR to cloud. \&quot;Fail over\&quot; signifies the mechanism to move the workload to cloud.
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoDRToCloudParams :  IEquatable<BackupJobProtoDRToCloudParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoDRToCloudParams" /> class.
        /// </summary>
        /// <param name="needToFailOver">Whether the objects in this job will be failed over to cloud. In case of VMs, we need to fetch information about the logical volumes present on the VM. Magneto might fail backup of a VM in case volume information can not be fetched (maybe because the agent is not installed or if the VM is turned off etc.).  The VM will be backed up using the physical agent when it is running in the cloud. We might choose to backup the VM in the cloud using native API at a later point.  This flag makes sense when configuring a job to backup on-prem VMs..</param>
        public BackupJobProtoDRToCloudParams(bool? needToFailOver = default(bool?))
        {
            this.NeedToFailOver = needToFailOver;
            this.NeedToFailOver = needToFailOver;
        }
        
        /// <summary>
        /// Whether the objects in this job will be failed over to cloud. In case of VMs, we need to fetch information about the logical volumes present on the VM. Magneto might fail backup of a VM in case volume information can not be fetched (maybe because the agent is not installed or if the VM is turned off etc.).  The VM will be backed up using the physical agent when it is running in the cloud. We might choose to backup the VM in the cloud using native API at a later point.  This flag makes sense when configuring a job to backup on-prem VMs.
        /// </summary>
        /// <value>Whether the objects in this job will be failed over to cloud. In case of VMs, we need to fetch information about the logical volumes present on the VM. Magneto might fail backup of a VM in case volume information can not be fetched (maybe because the agent is not installed or if the VM is turned off etc.).  The VM will be backed up using the physical agent when it is running in the cloud. We might choose to backup the VM in the cloud using native API at a later point.  This flag makes sense when configuring a job to backup on-prem VMs.</value>
        [DataMember(Name="needToFailOver", EmitDefaultValue=true)]
        public bool? NeedToFailOver { get; set; }

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
            return this.Equals(input as BackupJobProtoDRToCloudParams);
        }

        /// <summary>
        /// Returns true if BackupJobProtoDRToCloudParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoDRToCloudParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoDRToCloudParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NeedToFailOver == input.NeedToFailOver ||
                    (this.NeedToFailOver != null &&
                    this.NeedToFailOver.Equals(input.NeedToFailOver))
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
                if (this.NeedToFailOver != null)
                    hashCode = hashCode * 59 + this.NeedToFailOver.GetHashCode();
                return hashCode;
            }
        }

    }

}

