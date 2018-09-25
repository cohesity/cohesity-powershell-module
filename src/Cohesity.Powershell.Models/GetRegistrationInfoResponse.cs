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
    /// Specifies the registration and protection information of all or a subset of the registered Protection Source Trees or Views on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class GetRegistrationInfoResponse :  IEquatable<GetRegistrationInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegistrationInfoResponse" /> class.
        /// </summary>
        /// <param name="rootNodes">Specifies the registration and protection information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true.</param>
        /// <param name="stats">stats.</param>
        /// <param name="views">Specifies the protection information of either all or a subset of Views created on the Cohesity Cluster. overrideDescription: true.</param>
        public GetRegistrationInfoResponse(List<ProtectionSourceTreeInfo> rootNodes = default(List<ProtectionSourceTreeInfo>), ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster_ stats = default(ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster_), List<ViewProtectionInfo> views = default(List<ViewProtectionInfo>))
        {
            this.RootNodes = rootNodes;
            this.Stats = stats;
            this.Views = views;
        }
        
        /// <summary>
        /// Specifies the registration and protection information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true
        /// </summary>
        /// <value>Specifies the registration and protection information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true</value>
        [DataMember(Name="rootNodes", EmitDefaultValue=false)]
        public List<ProtectionSourceTreeInfo> RootNodes { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster_ Stats { get; set; }

        /// <summary>
        /// Specifies the protection information of either all or a subset of Views created on the Cohesity Cluster. overrideDescription: true
        /// </summary>
        /// <value>Specifies the protection information of either all or a subset of Views created on the Cohesity Cluster. overrideDescription: true</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<ViewProtectionInfo> Views { get; set; }

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
            return this.Equals(input as GetRegistrationInfoResponse);
        }

        /// <summary>
        /// Returns true if GetRegistrationInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRegistrationInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRegistrationInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootNodes == input.RootNodes ||
                    this.RootNodes != null &&
                    this.RootNodes.SequenceEqual(input.RootNodes)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.RootNodes != null)
                    hashCode = hashCode * 59 + this.RootNodes.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

