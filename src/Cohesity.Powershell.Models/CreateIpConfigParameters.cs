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
    /// Specifies the parameters needed for an ipconfig request.
    /// </summary>
    [DataContract]
    public partial class CreateIpConfigParameters :  IEquatable<CreateIpConfigParameters>
    {
        /// <summary>
        /// Specifies the interface role. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.
        /// </summary>
        /// <value>Specifies the interface role. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum KPrimary for value: kPrimary
            /// </summary>
            [EnumMember(Value = "kPrimary")]
            KPrimary = 1,

            /// <summary>
            /// Enum KSecondary for value: kSecondary
            /// </summary>
            [EnumMember(Value = "kSecondary")]
            KSecondary = 2

        }

        /// <summary>
        /// Specifies the interface role. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.
        /// </summary>
        /// <value>Specifies the interface role. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIpConfigParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateIpConfigParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIpConfigParameters" /> class.
        /// </summary>
        /// <param name="ips">Specifies the interface ips..</param>
        /// <param name="mtu">Specifies the interface mtu..</param>
        /// <param name="name">Specifies the interface name. (required).</param>
        /// <param name="role">Specifies the interface role. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role..</param>
        /// <param name="subnetGateway">Specifies the interface gateway..</param>
        /// <param name="subnetMask">Specifies the interface subnet mask..</param>
        public CreateIpConfigParameters(List<string> ips = default(List<string>), int? mtu = default(int?), string name = default(string), RoleEnum? role = default(RoleEnum?), string subnetGateway = default(string), string subnetMask = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateIpConfigParameters and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Ips = ips;
            this.Mtu = mtu;
            this.Role = role;
            this.SubnetGateway = subnetGateway;
            this.SubnetMask = subnetMask;
        }
        
        /// <summary>
        /// Specifies the interface ips.
        /// </summary>
        /// <value>Specifies the interface ips.</value>
        [DataMember(Name="ips", EmitDefaultValue=false)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Specifies the interface mtu.
        /// </summary>
        /// <value>Specifies the interface mtu.</value>
        [DataMember(Name="mtu", EmitDefaultValue=false)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the interface name.
        /// </summary>
        /// <value>Specifies the interface name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the interface gateway.
        /// </summary>
        /// <value>Specifies the interface gateway.</value>
        [DataMember(Name="subnetGateway", EmitDefaultValue=false)]
        public string SubnetGateway { get; set; }

        /// <summary>
        /// Specifies the interface subnet mask.
        /// </summary>
        /// <value>Specifies the interface subnet mask.</value>
        [DataMember(Name="subnetMask", EmitDefaultValue=false)]
        public string SubnetMask { get; set; }

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
            return this.Equals(input as CreateIpConfigParameters);
        }

        /// <summary>
        /// Returns true if CreateIpConfigParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateIpConfigParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateIpConfigParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    this.Ips.Equals(input.Ips)
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.SubnetGateway == input.SubnetGateway ||
                    (this.SubnetGateway != null &&
                    this.SubnetGateway.Equals(input.SubnetGateway))
                ) && 
                (
                    this.SubnetMask == input.SubnetMask ||
                    (this.SubnetMask != null &&
                    this.SubnetMask.Equals(input.SubnetMask))
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
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.SubnetGateway != null)
                    hashCode = hashCode * 59 + this.SubnetGateway.GetHashCode();
                if (this.SubnetMask != null)
                    hashCode = hashCode * 59 + this.SubnetMask.GetHashCode();
                return hashCode;
            }
        }

    }

}

