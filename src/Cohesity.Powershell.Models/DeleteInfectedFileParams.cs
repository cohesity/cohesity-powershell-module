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
    /// DeleteInfectedFileParams
    /// </summary>
    [DataContract]
    public partial class DeleteInfectedFileParams :  IEquatable<DeleteInfectedFileParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInfectedFileParams" /> class.
        /// </summary>
        /// <param name="infectedFileIds">Specifies the list of infected file path..</param>
        public DeleteInfectedFileParams(List<InfectedFileParam> infectedFileIds = default(List<InfectedFileParam>))
        {
            this.InfectedFileIds = infectedFileIds;
            this.InfectedFileIds = infectedFileIds;
        }
        
        /// <summary>
        /// Specifies the list of infected file path.
        /// </summary>
        /// <value>Specifies the list of infected file path.</value>
        [DataMember(Name="infectedFileIds", EmitDefaultValue=true)]
        public List<InfectedFileParam> InfectedFileIds { get; set; }

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
            return this.Equals(input as DeleteInfectedFileParams);
        }

        /// <summary>
        /// Returns true if DeleteInfectedFileParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInfectedFileParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInfectedFileParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InfectedFileIds == input.InfectedFileIds ||
                    this.InfectedFileIds != null &&
                    input.InfectedFileIds != null &&
                    this.InfectedFileIds.SequenceEqual(input.InfectedFileIds)
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
                if (this.InfectedFileIds != null)
                    hashCode = hashCode * 59 + this.InfectedFileIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

