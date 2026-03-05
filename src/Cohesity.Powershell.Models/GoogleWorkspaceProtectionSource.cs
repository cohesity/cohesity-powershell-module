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
    /// Specifies an Object representing GoogleWorkspace.
    /// </summary>
    [DataContract]
    public partial class GoogleWorkspaceProtectionSource :  IEquatable<GoogleWorkspaceProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Google Workspace Protection Source. Specifies the type of a Google Workspace source entity. &#39;kWorkspaceOrg&#39; indicates the organization unit in Google Workspace environment. &#39;kUsers&#39; indicates a user collection in the Google Workspace environment. &#39;kGroups&#39; indicates a group collection in the Google Workspace environment. &#39;kSharedDrives&#39; indicates a shared drive collection in the Google Workspace environment. &#39;kUser&#39; indicates a user in the Google Workspace environment. &#39;kGroup&#39; indicates a group in the Google Workspace environment. &#39;kSharedDrive&#39; indicates a shared drive in the Google Workspace environment. &#39;kGmail&#39; indicates a mailbox in the Google Workspace environment. &#39;kGoogleDrive&#39; indicates a google drive in the Google Workspace environment. kGmail, kGoogleDrive
        /// </summary>
        /// <value>Specifies the type of the managed Object in Google Workspace Protection Source. Specifies the type of a Google Workspace source entity. &#39;kWorkspaceOrg&#39; indicates the organization unit in Google Workspace environment. &#39;kUsers&#39; indicates a user collection in the Google Workspace environment. &#39;kGroups&#39; indicates a group collection in the Google Workspace environment. &#39;kSharedDrives&#39; indicates a shared drive collection in the Google Workspace environment. &#39;kUser&#39; indicates a user in the Google Workspace environment. &#39;kGroup&#39; indicates a group in the Google Workspace environment. &#39;kSharedDrive&#39; indicates a shared drive in the Google Workspace environment. &#39;kGmail&#39; indicates a mailbox in the Google Workspace environment. &#39;kGoogleDrive&#39; indicates a google drive in the Google Workspace environment. kGmail, kGoogleDrive</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KWorkspaceOrg for value: kWorkspaceOrg
            /// </summary>
            [EnumMember(Value = "kWorkspaceOrg")]
            KWorkspaceOrg = 1,

            /// <summary>
            /// Enum KUsers for value: kUsers
            /// </summary>
            [EnumMember(Value = "kUsers")]
            KUsers = 2,

            /// <summary>
            /// Enum KGroups for value: kGroups
            /// </summary>
            [EnumMember(Value = "kGroups")]
            KGroups = 3,

            /// <summary>
            /// Enum KSharedDrives for value: kSharedDrives
            /// </summary>
            [EnumMember(Value = "kSharedDrives")]
            KSharedDrives = 4,

            /// <summary>
            /// Enum KUser for value: kUser
            /// </summary>
            [EnumMember(Value = "kUser")]
            KUser = 5,

            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 6,

            /// <summary>
            /// Enum KSharedDrive for value: kSharedDrive
            /// </summary>
            [EnumMember(Value = "kSharedDrive")]
            KSharedDrive = 7

        }

        /// <summary>
        /// Specifies the type of the managed Object in Google Workspace Protection Source. Specifies the type of a Google Workspace source entity. &#39;kWorkspaceOrg&#39; indicates the organization unit in Google Workspace environment. &#39;kUsers&#39; indicates a user collection in the Google Workspace environment. &#39;kGroups&#39; indicates a group collection in the Google Workspace environment. &#39;kSharedDrives&#39; indicates a shared drive collection in the Google Workspace environment. &#39;kUser&#39; indicates a user in the Google Workspace environment. &#39;kGroup&#39; indicates a group in the Google Workspace environment. &#39;kSharedDrive&#39; indicates a shared drive in the Google Workspace environment. &#39;kGmail&#39; indicates a mailbox in the Google Workspace environment. &#39;kGoogleDrive&#39; indicates a google drive in the Google Workspace environment. kGmail, kGoogleDrive
        /// </summary>
        /// <value>Specifies the type of the managed Object in Google Workspace Protection Source. Specifies the type of a Google Workspace source entity. &#39;kWorkspaceOrg&#39; indicates the organization unit in Google Workspace environment. &#39;kUsers&#39; indicates a user collection in the Google Workspace environment. &#39;kGroups&#39; indicates a group collection in the Google Workspace environment. &#39;kSharedDrives&#39; indicates a shared drive collection in the Google Workspace environment. &#39;kUser&#39; indicates a user in the Google Workspace environment. &#39;kGroup&#39; indicates a group in the Google Workspace environment. &#39;kSharedDrive&#39; indicates a shared drive in the Google Workspace environment. &#39;kGmail&#39; indicates a mailbox in the Google Workspace environment. &#39;kGoogleDrive&#39; indicates a google drive in the Google Workspace environment. kGmail, kGoogleDrive</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleWorkspaceProtectionSource" /> class.
        /// </summary>
        /// <param name="id">Specifies the entity id..</param>
        /// <param name="name">Specifies the instance name of the Google Workspace entity..</param>
        /// <param name="type">Specifies the type of the managed Object in Google Workspace Protection Source. Specifies the type of a Google Workspace source entity. &#39;kWorkspaceOrg&#39; indicates the organization unit in Google Workspace environment. &#39;kUsers&#39; indicates a user collection in the Google Workspace environment. &#39;kGroups&#39; indicates a group collection in the Google Workspace environment. &#39;kSharedDrives&#39; indicates a shared drive collection in the Google Workspace environment. &#39;kUser&#39; indicates a user in the Google Workspace environment. &#39;kGroup&#39; indicates a group in the Google Workspace environment. &#39;kSharedDrive&#39; indicates a shared drive in the Google Workspace environment. &#39;kGmail&#39; indicates a mailbox in the Google Workspace environment. &#39;kGoogleDrive&#39; indicates a google drive in the Google Workspace environment. kGmail, kGoogleDrive.</param>
        public GoogleWorkspaceProtectionSource(long? id = default(long?), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the entity id.
        /// </summary>
        /// <value>Specifies the entity id.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the instance name of the Google Workspace entity.
        /// </summary>
        /// <value>Specifies the instance name of the Google Workspace entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as GoogleWorkspaceProtectionSource);
        }

        /// <summary>
        /// Returns true if GoogleWorkspaceProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleWorkspaceProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleWorkspaceProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

