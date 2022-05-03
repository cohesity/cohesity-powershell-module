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
    /// BackupJobProtoBackupSource
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoBackupSource :  IEquatable<BackupJobProtoBackupSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoBackupSource" /> class.
        /// </summary>
        /// <param name="entities">Source entities. NOTE: Multiple sources can be specified here for non-leaf-level entities in the hierarchy. The sources obtained after expanding these will be intersected among each other to form the final set of sources. e.g. this can be used to backup only those VMs that have both the tags &#39;SQL&#39; and &#39;3hrs&#39;..</param>
        public BackupJobProtoBackupSource(List<EntityProto> entities = default(List<EntityProto>))
        {
            this.Entities = entities;
        }
        
        /// <summary>
        /// Source entities. NOTE: Multiple sources can be specified here for non-leaf-level entities in the hierarchy. The sources obtained after expanding these will be intersected among each other to form the final set of sources. e.g. this can be used to backup only those VMs that have both the tags &#39;SQL&#39; and &#39;3hrs&#39;.
        /// </summary>
        /// <value>Source entities. NOTE: Multiple sources can be specified here for non-leaf-level entities in the hierarchy. The sources obtained after expanding these will be intersected among each other to form the final set of sources. e.g. this can be used to backup only those VMs that have both the tags &#39;SQL&#39; and &#39;3hrs&#39;.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EntityProto> Entities { get; set; }

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
            return this.Equals(input as BackupJobProtoBackupSource);
        }

        /// <summary>
        /// Returns true if BackupJobProtoBackupSource instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoBackupSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoBackupSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.Equals(input.Entities)
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

