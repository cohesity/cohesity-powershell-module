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
    /// Specifies the list of services name.
    /// </summary>
    [DataContract]
    public partial class RestartServicesParams :  IEquatable<RestartServicesParams>
    {
        /// <summary>
        /// Defines ServiceName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 1,

            /// <summary>
            /// Enum KYarn for value: kYarn
            /// </summary>
            [EnumMember(Value = "kYarn")]
            KYarn = 2,

            /// <summary>
            /// Enum KZookeeper for value: kZookeeper
            /// </summary>
            [EnumMember(Value = "kZookeeper")]
            KZookeeper = 3,

            /// <summary>
            /// Enum KApiServer for value: kApiServer
            /// </summary>
            [EnumMember(Value = "kApiServer")]
            KApiServer = 4,

            /// <summary>
            /// Enum KMongoCdp for value: kMongoCdp
            /// </summary>
            [EnumMember(Value = "kMongoCdp")]
            KMongoCdp = 5

        }


        /// <summary>
        /// Specifies the list of services name. &#39;kAll&#39; Specifies to restart all services. &#39;kYarn&#39; Specifies to restart yarn service. &#39;kZookeeper&#39; Specifies to restart Zookeeper service. &#39;kApiServer&#39; Specifies to restart ApiServer service. &#39;kMongoCdp&#39; Specifies to restart MongoCdp service.
        /// </summary>
        /// <value>Specifies the list of services name. &#39;kAll&#39; Specifies to restart all services. &#39;kYarn&#39; Specifies to restart yarn service. &#39;kZookeeper&#39; Specifies to restart Zookeeper service. &#39;kApiServer&#39; Specifies to restart ApiServer service. &#39;kMongoCdp&#39; Specifies to restart MongoCdp service.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=true)]
        public List<ServiceNameEnum> ServiceName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartServicesParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestartServicesParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartServicesParams" /> class.
        /// </summary>
        /// <param name="serviceName">Specifies the list of services name. &#39;kAll&#39; Specifies to restart all services. &#39;kYarn&#39; Specifies to restart yarn service. &#39;kZookeeper&#39; Specifies to restart Zookeeper service. &#39;kApiServer&#39; Specifies to restart ApiServer service. &#39;kMongoCdp&#39; Specifies to restart MongoCdp service. (required).</param>
        public RestartServicesParams(List<ServiceNameEnum> serviceName = default(List<ServiceNameEnum>))
        {
            this.ServiceName = serviceName;
        }
        
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
            return this.Equals(input as RestartServicesParams);
        }

        /// <summary>
        /// Returns true if RestartServicesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestartServicesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestartServicesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceName == input.ServiceName ||
                    this.ServiceName.SequenceEqual(input.ServiceName)
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
                hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                return hashCode;
            }
        }

    }

}

