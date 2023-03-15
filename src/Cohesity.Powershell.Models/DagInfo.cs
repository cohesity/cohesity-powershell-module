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
    /// Specifies the information about the DAG(Database availability group).
    /// </summary>
    [DataContract]
    public partial class DagInfo :  IEquatable<DagInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DagInfo" /> class.
        /// </summary>
        /// <param name="dagApplicationServerInfoList">Specifies the status of all the Exchange Application Servers that are part of this DAG..</param>
        /// <param name="exchangeDagProtectionPreference">exchangeDagProtectionPreference.</param>
        /// <param name="guid">Specifies Unique GUID for the DAG..</param>
        /// <param name="name">Specifies display name of the DAG..</param>
        public DagInfo(List<DagApplicationServerInfo> dagApplicationServerInfoList = default(List<DagApplicationServerInfo>), ExchangeDAGProtectionPreference exchangeDagProtectionPreference = default(ExchangeDAGProtectionPreference), string guid = default(string), string name = default(string))
        {
            this.DagApplicationServerInfoList = dagApplicationServerInfoList;
            this.Guid = guid;
            this.Name = name;
            this.DagApplicationServerInfoList = dagApplicationServerInfoList;
            this.ExchangeDagProtectionPreference = exchangeDagProtectionPreference;
            this.Guid = guid;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the status of all the Exchange Application Servers that are part of this DAG.
        /// </summary>
        /// <value>Specifies the status of all the Exchange Application Servers that are part of this DAG.</value>
        [DataMember(Name="dagApplicationServerInfoList", EmitDefaultValue=true)]
        public List<DagApplicationServerInfo> DagApplicationServerInfoList { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeDagProtectionPreference
        /// </summary>
        [DataMember(Name="exchangeDagProtectionPreference", EmitDefaultValue=false)]
        public ExchangeDAGProtectionPreference ExchangeDagProtectionPreference { get; set; }

        /// <summary>
        /// Specifies Unique GUID for the DAG.
        /// </summary>
        /// <value>Specifies Unique GUID for the DAG.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies display name of the DAG.
        /// </summary>
        /// <value>Specifies display name of the DAG.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as DagInfo);
        }

        /// <summary>
        /// Returns true if DagInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DagInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DagInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DagApplicationServerInfoList == input.DagApplicationServerInfoList ||
                    this.DagApplicationServerInfoList != null &&
                    input.DagApplicationServerInfoList != null &&
                    this.DagApplicationServerInfoList.SequenceEqual(input.DagApplicationServerInfoList)
                ) && 
                (
                    this.ExchangeDagProtectionPreference == input.ExchangeDagProtectionPreference ||
                    (this.ExchangeDagProtectionPreference != null &&
                    this.ExchangeDagProtectionPreference.Equals(input.ExchangeDagProtectionPreference))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.DagApplicationServerInfoList != null)
                    hashCode = hashCode * 59 + this.DagApplicationServerInfoList.GetHashCode();
                if (this.ExchangeDagProtectionPreference != null)
                    hashCode = hashCode * 59 + this.ExchangeDagProtectionPreference.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

