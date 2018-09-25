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
    /// Specifies a list of principals to set access permissions for. For each principal, set the Protection Sources and View names that the specified principal has permissions to access.
    /// </summary>
    [DataContract]
    public partial class UpdateSourcesForPrincipalsParams :  IEquatable<UpdateSourcesForPrincipalsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSourcesForPrincipalsParams" /> class.
        /// </summary>
        /// <param name="sourcesForPrincipals">Specifies a list of principals. For each principal, specify the Protection Sources and Views that the principal has permissions to access..</param>
        public UpdateSourcesForPrincipalsParams(List<SourceForPrincipalParam> sourcesForPrincipals = default(List<SourceForPrincipalParam>))
        {
            this.SourcesForPrincipals = sourcesForPrincipals;
        }
        
        /// <summary>
        /// Specifies a list of principals. For each principal, specify the Protection Sources and Views that the principal has permissions to access.
        /// </summary>
        /// <value>Specifies a list of principals. For each principal, specify the Protection Sources and Views that the principal has permissions to access.</value>
        [DataMember(Name="sourcesForPrincipals", EmitDefaultValue=false)]
        public List<SourceForPrincipalParam> SourcesForPrincipals { get; set; }

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
            return this.Equals(input as UpdateSourcesForPrincipalsParams);
        }

        /// <summary>
        /// Returns true if UpdateSourcesForPrincipalsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSourcesForPrincipalsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSourcesForPrincipalsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourcesForPrincipals == input.SourcesForPrincipals ||
                    this.SourcesForPrincipals != null &&
                    this.SourcesForPrincipals.SequenceEqual(input.SourcesForPrincipals)
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
                if (this.SourcesForPrincipals != null)
                    hashCode = hashCode * 59 + this.SourcesForPrincipals.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

