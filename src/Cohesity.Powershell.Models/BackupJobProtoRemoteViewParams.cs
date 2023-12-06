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
    /// From 6.6 onwards, we always create remote view for view backups if policy has replication, hence &#39;create_remote_view&#39; bool is not added here.
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoRemoteViewParams :  IEquatable<BackupJobProtoRemoteViewParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoRemoteViewParams" /> class.
        /// </summary>
        /// <param name="remoteViewMap">A map from view id on source cluster to the view name params on remote cluster. This is applicable for view backups with replication configured in the policy..</param>
        public BackupJobProtoRemoteViewParams(List<BackupJobProtoRemoteViewParamsRemoteViewMapEntry> remoteViewMap = default(List<BackupJobProtoRemoteViewParamsRemoteViewMapEntry>))
        {
            this.RemoteViewMap = remoteViewMap;
            this.RemoteViewMap = remoteViewMap;
        }
        
        /// <summary>
        /// A map from view id on source cluster to the view name params on remote cluster. This is applicable for view backups with replication configured in the policy.
        /// </summary>
        /// <value>A map from view id on source cluster to the view name params on remote cluster. This is applicable for view backups with replication configured in the policy.</value>
        [DataMember(Name="remoteViewMap", EmitDefaultValue=true)]
        public List<BackupJobProtoRemoteViewParamsRemoteViewMapEntry> RemoteViewMap { get; set; }

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
            return this.Equals(input as BackupJobProtoRemoteViewParams);
        }

        /// <summary>
        /// Returns true if BackupJobProtoRemoteViewParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoRemoteViewParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoRemoteViewParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteViewMap == input.RemoteViewMap ||
                    this.RemoteViewMap != null &&
                    input.RemoteViewMap != null &&
                    this.RemoteViewMap.SequenceEqual(input.RemoteViewMap)
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
                if (this.RemoteViewMap != null)
                    hashCode = hashCode * 59 + this.RemoteViewMap.GetHashCode();
                return hashCode;
            }
        }

    }

}

