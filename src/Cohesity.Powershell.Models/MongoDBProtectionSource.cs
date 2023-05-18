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
    public partial class MongoDBProtectionSource :  IEquatable<MongoDBProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB source entity. &#39;kCluster&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kDatabase&#39; indicates a Database within the MongoDB environment. &#39;kCollection&#39; indicates a Collection in the MongoDB enironment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB source entity. &#39;kCluster&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kDatabase&#39; indicates a Database within the MongoDB environment. &#39;kCollection&#39; indicates a Collection in the MongoDB enironment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KDatabase for value: kDatabase
            /// </summary>
            [EnumMember(Value = "kDatabase")]
            KDatabase = 2,

            /// <summary>
            /// Enum KCollection for value: kCollection
            /// </summary>
            [EnumMember(Value = "kCollection")]
            KCollection = 3

        }

        /// <summary>
        /// Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB source entity. &#39;kCluster&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kDatabase&#39; indicates a Database within the MongoDB environment. &#39;kCollection&#39; indicates a Collection in the MongoDB enironment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB source entity. &#39;kCluster&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kDatabase&#39; indicates a Database within the MongoDB environment. &#39;kCollection&#39; indicates a Collection in the MongoDB enironment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="collectionInfo">collectionInfo.</param>
        /// <param name="databaseInfo">databaseInfo.</param>
        /// <param name="name">Specifies the instance name of the MongoDB entity..</param>
        /// <param name="type">Specifies the type of the managed Object in MongoDB Protection Source. Specifies the type of an MongoDB source entity. &#39;kCluster&#39; indicates a mongodb cluster distributed over several physical nodes. &#39;kDatabase&#39; indicates a Database within the MongoDB environment. &#39;kCollection&#39; indicates a Collection in the MongoDB enironment..</param>
        /// <param name="uuid">Specifies the UUID for the MongoDB entity..</param>
        public MongoDBProtectionSource(MongoDBCluster clusterInfo = default(MongoDBCluster), MongoDBCollection collectionInfo = default(MongoDBCollection), MongoDBDatabase databaseInfo = default(MongoDBDatabase), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.ClusterInfo = clusterInfo;
            this.CollectionInfo = collectionInfo;
            this.DatabaseInfo = databaseInfo;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public MongoDBCluster ClusterInfo { get; set; }

        /// <summary>
        /// Gets or Sets CollectionInfo
        /// </summary>
        [DataMember(Name="collectionInfo", EmitDefaultValue=false)]
        public MongoDBCollection CollectionInfo { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseInfo
        /// </summary>
        [DataMember(Name="databaseInfo", EmitDefaultValue=false)]
        public MongoDBDatabase DatabaseInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the MongoDB entity.
        /// </summary>
        /// <value>Specifies the instance name of the MongoDB entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as MongoDBProtectionSource);
        }

        /// <summary>
        /// Returns true if MongoDBProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBProtectionSource input)
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
                    this.CollectionInfo == input.CollectionInfo ||
                    (this.CollectionInfo != null &&
                    this.CollectionInfo.Equals(input.CollectionInfo))
                ) && 
                (
                    this.DatabaseInfo == input.DatabaseInfo ||
                    (this.DatabaseInfo != null &&
                    this.DatabaseInfo.Equals(input.DatabaseInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.CollectionInfo != null)
                    hashCode = hashCode * 59 + this.CollectionInfo.GetHashCode();
                if (this.DatabaseInfo != null)
                    hashCode = hashCode * 59 + this.DatabaseInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

