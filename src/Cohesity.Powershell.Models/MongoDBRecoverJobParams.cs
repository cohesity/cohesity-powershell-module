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
    /// Contains any additional mongodb environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class MongoDBRecoverJobParams :  IEquatable<MongoDBRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBRecoverJobParams" /> class.
        /// </summary>
        /// <param name="recoverUserRole">Should the agent Recover users and roles in this job..</param>
        /// <param name="recoverZonesTags">Should the agent Recover zones/shard tags in this job..</param>
        /// <param name="suffix">A suffix that is to be applied to all recovered entities.</param>
        public MongoDBRecoverJobParams(bool? recoverUserRole = default(bool?), bool? recoverZonesTags = default(bool?), string suffix = default(string))
        {
            this.RecoverUserRole = recoverUserRole;
            this.RecoverZonesTags = recoverZonesTags;
            this.Suffix = suffix;
            this.RecoverUserRole = recoverUserRole;
            this.RecoverZonesTags = recoverZonesTags;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Should the agent Recover users and roles in this job.
        /// </summary>
        /// <value>Should the agent Recover users and roles in this job.</value>
        [DataMember(Name="recoverUserRole", EmitDefaultValue=true)]
        public bool? RecoverUserRole { get; set; }

        /// <summary>
        /// Should the agent Recover zones/shard tags in this job.
        /// </summary>
        /// <value>Should the agent Recover zones/shard tags in this job.</value>
        [DataMember(Name="recoverZonesTags", EmitDefaultValue=true)]
        public bool? RecoverZonesTags { get; set; }

        /// <summary>
        /// A suffix that is to be applied to all recovered entities
        /// </summary>
        /// <value>A suffix that is to be applied to all recovered entities</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

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
            return this.Equals(input as MongoDBRecoverJobParams);
        }

        /// <summary>
        /// Returns true if MongoDBRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecoverUserRole == input.RecoverUserRole ||
                    (this.RecoverUserRole != null &&
                    this.RecoverUserRole.Equals(input.RecoverUserRole))
                ) && 
                (
                    this.RecoverZonesTags == input.RecoverZonesTags ||
                    (this.RecoverZonesTags != null &&
                    this.RecoverZonesTags.Equals(input.RecoverZonesTags))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.RecoverUserRole != null)
                    hashCode = hashCode * 59 + this.RecoverUserRole.GetHashCode();
                if (this.RecoverZonesTags != null)
                    hashCode = hashCode * 59 + this.RecoverZonesTags.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

