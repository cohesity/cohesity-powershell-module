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
    /// RestoreO365GroupsParams
    /// </summary>
    [DataContract]
    public partial class RestoreO365GroupsParams :  IEquatable<RestoreO365GroupsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365GroupsParams" /> class.
        /// </summary>
        /// <param name="createNewGroup">Bool which specifies, if we have to create a new group if it doesn&#39;t exist..</param>
        /// <param name="msGroupsVec">List of groups getting restored..</param>
        /// <param name="restoreOriginalOwnersMembers">Bool which specifies, if the original members/owners should be part of the newly created target group..</param>
        /// <param name="restoreToOriginal">Whether or not all groups are restored to original location..</param>
        /// <param name="targetGroup">Target group in case restore_to_original is false..</param>
        /// <param name="targetGroupName">Target group name in case restore_to_original is false. This will be ignored if restoring to alternate existing group..</param>
        /// <param name="targetGroupOwner">The string which contains the owner smtp address for the target group..</param>
        public RestoreO365GroupsParams(bool? createNewGroup = default(bool?), List<RestoreO365GroupsParamsMSGroupInfo> msGroupsVec = default(List<RestoreO365GroupsParamsMSGroupInfo>), bool? restoreOriginalOwnersMembers = default(bool?), bool? restoreToOriginal = default(bool?), string targetGroup = default(string), string targetGroupName = default(string), string targetGroupOwner = default(string))
        {
            this.CreateNewGroup = createNewGroup;
            this.MsGroupsVec = msGroupsVec;
            this.RestoreOriginalOwnersMembers = restoreOriginalOwnersMembers;
            this.RestoreToOriginal = restoreToOriginal;
            this.TargetGroup = targetGroup;
            this.TargetGroupName = targetGroupName;
            this.TargetGroupOwner = targetGroupOwner;
        }
        
        /// <summary>
        /// Bool which specifies, if we have to create a new group if it doesn&#39;t exist.
        /// </summary>
        /// <value>Bool which specifies, if we have to create a new group if it doesn&#39;t exist.</value>
        [DataMember(Name="createNewGroup", EmitDefaultValue=false)]
        public bool? CreateNewGroup { get; set; }

        /// <summary>
        /// List of groups getting restored.
        /// </summary>
        /// <value>List of groups getting restored.</value>
        [DataMember(Name="msGroupsVec", EmitDefaultValue=false)]
        public List<RestoreO365GroupsParamsMSGroupInfo> MsGroupsVec { get; set; }

        /// <summary>
        /// Bool which specifies, if the original members/owners should be part of the newly created target group.
        /// </summary>
        /// <value>Bool which specifies, if the original members/owners should be part of the newly created target group.</value>
        [DataMember(Name="restoreOriginalOwnersMembers", EmitDefaultValue=false)]
        public bool? RestoreOriginalOwnersMembers { get; set; }

        /// <summary>
        /// Whether or not all groups are restored to original location.
        /// </summary>
        /// <value>Whether or not all groups are restored to original location.</value>
        [DataMember(Name="restoreToOriginal", EmitDefaultValue=false)]
        public bool? RestoreToOriginal { get; set; }

        /// <summary>
        /// Target group in case restore_to_original is false.
        /// </summary>
        /// <value>Target group in case restore_to_original is false.</value>
        [DataMember(Name="targetGroup", EmitDefaultValue=false)]
        public string TargetGroup { get; set; }

        /// <summary>
        /// Target group name in case restore_to_original is false. This will be ignored if restoring to alternate existing group.
        /// </summary>
        /// <value>Target group name in case restore_to_original is false. This will be ignored if restoring to alternate existing group.</value>
        [DataMember(Name="targetGroupName", EmitDefaultValue=false)]
        public string TargetGroupName { get; set; }

        /// <summary>
        /// The string which contains the owner smtp address for the target group.
        /// </summary>
        /// <value>The string which contains the owner smtp address for the target group.</value>
        [DataMember(Name="targetGroupOwner", EmitDefaultValue=false)]
        public string TargetGroupOwner { get; set; }

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
            return this.Equals(input as RestoreO365GroupsParams);
        }

        /// <summary>
        /// Returns true if RestoreO365GroupsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365GroupsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365GroupsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateNewGroup == input.CreateNewGroup ||
                    (this.CreateNewGroup != null &&
                    this.CreateNewGroup.Equals(input.CreateNewGroup))
                ) && 
                (
                    this.MsGroupsVec == input.MsGroupsVec ||
                    this.MsGroupsVec != null &&
                    this.MsGroupsVec.Equals(input.MsGroupsVec)
                ) && 
                (
                    this.RestoreOriginalOwnersMembers == input.RestoreOriginalOwnersMembers ||
                    (this.RestoreOriginalOwnersMembers != null &&
                    this.RestoreOriginalOwnersMembers.Equals(input.RestoreOriginalOwnersMembers))
                ) && 
                (
                    this.RestoreToOriginal == input.RestoreToOriginal ||
                    (this.RestoreToOriginal != null &&
                    this.RestoreToOriginal.Equals(input.RestoreToOriginal))
                ) && 
                (
                    this.TargetGroup == input.TargetGroup ||
                    (this.TargetGroup != null &&
                    this.TargetGroup.Equals(input.TargetGroup))
                ) && 
                (
                    this.TargetGroupName == input.TargetGroupName ||
                    (this.TargetGroupName != null &&
                    this.TargetGroupName.Equals(input.TargetGroupName))
                ) && 
                (
                    this.TargetGroupOwner == input.TargetGroupOwner ||
                    (this.TargetGroupOwner != null &&
                    this.TargetGroupOwner.Equals(input.TargetGroupOwner))
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
                if (this.CreateNewGroup != null)
                    hashCode = hashCode * 59 + this.CreateNewGroup.GetHashCode();
                if (this.MsGroupsVec != null)
                    hashCode = hashCode * 59 + this.MsGroupsVec.GetHashCode();
                if (this.RestoreOriginalOwnersMembers != null)
                    hashCode = hashCode * 59 + this.RestoreOriginalOwnersMembers.GetHashCode();
                if (this.RestoreToOriginal != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginal.GetHashCode();
                if (this.TargetGroup != null)
                    hashCode = hashCode * 59 + this.TargetGroup.GetHashCode();
                if (this.TargetGroupName != null)
                    hashCode = hashCode * 59 + this.TargetGroupName.GetHashCode();
                if (this.TargetGroupOwner != null)
                    hashCode = hashCode * 59 + this.TargetGroupOwner.GetHashCode();
                return hashCode;
            }
        }

    }

}

