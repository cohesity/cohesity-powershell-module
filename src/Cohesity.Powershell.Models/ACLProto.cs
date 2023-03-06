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
    /// Protobuf that describes the access control list (ACL) permissions for a bucket or for an object.
    /// </summary>
    [DataContract]
    public partial class ACLProto :  IEquatable<ACLProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACLProto" /> class.
        /// </summary>
        /// <param name="commonAcl">commonAcl.</param>
        /// <param name="grantVec">grantVec.</param>
        /// <param name="keystoneAcl">keystoneAcl.</param>
        /// <param name="swiftReadAcl">Swift ACL strings..</param>
        /// <param name="swiftWriteAcl">swiftWriteAcl.</param>
        public ACLProto(CommonACLProto commonAcl = default(CommonACLProto), List<ACLProtoGrant> grantVec = default(List<ACLProtoGrant>), KeystoneACLProto keystoneAcl = default(KeystoneACLProto), string swiftReadAcl = default(string), string swiftWriteAcl = default(string))
        {
            this.GrantVec = grantVec;
            this.SwiftReadAcl = swiftReadAcl;
            this.SwiftWriteAcl = swiftWriteAcl;
            this.CommonAcl = commonAcl;
            this.GrantVec = grantVec;
            this.KeystoneAcl = keystoneAcl;
            this.SwiftReadAcl = swiftReadAcl;
            this.SwiftWriteAcl = swiftWriteAcl;
        }
        
        /// <summary>
        /// Gets or Sets CommonAcl
        /// </summary>
        [DataMember(Name="commonAcl", EmitDefaultValue=false)]
        public CommonACLProto CommonAcl { get; set; }

        /// <summary>
        /// Gets or Sets GrantVec
        /// </summary>
        [DataMember(Name="grantVec", EmitDefaultValue=true)]
        public List<ACLProtoGrant> GrantVec { get; set; }

        /// <summary>
        /// Gets or Sets KeystoneAcl
        /// </summary>
        [DataMember(Name="keystoneAcl", EmitDefaultValue=false)]
        public KeystoneACLProto KeystoneAcl { get; set; }

        /// <summary>
        /// Swift ACL strings.
        /// </summary>
        /// <value>Swift ACL strings.</value>
        [DataMember(Name="swiftReadAcl", EmitDefaultValue=true)]
        public string SwiftReadAcl { get; set; }

        /// <summary>
        /// Gets or Sets SwiftWriteAcl
        /// </summary>
        [DataMember(Name="swiftWriteAcl", EmitDefaultValue=true)]
        public string SwiftWriteAcl { get; set; }

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
            return this.Equals(input as ACLProto);
        }

        /// <summary>
        /// Returns true if ACLProto instances are equal
        /// </summary>
        /// <param name="input">Instance of ACLProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ACLProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommonAcl == input.CommonAcl ||
                    (this.CommonAcl != null &&
                    this.CommonAcl.Equals(input.CommonAcl))
                ) && 
                (
                    this.GrantVec == input.GrantVec ||
                    this.GrantVec != null &&
                    input.GrantVec != null &&
                    this.GrantVec.SequenceEqual(input.GrantVec)
                ) && 
                (
                    this.KeystoneAcl == input.KeystoneAcl ||
                    (this.KeystoneAcl != null &&
                    this.KeystoneAcl.Equals(input.KeystoneAcl))
                ) && 
                (
                    this.SwiftReadAcl == input.SwiftReadAcl ||
                    (this.SwiftReadAcl != null &&
                    this.SwiftReadAcl.Equals(input.SwiftReadAcl))
                ) && 
                (
                    this.SwiftWriteAcl == input.SwiftWriteAcl ||
                    (this.SwiftWriteAcl != null &&
                    this.SwiftWriteAcl.Equals(input.SwiftWriteAcl))
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
                if (this.CommonAcl != null)
                    hashCode = hashCode * 59 + this.CommonAcl.GetHashCode();
                if (this.GrantVec != null)
                    hashCode = hashCode * 59 + this.GrantVec.GetHashCode();
                if (this.KeystoneAcl != null)
                    hashCode = hashCode * 59 + this.KeystoneAcl.GetHashCode();
                if (this.SwiftReadAcl != null)
                    hashCode = hashCode * 59 + this.SwiftReadAcl.GetHashCode();
                if (this.SwiftWriteAcl != null)
                    hashCode = hashCode * 59 + this.SwiftWriteAcl.GetHashCode();
                return hashCode;
            }
        }

    }

}

