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
    /// Specifies the registration and protection information of a registered Protection Source Tree on the Cohesity Cluster.  Many different Protection Source trees are supported such as &#39;kVMware&#39;, &#39;kAcropolis&#39;, &#39;kPhysical&#39; etc.,
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceTreeInfo :  IEquatable<ProtectionSourceTreeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceTreeInfo" /> class.
        /// </summary>
        /// <param name="registrationInfo">registrationInfo.</param>
        /// <param name="rootNode">rootNode.</param>
        /// <param name="stats">stats.</param>
        public ProtectionSourceTreeInfo(RegisteredSourceInfo_ registrationInfo = default(RegisteredSourceInfo_), ProtectionSource1 rootNode = default(ProtectionSource1), ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster2 stats = default(ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster2))
        {
            this.RegistrationInfo = registrationInfo;
            this.RootNode = rootNode;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Gets or Sets RegistrationInfo
        /// </summary>
        [DataMember(Name="registrationInfo", EmitDefaultValue=false)]
        public RegisteredSourceInfo_ RegistrationInfo { get; set; }

        /// <summary>
        /// Gets or Sets RootNode
        /// </summary>
        [DataMember(Name="rootNode", EmitDefaultValue=false)]
        public ProtectionSource1 RootNode { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster2 Stats { get; set; }

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
            return this.Equals(input as ProtectionSourceTreeInfo);
        }

        /// <summary>
        /// Returns true if ProtectionSourceTreeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceTreeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceTreeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistrationInfo == input.RegistrationInfo ||
                    (this.RegistrationInfo != null &&
                    this.RegistrationInfo.Equals(input.RegistrationInfo))
                ) && 
                (
                    this.RootNode == input.RootNode ||
                    (this.RootNode != null &&
                    this.RootNode.Equals(input.RootNode))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                if (this.RegistrationInfo != null)
                    hashCode = hashCode * 59 + this.RegistrationInfo.GetHashCode();
                if (this.RootNode != null)
                    hashCode = hashCode * 59 + this.RootNode.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

