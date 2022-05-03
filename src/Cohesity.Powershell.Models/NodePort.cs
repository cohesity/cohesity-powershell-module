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
    /// VmInfo specifies information of a NodePort per service and port combination within an application instance.
    /// </summary>
    [DataContract]
    public partial class NodePort :  IEquatable<NodePort>
    {
        /// <summary>
        /// Specifies use of the nodeport kDefault - No specific service. kHttp - HTTP server. kHttps -  Secure HTTP server. kSsh - Secure shell server.
        /// </summary>
        /// <value>Specifies use of the nodeport kDefault - No specific service. kHttp - HTTP server. kHttps -  Secure HTTP server. kSsh - Secure shell server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TagEnum
        {
            /// <summary>
            /// Enum KDefault for value: kDefault
            /// </summary>
            [EnumMember(Value = "kDefault")]
            KDefault = 1,

            /// <summary>
            /// Enum KHttp for value: kHttp
            /// </summary>
            [EnumMember(Value = "kHttp")]
            KHttp = 2,

            /// <summary>
            /// Enum KHttps for value: kHttps
            /// </summary>
            [EnumMember(Value = "kHttps")]
            KHttps = 3,

            /// <summary>
            /// Enum KSsh for value: kSsh
            /// </summary>
            [EnumMember(Value = "kSsh")]
            KSsh = 4

        }

        /// <summary>
        /// Specifies use of the nodeport kDefault - No specific service. kHttp - HTTP server. kHttps -  Secure HTTP server. kSsh - Secure shell server.
        /// </summary>
        /// <value>Specifies use of the nodeport kDefault - No specific service. kHttp - HTTP server. kHttps -  Secure HTTP server. kSsh - Secure shell server.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public TagEnum? Tag { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodePort" /> class.
        /// </summary>
        /// <param name="isUiPort">isUiPort.</param>
        /// <param name="port">port.</param>
        /// <param name="tag">Specifies use of the nodeport kDefault - No specific service. kHttp - HTTP server. kHttps -  Secure HTTP server. kSsh - Secure shell server..</param>
        public NodePort(bool? isUiPort = default(bool?), int? port = default(int?), TagEnum? tag = default(TagEnum?))
        {
            this.IsUiPort = isUiPort;
            this.Port = port;
            this.Tag = tag;
        }
        
        /// <summary>
        /// Gets or Sets IsUiPort
        /// </summary>
        [DataMember(Name="isUiPort", EmitDefaultValue=false)]
        public bool? IsUiPort { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }


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
            return this.Equals(input as NodePort);
        }

        /// <summary>
        /// Returns true if NodePort instances are equal
        /// </summary>
        /// <param name="input">Instance of NodePort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodePort input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsUiPort == input.IsUiPort ||
                    (this.IsUiPort != null &&
                    this.IsUiPort.Equals(input.IsUiPort))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.IsUiPort != null)
                    hashCode = hashCode * 59 + this.IsUiPort.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }

    }

}

