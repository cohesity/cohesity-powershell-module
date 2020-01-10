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
    /// Specifies the parameters needed for a Node upgrade request.
    /// </summary>
    [DataContract]
    public partial class UpgradeNodeParameters :  IEquatable<UpgradeNodeParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeNodeParameters" /> class.
        /// </summary>
        /// <param name="nodeIds">Specifies a list of IDs of additional nodes to be upgraded. These must be free Nodes present on the same local network as the Node that the request was sent to. The ID of the Node the request was sent to should not be included in this list. This parameter can only be specified if upgradeAllFreeNodes is not..</param>
        /// <param name="targetSwVersion">Specifies the target software version. The node that the request is sent to will search itself for the specified software package and if that package is found, it will be used for the upgrade..</param>
        /// <param name="upgradeAllFreeNodes">Specifies whether or not to attempt to upgrade all free nodes which are currently connected to the same local network as the node that the request was sent to. This parameter can only be specified if nodeIds is not..</param>
        /// <param name="upgradeSelf">Specifies that the node that the request is being sent to should be upgraded. By default this is set to true..</param>
        public UpgradeNodeParameters(List<long> nodeIds = default(List<long>), string targetSwVersion = default(string), bool? upgradeAllFreeNodes = default(bool?), bool? upgradeSelf = default(bool?))
        {
            this.NodeIds = nodeIds;
            this.TargetSwVersion = targetSwVersion;
            this.UpgradeAllFreeNodes = upgradeAllFreeNodes;
            this.UpgradeSelf = upgradeSelf;
            this.NodeIds = nodeIds;
            this.TargetSwVersion = targetSwVersion;
            this.UpgradeAllFreeNodes = upgradeAllFreeNodes;
            this.UpgradeSelf = upgradeSelf;
        }
        
        /// <summary>
        /// Specifies a list of IDs of additional nodes to be upgraded. These must be free Nodes present on the same local network as the Node that the request was sent to. The ID of the Node the request was sent to should not be included in this list. This parameter can only be specified if upgradeAllFreeNodes is not.
        /// </summary>
        /// <value>Specifies a list of IDs of additional nodes to be upgraded. These must be free Nodes present on the same local network as the Node that the request was sent to. The ID of the Node the request was sent to should not be included in this list. This parameter can only be specified if upgradeAllFreeNodes is not.</value>
        [DataMember(Name="nodeIds", EmitDefaultValue=true)]
        public List<long> NodeIds { get; set; }

        /// <summary>
        /// Specifies the target software version. The node that the request is sent to will search itself for the specified software package and if that package is found, it will be used for the upgrade.
        /// </summary>
        /// <value>Specifies the target software version. The node that the request is sent to will search itself for the specified software package and if that package is found, it will be used for the upgrade.</value>
        [DataMember(Name="targetSwVersion", EmitDefaultValue=true)]
        public string TargetSwVersion { get; set; }

        /// <summary>
        /// Specifies whether or not to attempt to upgrade all free nodes which are currently connected to the same local network as the node that the request was sent to. This parameter can only be specified if nodeIds is not.
        /// </summary>
        /// <value>Specifies whether or not to attempt to upgrade all free nodes which are currently connected to the same local network as the node that the request was sent to. This parameter can only be specified if nodeIds is not.</value>
        [DataMember(Name="upgradeAllFreeNodes", EmitDefaultValue=true)]
        public bool? UpgradeAllFreeNodes { get; set; }

        /// <summary>
        /// Specifies that the node that the request is being sent to should be upgraded. By default this is set to true.
        /// </summary>
        /// <value>Specifies that the node that the request is being sent to should be upgraded. By default this is set to true.</value>
        [DataMember(Name="upgradeSelf", EmitDefaultValue=true)]
        public bool? UpgradeSelf { get; set; }

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
            return this.Equals(input as UpgradeNodeParameters);
        }

        /// <summary>
        /// Returns true if UpgradeNodeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeNodeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeNodeParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeIds == input.NodeIds ||
                    this.NodeIds != null &&
                    input.NodeIds != null &&
                    this.NodeIds.SequenceEqual(input.NodeIds)
                ) && 
                (
                    this.TargetSwVersion == input.TargetSwVersion ||
                    (this.TargetSwVersion != null &&
                    this.TargetSwVersion.Equals(input.TargetSwVersion))
                ) && 
                (
                    this.UpgradeAllFreeNodes == input.UpgradeAllFreeNodes ||
                    (this.UpgradeAllFreeNodes != null &&
                    this.UpgradeAllFreeNodes.Equals(input.UpgradeAllFreeNodes))
                ) && 
                (
                    this.UpgradeSelf == input.UpgradeSelf ||
                    (this.UpgradeSelf != null &&
                    this.UpgradeSelf.Equals(input.UpgradeSelf))
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
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.TargetSwVersion != null)
                    hashCode = hashCode * 59 + this.TargetSwVersion.GetHashCode();
                if (this.UpgradeAllFreeNodes != null)
                    hashCode = hashCode * 59 + this.UpgradeAllFreeNodes.GetHashCode();
                if (this.UpgradeSelf != null)
                    hashCode = hashCode * 59 + this.UpgradeSelf.GetHashCode();
                return hashCode;
            }
        }

    }

}

