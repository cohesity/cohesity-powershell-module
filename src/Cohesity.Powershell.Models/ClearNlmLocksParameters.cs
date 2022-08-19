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
    /// Specifies parameters required to force clear NLM Locks.
    /// </summary>
    [DataContract]
    public partial class ClearNlmLocksParameters :  IEquatable<ClearNlmLocksParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearNlmLocksParameters" /> class.
        /// </summary>
        /// <param name="clientId">Specifies the id of the client, related NLM locks needs to be clear..</param>
        /// <param name="filePath">Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified..</param>
        /// <param name="viewName">Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified..</param>
        public ClearNlmLocksParameters(string clientId = default(string), string filePath = default(string), string viewName = default(string))
        {
            this.ClientId = clientId;
            this.FilePath = filePath;
            this.ViewName = viewName;
            this.ClientId = clientId;
            this.FilePath = filePath;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the id of the client, related NLM locks needs to be clear.
        /// </summary>
        /// <value>Specifies the id of the client, related NLM locks needs to be clear.</value>
        [DataMember(Name="clientId", EmitDefaultValue=true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified.
        /// </summary>
        /// <value>Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified.</value>
        [DataMember(Name="filePath", EmitDefaultValue=true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified.
        /// </summary>
        /// <value>Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as ClearNlmLocksParameters);
        }

        /// <summary>
        /// Returns true if ClearNlmLocksParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ClearNlmLocksParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClearNlmLocksParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

