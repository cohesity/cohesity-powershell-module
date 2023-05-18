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
    /// OracleSbtHostParams
    /// </summary>
    [DataContract]
    public partial class OracleSbtHostParams :  IEquatable<OracleSbtHostParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleSbtHostParams" /> class.
        /// </summary>
        /// <param name="sbtLibraryPath">The path of sbt library, This is set only when backup type is kSbt..</param>
        /// <param name="viewFsPath">Cohesity view path..</param>
        /// <param name="vipVec">Vector of Cohesity primary VIPs..</param>
        /// <param name="vlanInfoVec">Vlan information for Cohesity cluster..</param>
        public OracleSbtHostParams(string sbtLibraryPath = default(string), string viewFsPath = default(string), List<string> vipVec = default(List<string>), List<OracleVlanInfo> vlanInfoVec = default(List<OracleVlanInfo>))
        {
            this.SbtLibraryPath = sbtLibraryPath;
            this.ViewFsPath = viewFsPath;
            this.VipVec = vipVec;
            this.VlanInfoVec = vlanInfoVec;
            this.SbtLibraryPath = sbtLibraryPath;
            this.ViewFsPath = viewFsPath;
            this.VipVec = vipVec;
            this.VlanInfoVec = vlanInfoVec;
        }
        
        /// <summary>
        /// The path of sbt library, This is set only when backup type is kSbt.
        /// </summary>
        /// <value>The path of sbt library, This is set only when backup type is kSbt.</value>
        [DataMember(Name="sbtLibraryPath", EmitDefaultValue=true)]
        public string SbtLibraryPath { get; set; }

        /// <summary>
        /// Cohesity view path.
        /// </summary>
        /// <value>Cohesity view path.</value>
        [DataMember(Name="viewFsPath", EmitDefaultValue=true)]
        public string ViewFsPath { get; set; }

        /// <summary>
        /// Vector of Cohesity primary VIPs.
        /// </summary>
        /// <value>Vector of Cohesity primary VIPs.</value>
        [DataMember(Name="vipVec", EmitDefaultValue=true)]
        public List<string> VipVec { get; set; }

        /// <summary>
        /// Vlan information for Cohesity cluster.
        /// </summary>
        /// <value>Vlan information for Cohesity cluster.</value>
        [DataMember(Name="vlanInfoVec", EmitDefaultValue=true)]
        public List<OracleVlanInfo> VlanInfoVec { get; set; }

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
            return this.Equals(input as OracleSbtHostParams);
        }

        /// <summary>
        /// Returns true if OracleSbtHostParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleSbtHostParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleSbtHostParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SbtLibraryPath == input.SbtLibraryPath ||
                    (this.SbtLibraryPath != null &&
                    this.SbtLibraryPath.Equals(input.SbtLibraryPath))
                ) && 
                (
                    this.ViewFsPath == input.ViewFsPath ||
                    (this.ViewFsPath != null &&
                    this.ViewFsPath.Equals(input.ViewFsPath))
                ) && 
                (
                    this.VipVec == input.VipVec ||
                    this.VipVec != null &&
                    input.VipVec != null &&
                    this.VipVec.SequenceEqual(input.VipVec)
                ) && 
                (
                    this.VlanInfoVec == input.VlanInfoVec ||
                    this.VlanInfoVec != null &&
                    input.VlanInfoVec != null &&
                    this.VlanInfoVec.SequenceEqual(input.VlanInfoVec)
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
                if (this.SbtLibraryPath != null)
                    hashCode = hashCode * 59 + this.SbtLibraryPath.GetHashCode();
                if (this.ViewFsPath != null)
                    hashCode = hashCode * 59 + this.ViewFsPath.GetHashCode();
                if (this.VipVec != null)
                    hashCode = hashCode * 59 + this.VipVec.GetHashCode();
                if (this.VlanInfoVec != null)
                    hashCode = hashCode * 59 + this.VlanInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

