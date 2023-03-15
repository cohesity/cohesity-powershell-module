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
    /// ADObjectRestoreParam
    /// </summary>
    [DataContract]
    public partial class ADObjectRestoreParam :  IEquatable<ADObjectRestoreParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADObjectRestoreParam" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="guidVec">Array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status..</param>
        /// <param name="optionFlags">Restore option flags of type ADObjectRestoreOptionFlags..</param>
        /// <param name="ouPath">Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects..</param>
        /// <param name="srcSysvolFolder">When restoring a GPO, need to know the absolute path for SYSVOL folder..</param>
        public ADObjectRestoreParam(Credentials credentials = default(Credentials), List<string> guidVec = default(List<string>), int? optionFlags = default(int?), string ouPath = default(string), string srcSysvolFolder = default(string))
        {
            this.GuidVec = guidVec;
            this.OptionFlags = optionFlags;
            this.OuPath = ouPath;
            this.SrcSysvolFolder = srcSysvolFolder;
            this.Credentials = credentials;
            this.GuidVec = guidVec;
            this.OptionFlags = optionFlags;
            this.OuPath = ouPath;
            this.SrcSysvolFolder = srcSysvolFolder;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status.
        /// </summary>
        /// <value>Array of AD object guids to restore either from recycle bin or from AD snapshot. The guid should not exist in production AD. If it exits, then kDuplicate error is output in status.</value>
        [DataMember(Name="guidVec", EmitDefaultValue=true)]
        public List<string> GuidVec { get; set; }

        /// <summary>
        /// Restore option flags of type ADObjectRestoreOptionFlags.
        /// </summary>
        /// <value>Restore option flags of type ADObjectRestoreOptionFlags.</value>
        [DataMember(Name="optionFlags", EmitDefaultValue=true)]
        public int? OptionFlags { get; set; }

        /// <summary>
        /// Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects.
        /// </summary>
        /// <value>Distinguished name(DN) of the target Organization Unit (OU) to restore non-OU object. This can be empty, in which case objects are restored to their original OU. The &#39;credential&#39; specified must have privileges to add objects to this OU. Example: &#39;OU&#x3D;SJC,OU&#x3D;EngOU,DC&#x3D;contoso,DC&#x3D;com&#39;. This parameter is ignored for OU objects.</value>
        [DataMember(Name="ouPath", EmitDefaultValue=true)]
        public string OuPath { get; set; }

        /// <summary>
        /// When restoring a GPO, need to know the absolute path for SYSVOL folder.
        /// </summary>
        /// <value>When restoring a GPO, need to know the absolute path for SYSVOL folder.</value>
        [DataMember(Name="srcSysvolFolder", EmitDefaultValue=true)]
        public string SrcSysvolFolder { get; set; }

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
            return this.Equals(input as ADObjectRestoreParam);
        }

        /// <summary>
        /// Returns true if ADObjectRestoreParam instances are equal
        /// </summary>
        /// <param name="input">Instance of ADObjectRestoreParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADObjectRestoreParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.GuidVec == input.GuidVec ||
                    this.GuidVec != null &&
                    input.GuidVec != null &&
                    this.GuidVec.SequenceEqual(input.GuidVec)
                ) && 
                (
                    this.OptionFlags == input.OptionFlags ||
                    (this.OptionFlags != null &&
                    this.OptionFlags.Equals(input.OptionFlags))
                ) && 
                (
                    this.OuPath == input.OuPath ||
                    (this.OuPath != null &&
                    this.OuPath.Equals(input.OuPath))
                ) && 
                (
                    this.SrcSysvolFolder == input.SrcSysvolFolder ||
                    (this.SrcSysvolFolder != null &&
                    this.SrcSysvolFolder.Equals(input.SrcSysvolFolder))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.GuidVec != null)
                    hashCode = hashCode * 59 + this.GuidVec.GetHashCode();
                if (this.OptionFlags != null)
                    hashCode = hashCode * 59 + this.OptionFlags.GetHashCode();
                if (this.OuPath != null)
                    hashCode = hashCode * 59 + this.OuPath.GetHashCode();
                if (this.SrcSysvolFolder != null)
                    hashCode = hashCode * 59 + this.SrcSysvolFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

