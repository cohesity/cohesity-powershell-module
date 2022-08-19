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
    /// Specifies information about an Office365 Team.
    /// </summary>
    [DataContract]
    public partial class Office365TeamInfo :  IEquatable<Office365TeamInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365TeamInfo" /> class.
        /// </summary>
        /// <param name="channelCount">Specifies the channel count associated with a team..</param>
        /// <param name="channels">Specifies the list of channels associated with a team..</param>
        /// <param name="membersCount">Specifies the members count associated with a team..</param>
        public Office365TeamInfo(long? channelCount = default(long?), List<M365TeamsChannelInfo> channels = default(List<M365TeamsChannelInfo>), long? membersCount = default(long?))
        {
            this.ChannelCount = channelCount;
            this.Channels = channels;
            this.MembersCount = membersCount;
            this.ChannelCount = channelCount;
            this.Channels = channels;
            this.MembersCount = membersCount;
        }
        
        /// <summary>
        /// Specifies the channel count associated with a team.
        /// </summary>
        /// <value>Specifies the channel count associated with a team.</value>
        [DataMember(Name="channelCount", EmitDefaultValue=true)]
        public long? ChannelCount { get; set; }

        /// <summary>
        /// Specifies the list of channels associated with a team.
        /// </summary>
        /// <value>Specifies the list of channels associated with a team.</value>
        [DataMember(Name="channels", EmitDefaultValue=true)]
        public List<M365TeamsChannelInfo> Channels { get; set; }

        /// <summary>
        /// Specifies the members count associated with a team.
        /// </summary>
        /// <value>Specifies the members count associated with a team.</value>
        [DataMember(Name="membersCount", EmitDefaultValue=true)]
        public long? MembersCount { get; set; }

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
            return this.Equals(input as Office365TeamInfo);
        }

        /// <summary>
        /// Returns true if Office365TeamInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365TeamInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365TeamInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelCount == input.ChannelCount ||
                    (this.ChannelCount != null &&
                    this.ChannelCount.Equals(input.ChannelCount))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    input.Channels != null &&
                    this.Channels.Equals(input.Channels)
                ) && 
                (
                    this.MembersCount == input.MembersCount ||
                    (this.MembersCount != null &&
                    this.MembersCount.Equals(input.MembersCount))
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
                if (this.ChannelCount != null)
                    hashCode = hashCode * 59 + this.ChannelCount.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.MembersCount != null)
                    hashCode = hashCode * 59 + this.MembersCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

