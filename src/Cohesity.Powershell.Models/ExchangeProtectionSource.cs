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
    /// Specifies an object representing an Exchange entity. DAG - Database availability group
    /// </summary>
    [DataContract]
    public partial class ExchangeProtectionSource :  IEquatable<ExchangeProtectionSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeProtectionSource" /> class.
        /// </summary>
        /// <param name="dagInfo">dagInfo.</param>
        /// <param name="applicationServerInfo">applicationServerInfo.</param>
        /// <param name="dagDatabaseCopyInfo">dagDatabaseCopyInfo.</param>
        /// <param name="dagDatabaseInfo">dagDatabaseInfo.</param>
        /// <param name="name">name.</param>
        /// <param name="ownerId">Specifies the entity id of the owner of the Exchange Protection Source..</param>
        /// <param name="standaloneDatabaseCopyInfo">standaloneDatabaseCopyInfo.</param>
        /// <param name="type">Specifies the type of the Exchange Protection Source..</param>
        /// <param name="uuid">Specifies the UUID for the Exchange entity..</param>
        public ExchangeProtectionSource(DagInfo dagInfo = default(DagInfo), ApplicationServerInfo applicationServerInfo = default(ApplicationServerInfo), ExchangeDatabaseCopyInfo dagDatabaseCopyInfo = default(ExchangeDatabaseCopyInfo), ExchangeDAGDatabase dagDatabaseInfo = default(ExchangeDAGDatabase), string name = default(string), long? ownerId = default(long?), ExchangeDatabaseInfo standaloneDatabaseCopyInfo = default(ExchangeDatabaseInfo), int? type = default(int?), string uuid = default(string))
        {
            this.Name = name;
            this.OwnerId = ownerId;
            this.Type = type;
            this.Uuid = uuid;
            this.DagInfo = dagInfo;
            this.ApplicationServerInfo = applicationServerInfo;
            this.DagDatabaseCopyInfo = dagDatabaseCopyInfo;
            this.DagDatabaseInfo = dagDatabaseInfo;
            this.Name = name;
            this.OwnerId = ownerId;
            this.StandaloneDatabaseCopyInfo = standaloneDatabaseCopyInfo;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets DagInfo
        /// </summary>
        [DataMember(Name="DagInfo", EmitDefaultValue=false)]
        public DagInfo DagInfo { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationServerInfo
        /// </summary>
        [DataMember(Name="applicationServerInfo", EmitDefaultValue=false)]
        public ApplicationServerInfo ApplicationServerInfo { get; set; }

        /// <summary>
        /// Gets or Sets DagDatabaseCopyInfo
        /// </summary>
        [DataMember(Name="dagDatabaseCopyInfo", EmitDefaultValue=false)]
        public ExchangeDatabaseCopyInfo DagDatabaseCopyInfo { get; set; }

        /// <summary>
        /// Gets or Sets DagDatabaseInfo
        /// </summary>
        [DataMember(Name="dagDatabaseInfo", EmitDefaultValue=false)]
        public ExchangeDAGDatabase DagDatabaseInfo { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the entity id of the owner of the Exchange Protection Source.
        /// </summary>
        /// <value>Specifies the entity id of the owner of the Exchange Protection Source.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets StandaloneDatabaseCopyInfo
        /// </summary>
        [DataMember(Name="standaloneDatabaseCopyInfo", EmitDefaultValue=false)]
        public ExchangeDatabaseInfo StandaloneDatabaseCopyInfo { get; set; }

        /// <summary>
        /// Specifies the type of the Exchange Protection Source.
        /// </summary>
        /// <value>Specifies the type of the Exchange Protection Source.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Specifies the UUID for the Exchange entity.
        /// </summary>
        /// <value>Specifies the UUID for the Exchange entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as ExchangeProtectionSource);
        }

        /// <summary>
        /// Returns true if ExchangeProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DagInfo == input.DagInfo ||
                    (this.DagInfo != null &&
                    this.DagInfo.Equals(input.DagInfo))
                ) && 
                (
                    this.ApplicationServerInfo == input.ApplicationServerInfo ||
                    (this.ApplicationServerInfo != null &&
                    this.ApplicationServerInfo.Equals(input.ApplicationServerInfo))
                ) && 
                (
                    this.DagDatabaseCopyInfo == input.DagDatabaseCopyInfo ||
                    (this.DagDatabaseCopyInfo != null &&
                    this.DagDatabaseCopyInfo.Equals(input.DagDatabaseCopyInfo))
                ) && 
                (
                    this.DagDatabaseInfo == input.DagDatabaseInfo ||
                    (this.DagDatabaseInfo != null &&
                    this.DagDatabaseInfo.Equals(input.DagDatabaseInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.StandaloneDatabaseCopyInfo == input.StandaloneDatabaseCopyInfo ||
                    (this.StandaloneDatabaseCopyInfo != null &&
                    this.StandaloneDatabaseCopyInfo.Equals(input.StandaloneDatabaseCopyInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.DagInfo != null)
                    hashCode = hashCode * 59 + this.DagInfo.GetHashCode();
                if (this.ApplicationServerInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationServerInfo.GetHashCode();
                if (this.DagDatabaseCopyInfo != null)
                    hashCode = hashCode * 59 + this.DagDatabaseCopyInfo.GetHashCode();
                if (this.DagDatabaseInfo != null)
                    hashCode = hashCode * 59 + this.DagDatabaseInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.StandaloneDatabaseCopyInfo != null)
                    hashCode = hashCode * 59 + this.StandaloneDatabaseCopyInfo.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

