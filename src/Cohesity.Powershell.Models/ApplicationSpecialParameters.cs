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
    /// Specifies additional special settings applicable for a Protection Source of &#39;kSQL&#39;/&#39;kOracle&#39; type in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class ApplicationSpecialParameters :  IEquatable<ApplicationSpecialParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSpecialParameters" /> class.
        /// </summary>
        /// <param name="applicationEntityIds">Array of Ids of Application Entities like SQL/Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like SQL/Oracle instances, and databases to protect in a Protection Source of type &#39;kSQL&#39;/&#39;kOracle&#39;. If not specified, all application entities on the Protection Source..</param>
        public ApplicationSpecialParameters(List<long> applicationEntityIds = default(List<long>))
        {
            this.ApplicationEntityIds = applicationEntityIds;
            this.ApplicationEntityIds = applicationEntityIds;
        }
        
        /// <summary>
        /// Array of Ids of Application Entities like SQL/Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like SQL/Oracle instances, and databases to protect in a Protection Source of type &#39;kSQL&#39;/&#39;kOracle&#39;. If not specified, all application entities on the Protection Source.
        /// </summary>
        /// <value>Array of Ids of Application Entities like SQL/Oracle instances, and databases that should be protected in a Protection Source.  Specifies the subset of application entities like SQL/Oracle instances, and databases to protect in a Protection Source of type &#39;kSQL&#39;/&#39;kOracle&#39;. If not specified, all application entities on the Protection Source.</value>
        [DataMember(Name="applicationEntityIds", EmitDefaultValue=true)]
        public List<long> ApplicationEntityIds { get; set; }

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
            return this.Equals(input as ApplicationSpecialParameters);
        }

        /// <summary>
        /// Returns true if ApplicationSpecialParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationSpecialParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationSpecialParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationEntityIds == input.ApplicationEntityIds ||
                    this.ApplicationEntityIds != null &&
                    input.ApplicationEntityIds != null &&
                    this.ApplicationEntityIds.Equals(input.ApplicationEntityIds)
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
                if (this.ApplicationEntityIds != null)
                    hashCode = hashCode * 59 + this.ApplicationEntityIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

