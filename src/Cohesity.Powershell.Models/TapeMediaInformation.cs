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
    /// TapeMediaInformation
    /// </summary>
    [DataContract]
    public partial class TapeMediaInformation :  IEquatable<TapeMediaInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TapeMediaInformation" /> class.
        /// </summary>
        /// <param name="barcode">Specifies a unique identifier for the media..</param>
        /// <param name="location">Specifies the location of the offline media as recorded by the backup administrator using media management software..</param>
        /// <param name="online">Specifies a flag that indicates if the media is online or offline. Offline media must be manually loaded into the media library before a recovery can occur..</param>
        public TapeMediaInformation(string barcode = default(string), string location = default(string), bool? online = default(bool?))
        {
            this.Barcode = barcode;
            this.Location = location;
            this.Online = online;
        }
        
        /// <summary>
        /// Specifies a unique identifier for the media.
        /// </summary>
        /// <value>Specifies a unique identifier for the media.</value>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// Specifies the location of the offline media as recorded by the backup administrator using media management software.
        /// </summary>
        /// <value>Specifies the location of the offline media as recorded by the backup administrator using media management software.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies a flag that indicates if the media is online or offline. Offline media must be manually loaded into the media library before a recovery can occur.
        /// </summary>
        /// <value>Specifies a flag that indicates if the media is online or offline. Offline media must be manually loaded into the media library before a recovery can occur.</value>
        [DataMember(Name="online", EmitDefaultValue=false)]
        public bool? Online { get; set; }

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
            return this.Equals(input as TapeMediaInformation);
        }

        /// <summary>
        /// Returns true if TapeMediaInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of TapeMediaInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TapeMediaInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
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
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

