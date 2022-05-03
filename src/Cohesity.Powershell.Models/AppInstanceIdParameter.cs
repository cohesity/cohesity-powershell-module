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
    /// AppInstanceIdParameter
    /// </summary>
    [DataContract]
    public partial class AppInstanceIdParameter :  IEquatable<AppInstanceIdParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceIdParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppInstanceIdParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceIdParameter" /> class.
        /// </summary>
        /// <param name="appInstanceId">Specifies the app instance Id. In: path (required).</param>
        public AppInstanceIdParameter(long? appInstanceId = default(long?))
        {
            // to ensure "appInstanceId" is required (not null)
            if (appInstanceId == null)
            {
                throw new InvalidDataException("appInstanceId is a required property for AppInstanceIdParameter and cannot be null");
            }
            else
            {
                this.AppInstanceId = appInstanceId;
            }
        }
        
        /// <summary>
        /// Specifies the app instance Id. In: path
        /// </summary>
        /// <value>Specifies the app instance Id. In: path</value>
        [DataMember(Name="appInstanceId", EmitDefaultValue=false)]
        public long? AppInstanceId { get; set; }

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
            return this.Equals(input as AppInstanceIdParameter);
        }

        /// <summary>
        /// Returns true if AppInstanceIdParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInstanceIdParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInstanceIdParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppInstanceId == input.AppInstanceId ||
                    (this.AppInstanceId != null &&
                    this.AppInstanceId.Equals(input.AppInstanceId))
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
                if (this.AppInstanceId != null)
                    hashCode = hashCode * 59 + this.AppInstanceId.GetHashCode();
                return hashCode;
            }
        }

    }

}

