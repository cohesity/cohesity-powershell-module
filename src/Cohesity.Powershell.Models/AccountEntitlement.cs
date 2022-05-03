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
    /// AccountEntitlement
    /// </summary>
    [DataContract]
    public partial class AccountEntitlement :  IEquatable<AccountEntitlement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEntitlement" /> class.
        /// </summary>
        /// <param name="dMaaSFreeTrialC">Specifies whether DMaaS free trail is active..</param>
        /// <param name="endDate">Specifies the end date of the entitlement..</param>
        /// <param name="id">Specifies the entitlement ID..</param>
        /// <param name="name">Specifies the name of the entitlement..</param>
        /// <param name="sKUC">Specifies the stock keeping unit..</param>
        /// <param name="startDate">Specifies the start date of the entitlement..</param>
        public AccountEntitlement(bool? dMaaSFreeTrialC = default(bool?), string endDate = default(string), string id = default(string), string name = default(string), string sKUC = default(string), string startDate = default(string))
        {
            this.DMaaSFreeTrialC = dMaaSFreeTrialC;
            this.EndDate = endDate;
            this.Id = id;
            this.Name = name;
            this.SKUC = sKUC;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// Specifies whether DMaaS free trail is active.
        /// </summary>
        /// <value>Specifies whether DMaaS free trail is active.</value>
        [DataMember(Name="DMaaS_Free_Trial__c", EmitDefaultValue=false)]
        public bool? DMaaSFreeTrialC { get; set; }

        /// <summary>
        /// Specifies the end date of the entitlement.
        /// </summary>
        /// <value>Specifies the end date of the entitlement.</value>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Specifies the entitlement ID.
        /// </summary>
        /// <value>Specifies the entitlement ID.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the name of the entitlement.
        /// </summary>
        /// <value>Specifies the name of the entitlement.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the stock keeping unit.
        /// </summary>
        /// <value>Specifies the stock keeping unit.</value>
        [DataMember(Name="SKU__c", EmitDefaultValue=false)]
        public string SKUC { get; set; }

        /// <summary>
        /// Specifies the start date of the entitlement.
        /// </summary>
        /// <value>Specifies the start date of the entitlement.</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

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
            return this.Equals(input as AccountEntitlement);
        }

        /// <summary>
        /// Returns true if AccountEntitlement instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountEntitlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountEntitlement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DMaaSFreeTrialC == input.DMaaSFreeTrialC ||
                    (this.DMaaSFreeTrialC != null &&
                    this.DMaaSFreeTrialC.Equals(input.DMaaSFreeTrialC))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SKUC == input.SKUC ||
                    (this.SKUC != null &&
                    this.SKUC.Equals(input.SKUC))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.DMaaSFreeTrialC != null)
                    hashCode = hashCode * 59 + this.DMaaSFreeTrialC.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SKUC != null)
                    hashCode = hashCode * 59 + this.SKUC.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

    }

}

