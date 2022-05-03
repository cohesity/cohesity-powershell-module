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
    /// Specifies the local or remote node for which system LED details are requested.
    /// </summary>
    [DataContract]
    public partial class ShowSystemLedInfoParameters :  IEquatable<ShowSystemLedInfoParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowSystemLedInfoParameters" /> class.
        /// </summary>
        /// <param name="nodeIp">Optional field. If Node IP is not specified, LED info for the current node is displayed..</param>
        public ShowSystemLedInfoParameters(string nodeIp = default(string))
        {
            this.NodeIp = nodeIp;
        }
        
        /// <summary>
        /// Optional field. If Node IP is not specified, LED info for the current node is displayed.
        /// </summary>
        /// <value>Optional field. If Node IP is not specified, LED info for the current node is displayed.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=false)]
        public string NodeIp { get; set; }

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
            return this.Equals(input as ShowSystemLedInfoParameters);
        }

        /// <summary>
        /// Returns true if ShowSystemLedInfoParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowSystemLedInfoParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowSystemLedInfoParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
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
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                return hashCode;
            }
        }

    }

}

