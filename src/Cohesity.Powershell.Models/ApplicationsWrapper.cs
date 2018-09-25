// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// ApplicationsWrapper is the struct to define the list of map-reduce applications.
    /// </summary>
    [DataContract]
    public partial class ApplicationsWrapper :  IEquatable<ApplicationsWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsWrapper" /> class.
        /// </summary>
        /// <param name="applications">Applications specifies the list of available map-reduce applications in analytics workbench..</param>
        public ApplicationsWrapper(List<MapReduceInfo> applications = default(List<MapReduceInfo>))
        {
            this.Applications = applications;
        }
        
        /// <summary>
        /// Applications specifies the list of available map-reduce applications in analytics workbench.
        /// </summary>
        /// <value>Applications specifies the list of available map-reduce applications in analytics workbench.</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<MapReduceInfo> Applications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ApplicationsWrapper);
        }

        /// <summary>
        /// Returns true if ApplicationsWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

