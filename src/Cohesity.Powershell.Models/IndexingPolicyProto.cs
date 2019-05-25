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
    /// Proto to encapsulate file level indexing policy for VMs in a backup job.
    /// </summary>
    [DataContract]
    public partial class IndexingPolicyProto :  IEquatable<IndexingPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexingPolicyProto" /> class.
        /// </summary>
        /// <param name="allowPrefixes">List of directory prefixes to allow for indexing..</param>
        /// <param name="denyPrefixes">List of directory prefixes to filter out..</param>
        /// <param name="disableIndexing">If this field is set all the files in the VM will be filtered..</param>
        public IndexingPolicyProto(List<string> allowPrefixes = default(List<string>), List<string> denyPrefixes = default(List<string>), bool? disableIndexing = default(bool?))
        {
            this.AllowPrefixes = allowPrefixes;
            this.DenyPrefixes = denyPrefixes;
            this.DisableIndexing = disableIndexing;
            this.AllowPrefixes = allowPrefixes;
            this.DenyPrefixes = denyPrefixes;
            this.DisableIndexing = disableIndexing;
        }
        
        /// <summary>
        /// List of directory prefixes to allow for indexing.
        /// </summary>
        /// <value>List of directory prefixes to allow for indexing.</value>
        [DataMember(Name="allowPrefixes", EmitDefaultValue=true)]
        public List<string> AllowPrefixes { get; set; }

        /// <summary>
        /// List of directory prefixes to filter out.
        /// </summary>
        /// <value>List of directory prefixes to filter out.</value>
        [DataMember(Name="denyPrefixes", EmitDefaultValue=true)]
        public List<string> DenyPrefixes { get; set; }

        /// <summary>
        /// If this field is set all the files in the VM will be filtered.
        /// </summary>
        /// <value>If this field is set all the files in the VM will be filtered.</value>
        [DataMember(Name="disableIndexing", EmitDefaultValue=true)]
        public bool? DisableIndexing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexingPolicyProto {\n");
            sb.Append("  AllowPrefixes: ").Append(AllowPrefixes).Append("\n");
            sb.Append("  DenyPrefixes: ").Append(DenyPrefixes).Append("\n");
            sb.Append("  DisableIndexing: ").Append(DisableIndexing).Append("\n");
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
            return this.Equals(input as IndexingPolicyProto);
        }

        /// <summary>
        /// Returns true if IndexingPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexingPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexingPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowPrefixes == input.AllowPrefixes ||
                    this.AllowPrefixes != null &&
                    input.AllowPrefixes != null &&
                    this.AllowPrefixes.SequenceEqual(input.AllowPrefixes)
                ) && 
                (
                    this.DenyPrefixes == input.DenyPrefixes ||
                    this.DenyPrefixes != null &&
                    input.DenyPrefixes != null &&
                    this.DenyPrefixes.SequenceEqual(input.DenyPrefixes)
                ) && 
                (
                    this.DisableIndexing == input.DisableIndexing ||
                    (this.DisableIndexing != null &&
                    this.DisableIndexing.Equals(input.DisableIndexing))
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
                if (this.AllowPrefixes != null)
                    hashCode = hashCode * 59 + this.AllowPrefixes.GetHashCode();
                if (this.DenyPrefixes != null)
                    hashCode = hashCode * 59 + this.DenyPrefixes.GetHashCode();
                if (this.DisableIndexing != null)
                    hashCode = hashCode * 59 + this.DisableIndexing.GetHashCode();
                return hashCode;
            }
        }

    }

}
