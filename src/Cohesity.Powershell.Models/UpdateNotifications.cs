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
    /// Specifies the list of notificationIds and the operation to be performed.
    /// </summary>
    [DataContract]
    public partial class UpdateNotifications :  IEquatable<UpdateNotifications>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNotifications" /> class.
        /// </summary>
        /// <param name="action">Specifies the operation to be performed on the resource. Eg. \&quot;action\&quot;:\&quot;dismiss\&quot;.</param>
        /// <param name="notificationIds">Specifies the list of NotificationIds to be operated upon..</param>
        public UpdateNotifications(string action = default(string), List<string> notificationIds = default(List<string>))
        {
            this.Action = action;
            this.NotificationIds = notificationIds;
            this.Action = action;
            this.NotificationIds = notificationIds;
        }
        
        /// <summary>
        /// Specifies the operation to be performed on the resource. Eg. \&quot;action\&quot;:\&quot;dismiss\&quot;
        /// </summary>
        /// <value>Specifies the operation to be performed on the resource. Eg. \&quot;action\&quot;:\&quot;dismiss\&quot;</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public string Action { get; set; }

        /// <summary>
        /// Specifies the list of NotificationIds to be operated upon.
        /// </summary>
        /// <value>Specifies the list of NotificationIds to be operated upon.</value>
        [DataMember(Name="notificationIds", EmitDefaultValue=true)]
        public List<string> NotificationIds { get; set; }

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
            return this.Equals(input as UpdateNotifications);
        }

        /// <summary>
        /// Returns true if UpdateNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNotifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.NotificationIds == input.NotificationIds ||
                    this.NotificationIds != null &&
                    input.NotificationIds != null &&
                    this.NotificationIds.SequenceEqual(input.NotificationIds)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.NotificationIds != null)
                    hashCode = hashCode * 59 + this.NotificationIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

