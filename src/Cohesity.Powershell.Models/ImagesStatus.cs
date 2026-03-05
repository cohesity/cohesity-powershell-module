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
    /// ImagesStatus
    /// </summary>
    [DataContract]
    public partial class ImagesStatus :  IEquatable<ImagesStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesStatus" /> class.
        /// </summary>
        /// <param name="appUid">AppUid.</param>
        /// <param name="imageName">Name of Image.</param>
        /// <param name="imageTags">Image tags available in registry.</param>
        /// <param name="loadedImages">Loaded Images.</param>
        /// <param name="status">Image status.</param>
        public ImagesStatus(long? appUid = default(long?), string imageName = default(string), List<string> imageTags = default(List<string>), List<string> loadedImages = default(List<string>), string status = default(string))
        {
            this.AppUid = appUid;
            this.ImageName = imageName;
            this.ImageTags = imageTags;
            this.LoadedImages = loadedImages;
            this.Status = status;
            this.AppUid = appUid;
            this.ImageName = imageName;
            this.ImageTags = imageTags;
            this.LoadedImages = loadedImages;
            this.Status = status;
        }
        
        /// <summary>
        /// AppUid
        /// </summary>
        /// <value>AppUid</value>
        [DataMember(Name="appUid", EmitDefaultValue=true)]
        public long? AppUid { get; set; }

        /// <summary>
        /// Name of Image
        /// </summary>
        /// <value>Name of Image</value>
        [DataMember(Name="imageName", EmitDefaultValue=true)]
        public string ImageName { get; set; }

        /// <summary>
        /// Image tags available in registry
        /// </summary>
        /// <value>Image tags available in registry</value>
        [DataMember(Name="imageTags", EmitDefaultValue=true)]
        public List<string> ImageTags { get; set; }

        /// <summary>
        /// Loaded Images
        /// </summary>
        /// <value>Loaded Images</value>
        [DataMember(Name="loadedImages", EmitDefaultValue=true)]
        public List<string> LoadedImages { get; set; }

        /// <summary>
        /// Image status
        /// </summary>
        /// <value>Image status</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

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
            return this.Equals(input as ImagesStatus);
        }

        /// <summary>
        /// Returns true if ImagesStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ImagesStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImagesStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppUid == input.AppUid ||
                    (this.AppUid != null &&
                    this.AppUid.Equals(input.AppUid))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ImageTags == input.ImageTags ||
                    this.ImageTags != null &&
                    input.ImageTags != null &&
                    this.ImageTags.SequenceEqual(input.ImageTags)
                ) && 
                (
                    this.LoadedImages == input.LoadedImages ||
                    this.LoadedImages != null &&
                    input.LoadedImages != null &&
                    this.LoadedImages.SequenceEqual(input.LoadedImages)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AppUid != null)
                    hashCode = hashCode * 59 + this.AppUid.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageTags != null)
                    hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                if (this.LoadedImages != null)
                    hashCode = hashCode * 59 + this.LoadedImages.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

