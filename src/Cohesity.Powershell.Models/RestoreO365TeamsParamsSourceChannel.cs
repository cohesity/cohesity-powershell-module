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
    /// RestoreO365TeamsParamsSourceChannel
    /// </summary>
    [DataContract]
    public partial class RestoreO365TeamsParamsSourceChannel :  IEquatable<RestoreO365TeamsParamsSourceChannel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365TeamsParamsSourceChannel" /> class.
        /// </summary>
        /// <param name="driveVec">Drives of this channel whose items have to be restored. This will be empty iff is_full_channel_restore is true..</param>
        /// <param name="id">Id of the source channel for restore..</param>
        /// <param name="isFullChannelRestore">Whether we have to restore the complete channel..</param>
        /// <param name="name">Name of the source channel for restore..</param>
        public RestoreO365TeamsParamsSourceChannel(List<RestoreSiteParamsSiteOwnerDrive> driveVec = default(List<RestoreSiteParamsSiteOwnerDrive>), string id = default(string), bool? isFullChannelRestore = default(bool?), string name = default(string))
        {
            this.DriveVec = driveVec;
            this.Id = id;
            this.IsFullChannelRestore = isFullChannelRestore;
            this.Name = name;
            this.DriveVec = driveVec;
            this.Id = id;
            this.IsFullChannelRestore = isFullChannelRestore;
            this.Name = name;
        }
        
        /// <summary>
        /// Drives of this channel whose items have to be restored. This will be empty iff is_full_channel_restore is true.
        /// </summary>
        /// <value>Drives of this channel whose items have to be restored. This will be empty iff is_full_channel_restore is true.</value>
        [DataMember(Name="driveVec", EmitDefaultValue=true)]
        public List<RestoreSiteParamsSiteOwnerDrive> DriveVec { get; set; }

        /// <summary>
        /// Id of the source channel for restore.
        /// </summary>
        /// <value>Id of the source channel for restore.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Whether we have to restore the complete channel.
        /// </summary>
        /// <value>Whether we have to restore the complete channel.</value>
        [DataMember(Name="isFullChannelRestore", EmitDefaultValue=true)]
        public bool? IsFullChannelRestore { get; set; }

        /// <summary>
        /// Name of the source channel for restore.
        /// </summary>
        /// <value>Name of the source channel for restore.</value>
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
            return this.Equals(input as RestoreO365TeamsParamsSourceChannel);
        }

        /// <summary>
        /// Returns true if RestoreO365TeamsParamsSourceChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365TeamsParamsSourceChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365TeamsParamsSourceChannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveVec == input.DriveVec ||
                    this.DriveVec != null &&
                    input.DriveVec != null &&
                    this.DriveVec.Equals(input.DriveVec)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsFullChannelRestore == input.IsFullChannelRestore ||
                    (this.IsFullChannelRestore != null &&
                    this.IsFullChannelRestore.Equals(input.IsFullChannelRestore))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.DriveVec != null)
                    hashCode = hashCode * 59 + this.DriveVec.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsFullChannelRestore != null)
                    hashCode = hashCode * 59 + this.IsFullChannelRestore.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

