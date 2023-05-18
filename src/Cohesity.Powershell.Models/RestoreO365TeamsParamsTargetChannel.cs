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
    /// Target channel for teams granular restore to alternate loc. At least one of id or name must be specified. name must be specified if create_new_channel is true.
    /// </summary>
    [DataContract]
    public partial class RestoreO365TeamsParamsTargetChannel :  IEquatable<RestoreO365TeamsParamsTargetChannel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365TeamsParamsTargetChannel" /> class.
        /// </summary>
        /// <param name="channelOwnerVec">Owners for the private channel. This is needed only if we are creating private channel..</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="createNewChannel">Whether to create a new channel. Name must be provided for this case..</param>
        /// <param name="id">Id of the target channel..</param>
        /// <param name="name">Name of the target channel..</param>
        public RestoreO365TeamsParamsTargetChannel(List<EntityProto> channelOwnerVec = default(List<EntityProto>), int? channelType = default(int?), bool? createNewChannel = default(bool?), string id = default(string), string name = default(string))
        {
            this.ChannelOwnerVec = channelOwnerVec;
            this.ChannelType = channelType;
            this.CreateNewChannel = createNewChannel;
            this.Id = id;
            this.Name = name;
            this.ChannelOwnerVec = channelOwnerVec;
            this.ChannelType = channelType;
            this.CreateNewChannel = createNewChannel;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Owners for the private channel. This is needed only if we are creating private channel.
        /// </summary>
        /// <value>Owners for the private channel. This is needed only if we are creating private channel.</value>
        [DataMember(Name="channelOwnerVec", EmitDefaultValue=true)]
        public List<EntityProto> ChannelOwnerVec { get; set; }

        /// <summary>
        /// Gets or Sets ChannelType
        /// </summary>
        [DataMember(Name="channelType", EmitDefaultValue=true)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// Whether to create a new channel. Name must be provided for this case.
        /// </summary>
        /// <value>Whether to create a new channel. Name must be provided for this case.</value>
        [DataMember(Name="createNewChannel", EmitDefaultValue=true)]
        public bool? CreateNewChannel { get; set; }

        /// <summary>
        /// Id of the target channel.
        /// </summary>
        /// <value>Id of the target channel.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the target channel.
        /// </summary>
        /// <value>Name of the target channel.</value>
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
            return this.Equals(input as RestoreO365TeamsParamsTargetChannel);
        }

        /// <summary>
        /// Returns true if RestoreO365TeamsParamsTargetChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365TeamsParamsTargetChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365TeamsParamsTargetChannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelOwnerVec == input.ChannelOwnerVec ||
                    this.ChannelOwnerVec != null &&
                    input.ChannelOwnerVec != null &&
                    this.ChannelOwnerVec.SequenceEqual(input.ChannelOwnerVec)
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.CreateNewChannel == input.CreateNewChannel ||
                    (this.CreateNewChannel != null &&
                    this.CreateNewChannel.Equals(input.CreateNewChannel))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ChannelOwnerVec != null)
                    hashCode = hashCode * 59 + this.ChannelOwnerVec.GetHashCode();
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.CreateNewChannel != null)
                    hashCode = hashCode * 59 + this.CreateNewChannel.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

