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
    /// CloseSmbFileOpenParameters
    /// </summary>
    [DataContract]
    public partial class CloseSmbFileOpenParameters :  IEquatable<CloseSmbFileOpenParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloseSmbFileOpenParameters" /> class.
        /// </summary>
        /// <param name="filePath">Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified..</param>
        /// <param name="openId">Specifies the id of the active open..</param>
        /// <param name="viewName">Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified..</param>
        public CloseSmbFileOpenParameters(string filePath = default(string), long? openId = default(long?), string viewName = default(string))
        {
            this.FilePath = filePath;
            this.OpenId = openId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified.
        /// </summary>
        /// <value>Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified.</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Specifies the id of the active open.
        /// </summary>
        /// <value>Specifies the id of the active open.</value>
        [DataMember(Name="openId", EmitDefaultValue=false)]
        public long? OpenId { get; set; }

        /// <summary>
        /// Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified.
        /// </summary>
        /// <value>Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

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
            return this.Equals(input as CloseSmbFileOpenParameters);
        }

        /// <summary>
        /// Returns true if CloseSmbFileOpenParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CloseSmbFileOpenParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloseSmbFileOpenParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
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
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.OpenId != null)
                    hashCode = hashCode * 59 + this.OpenId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

