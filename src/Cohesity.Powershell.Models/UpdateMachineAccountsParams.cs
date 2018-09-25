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
    /// Specifies the parameters required to update the machine accounts of an active directory.
    /// </summary>
    [DataContract]
    public partial class UpdateMachineAccountsParams :  IEquatable<UpdateMachineAccountsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMachineAccountsParams" /> class.
        /// </summary>
        /// <param name="machineAccounts">Specifies an array of computer names used to identify the Cohesity Cluster on the domain..</param>
        /// <param name="overwriteExistingAccounts">Specifies whether the specified machine accounts should overwrite the existing machine accounts in this domain..</param>
        /// <param name="password">Specifies the password for the specified userName..</param>
        /// <param name="userName">Specifies a userName that has administrative privileges in the domain..</param>
        public UpdateMachineAccountsParams(List<string> machineAccounts = default(List<string>), bool? overwriteExistingAccounts = default(bool?), string password = default(string), string userName = default(string))
        {
            this.MachineAccounts = machineAccounts;
            this.OverwriteExistingAccounts = overwriteExistingAccounts;
            this.Password = password;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Specifies an array of computer names used to identify the Cohesity Cluster on the domain.
        /// </summary>
        /// <value>Specifies an array of computer names used to identify the Cohesity Cluster on the domain.</value>
        [DataMember(Name="machineAccounts", EmitDefaultValue=false)]
        public List<string> MachineAccounts { get; set; }

        /// <summary>
        /// Specifies whether the specified machine accounts should overwrite the existing machine accounts in this domain.
        /// </summary>
        /// <value>Specifies whether the specified machine accounts should overwrite the existing machine accounts in this domain.</value>
        [DataMember(Name="overwriteExistingAccounts", EmitDefaultValue=false)]
        public bool? OverwriteExistingAccounts { get; set; }

        /// <summary>
        /// Specifies the password for the specified userName.
        /// </summary>
        /// <value>Specifies the password for the specified userName.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies a userName that has administrative privileges in the domain.
        /// </summary>
        /// <value>Specifies a userName that has administrative privileges in the domain.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

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
            return this.Equals(input as UpdateMachineAccountsParams);
        }

        /// <summary>
        /// Returns true if UpdateMachineAccountsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMachineAccountsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMachineAccountsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MachineAccounts == input.MachineAccounts ||
                    this.MachineAccounts != null &&
                    this.MachineAccounts.SequenceEqual(input.MachineAccounts)
                ) && 
                (
                    this.OverwriteExistingAccounts == input.OverwriteExistingAccounts ||
                    (this.OverwriteExistingAccounts != null &&
                    this.OverwriteExistingAccounts.Equals(input.OverwriteExistingAccounts))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.MachineAccounts != null)
                    hashCode = hashCode * 59 + this.MachineAccounts.GetHashCode();
                if (this.OverwriteExistingAccounts != null)
                    hashCode = hashCode * 59 + this.OverwriteExistingAccounts.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

