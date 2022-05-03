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
    /// Specifies Icap server connection status response.
    /// </summary>
    [DataContract]
    public partial class IcapConnectionStatusResponse :  IEquatable<IcapConnectionStatusResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IcapConnectionStatusResponse" /> class.
        /// </summary>
        /// <param name="failedConnectionStatus">Specifies the failed connection status of Icap servers..</param>
        /// <param name="succeededConnectionStatus">Specifies the success connection status of Icap servers..</param>
        public IcapConnectionStatusResponse(List<string> failedConnectionStatus = default(List<string>), List<string> succeededConnectionStatus = default(List<string>))
        {
            this.FailedConnectionStatus = failedConnectionStatus;
            this.SucceededConnectionStatus = succeededConnectionStatus;
        }
        
        /// <summary>
        /// Specifies the failed connection status of Icap servers.
        /// </summary>
        /// <value>Specifies the failed connection status of Icap servers.</value>
        [DataMember(Name="failedConnectionStatus", EmitDefaultValue=false)]
        public List<string> FailedConnectionStatus { get; set; }

        /// <summary>
        /// Specifies the success connection status of Icap servers.
        /// </summary>
        /// <value>Specifies the success connection status of Icap servers.</value>
        [DataMember(Name="succeededConnectionStatus", EmitDefaultValue=false)]
        public List<string> SucceededConnectionStatus { get; set; }

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
            return this.Equals(input as IcapConnectionStatusResponse);
        }

        /// <summary>
        /// Returns true if IcapConnectionStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IcapConnectionStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IcapConnectionStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailedConnectionStatus == input.FailedConnectionStatus ||
                    this.FailedConnectionStatus != null &&
                    this.FailedConnectionStatus.Equals(input.FailedConnectionStatus)
                ) && 
                (
                    this.SucceededConnectionStatus == input.SucceededConnectionStatus ||
                    this.SucceededConnectionStatus != null &&
                    this.SucceededConnectionStatus.Equals(input.SucceededConnectionStatus)
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
                if (this.FailedConnectionStatus != null)
                    hashCode = hashCode * 59 + this.FailedConnectionStatus.GetHashCode();
                if (this.SucceededConnectionStatus != null)
                    hashCode = hashCode * 59 + this.SucceededConnectionStatus.GetHashCode();
                return hashCode;
            }
        }

    }

}

