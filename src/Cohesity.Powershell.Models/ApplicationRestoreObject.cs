// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the Application Server to restore and parameters specific to that application.
    /// </summary>
    [DataContract]
    public partial class ApplicationRestoreObject :  IEquatable<ApplicationRestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationRestoreObject" /> class.
        /// </summary>
        /// <param name="applicationServerId">Specifies the Application Server to restore (for example, kSQL)..</param>
        /// <param name="sqlRestoreParameters">Specifies parameters specific to this Application Server..</param>
        /// <param name="targetHostId">Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source..</param>
        /// <param name="targetRootNodeId">Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application..</param>
        public ApplicationRestoreObject(long? applicationServerId = default(long?), SqlRestoreParameters sqlRestoreParameters = default(SqlRestoreParameters), long? targetHostId = default(long?), long? targetRootNodeId = default(long?))
        {
            this.ApplicationServerId = applicationServerId;
            this.SqlRestoreParameters = sqlRestoreParameters;
            this.TargetHostId = targetHostId;
            this.TargetRootNodeId = targetRootNodeId;
        }
        
        /// <summary>
        /// Specifies the Application Server to restore (for example, kSQL).
        /// </summary>
        /// <value>Specifies the Application Server to restore (for example, kSQL).</value>
        [DataMember(Name="applicationServerId", EmitDefaultValue=false)]
        public long? ApplicationServerId { get; set; }

        /// <summary>
        /// Specifies parameters specific to this Application Server.
        /// </summary>
        /// <value>Specifies parameters specific to this Application Server.</value>
        [DataMember(Name="sqlRestoreParameters", EmitDefaultValue=false)]
        public SqlRestoreParameters SqlRestoreParameters { get; set; }

        /// <summary>
        /// Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source.
        /// </summary>
        /// <value>Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source.</value>
        [DataMember(Name="targetHostId", EmitDefaultValue=false)]
        public long? TargetHostId { get; set; }

        /// <summary>
        /// Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application.
        /// </summary>
        /// <value>Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application.</value>
        [DataMember(Name="targetRootNodeId", EmitDefaultValue=false)]
        public long? TargetRootNodeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ApplicationRestoreObject);
        }

        /// <summary>
        /// Returns true if ApplicationRestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationRestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationRestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationServerId == input.ApplicationServerId ||
                    (this.ApplicationServerId != null &&
                    this.ApplicationServerId.Equals(input.ApplicationServerId))
                ) && 
                (
                    this.SqlRestoreParameters == input.SqlRestoreParameters ||
                    (this.SqlRestoreParameters != null &&
                    this.SqlRestoreParameters.Equals(input.SqlRestoreParameters))
                ) && 
                (
                    this.TargetHostId == input.TargetHostId ||
                    (this.TargetHostId != null &&
                    this.TargetHostId.Equals(input.TargetHostId))
                ) && 
                (
                    this.TargetRootNodeId == input.TargetRootNodeId ||
                    (this.TargetRootNodeId != null &&
                    this.TargetRootNodeId.Equals(input.TargetRootNodeId))
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
                if (this.ApplicationServerId != null)
                    hashCode = hashCode * 59 + this.ApplicationServerId.GetHashCode();
                if (this.SqlRestoreParameters != null)
                    hashCode = hashCode * 59 + this.SqlRestoreParameters.GetHashCode();
                if (this.TargetHostId != null)
                    hashCode = hashCode * 59 + this.TargetHostId.GetHashCode();
                if (this.TargetRootNodeId != null)
                    hashCode = hashCode * 59 + this.TargetRootNodeId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

