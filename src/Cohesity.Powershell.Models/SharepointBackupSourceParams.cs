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
    /// SharepointBackupSourceParams
    /// </summary>
    [DataContract]
    public partial class SharepointBackupSourceParams :  IEquatable<SharepointBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointBackupSourceParams" /> class.
        /// </summary>
        /// <param name="autoprotectEntity">Specifies to whether autoprotect the site entity  or not. If this is set to true, the site entity and subsites of it are protected. If this is set to false, only the site entity is protected..</param>
        public SharepointBackupSourceParams(bool? autoprotectEntity = default(bool?))
        {
            this.AutoprotectEntity = autoprotectEntity;
            this.AutoprotectEntity = autoprotectEntity;
        }
        
        /// <summary>
        /// Specifies to whether autoprotect the site entity  or not. If this is set to true, the site entity and subsites of it are protected. If this is set to false, only the site entity is protected.
        /// </summary>
        /// <value>Specifies to whether autoprotect the site entity  or not. If this is set to true, the site entity and subsites of it are protected. If this is set to false, only the site entity is protected.</value>
        [DataMember(Name="autoprotectEntity", EmitDefaultValue=true)]
        public bool? AutoprotectEntity { get; set; }

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
            return this.Equals(input as SharepointBackupSourceParams);
        }

        /// <summary>
        /// Returns true if SharepointBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SharepointBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharepointBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoprotectEntity == input.AutoprotectEntity ||
                    (this.AutoprotectEntity != null &&
                    this.AutoprotectEntity.Equals(input.AutoprotectEntity))
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
                if (this.AutoprotectEntity != null)
                    hashCode = hashCode * 59 + this.AutoprotectEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

