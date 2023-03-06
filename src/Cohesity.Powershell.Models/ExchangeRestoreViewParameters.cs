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
    /// ExchangeRestoreViewParameters
    /// </summary>
    [DataContract]
    public partial class ExchangeRestoreViewParameters :  IEquatable<ExchangeRestoreViewParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRestoreViewParameters" /> class.
        /// </summary>
        /// <param name="endpoint">Specifies whether we should allow all the IP addresses to be part of the allowlist. If this parameter is set to false, then only the machine on which the view is mounted will be allowed..</param>
        /// <param name="mountPoint">Specifies the path of the SMB share..</param>
        /// <param name="viewName">Specifies the view to which the files of an Exchange database has to be cloned..</param>
        public ExchangeRestoreViewParameters(bool? endpoint = default(bool?), string mountPoint = default(string), string viewName = default(string))
        {
            this.Endpoint = endpoint;
            this.MountPoint = mountPoint;
            this.ViewName = viewName;
            this.Endpoint = endpoint;
            this.MountPoint = mountPoint;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies whether we should allow all the IP addresses to be part of the allowlist. If this parameter is set to false, then only the machine on which the view is mounted will be allowed.
        /// </summary>
        /// <value>Specifies whether we should allow all the IP addresses to be part of the allowlist. If this parameter is set to false, then only the machine on which the view is mounted will be allowed.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public bool? Endpoint { get; set; }

        /// <summary>
        /// Specifies the path of the SMB share.
        /// </summary>
        /// <value>Specifies the path of the SMB share.</value>
        [DataMember(Name="mountPoint", EmitDefaultValue=true)]
        public string MountPoint { get; set; }

        /// <summary>
        /// Specifies the view to which the files of an Exchange database has to be cloned.
        /// </summary>
        /// <value>Specifies the view to which the files of an Exchange database has to be cloned.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as ExchangeRestoreViewParameters);
        }

        /// <summary>
        /// Returns true if ExchangeRestoreViewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRestoreViewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRestoreViewParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.MountPoint == input.MountPoint ||
                    (this.MountPoint != null &&
                    this.MountPoint.Equals(input.MountPoint))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.MountPoint != null)
                    hashCode = hashCode * 59 + this.MountPoint.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

