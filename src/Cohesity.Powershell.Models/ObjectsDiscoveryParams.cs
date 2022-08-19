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
    /// Specifies the parameters used for discovering the office 365 objects selectively during source registration or refresh.
    /// </summary>
    [DataContract]
    public partial class ObjectsDiscoveryParams :  IEquatable<ObjectsDiscoveryParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsDiscoveryParams" /> class.
        /// </summary>
        /// <param name="discoverableObjectTypeList">Specifies the list of object types that will be discovered as part of source registration or refresh..</param>
        /// <param name="usersDiscoveryParams">usersDiscoveryParams.</param>
        public ObjectsDiscoveryParams(List<string> discoverableObjectTypeList = default(List<string>), UsersDiscoveryParams usersDiscoveryParams = default(UsersDiscoveryParams))
        {
            this.DiscoverableObjectTypeList = discoverableObjectTypeList;
            this.DiscoverableObjectTypeList = discoverableObjectTypeList;
            this.UsersDiscoveryParams = usersDiscoveryParams;
        }
        
        /// <summary>
        /// Specifies the list of object types that will be discovered as part of source registration or refresh.
        /// </summary>
        /// <value>Specifies the list of object types that will be discovered as part of source registration or refresh.</value>
        [DataMember(Name="discoverableObjectTypeList", EmitDefaultValue=true)]
        public List<string> DiscoverableObjectTypeList { get; set; }

        /// <summary>
        /// Gets or Sets UsersDiscoveryParams
        /// </summary>
        [DataMember(Name="usersDiscoveryParams", EmitDefaultValue=false)]
        public UsersDiscoveryParams UsersDiscoveryParams { get; set; }

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
            return this.Equals(input as ObjectsDiscoveryParams);
        }

        /// <summary>
        /// Returns true if ObjectsDiscoveryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectsDiscoveryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectsDiscoveryParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscoverableObjectTypeList == input.DiscoverableObjectTypeList ||
                    this.DiscoverableObjectTypeList != null &&
                    input.DiscoverableObjectTypeList != null &&
                    this.DiscoverableObjectTypeList.Equals(input.DiscoverableObjectTypeList)
                ) && 
                (
                    this.UsersDiscoveryParams == input.UsersDiscoveryParams ||
                    (this.UsersDiscoveryParams != null &&
                    this.UsersDiscoveryParams.Equals(input.UsersDiscoveryParams))
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
                if (this.DiscoverableObjectTypeList != null)
                    hashCode = hashCode * 59 + this.DiscoverableObjectTypeList.GetHashCode();
                if (this.UsersDiscoveryParams != null)
                    hashCode = hashCode * 59 + this.UsersDiscoveryParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

