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
    /// Specifies the parameters to update a Protection Object.
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionObjectParameters :  IEquatable<UpdateProtectionObjectParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionObjectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateProtectionObjectParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionObjectParameters" /> class.
        /// </summary>
        /// <param name="pauseBackup">Specifies if the protection for the Protection Object is to be paused..</param>
        /// <param name="protectedSourceUid">protectedSourceUid (required).</param>
        /// <param name="rpoPolicyId">Specifies the unique id of the new RPO policy to assign to the object..</param>
        /// <param name="sourceParameters">Specifies the additional special settings for a Protected Source..</param>
        public UpdateProtectionObjectParameters(bool? pauseBackup = default(bool?), UniversalId protectedSourceUid = default(UniversalId), string rpoPolicyId = default(string), List<SourceSpecialParameter> sourceParameters = default(List<SourceSpecialParameter>))
        {
            this.PauseBackup = pauseBackup;
            // to ensure "protectedSourceUid" is required (not null)
            if (protectedSourceUid == null)
            {
                throw new InvalidDataException("protectedSourceUid is a required property for UpdateProtectionObjectParameters and cannot be null");
            }
            else
            {
                this.ProtectedSourceUid = protectedSourceUid;
            }

            this.RpoPolicyId = rpoPolicyId;
            this.SourceParameters = sourceParameters;
            this.PauseBackup = pauseBackup;
            this.RpoPolicyId = rpoPolicyId;
            this.SourceParameters = sourceParameters;
        }
        
        /// <summary>
        /// Specifies if the protection for the Protection Object is to be paused.
        /// </summary>
        /// <value>Specifies if the protection for the Protection Object is to be paused.</value>
        [DataMember(Name="pauseBackup", EmitDefaultValue=true)]
        public bool? PauseBackup { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedSourceUid
        /// </summary>
        [DataMember(Name="protectedSourceUid", EmitDefaultValue=false)]
        public UniversalId ProtectedSourceUid { get; set; }

        /// <summary>
        /// Specifies the unique id of the new RPO policy to assign to the object.
        /// </summary>
        /// <value>Specifies the unique id of the new RPO policy to assign to the object.</value>
        [DataMember(Name="rpoPolicyId", EmitDefaultValue=true)]
        public string RpoPolicyId { get; set; }

        /// <summary>
        /// Specifies the additional special settings for a Protected Source.
        /// </summary>
        /// <value>Specifies the additional special settings for a Protected Source.</value>
        [DataMember(Name="sourceParameters", EmitDefaultValue=true)]
        public List<SourceSpecialParameter> SourceParameters { get; set; }

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
            return this.Equals(input as UpdateProtectionObjectParameters);
        }

        /// <summary>
        /// Returns true if UpdateProtectionObjectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionObjectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionObjectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PauseBackup == input.PauseBackup ||
                    (this.PauseBackup != null &&
                    this.PauseBackup.Equals(input.PauseBackup))
                ) && 
                (
                    this.ProtectedSourceUid == input.ProtectedSourceUid ||
                    (this.ProtectedSourceUid != null &&
                    this.ProtectedSourceUid.Equals(input.ProtectedSourceUid))
                ) && 
                (
                    this.RpoPolicyId == input.RpoPolicyId ||
                    (this.RpoPolicyId != null &&
                    this.RpoPolicyId.Equals(input.RpoPolicyId))
                ) && 
                (
                    this.SourceParameters == input.SourceParameters ||
                    this.SourceParameters != null &&
                    input.SourceParameters != null &&
                    this.SourceParameters.SequenceEqual(input.SourceParameters)
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
                if (this.PauseBackup != null)
                    hashCode = hashCode * 59 + this.PauseBackup.GetHashCode();
                if (this.ProtectedSourceUid != null)
                    hashCode = hashCode * 59 + this.ProtectedSourceUid.GetHashCode();
                if (this.RpoPolicyId != null)
                    hashCode = hashCode * 59 + this.RpoPolicyId.GetHashCode();
                if (this.SourceParameters != null)
                    hashCode = hashCode * 59 + this.SourceParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

