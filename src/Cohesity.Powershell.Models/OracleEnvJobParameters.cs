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
    /// Specifies job parameters applicable for all &#39;kOracle&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class OracleEnvJobParameters :  IEquatable<OracleEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleEnvJobParameters" /> class.
        /// </summary>
        /// <param name="persistMountpoints">Specifies whether the mountpoints created while backing up Oracle DBs should be persisted. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public OracleEnvJobParameters(bool? persistMountpoints = default(bool?), VlanParams vlanParams = default(VlanParams))
        {
            this.PersistMountpoints = persistMountpoints;
            this.VlanParams = vlanParams;
        }
        
        /// <summary>
        /// Specifies whether the mountpoints created while backing up Oracle DBs should be persisted. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams.
        /// </summary>
        /// <value>Specifies whether the mountpoints created while backing up Oracle DBs should be persisted. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams.</value>
        [DataMember(Name="persistMountpoints", EmitDefaultValue=true)]
        public bool? PersistMountpoints { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParams VlanParams { get; set; }

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
            return this.Equals(input as OracleEnvJobParameters);
        }

        /// <summary>
        /// Returns true if OracleEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PersistMountpoints == input.PersistMountpoints ||
                    (this.PersistMountpoints != null &&
                    this.PersistMountpoints.Equals(input.PersistMountpoints))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
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
                if (this.PersistMountpoints != null)
                    hashCode = hashCode * 59 + this.PersistMountpoints.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

