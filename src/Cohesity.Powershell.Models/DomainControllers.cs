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
    /// Domain Controllers for a domain of an Active Directory domain.
    /// </summary>
    [DataContract]
    public partial class DomainControllers :  IEquatable<DomainControllers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainControllers" /> class.
        /// </summary>
        /// <param name="domainControllers">Domain Controllers of a domain of an Active Directory domain..</param>
        public DomainControllers(List<string> domainControllers = default(List<string>))
        {
            this._DomainControllers = domainControllers;
            this._DomainControllers = domainControllers;
        }
        
        /// <summary>
        /// Domain Controllers of a domain of an Active Directory domain.
        /// </summary>
        /// <value>Domain Controllers of a domain of an Active Directory domain.</value>
        [DataMember(Name="domainControllers", EmitDefaultValue=true)]
        public List<string> _DomainControllers { get; set; }

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
            return this.Equals(input as DomainControllers);
        }

        /// <summary>
        /// Returns true if DomainControllers instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainControllers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainControllers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._DomainControllers == input._DomainControllers ||
                    this._DomainControllers != null &&
                    input._DomainControllers != null &&
                    this._DomainControllers.SequenceEqual(input._DomainControllers)
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
                if (this._DomainControllers != null)
                    hashCode = hashCode * 59 + this._DomainControllers.GetHashCode();
                return hashCode;
            }
        }

    }

}

