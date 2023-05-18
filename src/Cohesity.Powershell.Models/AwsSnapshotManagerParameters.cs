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
    /// Protection Job parameters applicable to &#39;kAWSSnapshotManager&#39; Environment type. Specifies additional job parameters applicable for &#39;kAWSSnapshotManager&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class AwsSnapshotManagerParameters :  IEquatable<AwsSnapshotManagerParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsSnapshotManagerParameters" /> class.
        /// </summary>
        /// <param name="amiCreationFrequency">Specifies the frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI..</param>
        /// <param name="createAmi">If true, creates an AMI after taking snapshots of the instance. It should be set only while backing up EC2 instances. CreateAmi creates AMI for the protection job..</param>
        public AwsSnapshotManagerParameters(int? amiCreationFrequency = default(int?), bool? createAmi = default(bool?))
        {
            this.AmiCreationFrequency = amiCreationFrequency;
            this.CreateAmi = createAmi;
            this.AmiCreationFrequency = amiCreationFrequency;
            this.CreateAmi = createAmi;
        }
        
        /// <summary>
        /// Specifies the frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI.
        /// </summary>
        /// <value>Specifies the frequency of AMI creation. This should be set if the option to create AMI is set. A value of n creates an AMI from the snapshots after every n runs. eg. n &#x3D; 2 implies every alternate backup run starting from the first will create an AMI.</value>
        [DataMember(Name="amiCreationFrequency", EmitDefaultValue=true)]
        public int? AmiCreationFrequency { get; set; }

        /// <summary>
        /// If true, creates an AMI after taking snapshots of the instance. It should be set only while backing up EC2 instances. CreateAmi creates AMI for the protection job.
        /// </summary>
        /// <value>If true, creates an AMI after taking snapshots of the instance. It should be set only while backing up EC2 instances. CreateAmi creates AMI for the protection job.</value>
        [DataMember(Name="createAmi", EmitDefaultValue=true)]
        public bool? CreateAmi { get; set; }

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
            return this.Equals(input as AwsSnapshotManagerParameters);
        }

        /// <summary>
        /// Returns true if AwsSnapshotManagerParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsSnapshotManagerParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsSnapshotManagerParameters input)
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
                    this.CreateAmi == input.CreateAmi ||
                    (this.CreateAmi != null &&
                    this.CreateAmi.Equals(input.CreateAmi))
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
                if (this.CreateAmi != null)
                    hashCode = hashCode * 59 + this.CreateAmi.GetHashCode();
                return hashCode;
            }
        }

    }

}

