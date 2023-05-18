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
    /// RestoreAcropolisVMParam
    /// </summary>
    [DataContract]
    public partial class RestoreAcropolisVMParam :  IEquatable<RestoreAcropolisVMParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAcropolisVMParam" /> class.
        /// </summary>
        /// <param name="baseCbtSnapshotInfoProto">baseCbtSnapshotInfoProto.</param>
        /// <param name="networkConfig">networkConfig.</param>
        public RestoreAcropolisVMParam(SnapshotInfoProto baseCbtSnapshotInfoProto = default(SnapshotInfoProto), RestoreAcropolisVMParamNetworkConfigInfo networkConfig = default(RestoreAcropolisVMParamNetworkConfigInfo))
        {
            this.BaseCbtSnapshotInfoProto = baseCbtSnapshotInfoProto;
            this.NetworkConfig = networkConfig;
        }
        
        /// <summary>
        /// Gets or Sets BaseCbtSnapshotInfoProto
        /// </summary>
        [DataMember(Name="baseCbtSnapshotInfoProto", EmitDefaultValue=false)]
        public SnapshotInfoProto BaseCbtSnapshotInfoProto { get; set; }

        /// <summary>
        /// Gets or Sets NetworkConfig
        /// </summary>
        [DataMember(Name="networkConfig", EmitDefaultValue=false)]
        public RestoreAcropolisVMParamNetworkConfigInfo NetworkConfig { get; set; }

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
            return this.Equals(input as RestoreAcropolisVMParam);
        }

        /// <summary>
        /// Returns true if RestoreAcropolisVMParam instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAcropolisVMParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAcropolisVMParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseCbtSnapshotInfoProto == input.BaseCbtSnapshotInfoProto ||
                    (this.BaseCbtSnapshotInfoProto != null &&
                    this.BaseCbtSnapshotInfoProto.Equals(input.BaseCbtSnapshotInfoProto))
                ) && 
                (
                    this.NetworkConfig == input.NetworkConfig ||
                    (this.NetworkConfig != null &&
                    this.NetworkConfig.Equals(input.NetworkConfig))
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
                if (this.BaseCbtSnapshotInfoProto != null)
                    hashCode = hashCode * 59 + this.BaseCbtSnapshotInfoProto.GetHashCode();
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

