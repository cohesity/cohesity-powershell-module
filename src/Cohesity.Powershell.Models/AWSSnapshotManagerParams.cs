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
    /// AWSSnapshotManagerParams
    /// </summary>
    [DataContract]
    public partial class AWSSnapshotManagerParams :  IEquatable<AWSSnapshotManagerParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSSnapshotManagerParams" /> class.
        /// </summary>
        /// <param name="amiCreationFrequency">The frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI..</param>
        /// <param name="createAmiForRun">Whether we need to create an AMI for this run..</param>
        /// <param name="shouldCreateAmi">Whether we need to create an AMI after taking snapshots of the instance..</param>
        /// <param name="volumeExclusionParams">volumeExclusionParams.</param>
        public AWSSnapshotManagerParams(int? amiCreationFrequency = default(int?), bool? createAmiForRun = default(bool?), bool? shouldCreateAmi = default(bool?), EBSVolumeExclusionParams volumeExclusionParams = default(EBSVolumeExclusionParams))
        {
            this.AmiCreationFrequency = amiCreationFrequency;
            this.CreateAmiForRun = createAmiForRun;
            this.ShouldCreateAmi = shouldCreateAmi;
            this.AmiCreationFrequency = amiCreationFrequency;
            this.CreateAmiForRun = createAmiForRun;
            this.ShouldCreateAmi = shouldCreateAmi;
            this.VolumeExclusionParams = volumeExclusionParams;
        }
        
        /// <summary>
        /// The frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI.
        /// </summary>
        /// <value>The frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI.</value>
        [DataMember(Name="amiCreationFrequency", EmitDefaultValue=true)]
        public int? AmiCreationFrequency { get; set; }

        /// <summary>
        /// Whether we need to create an AMI for this run.
        /// </summary>
        /// <value>Whether we need to create an AMI for this run.</value>
        [DataMember(Name="createAmiForRun", EmitDefaultValue=true)]
        public bool? CreateAmiForRun { get; set; }

        /// <summary>
        /// Whether we need to create an AMI after taking snapshots of the instance.
        /// </summary>
        /// <value>Whether we need to create an AMI after taking snapshots of the instance.</value>
        [DataMember(Name="shouldCreateAmi", EmitDefaultValue=true)]
        public bool? ShouldCreateAmi { get; set; }

        /// <summary>
        /// Gets or Sets VolumeExclusionParams
        /// </summary>
        [DataMember(Name="volumeExclusionParams", EmitDefaultValue=false)]
        public EBSVolumeExclusionParams VolumeExclusionParams { get; set; }

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
            return this.Equals(input as AWSSnapshotManagerParams);
        }

        /// <summary>
        /// Returns true if AWSSnapshotManagerParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSSnapshotManagerParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSSnapshotManagerParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmiCreationFrequency == input.AmiCreationFrequency ||
                    (this.AmiCreationFrequency != null &&
                    this.AmiCreationFrequency.Equals(input.AmiCreationFrequency))
                ) && 
                (
                    this.CreateAmiForRun == input.CreateAmiForRun ||
                    (this.CreateAmiForRun != null &&
                    this.CreateAmiForRun.Equals(input.CreateAmiForRun))
                ) && 
                (
                    this.ShouldCreateAmi == input.ShouldCreateAmi ||
                    (this.ShouldCreateAmi != null &&
                    this.ShouldCreateAmi.Equals(input.ShouldCreateAmi))
                ) && 
                (
                    this.VolumeExclusionParams == input.VolumeExclusionParams ||
                    (this.VolumeExclusionParams != null &&
                    this.VolumeExclusionParams.Equals(input.VolumeExclusionParams))
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
                if (this.AmiCreationFrequency != null)
                    hashCode = hashCode * 59 + this.AmiCreationFrequency.GetHashCode();
                if (this.CreateAmiForRun != null)
                    hashCode = hashCode * 59 + this.CreateAmiForRun.GetHashCode();
                if (this.ShouldCreateAmi != null)
                    hashCode = hashCode * 59 + this.ShouldCreateAmi.GetHashCode();
                if (this.VolumeExclusionParams != null)
                    hashCode = hashCode * 59 + this.VolumeExclusionParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

