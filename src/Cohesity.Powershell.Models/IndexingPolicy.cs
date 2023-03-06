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
    /// Specifies settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered. This also specifies inclusion and exclusion rules that determine the directories to index.
    /// </summary>
    [DataContract]
    public partial class IndexingPolicy :  IEquatable<IndexingPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexingPolicy" /> class.
        /// </summary>
        /// <param name="allowPrefixes">Array of Indexed Directories.  Specifies a list of directories to index..</param>
        /// <param name="denyPrefixes">Array of Excluded Directories.  Specifies a list of directories to exclude from indexing..</param>
        /// <param name="disableIndexing">Specifies if the files found in an Object (such as a VM) should be indexed. If false (the default), files are indexed..</param>
        public IndexingPolicy(List<string> allowPrefixes = default(List<string>), List<string> denyPrefixes = default(List<string>), bool? disableIndexing = default(bool?))
        {
            this.AllowPrefixes = allowPrefixes;
            this.DenyPrefixes = denyPrefixes;
            this.DisableIndexing = disableIndexing;
            this.AllowPrefixes = allowPrefixes;
            this.DenyPrefixes = denyPrefixes;
            this.DisableIndexing = disableIndexing;
        }
        
        /// <summary>
        /// Array of Indexed Directories.  Specifies a list of directories to index.
        /// </summary>
        /// <value>Array of Indexed Directories.  Specifies a list of directories to index.</value>
        [DataMember(Name="allowPrefixes", EmitDefaultValue=true)]
        public List<string> AllowPrefixes { get; set; }

        /// <summary>
        /// Array of Excluded Directories.  Specifies a list of directories to exclude from indexing.
        /// </summary>
        /// <value>Array of Excluded Directories.  Specifies a list of directories to exclude from indexing.</value>
        [DataMember(Name="denyPrefixes", EmitDefaultValue=true)]
        public List<string> DenyPrefixes { get; set; }

        /// <summary>
        /// Specifies if the files found in an Object (such as a VM) should be indexed. If false (the default), files are indexed.
        /// </summary>
        /// <value>Specifies if the files found in an Object (such as a VM) should be indexed. If false (the default), files are indexed.</value>
        [DataMember(Name="disableIndexing", EmitDefaultValue=true)]
        public bool? DisableIndexing { get; set; }

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
            return this.Equals(input as IndexingPolicy);
        }

        /// <summary>
        /// Returns true if IndexingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexingPolicy input)
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

