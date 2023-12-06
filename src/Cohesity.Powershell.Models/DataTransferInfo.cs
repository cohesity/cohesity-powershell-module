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
    /// This proto contains information of the network which will be used at the source side for data transfer from the source to the Cohesity cluster. Currently, this is populated only in case of Native Backup/Restore of Azure Managed VMs.
    /// </summary>
    [DataContract]
    public partial class DataTransferInfo :  IEquatable<DataTransferInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferInfo" /> class.
        /// </summary>
        /// <param name="isPrivateNetwork">Whether to use private network or public network..</param>
        /// <param name="privateNetworkInfoVec">Information required to create endpoints in private networks for all the regions whose VMs are getting protected..</param>
        /// <param name="useProtectionJobInfo">Whether to use private network info which was used in backup of VMs. This should be populated only for restore job. is_private_network should be true if this is set and its corresponding backup job should also have is_private_network to be true..</param>
        public DataTransferInfo(bool? isPrivateNetwork = default(bool?), List<DataTransferInfoPrivateNetworkInfo> privateNetworkInfoVec = default(List<DataTransferInfoPrivateNetworkInfo>), bool? useProtectionJobInfo = default(bool?))
        {
            this.IsPrivateNetwork = isPrivateNetwork;
            this.PrivateNetworkInfoVec = privateNetworkInfoVec;
            this.UseProtectionJobInfo = useProtectionJobInfo;
            this.IsPrivateNetwork = isPrivateNetwork;
            this.PrivateNetworkInfoVec = privateNetworkInfoVec;
            this.UseProtectionJobInfo = useProtectionJobInfo;
        }
        
        /// <summary>
        /// Whether to use private network or public network.
        /// </summary>
        /// <value>Whether to use private network or public network.</value>
        [DataMember(Name="isPrivateNetwork", EmitDefaultValue=true)]
        public bool? IsPrivateNetwork { get; set; }

        /// <summary>
        /// Information required to create endpoints in private networks for all the regions whose VMs are getting protected.
        /// </summary>
        /// <value>Information required to create endpoints in private networks for all the regions whose VMs are getting protected.</value>
        [DataMember(Name="privateNetworkInfoVec", EmitDefaultValue=true)]
        public List<DataTransferInfoPrivateNetworkInfo> PrivateNetworkInfoVec { get; set; }

        /// <summary>
        /// Whether to use private network info which was used in backup of VMs. This should be populated only for restore job. is_private_network should be true if this is set and its corresponding backup job should also have is_private_network to be true.
        /// </summary>
        /// <value>Whether to use private network info which was used in backup of VMs. This should be populated only for restore job. is_private_network should be true if this is set and its corresponding backup job should also have is_private_network to be true.</value>
        [DataMember(Name="useProtectionJobInfo", EmitDefaultValue=true)]
        public bool? UseProtectionJobInfo { get; set; }

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
            return this.Equals(input as DataTransferInfo);
        }

        /// <summary>
        /// Returns true if DataTransferInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPrivateNetwork == input.IsPrivateNetwork ||
                    (this.IsPrivateNetwork != null &&
                    this.IsPrivateNetwork.Equals(input.IsPrivateNetwork))
                ) && 
                (
                    this.PrivateNetworkInfoVec == input.PrivateNetworkInfoVec ||
                    this.PrivateNetworkInfoVec != null &&
                    input.PrivateNetworkInfoVec != null &&
                    this.PrivateNetworkInfoVec.SequenceEqual(input.PrivateNetworkInfoVec)
                ) && 
                (
                    this.UseProtectionJobInfo == input.UseProtectionJobInfo ||
                    (this.UseProtectionJobInfo != null &&
                    this.UseProtectionJobInfo.Equals(input.UseProtectionJobInfo))
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
                if (this.IsPrivateNetwork != null)
                    hashCode = hashCode * 59 + this.IsPrivateNetwork.GetHashCode();
                if (this.PrivateNetworkInfoVec != null)
                    hashCode = hashCode * 59 + this.PrivateNetworkInfoVec.GetHashCode();
                if (this.UseProtectionJobInfo != null)
                    hashCode = hashCode * 59 + this.UseProtectionJobInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

