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
    /// Request to stop a remote Vault search Job.
    /// </summary>
    [DataContract]
    public partial class StopRemoteVaultSearchJobParameters :  IEquatable<StopRemoteVaultSearchJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopRemoteVaultSearchJobParameters" /> class.
        /// </summary>
        /// <param name="searchJobUid">Specifies the unique id of the Remote Vault search job in progress..</param>
        public StopRemoteVaultSearchJobParameters(UniversalId searchJobUid = default(UniversalId))
        {
            this.SearchJobUid = searchJobUid;
        }
        
        /// <summary>
        /// Specifies the unique id of the Remote Vault search job in progress.
        /// </summary>
        /// <value>Specifies the unique id of the Remote Vault search job in progress.</value>
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
            return this.Equals(input as StopRemoteVaultSearchJobParameters);
        }

        /// <summary>
        /// Returns true if StopRemoteVaultSearchJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of StopRemoteVaultSearchJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopRemoteVaultSearchJobParameters input)
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

