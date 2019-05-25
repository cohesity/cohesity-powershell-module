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
    /// Represents the security identifier that uniquely defines a security principal. SIDs are associated with users and groups. Reference: https://msdn.microsoft.com/en-us/library/aa379597.aspx
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoSID :  IEquatable<ClusterConfigProtoSID>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoSID" /> class.
        /// </summary>
        /// <param name="identifierAuthority">The authority under which the SID was created. This is always 6 bytes long..</param>
        /// <param name="revisionLevel">The revision level of the SID..</param>
        /// <param name="subAuthority">List of ids relative to the identifier_authority that uniquely identify a principal. The last entry in this list is the RID, which uniquely identifies the principal within a domain..</param>
        public ClusterConfigProtoSID(List<int> identifierAuthority = default(List<int>), int? revisionLevel = default(int?), List<int> subAuthority = default(List<int>))
        {
            this.IdentifierAuthority = identifierAuthority;
            this.RevisionLevel = revisionLevel;
            this.SubAuthority = subAuthority;
            this.IdentifierAuthority = identifierAuthority;
            this.RevisionLevel = revisionLevel;
            this.SubAuthority = subAuthority;
        }
        
        /// <summary>
        /// The authority under which the SID was created. This is always 6 bytes long.
        /// </summary>
        /// <value>The authority under which the SID was created. This is always 6 bytes long.</value>
        [DataMember(Name="identifierAuthority", EmitDefaultValue=true)]
        public List<int> IdentifierAuthority { get; set; }

        /// <summary>
        /// The revision level of the SID.
        /// </summary>
        /// <value>The revision level of the SID.</value>
        [DataMember(Name="revisionLevel", EmitDefaultValue=true)]
        public int? RevisionLevel { get; set; }

        /// <summary>
        /// List of ids relative to the identifier_authority that uniquely identify a principal. The last entry in this list is the RID, which uniquely identifies the principal within a domain.
        /// </summary>
        /// <value>List of ids relative to the identifier_authority that uniquely identify a principal. The last entry in this list is the RID, which uniquely identifies the principal within a domain.</value>
        [DataMember(Name="subAuthority", EmitDefaultValue=true)]
        public List<int> SubAuthority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterConfigProtoSID {\n");
            sb.Append("  IdentifierAuthority: ").Append(IdentifierAuthority).Append("\n");
            sb.Append("  RevisionLevel: ").Append(RevisionLevel).Append("\n");
            sb.Append("  SubAuthority: ").Append(SubAuthority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as ClusterConfigProtoSID);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoSID instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoSID to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoSID input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierAuthority == input.IdentifierAuthority ||
                    this.IdentifierAuthority != null &&
                    input.IdentifierAuthority != null &&
                    this.IdentifierAuthority.SequenceEqual(input.IdentifierAuthority)
                ) && 
                (
                    this.RevisionLevel == input.RevisionLevel ||
                    (this.RevisionLevel != null &&
                    this.RevisionLevel.Equals(input.RevisionLevel))
                ) && 
                (
                    this.SubAuthority == input.SubAuthority ||
                    this.SubAuthority != null &&
                    input.SubAuthority != null &&
                    this.SubAuthority.SequenceEqual(input.SubAuthority)
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
                if (this.IdentifierAuthority != null)
                    hashCode = hashCode * 59 + this.IdentifierAuthority.GetHashCode();
                if (this.RevisionLevel != null)
                    hashCode = hashCode * 59 + this.RevisionLevel.GetHashCode();
                if (this.SubAuthority != null)
                    hashCode = hashCode * 59 + this.SubAuthority.GetHashCode();
                return hashCode;
            }
        }

    }

}
