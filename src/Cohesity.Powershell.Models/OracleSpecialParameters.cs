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
    /// Specifies special settings applicable for &#39;kOracle&#39; environment.
    /// </summary>
    [DataContract]
    public partial class OracleSpecialParameters :  IEquatable<OracleSpecialParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleSpecialParameters" /> class.
        /// </summary>
        /// <param name="appParamsList">Array of application parameters i.e. database parameters for standalone/RAC and DG parameters for data guard.  Specifies the list of parameters required at app entity level..</param>
        /// <param name="applicationEntityIds">Array of Ids of Application Entities like Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like Oracle instances, and databases to protect in a Protection Source of type kOracle&#39;. If not specified, all application entities on the Protection Source..</param>
        /// <param name="persistMountpoints">Specifies if the mountpoints for Oracle view for the current host are to be persisted..</param>
        public OracleSpecialParameters(List<OracleAppParams> appParamsList = default(List<OracleAppParams>), List<long> applicationEntityIds = default(List<long>), bool? persistMountpoints = default(bool?))
        {
            this.AppParamsList = appParamsList;
            this.ApplicationEntityIds = applicationEntityIds;
            this.PersistMountpoints = persistMountpoints;
            this.AppParamsList = appParamsList;
            this.ApplicationEntityIds = applicationEntityIds;
            this.PersistMountpoints = persistMountpoints;
        }
        
        /// <summary>
        /// Array of application parameters i.e. database parameters for standalone/RAC and DG parameters for data guard.  Specifies the list of parameters required at app entity level.
        /// </summary>
        /// <value>Array of application parameters i.e. database parameters for standalone/RAC and DG parameters for data guard.  Specifies the list of parameters required at app entity level.</value>
        [DataMember(Name="appParamsList", EmitDefaultValue=true)]
        public List<OracleAppParams> AppParamsList { get; set; }

        /// <summary>
        /// Array of Ids of Application Entities like Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like Oracle instances, and databases to protect in a Protection Source of type kOracle&#39;. If not specified, all application entities on the Protection Source.
        /// </summary>
        /// <value>Array of Ids of Application Entities like Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like Oracle instances, and databases to protect in a Protection Source of type kOracle&#39;. If not specified, all application entities on the Protection Source.</value>
        [DataMember(Name="applicationEntityIds", EmitDefaultValue=true)]
        public List<long> ApplicationEntityIds { get; set; }

        /// <summary>
        /// Specifies if the mountpoints for Oracle view for the current host are to be persisted.
        /// </summary>
        /// <value>Specifies if the mountpoints for Oracle view for the current host are to be persisted.</value>
        [DataMember(Name="persistMountpoints", EmitDefaultValue=true)]
        public bool? PersistMountpoints { get; set; }

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
            return this.Equals(input as OracleSpecialParameters);
        }

        /// <summary>
        /// Returns true if OracleSpecialParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleSpecialParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleSpecialParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppParamsList == input.AppParamsList ||
                    this.AppParamsList != null &&
                    input.AppParamsList != null &&
                    this.AppParamsList.Equals(input.AppParamsList)
                ) && 
                (
                    this.ApplicationEntityIds == input.ApplicationEntityIds ||
                    this.ApplicationEntityIds != null &&
                    input.ApplicationEntityIds != null &&
                    this.ApplicationEntityIds.Equals(input.ApplicationEntityIds)
                ) && 
                (
                    this.PersistMountpoints == input.PersistMountpoints ||
                    (this.PersistMountpoints != null &&
                    this.PersistMountpoints.Equals(input.PersistMountpoints))
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
                if (this.AppParamsList != null)
                    hashCode = hashCode * 59 + this.AppParamsList.GetHashCode();
                if (this.ApplicationEntityIds != null)
                    hashCode = hashCode * 59 + this.ApplicationEntityIds.GetHashCode();
                if (this.PersistMountpoints != null)
                    hashCode = hashCode * 59 + this.PersistMountpoints.GetHashCode();
                return hashCode;
            }
        }

    }

}

