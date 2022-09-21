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
    /// OracleRecoveryValidationInfo
    /// </summary>
    [DataContract]
    public partial class OracleRecoveryValidationInfo :  IEquatable<OracleRecoveryValidationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleRecoveryValidationInfo" /> class.
        /// </summary>
        /// <param name="createDummyInstance">Boolean to tell whether we will be creating a dummy oracle instance to run recovery validations. Generally if we doing recovery validations on source host, we will do validations on the existing DB, else if validations are done on target different from source then we will be creating a dummy oracle instance to run validations..</param>
        public OracleRecoveryValidationInfo(bool? createDummyInstance = default(bool?))
        {
            this.CreateDummyInstance = createDummyInstance;
            this.CreateDummyInstance = createDummyInstance;
        }
        
        /// <summary>
        /// Boolean to tell whether we will be creating a dummy oracle instance to run recovery validations. Generally if we doing recovery validations on source host, we will do validations on the existing DB, else if validations are done on target different from source then we will be creating a dummy oracle instance to run validations.
        /// </summary>
        /// <value>Boolean to tell whether we will be creating a dummy oracle instance to run recovery validations. Generally if we doing recovery validations on source host, we will do validations on the existing DB, else if validations are done on target different from source then we will be creating a dummy oracle instance to run validations.</value>
        [DataMember(Name="createDummyInstance", EmitDefaultValue=true)]
        public bool? CreateDummyInstance { get; set; }

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
            return this.Equals(input as OracleRecoveryValidationInfo);
        }

        /// <summary>
        /// Returns true if OracleRecoveryValidationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleRecoveryValidationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleRecoveryValidationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateDummyInstance == input.CreateDummyInstance ||
                    (this.CreateDummyInstance != null &&
                    this.CreateDummyInstance.Equals(input.CreateDummyInstance))
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
                if (this.CreateDummyInstance != null)
                    hashCode = hashCode * 59 + this.CreateDummyInstance.GetHashCode();
                return hashCode;
            }
        }

    }

}

