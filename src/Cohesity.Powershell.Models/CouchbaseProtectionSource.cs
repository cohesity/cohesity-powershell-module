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
    /// Specifies an Object representing Couchbase.
    /// </summary>
    [DataContract]
    public partial class CouchbaseProtectionSource :  IEquatable<CouchbaseProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Couchbase Protection Source. Specifies the type of an Couchbase source entity. &#39;kCluster&#39; indicates a Couchbase cluster distributed over several physical nodes. &#39;kBucket&#39; indicates a bucket within the Couchbase environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Couchbase Protection Source. Specifies the type of an Couchbase source entity. &#39;kCluster&#39; indicates a Couchbase cluster distributed over several physical nodes. &#39;kBucket&#39; indicates a bucket within the Couchbase environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KBucket for value: kBucket
            /// </summary>
            [EnumMember(Value = "kBucket")]
            KBucket = 2

        }

        /// <summary>
        /// Specifies the type of the managed Object in Couchbase Protection Source. Specifies the type of an Couchbase source entity. &#39;kCluster&#39; indicates a Couchbase cluster distributed over several physical nodes. &#39;kBucket&#39; indicates a bucket within the Couchbase environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Couchbase Protection Source. Specifies the type of an Couchbase source entity. &#39;kCluster&#39; indicates a Couchbase cluster distributed over several physical nodes. &#39;kBucket&#39; indicates a bucket within the Couchbase environment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouchbaseProtectionSource" /> class.
        /// </summary>
        /// <param name="bucketInfo">bucketInfo.</param>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="name">Specifies the instance name of the Couchbase entity..</param>
        /// <param name="type">Specifies the type of the managed Object in Couchbase Protection Source. Specifies the type of an Couchbase source entity. &#39;kCluster&#39; indicates a Couchbase cluster distributed over several physical nodes. &#39;kBucket&#39; indicates a bucket within the Couchbase environment..</param>
        /// <param name="uuid">Specifies the UUID for the Couchbase entity..</param>
        public CouchbaseProtectionSource(CouchbaseBucket bucketInfo = default(CouchbaseBucket), CouchbaseCluster clusterInfo = default(CouchbaseCluster), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.BucketInfo = bucketInfo;
            this.ClusterInfo = clusterInfo;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets BucketInfo
        /// </summary>
        [DataMember(Name="bucketInfo", EmitDefaultValue=false)]
        public CouchbaseBucket BucketInfo { get; set; }

        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public CouchbaseCluster ClusterInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the Couchbase entity.
        /// </summary>
        /// <value>Specifies the instance name of the Couchbase entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID for the Couchbase entity.
        /// </summary>
        /// <value>Specifies the UUID for the Couchbase entity.</value>
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
            return this.Equals(input as CouchbaseProtectionSource);
        }

        /// <summary>
        /// Returns true if CouchbaseProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of CouchbaseProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouchbaseProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketInfo == input.BucketInfo ||
                    (this.BucketInfo != null &&
                    this.BucketInfo.Equals(input.BucketInfo))
                ) && 
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
                if (this.BucketInfo != null)
                    hashCode = hashCode * 59 + this.BucketInfo.GetHashCode();
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
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

