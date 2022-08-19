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
    /// VMwareBackupEnvParamsVAppChildVMsList
    /// </summary>
    [DataContract]
    public partial class VMwareBackupEnvParamsVAppChildVMsList :  IEquatable<VMwareBackupEnvParamsVAppChildVMsList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareBackupEnvParamsVAppChildVMsList" /> class.
        /// </summary>
        /// <param name="vappEntityId">vApp entity id..</param>
        /// <param name="vmEntityIds">List of entity ids of all child VMs under vApp with id &#39;vapp_entity_id&#39;..</param>
        public VMwareBackupEnvParamsVAppChildVMsList(long? vappEntityId = default(long?), List<long> vmEntityIds = default(List<long>))
        {
            this.VappEntityId = vappEntityId;
            this.VmEntityIds = vmEntityIds;
            this.VappEntityId = vappEntityId;
            this.VmEntityIds = vmEntityIds;
        }
        
        /// <summary>
        /// vApp entity id.
        /// </summary>
        /// <value>vApp entity id.</value>
        [DataMember(Name="vappEntityId", EmitDefaultValue=true)]
        public long? VappEntityId { get; set; }

        /// <summary>
        /// List of entity ids of all child VMs under vApp with id &#39;vapp_entity_id&#39;.
        /// </summary>
        /// <value>List of entity ids of all child VMs under vApp with id &#39;vapp_entity_id&#39;.</value>
        [DataMember(Name="vmEntityIds", EmitDefaultValue=true)]
        public List<long> VmEntityIds { get; set; }

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
            return this.Equals(input as VMwareBackupEnvParamsVAppChildVMsList);
        }

        /// <summary>
        /// Returns true if VMwareBackupEnvParamsVAppChildVMsList instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareBackupEnvParamsVAppChildVMsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareBackupEnvParamsVAppChildVMsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VappEntityId == input.VappEntityId ||
                    (this.VappEntityId != null &&
                    this.VappEntityId.Equals(input.VappEntityId))
                ) && 
                (
                    this.VmEntityIds == input.VmEntityIds ||
                    this.VmEntityIds != null &&
                    input.VmEntityIds != null &&
                    this.VmEntityIds.Equals(input.VmEntityIds)
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
                if (this.VappEntityId != null)
                    hashCode = hashCode * 59 + this.VappEntityId.GetHashCode();
                if (this.VmEntityIds != null)
                    hashCode = hashCode * 59 + this.VmEntityIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

