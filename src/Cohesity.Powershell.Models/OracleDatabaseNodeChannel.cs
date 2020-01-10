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
    /// Specifies node and channel info required for the backup and restore of a database.
    /// </summary>
    [DataContract]
    public partial class OracleDatabaseNodeChannel :  IEquatable<OracleDatabaseNodeChannel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDatabaseNodeChannel" /> class.
        /// </summary>
        /// <param name="archiveLogKeepDays">Specifies the number of days archive log should be stored..</param>
        /// <param name="databaseNodeList">Array of nodes of a database.  Specifies the Node info from where we are allowed to take the backup/restore..</param>
        /// <param name="databaseUniqueName">Specifies the unique Name of the database..</param>
        /// <param name="databaseUuid">Specifies the database unique id. This is an internal field and is filled by magneto master based on corresponding app entity id..</param>
        /// <param name="defaultChannelCount">Specifies the default number of channels to use per node per database. The default number of channels to use per host per db. This value is used on all OracleDatabaseNode&#39;s unless databaseNodeList item&#39;s channelCount is specified for the node..</param>
        /// <param name="maxNodeCount">Specifies the maximum number of nodes from which we are allowed to take backup/restore..</param>
        public OracleDatabaseNodeChannel(int? archiveLogKeepDays = default(int?), List<OracleDatabaseNode> databaseNodeList = default(List<OracleDatabaseNode>), string databaseUniqueName = default(string), string databaseUuid = default(string), int? defaultChannelCount = default(int?), int? maxNodeCount = default(int?))
        {
            this.ArchiveLogKeepDays = archiveLogKeepDays;
            this.DatabaseNodeList = databaseNodeList;
            this.DatabaseUniqueName = databaseUniqueName;
            this.DatabaseUuid = databaseUuid;
            this.DefaultChannelCount = defaultChannelCount;
            this.MaxNodeCount = maxNodeCount;
            this.ArchiveLogKeepDays = archiveLogKeepDays;
            this.DatabaseNodeList = databaseNodeList;
            this.DatabaseUniqueName = databaseUniqueName;
            this.DatabaseUuid = databaseUuid;
            this.DefaultChannelCount = defaultChannelCount;
            this.MaxNodeCount = maxNodeCount;
        }
        
        /// <summary>
        /// Specifies the number of days archive log should be stored.
        /// </summary>
        /// <value>Specifies the number of days archive log should be stored.</value>
        [DataMember(Name="archiveLogKeepDays", EmitDefaultValue=true)]
        public int? ArchiveLogKeepDays { get; set; }

        /// <summary>
        /// Array of nodes of a database.  Specifies the Node info from where we are allowed to take the backup/restore.
        /// </summary>
        /// <value>Array of nodes of a database.  Specifies the Node info from where we are allowed to take the backup/restore.</value>
        [DataMember(Name="databaseNodeList", EmitDefaultValue=true)]
        public List<OracleDatabaseNode> DatabaseNodeList { get; set; }

        /// <summary>
        /// Specifies the unique Name of the database.
        /// </summary>
        /// <value>Specifies the unique Name of the database.</value>
        [DataMember(Name="databaseUniqueName", EmitDefaultValue=true)]
        public string DatabaseUniqueName { get; set; }

        /// <summary>
        /// Specifies the database unique id. This is an internal field and is filled by magneto master based on corresponding app entity id.
        /// </summary>
        /// <value>Specifies the database unique id. This is an internal field and is filled by magneto master based on corresponding app entity id.</value>
        [DataMember(Name="databaseUuid", EmitDefaultValue=true)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// Specifies the default number of channels to use per node per database. The default number of channels to use per host per db. This value is used on all OracleDatabaseNode&#39;s unless databaseNodeList item&#39;s channelCount is specified for the node.
        /// </summary>
        /// <value>Specifies the default number of channels to use per node per database. The default number of channels to use per host per db. This value is used on all OracleDatabaseNode&#39;s unless databaseNodeList item&#39;s channelCount is specified for the node.</value>
        [DataMember(Name="defaultChannelCount", EmitDefaultValue=true)]
        public int? DefaultChannelCount { get; set; }

        /// <summary>
        /// Specifies the maximum number of nodes from which we are allowed to take backup/restore.
        /// </summary>
        /// <value>Specifies the maximum number of nodes from which we are allowed to take backup/restore.</value>
        [DataMember(Name="maxNodeCount", EmitDefaultValue=true)]
        public int? MaxNodeCount { get; set; }

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
            return this.Equals(input as OracleDatabaseNodeChannel);
        }

        /// <summary>
        /// Returns true if OracleDatabaseNodeChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDatabaseNodeChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDatabaseNodeChannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveLogKeepDays == input.ArchiveLogKeepDays ||
                    (this.ArchiveLogKeepDays != null &&
                    this.ArchiveLogKeepDays.Equals(input.ArchiveLogKeepDays))
                ) && 
                (
                    this.DatabaseNodeList == input.DatabaseNodeList ||
                    this.DatabaseNodeList != null &&
                    input.DatabaseNodeList != null &&
                    this.DatabaseNodeList.SequenceEqual(input.DatabaseNodeList)
                ) && 
                (
                    this.DatabaseUniqueName == input.DatabaseUniqueName ||
                    (this.DatabaseUniqueName != null &&
                    this.DatabaseUniqueName.Equals(input.DatabaseUniqueName))
                ) && 
                (
                    this.DatabaseUuid == input.DatabaseUuid ||
                    (this.DatabaseUuid != null &&
                    this.DatabaseUuid.Equals(input.DatabaseUuid))
                ) && 
                (
                    this.DefaultChannelCount == input.DefaultChannelCount ||
                    (this.DefaultChannelCount != null &&
                    this.DefaultChannelCount.Equals(input.DefaultChannelCount))
                ) && 
                (
                    this.MaxNodeCount == input.MaxNodeCount ||
                    (this.MaxNodeCount != null &&
                    this.MaxNodeCount.Equals(input.MaxNodeCount))
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
                if (this.ArchiveLogKeepDays != null)
                    hashCode = hashCode * 59 + this.ArchiveLogKeepDays.GetHashCode();
                if (this.DatabaseNodeList != null)
                    hashCode = hashCode * 59 + this.DatabaseNodeList.GetHashCode();
                if (this.DatabaseUniqueName != null)
                    hashCode = hashCode * 59 + this.DatabaseUniqueName.GetHashCode();
                if (this.DatabaseUuid != null)
                    hashCode = hashCode * 59 + this.DatabaseUuid.GetHashCode();
                if (this.DefaultChannelCount != null)
                    hashCode = hashCode * 59 + this.DefaultChannelCount.GetHashCode();
                if (this.MaxNodeCount != null)
                    hashCode = hashCode * 59 + this.MaxNodeCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

