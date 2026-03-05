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
    /// Specifies an Object representing MongoDB.
    /// </summary>
    [DataContract]
    public partial class MongoDBPhysicalProtectionSource :  IEquatable<MongoDBPhysicalProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB Physical source entity. &#39;kUnknown&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kOpsManager&#39; indicates a Database within the MongoDB environment. &#39;kOrganization&#39; indicates a Collection in the MongoDB enironment. &#39;kProject&#39; indicates a Collection in the MongoDB enironment. &#39;kCluster&#39; indicates a Collection in the MongoDB enironment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB Physical source entity. &#39;kUnknown&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kOpsManager&#39; indicates a Database within the MongoDB environment. &#39;kOrganization&#39; indicates a Collection in the MongoDB enironment. &#39;kProject&#39; indicates a Collection in the MongoDB enironment. &#39;kCluster&#39; indicates a Collection in the MongoDB enironment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KOpsManager for value: kOpsManager
            /// </summary>
            [EnumMember(Value = "kOpsManager")]
            KOpsManager = 2,

            /// <summary>
            /// Enum KOrganization for value: kOrganization
            /// </summary>
            [EnumMember(Value = "kOrganization")]
            KOrganization = 3,

            /// <summary>
            /// Enum KProject for value: kProject
            /// </summary>
            [EnumMember(Value = "kProject")]
            KProject = 4,

            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 5

        }

        /// <summary>
        /// Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB Physical source entity. &#39;kUnknown&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kOpsManager&#39; indicates a Database within the MongoDB environment. &#39;kOrganization&#39; indicates a Collection in the MongoDB enironment. &#39;kProject&#39; indicates a Collection in the MongoDB enironment. &#39;kCluster&#39; indicates a Collection in the MongoDB enironment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB Physical source entity. &#39;kUnknown&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kOpsManager&#39; indicates a Database within the MongoDB environment. &#39;kOrganization&#39; indicates a Collection in the MongoDB enironment. &#39;kProject&#39; indicates a Collection in the MongoDB enironment. &#39;kCluster&#39; indicates a Collection in the MongoDB enironment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBPhysicalProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="name">Specifies the instance name of the MongoDB entity..</param>
        /// <param name="orgInfo">orgInfo.</param>
        /// <param name="projectInfo">projectInfo.</param>
        /// <param name="type">Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB Physical source entity. &#39;kUnknown&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kOpsManager&#39; indicates a Database within the MongoDB environment. &#39;kOrganization&#39; indicates a Collection in the MongoDB enironment. &#39;kProject&#39; indicates a Collection in the MongoDB enironment. &#39;kCluster&#39; indicates a Collection in the MongoDB enironment..</param>
        /// <param name="uuid">Specifies the UUID for the MongoDB entity..</param>
        public MongoDBPhysicalProtectionSource(MongoDBPhysicalCluster clusterInfo = default(MongoDBPhysicalCluster), string name = default(string), MongoDBOrganization orgInfo = default(MongoDBOrganization), MongoDBProject projectInfo = default(MongoDBProject), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.ClusterInfo = clusterInfo;
            this.Name = name;
            this.OrgInfo = orgInfo;
            this.ProjectInfo = projectInfo;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public MongoDBPhysicalCluster ClusterInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the MongoDB entity.
        /// </summary>
        /// <value>Specifies the instance name of the MongoDB entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrgInfo
        /// </summary>
        [DataMember(Name="orgInfo", EmitDefaultValue=false)]
        public MongoDBOrganization OrgInfo { get; set; }

        /// <summary>
        /// Gets or Sets ProjectInfo
        /// </summary>
        [DataMember(Name="projectInfo", EmitDefaultValue=false)]
        public MongoDBProject ProjectInfo { get; set; }

        /// <summary>
        /// Specifies the UUID for the MongoDB entity.
        /// </summary>
        /// <value>Specifies the UUID for the MongoDB entity.</value>
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
            return this.Equals(input as MongoDBPhysicalProtectionSource);
        }

        /// <summary>
        /// Returns true if MongoDBPhysicalProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBPhysicalProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBPhysicalProtectionSource input)
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
                    this.OrgInfo == input.OrgInfo ||
                    (this.OrgInfo != null &&
                    this.OrgInfo.Equals(input.OrgInfo))
                ) && 
                (
                    this.ProjectInfo == input.ProjectInfo ||
                    (this.ProjectInfo != null &&
                    this.ProjectInfo.Equals(input.ProjectInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.OrgInfo != null)
                    hashCode = hashCode * 59 + this.OrgInfo.GetHashCode();
                if (this.ProjectInfo != null)
                    hashCode = hashCode * 59 + this.ProjectInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

