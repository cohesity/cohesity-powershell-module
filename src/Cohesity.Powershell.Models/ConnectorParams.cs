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
    /// Specifies the parameters required to establish a connection with a particular environment.
    /// </summary>
    [DataContract]
    public partial class ConnectorParams :  IEquatable<ConnectorParams>
    {

        /// <summary>
        /// Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParams" /> class.
        /// </summary>
        /// <param name="endpoint">Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment)..</param>
        /// <param name="environment">Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="id">Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params..</param>
        /// <param name="version">Version is updated each time the connector parameters are updated. This is used to discard older connector parameters..</param>
        public ConnectorParams(string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), long? id = default(long?), long? version = default(long?))
        {
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.Id = id;
            this.Version = version;
        }
        
        /// <summary>
        /// Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment).
        /// </summary>
        /// <value>Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment).</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }


        /// <summary>
        /// Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params.
        /// </summary>
        /// <value>Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Version is updated each time the connector parameters are updated. This is used to discard older connector parameters.
        /// </summary>
        /// <value>Version is updated each time the connector parameters are updated. This is used to discard older connector parameters.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(input as ConnectorParams);
        }

        /// <summary>
        /// Returns true if ConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

