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
    /// DownloadChatsParamsChannel
    /// </summary>
    [DataContract]
    public partial class DownloadChatsParamsChannel :  IEquatable<DownloadChatsParamsChannel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadChatsParamsChannel" /> class.
        /// </summary>
        /// <param name="id">Channel ID of a channel whose chats needs to be downloaded..</param>
        /// <param name="name">Channel name of a channel whose chats needs to be downloaded..</param>
        public DownloadChatsParamsChannel(string id = default(string), string name = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Channel ID of a channel whose chats needs to be downloaded.
        /// </summary>
        /// <value>Channel ID of a channel whose chats needs to be downloaded.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Channel name of a channel whose chats needs to be downloaded.
        /// </summary>
        /// <value>Channel name of a channel whose chats needs to be downloaded.</value>
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
            return this.Equals(input as DownloadChatsParamsChannel);
        }

        /// <summary>
        /// Returns true if DownloadChatsParamsChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadChatsParamsChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadChatsParamsChannel input)
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
                return hashCode;
            }
        }

    }

}

