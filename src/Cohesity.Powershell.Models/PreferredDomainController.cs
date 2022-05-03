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
    /// Specifies Preferred domain controllers (DCs) for an Active Directory domain.
    /// </summary>
    [DataContract]
    public partial class PreferredDomainController :  IEquatable<PreferredDomainController>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreferredDomainController" /> class.
        /// </summary>
        /// <param name="domainControllers">List of Domain controllers DCs in FQDN format that are mapped to an Active Directory Domain name..</param>
        /// <param name="domainName">Specifies the Domain name or the trusted domain of an Active Directory..</param>
        public PreferredDomainController(List<string> domainControllers = default(List<string>), string domainName = default(string))
        {
            this.DomainControllers = domainControllers;
            this.DomainName = domainName;
        }
        
        /// <summary>
        /// List of Domain controllers DCs in FQDN format that are mapped to an Active Directory Domain name.
        /// </summary>
        /// <value>List of Domain controllers DCs in FQDN format that are mapped to an Active Directory Domain name.</value>
        [DataMember(Name="domainControllers", EmitDefaultValue=false)]
        public List<string> DomainControllers { get; set; }

        /// <summary>
        /// Specifies the Domain name or the trusted domain of an Active Directory.
        /// </summary>
        /// <value>Specifies the Domain name or the trusted domain of an Active Directory.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

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
            return this.Equals(input as PreferredDomainController);
        }

        /// <summary>
        /// Returns true if PreferredDomainController instances are equal
        /// </summary>
        /// <param name="input">Instance of PreferredDomainController to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreferredDomainController input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainControllers == input.DomainControllers ||
                    this.DomainControllers != null &&
                    this.DomainControllers.Equals(input.DomainControllers)
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
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
                if (this.DomainControllers != null)
                    hashCode = hashCode * 59 + this.DomainControllers.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                return hashCode;
            }
        }

    }

}

