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
    /// GROUP1 : {DST1/CH1.log, DST2/CH1.log} GROUP2 : {DST1/CH2.log, DST2/CH2.log} GROUP3 : {DST1/CH3.log, DST2/CH3.log}
    /// </summary>
    [DataContract]
    public partial class OracleDBConfigRedoLogGroupConf :  IEquatable<OracleDBConfigRedoLogGroupConf>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDBConfigRedoLogGroupConf" /> class.
        /// </summary>
        /// <param name="groupMemberVec">List of members of this redo log group..</param>
        /// <param name="memberPrefix">Log member name prefix..</param>
        /// <param name="numGroups">Number of redo log groups..</param>
        /// <param name="sizeMb">Size of the member in MB..</param>
        public OracleDBConfigRedoLogGroupConf(List<string> groupMemberVec = default(List<string>), string memberPrefix = default(string), int? numGroups = default(int?), int? sizeMb = default(int?))
        {
            this.GroupMemberVec = groupMemberVec;
            this.MemberPrefix = memberPrefix;
            this.NumGroups = numGroups;
            this.SizeMb = sizeMb;
            this.GroupMemberVec = groupMemberVec;
            this.MemberPrefix = memberPrefix;
            this.NumGroups = numGroups;
            this.SizeMb = sizeMb;
        }
        
        /// <summary>
        /// List of members of this redo log group.
        /// </summary>
        /// <value>List of members of this redo log group.</value>
        [DataMember(Name="groupMemberVec", EmitDefaultValue=true)]
        public List<string> GroupMemberVec { get; set; }

        /// <summary>
        /// Log member name prefix.
        /// </summary>
        /// <value>Log member name prefix.</value>
        [DataMember(Name="memberPrefix", EmitDefaultValue=true)]
        public string MemberPrefix { get; set; }

        /// <summary>
        /// Number of redo log groups.
        /// </summary>
        /// <value>Number of redo log groups.</value>
        [DataMember(Name="numGroups", EmitDefaultValue=true)]
        public int? NumGroups { get; set; }

        /// <summary>
        /// Size of the member in MB.
        /// </summary>
        /// <value>Size of the member in MB.</value>
        [DataMember(Name="sizeMb", EmitDefaultValue=true)]
        public int? SizeMb { get; set; }

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
            return this.Equals(input as OracleDBConfigRedoLogGroupConf);
        }

        /// <summary>
        /// Returns true if OracleDBConfigRedoLogGroupConf instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDBConfigRedoLogGroupConf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDBConfigRedoLogGroupConf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupMemberVec == input.GroupMemberVec ||
                    this.GroupMemberVec != null &&
                    input.GroupMemberVec != null &&
                    this.GroupMemberVec.SequenceEqual(input.GroupMemberVec)
                ) && 
                (
                    this.MemberPrefix == input.MemberPrefix ||
                    (this.MemberPrefix != null &&
                    this.MemberPrefix.Equals(input.MemberPrefix))
                ) && 
                (
                    this.NumGroups == input.NumGroups ||
                    (this.NumGroups != null &&
                    this.NumGroups.Equals(input.NumGroups))
                ) && 
                (
                    this.SizeMb == input.SizeMb ||
                    (this.SizeMb != null &&
                    this.SizeMb.Equals(input.SizeMb))
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
                if (this.GroupMemberVec != null)
                    hashCode = hashCode * 59 + this.GroupMemberVec.GetHashCode();
                if (this.MemberPrefix != null)
                    hashCode = hashCode * 59 + this.MemberPrefix.GetHashCode();
                if (this.NumGroups != null)
                    hashCode = hashCode * 59 + this.NumGroups.GetHashCode();
                if (this.SizeMb != null)
                    hashCode = hashCode * 59 + this.SizeMb.GetHashCode();
                return hashCode;
            }
        }

    }

}

