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
    /// EntityDAGProto is used to pass child-&gt;parent relationships of entities from Master Op to Slave Op.
    /// </summary>
    [DataContract]
    public partial class EntityDAGProto :  IEquatable<EntityDAGProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDAGProto" /> class.
        /// </summary>
        /// <param name="entityVec">List of all unique entities in the DAG..</param>
        /// <param name="parentLinksMap">Collection of all edges (child -&gt; parent links) defining the DAG structure. Do not assume any order in which the edges will be present..</param>
        public EntityDAGProto(List<EntityProto> entityVec = default(List<EntityProto>), List<EntityDAGProtoEntityDAGEdge> parentLinksMap = default(List<EntityDAGProtoEntityDAGEdge>))
        {
            this.EntityVec = entityVec;
            this.ParentLinksMap = parentLinksMap;
            this.EntityVec = entityVec;
            this.ParentLinksMap = parentLinksMap;
        }
        
        /// <summary>
        /// List of all unique entities in the DAG.
        /// </summary>
        /// <value>List of all unique entities in the DAG.</value>
        [DataMember(Name="entityVec", EmitDefaultValue=true)]
        public List<EntityProto> EntityVec { get; set; }

        /// <summary>
        /// Collection of all edges (child -&gt; parent links) defining the DAG structure. Do not assume any order in which the edges will be present.
        /// </summary>
        /// <value>Collection of all edges (child -&gt; parent links) defining the DAG structure. Do not assume any order in which the edges will be present.</value>
        [DataMember(Name="parentLinksMap", EmitDefaultValue=true)]
        public List<EntityDAGProtoEntityDAGEdge> ParentLinksMap { get; set; }

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
            return this.Equals(input as EntityDAGProto);
        }

        /// <summary>
        /// Returns true if EntityDAGProto instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityDAGProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityDAGProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityVec == input.EntityVec ||
                    this.EntityVec != null &&
                    input.EntityVec != null &&
                    this.EntityVec.SequenceEqual(input.EntityVec)
                ) && 
                (
                    this.ParentLinksMap == input.ParentLinksMap ||
                    this.ParentLinksMap != null &&
                    input.ParentLinksMap != null &&
                    this.ParentLinksMap.SequenceEqual(input.ParentLinksMap)
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
                if (this.EntityVec != null)
                    hashCode = hashCode * 59 + this.EntityVec.GetHashCode();
                if (this.ParentLinksMap != null)
                    hashCode = hashCode * 59 + this.ParentLinksMap.GetHashCode();
                return hashCode;
            }
        }

    }

}

