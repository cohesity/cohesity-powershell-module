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
    /// Specifies the settings for creating a new clone refresh task.
    /// </summary>
    [DataContract]
    public partial class CloneRefreshRequest :  IEquatable<CloneRefreshRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneRefreshRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloneRefreshRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneRefreshRequest" /> class.
        /// </summary>
        /// <param name="cloneTaskId">Specifies the ID of the clone task. This is required to determine the details of the clone to be refreshed as clone task contains the details of the clone..</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="refreshTimeSecs">Specifies a point in time (unix epoch) to which the database needs to be refreshed. This helps granular refresh of the database. If this is set, relevant archive logs (redo logs) will also be re-played to match with the specified time. For this, the log backup should be enabled in the backup policy. If this is not set, then only the incremental backup data will be used to refresh the target database..</param>
        /// <param name="sourceDatabaseId">Specifies the ID of the source database in the backup job snapshot. This is the entity ID of the database, which needs to be used as a source during the refresh process..</param>
        /// <param name="vlanParameters">vlanParameters.</param>
        public CloneRefreshRequest(long? cloneTaskId = default(long?), bool? continueOnError = default(bool?), string name = default(string), long? newParentId = default(long?), List<RestoreObjectDetails> objects = default(List<RestoreObjectDetails>), long? refreshTimeSecs = default(long?), long? sourceDatabaseId = default(long?), VlanParameters vlanParameters = default(VlanParameters))
        {
            this.CloneTaskId = cloneTaskId;
            this.ContinueOnError = continueOnError;
            this.Name = name;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.RefreshTimeSecs = refreshTimeSecs;
            this.SourceDatabaseId = sourceDatabaseId;
            this.CloneTaskId = cloneTaskId;
            this.ContinueOnError = continueOnError;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.RefreshTimeSecs = refreshTimeSecs;
            this.SourceDatabaseId = sourceDatabaseId;
            this.VlanParameters = vlanParameters;
        }
        
        /// <summary>
        /// Specifies the ID of the clone task. This is required to determine the details of the clone to be refreshed as clone task contains the details of the clone.
        /// </summary>
        /// <value>Specifies the ID of the clone task. This is required to determine the details of the clone to be refreshed as clone task contains the details of the clone.</value>
        [DataMember(Name="cloneTaskId", EmitDefaultValue=true)]
        public long? CloneTaskId { get; set; }

        /// <summary>
        /// Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=true)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObjectDetails> Objects { get; set; }

        /// <summary>
        /// Specifies a point in time (unix epoch) to which the database needs to be refreshed. This helps granular refresh of the database. If this is set, relevant archive logs (redo logs) will also be re-played to match with the specified time. For this, the log backup should be enabled in the backup policy. If this is not set, then only the incremental backup data will be used to refresh the target database.
        /// </summary>
        /// <value>Specifies a point in time (unix epoch) to which the database needs to be refreshed. This helps granular refresh of the database. If this is set, relevant archive logs (redo logs) will also be re-played to match with the specified time. For this, the log backup should be enabled in the backup policy. If this is not set, then only the incremental backup data will be used to refresh the target database.</value>
        [DataMember(Name="refreshTimeSecs", EmitDefaultValue=true)]
        public long? RefreshTimeSecs { get; set; }

        /// <summary>
        /// Specifies the ID of the source database in the backup job snapshot. This is the entity ID of the database, which needs to be used as a source during the refresh process.
        /// </summary>
        /// <value>Specifies the ID of the source database in the backup job snapshot. This is the entity ID of the database, which needs to be used as a source during the refresh process.</value>
        [DataMember(Name="sourceDatabaseId", EmitDefaultValue=true)]
        public long? SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets or Sets VlanParameters
        /// </summary>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

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
            return this.Equals(input as CloneRefreshRequest);
        }

        /// <summary>
        /// Returns true if CloneRefreshRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneRefreshRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneRefreshRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloneTaskId == input.CloneTaskId ||
                    (this.CloneTaskId != null &&
                    this.CloneTaskId.Equals(input.CloneTaskId))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewParentId == input.NewParentId ||
                    (this.NewParentId != null &&
                    this.NewParentId.Equals(input.NewParentId))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.RefreshTimeSecs == input.RefreshTimeSecs ||
                    (this.RefreshTimeSecs != null &&
                    this.RefreshTimeSecs.Equals(input.RefreshTimeSecs))
                ) && 
                (
                    this.SourceDatabaseId == input.SourceDatabaseId ||
                    (this.SourceDatabaseId != null &&
                    this.SourceDatabaseId.Equals(input.SourceDatabaseId))
                ) && 
                (
                    this.VlanParameters == input.VlanParameters ||
                    (this.VlanParameters != null &&
                    this.VlanParameters.Equals(input.VlanParameters))
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
                if (this.CloneTaskId != null)
                    hashCode = hashCode * 59 + this.CloneTaskId.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.RefreshTimeSecs != null)
                    hashCode = hashCode * 59 + this.RefreshTimeSecs.GetHashCode();
                if (this.SourceDatabaseId != null)
                    hashCode = hashCode * 59 + this.SourceDatabaseId.GetHashCode();
                if (this.VlanParameters != null)
                    hashCode = hashCode * 59 + this.VlanParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

