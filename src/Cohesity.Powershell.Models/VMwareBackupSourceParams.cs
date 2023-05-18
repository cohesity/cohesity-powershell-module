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
    /// Message to capture additional backup params for a VMware type source.
    /// </summary>
    [DataContract]
    public partial class VMwareBackupSourceParams :  IEquatable<VMwareBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareBackupSourceParams" /> class.
        /// </summary>
        /// <param name="sourceAppParams">sourceAppParams.</param>
        /// <param name="vmCredentials">vmCredentials.</param>
        /// <param name="vmwareDiskExclusionInfo">List of Virtual Disk(s) to be excluded from the backup job for the source. Overrides the exclusion list requested (if any) through EnvBackupParams.VMwareBackupEnvParams..</param>
        public VMwareBackupSourceParams(SourceAppParams sourceAppParams = default(SourceAppParams), Credentials vmCredentials = default(Credentials), List<VMwareDiskExclusionProto> vmwareDiskExclusionInfo = default(List<VMwareDiskExclusionProto>))
        {
            this.VmwareDiskExclusionInfo = vmwareDiskExclusionInfo;
            this.SourceAppParams = sourceAppParams;
            this.VmCredentials = vmCredentials;
            this.VmwareDiskExclusionInfo = vmwareDiskExclusionInfo;
        }
        
        /// <summary>
        /// Gets or Sets SourceAppParams
        /// </summary>
        [DataMember(Name="sourceAppParams", EmitDefaultValue=false)]
        public SourceAppParams SourceAppParams { get; set; }

        /// <summary>
        /// Gets or Sets VmCredentials
        /// </summary>
        [DataMember(Name="vmCredentials", EmitDefaultValue=false)]
        public Credentials VmCredentials { get; set; }

        /// <summary>
        /// List of Virtual Disk(s) to be excluded from the backup job for the source. Overrides the exclusion list requested (if any) through EnvBackupParams.VMwareBackupEnvParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be excluded from the backup job for the source. Overrides the exclusion list requested (if any) through EnvBackupParams.VMwareBackupEnvParams.</value>
        [DataMember(Name="vmwareDiskExclusionInfo", EmitDefaultValue=true)]
        public List<VMwareDiskExclusionProto> VmwareDiskExclusionInfo { get; set; }

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
            return this.Equals(input as VMwareBackupSourceParams);
        }

        /// <summary>
        /// Returns true if VMwareBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAppParams == input.SourceAppParams ||
                    (this.SourceAppParams != null &&
                    this.SourceAppParams.Equals(input.SourceAppParams))
                ) && 
                (
                    this.VmCredentials == input.VmCredentials ||
                    (this.VmCredentials != null &&
                    this.VmCredentials.Equals(input.VmCredentials))
                ) && 
                (
                    this.VmwareDiskExclusionInfo == input.VmwareDiskExclusionInfo ||
                    this.VmwareDiskExclusionInfo != null &&
                    input.VmwareDiskExclusionInfo != null &&
                    this.VmwareDiskExclusionInfo.SequenceEqual(input.VmwareDiskExclusionInfo)
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
                if (this.SourceAppParams != null)
                    hashCode = hashCode * 59 + this.SourceAppParams.GetHashCode();
                if (this.VmCredentials != null)
                    hashCode = hashCode * 59 + this.VmCredentials.GetHashCode();
                if (this.VmwareDiskExclusionInfo != null)
                    hashCode = hashCode * 59 + this.VmwareDiskExclusionInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

