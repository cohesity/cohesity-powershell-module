// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the user ids to remove the corresponding quota overrides in view.
    /// </summary>
    [DataContract]
    public partial class DeleteViewUsersQuotaParameters :  IEquatable<DeleteViewUsersQuotaParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteViewUsersQuotaParameters" /> class.
        /// </summary>
        /// <param name="deleteAll">Delete all existing user quota override policies..</param>
        /// <param name="userIds">userIds.</param>
        /// <param name="viewName">View name of input view..</param>
        public DeleteViewUsersQuotaParameters(bool? deleteAll = default(bool?), List<UserId> userIds = default(List<UserId>), string viewName = default(string))
        {
            this.DeleteAll = deleteAll;
            this.UserIds = userIds;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Delete all existing user quota override policies.
        /// </summary>
        /// <value>Delete all existing user quota override policies.</value>
        [DataMember(Name="deleteAll", EmitDefaultValue=false)]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<UserId> UserIds { get; set; }

        /// <summary>
        /// View name of input view.
        /// </summary>
        /// <value>View name of input view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as DeleteViewUsersQuotaParameters);
        }

        /// <summary>
        /// Returns true if DeleteViewUsersQuotaParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteViewUsersQuotaParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteViewUsersQuotaParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteAll == input.DeleteAll ||
                    (this.DeleteAll != null &&
                    this.DeleteAll.Equals(input.DeleteAll))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.DeleteAll != null)
                    hashCode = hashCode * 59 + this.DeleteAll.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

