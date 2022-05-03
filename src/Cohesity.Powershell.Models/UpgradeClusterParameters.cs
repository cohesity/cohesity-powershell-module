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
    /// Specifies the parameters needed for a Cluster Upgrade request.
    /// </summary>
    [DataContract]
    public partial class UpgradeClusterParameters :  IEquatable<UpgradeClusterParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpgradeClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeClusterParameters" /> class.
        /// </summary>
        /// <param name="targetSwVersion">Specifies the target software version. If specified, all Nodes on the Cluster will be searched to see if they have had the specified software package uploaded to them. If the specified package is found, then it will be used for the upgrade. (required).</param>
        public UpgradeClusterParameters(string targetSwVersion = default(string))
        {
            // to ensure "targetSwVersion" is required (not null)
            if (targetSwVersion == null)
            {
                throw new InvalidDataException("targetSwVersion is a required property for UpgradeClusterParameters and cannot be null");
            }
            else
            {
                this.TargetSwVersion = targetSwVersion;
            }
        }
        
        /// <summary>
        /// Specifies the target software version. If specified, all Nodes on the Cluster will be searched to see if they have had the specified software package uploaded to them. If the specified package is found, then it will be used for the upgrade.
        /// </summary>
        /// <value>Specifies the target software version. If specified, all Nodes on the Cluster will be searched to see if they have had the specified software package uploaded to them. If the specified package is found, then it will be used for the upgrade.</value>
        [DataMember(Name="targetSwVersion", EmitDefaultValue=false)]
        public string TargetSwVersion { get; set; }

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
            return this.Equals(input as UpgradeClusterParameters);
        }

        /// <summary>
        /// Returns true if UpgradeClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeClusterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetSwVersion == input.TargetSwVersion ||
                    (this.TargetSwVersion != null &&
                    this.TargetSwVersion.Equals(input.TargetSwVersion))
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
                if (this.TargetSwVersion != null)
                    hashCode = hashCode * 59 + this.TargetSwVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}

