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
    /// Specifies additional special settings applicable for a Protection Source of &#39;kVMware&#39; type in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class VmwareSpecialParameters :  IEquatable<VmwareSpecialParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareSpecialParameters" /> class.
        /// </summary>
        /// <param name="applicationParameters">applicationParameters.</param>
        /// <param name="excludedDisks">Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job..</param>
        /// <param name="vmCredentials">Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment..</param>
        public VmwareSpecialParameters(ApplicationParameters applicationParameters = default(ApplicationParameters), List<DiskUnit> excludedDisks = default(List<DiskUnit>), Credentials vmCredentials = default(Credentials))
        {
            this.ExcludedDisks = excludedDisks;
            this.VmCredentials = vmCredentials;
            this.ApplicationParameters = applicationParameters;
            this.ExcludedDisks = excludedDisks;
            this.VmCredentials = vmCredentials;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationParameters
        /// </summary>
        [DataMember(Name="applicationParameters", EmitDefaultValue=false)]
        public ApplicationParameters ApplicationParameters { get; set; }

        /// <summary>
        /// Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.
        /// </summary>
        /// <value>Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.</value>
        [DataMember(Name="excludedDisks", EmitDefaultValue=true)]
        public List<DiskUnit> ExcludedDisks { get; set; }

        /// <summary>
        /// Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment.
        /// </summary>
        /// <value>Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment.</value>
        [DataMember(Name="vmCredentials", EmitDefaultValue=true)]
        public Credentials VmCredentials { get; set; }

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
            return this.Equals(input as VmwareSpecialParameters);
        }

        /// <summary>
        /// Returns true if VmwareSpecialParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareSpecialParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareSpecialParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationParameters == input.ApplicationParameters ||
                    (this.ApplicationParameters != null &&
                    this.ApplicationParameters.Equals(input.ApplicationParameters))
                ) && 
                (
                    this.ExcludedDisks == input.ExcludedDisks ||
                    this.ExcludedDisks != null &&
                    input.ExcludedDisks != null &&
                    this.ExcludedDisks.Equals(input.ExcludedDisks)
                ) && 
                (
                    this.VmCredentials == input.VmCredentials ||
                    (this.VmCredentials != null &&
                    this.VmCredentials.Equals(input.VmCredentials))
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
                if (this.ApplicationParameters != null)
                    hashCode = hashCode * 59 + this.ApplicationParameters.GetHashCode();
                if (this.ExcludedDisks != null)
                    hashCode = hashCode * 59 + this.ExcludedDisks.GetHashCode();
                if (this.VmCredentials != null)
                    hashCode = hashCode * 59 + this.VmCredentials.GetHashCode();
                return hashCode;
            }
        }

    }

}

