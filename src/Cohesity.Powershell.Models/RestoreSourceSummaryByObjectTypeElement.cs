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
    /// RestoreSourceSummaryByObjectTypeElement represents a recover/clone summary for a single object type.
    /// </summary>
    [DataContract]
    public partial class RestoreSourceSummaryByObjectTypeElement :  IEquatable<RestoreSourceSummaryByObjectTypeElement>
    {
        /// <summary>
        /// Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders.
        /// </summary>
        /// <value>Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KRecoverVMs for value: kRecoverVMs
            /// </summary>
            [EnumMember(Value = "kRecoverVMs")]
            KRecoverVMs = 1,
            
            /// <summary>
            /// Enum KCloneVMs for value: kCloneVMs
            /// </summary>
            [EnumMember(Value = "kCloneVMs")]
            KCloneVMs = 2,
            
            /// <summary>
            /// Enum KCloneView for value: kCloneView
            /// </summary>
            [EnumMember(Value = "kCloneView")]
            KCloneView = 3,
            
            /// <summary>
            /// Enum KMountVolumes for value: kMountVolumes
            /// </summary>
            [EnumMember(Value = "kMountVolumes")]
            KMountVolumes = 4,
            
            /// <summary>
            /// Enum KRestoreFiles for value: kRestoreFiles
            /// </summary>
            [EnumMember(Value = "kRestoreFiles")]
            KRestoreFiles = 5
        }

        /// <summary>
        /// Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders.
        /// </summary>
        /// <value>Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSourceSummaryByObjectTypeElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestoreSourceSummaryByObjectTypeElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSourceSummaryByObjectTypeElement" /> class.
        /// </summary>
        /// <param name="datastoreId">Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source..</param>
        /// <param name="fileRestoreInfo">fileRestoreInfo.</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="objects">Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="protectionSourceName">The protection source name..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the Restore Task as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="type">Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders..</param>
        /// <param name="username">Specifies the Cohesity user who requested this Restore Task..</param>
        public RestoreSourceSummaryByObjectTypeElement(long? datastoreId = default(long?), List<FileRestoreInfo> fileRestoreInfo = default(List<FileRestoreInfo>), string name = default(string), List<RestoreObject> objects = default(List<RestoreObject>), string protectionSourceName = default(string), long? startTimeUsecs = default(long?), TypeEnum? type = default(TypeEnum?), string username = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RestoreSourceSummaryByObjectTypeElement and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.DatastoreId = datastoreId;
            this.FileRestoreInfo = fileRestoreInfo;
            this.Objects = objects;
            this.ProtectionSourceName = protectionSourceName;
            this.StartTimeUsecs = startTimeUsecs;
            this.Type = type;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source.
        /// </summary>
        /// <value>Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source.</value>
        [DataMember(Name="datastoreId", EmitDefaultValue=false)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// Gets or Sets FileRestoreInfo
        /// </summary>
        [DataMember(Name="fileRestoreInfo", EmitDefaultValue=false)]
        public List<FileRestoreInfo> FileRestoreInfo { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=false)]
        public List<RestoreObject> Objects { get; set; }

        /// <summary>
        /// The protection source name.
        /// </summary>
        /// <value>The protection source name.</value>
        [DataMember(Name="protectionSourceName", EmitDefaultValue=false)]
        public string ProtectionSourceName { get; set; }

        /// <summary>
        /// Specifies the start time of the Restore Task as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the Restore Task as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }


        /// <summary>
        /// Specifies the Cohesity user who requested this Restore Task.
        /// </summary>
        /// <value>Specifies the Cohesity user who requested this Restore Task.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as RestoreSourceSummaryByObjectTypeElement);
        }

        /// <summary>
        /// Returns true if RestoreSourceSummaryByObjectTypeElement instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSourceSummaryByObjectTypeElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSourceSummaryByObjectTypeElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreId == input.DatastoreId ||
                    (this.DatastoreId != null &&
                    this.DatastoreId.Equals(input.DatastoreId))
                ) && 
                (
                    this.FileRestoreInfo == input.FileRestoreInfo ||
                    this.FileRestoreInfo != null &&
                    this.FileRestoreInfo.SequenceEqual(input.FileRestoreInfo)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.ProtectionSourceName == input.ProtectionSourceName ||
                    (this.ProtectionSourceName != null &&
                    this.ProtectionSourceName.Equals(input.ProtectionSourceName))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.DatastoreId != null)
                    hashCode = hashCode * 59 + this.DatastoreId.GetHashCode();
                if (this.FileRestoreInfo != null)
                    hashCode = hashCode * 59 + this.FileRestoreInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.ProtectionSourceName != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceName.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

