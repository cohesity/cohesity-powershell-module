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
    /// MountVolumesTaskStateProto
    /// </summary>
    [DataContract]
    public partial class MountVolumesTaskStateProto :  IEquatable<MountVolumesTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesTaskStateProto" /> class.
        /// </summary>
        /// <param name="fullNasPath">Contains the SMB/NFS path of the share we expose to clients. The share contains the files pertinent to the original backup run type..</param>
        /// <param name="hostEntity">hostEntity.</param>
        /// <param name="mountInfo">mountInfo.</param>
        /// <param name="mountParams">mountParams.</param>
        public MountVolumesTaskStateProto(string fullNasPath = default(string), EntityProto hostEntity = default(EntityProto), MountVolumesInfoProto mountInfo = default(MountVolumesInfoProto), MountVolumesParams mountParams = default(MountVolumesParams))
        {
            this.FullNasPath = fullNasPath;
            this.HostEntity = hostEntity;
            this.MountInfo = mountInfo;
            this.MountParams = mountParams;
        }
        
        /// <summary>
        /// Contains the SMB/NFS path of the share we expose to clients. The share contains the files pertinent to the original backup run type.
        /// </summary>
        /// <value>Contains the SMB/NFS path of the share we expose to clients. The share contains the files pertinent to the original backup run type.</value>
        [DataMember(Name="fullNasPath", EmitDefaultValue=false)]
        public string FullNasPath { get; set; }

        /// <summary>
        /// Gets or Sets HostEntity
        /// </summary>
        [DataMember(Name="hostEntity", EmitDefaultValue=false)]
        public EntityProto HostEntity { get; set; }

        /// <summary>
        /// Gets or Sets MountInfo
        /// </summary>
        [DataMember(Name="mountInfo", EmitDefaultValue=false)]
        public MountVolumesInfoProto MountInfo { get; set; }

        /// <summary>
        /// Gets or Sets MountParams
        /// </summary>
        [DataMember(Name="mountParams", EmitDefaultValue=false)]
        public MountVolumesParams MountParams { get; set; }

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
            return this.Equals(input as MountVolumesTaskStateProto);
        }

        /// <summary>
        /// Returns true if MountVolumesTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullNasPath == input.FullNasPath ||
                    (this.FullNasPath != null &&
                    this.FullNasPath.Equals(input.FullNasPath))
                ) && 
                (
                    this.HostEntity == input.HostEntity ||
                    (this.HostEntity != null &&
                    this.HostEntity.Equals(input.HostEntity))
                ) && 
                (
                    this.MountInfo == input.MountInfo ||
                    (this.MountInfo != null &&
                    this.MountInfo.Equals(input.MountInfo))
                ) && 
                (
                    this.MountParams == input.MountParams ||
                    (this.MountParams != null &&
                    this.MountParams.Equals(input.MountParams))
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
                if (this.FullNasPath != null)
                    hashCode = hashCode * 59 + this.FullNasPath.GetHashCode();
                if (this.HostEntity != null)
                    hashCode = hashCode * 59 + this.HostEntity.GetHashCode();
                if (this.MountInfo != null)
                    hashCode = hashCode * 59 + this.MountInfo.GetHashCode();
                if (this.MountParams != null)
                    hashCode = hashCode * 59 + this.MountParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

