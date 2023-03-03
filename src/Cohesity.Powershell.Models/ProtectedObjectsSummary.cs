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
    /// Specifies the statistics of the protected objects on the cluster.
    /// </summary>
    [DataContract]
    public partial class ProtectedObjectsSummary :  IEquatable<ProtectedObjectsSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedObjectsSummary" /> class.
        /// </summary>
        /// <param name="numObjectsProtected">Specifies the total number of protected objects..</param>
        /// <param name="numObjectsUnprotected">Specifies the total number of unprotected objects..</param>
        /// <param name="protectedSizeBytes">Specifies the total size of protected objects in bytes..</param>
        /// <param name="statsByEnv">Specifies the stats of Protected objects by environment..</param>
        /// <param name="unprotectedSizeBytes">Specifies the total size of unprotected objects in bytes..</param>
        public ProtectedObjectsSummary(long? numObjectsProtected = default(long?), long? numObjectsUnprotected = default(long?), long? protectedSizeBytes = default(long?), List<ProtectedObjectsSummaryByEnv> statsByEnv = default(List<ProtectedObjectsSummaryByEnv>), long? unprotectedSizeBytes = default(long?))
        {
            this.NumObjectsProtected = numObjectsProtected;
            this.NumObjectsUnprotected = numObjectsUnprotected;
            this.ProtectedSizeBytes = protectedSizeBytes;
            this.UnprotectedSizeBytes = unprotectedSizeBytes;
            this.NumObjectsProtected = numObjectsProtected;
            this.NumObjectsUnprotected = numObjectsUnprotected;
            this.ProtectedSizeBytes = protectedSizeBytes;
            this.StatsByEnv = statsByEnv;
            this.UnprotectedSizeBytes = unprotectedSizeBytes;
        }
        
        /// <summary>
        /// Specifies the total number of protected objects.
        /// </summary>
        /// <value>Specifies the total number of protected objects.</value>
        [DataMember(Name="numObjectsProtected", EmitDefaultValue=true)]
        public long? NumObjectsProtected { get; set; }

        /// <summary>
        /// Specifies the total number of unprotected objects.
        /// </summary>
        /// <value>Specifies the total number of unprotected objects.</value>
        [DataMember(Name="numObjectsUnprotected", EmitDefaultValue=true)]
        public long? NumObjectsUnprotected { get; set; }

        /// <summary>
        /// Specifies the total size of protected objects in bytes.
        /// </summary>
        /// <value>Specifies the total size of protected objects in bytes.</value>
        [DataMember(Name="protectedSizeBytes", EmitDefaultValue=true)]
        public long? ProtectedSizeBytes { get; set; }

        /// <summary>
        /// Specifies the stats of Protected objects by environment.
        /// </summary>
        /// <value>Specifies the stats of Protected objects by environment.</value>
        [DataMember(Name="statsByEnv", EmitDefaultValue=false)]
        public List<ProtectedObjectsSummaryByEnv> StatsByEnv { get; set; }

        /// <summary>
        /// Specifies the total size of unprotected objects in bytes.
        /// </summary>
        /// <value>Specifies the total size of unprotected objects in bytes.</value>
        [DataMember(Name="unprotectedSizeBytes", EmitDefaultValue=true)]
        public long? UnprotectedSizeBytes { get; set; }

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
            return this.Equals(input as ProtectedObjectsSummary);
        }

        /// <summary>
        /// Returns true if ProtectedObjectsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedObjectsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedObjectsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumObjectsProtected == input.NumObjectsProtected ||
                    (this.NumObjectsProtected != null &&
                    this.NumObjectsProtected.Equals(input.NumObjectsProtected))
                ) && 
                (
                    this.NumObjectsUnprotected == input.NumObjectsUnprotected ||
                    (this.NumObjectsUnprotected != null &&
                    this.NumObjectsUnprotected.Equals(input.NumObjectsUnprotected))
                ) && 
                (
                    this.ProtectedSizeBytes == input.ProtectedSizeBytes ||
                    (this.ProtectedSizeBytes != null &&
                    this.ProtectedSizeBytes.Equals(input.ProtectedSizeBytes))
                ) && 
                (
                    this.StatsByEnv == input.StatsByEnv ||
                    this.StatsByEnv != null &&
                    input.StatsByEnv != null &&
                    this.StatsByEnv.SequenceEqual(input.StatsByEnv)
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
                if (this.NumObjectsProtected != null)
                    hashCode = hashCode * 59 + this.NumObjectsProtected.GetHashCode();
                if (this.NumObjectsUnprotected != null)
                    hashCode = hashCode * 59 + this.NumObjectsUnprotected.GetHashCode();
                if (this.ProtectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.ProtectedSizeBytes.GetHashCode();
                if (this.StatsByEnv != null)
                    hashCode = hashCode * 59 + this.StatsByEnv.GetHashCode();
                if (this.UnprotectedSizeBytes != null)
                    hashCode = hashCode * 59 + this.UnprotectedSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

