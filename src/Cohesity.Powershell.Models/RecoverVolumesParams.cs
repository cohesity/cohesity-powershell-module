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
    /// RecoverVolumesParams
    /// </summary>
    [DataContract]
    public partial class RecoverVolumesParams :  IEquatable<RecoverVolumesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVolumesParams" /> class.
        /// </summary>
        /// <param name="forceUnmountVolume">Whether volume would be dismounted first during LockVolume failure.</param>
        /// <param name="mappingVec">Contains the volume mapping data that defines the restore task..</param>
        /// <param name="targetEntity">targetEntity.</param>
        public RecoverVolumesParams(bool? forceUnmountVolume = default(bool?), List<RecoverVolumesParamsMapping> mappingVec = default(List<RecoverVolumesParamsMapping>), EntityProto targetEntity = default(EntityProto))
        {
            this.ForceUnmountVolume = forceUnmountVolume;
            this.MappingVec = mappingVec;
            this.ForceUnmountVolume = forceUnmountVolume;
            this.MappingVec = mappingVec;
            this.TargetEntity = targetEntity;
        }
        
        /// <summary>
        /// Whether volume would be dismounted first during LockVolume failure
        /// </summary>
        /// <value>Whether volume would be dismounted first during LockVolume failure</value>
        [DataMember(Name="forceUnmountVolume", EmitDefaultValue=true)]
        public bool? ForceUnmountVolume { get; set; }

        /// <summary>
        /// Contains the volume mapping data that defines the restore task.
        /// </summary>
        /// <value>Contains the volume mapping data that defines the restore task.</value>
        [DataMember(Name="mappingVec", EmitDefaultValue=true)]
        public List<RecoverVolumesParamsMapping> MappingVec { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

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
            return this.Equals(input as RecoverVolumesParams);
        }

        /// <summary>
        /// Returns true if RecoverVolumesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVolumesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVolumesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForceUnmountVolume == input.ForceUnmountVolume ||
                    (this.ForceUnmountVolume != null &&
                    this.ForceUnmountVolume.Equals(input.ForceUnmountVolume))
                ) && 
                (
                    this.MappingVec == input.MappingVec ||
                    this.MappingVec != null &&
                    input.MappingVec != null &&
                    this.MappingVec.Equals(input.MappingVec)
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
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
                if (this.ForceUnmountVolume != null)
                    hashCode = hashCode * 59 + this.ForceUnmountVolume.GetHashCode();
                if (this.MappingVec != null)
                    hashCode = hashCode * 59 + this.MappingVec.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

