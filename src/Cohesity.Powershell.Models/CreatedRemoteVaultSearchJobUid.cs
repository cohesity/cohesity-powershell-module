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
    /// Specifies the Uid of the Job created to search the remote vault.
    /// </summary>
    [DataContract]
    public partial class CreatedRemoteVaultSearchJobUid :  IEquatable<CreatedRemoteVaultSearchJobUid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedRemoteVaultSearchJobUid" /> class.
        /// </summary>
        /// <param name="searchJobUid">Specifies the unique id assigned for the search Job on the Cluster..</param>
        public CreatedRemoteVaultSearchJobUid(UniversalId searchJobUid = default(UniversalId))
        {
            this.SearchJobUid = searchJobUid;
            this.SearchJobUid = searchJobUid;
        }
        
        /// <summary>
        /// Specifies the unique id assigned for the search Job on the Cluster.
        /// </summary>
        /// <value>Specifies the unique id assigned for the search Job on the Cluster.</value>
        [DataMember(Name="searchJobUid", EmitDefaultValue=true)]
        public UniversalId SearchJobUid { get; set; }

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
            return this.Equals(input as CreatedRemoteVaultSearchJobUid);
        }

        /// <summary>
        /// Returns true if CreatedRemoteVaultSearchJobUid instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedRemoteVaultSearchJobUid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedRemoteVaultSearchJobUid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchJobUid == input.SearchJobUid ||
                    (this.SearchJobUid != null &&
                    this.SearchJobUid.Equals(input.SearchJobUid))
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
                if (this.SearchJobUid != null)
                    hashCode = hashCode * 59 + this.SearchJobUid.GetHashCode();
                return hashCode;
            }
        }

    }

}

