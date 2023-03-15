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
    /// RestoreO365TeamsParamsMSTeamInfo
    /// </summary>
    [DataContract]
    public partial class RestoreO365TeamsParamsMSTeamInfo :  IEquatable<RestoreO365TeamsParamsMSTeamInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365TeamsParamsMSTeamInfo" /> class.
        /// </summary>
        /// <param name="isFullTeamRequired">Specify if the entire Team is to be restored..</param>
        /// <param name="_object">_object.</param>
        /// <param name="sourceChannelVec">Channel items that have to be restored. This will be empty iff is_full_team_required is false..</param>
        public RestoreO365TeamsParamsMSTeamInfo(bool? isFullTeamRequired = default(bool?), RestoreObject _object = default(RestoreObject), List<RestoreO365TeamsParamsSourceChannel> sourceChannelVec = default(List<RestoreO365TeamsParamsSourceChannel>))
        {
            this.IsFullTeamRequired = isFullTeamRequired;
            this.SourceChannelVec = sourceChannelVec;
            this.IsFullTeamRequired = isFullTeamRequired;
            this.Object = _object;
            this.SourceChannelVec = sourceChannelVec;
        }
        
        /// <summary>
        /// Specify if the entire Team is to be restored.
        /// </summary>
        /// <value>Specify if the entire Team is to be restored.</value>
        [DataMember(Name="isFullTeamRequired", EmitDefaultValue=true)]
        public bool? IsFullTeamRequired { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

        /// <summary>
        /// Channel items that have to be restored. This will be empty iff is_full_team_required is false.
        /// </summary>
        /// <value>Channel items that have to be restored. This will be empty iff is_full_team_required is false.</value>
        [DataMember(Name="sourceChannelVec", EmitDefaultValue=true)]
        public List<RestoreO365TeamsParamsSourceChannel> SourceChannelVec { get; set; }

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
            return this.Equals(input as RestoreO365TeamsParamsMSTeamInfo);
        }

        /// <summary>
        /// Returns true if RestoreO365TeamsParamsMSTeamInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365TeamsParamsMSTeamInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365TeamsParamsMSTeamInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsFullTeamRequired == input.IsFullTeamRequired ||
                    (this.IsFullTeamRequired != null &&
                    this.IsFullTeamRequired.Equals(input.IsFullTeamRequired))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.SourceChannelVec == input.SourceChannelVec ||
                    this.SourceChannelVec != null &&
                    input.SourceChannelVec != null &&
                    this.SourceChannelVec.SequenceEqual(input.SourceChannelVec)
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
                if (this.IsFullTeamRequired != null)
                    hashCode = hashCode * 59 + this.IsFullTeamRequired.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.SourceChannelVec != null)
                    hashCode = hashCode * 59 + this.SourceChannelVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

