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
    /// NoSqlRestoreObject
    /// </summary>
    [DataContract]
    public partial class NoSqlRestoreObject :  IEquatable<NoSqlRestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlRestoreObject" /> class.
        /// </summary>
        /// <param name="objectRestorePropertiesMap">Key-Value pair for properties to apply on restore object. Ex. Compaction for cassandra or ShardKeyJson for Mongo..</param>
        /// <param name="objectUuid">Uuid of the object to be restored..</param>
        /// <param name="rename">The new name of the object after restore..</param>
        public NoSqlRestoreObject(List<NoSqlRestoreObjectObjectRestorePropertiesMapEntry> objectRestorePropertiesMap = default(List<NoSqlRestoreObjectObjectRestorePropertiesMapEntry>), string objectUuid = default(string), string rename = default(string))
        {
            this.ObjectRestorePropertiesMap = objectRestorePropertiesMap;
            this.ObjectUuid = objectUuid;
            this.Rename = rename;
        }
        
        /// <summary>
        /// Key-Value pair for properties to apply on restore object. Ex. Compaction for cassandra or ShardKeyJson for Mongo.
        /// </summary>
        /// <value>Key-Value pair for properties to apply on restore object. Ex. Compaction for cassandra or ShardKeyJson for Mongo.</value>
        [DataMember(Name="objectRestorePropertiesMap", EmitDefaultValue=false)]
        public List<NoSqlRestoreObjectObjectRestorePropertiesMapEntry> ObjectRestorePropertiesMap { get; set; }

        /// <summary>
        /// Uuid of the object to be restored.
        /// </summary>
        /// <value>Uuid of the object to be restored.</value>
        [DataMember(Name="objectUuid", EmitDefaultValue=false)]
        public string ObjectUuid { get; set; }

        /// <summary>
        /// The new name of the object after restore.
        /// </summary>
        /// <value>The new name of the object after restore.</value>
        [DataMember(Name="rename", EmitDefaultValue=false)]
        public string Rename { get; set; }

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
            return this.Equals(input as NoSqlRestoreObject);
        }

        /// <summary>
        /// Returns true if NoSqlRestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlRestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlRestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectRestorePropertiesMap == input.ObjectRestorePropertiesMap ||
                    this.ObjectRestorePropertiesMap != null &&
                    this.ObjectRestorePropertiesMap.Equals(input.ObjectRestorePropertiesMap)
                ) && 
                (
                    this.ObjectUuid == input.ObjectUuid ||
                    (this.ObjectUuid != null &&
                    this.ObjectUuid.Equals(input.ObjectUuid))
                ) && 
                (
                    this.Rename == input.Rename ||
                    (this.Rename != null &&
                    this.Rename.Equals(input.Rename))
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
                if (this.ObjectRestorePropertiesMap != null)
                    hashCode = hashCode * 59 + this.ObjectRestorePropertiesMap.GetHashCode();
                if (this.ObjectUuid != null)
                    hashCode = hashCode * 59 + this.ObjectUuid.GetHashCode();
                if (this.Rename != null)
                    hashCode = hashCode * 59 + this.Rename.GetHashCode();
                return hashCode;
            }
        }

    }

}

