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
    /// Specifies the Quality of Service (QoS) Policy for the View.
    /// </summary>
    [DataContract]
    public partial class QoS :  IEquatable<QoS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QoS" /> class.
        /// </summary>
        /// <param name="principalId">Specifies the name of the QoS Policy used for the View..</param>
        /// <param name="principalName">Specifies the name of the QoS Policy used for the View such as &#39;TestAndDev High&#39;, &#39;Backup Target SSD&#39;, &#39;Backup Target High&#39; &#39;TestAndDev Low&#39; and &#39;Backup Target Low&#39;. For a complete list and descriptions, see the &#39;Create or Edit Views&#39; topic in the documentation. If not specified, the default is &#39;Backup Target Low&#39;..</param>
        public QoS(long? principalId = default(long?), string principalName = default(string))
        {
            this.PrincipalId = principalId;
            this.PrincipalName = principalName;
        }
        
        /// <summary>
        /// Specifies the name of the QoS Policy used for the View.
        /// </summary>
        /// <value>Specifies the name of the QoS Policy used for the View.</value>
        [DataMember(Name="principalId", EmitDefaultValue=true)]
        public long? PrincipalId { get; set; }

        /// <summary>
        /// Specifies the name of the QoS Policy used for the View such as &#39;TestAndDev High&#39;, &#39;Backup Target SSD&#39;, &#39;Backup Target High&#39; &#39;TestAndDev Low&#39; and &#39;Backup Target Low&#39;. For a complete list and descriptions, see the &#39;Create or Edit Views&#39; topic in the documentation. If not specified, the default is &#39;Backup Target Low&#39;.
        /// </summary>
        /// <value>Specifies the name of the QoS Policy used for the View such as &#39;TestAndDev High&#39;, &#39;Backup Target SSD&#39;, &#39;Backup Target High&#39; &#39;TestAndDev Low&#39; and &#39;Backup Target Low&#39;. For a complete list and descriptions, see the &#39;Create or Edit Views&#39; topic in the documentation. If not specified, the default is &#39;Backup Target Low&#39;.</value>
        [DataMember(Name="principalName", EmitDefaultValue=true)]
        public string PrincipalName { get; set; }

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
            return this.Equals(input as QoS);
        }

        /// <summary>
        /// Returns true if QoS instances are equal
        /// </summary>
        /// <param name="input">Instance of QoS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QoS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrincipalId == input.PrincipalId ||
                    (this.PrincipalId != null &&
                    this.PrincipalId.Equals(input.PrincipalId))
                ) && 
                (
                    this.PrincipalName == input.PrincipalName ||
                    (this.PrincipalName != null &&
                    this.PrincipalName.Equals(input.PrincipalName))
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
                if (this.PrincipalId != null)
                    hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                return hashCode;
            }
        }

    }

}

