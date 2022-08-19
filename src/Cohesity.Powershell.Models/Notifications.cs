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
    /// All the Notification events generated for a given user. This is used for for transferring notifications over wire.
    /// </summary>
    [DataContract]
    public partial class Notifications :  IEquatable<Notifications>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications" /> class.
        /// </summary>
        /// <param name="count">Notification Count..</param>
        /// <param name="notificationList">Notification list..</param>
        /// <param name="unreadCount">Unread Notification Count..</param>
        public Notifications(long? count = default(long?), List<TaskNotification> notificationList = default(List<TaskNotification>), long? unreadCount = default(long?))
        {
            this.Count = count;
            this.NotificationList = notificationList;
            this.UnreadCount = unreadCount;
            this.Count = count;
            this.NotificationList = notificationList;
            this.UnreadCount = unreadCount;
        }
        
        /// <summary>
        /// Notification Count.
        /// </summary>
        /// <value>Notification Count.</value>
        [DataMember(Name="count", EmitDefaultValue=true)]
        public long? Count { get; set; }

        /// <summary>
        /// Notification list.
        /// </summary>
        /// <value>Notification list.</value>
        [DataMember(Name="notificationList", EmitDefaultValue=true)]
        public List<TaskNotification> NotificationList { get; set; }

        /// <summary>
        /// Unread Notification Count.
        /// </summary>
        /// <value>Unread Notification Count.</value>
        [DataMember(Name="unreadCount", EmitDefaultValue=true)]
        public long? UnreadCount { get; set; }

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
            return this.Equals(input as Notifications);
        }

        /// <summary>
        /// Returns true if Notifications instances are equal
        /// </summary>
        /// <param name="input">Instance of Notifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.NotificationList == input.NotificationList ||
                    this.NotificationList != null &&
                    input.NotificationList != null &&
                    this.NotificationList.Equals(input.NotificationList)
                ) && 
                (
                    this.UnreadCount == input.UnreadCount ||
                    (this.UnreadCount != null &&
                    this.UnreadCount.Equals(input.UnreadCount))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.NotificationList != null)
                    hashCode = hashCode * 59 + this.NotificationList.GetHashCode();
                if (this.UnreadCount != null)
                    hashCode = hashCode * 59 + this.UnreadCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

