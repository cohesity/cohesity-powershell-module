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
    /// Specifies the remote host where the remote scripts are executed. This field must be set for Remote Adapter Jobs.
    /// </summary>
    [DataContract]
    public partial class RemoteHost_ :  IEquatable<RemoteHost_>
    {
        /// <summary>
        /// Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,
            
            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2
        }

        /// <summary>
        /// Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteHost_" /> class.
        /// </summary>
        /// <param name="address">Specifies the address (IP, hostname or FQDN) of the remote host that will run the script..</param>
        /// <param name="type">Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        public RemoteHost_(string address = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Address = address;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the address (IP, hostname or FQDN) of the remote host that will run the script.
        /// </summary>
        /// <value>Specifies the address (IP, hostname or FQDN) of the remote host that will run the script.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


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
            return this.Equals(input as RemoteHost_);
        }

        /// <summary>
        /// Returns true if RemoteHost_ instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteHost_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteHost_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

