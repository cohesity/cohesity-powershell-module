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
    /// Oracle Database Node.  Specifies database node required for the backup and restore.
    /// </summary>
    [DataContract]
    public partial class OracleDatabaseNode :  IEquatable<OracleDatabaseNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDatabaseNode" /> class.
        /// </summary>
        /// <param name="channelCount">Specifies the number of channels user wants for the backup/recovery of this node..</param>
        /// <param name="node">Specifies the ip of the database node..</param>
        /// <param name="port">Specifies the port on which user wants to run the backup/recovery..</param>
        public OracleDatabaseNode(int? channelCount = default(int?), string node = default(string), long? port = default(long?))
        {
            this.ChannelCount = channelCount;
            this.Node = node;
            this.Port = port;
            this.ChannelCount = channelCount;
            this.Node = node;
            this.Port = port;
        }
        
        /// <summary>
        /// Specifies the number of channels user wants for the backup/recovery of this node.
        /// </summary>
        /// <value>Specifies the number of channels user wants for the backup/recovery of this node.</value>
        [DataMember(Name="channelCount", EmitDefaultValue=true)]
        public int? ChannelCount { get; set; }

        /// <summary>
        /// Specifies the ip of the database node.
        /// </summary>
        /// <value>Specifies the ip of the database node.</value>
        [DataMember(Name="node", EmitDefaultValue=true)]
        public string Node { get; set; }

        /// <summary>
        /// Specifies the port on which user wants to run the backup/recovery.
        /// </summary>
        /// <value>Specifies the port on which user wants to run the backup/recovery.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public long? Port { get; set; }

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
            return this.Equals(input as OracleDatabaseNode);
        }

        /// <summary>
        /// Returns true if OracleDatabaseNode instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDatabaseNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDatabaseNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelCount == input.ChannelCount ||
                    (this.ChannelCount != null &&
                    this.ChannelCount.Equals(input.ChannelCount))
                ) && 
                (
                    this.Node == input.Node ||
                    (this.Node != null &&
                    this.Node.Equals(input.Node))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.ChannelCount != null)
                    hashCode = hashCode * 59 + this.ChannelCount.GetHashCode();
                if (this.Node != null)
                    hashCode = hashCode * 59 + this.Node.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

