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
    /// AdObjectRestoreParameters are the parameters to restore AD objects from recycle bin or from a mounted AD snapshot database.
    /// </summary>
    [DataContract]
    public partial class AdObjectRestoreParameters :  IEquatable<AdObjectRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdObjectRestoreParameters" /> class.
        /// </summary>
        /// <param name="changePasswordOnNextLogon">Specifies the option for AD &#39;user&#39; type of objects to change password when they next logon..</param>
        /// <param name="leaveStateDisabled">Specifies the option to leave the restored object in disabled state for AD &#39;account&#39; type of objects that support disabled state so that admin can do manual inspection before enabling the account. This property has no effect when restoring object from recycle bin. &#39;User&#39; and &#39;Computer&#39; are AD account types having enable/disable option..</param>
        /// <param name="objectGuids">Specifies the array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status..</param>
        /// <param name="organizationUnitPath">Specifies the Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects..</param>
        /// <param name="password">Specifies the password for restoring user type objects (user, inetOrgPerson or organizationalPerson LDAP classes) that is returned in search result with &#39;kRestorePasswordRequired&#39; flag, an initial password is required. The password is UTF8 string encoded in base64 format. Password cannot be empty and must satisfy production AD password complexity. If &#39;kFromDestRecycleBinIfFound&#39; is true and the user is restored from production AD recycle bin, password will not be changed and the restored user retains their original password. For non-user type objects, this password value is ignored..</param>
        public AdObjectRestoreParameters(bool? changePasswordOnNextLogon = default(bool?), bool? leaveStateDisabled = default(bool?), List<string> objectGuids = default(List<string>), string organizationUnitPath = default(string), string password = default(string))
        {
            this.ChangePasswordOnNextLogon = changePasswordOnNextLogon;
            this.LeaveStateDisabled = leaveStateDisabled;
            this.ObjectGuids = objectGuids;
            this.OrganizationUnitPath = organizationUnitPath;
            this.Password = password;
            this.ChangePasswordOnNextLogon = changePasswordOnNextLogon;
            this.LeaveStateDisabled = leaveStateDisabled;
            this.ObjectGuids = objectGuids;
            this.OrganizationUnitPath = organizationUnitPath;
            this.Password = password;
        }
        
        /// <summary>
        /// Specifies the option for AD &#39;user&#39; type of objects to change password when they next logon.
        /// </summary>
        /// <value>Specifies the option for AD &#39;user&#39; type of objects to change password when they next logon.</value>
        [DataMember(Name="changePasswordOnNextLogon", EmitDefaultValue=true)]
        public bool? ChangePasswordOnNextLogon { get; set; }

        /// <summary>
        /// Specifies the option to leave the restored object in disabled state for AD &#39;account&#39; type of objects that support disabled state so that admin can do manual inspection before enabling the account. This property has no effect when restoring object from recycle bin. &#39;User&#39; and &#39;Computer&#39; are AD account types having enable/disable option.
        /// </summary>
        /// <value>Specifies the option to leave the restored object in disabled state for AD &#39;account&#39; type of objects that support disabled state so that admin can do manual inspection before enabling the account. This property has no effect when restoring object from recycle bin. &#39;User&#39; and &#39;Computer&#39; are AD account types having enable/disable option.</value>
        [DataMember(Name="leaveStateDisabled", EmitDefaultValue=true)]
        public bool? LeaveStateDisabled { get; set; }

        /// <summary>
        /// Specifies the array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status.
        /// </summary>
        /// <value>Specifies the array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status.</value>
        [DataMember(Name="objectGuids", EmitDefaultValue=true)]
        public List<string> ObjectGuids { get; set; }

        /// <summary>
        /// Specifies the Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects.
        /// </summary>
        /// <value>Specifies the Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects.</value>
        [DataMember(Name="organizationUnitPath", EmitDefaultValue=true)]
        public string OrganizationUnitPath { get; set; }

        /// <summary>
        /// Specifies the password for restoring user type objects (user, inetOrgPerson or organizationalPerson LDAP classes) that is returned in search result with &#39;kRestorePasswordRequired&#39; flag, an initial password is required. The password is UTF8 string encoded in base64 format. Password cannot be empty and must satisfy production AD password complexity. If &#39;kFromDestRecycleBinIfFound&#39; is true and the user is restored from production AD recycle bin, password will not be changed and the restored user retains their original password. For non-user type objects, this password value is ignored.
        /// </summary>
        /// <value>Specifies the password for restoring user type objects (user, inetOrgPerson or organizationalPerson LDAP classes) that is returned in search result with &#39;kRestorePasswordRequired&#39; flag, an initial password is required. The password is UTF8 string encoded in base64 format. Password cannot be empty and must satisfy production AD password complexity. If &#39;kFromDestRecycleBinIfFound&#39; is true and the user is restored from production AD recycle bin, password will not be changed and the restored user retains their original password. For non-user type objects, this password value is ignored.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

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
            return this.Equals(input as AdObjectRestoreParameters);
        }

        /// <summary>
        /// Returns true if AdObjectRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AdObjectRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdObjectRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangePasswordOnNextLogon == input.ChangePasswordOnNextLogon ||
                    (this.ChangePasswordOnNextLogon != null &&
                    this.ChangePasswordOnNextLogon.Equals(input.ChangePasswordOnNextLogon))
                ) && 
                (
                    this.LeaveStateDisabled == input.LeaveStateDisabled ||
                    (this.LeaveStateDisabled != null &&
                    this.LeaveStateDisabled.Equals(input.LeaveStateDisabled))
                ) && 
                (
                    this.ObjectGuids == input.ObjectGuids ||
                    this.ObjectGuids != null &&
                    input.ObjectGuids != null &&
                    this.ObjectGuids.SequenceEqual(input.ObjectGuids)
                ) && 
                (
                    this.OrganizationUnitPath == input.OrganizationUnitPath ||
                    (this.OrganizationUnitPath != null &&
                    this.OrganizationUnitPath.Equals(input.OrganizationUnitPath))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.ChangePasswordOnNextLogon != null)
                    hashCode = hashCode * 59 + this.ChangePasswordOnNextLogon.GetHashCode();
                if (this.LeaveStateDisabled != null)
                    hashCode = hashCode * 59 + this.LeaveStateDisabled.GetHashCode();
                if (this.ObjectGuids != null)
                    hashCode = hashCode * 59 + this.ObjectGuids.GetHashCode();
                if (this.OrganizationUnitPath != null)
                    hashCode = hashCode * 59 + this.OrganizationUnitPath.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }

}

