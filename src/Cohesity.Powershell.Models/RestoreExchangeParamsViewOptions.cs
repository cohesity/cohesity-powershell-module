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
    /// RestoreExchangeParamsViewOptions
    /// </summary>
    [DataContract]
    public partial class RestoreExchangeParamsViewOptions :  IEquatable<RestoreExchangeParamsViewOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreExchangeParamsViewOptions" /> class.
        /// </summary>
        /// <param name="mountPoint">The path to access the SMB share..</param>
        /// <param name="viewName">View to which the files of an Exchange database have to be cloned..</param>
        /// <param name="whitelistRestoreViewForAll">If set to true then when restore view is cloned then white-list all IPs not just the agent IP..</param>
        public RestoreExchangeParamsViewOptions(string mountPoint = default(string), string viewName = default(string), bool? whitelistRestoreViewForAll = default(bool?))
        {
            this.MountPoint = mountPoint;
            this.ViewName = viewName;
            this.WhitelistRestoreViewForAll = whitelistRestoreViewForAll;
            this.MountPoint = mountPoint;
            this.ViewName = viewName;
            this.WhitelistRestoreViewForAll = whitelistRestoreViewForAll;
        }
        
        /// <summary>
        /// The path to access the SMB share.
        /// </summary>
        /// <value>The path to access the SMB share.</value>
        [DataMember(Name="mountPoint", EmitDefaultValue=true)]
        public string MountPoint { get; set; }

        /// <summary>
        /// View to which the files of an Exchange database have to be cloned.
        /// </summary>
        /// <value>View to which the files of an Exchange database have to be cloned.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// If set to true then when restore view is cloned then white-list all IPs not just the agent IP.
        /// </summary>
        /// <value>If set to true then when restore view is cloned then white-list all IPs not just the agent IP.</value>
        [DataMember(Name="whitelistRestoreViewForAll", EmitDefaultValue=true)]
        public bool? WhitelistRestoreViewForAll { get; set; }

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
            return this.Equals(input as RestoreExchangeParamsViewOptions);
        }

        /// <summary>
        /// Returns true if RestoreExchangeParamsViewOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreExchangeParamsViewOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreExchangeParamsViewOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountPoint == input.MountPoint ||
                    (this.MountPoint != null &&
                    this.MountPoint.Equals(input.MountPoint))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.WhitelistRestoreViewForAll == input.WhitelistRestoreViewForAll ||
                    (this.WhitelistRestoreViewForAll != null &&
                    this.WhitelistRestoreViewForAll.Equals(input.WhitelistRestoreViewForAll))
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
                if (this.MountPoint != null)
                    hashCode = hashCode * 59 + this.MountPoint.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.WhitelistRestoreViewForAll != null)
                    hashCode = hashCode * 59 + this.WhitelistRestoreViewForAll.GetHashCode();
                return hashCode;
            }
        }

    }

}

