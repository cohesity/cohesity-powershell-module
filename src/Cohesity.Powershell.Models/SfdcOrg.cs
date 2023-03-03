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
    /// Specifies an Object containing information about a Salesforce Org.
    /// </summary>
    [DataContract]
    public partial class SfdcOrg :  IEquatable<SfdcOrg>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcOrg" /> class.
        /// </summary>
        /// <param name="orgId">String id of the organization to which Sfdc user belongs..</param>
        public SfdcOrg(string orgId = default(string))
        {
            this.OrgId = orgId;
            this.OrgId = orgId;
        }
        
        /// <summary>
        /// String id of the organization to which Sfdc user belongs.
        /// </summary>
        /// <value>String id of the organization to which Sfdc user belongs.</value>
        [DataMember(Name="orgId", EmitDefaultValue=true)]
        public string OrgId { get; set; }

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
            return this.Equals(input as SfdcOrg);
        }

        /// <summary>
        /// Returns true if SfdcOrg instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcOrg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcOrg input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrgId == input.OrgId ||
                    (this.OrgId != null &&
                    this.OrgId.Equals(input.OrgId))
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
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                return hashCode;
            }
        }

    }

}

