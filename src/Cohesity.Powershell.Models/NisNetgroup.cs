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
    /// Defines an NIS Netgroup.
    /// </summary>
    [DataContract]
    public partial class NisNetgroup :  IEquatable<NisNetgroup>
    {
        /// <summary>
        /// Specifies whether clients from this netgroup can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this netgroup can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NfsAccessEnum
        {
            /// <summary>
            /// Enum KDisabled for value: kDisabled
            /// </summary>
            [EnumMember(Value = "kDisabled")]
            KDisabled = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 3

        }

        /// <summary>
        /// Specifies whether clients from this netgroup can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this netgroup can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [DataMember(Name="nfsAccess", EmitDefaultValue=false)]
        public NfsAccessEnum? NfsAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NisNetgroup" /> class.
        /// </summary>
        /// <param name="description">Description of the netgroup..</param>
        /// <param name="domain">Specifies the domain of the netgroup..</param>
        /// <param name="name">Specifies the name of the netgroup..</param>
        /// <param name="nfsAccess">Specifies whether clients from this netgroup can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;.</param>
        /// <param name="nfsSquash">Specifies the NFS squash type..</param>
        public NisNetgroup(string description = default(string), string domain = default(string), string name = default(string), NfsAccessEnum? nfsAccess = default(NfsAccessEnum?), int? nfsSquash = default(int?))
        {
            this.Description = description;
            this.Domain = domain;
            this.Name = name;
            this.NfsAccess = nfsAccess;
            this.NfsSquash = nfsSquash;
        }
        
        /// <summary>
        /// Description of the netgroup.
        /// </summary>
        /// <value>Description of the netgroup.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the domain of the netgroup.
        /// </summary>
        /// <value>Specifies the domain of the netgroup.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the name of the netgroup.
        /// </summary>
        /// <value>Specifies the name of the netgroup.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the NFS squash type.
        /// </summary>
        /// <value>Specifies the NFS squash type.</value>
        [DataMember(Name="nfsSquash", EmitDefaultValue=false)]
        public int? NfsSquash { get; set; }

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
            return this.Equals(input as NisNetgroup);
        }

        /// <summary>
        /// Returns true if NisNetgroup instances are equal
        /// </summary>
        /// <param name="input">Instance of NisNetgroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NisNetgroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NfsAccess == input.NfsAccess ||
                    (this.NfsAccess != null &&
                    this.NfsAccess.Equals(input.NfsAccess))
                ) && 
                (
                    this.NfsSquash == input.NfsSquash ||
                    (this.NfsSquash != null &&
                    this.NfsSquash.Equals(input.NfsSquash))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NfsAccess != null)
                    hashCode = hashCode * 59 + this.NfsAccess.GetHashCode();
                if (this.NfsSquash != null)
                    hashCode = hashCode * 59 + this.NfsSquash.GetHashCode();
                return hashCode;
            }
        }

    }

}

