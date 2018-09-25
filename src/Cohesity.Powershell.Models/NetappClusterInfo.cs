// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a NetApp Cluster Protection Source.
    /// </summary>
    [DataContract]
    public partial class NetappClusterInfo :  IEquatable<NetappClusterInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappClusterInfo" /> class.
        /// </summary>
        /// <param name="contactInfo">Specifies information about the contact for the NetApp cluster such as a name, phone number, and email address..</param>
        /// <param name="location">Specifies where this NetApp cluster is located. This location identification string is configured by the NetApp system administrator. This field does not contain the NetApp cluster hostname or IP address..</param>
        /// <param name="serialNumber">Specifies the serial number of the NetApp cluster in the format: x-xx-xxxxxx..</param>
        public NetappClusterInfo(string contactInfo = default(string), string location = default(string), string serialNumber = default(string))
        {
            this.ContactInfo = contactInfo;
            this.Location = location;
            this.SerialNumber = serialNumber;
        }
        
        /// <summary>
        /// Specifies information about the contact for the NetApp cluster such as a name, phone number, and email address.
        /// </summary>
        /// <value>Specifies information about the contact for the NetApp cluster such as a name, phone number, and email address.</value>
        [DataMember(Name="contactInfo", EmitDefaultValue=false)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Specifies where this NetApp cluster is located. This location identification string is configured by the NetApp system administrator. This field does not contain the NetApp cluster hostname or IP address.
        /// </summary>
        /// <value>Specifies where this NetApp cluster is located. This location identification string is configured by the NetApp system administrator. This field does not contain the NetApp cluster hostname or IP address.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies the serial number of the NetApp cluster in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NetApp cluster in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

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
            return this.Equals(input as NetappClusterInfo);
        }

        /// <summary>
        /// Returns true if NetappClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetappClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetappClusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactInfo == input.ContactInfo ||
                    (this.ContactInfo != null &&
                    this.ContactInfo.Equals(input.ContactInfo))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
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
                if (this.ContactInfo != null)
                    hashCode = hashCode * 59 + this.ContactInfo.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

