// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// ProtectedObjectsTile
    /// </summary>
    [DataContract]
    public partial class ProtectedObjectsTile :  IEquatable<ProtectedObjectsTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedObjectsTile" /> class.
        /// </summary>
        /// <param name="objectsProtected">objectsProtected.</param>
        /// <param name="protectedCount">Number of Protected Objects..</param>
        /// <param name="protectedSizeBytes">Size of Protected Objects..</param>
        /// <param name="unprotectedCount">Number of Unprotected Objects..</param>
        /// <param name="unprotectedSizeBytes">Size of Unprotected Objects..</param>
        public ProtectedObjectsTile(List<ProtectedObjectsByEnv> objectsProtected = default(List<ProtectedObjectsByEnv>), int? protectedCount = default(int?), long? protectedSizeBytes = default(long?), int? unprotectedCount = default(int?), long? unprotectedSizeBytes = default(long?))
        {
            this.ObjectsProtected = objectsProtected;
            this.ProtectedCount = protectedCount;
            this.ProtectedSizeBytes = protectedSizeBytes;
            this.UnprotectedCount = unprotectedCount;
            this.UnprotectedSizeBytes = unprotectedSizeBytes;
        }
        
        /// <summary>
        /// Gets or Sets ObjectsProtected
        /// </summary>
        [DataMember(Name="objectsProtected", EmitDefaultValue=false)]
        public List<ProtectedObjectsByEnv> ObjectsProtected { get; set; }

        /// <summary>
        /// Number of Protected Objects.
        /// </summary>
        /// <value>Number of Protected Objects.</value>
        [DataMember(Name="protectedCount", EmitDefaultValue=false)]
        public int? ProtectedCount { get; set; }

        /// <summary>
        /// Size of Protected Objects.
        /// </summary>
        /// <value>Size of Protected Objects.</value>
        [DataMember(Name="protectedSizeBytes", EmitDefaultValue=false)]
        public long? ProtectedSizeBytes { get; set; }

        /// <summary>
        /// Number of Unprotected Objects.
        /// </summary>
        /// <value>Number of Unprotected Objects.</value>
        [DataMember(Name="unprotectedCount", EmitDefaultValue=false)]
        public int? UnprotectedCount { get; set; }

        /// <summary>
        /// Size of Unprotected Objects.
        /// </summary>
        /// <value>Size of Unprotected Objects.</value>
        [DataMember(Name="unprotectedSizeBytes", EmitDefaultValue=false)]
        public long? UnprotectedSizeBytes { get; set; }

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
            return this.Equals(input as ProtectedObjectsTile);
        }

        /// <summary>
        /// Returns true if ProtectedObjectsTile instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedObjectsTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedObjectsTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectsProtected == input.ObjectsProtected ||
                    this.ObjectsProtected != null &&
                    this.ObjectsProtected.SequenceEqual(input.ObjectsProtected)
                ) && 
                (
                    this.ProtectedCount == input.ProtectedCount ||
                    (this.ProtectedCount != null &&
                    this.ProtectedCount.Equals(input.ProtectedCount))
                ) && 
                (
                    this.ProtectedSizeBytes == input.ProtectedSizeBytes ||
                    (this.ProtectedSizeBytes != null &&
                    this.ProtectedSizeBytes.Equals(input.ProtectedSizeBytes))
                ) && 
                (
                    this.UnprotectedCount == input.UnprotectedCount ||
                    (this.UnprotectedCount != null &&
                    this.UnprotectedCount.Equals(input.UnprotectedCount))
                ) && 
                (
                    this.UnprotectedSizeBytes == input.UnprotectedSizeBytes ||
                    (this.UnprotectedSizeBytes != null &&
                    this.UnprotectedSizeBytes.Equals(input.UnprotectedSizeBytes))
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
                if (this.ObjectsProtected != null)
                    hashCode = hashCode * 59 + this.ObjectsProtected.GetHashCode();
                if (this.ProtectedCount != null)
                    hashCode = hashCode * 59 + this.ProtectedCount.GetHashCode();
                if (this.ProtectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.ProtectedSizeBytes.GetHashCode();
                if (this.UnprotectedCount != null)
                    hashCode = hashCode * 59 + this.UnprotectedCount.GetHashCode();
                if (this.UnprotectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.UnprotectedSizeBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

