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
    /// Specifies additional params for Teams entities. It should only be populated if the &#39;DiscoveryParams.discoverableObjectTypeList&#39; includes &#39;kTeams&#39; otherwise this will be ignored.
    /// </summary>
    [DataContract]
    public partial class TeamsAdditionalParams :  IEquatable<TeamsAdditionalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAdditionalParams" /> class.
        /// </summary>
        /// <param name="allowPostsBackup">Specifies whether the Teams posts/conversations will be backed up or not. If this is false or not specified teams&#39; posts backup will not be done..</param>
        public TeamsAdditionalParams(bool? allowPostsBackup = default(bool?))
        {
            this.AllowPostsBackup = allowPostsBackup;
            this.AllowPostsBackup = allowPostsBackup;
        }
        
        /// <summary>
        /// Specifies whether the Teams posts/conversations will be backed up or not. If this is false or not specified teams&#39; posts backup will not be done.
        /// </summary>
        /// <value>Specifies whether the Teams posts/conversations will be backed up or not. If this is false or not specified teams&#39; posts backup will not be done.</value>
        [DataMember(Name="allowPostsBackup", EmitDefaultValue=true)]
        public bool? AllowPostsBackup { get; set; }

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
            return this.Equals(input as TeamsAdditionalParams);
        }

        /// <summary>
        /// Returns true if TeamsAdditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsAdditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsAdditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowPostsBackup == input.AllowPostsBackup ||
                    (this.AllowPostsBackup != null &&
                    this.AllowPostsBackup.Equals(input.AllowPostsBackup))
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
                if (this.AllowPostsBackup != null)
                    hashCode = hashCode * 59 + this.AllowPostsBackup.GetHashCode();
                return hashCode;
            }
        }

    }

}

