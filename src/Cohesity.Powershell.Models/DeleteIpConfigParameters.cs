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
    /// Specifies the parameters needed for an ipunconfig request.
    /// </summary>
    [DataContract]
    public partial class DeleteIpConfigParameters :  IEquatable<DeleteIpConfigParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteIpConfigParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteIpConfigParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteIpConfigParameters" /> class.
        /// </summary>
        /// <param name="name">Specifies the interface name to be deleted. (required).</param>
        public DeleteIpConfigParameters(string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DeleteIpConfigParameters and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// Specifies the interface name to be deleted.
        /// </summary>
        /// <value>Specifies the interface name to be deleted.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as DeleteIpConfigParameters);
        }

        /// <summary>
        /// Returns true if DeleteIpConfigParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteIpConfigParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteIpConfigParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

