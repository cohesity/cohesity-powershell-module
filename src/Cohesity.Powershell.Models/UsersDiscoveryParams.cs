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
    /// Specifies discovery params for kUser entities. It should only be populated when the &#39;DiscoveryParams.discoverableObjectTypeList&#39; includes &#39;kUsers&#39;.
    /// </summary>
    [DataContract]
    public partial class UsersDiscoveryParams :  IEquatable<UsersDiscoveryParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDiscoveryParams" /> class.
        /// </summary>
        /// <param name="discoverUsersWithMailbox">Specifies if office 365 users with valid mailboxes should be discovered or not..</param>
        /// <param name="discoverUsersWithOnedrive">Specifies if office 365 users with valid Onedrives should be discovered or not..</param>
        /// <param name="fetchMailboxInfo">Specifies whether users&#39; mailbox info including the provisioning status, mailbox type &amp; in-place archival support will be fetched and processed..</param>
        /// <param name="fetchOneDriveInfo">Specifies whether users&#39; onedrive info including the provisioning status &amp; storage quota will be fetched and processed..</param>
        /// <param name="skipUsersWithoutMySite">Specifies whether to skip processing user who have uninitialized OneDrive or are without MySite..</param>
        public UsersDiscoveryParams(bool? discoverUsersWithMailbox = default(bool?), bool? discoverUsersWithOnedrive = default(bool?), bool? fetchMailboxInfo = default(bool?), bool? fetchOneDriveInfo = default(bool?), bool? skipUsersWithoutMySite = default(bool?))
        {
            this.DiscoverUsersWithMailbox = discoverUsersWithMailbox;
            this.DiscoverUsersWithOnedrive = discoverUsersWithOnedrive;
            this.FetchMailboxInfo = fetchMailboxInfo;
            this.FetchOneDriveInfo = fetchOneDriveInfo;
            this.SkipUsersWithoutMySite = skipUsersWithoutMySite;
            this.DiscoverUsersWithMailbox = discoverUsersWithMailbox;
            this.DiscoverUsersWithOnedrive = discoverUsersWithOnedrive;
            this.FetchMailboxInfo = fetchMailboxInfo;
            this.FetchOneDriveInfo = fetchOneDriveInfo;
            this.SkipUsersWithoutMySite = skipUsersWithoutMySite;
        }
        
        /// <summary>
        /// Specifies if office 365 users with valid mailboxes should be discovered or not.
        /// </summary>
        /// <value>Specifies if office 365 users with valid mailboxes should be discovered or not.</value>
        [DataMember(Name="discoverUsersWithMailbox", EmitDefaultValue=true)]
        public bool? DiscoverUsersWithMailbox { get; set; }

        /// <summary>
        /// Specifies if office 365 users with valid Onedrives should be discovered or not.
        /// </summary>
        /// <value>Specifies if office 365 users with valid Onedrives should be discovered or not.</value>
        [DataMember(Name="discoverUsersWithOnedrive", EmitDefaultValue=true)]
        public bool? DiscoverUsersWithOnedrive { get; set; }

        /// <summary>
        /// Specifies whether users&#39; mailbox info including the provisioning status, mailbox type &amp; in-place archival support will be fetched and processed.
        /// </summary>
        /// <value>Specifies whether users&#39; mailbox info including the provisioning status, mailbox type &amp; in-place archival support will be fetched and processed.</value>
        [DataMember(Name="fetchMailboxInfo", EmitDefaultValue=true)]
        public bool? FetchMailboxInfo { get; set; }

        /// <summary>
        /// Specifies whether users&#39; onedrive info including the provisioning status &amp; storage quota will be fetched and processed.
        /// </summary>
        /// <value>Specifies whether users&#39; onedrive info including the provisioning status &amp; storage quota will be fetched and processed.</value>
        [DataMember(Name="fetchOneDriveInfo", EmitDefaultValue=true)]
        public bool? FetchOneDriveInfo { get; set; }

        /// <summary>
        /// Specifies whether to skip processing user who have uninitialized OneDrive or are without MySite.
        /// </summary>
        /// <value>Specifies whether to skip processing user who have uninitialized OneDrive or are without MySite.</value>
        [DataMember(Name="skipUsersWithoutMySite", EmitDefaultValue=true)]
        public bool? SkipUsersWithoutMySite { get; set; }

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
            return this.Equals(input as UsersDiscoveryParams);
        }

        /// <summary>
        /// Returns true if UsersDiscoveryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersDiscoveryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersDiscoveryParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscoverUsersWithMailbox == input.DiscoverUsersWithMailbox ||
                    (this.DiscoverUsersWithMailbox != null &&
                    this.DiscoverUsersWithMailbox.Equals(input.DiscoverUsersWithMailbox))
                ) && 
                (
                    this.DiscoverUsersWithOnedrive == input.DiscoverUsersWithOnedrive ||
                    (this.DiscoverUsersWithOnedrive != null &&
                    this.DiscoverUsersWithOnedrive.Equals(input.DiscoverUsersWithOnedrive))
                ) && 
                (
                    this.FetchMailboxInfo == input.FetchMailboxInfo ||
                    (this.FetchMailboxInfo != null &&
                    this.FetchMailboxInfo.Equals(input.FetchMailboxInfo))
                ) && 
                (
                    this.FetchOneDriveInfo == input.FetchOneDriveInfo ||
                    (this.FetchOneDriveInfo != null &&
                    this.FetchOneDriveInfo.Equals(input.FetchOneDriveInfo))
                ) && 
                (
                    this.SkipUsersWithoutMySite == input.SkipUsersWithoutMySite ||
                    (this.SkipUsersWithoutMySite != null &&
                    this.SkipUsersWithoutMySite.Equals(input.SkipUsersWithoutMySite))
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
                if (this.DiscoverUsersWithMailbox != null)
                    hashCode = hashCode * 59 + this.DiscoverUsersWithMailbox.GetHashCode();
                if (this.DiscoverUsersWithOnedrive != null)
                    hashCode = hashCode * 59 + this.DiscoverUsersWithOnedrive.GetHashCode();
                if (this.FetchMailboxInfo != null)
                    hashCode = hashCode * 59 + this.FetchMailboxInfo.GetHashCode();
                if (this.FetchOneDriveInfo != null)
                    hashCode = hashCode * 59 + this.FetchOneDriveInfo.GetHashCode();
                if (this.SkipUsersWithoutMySite != null)
                    hashCode = hashCode * 59 + this.SkipUsersWithoutMySite.GetHashCode();
                return hashCode;
            }
        }

    }

}

