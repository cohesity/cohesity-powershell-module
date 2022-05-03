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
    /// Message to capture any additonal backup params for OneDrive within the Office365 environment.
    /// </summary>
    [DataContract]
    public partial class OneDriveBackupEnvParams :  IEquatable<OneDriveBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveBackupEnvParams" /> class.
        /// </summary>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="shouldBackupOnedrive">Specifies whether the OneDrive(s) for all the Office365 Users present in the protection job should be backed up..</param>
        public OneDriveBackupEnvParams(FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), bool? shouldBackupOnedrive = default(bool?))
        {
            this.FilteringPolicy = filteringPolicy;
            this.ShouldBackupOnedrive = shouldBackupOnedrive;
        }
        
        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// Specifies whether the OneDrive(s) for all the Office365 Users present in the protection job should be backed up.
        /// </summary>
        /// <value>Specifies whether the OneDrive(s) for all the Office365 Users present in the protection job should be backed up.</value>
        [DataMember(Name="shouldBackupOnedrive", EmitDefaultValue=false)]
        public bool? ShouldBackupOnedrive { get; set; }

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
            return this.Equals(input as OneDriveBackupEnvParams);
        }

        /// <summary>
        /// Returns true if OneDriveBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OneDriveBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneDriveBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.ShouldBackupOnedrive == input.ShouldBackupOnedrive ||
                    (this.ShouldBackupOnedrive != null &&
                    this.ShouldBackupOnedrive.Equals(input.ShouldBackupOnedrive))
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
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.ShouldBackupOnedrive != null)
                    hashCode = hashCode * 59 + this.ShouldBackupOnedrive.GetHashCode();
                return hashCode;
            }
        }

    }

}

