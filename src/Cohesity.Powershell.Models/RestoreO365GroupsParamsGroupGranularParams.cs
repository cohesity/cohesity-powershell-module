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
    /// RestoreO365GroupsParamsGroupGranularParams
    /// </summary>
    [DataContract]
    public partial class RestoreO365GroupsParamsGroupGranularParams :  IEquatable<RestoreO365GroupsParamsGroupGranularParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365GroupsParamsGroupGranularParams" /> class.
        /// </summary>
        /// <param name="groupId">The Unique ID of the group..</param>
        /// <param name="groupMbxParams">groupMbxParams.</param>
        /// <param name="restoreSiteParams">restoreSiteParams.</param>
        public RestoreO365GroupsParamsGroupGranularParams(string groupId = default(string), RestoreOutlookParams groupMbxParams = default(RestoreOutlookParams), RestoreSiteParams restoreSiteParams = default(RestoreSiteParams))
        {
            this.GroupId = groupId;
            this.GroupId = groupId;
            this.GroupMbxParams = groupMbxParams;
            this.RestoreSiteParams = restoreSiteParams;
        }
        
        /// <summary>
        /// The Unique ID of the group.
        /// </summary>
        /// <value>The Unique ID of the group.</value>
        [DataMember(Name="groupId", EmitDefaultValue=true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets GroupMbxParams
        /// </summary>
        [DataMember(Name="groupMbxParams", EmitDefaultValue=false)]
        public RestoreOutlookParams GroupMbxParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreSiteParams
        /// </summary>
        [DataMember(Name="restoreSiteParams", EmitDefaultValue=false)]
        public RestoreSiteParams RestoreSiteParams { get; set; }

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
            return this.Equals(input as RestoreO365GroupsParamsGroupGranularParams);
        }

        /// <summary>
        /// Returns true if RestoreO365GroupsParamsGroupGranularParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365GroupsParamsGroupGranularParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365GroupsParamsGroupGranularParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupMbxParams == input.GroupMbxParams ||
                    (this.GroupMbxParams != null &&
                    this.GroupMbxParams.Equals(input.GroupMbxParams))
                ) && 
                (
                    this.RestoreSiteParams == input.RestoreSiteParams ||
                    (this.RestoreSiteParams != null &&
                    this.RestoreSiteParams.Equals(input.RestoreSiteParams))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupMbxParams != null)
                    hashCode = hashCode * 59 + this.GroupMbxParams.GetHashCode();
                if (this.RestoreSiteParams != null)
                    hashCode = hashCode * 59 + this.RestoreSiteParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

