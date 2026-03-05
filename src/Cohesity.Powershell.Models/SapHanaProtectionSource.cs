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
    /// SapHanaProtectionSource
    /// </summary>
    [DataContract]
    public partial class SapHanaProtectionSource :  IEquatable<SapHanaProtectionSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SapHanaProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="name">Specifies the instance name of the SAP Hana entity..</param>
        /// <param name="objectInfo">objectInfo.</param>
        /// <param name="type">Specifies the type of the managed Object in SAP HANA Protection Source..</param>
        /// <param name="uuid">Specifies the UUID for the SAP Hana entity..</param>
        public SapHanaProtectionSource(SapHanaCluster clusterInfo = default(SapHanaCluster), string name = default(string), SapHanaObject objectInfo = default(SapHanaObject), int? type = default(int?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.ClusterInfo = clusterInfo;
            this.Name = name;
            this.ObjectInfo = objectInfo;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public SapHanaCluster ClusterInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the SAP Hana entity.
        /// </summary>
        /// <value>Specifies the instance name of the SAP Hana entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ObjectInfo
        /// </summary>
        [DataMember(Name="objectInfo", EmitDefaultValue=false)]
        public SapHanaObject ObjectInfo { get; set; }

        /// <summary>
        /// Specifies the type of the managed Object in SAP HANA Protection Source.
        /// </summary>
        /// <value>Specifies the type of the managed Object in SAP HANA Protection Source.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Specifies the UUID for the SAP Hana entity.
        /// </summary>
        /// <value>Specifies the UUID for the SAP Hana entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as SapHanaProtectionSource);
        }

        /// <summary>
        /// Returns true if SapHanaProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of SapHanaProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SapHanaProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterInfo == input.ClusterInfo ||
                    (this.ClusterInfo != null &&
                    this.ClusterInfo.Equals(input.ClusterInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    (this.ObjectInfo != null &&
                    this.ObjectInfo.Equals(input.ObjectInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

