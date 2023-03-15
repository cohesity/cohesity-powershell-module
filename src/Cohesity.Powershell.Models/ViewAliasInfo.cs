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
    /// View Alias Info is returned as part of list views.
    /// </summary>
    [DataContract]
    public partial class ViewAliasInfo :  IEquatable<ViewAliasInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewAliasInfo" /> class.
        /// </summary>
        /// <param name="aliasName">Alias name..</param>
        /// <param name="clientSubnetWhitelist">List of external client subnet IPs that are allowed to access the share..</param>
        /// <param name="smbConfig">smbConfig.</param>
        /// <param name="viewPath">View path for the alias..</param>
        public ViewAliasInfo(string aliasName = default(string), List<ClusterConfigProtoSubnet> clientSubnetWhitelist = default(List<ClusterConfigProtoSubnet>), AliasSmbConfig smbConfig = default(AliasSmbConfig), string viewPath = default(string))
        {
            this.AliasName = aliasName;
            this.ClientSubnetWhitelist = clientSubnetWhitelist;
            this.ViewPath = viewPath;
            this.AliasName = aliasName;
            this.ClientSubnetWhitelist = clientSubnetWhitelist;
            this.SmbConfig = smbConfig;
            this.ViewPath = viewPath;
        }
        
        /// <summary>
        /// Alias name.
        /// </summary>
        /// <value>Alias name.</value>
        [DataMember(Name="aliasName", EmitDefaultValue=true)]
        public string AliasName { get; set; }

        /// <summary>
        /// List of external client subnet IPs that are allowed to access the share.
        /// </summary>
        /// <value>List of external client subnet IPs that are allowed to access the share.</value>
        [DataMember(Name="clientSubnetWhitelist", EmitDefaultValue=true)]
        public List<ClusterConfigProtoSubnet> ClientSubnetWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets SmbConfig
        /// </summary>
        [DataMember(Name="smbConfig", EmitDefaultValue=false)]
        public AliasSmbConfig SmbConfig { get; set; }

        /// <summary>
        /// View path for the alias.
        /// </summary>
        /// <value>View path for the alias.</value>
        [DataMember(Name="viewPath", EmitDefaultValue=true)]
        public string ViewPath { get; set; }

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
            return this.Equals(input as ViewAliasInfo);
        }

        /// <summary>
        /// Returns true if ViewAliasInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewAliasInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewAliasInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AliasName == input.AliasName ||
                    (this.AliasName != null &&
                    this.AliasName.Equals(input.AliasName))
                ) && 
                (
                    this.ClientSubnetWhitelist == input.ClientSubnetWhitelist ||
                    this.ClientSubnetWhitelist != null &&
                    input.ClientSubnetWhitelist != null &&
                    this.ClientSubnetWhitelist.SequenceEqual(input.ClientSubnetWhitelist)
                ) && 
                (
                    this.SmbConfig == input.SmbConfig ||
                    (this.SmbConfig != null &&
                    this.SmbConfig.Equals(input.SmbConfig))
                ) && 
                (
                    this.ViewPath == input.ViewPath ||
                    (this.ViewPath != null &&
                    this.ViewPath.Equals(input.ViewPath))
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
                if (this.AliasName != null)
                    hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.ClientSubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.ClientSubnetWhitelist.GetHashCode();
                if (this.SmbConfig != null)
                    hashCode = hashCode * 59 + this.SmbConfig.GetHashCode();
                if (this.ViewPath != null)
                    hashCode = hashCode * 59 + this.ViewPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

