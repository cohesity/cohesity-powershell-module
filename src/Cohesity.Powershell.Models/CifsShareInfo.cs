// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a CIFS share of a NetApp volume.
    /// </summary>
    [DataContract]
    public partial class CifsShareInfo :  IEquatable<CifsShareInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CifsShareInfo" /> class.
        /// </summary>
        /// <param name="acls">Specifies the ACLs for this share..</param>
        /// <param name="name">Specifies the name of the CIFS share. This can be different from the volume name that this share belongs to. A single volume can export multiple CIFS shares, each with unique settings such as permissions..</param>
        /// <param name="path">Specifies the path of this share under the Vserver&#39;s root..</param>
        /// <param name="serverName">Specifies the CIFS server name (such as &#39;NETAPP-01&#39;) specified by the system administrator. This name is searchable within the active directory domain..</param>
        public CifsShareInfo(List<string> acls = default(List<string>), string name = default(string), string path = default(string), string serverName = default(string))
        {
            this.Acls = acls;
            this.Name = name;
            this.Path = path;
            this.ServerName = serverName;
        }
        
        /// <summary>
        /// Specifies the ACLs for this share.
        /// </summary>
        /// <value>Specifies the ACLs for this share.</value>
        [DataMember(Name="acls", EmitDefaultValue=false)]
        public List<string> Acls { get; set; }

        /// <summary>
        /// Specifies the name of the CIFS share. This can be different from the volume name that this share belongs to. A single volume can export multiple CIFS shares, each with unique settings such as permissions.
        /// </summary>
        /// <value>Specifies the name of the CIFS share. This can be different from the volume name that this share belongs to. A single volume can export multiple CIFS shares, each with unique settings such as permissions.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the path of this share under the Vserver&#39;s root.
        /// </summary>
        /// <value>Specifies the path of this share under the Vserver&#39;s root.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the CIFS server name (such as &#39;NETAPP-01&#39;) specified by the system administrator. This name is searchable within the active directory domain.
        /// </summary>
        /// <value>Specifies the CIFS server name (such as &#39;NETAPP-01&#39;) specified by the system administrator. This name is searchable within the active directory domain.</value>
        [DataMember(Name="serverName", EmitDefaultValue=false)]
        public string ServerName { get; set; }

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
            return this.Equals(input as CifsShareInfo);
        }

        /// <summary>
        /// Returns true if CifsShareInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CifsShareInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CifsShareInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Acls == input.Acls ||
                    this.Acls != null &&
                    this.Acls.SequenceEqual(input.Acls)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
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
                if (this.Acls != null)
                    hashCode = hashCode * 59 + this.Acls.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

