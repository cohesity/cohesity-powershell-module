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
    /// TenantStats
    /// </summary>
    [DataContract]
    public partial class TenantStats :  IEquatable<TenantStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantStats" /> class.
        /// </summary>
        /// <param name="groupList">Specifies a list of groups associated to this tenant (organization)..</param>
        /// <param name="id">Specifies the id of the tenant (organization)..</param>
        /// <param name="name">Specifies the name of the tenant (organization)..</param>
        /// <param name="schemaInfoList">Specifies a list of schemaInfos of the tenant (organization)..</param>
        /// <param name="stats">stats.</param>
        public TenantStats(List<StatsGroup> groupList = default(List<StatsGroup>), string id = default(string), string name = default(string), List<UsageSchemaInfo> schemaInfoList = default(List<UsageSchemaInfo>), DataUsageStats stats = default(DataUsageStats))
        {
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.SchemaInfoList = schemaInfoList;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Specifies a list of groups associated to this tenant (organization).
        /// </summary>
        /// <value>Specifies a list of groups associated to this tenant (organization).</value>
        [DataMember(Name="groupList", EmitDefaultValue=false)]
        public List<StatsGroup> GroupList { get; set; }

        /// <summary>
        /// Specifies the id of the tenant (organization).
        /// </summary>
        /// <value>Specifies the id of the tenant (organization).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the name of the tenant (organization).
        /// </summary>
        /// <value>Specifies the name of the tenant (organization).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a list of schemaInfos of the tenant (organization).
        /// </summary>
        /// <value>Specifies a list of schemaInfos of the tenant (organization).</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=false)]
        public List<UsageSchemaInfo> SchemaInfoList { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public DataUsageStats Stats { get; set; }

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
            return this.Equals(input as TenantStats);
        }

        /// <summary>
        /// Returns true if TenantStats instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupList == input.GroupList ||
                    this.GroupList != null &&
                    this.GroupList.Equals(input.GroupList)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    this.SchemaInfoList.Equals(input.SchemaInfoList)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                if (this.GroupList != null)
                    hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }

    }

}

