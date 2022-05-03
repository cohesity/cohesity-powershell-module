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
    /// Specifies the registration, protection and permission information of all or a subset of the registered Protection Source Trees or Views on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class GetRegistrationInfoResponse :  IEquatable<GetRegistrationInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegistrationInfoResponse" /> class.
        /// </summary>
        /// <param name="rootNodes">Specifies the registration, protection and permission information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true.</param>
        /// <param name="stats">Specifies the sum of all the stats of protection of Protection Sources and views selected by the query parameters..</param>
        /// <param name="statsByEnv">Specifies the breakdown of the stats by environment overrideDescription: true.</param>
        public GetRegistrationInfoResponse(List<ProtectionSourceTreeInfo> rootNodes = default(List<ProtectionSourceTreeInfo>), ProtectionSummary stats = default(ProtectionSummary), List<ProtectionSummaryByEnv> statsByEnv = default(List<ProtectionSummaryByEnv>))
        {
            this.RootNodes = rootNodes;
            this.Stats = stats;
            this.StatsByEnv = statsByEnv;
        }
        
        /// <summary>
        /// Specifies the registration, protection and permission information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true
        /// </summary>
        /// <value>Specifies the registration, protection and permission information of either all or a subset of registered Protection Sources matching the filter parameters. overrideDescription: true</value>
        [DataMember(Name="rootNodes", EmitDefaultValue=false)]
        public List<ProtectionSourceTreeInfo> RootNodes { get; set; }

        /// <summary>
        /// Specifies the sum of all the stats of protection of Protection Sources and views selected by the query parameters.
        /// </summary>
        /// <value>Specifies the sum of all the stats of protection of Protection Sources and views selected by the query parameters.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummary Stats { get; set; }

        /// <summary>
        /// Specifies the breakdown of the stats by environment overrideDescription: true
        /// </summary>
        /// <value>Specifies the breakdown of the stats by environment overrideDescription: true</value>
        [DataMember(Name="statsByEnv", EmitDefaultValue=false)]
        public List<ProtectionSummaryByEnv> StatsByEnv { get; set; }

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
                    this.RootNodes.Equals(input.RootNodes)
                ) && 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(input.Stats)
                ) && 
                (
                    this.StatsByEnv == input.StatsByEnv ||
                    this.StatsByEnv != null &&
                    this.StatsByEnv.Equals(input.StatsByEnv)
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
                if (this.StatsByEnv != null)
                    hashCode = hashCode * 59 + this.StatsByEnv.GetHashCode();
                return hashCode;
            }
        }

    }

}

