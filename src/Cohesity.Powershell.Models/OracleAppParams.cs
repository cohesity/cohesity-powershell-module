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
    /// Specifies special settings applicable for a app entity i.e database/dataguard.
    /// </summary>
    [DataContract]
    public partial class OracleAppParams :  IEquatable<OracleAppParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleAppParams" /> class.
        /// </summary>
        /// <param name="databaseAppId">Specifies the source entity id of the selected app entity..</param>
        /// <param name="nodeChannelList">Array of database node channel info.  Specifies the node channel info for all the databases of app entity. Length of this array will be 1 for RAC and Standalone setups..</param>
        public OracleAppParams(long? databaseAppId = default(long?), List<OracleDatabaseNodeChannel> nodeChannelList = default(List<OracleDatabaseNodeChannel>))
        {
            this.DatabaseAppId = databaseAppId;
            this.NodeChannelList = nodeChannelList;
        }
        
        /// <summary>
        /// Specifies the source entity id of the selected app entity.
        /// </summary>
        /// <value>Specifies the source entity id of the selected app entity.</value>
        [DataMember(Name="databaseAppId", EmitDefaultValue=false)]
        public long? DatabaseAppId { get; set; }

        /// <summary>
        /// Array of database node channel info.  Specifies the node channel info for all the databases of app entity. Length of this array will be 1 for RAC and Standalone setups.
        /// </summary>
        /// <value>Array of database node channel info.  Specifies the node channel info for all the databases of app entity. Length of this array will be 1 for RAC and Standalone setups.</value>
        [DataMember(Name="nodeChannelList", EmitDefaultValue=false)]
        public List<OracleDatabaseNodeChannel> NodeChannelList { get; set; }

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
            return this.Equals(input as OracleAppParams);
        }

        /// <summary>
        /// Returns true if OracleAppParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleAppParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleAppParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseAppId == input.DatabaseAppId ||
                    (this.DatabaseAppId != null &&
                    this.DatabaseAppId.Equals(input.DatabaseAppId))
                ) && 
                (
                    this.NodeChannelList == input.NodeChannelList ||
                    this.NodeChannelList != null &&
                    this.NodeChannelList.Equals(input.NodeChannelList)
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
                if (this.DatabaseAppId != null)
                    hashCode = hashCode * 59 + this.DatabaseAppId.GetHashCode();
                if (this.NodeChannelList != null)
                    hashCode = hashCode * 59 + this.NodeChannelList.GetHashCode();
                return hashCode;
            }
        }

    }

}

