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
    /// BackupJobProtoExcludeSource
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoExcludeSource :  IEquatable<BackupJobProtoExcludeSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoExcludeSource" /> class.
        /// </summary>
        /// <param name="entities">An intersection of leaf-level entities will be obtained after expanding the following entities. TODO(Chinmaya): Add some more comments..</param>
        public BackupJobProtoExcludeSource(List<EntityProto> entities = default(List<EntityProto>))
        {
            this.Entities = entities;
            this.Entities = entities;
        }
        
        /// <summary>
        /// An intersection of leaf-level entities will be obtained after expanding the following entities. TODO(Chinmaya): Add some more comments.
        /// </summary>
        /// <value>An intersection of leaf-level entities will be obtained after expanding the following entities. TODO(Chinmaya): Add some more comments.</value>
        [DataMember(Name="entities", EmitDefaultValue=true)]
        public List<EntityProto> Entities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupJobProtoExcludeSource {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as BackupJobProtoExcludeSource);
        }

        /// <summary>
        /// Returns true if BackupJobProtoExcludeSource instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoExcludeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoExcludeSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
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
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                return hashCode;
            }
        }

    }

}
