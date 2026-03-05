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
    /// ViewProtocol
    /// </summary>
    [DataContract]
    public partial class ViewProtocol :  IEquatable<ViewProtocol>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProtocol" /> class.
        /// </summary>
        /// <param name="mode">Mode of protocol access. &#39;ReadOnly&#39; &#39;ReadWrite&#39; Enum: [ReadOnly ReadWrite].</param>
        /// <param name="type">Type of protocol. Specifies the supported Protocols for the View. &#39;NFS&#39; enables protocol access to NFS v3. &#39;NFS4&#39; enables protocol access to NFS v4.1. &#39;SMB&#39; enables protocol access to SMB. &#39;S3&#39; enables protocol access to S3. &#39;Swift&#39; enables protocol access to Swift. Enum: [NFS NFS4 SMB S3 Swift].</param>
        public ViewProtocol(string mode = default(string), string type = default(string))
        {
            this.Mode = mode;
            this.Type = type;
            this.Mode = mode;
            this.Type = type;
        }
        
        /// <summary>
        /// Mode of protocol access. &#39;ReadOnly&#39; &#39;ReadWrite&#39; Enum: [ReadOnly ReadWrite]
        /// </summary>
        /// <value>Mode of protocol access. &#39;ReadOnly&#39; &#39;ReadWrite&#39; Enum: [ReadOnly ReadWrite]</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public string Mode { get; set; }

        /// <summary>
        /// Type of protocol. Specifies the supported Protocols for the View. &#39;NFS&#39; enables protocol access to NFS v3. &#39;NFS4&#39; enables protocol access to NFS v4.1. &#39;SMB&#39; enables protocol access to SMB. &#39;S3&#39; enables protocol access to S3. &#39;Swift&#39; enables protocol access to Swift. Enum: [NFS NFS4 SMB S3 Swift]
        /// </summary>
        /// <value>Type of protocol. Specifies the supported Protocols for the View. &#39;NFS&#39; enables protocol access to NFS v3. &#39;NFS4&#39; enables protocol access to NFS v4.1. &#39;SMB&#39; enables protocol access to SMB. &#39;S3&#39; enables protocol access to S3. &#39;Swift&#39; enables protocol access to Swift. Enum: [NFS NFS4 SMB S3 Swift]</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

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
            return this.Equals(input as ViewProtocol);
        }

        /// <summary>
        /// Returns true if ViewProtocol instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProtocol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProtocol input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

