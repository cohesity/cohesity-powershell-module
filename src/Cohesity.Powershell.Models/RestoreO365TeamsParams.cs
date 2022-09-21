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
    /// RestoreO365TeamsParams
    /// </summary>
    [DataContract]
    public partial class RestoreO365TeamsParams :  IEquatable<RestoreO365TeamsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365TeamsParams" /> class.
        /// </summary>
        /// <param name="createNewTeam">Bool which specifies, if we have to create a new team if it doesn&#39;t exist..</param>
        /// <param name="msTeamsVec">List of teams getting restored..</param>
        /// <param name="restoreOriginalOwnersMembers">Bool which specifies, if the original members/owners should be part of the newly created target team..</param>
        /// <param name="restoreToOriginal">Whether or not all teams are restored to original location..</param>
        /// <param name="targetChannel">targetChannel.</param>
        /// <param name="targetMsTeamEntity">targetMsTeamEntity.</param>
        /// <param name="targetTeam">Target team in case restore_to_original is false..</param>
        /// <param name="targetTeamName">The display name for the target team. Specified when a new team needs to be created..</param>
        /// <param name="targetTeamOwner">The addtional team owner info for the specified by target team..</param>
        /// <param name="targetTeamOwnerEntity">targetTeamOwnerEntity.</param>
        public RestoreO365TeamsParams(bool? createNewTeam = default(bool?), List<RestoreO365TeamsParamsMSTeamInfo> msTeamsVec = default(List<RestoreO365TeamsParamsMSTeamInfo>), bool? restoreOriginalOwnersMembers = default(bool?), bool? restoreToOriginal = default(bool?), RestoreO365TeamsParamsTargetChannel targetChannel = default(RestoreO365TeamsParamsTargetChannel), EntityProto targetMsTeamEntity = default(EntityProto), string targetTeam = default(string), string targetTeamName = default(string), string targetTeamOwner = default(string), EntityProto targetTeamOwnerEntity = default(EntityProto))
        {
            this.CreateNewTeam = createNewTeam;
            this.MsTeamsVec = msTeamsVec;
            this.RestoreOriginalOwnersMembers = restoreOriginalOwnersMembers;
            this.RestoreToOriginal = restoreToOriginal;
            this.TargetTeam = targetTeam;
            this.TargetTeamName = targetTeamName;
            this.TargetTeamOwner = targetTeamOwner;
            this.CreateNewTeam = createNewTeam;
            this.MsTeamsVec = msTeamsVec;
            this.RestoreOriginalOwnersMembers = restoreOriginalOwnersMembers;
            this.RestoreToOriginal = restoreToOriginal;
            this.TargetChannel = targetChannel;
            this.TargetMsTeamEntity = targetMsTeamEntity;
            this.TargetTeam = targetTeam;
            this.TargetTeamName = targetTeamName;
            this.TargetTeamOwner = targetTeamOwner;
            this.TargetTeamOwnerEntity = targetTeamOwnerEntity;
        }
        
        /// <summary>
        /// Bool which specifies, if we have to create a new team if it doesn&#39;t exist.
        /// </summary>
        /// <value>Bool which specifies, if we have to create a new team if it doesn&#39;t exist.</value>
        [DataMember(Name="createNewTeam", EmitDefaultValue=true)]
        public bool? CreateNewTeam { get; set; }

        /// <summary>
        /// List of teams getting restored.
        /// </summary>
        /// <value>List of teams getting restored.</value>
        [DataMember(Name="msTeamsVec", EmitDefaultValue=true)]
        public List<RestoreO365TeamsParamsMSTeamInfo> MsTeamsVec { get; set; }

        /// <summary>
        /// Bool which specifies, if the original members/owners should be part of the newly created target team.
        /// </summary>
        /// <value>Bool which specifies, if the original members/owners should be part of the newly created target team.</value>
        [DataMember(Name="restoreOriginalOwnersMembers", EmitDefaultValue=true)]
        public bool? RestoreOriginalOwnersMembers { get; set; }

        /// <summary>
        /// Whether or not all teams are restored to original location.
        /// </summary>
        /// <value>Whether or not all teams are restored to original location.</value>
        [DataMember(Name="restoreToOriginal", EmitDefaultValue=true)]
        public bool? RestoreToOriginal { get; set; }

        /// <summary>
        /// Gets or Sets TargetChannel
        /// </summary>
        [DataMember(Name="targetChannel", EmitDefaultValue=false)]
        public RestoreO365TeamsParamsTargetChannel TargetChannel { get; set; }

        /// <summary>
        /// Gets or Sets TargetMsTeamEntity
        /// </summary>
        [DataMember(Name="targetMsTeamEntity", EmitDefaultValue=false)]
        public EntityProto TargetMsTeamEntity { get; set; }

        /// <summary>
        /// Target team in case restore_to_original is false.
        /// </summary>
        /// <value>Target team in case restore_to_original is false.</value>
        [DataMember(Name="targetTeam", EmitDefaultValue=true)]
        public string TargetTeam { get; set; }

        /// <summary>
        /// The display name for the target team. Specified when a new team needs to be created.
        /// </summary>
        /// <value>The display name for the target team. Specified when a new team needs to be created.</value>
        [DataMember(Name="targetTeamName", EmitDefaultValue=true)]
        public string TargetTeamName { get; set; }

        /// <summary>
        /// The addtional team owner info for the specified by target team.
        /// </summary>
        /// <value>The addtional team owner info for the specified by target team.</value>
        [DataMember(Name="targetTeamOwner", EmitDefaultValue=true)]
        public string TargetTeamOwner { get; set; }

        /// <summary>
        /// Gets or Sets TargetTeamOwnerEntity
        /// </summary>
        [DataMember(Name="targetTeamOwnerEntity", EmitDefaultValue=false)]
        public EntityProto TargetTeamOwnerEntity { get; set; }

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
            return this.Equals(input as RestoreO365TeamsParams);
        }

        /// <summary>
        /// Returns true if RestoreO365TeamsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365TeamsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365TeamsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateNewTeam == input.CreateNewTeam ||
                    (this.CreateNewTeam != null &&
                    this.CreateNewTeam.Equals(input.CreateNewTeam))
                ) && 
                (
                    this.MsTeamsVec == input.MsTeamsVec ||
                    this.MsTeamsVec != null &&
                    input.MsTeamsVec != null &&
                    this.MsTeamsVec.Equals(input.MsTeamsVec)
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
                    this.TargetChannel == input.TargetChannel ||
                    (this.TargetChannel != null &&
                    this.TargetChannel.Equals(input.TargetChannel))
                ) && 
                (
                    this.TargetMsTeamEntity == input.TargetMsTeamEntity ||
                    (this.TargetMsTeamEntity != null &&
                    this.TargetMsTeamEntity.Equals(input.TargetMsTeamEntity))
                ) && 
                (
                    this.TargetTeam == input.TargetTeam ||
                    (this.TargetTeam != null &&
                    this.TargetTeam.Equals(input.TargetTeam))
                ) && 
                (
                    this.TargetTeamName == input.TargetTeamName ||
                    (this.TargetTeamName != null &&
                    this.TargetTeamName.Equals(input.TargetTeamName))
                ) && 
                (
                    this.TargetTeamOwner == input.TargetTeamOwner ||
                    (this.TargetTeamOwner != null &&
                    this.TargetTeamOwner.Equals(input.TargetTeamOwner))
                ) && 
                (
                    this.TargetTeamOwnerEntity == input.TargetTeamOwnerEntity ||
                    (this.TargetTeamOwnerEntity != null &&
                    this.TargetTeamOwnerEntity.Equals(input.TargetTeamOwnerEntity))
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
                if (this.CreateNewTeam != null)
                    hashCode = hashCode * 59 + this.CreateNewTeam.GetHashCode();
                if (this.MsTeamsVec != null)
                    hashCode = hashCode * 59 + this.MsTeamsVec.GetHashCode();
                if (this.RestoreOriginalOwnersMembers != null)
                    hashCode = hashCode * 59 + this.RestoreOriginalOwnersMembers.GetHashCode();
                if (this.RestoreToOriginal != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginal.GetHashCode();
                if (this.TargetChannel != null)
                    hashCode = hashCode * 59 + this.TargetChannel.GetHashCode();
                if (this.TargetMsTeamEntity != null)
                    hashCode = hashCode * 59 + this.TargetMsTeamEntity.GetHashCode();
                if (this.TargetTeam != null)
                    hashCode = hashCode * 59 + this.TargetTeam.GetHashCode();
                if (this.TargetTeamName != null)
                    hashCode = hashCode * 59 + this.TargetTeamName.GetHashCode();
                if (this.TargetTeamOwner != null)
                    hashCode = hashCode * 59 + this.TargetTeamOwner.GetHashCode();
                if (this.TargetTeamOwnerEntity != null)
                    hashCode = hashCode * 59 + this.TargetTeamOwnerEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

