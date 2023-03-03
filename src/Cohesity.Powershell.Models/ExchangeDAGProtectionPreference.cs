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
    /// Specifies the information about the preference order while choosing between which database copy of the database which is part of DAG should be protected.
    /// </summary>
    [DataContract]
    public partial class ExchangeDAGProtectionPreference :  IEquatable<ExchangeDAGProtectionPreference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeDAGProtectionPreference" /> class.
        /// </summary>
        /// <param name="passiveCopyPreferenceServerGuidList">Specifies the preference order of the exchange servers from which passive database copies should be protected. The preference order is descending which indicates that passive database copy in the first server in the list gets the highest preference..</param>
        /// <param name="passiveOnly">Specifies that only passive database copies should be protected if this is set to true. If this is set to false, both active and passive database copies can be protected..</param>
        /// <param name="useUserSpecifiedPassivePreferenceOrder">Specifies to use the user specified preference order of exchange servers from which the passive database copies should be protected if this is set to true.  Every copy of an Exchange database in a DAG is assigned an activation preference number. This number is used by the system as part of the passive database activation process. If this bool flag is set to false, the reverse order of activation is used while choosing between passive copies..</param>
        public ExchangeDAGProtectionPreference(List<string> passiveCopyPreferenceServerGuidList = default(List<string>), bool? passiveOnly = default(bool?), bool? useUserSpecifiedPassivePreferenceOrder = default(bool?))
        {
            this.PassiveCopyPreferenceServerGuidList = passiveCopyPreferenceServerGuidList;
            this.PassiveOnly = passiveOnly;
            this.UseUserSpecifiedPassivePreferenceOrder = useUserSpecifiedPassivePreferenceOrder;
            this.PassiveCopyPreferenceServerGuidList = passiveCopyPreferenceServerGuidList;
            this.PassiveOnly = passiveOnly;
            this.UseUserSpecifiedPassivePreferenceOrder = useUserSpecifiedPassivePreferenceOrder;
        }
        
        /// <summary>
        /// Specifies the preference order of the exchange servers from which passive database copies should be protected. The preference order is descending which indicates that passive database copy in the first server in the list gets the highest preference.
        /// </summary>
        /// <value>Specifies the preference order of the exchange servers from which passive database copies should be protected. The preference order is descending which indicates that passive database copy in the first server in the list gets the highest preference.</value>
        [DataMember(Name="passiveCopyPreferenceServerGuidList", EmitDefaultValue=true)]
        public List<string> PassiveCopyPreferenceServerGuidList { get; set; }

        /// <summary>
        /// Specifies that only passive database copies should be protected if this is set to true. If this is set to false, both active and passive database copies can be protected.
        /// </summary>
        /// <value>Specifies that only passive database copies should be protected if this is set to true. If this is set to false, both active and passive database copies can be protected.</value>
        [DataMember(Name="passiveOnly", EmitDefaultValue=true)]
        public bool? PassiveOnly { get; set; }

        /// <summary>
        /// Specifies to use the user specified preference order of exchange servers from which the passive database copies should be protected if this is set to true.  Every copy of an Exchange database in a DAG is assigned an activation preference number. This number is used by the system as part of the passive database activation process. If this bool flag is set to false, the reverse order of activation is used while choosing between passive copies.
        /// </summary>
        /// <value>Specifies to use the user specified preference order of exchange servers from which the passive database copies should be protected if this is set to true.  Every copy of an Exchange database in a DAG is assigned an activation preference number. This number is used by the system as part of the passive database activation process. If this bool flag is set to false, the reverse order of activation is used while choosing between passive copies.</value>
        [DataMember(Name="useUserSpecifiedPassivePreferenceOrder", EmitDefaultValue=true)]
        public bool? UseUserSpecifiedPassivePreferenceOrder { get; set; }

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
            return this.Equals(input as ExchangeDAGProtectionPreference);
        }

        /// <summary>
        /// Returns true if ExchangeDAGProtectionPreference instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeDAGProtectionPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeDAGProtectionPreference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassiveCopyPreferenceServerGuidList == input.PassiveCopyPreferenceServerGuidList ||
                    this.PassiveCopyPreferenceServerGuidList != null &&
                    input.PassiveCopyPreferenceServerGuidList != null &&
                    this.PassiveCopyPreferenceServerGuidList.SequenceEqual(input.PassiveCopyPreferenceServerGuidList)
                ) && 
                (
                    this.PassiveOnly == input.PassiveOnly ||
                    (this.PassiveOnly != null &&
                    this.PassiveOnly.Equals(input.PassiveOnly))
                ) && 
                (
                    this.UseUserSpecifiedPassivePreferenceOrder == input.UseUserSpecifiedPassivePreferenceOrder ||
                    (this.UseUserSpecifiedPassivePreferenceOrder != null &&
                    this.UseUserSpecifiedPassivePreferenceOrder.Equals(input.UseUserSpecifiedPassivePreferenceOrder))
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
                if (this.PassiveCopyPreferenceServerGuidList != null)
                    hashCode = hashCode * 59 + this.PassiveCopyPreferenceServerGuidList.GetHashCode();
                if (this.PassiveOnly != null)
                    hashCode = hashCode * 59 + this.PassiveOnly.GetHashCode();
                if (this.UseUserSpecifiedPassivePreferenceOrder != null)
                    hashCode = hashCode * 59 + this.UseUserSpecifiedPassivePreferenceOrder.GetHashCode();
                return hashCode;
            }
        }

    }

}

