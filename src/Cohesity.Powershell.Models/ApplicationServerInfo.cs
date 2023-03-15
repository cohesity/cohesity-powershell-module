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
    /// Specifies the Information about the Exchange Server Node.
    /// </summary>
    [DataContract]
    public partial class ApplicationServerInfo :  IEquatable<ApplicationServerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationServerInfo" /> class.
        /// </summary>
        /// <param name="databaseCopyInfoList">Specifies the list of all the copies of the Exchange databases(that are part of DAG) that are present on this Exchange Node..</param>
        /// <param name="databaseInfoList">Specifies the list of all the databases available on the standalone Exchange server node. This is populated for the Standlone Exchange Servers..</param>
        /// <param name="fqdn">Specifies the fully qualified domain name of the Exchange Server..</param>
        /// <param name="guid">Specifies the Guid of the Exchange Application Server..</param>
        /// <param name="name">Specifies the display name of the Exchange Application Server..</param>
        /// <param name="totalSizeBytes">Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG..</param>
        public ApplicationServerInfo(List<ExchangeDatabaseCopyInfo> databaseCopyInfoList = default(List<ExchangeDatabaseCopyInfo>), List<ExchangeDatabaseInfo> databaseInfoList = default(List<ExchangeDatabaseInfo>), string fqdn = default(string), string guid = default(string), string name = default(string), long? totalSizeBytes = default(long?))
        {
            this.DatabaseCopyInfoList = databaseCopyInfoList;
            this.DatabaseInfoList = databaseInfoList;
            this.Fqdn = fqdn;
            this.Guid = guid;
            this.Name = name;
            this.TotalSizeBytes = totalSizeBytes;
            this.DatabaseCopyInfoList = databaseCopyInfoList;
            this.DatabaseInfoList = databaseInfoList;
            this.Fqdn = fqdn;
            this.Guid = guid;
            this.Name = name;
            this.TotalSizeBytes = totalSizeBytes;
        }
        
        /// <summary>
        /// Specifies the list of all the copies of the Exchange databases(that are part of DAG) that are present on this Exchange Node.
        /// </summary>
        /// <value>Specifies the list of all the copies of the Exchange databases(that are part of DAG) that are present on this Exchange Node.</value>
        [DataMember(Name="databaseCopyInfoList", EmitDefaultValue=true)]
        public List<ExchangeDatabaseCopyInfo> DatabaseCopyInfoList { get; set; }

        /// <summary>
        /// Specifies the list of all the databases available on the standalone Exchange server node. This is populated for the Standlone Exchange Servers.
        /// </summary>
        /// <value>Specifies the list of all the databases available on the standalone Exchange server node. This is populated for the Standlone Exchange Servers.</value>
        [DataMember(Name="databaseInfoList", EmitDefaultValue=true)]
        public List<ExchangeDatabaseInfo> DatabaseInfoList { get; set; }

        /// <summary>
        /// Specifies the fully qualified domain name of the Exchange Server.
        /// </summary>
        /// <value>Specifies the fully qualified domain name of the Exchange Server.</value>
        [DataMember(Name="fqdn", EmitDefaultValue=true)]
        public string Fqdn { get; set; }

        /// <summary>
        /// Specifies the Guid of the Exchange Application Server.
        /// </summary>
        /// <value>Specifies the Guid of the Exchange Application Server.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies the display name of the Exchange Application Server.
        /// </summary>
        /// <value>Specifies the display name of the Exchange Application Server.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG.
        /// </summary>
        /// <value>Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG.</value>
        [DataMember(Name="totalSizeBytes", EmitDefaultValue=true)]
        public long? TotalSizeBytes { get; set; }

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
            return this.Equals(input as ApplicationServerInfo);
        }

        /// <summary>
        /// Returns true if ApplicationServerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationServerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseCopyInfoList == input.DatabaseCopyInfoList ||
                    this.DatabaseCopyInfoList != null &&
                    input.DatabaseCopyInfoList != null &&
                    this.DatabaseCopyInfoList.SequenceEqual(input.DatabaseCopyInfoList)
                ) && 
                (
                    this.DatabaseInfoList == input.DatabaseInfoList ||
                    this.DatabaseInfoList != null &&
                    input.DatabaseInfoList != null &&
                    this.DatabaseInfoList.SequenceEqual(input.DatabaseInfoList)
                ) && 
                (
                    this.Fqdn == input.Fqdn ||
                    (this.Fqdn != null &&
                    this.Fqdn.Equals(input.Fqdn))
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
                ) && 
                (
                    this.TotalSizeBytes == input.TotalSizeBytes ||
                    (this.TotalSizeBytes != null &&
                    this.TotalSizeBytes.Equals(input.TotalSizeBytes))
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
                if (this.DatabaseCopyInfoList != null)
                    hashCode = hashCode * 59 + this.DatabaseCopyInfoList.GetHashCode();
                if (this.DatabaseInfoList != null)
                    hashCode = hashCode * 59 + this.DatabaseInfoList.GetHashCode();
                if (this.Fqdn != null)
                    hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

