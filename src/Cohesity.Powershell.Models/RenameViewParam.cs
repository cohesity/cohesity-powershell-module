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
    /// RenameViewParam
    /// </summary>
    [DataContract]
    public partial class RenameViewParam :  IEquatable<RenameViewParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameViewParam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RenameViewParam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameViewParam" /> class.
        /// </summary>
        /// <param name="newViewName">Specifies the new name of the View. (required).</param>
        public RenameViewParam(string newViewName = default(string))
        {
            // to ensure "newViewName" is required (not null)
            if (newViewName == null)
            {
                throw new InvalidDataException("newViewName is a required property for RenameViewParam and cannot be null");
            }
            else
            {
                this.NewViewName = newViewName;
            }
        }
        
        /// <summary>
        /// Specifies the new name of the View.
        /// </summary>
        /// <value>Specifies the new name of the View.</value>
        [DataMember(Name="newViewName", EmitDefaultValue=false)]
        public string NewViewName { get; set; }

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
            return this.Equals(input as RenameViewParam);
        }

        /// <summary>
        /// Returns true if RenameViewParam instances are equal
        /// </summary>
        /// <param name="input">Instance of RenameViewParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenameViewParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewViewName == input.NewViewName ||
                    (this.NewViewName != null &&
                    this.NewViewName.Equals(input.NewViewName))
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
                if (this.NewViewName != null)
                    hashCode = hashCode * 59 + this.NewViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

