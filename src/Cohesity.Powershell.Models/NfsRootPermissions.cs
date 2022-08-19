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
    /// Specifies the config of NFS root permission of a view file system.
    /// </summary>
    [DataContract]
    public partial class NfsRootPermissions :  IEquatable<NfsRootPermissions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsRootPermissions" /> class.
        /// </summary>
        /// <param name="gid">Unix GID for the root of the file system..</param>
        /// <param name="mode">Unix mode bits for the root of the file system..</param>
        /// <param name="uid">Unix UID for the root of the file system..</param>
        public NfsRootPermissions(int? gid = default(int?), int? mode = default(int?), int? uid = default(int?))
        {
            this.Gid = gid;
            this.Mode = mode;
            this.Uid = uid;
            this.Gid = gid;
            this.Mode = mode;
            this.Uid = uid;
        }
        
        /// <summary>
        /// Unix GID for the root of the file system.
        /// </summary>
        /// <value>Unix GID for the root of the file system.</value>
        [DataMember(Name="gid", EmitDefaultValue=true)]
        public int? Gid { get; set; }

        /// <summary>
        /// Unix mode bits for the root of the file system.
        /// </summary>
        /// <value>Unix mode bits for the root of the file system.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public int? Mode { get; set; }

        /// <summary>
        /// Unix UID for the root of the file system.
        /// </summary>
        /// <value>Unix UID for the root of the file system.</value>
        [DataMember(Name="uid", EmitDefaultValue=true)]
        public int? Uid { get; set; }

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
            return this.Equals(input as NfsRootPermissions);
        }

        /// <summary>
        /// Returns true if NfsRootPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsRootPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsRootPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }

    }

}

