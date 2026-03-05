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
    /// Message containing params for downloading chat/post messages for user/teams/channel.
    /// </summary>
    [DataContract]
    public partial class DownloadChatsParams :  IEquatable<DownloadChatsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadChatsParams" /> class.
        /// </summary>
        /// <param name="channelIdsVec">List of channel IDs whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded..</param>
        /// <param name="channelVec">Details of channels whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded..</param>
        /// <param name="downloadFileType">File type which will be downloaded containing chat messages..</param>
        /// <param name="htmlTemplate">HTML template for the downloaded chats. IRIS will populate this by reading the template locally..</param>
        public DownloadChatsParams(List<string> channelIdsVec = default(List<string>), List<DownloadChatsParamsChannel> channelVec = default(List<DownloadChatsParamsChannel>), int? downloadFileType = default(int?), string htmlTemplate = default(string))
        {
            this.ChannelIdsVec = channelIdsVec;
            this.ChannelVec = channelVec;
            this.DownloadFileType = downloadFileType;
            this.HtmlTemplate = htmlTemplate;
            this.ChannelIdsVec = channelIdsVec;
            this.ChannelVec = channelVec;
            this.DownloadFileType = downloadFileType;
            this.HtmlTemplate = htmlTemplate;
        }
        
        /// <summary>
        /// List of channel IDs whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded.
        /// </summary>
        /// <value>List of channel IDs whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded.</value>
        [DataMember(Name="channelIdsVec", EmitDefaultValue=true)]
        public List<string> ChannelIdsVec { get; set; }

        /// <summary>
        /// Details of channels whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded.
        /// </summary>
        /// <value>Details of channels whose chats needs to be downloaded. This will only be populated when specific channel&#39;s posts needs to be downloaded. If this is not populated full teams posts will be downloaded.</value>
        [DataMember(Name="channelVec", EmitDefaultValue=true)]
        public List<DownloadChatsParamsChannel> ChannelVec { get; set; }

        /// <summary>
        /// File type which will be downloaded containing chat messages.
        /// </summary>
        /// <value>File type which will be downloaded containing chat messages.</value>
        [DataMember(Name="downloadFileType", EmitDefaultValue=true)]
        public int? DownloadFileType { get; set; }

        /// <summary>
        /// HTML template for the downloaded chats. IRIS will populate this by reading the template locally.
        /// </summary>
        /// <value>HTML template for the downloaded chats. IRIS will populate this by reading the template locally.</value>
        [DataMember(Name="htmlTemplate", EmitDefaultValue=true)]
        public string HtmlTemplate { get; set; }

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
            return this.Equals(input as DownloadChatsParams);
        }

        /// <summary>
        /// Returns true if DownloadChatsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadChatsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadChatsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelIdsVec == input.ChannelIdsVec ||
                    this.ChannelIdsVec != null &&
                    input.ChannelIdsVec != null &&
                    this.ChannelIdsVec.SequenceEqual(input.ChannelIdsVec)
                ) && 
                (
                    this.ChannelVec == input.ChannelVec ||
                    this.ChannelVec != null &&
                    input.ChannelVec != null &&
                    this.ChannelVec.SequenceEqual(input.ChannelVec)
                ) && 
                (
                    this.DownloadFileType == input.DownloadFileType ||
                    (this.DownloadFileType != null &&
                    this.DownloadFileType.Equals(input.DownloadFileType))
                ) && 
                (
                    this.HtmlTemplate == input.HtmlTemplate ||
                    (this.HtmlTemplate != null &&
                    this.HtmlTemplate.Equals(input.HtmlTemplate))
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
                if (this.ChannelIdsVec != null)
                    hashCode = hashCode * 59 + this.ChannelIdsVec.GetHashCode();
                if (this.ChannelVec != null)
                    hashCode = hashCode * 59 + this.ChannelVec.GetHashCode();
                if (this.DownloadFileType != null)
                    hashCode = hashCode * 59 + this.DownloadFileType.GetHashCode();
                if (this.HtmlTemplate != null)
                    hashCode = hashCode * 59 + this.HtmlTemplate.GetHashCode();
                return hashCode;
            }
        }

    }

}

